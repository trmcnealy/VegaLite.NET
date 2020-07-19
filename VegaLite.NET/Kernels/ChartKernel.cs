using System.Threading.Tasks;

using Microsoft.DotNet.Interactive;
using Microsoft.DotNet.Interactive.Formatting;

namespace VegaLite
{
    public sealed class ChartKernel : IKernelExtension
    {
        public async Task OnLoadAsync(IKernel kernel)
        {
            Formatter<Chart>.Register((chart,
                                       writer) =>
                                      {
                                          writer.Write(chart.ToString());
                                      },
                                      HtmlFormatter.MimeType);

            //if (kernel is KernelBase kernelBase)
            //{
            //    var arcGISCommand = new Command("#!arcgis", "Displays a clock showing the current or specified time.")
            //    {
            //    };
            //
            //    clockCommand.Handler = CommandHandler.Create(async (int hour, int minute, int second, KernelInvocationContext context) => 
            //    {
            //        await context.DisplayAsync(SvgClock.DrawSvgClock(hour, minute, second));
            //    });
            //
            //    kernelBase.AddDirective(clockCommand);
            //}

            if (KernelInvocationContext.Current is { } context)
            {
                await context.DisplayAsync($"`{nameof(ChartKernel)}` is loaded.", "text/markdown");
            }
        }
    }
}
