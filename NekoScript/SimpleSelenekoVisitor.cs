using Antlr4.Runtime.Tree;

namespace AntlrTests.NekoScript;

public class SimpleSelenekoVisitor : ISelenekoVisitor<object> {
    private Stack<string> _translationStack = new();

    public object Visit(IParseTree tree) {
        tree.Accept(this);

        foreach (var s in _translationStack) {
            Console.WriteLine(s);
        }
        
        return null;
    }

    public object VisitChildren(IRuleNode node) {
        return node.Accept(this);
    }

    public object VisitTerminal(ITerminalNode node) {
        return node.GetText();
    }

    public object VisitErrorNode(IErrorNode node) {
        return node.GetText();
    }

    public object VisitChunk(SelenekoParser.ChunkContext context) {
        context.block().Accept(this);

        return null;
    }

    public object VisitBlock(SelenekoParser.BlockContext context) {
        try {
            foreach (var statContext in context.stat()) {
                statContext.Accept(this);
            }
        }
        catch (Exception e) {
            Console.Error.WriteLine(e);
        }

        try {
            context.laststat().Accept(this);
        }
        catch (Exception) {
            // ignored
        }

        return null;
    }

    public object VisitStat(SelenekoParser.StatContext context) {
        var output = string.Empty;
        
        var firstChild = context.GetChild(0);

        if (firstChild is SelenekoParser.VarlistContext varlistContext) {
            var varlist = (List<IParseTree>) context.varlist().Accept(this);
            var explist = (List<IParseTree>) context.explist().Accept(this);
            
            var varlistParsed = varlist.Select(v => v.Accept(this)).ToList();
            var explistParsed = explist.Select(e => e.Accept(this)).ToList();

            if (varlistParsed.Count > 0) {
                output += "var ";
            }
            
            for(var i=0; i<varlistParsed.Count; i++) {
                output += $"{varlistParsed[i]} = {explistParsed[i]},";
            }
            
            output = output.TrimEnd(',');
            output += ";";
            
            _translationStack.Push(output);
        }

        return null;
    }

    public object VisitNative_call(SelenekoParser.Native_callContext context) {
        throw new NotImplementedException();
    }

    public object VisitAttnamelist(SelenekoParser.AttnamelistContext context) {
        throw new NotImplementedException();
    }

    public object VisitAttrib(SelenekoParser.AttribContext context) {
        throw new NotImplementedException();
    }

    public object VisitLaststat(SelenekoParser.LaststatContext context) {
        throw new NotImplementedException();
    }

    public object VisitLabel(SelenekoParser.LabelContext context) {
        throw new NotImplementedException();
    }

    public object VisitFuncname(SelenekoParser.FuncnameContext context) {
        throw new NotImplementedException();
    }

    public object VisitVarlist(SelenekoParser.VarlistContext context) {
        return context.children.Where(c => c is SelenekoParser.VarContext).ToList();
    }

    public object VisitNamelist(SelenekoParser.NamelistContext context) {
        throw new NotImplementedException();
    }

    public object VisitExplist(SelenekoParser.ExplistContext context) {
        return context.children.Where(c => c is SelenekoParser.ExpContext).ToList();
    }

    public object VisitExp(SelenekoParser.ExpContext context) {
        var firstChild = context.GetChild(0);

        if (firstChild is TerminalNodeImpl terminalNode) {
            return terminalNode.GetText() switch {
                "nil" => "null",
                "false" => "false",
                "true" => "true",
                "..." => "...",
                _ => throw new NotImplementedException()
            };
        }

        throw new NotImplementedException();
    }

    public object VisitPrefixexp(SelenekoParser.PrefixexpContext context) {
        throw new NotImplementedException();
    }

    public object VisitFunctioncall(SelenekoParser.FunctioncallContext context) {
        throw new NotImplementedException();
    }

    public object VisitVarOrExp(SelenekoParser.VarOrExpContext context) {
        throw new NotImplementedException();
    }

    public object VisitVar(SelenekoParser.VarContext context) {
        throw new NotImplementedException();
    }

    public object VisitVarSuffix(SelenekoParser.VarSuffixContext context) {
        throw new NotImplementedException();
    }

    public object VisitNameAndArgs(SelenekoParser.NameAndArgsContext context) {
        throw new NotImplementedException();
    }

    public object VisitArgs(SelenekoParser.ArgsContext context) {
        throw new NotImplementedException();
    }

    public object VisitFunctiondef(SelenekoParser.FunctiondefContext context) {
        throw new NotImplementedException();
    }

    public object VisitFuncbody(SelenekoParser.FuncbodyContext context) {
        throw new NotImplementedException();
    }

    public object VisitParlist(SelenekoParser.ParlistContext context) {
        throw new NotImplementedException();
    }

    public object VisitTableconstructor(SelenekoParser.TableconstructorContext context) {
        throw new NotImplementedException();
    }

    public object VisitFieldlist(SelenekoParser.FieldlistContext context) {
        throw new NotImplementedException();
    }

    public object VisitField(SelenekoParser.FieldContext context) {
        throw new NotImplementedException();
    }

    public object VisitFieldsep(SelenekoParser.FieldsepContext context) {
        return context.GetText();
    }

    public object VisitOperatorOr(SelenekoParser.OperatorOrContext context) {
        return context.GetText();
    }

    public object VisitOperatorAnd(SelenekoParser.OperatorAndContext context) {
        return context.GetText();
    }

    public object VisitOperatorComparison(SelenekoParser.OperatorComparisonContext context) {
        return context.GetText();
    }

    public object VisitOperatorStrcat(SelenekoParser.OperatorStrcatContext context) {
        return context.GetText();
    }

    public object VisitOperatorAddSub(SelenekoParser.OperatorAddSubContext context) {
        return context.GetText();
    }

    public object VisitOperatorMulDivMod(SelenekoParser.OperatorMulDivModContext context) {
        return context.GetText();
    }

    public object VisitOperatorBitwise(SelenekoParser.OperatorBitwiseContext context) {
        return context.GetText();
    }

    public object VisitOperatorUnary(SelenekoParser.OperatorUnaryContext context) {
        return context.GetText();
    }

    public object VisitOperatorPower(SelenekoParser.OperatorPowerContext context) {
        return context.GetText();
    }

    public object VisitNumber(SelenekoParser.NumberContext context) {
        return context.GetText();
    }

    public object VisitString(SelenekoParser.StringContext context) {
        return new NotImplementedException();
    }
}