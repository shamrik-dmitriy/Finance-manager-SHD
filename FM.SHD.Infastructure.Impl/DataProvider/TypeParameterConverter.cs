using FM.SHD.Infrastructure.Dal.Providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infastructure.Impl.DataProvider
{
    internal static class TypeParameterConverter
    {
        public static DbType ToDbType(DataParameterType type)
        {
            switch (type)
            {
                case DataParameterType.Decimal:
                    return DbType.Decimal;
                case DataParameterType.Int64:
                    return DbType.Int64;
                case DataParameterType.Int32:
                    return DbType.Int32;
                case DataParameterType.DateTime:
                    return DbType.DateTime;
                case DataParameterType.Boolean:
                    return DbType.Boolean;
                case DataParameterType.Double:
                    return DbType.Double;
                case DataParameterType.String:
                    return DbType.String;
            }
            return DbType.String;
        }

        public static DataParameterType ToParameterType(DbType dbType)
        {
            switch (dbType)
            {
                case DbType.AnsiString:
                case DbType.Guid:
                case DbType.Object:
                case DbType.String:
                case DbType.AnsiStringFixedLength:
                case DbType.StringFixedLength:
                case DbType.Xml:
                    return DataParameterType.String;
                case DbType.Byte:
                case DbType.Int16:
                case DbType.Int32:
                case DbType.SByte:
                case DbType.UInt16:
                case DbType.UInt32:
                    return DataParameterType.Int32;
                case DbType.Int64:
                case DbType.UInt64:
                    return DataParameterType.Int64;
                case DbType.Decimal:
                case DbType.Time:
                case DbType.VarNumeric:
                case DbType.DateTimeOffset:
                case DbType.Currency:
                    return DataParameterType.Decimal;
                case DbType.Boolean:
                    return DataParameterType.Boolean;
                case DbType.Date:
                case DbType.DateTime:
                case DbType.DateTime2:
                    return DataParameterType.DateTime;
                case DbType.Double:
                case DbType.Single:
                    return DataParameterType.Double;
            }
            return DataParameterType.String;
        }
    }
}
