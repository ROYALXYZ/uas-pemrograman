# AGENTS.md

## Project: C# Console Application (University Assignment)

**Stack:** C# console app, .NET Framework 4.7.2, MSBuild

### Build & Run

```powershell
# Build (Debug)
msbuild ConsoleApp1/ConsoleApp1.csproj /p:Configuration=Debug

# Build (Release)
msbuild ConsoleApp1/ConsoleApp1.csproj /p:Configuration=Release

# Run (after Debug build)
.\ConsoleApp1\bin\Debug\ConsoleApp1.exe

# Run (after Release build)
.\ConsoleApp1\bin\Release\ConsoleApp1.exe
```

### Structure

- **Entry point:** `ConsoleApp1/Program.cs` — `Main()` method
- **Config:** `ConsoleApp1/App.config` — .NET Framework startup config
- **Project file:** `ConsoleApp1/ConsoleApp1.csproj` — MSBuild format
- **Output:** `bin/Debug/` or `bin/Release/` (created after build)

### Important Notes

- **.NET Framework 4.7.2** (not modern .NET) — check API availability before using newer APIs
- No external dependencies; add via NuGet if needed (edit .csproj)
- No tests, CI/CD, or linting configured
- Not a git repo — this is a local university assignment folder
- Build artifacts in `bin/` and `obj/` can be safely deleted
