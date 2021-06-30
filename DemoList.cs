using static DemoParser;
using Elasticsearch.Net;
using Antlr4.Runtime.Misc;
using System.Collections.Generic;
using System.Linq;

using Nest;
using System.IO;
using System;

namespace dslq
{


    public class DemoList : DemoBaseListener
    {



        public Stack<QueryContainer> Stack { get; set; } = new Stack<QueryContainer>();
        public ElasticLowLevelClient client = new ElasticLowLevelClient();
         
        public DemoList()
        {

        }
        public override void ExitCompareExp(CompareExpContext c)
        {


            var attrName = c.propertyName.GetText();
            var attrValue = c.propertyValue.GetText().Trim();
            var temrsQuery = new TermQuery();
           
           var query2 = Query<dynamic>
				.Bool(b => b.Must(new QueryContainer[] {
				Query<string>
				.Terms(q => q.Field("sample")
				.Terms(new string[] { "a", "b" }))}));
            Stack.Push(query2);
        }



        public override void ExitAndLogicalExp([NotNull] AndLogicalExpContext context)
        {


            var left = Stack.Pop();
            var right = Stack.Pop();

               var query2 = Query<dynamic>
				.Bool(b => b.Must(new[]{left,right}));
                
            Stack.Push(left);
            Stack.Push(right);
            Stack.Push(query2);
           

        }

        public override void ExitOrLogicalExp([NotNull] OrLogicalExpContext context)
        {
             var left = Stack.Pop();
             var right = Stack.Pop();
            var query2 = Query<dynamic>
				.Bool(b => b.Should(new[]{left,right}));
                  Stack.Push(left);
            Stack.Push(right);
            Stack.Push(query2);

        }


        public override void ExitStart([NotNull] StartContext context)
        {
                var r=PrintQuery(GetClient(),Stack.Peek());
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
                return  System.Text.Encoding.UTF8.GetString(ms.ToArray());
            }

        }



    }
}