using Antlr4.Runtime;

namespace AntlrTests.TinyC; 

public class Program {
    public static void Main() {
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
    }
}