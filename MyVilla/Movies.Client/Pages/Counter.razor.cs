using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Movies.Client.Pages
{
    public partial class Counter
    {
        [Inject]
        public IJSRuntime js { get; set; }

        private IJSObjectReference counterJs;

        private int currentCount = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            counterJs = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");

            await counterJs.InvokeVoidAsync("Alert", "Hello world");
            await counterJs.InvokeVoidAsync("ConsoleLog", "Log Hello world");

            currentCount++;

            await js.InvokeVoidAsync("dotnetStaticInvocation");
        }

    }
}
