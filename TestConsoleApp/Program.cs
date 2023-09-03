// See https://aka.ms/new-console-template for more information
using Astral.Extensions.EnumHelper;
using Astral.Extensions.EnumHelper.Enums;
using BenchmarkDotNet.Running;
using TestConsoleApp;

//var summary = BenchmarkRunner.Run<GetAllApplicationNamesComparison>();
var t = EnumHelper.GetAllApplicationNames<ApplicationInfo>();
//var t1 = ApplicationInfo.CompanyGroupService.GetApplicationName();
Console.ReadLine();