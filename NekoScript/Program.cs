using Antlr4.Runtime;

namespace AntlrTests.NekoScript; 

public class Program {
    public static void Main() {
        var source = File.ReadAllText("./NekoScript/source.seleneko");

        Console.WriteLine($"Source:\n{source}");

        var inputStream = new AntlrInputStream(source);
        var lexer = new SelenekoLexer(inputStream);
        var commonTokenStream = new CommonTokenStream(lexer);
        var parser = new SelenekoParser(commonTokenStream);
        var tree = parser.chunk();
        
        var visitor = new SimpleSelenekoVisitor();
        
        Console.WriteLine("Result:\n");
        
        visitor.Visit(tree);
        
        //TODO: Use Lua's syntax as base for NekoScript syntax
    }
}