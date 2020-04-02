using System.Collections.Generic;

namespace VegaLite.Schema
{
    public struct Tooltip
    {
        public FieldDefWithConditionStringFieldDefString FieldDefWithConditionStringFieldDefString;
        public List<StringFieldDef>                      StringFieldDefArray;

        public static implicit operator Tooltip(FieldDefWithConditionStringFieldDefString fieldDefWithConditionStringFieldDefString)
        {
            return new Tooltip
            {
                FieldDefWithConditionStringFieldDefString = fieldDefWithConditionStringFieldDefString
            };
        }

        public static implicit operator Tooltip(List<StringFieldDef> stringFieldDefArray)
        {
            return new Tooltip
            {
                StringFieldDefArray = stringFieldDefArray
            };
        }

        public bool IsNull { get { return StringFieldDefArray == null && FieldDefWithConditionStringFieldDefString == null; } }
    }
}
