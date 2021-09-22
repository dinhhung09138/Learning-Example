using System;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Component.Pages
{
    partial class Counter : ComponentBase
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }

        [JSInvokable]
        public static async Task StaticMethod()
        {
            await Task.Delay(0);
            Console.WriteLine("This is the static function call from javascript file");
        }
    }
}
