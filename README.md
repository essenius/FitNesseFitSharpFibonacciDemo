# Introduction 
This repo contains a few demo on how to use FitNesse with FitSharp. It include FitNesse test pages as well as corresponding C# fixtures. 

# Getting Started
1. Ensure you have a Java JRE installed (8 or higher, preferably 11)
2. Create folder ```%LOCALAPPDATA%\FitNesse```
3. Download FitNesse from http://fitnesse.org/FitNesseDownload and copy or move ```fitnesse-standalone.jar``` to the just created folder ```%LOCALAPPDATA%\FitNesse```
4. Install FitSharp into ```%LOCALAPPDATA%\FitSharp```. The easiest way to do that is using the NuGet CLI which you can get from from https://dist.nuget.org/win-x86-commandline/latest/nuget.exe:
```
    nuget install fitsharp -OutputDirectory %LOCALAPPDATA% -ExcludeVersion
```
4. Download the repo as a ZIP file and extract the contents of the folder ```FitNesseFitSharpFibonacciDemo``` into ```%LOCALAPPDATA%\FitNesse```
5. If you took a different folder for FitSharp, update ```plugins.properties``` accordingly.
6. Build the solution ```ExtendedMath```:
```
    dotnet build %LOCALAPPDATA%\FitNesse\ExtendedMath\ExtendedMath.sln
```
7. Start FitNesse with the root repo folder as the data folder, and the assembly folder as the current directory:
```
    cd /D %LOCALAPPDATA%\ExtendedMath\ExtendedMathFixtures\bin\debug\net5.0
    java -jar %LOCALAPPDATA%\FitNesse\fitnesse-standalone.jar -d %LOCALAPPDATA%\FitNesse -e 0
```	
8. Open a browser and enter the URL http://localhost:8080/FibonacciTest?test

# Contribute
Enter an issue or provide a pull request. 
