## .NET Conf

```bash
dotnet run --project src/Standard.Net471/Standard.Net471.csproj  --framework netcoreapp2.1
dotnet run --project src/Standard.Net471/Standard.Net471.csproj  --framework net471
dotnet run --project src/Standard.Net471/Standard.Net471.csproj  --framework net47

dotnet msbuild src/Standard.Net471/Standard.Net471.csproj /t:run /p:Configuration=Release /p:Framework=net471
dotnet msbuild src/Standard.Net471/Standard.Net471.csproj /t:Clean,Build

dotnet msbuild src/Standard.Net471/Standard.Net471.csproj -pp | grep run

dotnet run --mono --project src/Standard.Net471/Standard.Net471.csproj
```