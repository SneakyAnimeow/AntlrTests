//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/sneakyanimeow/RiderProjects/AntlrTests/MyTinyC/MyTinyC.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace AntlrTests.MyTinyC {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class MyTinyCParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, STRING=26, INT=27, WS=28;
	public const int
		RULE_program = 0, RULE_statement = 1, RULE_paren_expr = 2, RULE_expr = 3, 
		RULE_test = 4, RULE_sum_ = 5, RULE_term = 6, RULE_id_ = 7, RULE_integer = 8;
	public static readonly string[] ruleNames = {
		"program", "statement", "paren_expr", "expr", "test", "sum_", "term", 
		"id_", "integer"
	};

	private static readonly string[] _LiteralNames = {
		null, "'if'", "'else'", "'while'", "'do'", "';'", "'{'", "'}'", "'\\U0001F366'", 
		"'('", "')'", "'='", "'&&'", "'||'", "'>>'", "'<'", "'>'", "'<='", "'>='", 
		"'=='", "'!='", "'+'", "'-'", "'*'", "'/'", "'%'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, "STRING", "INT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "MyTinyC.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static MyTinyCParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public MyTinyCParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public MyTinyCParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class ProgramContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(MyTinyCParser.Eof, 0); }
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.EnterProgram(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.ExitProgram(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyTinyCVisitor<TResult> typedVisitor = visitor as IMyTinyCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProgram(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(Context, State);
		EnterRule(_localctx, 0, RULE_program);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 18;
			statement();
			State = 19;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Paren_exprContext paren_expr() {
			return GetRuleContext<Paren_exprContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext[] statement() {
			return GetRuleContexts<StatementContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public StatementContext statement(int i) {
			return GetRuleContext<StatementContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyTinyCVisitor<TResult> typedVisitor = visitor as IMyTinyCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(Context, State);
		EnterRule(_localctx, 2, RULE_statement);
		int _la;
		try {
			State = 56;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 21;
				Match(T__0);
				State = 22;
				paren_expr();
				State = 23;
				statement();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 25;
				Match(T__0);
				State = 26;
				paren_expr();
				State = 27;
				statement();
				State = 28;
				Match(T__1);
				State = 29;
				statement();
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 31;
				Match(T__2);
				State = 32;
				paren_expr();
				State = 33;
				statement();
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 35;
				Match(T__3);
				State = 36;
				statement();
				State = 37;
				Match(T__2);
				State = 38;
				paren_expr();
				State = 39;
				Match(T__4);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 41;
				Match(T__5);
				State = 45;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & 201343610L) != 0)) {
					{
					{
					State = 42;
					statement();
					}
					}
					State = 47;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
				}
				State = 48;
				Match(T__6);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 49;
				expr(0);
				State = 50;
				Match(T__4);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 52;
				expr(0);
				State = 53;
				Match(T__7);
				}
				break;
			case 8:
				EnterOuterAlt(_localctx, 8);
				{
				State = 55;
				Match(T__4);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Paren_exprContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public Paren_exprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_paren_expr; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.EnterParen_expr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.ExitParen_expr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyTinyCVisitor<TResult> typedVisitor = visitor as IMyTinyCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParen_expr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Paren_exprContext paren_expr() {
		Paren_exprContext _localctx = new Paren_exprContext(Context, State);
		EnterRule(_localctx, 4, RULE_paren_expr);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 58;
			Match(T__8);
			State = 59;
			expr(0);
			State = 60;
			Match(T__9);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TestContext test() {
			return GetRuleContext<TestContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Id_Context id_() {
			return GetRuleContext<Id_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyTinyCVisitor<TResult> typedVisitor = visitor as IMyTinyCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 6;
		EnterRecursionRule(_localctx, 6, RULE_expr, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 70;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				{
				State = 63;
				test();
				}
				break;
			case 2:
				{
				State = 64;
				id_();
				State = 65;
				Match(T__10);
				State = 66;
				expr(4);
				}
				break;
			case 3:
				{
				State = 68;
				Match(T__13);
				State = 69;
				expr(1);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 80;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 78;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
					case 1:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 72;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 73;
						Match(T__11);
						State = 74;
						expr(4);
						}
						break;
					case 2:
						{
						_localctx = new ExprContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 75;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 76;
						Match(T__12);
						State = 77;
						expr(3);
						}
						break;
					}
					} 
				}
				State = 82;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class TestContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Sum_Context[] sum_() {
			return GetRuleContexts<Sum_Context>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public Sum_Context sum_(int i) {
			return GetRuleContext<Sum_Context>(i);
		}
		public TestContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_test; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.EnterTest(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.ExitTest(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyTinyCVisitor<TResult> typedVisitor = visitor as IMyTinyCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTest(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TestContext test() {
		TestContext _localctx = new TestContext(Context, State);
		EnterRule(_localctx, 8, RULE_test);
		try {
			State = 108;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 83;
				sum_(0);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 84;
				sum_(0);
				State = 85;
				Match(T__14);
				State = 86;
				sum_(0);
				}
				break;
			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 88;
				sum_(0);
				State = 89;
				Match(T__15);
				State = 90;
				sum_(0);
				}
				break;
			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 92;
				sum_(0);
				State = 93;
				Match(T__16);
				State = 94;
				sum_(0);
				}
				break;
			case 5:
				EnterOuterAlt(_localctx, 5);
				{
				State = 96;
				sum_(0);
				State = 97;
				Match(T__17);
				State = 98;
				sum_(0);
				}
				break;
			case 6:
				EnterOuterAlt(_localctx, 6);
				{
				State = 100;
				sum_(0);
				State = 101;
				Match(T__18);
				State = 102;
				sum_(0);
				}
				break;
			case 7:
				EnterOuterAlt(_localctx, 7);
				{
				State = 104;
				sum_(0);
				State = 105;
				Match(T__19);
				State = 106;
				sum_(0);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Sum_Context : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TermContext term() {
			return GetRuleContext<TermContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Sum_Context sum_() {
			return GetRuleContext<Sum_Context>(0);
		}
		public Sum_Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_sum_; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.EnterSum_(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.ExitSum_(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyTinyCVisitor<TResult> typedVisitor = visitor as IMyTinyCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSum_(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Sum_Context sum_() {
		return sum_(0);
	}

	private Sum_Context sum_(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		Sum_Context _localctx = new Sum_Context(Context, _parentState);
		Sum_Context _prevctx = _localctx;
		int _startState = 10;
		EnterRecursionRule(_localctx, 10, RULE_sum_, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			{
			State = 111;
			term();
			}
			Context.Stop = TokenStream.LT(-1);
			State = 130;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 128;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,6,Context) ) {
					case 1:
						{
						_localctx = new Sum_Context(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_sum_);
						State = 113;
						if (!(Precpred(Context, 5))) throw new FailedPredicateException(this, "Precpred(Context, 5)");
						State = 114;
						Match(T__20);
						State = 115;
						term();
						}
						break;
					case 2:
						{
						_localctx = new Sum_Context(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_sum_);
						State = 116;
						if (!(Precpred(Context, 4))) throw new FailedPredicateException(this, "Precpred(Context, 4)");
						State = 117;
						Match(T__21);
						State = 118;
						term();
						}
						break;
					case 3:
						{
						_localctx = new Sum_Context(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_sum_);
						State = 119;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 120;
						Match(T__22);
						State = 121;
						term();
						}
						break;
					case 4:
						{
						_localctx = new Sum_Context(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_sum_);
						State = 122;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 123;
						Match(T__23);
						State = 124;
						term();
						}
						break;
					case 5:
						{
						_localctx = new Sum_Context(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_sum_);
						State = 125;
						if (!(Precpred(Context, 1))) throw new FailedPredicateException(this, "Precpred(Context, 1)");
						State = 126;
						Match(T__24);
						State = 127;
						term();
						}
						break;
					}
					} 
				}
				State = 132;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public partial class TermContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public Id_Context id_() {
			return GetRuleContext<Id_Context>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public IntegerContext integer() {
			return GetRuleContext<IntegerContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public Paren_exprContext paren_expr() {
			return GetRuleContext<Paren_exprContext>(0);
		}
		public TermContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_term; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.EnterTerm(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.ExitTerm(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyTinyCVisitor<TResult> typedVisitor = visitor as IMyTinyCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTerm(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TermContext term() {
		TermContext _localctx = new TermContext(Context, State);
		EnterRule(_localctx, 12, RULE_term);
		try {
			State = 136;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case STRING:
				EnterOuterAlt(_localctx, 1);
				{
				State = 133;
				id_();
				}
				break;
			case INT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 134;
				integer();
				}
				break;
			case T__8:
				EnterOuterAlt(_localctx, 3);
				{
				State = 135;
				paren_expr();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Id_Context : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode STRING() { return GetToken(MyTinyCParser.STRING, 0); }
		public Id_Context(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_id_; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.EnterId_(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.ExitId_(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyTinyCVisitor<TResult> typedVisitor = visitor as IMyTinyCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitId_(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Id_Context id_() {
		Id_Context _localctx = new Id_Context(Context, State);
		EnterRule(_localctx, 14, RULE_id_);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 138;
			Match(STRING);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class IntegerContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INT() { return GetToken(MyTinyCParser.INT, 0); }
		public IntegerContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_integer; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.EnterInteger(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IMyTinyCListener typedListener = listener as IMyTinyCListener;
			if (typedListener != null) typedListener.ExitInteger(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMyTinyCVisitor<TResult> typedVisitor = visitor as IMyTinyCVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInteger(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public IntegerContext integer() {
		IntegerContext _localctx = new IntegerContext(Context, State);
		EnterRule(_localctx, 16, RULE_integer);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 140;
			Match(INT);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 3: return expr_sempred((ExprContext)_localctx, predIndex);
		case 5: return sum__sempred((Sum_Context)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 3);
		case 1: return Precpred(Context, 2);
		}
		return true;
	}
	private bool sum__sempred(Sum_Context _localctx, int predIndex) {
		switch (predIndex) {
		case 2: return Precpred(Context, 5);
		case 3: return Precpred(Context, 4);
		case 4: return Precpred(Context, 3);
		case 5: return Precpred(Context, 2);
		case 6: return Precpred(Context, 1);
		}
		return true;
	}

	private static int[] _serializedATN = {
		4,1,28,143,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,1,0,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,
		1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,5,1,44,8,1,10,1,12,1,47,9,1,
		1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,3,1,57,8,1,1,2,1,2,1,2,1,2,1,3,1,3,1,3,
		1,3,1,3,1,3,1,3,1,3,3,3,71,8,3,1,3,1,3,1,3,1,3,1,3,1,3,5,3,79,8,3,10,3,
		12,3,82,9,3,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,
		4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,1,4,3,4,109,8,4,1,5,1,5,1,5,1,5,
		1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,1,5,5,5,129,8,5,10,
		5,12,5,132,9,5,1,6,1,6,1,6,3,6,137,8,6,1,7,1,7,1,8,1,8,1,8,0,2,6,10,9,
		0,2,4,6,8,10,12,14,16,0,0,158,0,18,1,0,0,0,2,56,1,0,0,0,4,58,1,0,0,0,6,
		70,1,0,0,0,8,108,1,0,0,0,10,110,1,0,0,0,12,136,1,0,0,0,14,138,1,0,0,0,
		16,140,1,0,0,0,18,19,3,2,1,0,19,20,5,0,0,1,20,1,1,0,0,0,21,22,5,1,0,0,
		22,23,3,4,2,0,23,24,3,2,1,0,24,57,1,0,0,0,25,26,5,1,0,0,26,27,3,4,2,0,
		27,28,3,2,1,0,28,29,5,2,0,0,29,30,3,2,1,0,30,57,1,0,0,0,31,32,5,3,0,0,
		32,33,3,4,2,0,33,34,3,2,1,0,34,57,1,0,0,0,35,36,5,4,0,0,36,37,3,2,1,0,
		37,38,5,3,0,0,38,39,3,4,2,0,39,40,5,5,0,0,40,57,1,0,0,0,41,45,5,6,0,0,
		42,44,3,2,1,0,43,42,1,0,0,0,44,47,1,0,0,0,45,43,1,0,0,0,45,46,1,0,0,0,
		46,48,1,0,0,0,47,45,1,0,0,0,48,57,5,7,0,0,49,50,3,6,3,0,50,51,5,5,0,0,
		51,57,1,0,0,0,52,53,3,6,3,0,53,54,5,8,0,0,54,57,1,0,0,0,55,57,5,5,0,0,
		56,21,1,0,0,0,56,25,1,0,0,0,56,31,1,0,0,0,56,35,1,0,0,0,56,41,1,0,0,0,
		56,49,1,0,0,0,56,52,1,0,0,0,56,55,1,0,0,0,57,3,1,0,0,0,58,59,5,9,0,0,59,
		60,3,6,3,0,60,61,5,10,0,0,61,5,1,0,0,0,62,63,6,3,-1,0,63,71,3,8,4,0,64,
		65,3,14,7,0,65,66,5,11,0,0,66,67,3,6,3,4,67,71,1,0,0,0,68,69,5,14,0,0,
		69,71,3,6,3,1,70,62,1,0,0,0,70,64,1,0,0,0,70,68,1,0,0,0,71,80,1,0,0,0,
		72,73,10,3,0,0,73,74,5,12,0,0,74,79,3,6,3,4,75,76,10,2,0,0,76,77,5,13,
		0,0,77,79,3,6,3,3,78,72,1,0,0,0,78,75,1,0,0,0,79,82,1,0,0,0,80,78,1,0,
		0,0,80,81,1,0,0,0,81,7,1,0,0,0,82,80,1,0,0,0,83,109,3,10,5,0,84,85,3,10,
		5,0,85,86,5,15,0,0,86,87,3,10,5,0,87,109,1,0,0,0,88,89,3,10,5,0,89,90,
		5,16,0,0,90,91,3,10,5,0,91,109,1,0,0,0,92,93,3,10,5,0,93,94,5,17,0,0,94,
		95,3,10,5,0,95,109,1,0,0,0,96,97,3,10,5,0,97,98,5,18,0,0,98,99,3,10,5,
		0,99,109,1,0,0,0,100,101,3,10,5,0,101,102,5,19,0,0,102,103,3,10,5,0,103,
		109,1,0,0,0,104,105,3,10,5,0,105,106,5,20,0,0,106,107,3,10,5,0,107,109,
		1,0,0,0,108,83,1,0,0,0,108,84,1,0,0,0,108,88,1,0,0,0,108,92,1,0,0,0,108,
		96,1,0,0,0,108,100,1,0,0,0,108,104,1,0,0,0,109,9,1,0,0,0,110,111,6,5,-1,
		0,111,112,3,12,6,0,112,130,1,0,0,0,113,114,10,5,0,0,114,115,5,21,0,0,115,
		129,3,12,6,0,116,117,10,4,0,0,117,118,5,22,0,0,118,129,3,12,6,0,119,120,
		10,3,0,0,120,121,5,23,0,0,121,129,3,12,6,0,122,123,10,2,0,0,123,124,5,
		24,0,0,124,129,3,12,6,0,125,126,10,1,0,0,126,127,5,25,0,0,127,129,3,12,
		6,0,128,113,1,0,0,0,128,116,1,0,0,0,128,119,1,0,0,0,128,122,1,0,0,0,128,
		125,1,0,0,0,129,132,1,0,0,0,130,128,1,0,0,0,130,131,1,0,0,0,131,11,1,0,
		0,0,132,130,1,0,0,0,133,137,3,14,7,0,134,137,3,16,8,0,135,137,3,4,2,0,
		136,133,1,0,0,0,136,134,1,0,0,0,136,135,1,0,0,0,137,13,1,0,0,0,138,139,
		5,26,0,0,139,15,1,0,0,0,140,141,5,27,0,0,141,17,1,0,0,0,9,45,56,70,78,
		80,108,128,130,136
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace AntlrTests.MyTinyC
