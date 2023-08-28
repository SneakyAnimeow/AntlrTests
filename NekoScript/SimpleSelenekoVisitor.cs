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

        //If the first child is a varlist, then it's a global variable declaration
        if (firstChild is SelenekoParser.VarlistContext varlistContext) {
            var varlist = (List<IParseTree>) context.varlist().Accept(this);
            var explist = (List<IParseTree>) context.explist().Accept(this);
            
            var varlistParsed = varlist.Select(v => v.Accept(this)).ToList();
            var explistParsed = explist.Select(e => e.Accept(this)).ToList();

            //Commented out because it's not needed
            // if (varlistParsed.Count > 0) {
            //     output += "var ";
            // }
            
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
        return context.NAME().Select(n => n.GetText()).ToList();
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
        
        if(firstChild is SelenekoParser.NumberContext numberContext) {
            return numberContext.Accept(this);
        }
        
        if(firstChild is SelenekoParser.StringContext stringContext) {
            return stringContext.Accept(this);
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
        var output = string.Empty;
        var suffixes = context.varSuffix().Select(s => s.Accept(this)).ToList();
        
        var firstChild = context.GetChild(0);
        
        if (firstChild is TerminalNodeImpl terminalNode) {
            output = firstChild.GetText();
        }
        else {
            var exp = context.exp().Accept(this);
            output = $"({exp})";
        }

        return suffixes.Aggregate(output, (current, suffix) => current + suffix);
    }

    public object VisitVarSuffix(SelenekoParser.VarSuffixContext context) {
        var output = string.Empty;
        
        var hasNameAndArgs = context.nameAndArgs() != null;

        if (hasNameAndArgs) {
            var nameAndArgs = context.nameAndArgs().Select(n => n.Accept(this)).ToList();
            output = nameAndArgs.Aggregate(output, (current, nameAndArg) => current + nameAndArg);
        }
        
        var hasExp = context.exp() != null;

        if (hasExp) {
            output += $"[{context.exp().Accept(this)}]";
        }
        else {
            output += $".{context.NAME().GetText()}";
        }
        
        return output;
    }

    public object VisitNameAndArgs(SelenekoParser.NameAndArgsContext context) {
        var firstChild = context.GetChild(0);
        
        var output = string.Empty;
        
        if (firstChild is not SelenekoParser.ArgsContext argsContext) {
            var name = context.NAME().GetText();

            output = $": {name}";
        }
        
        var args = context.args().Accept(this);
        
        return $"{output}{args}";
    }

    public object VisitArgs(SelenekoParser.ArgsContext context) {
        var firstChild = context.GetChild(0);

        return firstChild switch {
            TerminalNodeImpl terminalNode when terminalNode.GetText() == "(" => $"({context.explist().Accept(this)})",
            SelenekoParser.TableconstructorContext tableconstructorContext => tableconstructorContext.Accept(this),
            _ => context.@string().Accept(this)
        };
    }

    public object VisitFunctiondef(SelenekoParser.FunctiondefContext context) {
        throw new NotImplementedException();
    }

    public object VisitFuncbody(SelenekoParser.FuncbodyContext context) {
        throw new NotImplementedException();
    }

    public object VisitParlist(SelenekoParser.ParlistContext context) {
        var firstChild = context.GetChild(0);
        
        if(firstChild is TerminalNodeImpl terminalNode && terminalNode.GetText() == "...") {
            return "...";
        }

        var output = string.Empty;

        var namelist = (List<string>) context.namelist().Accept(this);

        output = namelist.Aggregate(output, (current, name) => current + $"{name},");

        output = output.TrimEnd(',');

        if (context.ChildCount <= 1) return output;
        
        var lastTwoChildren = context.children.ToList().GetRange(context.ChildCount - 2, 2);
            
        if(lastTwoChildren[0] is TerminalNodeImpl child1
           && child1.GetText() == "..." 
           && lastTwoChildren[1] is TerminalNodeImpl child2
           && child2.GetText() == ","){
            output += ", ...";
        }

        return output;
    }

    public object VisitTableconstructor(SelenekoParser.TableconstructorContext context) {
        var fieldlist = context.fieldlist().Accept(this);
        
        return $"{{{fieldlist}}}";
    }

    public object VisitFieldlist(SelenekoParser.FieldlistContext context) {
        var fields = context.field().Select(f => f.Accept(this)).ToList();
        var fieldseps = context.fieldsep().Select(f => f.Accept(this)).ToList();
        
        var output = string.Empty;
        
        for (var i = 0; i < fields.Count; i++) {
            output += $"{fields[i]}{fieldseps[i]}";
        }
        
        return output;
    }

    public object VisitField(SelenekoParser.FieldContext context) {
        var firstChild = context.GetChild(0);
        
        if (firstChild is not TerminalNodeImpl terminalNode) {
            return firstChild.Accept(this);
        }

        if (firstChild.GetText() == "[") {
            return $"[{context.exp(0).Accept(this)}] = {context.exp(1).Accept(this)}";
        }
        
        return $"{context.NAME().GetText()} = {context.exp(0).Accept(this)}";
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
        var output = context.GetText();
        
        if (!int.TryParse(output, out int number)) {
            output += ".0";
        }

        return output;
    }

    public object VisitString(SelenekoParser.StringContext context) {
        var content = context.GetText();

        if (content.StartsWith("[[")) {
            //Remove first and last two characters (the [[ and ]]) and add quotes
            content = $"'{content[2..^2]}'";
        }
        
        return content;
    }
}