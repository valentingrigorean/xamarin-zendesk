using System;
using ObjCRuntime;

[Native]
public enum ZDKLogLevel : nint
{
	Error = 0,
	Warn = 1,
	Info = 2,
	Debug = 3,
	Verbose = 4
}
