# MSBuild XslTransformation Whitespace Issue
Project to reproduce [dotnet/msbuild!7671](https://github.com/dotnet/msbuild/issues/7671).

How to run:
- clone this repository
- execute `dotnet run`

What happens:
Two .proto files are generated:
- `Program.cs` uses `xsl/fdl2proto.xsl` on `GreetingProvider.sila.xml` to generate `GreetingProviderExpected.proto`
- `MSBuildXslTransformationIssue.csproj` uses `xsl/fdl2proto.xsl` on `GreetingProvider.sila.xml` to generate `GreetingProviderMSBuild.proto`

What I expect: Both files have the same content.

What actually happens: MSBuild does not correctly output whitespace
