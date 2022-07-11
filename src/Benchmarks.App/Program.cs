// See https://aka.ms/new-console-template for more information
using Benchmark.TestsLibrary.ComparsionOfAny;
using Benchmark.TestsLibrary.ForEachTests;
using Benchmark.TestsLibrary.StringTests;
using BenchmarkDotNet.Running;

//BenchmarkRunner.Run<StartWithTests>();
//BenchmarkRunner.Run<ForEachTests>();
BenchmarkRunner.Run<AnyVsContainsTests>();
//BenchmarkRunner.Run<CollectionContainsAnyItemTests>();

Console.ReadLine();
