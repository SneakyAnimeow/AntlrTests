using Antlr4.Runtime;

namespace AntlrTests.OwOLang; 

public class Program {
    public static void Main() {
        var source = File.ReadAllText("./OwOLang/source.owo");

        Console.WriteLine($"Source:\n{source}");

        var inputStream = new AntlrInputStream(source);
        var lexer = new OwOLangLexer(inputStream);
        var commonTokenStream = new CommonTokenStream(lexer);
        var parser = new OwOLangParser(commonTokenStream);
        var tree = parser.script();

        var visitor = new SimpleOwOLangVisitor();
        visitor.Visit(tree);

        // visitor.Print();
    }
}