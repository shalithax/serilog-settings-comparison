﻿#r "C:\Dev\serilog-settings-comparison\test\Serilog.Settings.Comparison.Tests\bin\Debug\net46\TestDummies.dll"
using TestDummies;

LoggerConfiguration
    .WriteTo.Dummy(stringParam: "A string param", intParam: 666, nullableIntParam: null);
