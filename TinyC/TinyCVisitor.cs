using Antlr4.Runtime.Tree;

namespace AntlrTests.TinyC;

public class TinyCVisitor : ITinyCVisitor<object?> {
    private Dictionary<string, int?> _variables = new ();

    public object Visit(IParseTree tree) {
        // Console.WriteLine("Visit node called");
        
        return tree.Accept(this);
    }

    public object VisitChildren(IRuleNode node) {
        Console.WriteLine("Children node called");
        
        throw new NotImplementedException();
    }

    public object VisitTerminal(ITerminalNode node) {
        Console.WriteLine("Terminal node called");
        
        throw new NotImplementedException();
    }

    public object VisitErrorNode(IErrorNode node) {
        Console.WriteLine("Error node called");
        
        throw new NotImplementedException();
    }

    public object VisitProgram(TinyCParser.ProgramContext context) {
        // Console.WriteLine("Program started");
        
        return context.children[0].Accept(this);
    }

    public object VisitStatement(TinyCParser.StatementContext context) {
        // Console.WriteLine("Statement started");
        
        var children = context.children;

        // Console.WriteLine(string.Join(", ", children.Select(x => x.GetText())));
        
        // skips {} in program's header
        if(context.Parent is TinyCParser.ProgramContext) {
            foreach (var parseTree in children.SkipLast(1).Skip(1)) {
                parseTree.Accept(this);
            }
        }

        if (children.Count == 2) {
            return children[0].Accept(this);
        }

        if (children.Count() == 3) {
            if(children[0].GetText() == "{") {
                return children[1].Accept(this);
            }
            
            if (children[0].GetText() == "if") {
                var parenExpr = children[1].Accept(this) as bool?;
                if(parenExpr == true) {
                    return children[2].Accept(this);
                }
            }
            
            if(children[0].GetText() == "while") {
                var parenExpr = children[1].Accept(this) as bool?;
                while(parenExpr == true) {
                    children[2].Accept(this);
                    parenExpr = children[1].Accept(this) as bool?;
                }
            }
        }
        
        if(children.Count == 5) {
            if(children[0].GetText() == "if") {
                var parenExpr = children[1].Accept(this) as bool?;
                if(parenExpr == true) {
                    return children[2].Accept(this);
                }
                else {
                    return children[4].Accept(this);
                }
            }
            
            if(children[0].GetText() == "do") {
                var parenExpr = children[3].Accept(this) as bool?;
                children[1].Accept(this);
                while(parenExpr == true) {
                    children[3].Accept(this);
                    parenExpr = children[1].Accept(this) as bool?;
                }
            }
        }

        return null;
    }

    public object VisitParen_expr(TinyCParser.Paren_exprContext context) {
        // Console.WriteLine("Paren_expr started");

        return context.expr().Accept(this);
    }

    public object VisitExpr(TinyCParser.ExprContext context) {
        // Console.WriteLine("Expr started");
        
        var children = context.children;
        
        if (children.Count == 1) {
            return children[0].Accept(this);
        }

        var left = children[0].Accept(this) as string;
        var right = children[2].Accept(this) as int?;
        
        _variables[left] = right;

        return null;
    }

    public object VisitTest(TinyCParser.TestContext context) {
        // Console.WriteLine("Test started");
        
        if (context.children.Count == 1) {
            return context.children[0].Accept(this);
        }
        
        var left = context.children[0].Accept(this) as int?;
        var right = context.children[2].Accept(this) as int?;
        
        return context.children[1].GetText() switch {
            "<" => left < right,
            _ => throw new Exception("Unknown operator")
        };
    }

    public object VisitSum_(TinyCParser.Sum_Context context) {
        // Console.WriteLine("Sum started");

        var children = context.children;

        if (children.Count == 1) {
            return children[0].Accept(this);
        }

        var left = children[0].Accept(this) as int?;
        var right = children[2].Accept(this) as int?;

        return children[1].GetText() switch {
            "+" => left + right,
            "-" => left - right,
            _ => throw new Exception("Unknown operator")
        };
    }

    public object VisitTerm(TinyCParser.TermContext context) {
        // Console.WriteLine("Term started");
        
        var children = context.children;
        
        if(children.Count == 1) {
            if(children[0] is TinyCParser.Id_Context) {
                return _variables[children[0].GetText()];
            }
            
            return children[0].Accept(this);
        }

        return context.paren_expr().Accept(this);
    }

    public object VisitId_(TinyCParser.Id_Context context) {
        // Console.WriteLine("Id started");

        return context.GetText();
    }

    public object VisitInteger(TinyCParser.IntegerContext context) {
        // Console.WriteLine("Integer started");
        
        return int.Parse(context.GetText());
    }
    
    public void Print() {
        Console.WriteLine("\n\n====Memory====");
        foreach (var (key, value) in _variables) {
            Console.WriteLine($"{key} = {value}");
        }
    }
}