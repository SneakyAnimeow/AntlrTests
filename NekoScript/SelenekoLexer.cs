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
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public partial class SelenekoLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, T__33=34, T__34=35, T__35=36, T__36=37, T__37=38, 
		T__38=39, T__39=40, T__40=41, T__41=42, T__42=43, T__43=44, T__44=45, 
		T__45=46, T__46=47, T__47=48, T__48=49, T__49=50, T__50=51, T__51=52, 
		T__52=53, T__53=54, T__54=55, T__55=56, T__56=57, T__57=58, NAME=59, NORMALSTRING=60, 
		CHARSTRING=61, LONGSTRING=62, INT=63, HEX=64, FLOAT=65, HEX_FLOAT=66, 
		COMMENT=67, LINE_COMMENT=68, WS=69, SHEBANG=70;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"T__33", "T__34", "T__35", "T__36", "T__37", "T__38", "T__39", "T__40", 
		"T__41", "T__42", "T__43", "T__44", "T__45", "T__46", "T__47", "T__48", 
		"T__49", "T__50", "T__51", "T__52", "T__53", "T__54", "T__55", "T__56", 
		"T__57", "NAME", "NORMALSTRING", "CHARSTRING", "LONGSTRING", "NESTED_STR", 
		"INT", "HEX", "FLOAT", "HEX_FLOAT", "ExponentPart", "HexExponentPart", 
		"EscapeSequence", "DecimalEscape", "HexEscape", "UtfEscape", "Digit", 
		"HexDigit", "SingleLineInputCharacter", "COMMENT", "LINE_COMMENT", "WS", 
		"SHEBANG"
	};


	public SelenekoLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public SelenekoLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'='", "'break'", "'goto'", "'{'", "'}'", "'do'", "'end'", 
		"'while'", "'('", "')'", "'repeat'", "'until'", "'if'", "'else'", "'then'", 
		"'for'", "','", "'in'", "'function'", "'let'", "'local'", "'~'", "'return'", 
		"'continue'", "'::'", "'.'", "':'", "'null'", "'nil'", "'false'", "'true'", 
		"'...'", "'['", "']'", "'or'", "'and'", "'<'", "'>'", "'<='", "'>='", 
		"'!='", "'~='", "'=='", "'..'", "'+'", "'-'", "'*'", "'/'", "'%'", "'//'", 
		"'&'", "'|'", "'<<'", "'>>'", "'not'", "'#'", "'^'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, "NAME", 
		"NORMALSTRING", "CHARSTRING", "LONGSTRING", "INT", "HEX", "FLOAT", "HEX_FLOAT", 
		"COMMENT", "LINE_COMMENT", "WS", "SHEBANG"
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

	public override string GrammarFileName { get { return "Seleneko.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static SelenekoLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,70,595,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,2,55,7,55,2,56,
		7,56,2,57,7,57,2,58,7,58,2,59,7,59,2,60,7,60,2,61,7,61,2,62,7,62,2,63,
		7,63,2,64,7,64,2,65,7,65,2,66,7,66,2,67,7,67,2,68,7,68,2,69,7,69,2,70,
		7,70,2,71,7,71,2,72,7,72,2,73,7,73,2,74,7,74,2,75,7,75,2,76,7,76,2,77,
		7,77,2,78,7,78,2,79,7,79,1,0,1,0,1,1,1,1,1,2,1,2,1,2,1,2,1,2,1,2,1,3,1,
		3,1,3,1,3,1,3,1,4,1,4,1,5,1,5,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,8,1,8,1,8,
		1,8,1,8,1,8,1,9,1,9,1,10,1,10,1,11,1,11,1,11,1,11,1,11,1,11,1,11,1,12,
		1,12,1,12,1,12,1,12,1,12,1,13,1,13,1,13,1,14,1,14,1,14,1,14,1,14,1,15,
		1,15,1,15,1,15,1,15,1,16,1,16,1,16,1,16,1,17,1,17,1,18,1,18,1,18,1,19,
		1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,19,1,20,1,20,1,20,1,20,1,21,1,21,
		1,21,1,21,1,21,1,21,1,22,1,22,1,23,1,23,1,23,1,23,1,23,1,23,1,23,1,24,
		1,24,1,24,1,24,1,24,1,24,1,24,1,24,1,24,1,25,1,25,1,25,1,26,1,26,1,27,
		1,27,1,28,1,28,1,28,1,28,1,28,1,29,1,29,1,29,1,29,1,30,1,30,1,30,1,30,
		1,30,1,30,1,31,1,31,1,31,1,31,1,31,1,32,1,32,1,32,1,32,1,33,1,33,1,34,
		1,34,1,35,1,35,1,35,1,36,1,36,1,36,1,36,1,37,1,37,1,38,1,38,1,39,1,39,
		1,39,1,40,1,40,1,40,1,41,1,41,1,41,1,42,1,42,1,42,1,43,1,43,1,43,1,44,
		1,44,1,44,1,45,1,45,1,46,1,46,1,47,1,47,1,48,1,48,1,49,1,49,1,50,1,50,
		1,50,1,51,1,51,1,52,1,52,1,53,1,53,1,53,1,54,1,54,1,54,1,55,1,55,1,55,
		1,55,1,56,1,56,1,57,1,57,1,58,1,58,5,58,367,8,58,10,58,12,58,370,9,58,
		1,59,1,59,1,59,5,59,375,8,59,10,59,12,59,378,9,59,1,59,1,59,1,60,1,60,
		1,60,5,60,385,8,60,10,60,12,60,388,9,60,1,60,1,60,1,61,1,61,1,61,1,61,
		1,62,1,62,1,62,1,62,1,62,1,62,5,62,402,8,62,10,62,12,62,405,9,62,1,62,
		3,62,408,8,62,1,63,4,63,411,8,63,11,63,12,63,412,1,64,1,64,1,64,4,64,418,
		8,64,11,64,12,64,419,1,65,4,65,423,8,65,11,65,12,65,424,1,65,1,65,5,65,
		429,8,65,10,65,12,65,432,9,65,1,65,3,65,435,8,65,1,65,1,65,4,65,439,8,
		65,11,65,12,65,440,1,65,3,65,444,8,65,1,65,4,65,447,8,65,11,65,12,65,448,
		1,65,1,65,3,65,453,8,65,1,66,1,66,1,66,4,66,458,8,66,11,66,12,66,459,1,
		66,1,66,5,66,464,8,66,10,66,12,66,467,9,66,1,66,3,66,470,8,66,1,66,1,66,
		1,66,1,66,4,66,476,8,66,11,66,12,66,477,1,66,3,66,481,8,66,1,66,1,66,1,
		66,4,66,486,8,66,11,66,12,66,487,1,66,1,66,3,66,492,8,66,1,67,1,67,3,67,
		496,8,67,1,67,4,67,499,8,67,11,67,12,67,500,1,68,1,68,3,68,505,8,68,1,
		68,4,68,508,8,68,11,68,12,68,509,1,69,1,69,1,69,1,69,3,69,516,8,69,1,69,
		1,69,1,69,1,69,3,69,522,8,69,1,70,1,70,1,70,1,70,1,70,1,70,1,70,1,70,1,
		70,1,70,1,70,3,70,535,8,70,1,71,1,71,1,71,1,71,1,71,1,72,1,72,1,72,1,72,
		1,72,4,72,547,8,72,11,72,12,72,548,1,72,1,72,1,73,1,73,1,74,1,74,1,75,
		1,75,1,76,1,76,1,76,1,76,1,76,1,76,1,76,1,76,1,76,1,77,1,77,1,77,1,77,
		5,77,572,8,77,10,77,12,77,575,9,77,1,77,1,77,1,78,4,78,580,8,78,11,78,
		12,78,581,1,78,1,78,1,79,1,79,1,79,5,79,589,8,79,10,79,12,79,592,9,79,
		1,79,1,79,1,403,0,80,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,10,21,
		11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,21,43,22,45,
		23,47,24,49,25,51,26,53,27,55,28,57,29,59,30,61,31,63,32,65,33,67,34,69,
		35,71,36,73,37,75,38,77,39,79,40,81,41,83,42,85,43,87,44,89,45,91,46,93,
		47,95,48,97,49,99,50,101,51,103,52,105,53,107,54,109,55,111,56,113,57,
		115,58,117,59,119,60,121,61,123,62,125,0,127,63,129,64,131,65,133,66,135,
		0,137,0,139,0,141,0,143,0,145,0,147,0,149,0,151,0,153,67,155,68,157,69,
		159,70,1,0,14,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,97,122,2,0,
		34,34,92,92,2,0,39,39,92,92,2,0,88,88,120,120,2,0,69,69,101,101,2,0,43,
		43,45,45,2,0,80,80,112,112,11,0,34,36,39,39,92,92,97,98,102,102,110,110,
		114,114,116,116,118,118,122,122,124,124,1,0,48,50,1,0,48,57,3,0,48,57,
		65,70,97,102,4,0,10,10,13,13,133,133,8232,8233,3,0,9,10,12,13,32,32,624,
		0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,
		0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,
		1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,
		0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,
		1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,
		0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,0,67,
		1,0,0,0,0,69,1,0,0,0,0,71,1,0,0,0,0,73,1,0,0,0,0,75,1,0,0,0,0,77,1,0,0,
		0,0,79,1,0,0,0,0,81,1,0,0,0,0,83,1,0,0,0,0,85,1,0,0,0,0,87,1,0,0,0,0,89,
		1,0,0,0,0,91,1,0,0,0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,
		0,0,101,1,0,0,0,0,103,1,0,0,0,0,105,1,0,0,0,0,107,1,0,0,0,0,109,1,0,0,
		0,0,111,1,0,0,0,0,113,1,0,0,0,0,115,1,0,0,0,0,117,1,0,0,0,0,119,1,0,0,
		0,0,121,1,0,0,0,0,123,1,0,0,0,0,127,1,0,0,0,0,129,1,0,0,0,0,131,1,0,0,
		0,0,133,1,0,0,0,0,153,1,0,0,0,0,155,1,0,0,0,0,157,1,0,0,0,0,159,1,0,0,
		0,1,161,1,0,0,0,3,163,1,0,0,0,5,165,1,0,0,0,7,171,1,0,0,0,9,176,1,0,0,
		0,11,178,1,0,0,0,13,180,1,0,0,0,15,183,1,0,0,0,17,187,1,0,0,0,19,193,1,
		0,0,0,21,195,1,0,0,0,23,197,1,0,0,0,25,204,1,0,0,0,27,210,1,0,0,0,29,213,
		1,0,0,0,31,218,1,0,0,0,33,223,1,0,0,0,35,227,1,0,0,0,37,229,1,0,0,0,39,
		232,1,0,0,0,41,241,1,0,0,0,43,245,1,0,0,0,45,251,1,0,0,0,47,253,1,0,0,
		0,49,260,1,0,0,0,51,269,1,0,0,0,53,272,1,0,0,0,55,274,1,0,0,0,57,276,1,
		0,0,0,59,281,1,0,0,0,61,285,1,0,0,0,63,291,1,0,0,0,65,296,1,0,0,0,67,300,
		1,0,0,0,69,302,1,0,0,0,71,304,1,0,0,0,73,307,1,0,0,0,75,311,1,0,0,0,77,
		313,1,0,0,0,79,315,1,0,0,0,81,318,1,0,0,0,83,321,1,0,0,0,85,324,1,0,0,
		0,87,327,1,0,0,0,89,330,1,0,0,0,91,333,1,0,0,0,93,335,1,0,0,0,95,337,1,
		0,0,0,97,339,1,0,0,0,99,341,1,0,0,0,101,343,1,0,0,0,103,346,1,0,0,0,105,
		348,1,0,0,0,107,350,1,0,0,0,109,353,1,0,0,0,111,356,1,0,0,0,113,360,1,
		0,0,0,115,362,1,0,0,0,117,364,1,0,0,0,119,371,1,0,0,0,121,381,1,0,0,0,
		123,391,1,0,0,0,125,407,1,0,0,0,127,410,1,0,0,0,129,414,1,0,0,0,131,452,
		1,0,0,0,133,491,1,0,0,0,135,493,1,0,0,0,137,502,1,0,0,0,139,521,1,0,0,
		0,141,534,1,0,0,0,143,536,1,0,0,0,145,541,1,0,0,0,147,552,1,0,0,0,149,
		554,1,0,0,0,151,556,1,0,0,0,153,558,1,0,0,0,155,567,1,0,0,0,157,579,1,
		0,0,0,159,585,1,0,0,0,161,162,5,59,0,0,162,2,1,0,0,0,163,164,5,61,0,0,
		164,4,1,0,0,0,165,166,5,98,0,0,166,167,5,114,0,0,167,168,5,101,0,0,168,
		169,5,97,0,0,169,170,5,107,0,0,170,6,1,0,0,0,171,172,5,103,0,0,172,173,
		5,111,0,0,173,174,5,116,0,0,174,175,5,111,0,0,175,8,1,0,0,0,176,177,5,
		123,0,0,177,10,1,0,0,0,178,179,5,125,0,0,179,12,1,0,0,0,180,181,5,100,
		0,0,181,182,5,111,0,0,182,14,1,0,0,0,183,184,5,101,0,0,184,185,5,110,0,
		0,185,186,5,100,0,0,186,16,1,0,0,0,187,188,5,119,0,0,188,189,5,104,0,0,
		189,190,5,105,0,0,190,191,5,108,0,0,191,192,5,101,0,0,192,18,1,0,0,0,193,
		194,5,40,0,0,194,20,1,0,0,0,195,196,5,41,0,0,196,22,1,0,0,0,197,198,5,
		114,0,0,198,199,5,101,0,0,199,200,5,112,0,0,200,201,5,101,0,0,201,202,
		5,97,0,0,202,203,5,116,0,0,203,24,1,0,0,0,204,205,5,117,0,0,205,206,5,
		110,0,0,206,207,5,116,0,0,207,208,5,105,0,0,208,209,5,108,0,0,209,26,1,
		0,0,0,210,211,5,105,0,0,211,212,5,102,0,0,212,28,1,0,0,0,213,214,5,101,
		0,0,214,215,5,108,0,0,215,216,5,115,0,0,216,217,5,101,0,0,217,30,1,0,0,
		0,218,219,5,116,0,0,219,220,5,104,0,0,220,221,5,101,0,0,221,222,5,110,
		0,0,222,32,1,0,0,0,223,224,5,102,0,0,224,225,5,111,0,0,225,226,5,114,0,
		0,226,34,1,0,0,0,227,228,5,44,0,0,228,36,1,0,0,0,229,230,5,105,0,0,230,
		231,5,110,0,0,231,38,1,0,0,0,232,233,5,102,0,0,233,234,5,117,0,0,234,235,
		5,110,0,0,235,236,5,99,0,0,236,237,5,116,0,0,237,238,5,105,0,0,238,239,
		5,111,0,0,239,240,5,110,0,0,240,40,1,0,0,0,241,242,5,108,0,0,242,243,5,
		101,0,0,243,244,5,116,0,0,244,42,1,0,0,0,245,246,5,108,0,0,246,247,5,111,
		0,0,247,248,5,99,0,0,248,249,5,97,0,0,249,250,5,108,0,0,250,44,1,0,0,0,
		251,252,5,126,0,0,252,46,1,0,0,0,253,254,5,114,0,0,254,255,5,101,0,0,255,
		256,5,116,0,0,256,257,5,117,0,0,257,258,5,114,0,0,258,259,5,110,0,0,259,
		48,1,0,0,0,260,261,5,99,0,0,261,262,5,111,0,0,262,263,5,110,0,0,263,264,
		5,116,0,0,264,265,5,105,0,0,265,266,5,110,0,0,266,267,5,117,0,0,267,268,
		5,101,0,0,268,50,1,0,0,0,269,270,5,58,0,0,270,271,5,58,0,0,271,52,1,0,
		0,0,272,273,5,46,0,0,273,54,1,0,0,0,274,275,5,58,0,0,275,56,1,0,0,0,276,
		277,5,110,0,0,277,278,5,117,0,0,278,279,5,108,0,0,279,280,5,108,0,0,280,
		58,1,0,0,0,281,282,5,110,0,0,282,283,5,105,0,0,283,284,5,108,0,0,284,60,
		1,0,0,0,285,286,5,102,0,0,286,287,5,97,0,0,287,288,5,108,0,0,288,289,5,
		115,0,0,289,290,5,101,0,0,290,62,1,0,0,0,291,292,5,116,0,0,292,293,5,114,
		0,0,293,294,5,117,0,0,294,295,5,101,0,0,295,64,1,0,0,0,296,297,5,46,0,
		0,297,298,5,46,0,0,298,299,5,46,0,0,299,66,1,0,0,0,300,301,5,91,0,0,301,
		68,1,0,0,0,302,303,5,93,0,0,303,70,1,0,0,0,304,305,5,111,0,0,305,306,5,
		114,0,0,306,72,1,0,0,0,307,308,5,97,0,0,308,309,5,110,0,0,309,310,5,100,
		0,0,310,74,1,0,0,0,311,312,5,60,0,0,312,76,1,0,0,0,313,314,5,62,0,0,314,
		78,1,0,0,0,315,316,5,60,0,0,316,317,5,61,0,0,317,80,1,0,0,0,318,319,5,
		62,0,0,319,320,5,61,0,0,320,82,1,0,0,0,321,322,5,33,0,0,322,323,5,61,0,
		0,323,84,1,0,0,0,324,325,5,126,0,0,325,326,5,61,0,0,326,86,1,0,0,0,327,
		328,5,61,0,0,328,329,5,61,0,0,329,88,1,0,0,0,330,331,5,46,0,0,331,332,
		5,46,0,0,332,90,1,0,0,0,333,334,5,43,0,0,334,92,1,0,0,0,335,336,5,45,0,
		0,336,94,1,0,0,0,337,338,5,42,0,0,338,96,1,0,0,0,339,340,5,47,0,0,340,
		98,1,0,0,0,341,342,5,37,0,0,342,100,1,0,0,0,343,344,5,47,0,0,344,345,5,
		47,0,0,345,102,1,0,0,0,346,347,5,38,0,0,347,104,1,0,0,0,348,349,5,124,
		0,0,349,106,1,0,0,0,350,351,5,60,0,0,351,352,5,60,0,0,352,108,1,0,0,0,
		353,354,5,62,0,0,354,355,5,62,0,0,355,110,1,0,0,0,356,357,5,110,0,0,357,
		358,5,111,0,0,358,359,5,116,0,0,359,112,1,0,0,0,360,361,5,35,0,0,361,114,
		1,0,0,0,362,363,5,94,0,0,363,116,1,0,0,0,364,368,7,0,0,0,365,367,7,1,0,
		0,366,365,1,0,0,0,367,370,1,0,0,0,368,366,1,0,0,0,368,369,1,0,0,0,369,
		118,1,0,0,0,370,368,1,0,0,0,371,376,5,34,0,0,372,375,3,139,69,0,373,375,
		8,2,0,0,374,372,1,0,0,0,374,373,1,0,0,0,375,378,1,0,0,0,376,374,1,0,0,
		0,376,377,1,0,0,0,377,379,1,0,0,0,378,376,1,0,0,0,379,380,5,34,0,0,380,
		120,1,0,0,0,381,386,5,39,0,0,382,385,3,139,69,0,383,385,8,3,0,0,384,382,
		1,0,0,0,384,383,1,0,0,0,385,388,1,0,0,0,386,384,1,0,0,0,386,387,1,0,0,
		0,387,389,1,0,0,0,388,386,1,0,0,0,389,390,5,39,0,0,390,122,1,0,0,0,391,
		392,5,91,0,0,392,393,3,125,62,0,393,394,5,93,0,0,394,124,1,0,0,0,395,396,
		5,61,0,0,396,397,3,125,62,0,397,398,5,61,0,0,398,408,1,0,0,0,399,403,5,
		91,0,0,400,402,9,0,0,0,401,400,1,0,0,0,402,405,1,0,0,0,403,404,1,0,0,0,
		403,401,1,0,0,0,404,406,1,0,0,0,405,403,1,0,0,0,406,408,5,93,0,0,407,395,
		1,0,0,0,407,399,1,0,0,0,408,126,1,0,0,0,409,411,3,147,73,0,410,409,1,0,
		0,0,411,412,1,0,0,0,412,410,1,0,0,0,412,413,1,0,0,0,413,128,1,0,0,0,414,
		415,5,48,0,0,415,417,7,4,0,0,416,418,3,149,74,0,417,416,1,0,0,0,418,419,
		1,0,0,0,419,417,1,0,0,0,419,420,1,0,0,0,420,130,1,0,0,0,421,423,3,147,
		73,0,422,421,1,0,0,0,423,424,1,0,0,0,424,422,1,0,0,0,424,425,1,0,0,0,425,
		426,1,0,0,0,426,430,5,46,0,0,427,429,3,147,73,0,428,427,1,0,0,0,429,432,
		1,0,0,0,430,428,1,0,0,0,430,431,1,0,0,0,431,434,1,0,0,0,432,430,1,0,0,
		0,433,435,3,135,67,0,434,433,1,0,0,0,434,435,1,0,0,0,435,453,1,0,0,0,436,
		438,5,46,0,0,437,439,3,147,73,0,438,437,1,0,0,0,439,440,1,0,0,0,440,438,
		1,0,0,0,440,441,1,0,0,0,441,443,1,0,0,0,442,444,3,135,67,0,443,442,1,0,
		0,0,443,444,1,0,0,0,444,453,1,0,0,0,445,447,3,147,73,0,446,445,1,0,0,0,
		447,448,1,0,0,0,448,446,1,0,0,0,448,449,1,0,0,0,449,450,1,0,0,0,450,451,
		3,135,67,0,451,453,1,0,0,0,452,422,1,0,0,0,452,436,1,0,0,0,452,446,1,0,
		0,0,453,132,1,0,0,0,454,455,5,48,0,0,455,457,7,4,0,0,456,458,3,149,74,
		0,457,456,1,0,0,0,458,459,1,0,0,0,459,457,1,0,0,0,459,460,1,0,0,0,460,
		461,1,0,0,0,461,465,5,46,0,0,462,464,3,149,74,0,463,462,1,0,0,0,464,467,
		1,0,0,0,465,463,1,0,0,0,465,466,1,0,0,0,466,469,1,0,0,0,467,465,1,0,0,
		0,468,470,3,137,68,0,469,468,1,0,0,0,469,470,1,0,0,0,470,492,1,0,0,0,471,
		472,5,48,0,0,472,473,7,4,0,0,473,475,5,46,0,0,474,476,3,149,74,0,475,474,
		1,0,0,0,476,477,1,0,0,0,477,475,1,0,0,0,477,478,1,0,0,0,478,480,1,0,0,
		0,479,481,3,137,68,0,480,479,1,0,0,0,480,481,1,0,0,0,481,492,1,0,0,0,482,
		483,5,48,0,0,483,485,7,4,0,0,484,486,3,149,74,0,485,484,1,0,0,0,486,487,
		1,0,0,0,487,485,1,0,0,0,487,488,1,0,0,0,488,489,1,0,0,0,489,490,3,137,
		68,0,490,492,1,0,0,0,491,454,1,0,0,0,491,471,1,0,0,0,491,482,1,0,0,0,492,
		134,1,0,0,0,493,495,7,5,0,0,494,496,7,6,0,0,495,494,1,0,0,0,495,496,1,
		0,0,0,496,498,1,0,0,0,497,499,3,147,73,0,498,497,1,0,0,0,499,500,1,0,0,
		0,500,498,1,0,0,0,500,501,1,0,0,0,501,136,1,0,0,0,502,504,7,7,0,0,503,
		505,7,6,0,0,504,503,1,0,0,0,504,505,1,0,0,0,505,507,1,0,0,0,506,508,3,
		147,73,0,507,506,1,0,0,0,508,509,1,0,0,0,509,507,1,0,0,0,509,510,1,0,0,
		0,510,138,1,0,0,0,511,512,5,92,0,0,512,522,7,8,0,0,513,515,5,92,0,0,514,
		516,5,13,0,0,515,514,1,0,0,0,515,516,1,0,0,0,516,517,1,0,0,0,517,522,5,
		10,0,0,518,522,3,141,70,0,519,522,3,143,71,0,520,522,3,145,72,0,521,511,
		1,0,0,0,521,513,1,0,0,0,521,518,1,0,0,0,521,519,1,0,0,0,521,520,1,0,0,
		0,522,140,1,0,0,0,523,524,5,92,0,0,524,535,3,147,73,0,525,526,5,92,0,0,
		526,527,3,147,73,0,527,528,3,147,73,0,528,535,1,0,0,0,529,530,5,92,0,0,
		530,531,7,9,0,0,531,532,3,147,73,0,532,533,3,147,73,0,533,535,1,0,0,0,
		534,523,1,0,0,0,534,525,1,0,0,0,534,529,1,0,0,0,535,142,1,0,0,0,536,537,
		5,92,0,0,537,538,5,120,0,0,538,539,3,149,74,0,539,540,3,149,74,0,540,144,
		1,0,0,0,541,542,5,92,0,0,542,543,5,117,0,0,543,544,5,123,0,0,544,546,1,
		0,0,0,545,547,3,149,74,0,546,545,1,0,0,0,547,548,1,0,0,0,548,546,1,0,0,
		0,548,549,1,0,0,0,549,550,1,0,0,0,550,551,5,125,0,0,551,146,1,0,0,0,552,
		553,7,10,0,0,553,148,1,0,0,0,554,555,7,11,0,0,555,150,1,0,0,0,556,557,
		8,12,0,0,557,152,1,0,0,0,558,559,5,45,0,0,559,560,5,45,0,0,560,561,5,91,
		0,0,561,562,1,0,0,0,562,563,3,125,62,0,563,564,5,93,0,0,564,565,1,0,0,
		0,565,566,6,76,0,0,566,154,1,0,0,0,567,568,5,45,0,0,568,569,5,45,0,0,569,
		573,1,0,0,0,570,572,3,151,75,0,571,570,1,0,0,0,572,575,1,0,0,0,573,571,
		1,0,0,0,573,574,1,0,0,0,574,576,1,0,0,0,575,573,1,0,0,0,576,577,6,77,0,
		0,577,156,1,0,0,0,578,580,7,13,0,0,579,578,1,0,0,0,580,581,1,0,0,0,581,
		579,1,0,0,0,581,582,1,0,0,0,582,583,1,0,0,0,583,584,6,78,1,0,584,158,1,
		0,0,0,585,586,5,35,0,0,586,590,5,33,0,0,587,589,3,151,75,0,588,587,1,0,
		0,0,589,592,1,0,0,0,590,588,1,0,0,0,590,591,1,0,0,0,591,593,1,0,0,0,592,
		590,1,0,0,0,593,594,6,79,0,0,594,160,1,0,0,0,35,0,368,374,376,384,386,
		403,407,412,419,424,430,434,440,443,448,452,459,465,469,477,480,487,491,
		495,500,504,509,515,521,534,548,573,581,590,2,0,1,0,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace AntlrTests.NekoScript
