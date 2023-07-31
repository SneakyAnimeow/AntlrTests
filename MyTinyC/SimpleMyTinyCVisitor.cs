using Antlr4.Runtime.Tree;

namespace AntlrTests.MyTinyC;

public class SimpleMyTinyCVisitor : IMyTinyCVisitor<object?> {
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

    public object VisitProgram(MyTinyCParser.ProgramContext context) {
        // Console.WriteLine("Program started");
        
        return context.children[0].Accept(this);
    }

    public object VisitStatement(MyTinyCParser.StatementContext context) {
        // Console.WriteLine("Statement started");
        
        var children = context.children;

        // Console.WriteLine(string.Join(", ", children.Select(x => x.GetText())));
        
        // skip {}
        if(children.First().GetText() == "{" && children.Last().GetText()=="}") {
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

    public object VisitParen_expr(MyTinyCParser.Paren_exprContext context) {
        // Console.WriteLine("Paren_expr started");

        return context.expr().Accept(this);
    }

    public object VisitExpr(MyTinyCParser.ExprContext context) {
        // Console.WriteLine("Expr started");

        var children = context.children;
        
        // Console.WriteLine(string.Join(", ", children.Select(x => x.GetText())));
        
        if (children.Count == 1) {
            return children[0].Accept(this);
        }
        
        if (children[1].GetText() == "&&") {
            return (children[0].Accept(this) as bool?) == true && (children[2].Accept(this) as bool?) == true;
        }
            
        if (children[1].GetText() == "||") {
            return (children[0].Accept(this) as bool?) == true || (children[2].Accept(this) as bool?) == true;
        }
        
        if (children[0].GetText() == ">>") {
            Console.WriteLine(">> " + children[1].Accept(this));
            return null;
        }

        var left = children[0].Accept(this) as string;
        var right = children[2].Accept(this) as int?;

        _variables[left] = right;

        return null;
    }

    public object VisitTest(MyTinyCParser.TestContext context) {
        // Console.WriteLine("Test started");
        
        if (context.children.Count == 1) {
            return context.children[0].Accept(this);
        }
        
        var left = context.children[0].Accept(this) as dynamic;
        var right = context.children[2].Accept(this) as dynamic;
        
        return context.children[1].GetText() switch {
            "<" => left < right,
            ">" => left > right,
            "<=" => left <= right,
            ">=" => left >= right,
            "==" => left == right,
            "!=" => left != right,
            _ => throw new Exception("Unknown operator")
        };
    }

    public object VisitSum_(MyTinyCParser.Sum_Context context) {
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
            "*" => left * right,
            "/" => left / right,
            "%" => left % right,
            _ => throw new Exception("Unknown operator")
        };
    }

    public object VisitTerm(MyTinyCParser.TermContext context) {
        // Console.WriteLine("Term started");
        
        // Console.WriteLine(string.Join(", ", context.children.Select(x => x.GetText())));
        
        var children = context.children;
        
        if(children.Count == 1) {
            if(children[0] is MyTinyCParser.Id_Context) {
                // Console.WriteLine(children[0].GetText() + " || ACCESSED");
                
                return _variables[children[0].GetText()];
            }
            
            return children[0].Accept(this);
        }

        return context.paren_expr().Accept(this);
    }

    public object VisitId_(MyTinyCParser.Id_Context context) {
        // Console.WriteLine("Id started");

        return context.GetText();
    }

    public object VisitInteger(MyTinyCParser.IntegerContext context) {
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