using NUnit.Framework;
//This file is required for tests to run in parallel
//This file can be created and just called assembly info and must be placed where in the test project
[assembly: Parallelizable(ParallelScope.Fixtures)]
