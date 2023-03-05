using System;

namespace FM.SHD.Infrastructure.Dal.Providers
{
    public class DataParameter
    {
        #region Private member variables

        private readonly DataParameterType _dataType;
        private readonly string _name;
        private readonly object _value;

        #endregion

        #region Public properties

        public string Name => _name;
        public object Value => _value;
        public DataParameterType DataType => _dataType;

        #endregion

        #region Constructors

        public DataParameter(DataParameterType dataType, string name, object value)
        {
            _dataType = dataType;
            _name = name;
            _value = value;
        }
        public DataParameter(string name, object value, TypeCode code)
        {
            _dataType = ConvertFromCode(code);
            _name = name;
            _value = value;
        }
        public DataParameter(string name, DateTime value)
        {
            _name = name;
            _value = value;
            _dataType = DataParameterType.DateTime;
        }
        public DataParameter(string name, DateTime? value)
        {
            _name = name;
            if (value.HasValue)
            {
                _value = value.Value;

                _dataType = DataParameterType.DateTime;
            }
            else
            {
                _value = DBNull.Value;
                _dataType = DataParameterType.Null;
            }
        }
        public DataParameter(string name, byte[] value)
        {
            _name = name;
            _value = value;
            _dataType = DataParameterType.ByteArray;
        }
        public DataParameter(string name, decimal value)
        {
            _name = name;
            _value = value;
            _dataType = DataParameterType.Decimal;
        }
        public DataParameter(string name, decimal? value)
        {
            _name = name;
            if (value.HasValue)
            {
                _value = value.Value;

                _dataType = DataParameterType.Decimal;
            }
            else
            {
                _value = DBNull.Value;
                _dataType = DataParameterType.Null;
            }
        }
        public DataParameter(string name, int value)
        {
            _name = name;
            _value = value;
            _dataType = DataParameterType.Int32;
        }    
        public DataParameter(string name, bool value)
        {
            _name = name;
            _value = value;
            _dataType = DataParameterType.Boolean;
        }
        public DataParameter(string name, int? value)
        {
            _name = name;
            if (value.HasValue)
            {
                _value = value.Value;

                _dataType = DataParameterType.Int32;
            }
            else
            {
                _value = DBNull.Value;
                _dataType = DataParameterType.Null;
            }
        }
        public DataParameter(string name, DBNull value)
        {
            _name = name;
            _value = DBNull.Value;
            _dataType = DataParameterType.Null;
        }
        public DataParameter(string name, long value)
        {
            _name = name;
            _value = value;
            _dataType = DataParameterType.Int64;
        }
        public DataParameter(string name, long? value)
        {
            _name = name;
            if (value.HasValue)
            {
                _value = value.Value;

                _dataType = DataParameterType.Int64;
            }
            else
            {
                _value = DBNull.Value;
                _dataType = DataParameterType.Null;
            }
        }
        public DataParameter(string name, string value)
        {
            _name = name;
            _value = value;
            _dataType = DataParameterType.String;
        }
        public DataParameter(string name, double value)
        {
            _name = name;
            _value = value;
            _dataType = DataParameterType.Double;
        }
        public DataParameter(string name, decimal[] value)
        {
            _name = name;
            _value = value;
            _dataType = DataParameterType.DecimalArray;
        }

        #endregion

        #region Public methods

        public override string ToString()
        {
            return string.Format("{0}={1}", Name, Value);
        }

        #endregion

        #region Private methods

        private DataParameterType ConvertFromCode(TypeCode code)
        {
            switch (code)
            {
                case TypeCode.Object:
                    throw new ArgumentOutOfRangeException("dataType", "Не объект");
                case TypeCode.Empty:
                case TypeCode.DBNull:
                    return DataParameterType.Null;
                case TypeCode.Boolean:
                    return DataParameterType.Boolean;
                case TypeCode.Int64:
                case TypeCode.UInt64:
                    return DataParameterType.Int64;
                case TypeCode.SByte:
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Int32:
                case TypeCode.UInt32:
                    return DataParameterType.Int32;
                case TypeCode.Single:
                case TypeCode.Double:
                    return DataParameterType.Double;
                case TypeCode.Decimal:
                    return DataParameterType.Decimal;
                case TypeCode.DateTime:
                    return DataParameterType.DateTime;
                case TypeCode.String:
                case TypeCode.Char:
                    return DataParameterType.String;
                default:
                    throw new ArgumentOutOfRangeException("dataType");
            }
        }

        #endregion
    }
}
