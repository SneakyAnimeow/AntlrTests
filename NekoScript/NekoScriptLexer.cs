//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/sneakyanimeow/RiderProjects/AntlrTests/NekoScript/NekoScript.g4 by ANTLR 4.12.0

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
public partial class NekoScriptLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, VAR=24, NUMERIC=25, 
		INT=26, FLOAT=27, ID=28, STRING=29, BOOL=30, WS=31, COMMENT=32, LINE_COMMENT=33;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "VAR", "NUMERIC", 
		"INT", "FLOAT", "ID", "STRING", "BOOL", "WS", "COMMENT", "LINE_COMMENT"
	};


	public NekoScriptLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public NekoScriptLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'='", "'+'", "'-'", "'*'", "'/'", "'%'", "'^'", "'=='", "'!='", 
		"'<'", "'<='", "'>'", "'>='", "'&&'", "'||'", "'?'", "':'", "'('", "')'", 
		"'['", "']'", "'.'", "','", "'var'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"VAR", "NUMERIC", "INT", "FLOAT", "ID", "STRING", "BOOL", "WS", "COMMENT", 
		"LINE_COMMENT"
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

	public override string GrammarFileName { get { return "NekoScript.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static NekoScriptLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,33,203,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,1,0,1,0,1,1,1,1,1,2,1,2,1,
		3,1,3,1,4,1,4,1,5,1,5,1,6,1,6,1,7,1,7,1,7,1,8,1,8,1,8,1,9,1,9,1,10,1,10,
		1,10,1,11,1,11,1,12,1,12,1,12,1,13,1,13,1,13,1,14,1,14,1,14,1,15,1,15,
		1,16,1,16,1,17,1,17,1,18,1,18,1,19,1,19,1,20,1,20,1,21,1,21,1,22,1,22,
		1,23,1,23,1,23,1,23,1,24,1,24,3,24,126,8,24,1,25,4,25,129,8,25,11,25,12,
		25,130,1,26,5,26,134,8,26,10,26,12,26,137,9,26,1,26,1,26,4,26,141,8,26,
		11,26,12,26,142,1,27,1,27,5,27,147,8,27,10,27,12,27,150,9,27,1,28,1,28,
		5,28,154,8,28,10,28,12,28,157,9,28,1,28,1,28,1,29,1,29,1,29,1,29,1,29,
		1,29,1,29,1,29,1,29,3,29,170,8,29,1,30,4,30,173,8,30,11,30,12,30,174,1,
		30,1,30,1,31,1,31,1,31,1,31,5,31,183,8,31,10,31,12,31,186,9,31,1,31,1,
		31,1,31,1,31,1,31,1,32,1,32,1,32,1,32,5,32,197,8,32,10,32,12,32,200,9,
		32,1,32,1,32,2,155,184,0,33,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,
		10,21,11,23,12,25,13,27,14,29,15,31,16,33,17,35,18,37,19,39,20,41,21,43,
		22,45,23,47,24,49,25,51,26,53,27,55,28,57,29,59,30,61,31,63,32,65,33,1,
		0,5,1,0,48,57,3,0,65,90,95,95,97,122,4,0,48,57,65,90,95,95,97,122,3,0,
		9,10,12,13,32,32,2,0,10,10,13,13,212,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,
		0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,
		1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,
		0,0,29,1,0,0,0,0,31,1,0,0,0,0,33,1,0,0,0,0,35,1,0,0,0,0,37,1,0,0,0,0,39,
		1,0,0,0,0,41,1,0,0,0,0,43,1,0,0,0,0,45,1,0,0,0,0,47,1,0,0,0,0,49,1,0,0,
		0,0,51,1,0,0,0,0,53,1,0,0,0,0,55,1,0,0,0,0,57,1,0,0,0,0,59,1,0,0,0,0,61,
		1,0,0,0,0,63,1,0,0,0,0,65,1,0,0,0,1,67,1,0,0,0,3,69,1,0,0,0,5,71,1,0,0,
		0,7,73,1,0,0,0,9,75,1,0,0,0,11,77,1,0,0,0,13,79,1,0,0,0,15,81,1,0,0,0,
		17,84,1,0,0,0,19,87,1,0,0,0,21,89,1,0,0,0,23,92,1,0,0,0,25,94,1,0,0,0,
		27,97,1,0,0,0,29,100,1,0,0,0,31,103,1,0,0,0,33,105,1,0,0,0,35,107,1,0,
		0,0,37,109,1,0,0,0,39,111,1,0,0,0,41,113,1,0,0,0,43,115,1,0,0,0,45,117,
		1,0,0,0,47,119,1,0,0,0,49,125,1,0,0,0,51,128,1,0,0,0,53,135,1,0,0,0,55,
		144,1,0,0,0,57,151,1,0,0,0,59,169,1,0,0,0,61,172,1,0,0,0,63,178,1,0,0,
		0,65,192,1,0,0,0,67,68,5,61,0,0,68,2,1,0,0,0,69,70,5,43,0,0,70,4,1,0,0,
		0,71,72,5,45,0,0,72,6,1,0,0,0,73,74,5,42,0,0,74,8,1,0,0,0,75,76,5,47,0,
		0,76,10,1,0,0,0,77,78,5,37,0,0,78,12,1,0,0,0,79,80,5,94,0,0,80,14,1,0,
		0,0,81,82,5,61,0,0,82,83,5,61,0,0,83,16,1,0,0,0,84,85,5,33,0,0,85,86,5,
		61,0,0,86,18,1,0,0,0,87,88,5,60,0,0,88,20,1,0,0,0,89,90,5,60,0,0,90,91,
		5,61,0,0,91,22,1,0,0,0,92,93,5,62,0,0,93,24,1,0,0,0,94,95,5,62,0,0,95,
		96,5,61,0,0,96,26,1,0,0,0,97,98,5,38,0,0,98,99,5,38,0,0,99,28,1,0,0,0,
		100,101,5,124,0,0,101,102,5,124,0,0,102,30,1,0,0,0,103,104,5,63,0,0,104,
		32,1,0,0,0,105,106,5,58,0,0,106,34,1,0,0,0,107,108,5,40,0,0,108,36,1,0,
		0,0,109,110,5,41,0,0,110,38,1,0,0,0,111,112,5,91,0,0,112,40,1,0,0,0,113,
		114,5,93,0,0,114,42,1,0,0,0,115,116,5,46,0,0,116,44,1,0,0,0,117,118,5,
		44,0,0,118,46,1,0,0,0,119,120,5,118,0,0,120,121,5,97,0,0,121,122,5,114,
		0,0,122,48,1,0,0,0,123,126,3,51,25,0,124,126,3,53,26,0,125,123,1,0,0,0,
		125,124,1,0,0,0,126,50,1,0,0,0,127,129,7,0,0,0,128,127,1,0,0,0,129,130,
		1,0,0,0,130,128,1,0,0,0,130,131,1,0,0,0,131,52,1,0,0,0,132,134,7,0,0,0,
		133,132,1,0,0,0,134,137,1,0,0,0,135,133,1,0,0,0,135,136,1,0,0,0,136,138,
		1,0,0,0,137,135,1,0,0,0,138,140,5,46,0,0,139,141,7,0,0,0,140,139,1,0,0,
		0,141,142,1,0,0,0,142,140,1,0,0,0,142,143,1,0,0,0,143,54,1,0,0,0,144,148,
		7,1,0,0,145,147,7,2,0,0,146,145,1,0,0,0,147,150,1,0,0,0,148,146,1,0,0,
		0,148,149,1,0,0,0,149,56,1,0,0,0,150,148,1,0,0,0,151,155,5,34,0,0,152,
		154,9,0,0,0,153,152,1,0,0,0,154,157,1,0,0,0,155,156,1,0,0,0,155,153,1,
		0,0,0,156,158,1,0,0,0,157,155,1,0,0,0,158,159,5,34,0,0,159,58,1,0,0,0,
		160,161,5,116,0,0,161,162,5,114,0,0,162,163,5,117,0,0,163,170,5,101,0,
		0,164,165,5,102,0,0,165,166,5,97,0,0,166,167,5,108,0,0,167,168,5,115,0,
		0,168,170,5,101,0,0,169,160,1,0,0,0,169,164,1,0,0,0,170,60,1,0,0,0,171,
		173,7,3,0,0,172,171,1,0,0,0,173,174,1,0,0,0,174,172,1,0,0,0,174,175,1,
		0,0,0,175,176,1,0,0,0,176,177,6,30,0,0,177,62,1,0,0,0,178,179,5,47,0,0,
		179,180,5,42,0,0,180,184,1,0,0,0,181,183,9,0,0,0,182,181,1,0,0,0,183,186,
		1,0,0,0,184,185,1,0,0,0,184,182,1,0,0,0,185,187,1,0,0,0,186,184,1,0,0,
		0,187,188,5,42,0,0,188,189,5,47,0,0,189,190,1,0,0,0,190,191,6,31,1,0,191,
		64,1,0,0,0,192,193,5,47,0,0,193,194,5,47,0,0,194,198,1,0,0,0,195,197,8,
		4,0,0,196,195,1,0,0,0,197,200,1,0,0,0,198,196,1,0,0,0,198,199,1,0,0,0,
		199,201,1,0,0,0,200,198,1,0,0,0,201,202,6,32,1,0,202,66,1,0,0,0,11,0,125,
		130,135,142,148,155,169,174,184,198,2,6,0,0,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace AntlrTests.NekoScript