This is a copy of GF's official .NET bindings to GF's official C runtime:

- source: https://github.com/GrammaticalFramework/gf-core/tree/master/src/runtime/dotNet 
- documentation: http://www.grammaticalframework.org/doc/runtime-api.html#csharp

with the following changes:

- The target framework has been updated to .NET Framework 4.8 (the latest available at this time).

- The native DLLs (`gu.dll` and `pgf.dll`) are included for convenience.
  I stole the two DLLs from [here](https://github.com/luteberget/PGFSharp/tree/master/PGFSharp/build).
  I don't know which version of GF these DLLs correspond to but, from experimenting a little, I think they're probably *older* than GF 3.11.0 (the most recent version of GF at this time).
