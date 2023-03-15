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

namespace Cli.All.SQLiteNorthwind
{
	[Table("Order Details")]
	public class OrderDetail : IEquatable<OrderDetail>
	{
		[Column("OrderID"  , DataType = DataType.Int32 , DbType = "int"  , Length = 4, Precision = 10, Scale = 0, IsPrimaryKey = true, PrimaryKeyOrder = 0)] public int     OrderId   { get; set; } // int
		[Column("ProductID", DataType = DataType.Int32 , DbType = "int"  , Length = 4, Precision = 10, Scale = 0, IsPrimaryKey = true, PrimaryKeyOrder = 1)] public int     ProductId { get; set; } // int
		[Column("UnitPrice", DataType = DataType.Double, DbType = "float", Length = 8, Precision = 26, Scale = 0                                          )] public double? UnitPrice { get; set; } // float
		[Column("Quantity" , DataType = DataType.Int32 , DbType = "int"  , Length = 4, Precision = 10, Scale = 0                                          )] public int?    Quantity  { get; set; } // int
		[Column("Discount" , DataType = DataType.Double, DbType = "float", Length = 8, Precision = 13, Scale = 0                                          )] public double? Discount  { get; set; } // float

		#region IEquatable<T> support
		private static readonly IEqualityComparer<OrderDetail> _equalityComparer = ComparerBuilder.GetEqualityComparer<OrderDetail>(c => c.OrderId, c => c.ProductId);

		public bool Equals(OrderDetail? other)
		{
			return _equalityComparer.Equals(this, other!);
		}

		public override int GetHashCode()
		{
			return _equalityComparer.GetHashCode(this);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as OrderDetail);
		}
		#endregion
	}
}
