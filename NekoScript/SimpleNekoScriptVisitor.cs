using Antlr4.Runtime.Tree;

namespace AntlrTests.NekoScript; 

public class SimpleNekoScriptVisitor : INekoScriptVisitor<object> {
    public object Visit(IParseTree tree) {
        Console.WriteLine(tree.GetChild(1));

        return null;
    }

    public object VisitChildren(IRuleNode node) {
        throw new NotImplementedException();
    }

    public object VisitTerminal(ITerminalNode node) {
        throw new NotImplementedException();
    }

    public object VisitErrorNode(IErrorNode node) {
        throw new NotImplementedException();
    }

    public object VisitProgram(NekoScriptParser.ProgramContext context) {
        throw new NotImplementedException();
    }

    public object VisitStatement(NekoScriptParser.StatementContext context) {
        throw new NotImplementedException();
    }

    public object VisitAssign_statement(NekoScriptParser.Assign_statementContext context) {
        throw new NotImplementedException();
    }

    public object VisitExpression(NekoScriptParser.ExpressionContext context) {
        throw new NotImplementedException();
    }

    public object VisitExpression_list(NekoScriptParser.Expression_listContext context) {
        throw new NotImplementedException();
    }
}