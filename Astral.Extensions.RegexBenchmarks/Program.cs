﻿// See https://aka.ms/new-console-template for more information
using Astral.Extensions.RegexBenchmarks;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<RegexVsRegexCompiled>();