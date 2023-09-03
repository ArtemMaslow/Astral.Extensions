// See https://aka.ms/new-console-template for more information
using Astral.Extensions.EnumHelper.BenchmarkTests;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<EnumHelperBenchmark>();
