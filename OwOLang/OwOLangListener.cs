//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/sneakyanimeow/RiderProjects/AntlrTests/OwOLang/OwOLang.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AntlrTests.OwOLang {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="OwOLangParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface IOwOLangListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScript([NotNull] OwOLangParser.ScriptContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScript([NotNull] OwOLangParser.ScriptContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] OwOLangParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] OwOLangParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.print"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrint([NotNull] OwOLangParser.PrintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.print"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrint([NotNull] OwOLangParser.PrintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.loop_x_times"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLoop_x_times([NotNull] OwOLangParser.Loop_x_timesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.loop_x_times"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLoop_x_times([NotNull] OwOLangParser.Loop_x_timesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.declare_new_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclare_new_type([NotNull] OwOLangParser.Declare_new_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.declare_new_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclare_new_type([NotNull] OwOLangParser.Declare_new_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.declare_new_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclare_new_variable([NotNull] OwOLangParser.Declare_new_variableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.declare_new_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclare_new_variable([NotNull] OwOLangParser.Declare_new_variableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.set_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet_variable([NotNull] OwOLangParser.Set_variableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.set_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet_variable([NotNull] OwOLangParser.Set_variableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.declare_and_set_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclare_and_set_variable([NotNull] OwOLangParser.Declare_and_set_variableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.declare_and_set_variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclare_and_set_variable([NotNull] OwOLangParser.Declare_and_set_variableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] OwOLangParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] OwOLangParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] OwOLangParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] OwOLangParser.TypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.primitives"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimitives([NotNull] OwOLangParser.PrimitivesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.primitives"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimitives([NotNull] OwOLangParser.PrimitivesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterId([NotNull] OwOLangParser.IdContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.id"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitId([NotNull] OwOLangParser.IdContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] OwOLangParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.int"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] OwOLangParser.IntContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.float"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloat([NotNull] OwOLangParser.FloatContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.float"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloat([NotNull] OwOLangParser.FloatContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] OwOLangParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] OwOLangParser.StringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OwOLangParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBool([NotNull] OwOLangParser.BoolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OwOLangParser.bool"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBool([NotNull] OwOLangParser.BoolContext context);
}
} // namespace AntlrTests.OwOLang
