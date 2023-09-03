using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Astral.Extensions.RegexBenchmarks
{
    public class RegexVsRegexCompiled
    {
        private const string _emailRegexTemplate = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        private static Regex _compiledEmailRegex = new Regex(_emailRegexTemplate, RegexOptions.Compiled);
        private static Regex _emailRegex = new Regex(_emailRegexTemplate);
        private static string _testEmail = "test@test.ru";

        [Benchmark]
        public static bool IsEmail()
        {
            return _emailRegex.IsMatch(_testEmail);
        }

        [Benchmark]
        public static bool IsEmailRegexCompiled()
        {
            return _compiledEmailRegex.IsMatch(_testEmail);
        }
    }
}
