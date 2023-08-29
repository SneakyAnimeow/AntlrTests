using Antlr4.Runtime.Tree;

namespace AntlrTests.NekoScript;

public class SimpleSelenekoVisitor : ISelenekoVisitor<object> {
    private Stack<string> _translationStack = new();

    public object Visit(IParseTree tree) {
        tree.Accept(this);

        foreach (var s in _translationStack.Reverse()) {
            Console.Write(s);
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
        var firstChild = context.GetChild(0);

        //If the first child is a varlist, then it's a global variable declaration
        if (firstChild is SelenekoParser.VarlistContext varlistContext) {
            var varlist = (List<IParseTree>) context.varlist().Accept(this);
            var explist = (List<IParseTree>) context.explist().Accept(this);
            
            // var varlistParsed = varlist.Select(v => v.Accept(this)).ToList();
            // var explistParsed = explist.Select(e => e.Accept(this)).ToList();
            //
            // //Commented out because it's not needed
            // // if (varlistParsed.Count > 0) {
            // //     output += "var ";
            // // }
            //
            // for(var i=0; i<varlistParsed.Count; i++) {
            //     output += $"{varlistParsed[i]} = {explistParsed[i]},";
            // }
            //
            // output = output.TrimEnd(',');
            // output += ";";
            //
            // _translationStack.Push(output);
            
            for(var i=0; i<varlist.Count; i++) {
                var varName = varlist[i].Accept(this);
                _translationStack.Push($"{varName} = ");
                
                var exp = explist[i].Accept(this);
                _translationStack.Push(exp.ToString() ?? string.Empty);
                
                _translationStack.Push(";");
            }
        }
        
        if(firstChild is SelenekoParser.Native_callContext nativeCallContext) {
            nativeCallContext.Accept(this);
        }

        return null;
    }

    public object VisitNative_call(SelenekoParser.Native_callContext context) {
        var name = context.NAME().GetText();
        var isExp = context.explist() != null;

        if (name == "call_neko" && isExp) {
            var explist = (List<IParseTree>) context.explist().Accept(this);
            
            var firstExp = explist[0].Accept(this).ToString()![1..^1];
                
            _translationStack.Push($"{firstExp}");
        }

        if (name == "export" && isExp) {
            var operation = string.Empty;
            
            var explist = (List<IParseTree>) context.explist().Accept(this);
            
            var objectToExport = explist[0].Accept(this);
            
            operation += $"$exports";

            if (explist.Count > 1) {
                var nameToExport = explist[1].Accept(this);
                
                operation += $".{nameToExport.ToString()[1..^1]}";
            }
            else {
                operation += $".{objectToExport}";
            }
            
            operation += $" = {objectToExport};";
                
            _translationStack.Push($"{operation}");
        }
        
        //TODO: import
        
        // var output = $"{name}(";
        //
        // output = explist.Select(exp => exp.Accept(this)).Aggregate(output, (current, expParsed) => current + $"{expParsed ?? string.Empty},");
        //
        // output = output.TrimEnd(',');
        //
        // output += ");";
        //
        // return output;
        
        //_translationStack.Push(@"$loader.loadmodule(""neko_bindings"", $loader);");

        return null;
    }

    public object VisitLaststat(SelenekoParser.LaststatContext context) {
        _translationStack.Push($"{context.children[0].Accept(this)} ");
        
        var isExplist = context.explist() != null;
        if (isExplist) {
            var explist = (List<IParseTree>) context.explist().Accept(this);

            foreach (var expParsed in explist.Select(exp => exp.Accept(this))) {
                _translationStack.Push(expParsed.ToString() ?? string.Empty);
            }
        }
        
        _translationStack.Push($";");
        return null;
    }

    public object VisitLabel(SelenekoParser.LabelContext context) {
        var name = context.NAME().GetText();
        
        return $"{name}:";
    }

    public object VisitFuncname(SelenekoParser.FuncnameContext context) {
        var names = context.NAME().Select(n => n.GetText()).ToList();
        
        var output = names.Aggregate(string.Empty, (current, name) => current + $"{name}.");
        
        output = output.TrimEnd('.');
        
        return output;
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
        
        if(firstChild is SelenekoParser.FunctiondefContext functiondefContext) {
            functiondefContext.Accept(this);
            return string.Empty;
        }
        
        if(firstChild is SelenekoParser.PrefixexpContext prefixexpContext) {
            return prefixexpContext.Accept(this);
        }
        
        if(firstChild is SelenekoParser.TableconstructorContext tableconstructorContext) {
            return tableconstructorContext.Accept(this);
        }

        if (context.operatorPower() != null) {
            var exp1 = context.exp(0).Accept(this);
            var exp2 = context.exp(1).Accept(this);
            
            return $"{exp1} {context.operatorPower().Accept(this)} {exp2}";
        }
        
        if (context.operatorUnary() != null) {
            var exp = context.exp(0).Accept(this);
            
            return $"!{exp}";
        }
        
        if (context.operatorMulDivMod() != null) {
            var exp1 = context.exp(0).Accept(this);
            var exp2 = context.exp(1).Accept(this);
            
            return $"{exp1} {context.operatorMulDivMod().Accept(this)} {exp2}";
        }

        throw new NotImplementedException();
    }

    public object VisitPrefixexp(SelenekoParser.PrefixexpContext context) {
        var output = string.Empty;
        
        var varOrExp = context.varOrExp().Accept(this).ToString();
        
        output += varOrExp;
        
        var nameAndArgs = context.nameAndArgs().Select(n => n.Accept(this)).ToList();
        
        output = nameAndArgs.Aggregate(output, (current, nameAndArg) => current + nameAndArg);
        
        return output;
    }

    public object VisitFunctioncall(SelenekoParser.FunctioncallContext context) {
        var output = string.Empty;
        
        var varOrExp = context.varOrExp().Accept(this).ToString();
        
        output += varOrExp;
        
        var nameAndArgs = context.nameAndArgs().Select(n => n.Accept(this)).ToList();
        
        output = nameAndArgs.Aggregate(output, (current, nameAndArg) => current + nameAndArg);
        
        return output;
    }

    public object VisitVarOrExp(SelenekoParser.VarOrExpContext context) {
        var hasVar = context.var() != null;
        
        return hasVar 
            ? context.var().Accept(this) 
            : $"({context.exp().Accept(this)})";
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
        context.funcbody().Accept(this);
        
        return null;
    }

    public object VisitFuncbody(SelenekoParser.FuncbodyContext context) {
        var hasParlist = context.parlist() != null;
        
        var parlist = hasParlist ? context.parlist().Accept(this) : string.Empty;
        
        _translationStack.Push($"function({parlist}) {{");

        context.block().Accept(this);
        
        _translationStack.Push("}");
        
        return null;
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
        
        if(float.TryParse(output, out float floatNumber)) {
            return output;
        }
        
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