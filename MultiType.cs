using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessToolkit
{

    public class MultiType
    {
        private Double doubleValue;
        public Double AsDouble { get { return doubleValue; } }
        private Single singleValue;
        public Single AsFloat { get { return singleValue; } }
        private Int16 int16Value;
        public Int16 AsInt16 { get { return int16Value; } }
        private Int32 int32Value;
        public Int32 AsInt32 { get { return int32Value; } }
        private Int64 int64Value;
        public Int64 AsInt64 { get { return int64Value; } }
        private UInt16 uint16Value;
        public UInt16 AsUInt16 { get { return uint16Value; } }
        private UInt32 uint32Value;
        public UInt32 AsUInt32 { get { return uint32Value; } }
        private UInt64 uint64Value;
        public UInt64 AsUInt64 { get { return uint64Value; } }
        internal MultiType(Double d, Single s, Int16 i16, Int32 i32, Int64 i64, UInt16 u16, UInt32 u32, UInt64 u64)
        {
            doubleValue = d;
            singleValue = s;
            int16Value = i16;
            int32Value = i32;
            int64Value = i64;
            uint16Value = u16;
            uint32Value = u32;
            uint64Value = u64;
        }
    }
}
