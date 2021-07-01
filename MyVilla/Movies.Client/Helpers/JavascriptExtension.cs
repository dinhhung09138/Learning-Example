using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client.Helpers
{
    public static class JavascriptExtension
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("console.log", "Confirm function");

            return await js.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask WriteLog(this IJSRuntime js ,string message)
        {
            await js.InvokeVoidAsync("writeLog", message);
        }
    }
}
