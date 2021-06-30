using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace dslq
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = "price=2000 OR model=\"hyundai\" AND (color=\"red\" OR color=\"blue\")";
            var stream = new AntlrInputStream(q);
            var lexer = new DemoLexer(stream);
            var tokenStream = new CommonTokenStream(lexer);
            var dslParser = new DemoParser(tokenStream);
            var tree = dslParser.start();

            var listener = new DemoList();

            ParseTreeWalker walker = new ParseTreeWalker();
            walker.Walk(listener, tree);
        }
    }
}
