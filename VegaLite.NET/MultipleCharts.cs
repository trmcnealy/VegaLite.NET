using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive.Formatting;

using static VegaLite.HtmlChart;

namespace VegaLite
{
    public class MultipleCharts
    {
        public Chart this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Charts[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Charts[index] = value; }
        }

        public Chart this[int row,
                          int column]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Charts[row * Columns + column]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Charts[row * Columns + column] = value; }
        }

        public Guid Id
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        public string Title
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        public int Rows
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        public int Columns
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        public Chart[] Charts
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get;
        }

        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //static MultipleCharts()
        //{
        //    Formatter<MultipleCharts>.Register((chart,
        //                                        writer) =>
        //                                       {
        //                                           writer.Write(chart.ToString());
        //                                       },
        //                                       HtmlFormatter.MimeType);
        //}
        //private MultipleCharts()
        //{
        //    Id            = Guid.NewGuid();

        //    Rows    = 0;
        //    Columns = 0;

        //    Charts = new Chart[Rows * Columns];
        //}

        public MultipleCharts(int rows,
                              int columns)
        {
            Id = Guid.NewGuid();

            Rows    = rows;
            Columns = columns;

            Charts = new Chart[Rows * Columns];
        }

        public MultipleCharts(string title,
                              int    rows,
                              int    columns)
        {
            Id = Guid.NewGuid();

            Title   = title;
            Rows    = rows;
            Columns = columns;

            Charts = new Chart[Rows * Columns];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return GetHtml();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string GetHtmlContent()
        {
            StringBuilder content = new StringBuilder();

            content.AppendLine($"<div id=\"{Id}\">\n");

            content.AppendLine();

            if(!string.IsNullOrEmpty(Title))
            {
                content.AppendLine($"{____}<h1>{Title}</h1>\n");
            }

            content.AppendLine($"{____}<table style=\"overflow-x:auto;border:1px solid black;width:100%\">");

            int fraction = 100 / Columns;

            List<Chart> charts = new List<Chart>(Rows * Columns);

            for(int row = 0; row < Rows; ++row)
            {
                content.AppendLine($"{________}<tr style=\"border:1px solid black\">");

                for(int column = 0; column < Columns; ++column)
                {
                    if(Charts[row * Columns + column] != null)
                    {
                        charts.Add(Charts[row * Columns + column]);

                        content.AppendLine($"{____________}<td style=\"border:1px solid black;width:{fraction:D0}%\">");

                        content.AppendLine(Charts[row * Columns + column].GetHtmlContent());

                        // content.AppendLine(Charts[row * Columns + column].GetHtmlContent().Replace("renderVegaLite",
                        //                                                                            $"renderVegaLite{Charts[row * Columns + column].Id.ToString().Replace("-", "")}"));

                        content.AppendLine($"{____________}</td>");
                    }
                }

                content.AppendLine($"{________}</tr>");
            }

            content.AppendLine($"{____}</table>\n");

            content.AppendLine(RequireJavaScriptFunction(____,
                                                         charts.ToArray()));

            content.AppendLine("</div>\n");

            return content.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string GetHtml()
        {
            return new HtmlString("<!DOCTYPE html>\n<html>\n<head>\n<meta charset=\"utf-8\"/>\n" + "</head>\n<body>\n" + GetHtmlContent() + "</body>\n</html>").ToString();

            //return new HtmlString(GetHtmlContent()).ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ShowInBrowser()
        {
            string tempPath = Path.GetTempPath();
            string path     = $"{Id.ToString()}.html";

            string text = Path.Combine(tempPath,
                                       path);

            File.WriteAllText(text,
                              ToString());

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = text, UseShellExecute = true
                };

                Process p = Process.Start(startInfo);

                if(p != null)
                {
                    p.EnableRaisingEvents = true;
                    p.WaitForInputIdle();
                }

                return;
            }

            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Process.Start("xdg-open",
                              text);

                return;
            }

            if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Process.Start("open",
                              text);

                return;
            }

            throw new InvalidOperationException("Not supported OS platform");
        }
    }
}