using System.Collections.Generic;

namespace VegaLite
{
    public struct Tooltip
    {
        public FieldDefWithConditionStringFieldDefString FieldDefWithConditionStringFieldDefString;
        public List<StringFieldDef>                      StringFieldDefArray;

        public static implicit operator Tooltip(FieldDefWithConditionStringFieldDefString fieldDefWithConditionStringFieldDefString) => new Tooltip { FieldDefWithConditionStringFieldDefString = fieldDefWithConditionStringFieldDefString };
        public static implicit operator Tooltip(List<StringFieldDef>                      stringFieldDefArray)                       => new Tooltip { StringFieldDefArray                       = stringFieldDefArray };
        public                          bool IsNull                                                                                  => StringFieldDefArray == null && FieldDefWithConditionStringFieldDefString == null;
    }
}