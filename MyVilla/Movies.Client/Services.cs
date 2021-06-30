using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Client
{
    public class SingleTonService
    {
        public int Value { get; set; }
    }

    public class TransientService
    {
        public int Value { get; set; }
    }
}
