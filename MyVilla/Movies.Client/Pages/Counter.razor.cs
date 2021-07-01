using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using static Movies.Client.Shared.MainLayout;

namespace Movies.Client.Pages
{
    public partial class Counter
    {
        [Inject]
        SingleTonService singleTon { get; set; }

        [Inject] 
        TransientService transient {get; set;}

        [Inject]
        public IJSRuntime js { get; set; }

        private IJSObjectReference counterJs;

        [CascadingParameter(Name = "AppSetting")]
        public AppSetting appSetting { get; set; }

        private int currentCount = 0;

        private static int staticCounter = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            counterJs = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");

            await counterJs.InvokeVoidAsync("Alert", "Hello world");
            await counterJs.InvokeVoidAsync("ConsoleLog", "Log Hello world");

            currentCount++;
            singleTon.Value += 1;
            transient.Value += 1;
            staticCounter += 1;

            await js.InvokeVoidAsync("dotnetStaticInvocation");
        }

        public async Task IncrementCountJavaScript()
        {
            await js.InvokeVoidAsync("dotNetInstanceInvocation", DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetStaticCounter()
        {
            return Task.FromResult(staticCounter);
        }

    }
}
