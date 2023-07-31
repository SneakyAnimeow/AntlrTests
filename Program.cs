// See https://aka.ms/new-console-template for more information

using Antlr4.Runtime;
using AntlrTests.TinyC;

var source = File.ReadAllText("./TinyC/source.c");

Console.WriteLine($"Source:\n{source}");

var inputStream = new AntlrInputStream(source);
var lexer = new TinyCLexer(inputStream);
var commonTokenStream = new CommonTokenStream(lexer);
var parser = new TinyCParser(commonTokenStream);
var tree = parser.program();

var visitor = new TinyCVisitor();
visitor.Visit(tree);

visitor.Print();