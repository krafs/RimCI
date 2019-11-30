using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RimCI
{
    [StaticConstructorOnStartup]
    public class Main
    {
        static Main()
        {
            Log.Message("Test mod that was built using GitHub Actions.");
        }
    }
