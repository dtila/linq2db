// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using System.Collections.Generic;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.Fluent.SqlServer
{
	public class TestSchemaX
	{
		public int TestSchemaXid { get; set; } // int
		public int Field1        { get; set; } // int

		#region Associations
		/// <summary>
		/// FK_TestSchemaY_OtherID backreference
		/// </summary>
		public IEnumerable<TestSchemaY> TestSchemaY { get; set; } = null!;

		/// <summary>
		/// FK_TestSchemaY_ParentTestSchemaX backreference
		/// </summary>
		public IEnumerable<TestSchemaY> TestSchemaY1 { get; set; } = null!;
		#endregion
	}
}
