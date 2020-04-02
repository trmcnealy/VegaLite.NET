using System;

using Newtonsoft.Json;

namespace VegaLite.Schema
{
    internal class CursorConverter : JsonConverter
    {
        public override bool CanConvert(Type t)
        {
            return t == typeof(Cursor) || t == typeof(Cursor?);
        }

        public override object ReadJson(JsonReader     reader,
                                        Type           t,
                                        object         existingValue,
                                        JsonSerializer serializer)
        {
            if(reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            string value = serializer.Deserialize<string>(reader);

            switch(value)
            {
                case "alias":         return Cursor.Alias;
                case "all-scroll":    return Cursor.AllScroll;
                case "auto":          return Cursor.Auto;
                case "cell":          return Cursor.Cell;
                case "col-resize":    return Cursor.ColResize;
                case "context-menu":  return Cursor.ContextMenu;
                case "copy":          return Cursor.Copy;
                case "crosshair":     return Cursor.Crosshair;
                case "default":       return Cursor.Default;
                case "e-resize":      return Cursor.EResize;
                case "ew-resize":     return Cursor.EwResize;
                case "grab":          return Cursor.Grab;
                case "grabbing":      return Cursor.Grabbing;
                case "help":          return Cursor.Help;
                case "move":          return Cursor.Move;
                case "n-resize":      return Cursor.NResize;
                case "ne-resize":     return Cursor.NeResize;
                case "nesw-resize":   return Cursor.NeswResize;
                case "no-drop":       return Cursor.NoDrop;
                case "none":          return Cursor.None;
                case "not-allowed":   return Cursor.NotAllowed;
                case "ns-resize":     return Cursor.NsResize;
                case "nw-resize":     return Cursor.NwResize;
                case "nwse-resize":   return Cursor.NwseResize;
                case "pointer":       return Cursor.Pointer;
                case "progress":      return Cursor.Progress;
                case "row-resize":    return Cursor.RowResize;
                case "s-resize":      return Cursor.SResize;
                case "se-resize":     return Cursor.SeResize;
                case "sw-resize":     return Cursor.SwResize;
                case "text":          return Cursor.Text;
                case "vertical-text": return Cursor.VerticalText;
                case "w-resize":      return Cursor.WResize;
                case "wait":          return Cursor.Wait;
                case "zoom-in":       return Cursor.ZoomIn;
                case "zoom-out":      return Cursor.ZoomOut;
            }

            throw new Exception("Cannot unmarshal type Cursor");
        }

        public override void WriteJson(JsonWriter     writer,
                                       object         untypedValue,
                                       JsonSerializer serializer)
        {
            if(untypedValue == null)
            {
                serializer.Serialize(writer,
                                     null);

                return;
            }

            Cursor value = (Cursor)untypedValue;

            switch(value)
            {
                case Cursor.Alias:
                    serializer.Serialize(writer,
                                         "alias");

                    return;
                case Cursor.AllScroll:
                    serializer.Serialize(writer,
                                         "all-scroll");

                    return;
                case Cursor.Auto:
                    serializer.Serialize(writer,
                                         "auto");

                    return;
                case Cursor.Cell:
                    serializer.Serialize(writer,
                                         "cell");

                    return;
                case Cursor.ColResize:
                    serializer.Serialize(writer,
                                         "col-resize");

                    return;
                case Cursor.ContextMenu:
                    serializer.Serialize(writer,
                                         "context-menu");

                    return;
                case Cursor.Copy:
                    serializer.Serialize(writer,
                                         "copy");

                    return;
                case Cursor.Crosshair:
                    serializer.Serialize(writer,
                                         "crosshair");

                    return;
                case Cursor.Default:
                    serializer.Serialize(writer,
                                         "default");

                    return;
                case Cursor.EResize:
                    serializer.Serialize(writer,
                                         "e-resize");

                    return;
                case Cursor.EwResize:
                    serializer.Serialize(writer,
                                         "ew-resize");

                    return;
                case Cursor.Grab:
                    serializer.Serialize(writer,
                                         "grab");

                    return;
                case Cursor.Grabbing:
                    serializer.Serialize(writer,
                                         "grabbing");

                    return;
                case Cursor.Help:
                    serializer.Serialize(writer,
                                         "help");

                    return;
                case Cursor.Move:
                    serializer.Serialize(writer,
                                         "move");

                    return;
                case Cursor.NResize:
                    serializer.Serialize(writer,
                                         "n-resize");

                    return;
                case Cursor.NeResize:
                    serializer.Serialize(writer,
                                         "ne-resize");

                    return;
                case Cursor.NeswResize:
                    serializer.Serialize(writer,
                                         "nesw-resize");

                    return;
                case Cursor.NoDrop:
                    serializer.Serialize(writer,
                                         "no-drop");

                    return;
                case Cursor.None:
                    serializer.Serialize(writer,
                                         "none");

                    return;
                case Cursor.NotAllowed:
                    serializer.Serialize(writer,
                                         "not-allowed");

                    return;
                case Cursor.NsResize:
                    serializer.Serialize(writer,
                                         "ns-resize");

                    return;
                case Cursor.NwResize:
                    serializer.Serialize(writer,
                                         "nw-resize");

                    return;
                case Cursor.NwseResize:
                    serializer.Serialize(writer,
                                         "nwse-resize");

                    return;
                case Cursor.Pointer:
                    serializer.Serialize(writer,
                                         "pointer");

                    return;
                case Cursor.Progress:
                    serializer.Serialize(writer,
                                         "progress");

                    return;
                case Cursor.RowResize:
                    serializer.Serialize(writer,
                                         "row-resize");

                    return;
                case Cursor.SResize:
                    serializer.Serialize(writer,
                                         "s-resize");

                    return;
                case Cursor.SeResize:
                    serializer.Serialize(writer,
                                         "se-resize");

                    return;
                case Cursor.SwResize:
                    serializer.Serialize(writer,
                                         "sw-resize");

                    return;
                case Cursor.Text:
                    serializer.Serialize(writer,
                                         "text");

                    return;
                case Cursor.VerticalText:
                    serializer.Serialize(writer,
                                         "vertical-text");

                    return;
                case Cursor.WResize:
                    serializer.Serialize(writer,
                                         "w-resize");

                    return;
                case Cursor.Wait:
                    serializer.Serialize(writer,
                                         "wait");

                    return;
                case Cursor.ZoomIn:
                    serializer.Serialize(writer,
                                         "zoom-in");

                    return;
                case Cursor.ZoomOut:
                    serializer.Serialize(writer,
                                         "zoom-out");

                    return;
            }

            throw new Exception("Cannot marshal type Cursor");
        }

        public static readonly CursorConverter Singleton = new CursorConverter();
    }
}
