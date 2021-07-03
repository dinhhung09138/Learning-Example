using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MathNet.Numerics.Statistics;

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
            var array = new double[] { 1, 2, 3, 4, 5 };
            var max = array.Maximum();
            var min = array.Minimum();

            counterJs = await js.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");

            await counterJs.InvokeVoidAsync("Alert", $"Max value {max}, Min value {min}");
            await counterJs.InvokeVoidAsync("ConsoleLog", $"Max value {max}, Min value {min}");

            currentCount++;

        }

    }
}
