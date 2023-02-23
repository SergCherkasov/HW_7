using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using HW_7.StringTests;

//var bs = new BenchmarkStrings();
//Console.WriteLine(bs.AddingSimple());
//Console.WriteLine(bs.AddingInCycle());
//Console.WriteLine(bs.AddingByStringBuilder());
//Console.WriteLine(bs.AddingCustom());

BenchmarkDotNet.Configs.ManualConfig config = DefaultConfig.Instance
   .AddJob(Job
        .MediumRun
        .WithLaunchCount(1)
        .WithToolchain(InProcessEmitToolchain.Instance));

BenchmarkRunner.Run<BenchTestsString>(config);