//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/meow/RiderProjects/AntlrTests/NekoScript\Seleneko.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AntlrTests.NekoScript {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="SelenekoParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface ISelenekoListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.chunk"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterChunk([NotNull] SelenekoParser.ChunkContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.chunk"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitChunk([NotNull] SelenekoParser.ChunkContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] SelenekoParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] SelenekoParser.BlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStat([NotNull] SelenekoParser.StatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.stat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStat([NotNull] SelenekoParser.StatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.native_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNative_call([NotNull] SelenekoParser.Native_callContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.native_call"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNative_call([NotNull] SelenekoParser.Native_callContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.laststat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLaststat([NotNull] SelenekoParser.LaststatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.laststat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLaststat([NotNull] SelenekoParser.LaststatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLabel([NotNull] SelenekoParser.LabelContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.label"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLabel([NotNull] SelenekoParser.LabelContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.funcname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncname([NotNull] SelenekoParser.FuncnameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.funcname"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncname([NotNull] SelenekoParser.FuncnameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.varlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarlist([NotNull] SelenekoParser.VarlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.varlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarlist([NotNull] SelenekoParser.VarlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.namelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNamelist([NotNull] SelenekoParser.NamelistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.namelist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNamelist([NotNull] SelenekoParser.NamelistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.explist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExplist([NotNull] SelenekoParser.ExplistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.explist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExplist([NotNull] SelenekoParser.ExplistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExp([NotNull] SelenekoParser.ExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.exp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExp([NotNull] SelenekoParser.ExpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.prefixexp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrefixexp([NotNull] SelenekoParser.PrefixexpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.prefixexp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrefixexp([NotNull] SelenekoParser.PrefixexpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.functioncall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctioncall([NotNull] SelenekoParser.FunctioncallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.functioncall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctioncall([NotNull] SelenekoParser.FunctioncallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.varOrExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarOrExp([NotNull] SelenekoParser.VarOrExpContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.varOrExp"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarOrExp([NotNull] SelenekoParser.VarOrExpContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVar([NotNull] SelenekoParser.VarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVar([NotNull] SelenekoParser.VarContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.varSuffix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVarSuffix([NotNull] SelenekoParser.VarSuffixContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.varSuffix"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVarSuffix([NotNull] SelenekoParser.VarSuffixContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.nameAndArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNameAndArgs([NotNull] SelenekoParser.NameAndArgsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.nameAndArgs"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNameAndArgs([NotNull] SelenekoParser.NameAndArgsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArgs([NotNull] SelenekoParser.ArgsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.args"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArgs([NotNull] SelenekoParser.ArgsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.functiondef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctiondef([NotNull] SelenekoParser.FunctiondefContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.functiondef"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctiondef([NotNull] SelenekoParser.FunctiondefContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.funcbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFuncbody([NotNull] SelenekoParser.FuncbodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.funcbody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFuncbody([NotNull] SelenekoParser.FuncbodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.parlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParlist([NotNull] SelenekoParser.ParlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.parlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParlist([NotNull] SelenekoParser.ParlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.objectconstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectconstructor([NotNull] SelenekoParser.ObjectconstructorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.objectconstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectconstructor([NotNull] SelenekoParser.ObjectconstructorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.objectfieldlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectfieldlist([NotNull] SelenekoParser.ObjectfieldlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.objectfieldlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectfieldlist([NotNull] SelenekoParser.ObjectfieldlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.objectfield"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterObjectfield([NotNull] SelenekoParser.ObjectfieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.objectfield"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitObjectfield([NotNull] SelenekoParser.ObjectfieldContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.tableconstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTableconstructor([NotNull] SelenekoParser.TableconstructorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.tableconstructor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTableconstructor([NotNull] SelenekoParser.TableconstructorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.fieldlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldlist([NotNull] SelenekoParser.FieldlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.fieldlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldlist([NotNull] SelenekoParser.FieldlistContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterField([NotNull] SelenekoParser.FieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitField([NotNull] SelenekoParser.FieldContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.fieldsep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldsep([NotNull] SelenekoParser.FieldsepContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.fieldsep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldsep([NotNull] SelenekoParser.FieldsepContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.operatorOr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorOr([NotNull] SelenekoParser.OperatorOrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.operatorOr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorOr([NotNull] SelenekoParser.OperatorOrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.operatorAnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorAnd([NotNull] SelenekoParser.OperatorAndContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.operatorAnd"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorAnd([NotNull] SelenekoParser.OperatorAndContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.operatorComparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorComparison([NotNull] SelenekoParser.OperatorComparisonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.operatorComparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorComparison([NotNull] SelenekoParser.OperatorComparisonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.operatorStrcat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorStrcat([NotNull] SelenekoParser.OperatorStrcatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.operatorStrcat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorStrcat([NotNull] SelenekoParser.OperatorStrcatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.operatorAddSub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorAddSub([NotNull] SelenekoParser.OperatorAddSubContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.operatorAddSub"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorAddSub([NotNull] SelenekoParser.OperatorAddSubContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.operatorMulDivMod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorMulDivMod([NotNull] SelenekoParser.OperatorMulDivModContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.operatorMulDivMod"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorMulDivMod([NotNull] SelenekoParser.OperatorMulDivModContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.operatorBitwise"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorBitwise([NotNull] SelenekoParser.OperatorBitwiseContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.operatorBitwise"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorBitwise([NotNull] SelenekoParser.OperatorBitwiseContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.operatorUnary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorUnary([NotNull] SelenekoParser.OperatorUnaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.operatorUnary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorUnary([NotNull] SelenekoParser.OperatorUnaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.operatorPower"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOperatorPower([NotNull] SelenekoParser.OperatorPowerContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.operatorPower"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOperatorPower([NotNull] SelenekoParser.OperatorPowerContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] SelenekoParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] SelenekoParser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="SelenekoParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] SelenekoParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="SelenekoParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] SelenekoParser.StringContext context);
}
} // namespace AntlrTests.NekoScript
