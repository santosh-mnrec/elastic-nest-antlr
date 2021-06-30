//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Poc and Personal\dslq\Demo.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

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

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class DemoParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, BOOLEAN=3, NULL=4, COMPARISON_OPERATOR=5, AND=6, OR=7, 
		O=8, R=9, A=10, N=11, D=12, EQ=13, E=14, Q=15, NE=16, GT=17, LT=18, GE=19, 
		LE=20, CO=21, SW=22, EW=23, BR_OPEN=24, BR_CLOSE=25, ATTRNAME=26, STRING=27, 
		DOUBLE=28, INT=29, EXP=30, WS=31;
	public const int
		RULE_start = 0, RULE_query = 1, RULE_attrPath = 2, RULE_attrValue = 3;
	public static readonly string[] ruleNames = {
		"start", "query", "attrPath", "attrValue"
	};

	private static readonly string[] _LiteralNames = {
		null, "'.'", "'-'", null, "'null'", null, null, null, null, null, null, 
		null, null, null, null, null, "'ne'", "'gt'", "'lt'", "'ge'", "'le'", 
		"'co'", "'sw'", "'ew'", "'('", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, "BOOLEAN", "NULL", "COMPARISON_OPERATOR", "AND", "OR", 
		"O", "R", "A", "N", "D", "EQ", "E", "Q", "NE", "GT", "LT", "GE", "LE", 
		"CO", "SW", "EW", "BR_OPEN", "BR_CLOSE", "ATTRNAME", "STRING", "DOUBLE", 
		"INT", "EXP", "WS"
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

	public override string GrammarFileName { get { return "Demo.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static DemoParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public DemoParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public DemoParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class StartContext : ParserRuleContext {
		public QueryContext query() {
			return GetRuleContext<QueryContext>(0);
		}
		public StartContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_start; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.EnterStart(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.ExitStart(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDemoVisitor<TResult> typedVisitor = visitor as IDemoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStart(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StartContext start() {
		StartContext _localctx = new StartContext(Context, State);
		EnterRule(_localctx, 0, RULE_start);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 8; query(0);
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

	public partial class QueryContext : ParserRuleContext {
		public QueryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_query; } }
	 
		public QueryContext() { }
		public virtual void CopyFrom(QueryContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class CompareExpContext : QueryContext {
		public AttrPathContext propertyName;
		public IToken op;
		public AttrValueContext propertyValue;
		public AttrPathContext attrPath() {
			return GetRuleContext<AttrPathContext>(0);
		}
		public ITerminalNode COMPARISON_OPERATOR() { return GetToken(DemoParser.COMPARISON_OPERATOR, 0); }
		public AttrValueContext attrValue() {
			return GetRuleContext<AttrValueContext>(0);
		}
		public CompareExpContext(QueryContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.EnterCompareExp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.ExitCompareExp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDemoVisitor<TResult> typedVisitor = visitor as IDemoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCompareExp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AndLogicalExpContext : QueryContext {
		public QueryContext leftQuery;
		public IToken op;
		public QueryContext rightQuery;
		public QueryContext[] query() {
			return GetRuleContexts<QueryContext>();
		}
		public QueryContext query(int i) {
			return GetRuleContext<QueryContext>(i);
		}
		public ITerminalNode AND() { return GetToken(DemoParser.AND, 0); }
		public AndLogicalExpContext(QueryContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.EnterAndLogicalExp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.ExitAndLogicalExp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDemoVisitor<TResult> typedVisitor = visitor as IDemoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAndLogicalExp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BracketExpContext : QueryContext {
		public IToken leftBracket;
		public IToken rightBracket;
		public QueryContext query() {
			return GetRuleContext<QueryContext>(0);
		}
		public ITerminalNode BR_OPEN() { return GetToken(DemoParser.BR_OPEN, 0); }
		public ITerminalNode BR_CLOSE() { return GetToken(DemoParser.BR_CLOSE, 0); }
		public BracketExpContext(QueryContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.EnterBracketExp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.ExitBracketExp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDemoVisitor<TResult> typedVisitor = visitor as IDemoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBracketExp(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class OrLogicalExpContext : QueryContext {
		public QueryContext leftQuery;
		public IToken op;
		public QueryContext rightQuery;
		public QueryContext[] query() {
			return GetRuleContexts<QueryContext>();
		}
		public QueryContext query(int i) {
			return GetRuleContext<QueryContext>(i);
		}
		public ITerminalNode OR() { return GetToken(DemoParser.OR, 0); }
		public OrLogicalExpContext(QueryContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.EnterOrLogicalExp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.ExitOrLogicalExp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDemoVisitor<TResult> typedVisitor = visitor as IDemoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOrLogicalExp(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public QueryContext query() {
		return query(0);
	}

	private QueryContext query(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		QueryContext _localctx = new QueryContext(Context, _parentState);
		QueryContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_query, _p);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 19;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BR_OPEN:
				{
				_localctx = new BracketExpContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 11; ((BracketExpContext)_localctx).leftBracket = Match(BR_OPEN);
				State = 12; query(0);
				State = 13; ((BracketExpContext)_localctx).rightBracket = Match(BR_CLOSE);
				}
				break;
			case ATTRNAME:
				{
				_localctx = new CompareExpContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 15; ((CompareExpContext)_localctx).propertyName = attrPath();
				State = 16; ((CompareExpContext)_localctx).op = Match(COMPARISON_OPERATOR);
				State = 17; ((CompareExpContext)_localctx).propertyValue = attrValue();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 29;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 27;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
					case 1:
						{
						_localctx = new AndLogicalExpContext(new QueryContext(_parentctx, _parentState));
						((AndLogicalExpContext)_localctx).leftQuery = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_query);
						State = 21;
						if (!(Precpred(Context, 3))) throw new FailedPredicateException(this, "Precpred(Context, 3)");
						State = 22; ((AndLogicalExpContext)_localctx).op = Match(AND);
						State = 23; ((AndLogicalExpContext)_localctx).rightQuery = query(4);
						}
						break;
					case 2:
						{
						_localctx = new OrLogicalExpContext(new QueryContext(_parentctx, _parentState));
						((OrLogicalExpContext)_localctx).leftQuery = _prevctx;
						PushNewRecursionContext(_localctx, _startState, RULE_query);
						State = 24;
						if (!(Precpred(Context, 2))) throw new FailedPredicateException(this, "Precpred(Context, 2)");
						State = 25; ((OrLogicalExpContext)_localctx).op = Match(OR);
						State = 26; ((OrLogicalExpContext)_localctx).rightQuery = query(3);
						}
						break;
					}
					} 
				}
				State = 31;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,2,Context);
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

	public partial class AttrPathContext : ParserRuleContext {
		public ITerminalNode[] ATTRNAME() { return GetTokens(DemoParser.ATTRNAME); }
		public ITerminalNode ATTRNAME(int i) {
			return GetToken(DemoParser.ATTRNAME, i);
		}
		public AttrPathContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attrPath; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.EnterAttrPath(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.ExitAttrPath(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDemoVisitor<TResult> typedVisitor = visitor as IDemoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAttrPath(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AttrPathContext attrPath() {
		AttrPathContext _localctx = new AttrPathContext(Context, State);
		EnterRule(_localctx, 4, RULE_attrPath);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 32; Match(ATTRNAME);
			State = 35;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			if (_la==T__0) {
				{
				State = 33; Match(T__0);
				State = 34; Match(ATTRNAME);
				}
			}

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

	public partial class AttrValueContext : ParserRuleContext {
		public AttrValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_attrValue; } }
	 
		public AttrValueContext() { }
		public virtual void CopyFrom(AttrValueContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class BooleanContext : AttrValueContext {
		public ITerminalNode BOOLEAN() { return GetToken(DemoParser.BOOLEAN, 0); }
		public BooleanContext(AttrValueContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.EnterBoolean(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.ExitBoolean(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDemoVisitor<TResult> typedVisitor = visitor as IDemoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBoolean(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NullContext : AttrValueContext {
		public ITerminalNode NULL() { return GetToken(DemoParser.NULL, 0); }
		public NullContext(AttrValueContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.EnterNull(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.ExitNull(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDemoVisitor<TResult> typedVisitor = visitor as IDemoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNull(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class StringContext : AttrValueContext {
		public ITerminalNode STRING() { return GetToken(DemoParser.STRING, 0); }
		public StringContext(AttrValueContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.EnterString(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.ExitString(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDemoVisitor<TResult> typedVisitor = visitor as IDemoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitString(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DoubleContext : AttrValueContext {
		public ITerminalNode DOUBLE() { return GetToken(DemoParser.DOUBLE, 0); }
		public DoubleContext(AttrValueContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.EnterDouble(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.ExitDouble(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDemoVisitor<TResult> typedVisitor = visitor as IDemoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDouble(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class LongContext : AttrValueContext {
		public ITerminalNode INT() { return GetToken(DemoParser.INT, 0); }
		public ITerminalNode EXP() { return GetToken(DemoParser.EXP, 0); }
		public LongContext(AttrValueContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.EnterLong(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDemoListener typedListener = listener as IDemoListener;
			if (typedListener != null) typedListener.ExitLong(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDemoVisitor<TResult> typedVisitor = visitor as IDemoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLong(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public AttrValueContext attrValue() {
		AttrValueContext _localctx = new AttrValueContext(Context, State);
		EnterRule(_localctx, 6, RULE_attrValue);
		int _la;
		try {
			State = 48;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case BOOLEAN:
				_localctx = new BooleanContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 37; Match(BOOLEAN);
				}
				break;
			case NULL:
				_localctx = new NullContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 38; Match(NULL);
				}
				break;
			case STRING:
				_localctx = new StringContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 39; Match(STRING);
				}
				break;
			case DOUBLE:
				_localctx = new DoubleContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 40; Match(DOUBLE);
				}
				break;
			case T__1:
			case INT:
				_localctx = new LongContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 42;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if (_la==T__1) {
					{
					State = 41; Match(T__1);
					}
				}

				State = 44; Match(INT);
				State = 46;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
				case 1:
					{
					State = 45; Match(EXP);
					}
					break;
				}
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

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return query_sempred((QueryContext)_localctx, predIndex);
		}
		return true;
	}
	private bool query_sempred(QueryContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 3);
		case 1: return Precpred(Context, 2);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '!', '\x35', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x5', '\x3', '\x16', '\n', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\a', '\x3', '\x1E', 
		'\n', '\x3', '\f', '\x3', '\xE', '\x3', '!', '\v', '\x3', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x5', '\x4', '&', '\n', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', 
		'-', '\n', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', '\x31', '\n', 
		'\x5', '\x5', '\x5', '\x33', '\n', '\x5', '\x3', '\x5', '\x2', '\x3', 
		'\x4', '\x6', '\x2', '\x4', '\x6', '\b', '\x2', '\x2', '\x2', ':', '\x2', 
		'\n', '\x3', '\x2', '\x2', '\x2', '\x4', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x6', '\"', '\x3', '\x2', '\x2', '\x2', '\b', '\x32', '\x3', '\x2', 
		'\x2', '\x2', '\n', '\v', '\x5', '\x4', '\x3', '\x2', '\v', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\f', '\r', '\b', '\x3', '\x1', '\x2', '\r', '\xE', 
		'\a', '\x1A', '\x2', '\x2', '\xE', '\xF', '\x5', '\x4', '\x3', '\x2', 
		'\xF', '\x10', '\a', '\x1B', '\x2', '\x2', '\x10', '\x16', '\x3', '\x2', 
		'\x2', '\x2', '\x11', '\x12', '\x5', '\x6', '\x4', '\x2', '\x12', '\x13', 
		'\a', '\a', '\x2', '\x2', '\x13', '\x14', '\x5', '\b', '\x5', '\x2', '\x14', 
		'\x16', '\x3', '\x2', '\x2', '\x2', '\x15', '\f', '\x3', '\x2', '\x2', 
		'\x2', '\x15', '\x11', '\x3', '\x2', '\x2', '\x2', '\x16', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '\x17', '\x18', '\f', '\x5', '\x2', '\x2', '\x18', 
		'\x19', '\a', '\b', '\x2', '\x2', '\x19', '\x1E', '\x5', '\x4', '\x3', 
		'\x6', '\x1A', '\x1B', '\f', '\x4', '\x2', '\x2', '\x1B', '\x1C', '\a', 
		'\t', '\x2', '\x2', '\x1C', '\x1E', '\x5', '\x4', '\x3', '\x5', '\x1D', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1A', '\x3', '\x2', '\x2', 
		'\x2', '\x1E', '!', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x1F', ' ', '\x3', '\x2', '\x2', '\x2', ' ', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '!', '\x1F', '\x3', '\x2', '\x2', '\x2', '\"', 
		'%', '\a', '\x1C', '\x2', '\x2', '#', '$', '\a', '\x3', '\x2', '\x2', 
		'$', '&', '\a', '\x1C', '\x2', '\x2', '%', '#', '\x3', '\x2', '\x2', '\x2', 
		'%', '&', '\x3', '\x2', '\x2', '\x2', '&', '\a', '\x3', '\x2', '\x2', 
		'\x2', '\'', '\x33', '\a', '\x5', '\x2', '\x2', '(', '\x33', '\a', '\x6', 
		'\x2', '\x2', ')', '\x33', '\a', '\x1D', '\x2', '\x2', '*', '\x33', '\a', 
		'\x1E', '\x2', '\x2', '+', '-', '\a', '\x4', '\x2', '\x2', ',', '+', '\x3', 
		'\x2', '\x2', '\x2', ',', '-', '\x3', '\x2', '\x2', '\x2', '-', '.', '\x3', 
		'\x2', '\x2', '\x2', '.', '\x30', '\a', '\x1F', '\x2', '\x2', '/', '\x31', 
		'\a', ' ', '\x2', '\x2', '\x30', '/', '\x3', '\x2', '\x2', '\x2', '\x30', 
		'\x31', '\x3', '\x2', '\x2', '\x2', '\x31', '\x33', '\x3', '\x2', '\x2', 
		'\x2', '\x32', '\'', '\x3', '\x2', '\x2', '\x2', '\x32', '(', '\x3', '\x2', 
		'\x2', '\x2', '\x32', ')', '\x3', '\x2', '\x2', '\x2', '\x32', '*', '\x3', 
		'\x2', '\x2', '\x2', '\x32', ',', '\x3', '\x2', '\x2', '\x2', '\x33', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\t', '\x15', '\x1D', '\x1F', '%', ',', 
		'\x30', '\x32',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}