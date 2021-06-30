using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Elasticsearch.Net;

using Nest;
using System.IO;
using Newtonsoft.Json.Linq;

namespace dslq
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = @"name=""santosh"" OR price=2000 OR model=""hyundai"" AND (color=""red"" OR color=""blue"")";
            var stream = new AntlrInputStream(q);
            var lexer = new DemoLexer(stream);
            var tokenStream = new CommonTokenStream(lexer);
            var dslParser = new DemoParser(tokenStream);
            var tree = dslParser.start();

            var listener = new DemoList();

            ParseTreeWalker walker = new ParseTreeWalker();
            walker.Walk(listener, tree);
            System.Console.WriteLine(PrintQuery(GetClient(),listener.Stack.Peek()));
        }
          public static IElasticClient GetClient()
        {
            var connection = new InMemoryConnection();
            var connectionPool = new SingleNodeConnectionPool(new Uri("http://localhost:9200"));
            var settings = new ConnectionSettings(connectionPool, connection);
            return new ElasticClient(settings);
        }

        public static string PrintQuery(IElasticClient esClient, QueryContainer search)
        {
            using (var ms = new MemoryStream())
            {
                esClient.SourceSerializer.Serialize(search, ms);
                var s=  System.Text.Encoding.UTF8.GetString(ms.ToArray());
                return JObject.Parse(s).ToString();
            }

        }
    }
}
