using Antlr4.Runtime;

namespace AntlrTests.MyTinyC;

public class Program {
    public static void Main() {
        var source = File.ReadAllText("./MyTinyC/source.c");

        Console.WriteLine($"Source:\n{source}\n\nProgram Output:");

        source = source.Replace("🍦", ";");

        var inputStream = new AntlrInputStream(source);
        var lexer = new MyTinyCLexer(inputStream);
        var commonTokenStream = new CommonTokenStream(lexer);
        var parser = new MyTinyCParser(commonTokenStream);
        var tree = parser.program();
        
        var visitor = new SimpleMyTinyCVisitor();
        visitor.Visit(tree);
        
        visitor.Print();
    }
}