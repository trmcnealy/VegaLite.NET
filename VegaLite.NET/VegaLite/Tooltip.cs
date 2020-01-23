using System.Collections.Generic;

namespace VegaLite
{
    public struct Tooltip
    {
        public FieldDefWithConditionStringFieldDefString FieldDefWithConditionStringFieldDefString;
        public List<StringFieldDef>                      StringFieldDefArray;

        public static implicit operator Tooltip(FieldDefWithConditionStringFieldDefString FieldDefWithConditionStringFieldDefString) => new Tooltip { FieldDefWithConditionStringFieldDefString = FieldDefWithConditionStringFieldDefString };
        public static implicit operator Tooltip(List<StringFieldDef>                      StringFieldDefArray)                       => new Tooltip { StringFieldDefArray                       = StringFieldDefArray };
        public                          bool IsNull                                                                                  => StringFieldDefArray == null && FieldDefWithConditionStringFieldDefString == null;
    }
}