using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeComponent1
{
    public sealed class Class1
    {
        public void InitAppCenter()
        {
            AppCenter.Start("afc4f213-f02e-4f74-ae42-6386100bdaf8", typeof(Analytics), typeof(Crashes));

        }
    }
}
