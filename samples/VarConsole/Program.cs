using DotNetEnv;

Env.Load();
// See https://aka.ms/new-console-template for more information
var name = Environment.GetEnvironmentVariable("NAME");
var hobby = Environment.GetEnvironmentVariable("HOBBY");
var job = Environment.GetEnvironmentVariable("JOB");
Console.WriteLine($"Name: {name}\nHobby: {hobby}\nJob: {job}");
