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


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IDemoListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class DemoBaseListener : IDemoListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="DemoParser.start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStart([NotNull] DemoParser.StartContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DemoParser.start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStart([NotNull] DemoParser.StartContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>compareExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompareExp([NotNull] DemoParser.CompareExpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>compareExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompareExp([NotNull] DemoParser.CompareExpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>andLogicalExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAndLogicalExp([NotNull] DemoParser.AndLogicalExpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>andLogicalExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAndLogicalExp([NotNull] DemoParser.AndLogicalExpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>bracketExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBracketExp([NotNull] DemoParser.BracketExpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>bracketExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBracketExp([NotNull] DemoParser.BracketExpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>orLogicalExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOrLogicalExp([NotNull] DemoParser.OrLogicalExpContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>orLogicalExp</c>
	/// labeled alternative in <see cref="DemoParser.query"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOrLogicalExp([NotNull] DemoParser.OrLogicalExpContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="DemoParser.attrPath"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAttrPath([NotNull] DemoParser.AttrPathContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="DemoParser.attrPath"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAttrPath([NotNull] DemoParser.AttrPathContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>boolean</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBoolean([NotNull] DemoParser.BooleanContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>boolean</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBoolean([NotNull] DemoParser.BooleanContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>null</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNull([NotNull] DemoParser.NullContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>null</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNull([NotNull] DemoParser.NullContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] DemoParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>string</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] DemoParser.StringContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>double</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDouble([NotNull] DemoParser.DoubleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>double</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDouble([NotNull] DemoParser.DoubleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>long</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLong([NotNull] DemoParser.LongContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>long</c>
	/// labeled alternative in <see cref="DemoParser.attrValue"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLong([NotNull] DemoParser.LongContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}