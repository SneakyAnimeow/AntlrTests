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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IOwOLangVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class OwOLangBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IOwOLangVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.script"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitScript([NotNull] OwOLangParser.ScriptContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.function"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFunction([NotNull] OwOLangParser.FunctionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.print"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrint([NotNull] OwOLangParser.PrintContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.loop_x_times"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLoop_x_times([NotNull] OwOLangParser.Loop_x_timesContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.declare_new_type"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDeclare_new_type([NotNull] OwOLangParser.Declare_new_typeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.declare_new_variable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDeclare_new_variable([NotNull] OwOLangParser.Declare_new_variableContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.set_variable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSet_variable([NotNull] OwOLangParser.Set_variableContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.declare_and_set_variable"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDeclare_and_set_variable([NotNull] OwOLangParser.Declare_and_set_variableContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.expression"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpression([NotNull] OwOLangParser.ExpressionContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.type"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitType([NotNull] OwOLangParser.TypeContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.primitives"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPrimitives([NotNull] OwOLangParser.PrimitivesContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.id"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitId([NotNull] OwOLangParser.IdContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.int"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInt([NotNull] OwOLangParser.IntContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.float"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFloat([NotNull] OwOLangParser.FloatContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.string"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitString([NotNull] OwOLangParser.StringContext context) { return VisitChildren(context); }
	/// <summary>
	/// Visit a parse tree produced by <see cref="OwOLangParser.bool"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBool([NotNull] OwOLangParser.BoolContext context) { return VisitChildren(context); }
}
} // namespace AntlrTests.OwOLang
