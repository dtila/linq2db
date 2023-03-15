// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Mapping;
using Oracle.ManagedDataAccess.Types;
using System;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.Oracle
{
	[Table("LINQDATATYPESBC")]
	public class Linqdatatypesbc
	{
		[Column("ID"            , DataType = DataType.Decimal  , DbType = "NUMBER"       , Length = 22, Scale     = 0            )] public OracleDecimal? Id             { get; set; } // NUMBER
		[Column("MONEYVALUE"    , DataType = DataType.Decimal  , DbType = "NUMBER (10,4)", Length = 22, Precision = 10, Scale = 4)] public OracleDecimal? Moneyvalue     { get; set; } // NUMBER (10,4)
		[Column("DATETIMEVALUE" , DataType = DataType.DateTime2, DbType = "TIMESTAMP(6)" , Length = 11, Scale     = 6            )] public DateTime?      Datetimevalue  { get; set; } // TIMESTAMP(6)
		[Column("DATETIMEVALUE2", DataType = DataType.DateTime2, DbType = "TIMESTAMP(6)" , Length = 11, Scale     = 6            )] public DateTime?      Datetimevalue2 { get; set; } // TIMESTAMP(6)
		[Column("BOOLVALUE"     , DataType = DataType.Decimal  , DbType = "NUMBER"       , Length = 22, Scale     = 0            )] public OracleDecimal? Boolvalue      { get; set; } // NUMBER
		[Column("GUIDVALUE"     , DataType = DataType.Binary   , DbType = "RAW(16)"      , Length = 16                           )] public OracleBinary?  Guidvalue      { get; set; } // RAW(16)
		[Column("SMALLINTVALUE" , DataType = DataType.Decimal  , DbType = "NUMBER"       , Length = 22, Scale     = 0            )] public OracleDecimal? Smallintvalue  { get; set; } // NUMBER
		[Column("INTVALUE"      , DataType = DataType.Decimal  , DbType = "NUMBER"       , Length = 22, Scale     = 0            )] public OracleDecimal? Intvalue       { get; set; } // NUMBER
		[Column("BIGINTVALUE"   , DataType = DataType.Decimal  , DbType = "NUMBER (20,0)", Length = 22, Precision = 20, Scale = 0)] public OracleDecimal? Bigintvalue    { get; set; } // NUMBER (20,0)
		[Column("STRINGVALUE"   , DataType = DataType.VarChar  , DbType = "VARCHAR2(50)" , Length = 50                           )] public string?        Stringvalue    { get; set; } // VARCHAR2(50)
	}
}
