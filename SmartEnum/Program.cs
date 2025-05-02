
using Environment = SmartEnum.Enum.Environment;

Console.WriteLine("Index: {0}\n Name: {1}", Environment.Production.Index, Environment.Production);
Console.WriteLine("Index: {0}\n Name: {1}", Environment.EnvironmentVariable.Index, Environment.EnvironmentVariable);

Console.WriteLine("=======================================");

Console.WriteLine("Index using Cast: {0}\n Name: {1}", (int)Environment.Production, Environment.Production);
Console.WriteLine("Index using Cast: {0}\n Name: {1}", (int)Environment.EnvironmentVariable,
    Environment.EnvironmentVariable);