using Antlr4.Runtime.Tree;

namespace AntlrTests.OwOLang;

[Obsolete("Bad code design, marked for refactoring")]
public class SimpleOwOLangVisitor : IOwOLangVisitor<object> {
    private readonly Dictionary<string, Type> _types = new();
    
    public object Visit(IParseTree tree) {
        throw new NotImplementedException();
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

    public object VisitScript(OwOLangParser.ScriptContext context) {
        throw new NotImplementedException();
    }

    public object VisitFunction(OwOLangParser.FunctionContext context) {
        throw new NotImplementedException();
    }

    public object VisitPrint(OwOLangParser.PrintContext context) {
        throw new NotImplementedException();
    }

    public object VisitLoop_x_times(OwOLangParser.Loop_x_timesContext context) {
        throw new NotImplementedException();
    }

    public object VisitDeclare_new_type(OwOLangParser.Declare_new_typeContext context) {
        throw new NotImplementedException();
    }

    public object VisitDeclare_new_variable(OwOLangParser.Declare_new_variableContext context) {
        throw new NotImplementedException();
    }

    public object VisitSet_variable(OwOLangParser.Set_variableContext context) {
        throw new NotImplementedException();
    }

    public object VisitDeclare_and_set_variable(OwOLangParser.Declare_and_set_variableContext context) {
        throw new NotImplementedException();
    }

    public object VisitExpression(OwOLangParser.ExpressionContext context) {
        var children = context.children;
        
        if (children.Count == 1) {
            return children[0].Accept(this);
        }
        
        if (children.Count == 3) {
            var left = children[0].Accept(this);
            var right = children[2].Accept(this);

            var op = children[1].GetText();

            return op switch {
                "^+^" => (dynamic) left + (dynamic) right,
                "^-^" => (dynamic) left - (dynamic) right,
                "^*^" => (dynamic) left * (dynamic) right,
                "^/^" => (dynamic) left / (dynamic) right,
                "^%^" => (dynamic) left % (dynamic) right,
                "^==^" => (dynamic) left == (dynamic) right,
                "^!=^" => (dynamic) left != (dynamic) right,
                "^<^" => (dynamic) left < (dynamic) right,
                "^>^" => (dynamic) left > (dynamic) right,
                "^<=^" => (dynamic) left <= (dynamic) right,
                "^>=^" => (dynamic) left >= (dynamic) right,
                "^&&^" => (dynamic) left && (dynamic) right,
                "^||^" => (dynamic) left || (dynamic) right,
                "from" => throw new NotImplementedException(),
                _ => throw new Exception($"Unknown operator: {op}")
            };
        }
        
        throw new Exception($"Unknown expression: {context.GetText()}");
    }

    public object VisitType(OwOLangParser.TypeContext context) {
        var value = context.GetText();

        var firstValue = context.children[0].GetText();

        if (firstValue.StartsWith("lotz da")) {
            var type = (Type) context.children[1].Accept(this);

            dynamic list = Activator.CreateInstance(typeof(List<>).MakeGenericType(type));

            return list.GetType();
        }

        Type DetermineType() {
            var name = context.id().Accept(this);
            
            if (_types.TryGetValue(name.ToString(), out var type)) {
                return type;
            }
            
            var systemType = Type.GetType(name.ToString());
            
            return systemType ?? throw new Exception($"Unknown type: {name}");
        }

        return value switch {
            "numbah" => typeof(int),
            "dottynumbah" => typeof(float),
            "textz" => typeof(string),
            "opinionz" => typeof(bool),
            "idc" => typeof(object),
            _ => DetermineType()
        };
    }

    public object VisitPrimitives(OwOLangParser.PrimitivesContext context) {
        var value = context.children[0];

        return value switch {
            OwOLangParser.IntContext => context.@int().Accept(this),
            OwOLangParser.FloatContext => context.@float().Accept(this),
            OwOLangParser.StringContext => context.@string().Accept(this),
            OwOLangParser.BoolContext => context.@bool().Accept(this),
            _ => throw new Exception($"Unknown primitive type: {value}")
        };
    }

    public object VisitId(OwOLangParser.IdContext context) {
        return context.GetText();
    }

    public object VisitInt(OwOLangParser.IntContext context) {
        var value = context.GetText();
        int.TryParse(value, out var result);

        return result;
    }

    public object VisitFloat(OwOLangParser.FloatContext context) {
        var value = context.GetText();
        float.TryParse(value, out var result);

        return result;
    }

    public object VisitString(OwOLangParser.StringContext context) {
        return context.GetText();
    }

    public object VisitBool(OwOLangParser.BoolContext context) {
        var value = context.GetText();

        return value switch {
            "yaya" => true,
            "nah" => false,
            _ => throw new Exception($"Unknown bool value: {value}")
        };
    }
}