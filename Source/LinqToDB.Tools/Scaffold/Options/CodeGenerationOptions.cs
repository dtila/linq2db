﻿using System;
using System.Collections.Generic;

namespace LinqToDB.Scaffold
{
	/// <summary>
	/// General code-generation options, not related to data model directly.
	/// </summary>
	public sealed class CodeGenerationOptions
	{
		internal CodeGenerationOptions() { }

		/// <summary>
		/// Enables generation of nullable reference type annotations in generated code.
		/// Ignored if target language doesn't support nullable reference types.
		/// <list type="bullet">
		/// <item>Default: <c>true</c></item>
		/// <item>In T4 compability mode: <c>true</c></item>
		/// </list>
		/// </summary>
		public bool EnableNullableReferenceTypes { get; set; } = true;

		/// <summary>
		/// Gets or sets string, used for a single indentation level in generated code.
		/// <list type="bullet">
		/// <item>Default: <c>"\t"</c></item>
		/// <item>In T4 compability mode: <c>"\t"</c></item>
		/// </list>
		/// </summary>
		public string Indent { get; set; } = "\t";

		/// <summary>
		/// Gets or sets string, used as newline sequence in generated code.
		/// <list type="bullet">
		/// <item>Default: <see cref="Environment.NewLine"/></item>
		/// <item>In T4 compability mode: <c>"\r\n"</c></item>
		/// </list>
		/// </summary>
		public string NewLine { get; set; } = Environment.NewLine;

		/// <summary>
		/// Enables suppression of missing XML documentation warnings in generated code.
		/// Applicable only to code, generated without &lt;auto-generated /&gt; comment.
		/// <list type="bullet">
		/// <item>Default: <c>true</c></item>
		/// <item>In T4 compability mode: <c>true</c> (both CS1573 and CS1591, T4 supporessed only CS1591)</item>
		/// </list>
		/// </summary>
		public bool SuppressMissingXmlDocWarnings { get; set; } = true;

		/// <summary>
		/// Adds &lt;auto-generated /&gt; comment to generated code.
		/// <list type="bullet">
		/// <item>Default: <c>true</c></item>
		/// <item>In T4 compability mode: <c>true</c></item>
		/// </list>
		/// </summary>
		public bool MarkAsAutoGenerated { get; set; } = true;

		/// <summary>
		/// Enables class-per-file generation. Otherwise all code will be generated in single file.
		/// <list type="bullet">
		/// <item>Default: <c>true</c></item>
		/// <item>In T4 compability mode: <c>false</c></item>
		/// </list>
		/// </summary>
		public bool ClassPerFile { get; set; } = true;

		/// <summary>
		/// List of type and/or namespace names that conflict with generated code. Used to adjust code-generation to resolve conflicts.
		/// Name should include both namespace and type name (for types) with dot as namespace separator and plus as nested class separator.
		/// E.g. <c>My.Namespace.SomeType+NestedType</c>.
		/// <list type="bullet">
		/// <item>Default: empty</item>
		/// <item>In T4 compability mode: empty</item>
		/// </list>
		/// </summary>
		public ISet<string> ConflictingNames { get; } = new HashSet<string>();

		/// <summary>
		/// Optional header comment text on top of each generated file. Will be wrapped into &lt;auto-generated&gt; tag.
		/// Used only when <see cref="MarkAsAutoGenerated"/> is set.
		/// When <c>null</c>, default linq2db header text will be used.
		/// </summary>
		public string? AutoGeneratedHeader { get; set; }

		/// <summary>
		/// Gets or sets namespace name for generated code.
		/// <list type="bullet">
		/// <item>Default: <c>"DataModel"</c></item>
		/// <item>In T4 compability mode: <c>"DataModel"</c></item>
		/// </list>
		/// </summary>
		public string? Namespace { get; set; } = "DataModel";
	}
}