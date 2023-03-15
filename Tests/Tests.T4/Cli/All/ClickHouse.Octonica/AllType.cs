// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using LinqToDB.Tools.Comparers;
using System;
using System.Collections.Generic;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.ClickHouse.Octonica
{
	[Table("AllTypes")]
	public class AllType : IEquatable<AllType>
	{
		[Column("ID"              , DataType = DataType.Int32   , DbType = "Int32"          , IsPrimaryKey = true, SkipOnUpdate = true)] public int     Id               { get; set; } // Int32
		[Column("intDataType"     , DataType = DataType.Int32   , DbType = "Int32"                                                    )] public int?    IntDataType      { get; set; } // Int32
		[Column("smallintDataType", DataType = DataType.Int16   , DbType = "Int16"                                                    )] public short?  SmallintDataType { get; set; } // Int16
		[Column("floatDataType"   , DataType = DataType.Single  , DbType = "Float32"                                                  )] public float?  FloatDataType    { get; set; } // Float32
		[Column("doubleDataType"  , DataType = DataType.Double  , DbType = "Float64"                                                  )] public double? DoubleDataType   { get; set; } // Float64
		[Column("ncharDataType"   , DataType = DataType.Binary  , DbType = "FixedString(20)", Length       = 20                       )] public byte[]? NcharDataType    { get; set; } // FixedString(20)
		[Column("char20DataType"  , DataType = DataType.Binary  , DbType = "FixedString(20)", Length       = 20                       )] public byte[]? Char20DataType   { get; set; } // FixedString(20)
		[Column("varcharDataType" , DataType = DataType.NVarChar, DbType = "String"                                                   )] public string? VarcharDataType  { get; set; } // String
		[Column("charDataType"    , DataType = DataType.Binary  , DbType = "FixedString(1)" , Length       = 1                        )] public byte[]? CharDataType     { get; set; } // FixedString(1)

		#region IEquatable<T> support
		private static readonly IEqualityComparer<AllType> _equalityComparer = ComparerBuilder.GetEqualityComparer<AllType>(c => c.Id);

		public bool Equals(AllType? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as AllType);
		}
		#endregion
	}
}
