using BenchmarkDotNet.Attributes;
using Astral.Extensions.EnumHelper.Enums;

namespace Astral.Extensions.EnumHelper.BenchmarkTests
{
    public class EnumHelperBenchmark
    {
        public EnumHelperBenchmark()
        {
            
        }

        [Benchmark]
        public string[] GetAllApplicationNames() => EnumHelper.GetAllApplicationNames();

        [Benchmark]
        public string[] GetAllApplicationNamesOptimized() => EnumHelper.GetAllApplicationNamesOptimized();

        [Benchmark]
        public string GetApplicationName() => ApplicationInfo.RngService.GetApplicationName();

        [Benchmark]
        public string GetApplicationNameOptimized() => ApplicationInfo.RngService.GetApplicationNameOptimized();
    }
}
