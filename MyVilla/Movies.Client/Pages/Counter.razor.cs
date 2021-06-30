using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Movies.Client.Pages
{
    public partial class Counter
    {
        [Inject]
        SingleTonService singleTon { get; set; }

        [Inject] 
        TransientService transient {get; set;}

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            singleTon.Value += 1;
            transient.Value += 1;
        }

    }
}
