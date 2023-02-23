using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7.StringTests
{
    public class BenchTestsString
    {
        private static BenchmarkStrings benchmarkStrings=new BenchmarkStrings();

       

        [Benchmark]
        public string AddingSimple()
        {
            return benchmarkStrings.AddingSimple();
        }
        [Benchmark]
        public string AddingInCycle()
        {
            return benchmarkStrings.AddingInCycle();
        }
        [Benchmark]
        public string AddingByStringBuilder()
        {
            return benchmarkStrings.AddingByStringBuilder();
        }
        [Benchmark]
        public string AddingCustom()
        {
            return benchmarkStrings.AddingCustom();
        }
        
    }
}
