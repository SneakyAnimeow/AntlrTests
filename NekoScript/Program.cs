using Antlr4.Runtime;

namespace AntlrTests.NekoScript; 

public class Program {
    public static void Main() {
        var source = File.ReadAllText("./NekoScript/source.nekos");

        Console.WriteLine($"Source:\n{source}");

        var inputStream = new AntlrInputStream(source);
        var lexer = new NekoScriptLexer(inputStream);
        var commonTokenStream = new CommonTokenStream(lexer);
        var parser = new NekoScriptParser(commonTokenStream);
        var tree = parser.program();

        var visitor = new SimpleNekoScriptVisitor();
        visitor.Visit(tree);

        // visitor.Print();
    }
}