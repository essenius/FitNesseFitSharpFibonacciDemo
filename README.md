# Introduction 
This repo contains a demo on how to use FitNesse with FitSharp. It include a FitNesse test page as well as a corresponding C# fixture. 

# Installation and Startup

## Windows
1. Ensure you have a Java JRE installed (8 or higher, preferably 11). OpenJDK 11 has been tested and works well.
2. Ensure that Java is in the path.
3. Create folder for FitNesse: ```mkdir %LOCALAPPDATA%\FitNesse``` 
4. Download FitNesse from http://fitnesse.org/FitNesseDownload and copy or move ```fitnesse-standalone.jar``` to ```%LOCALAPPDATA%\FitNesse```
5. If you don't have the NuGet CLI already, get it from https://dist.nuget.org/win-x86-commandline/latest/nuget.exe).
6. Install FitSharp: ```nuget install fitsharp -OutputDirectory %LOCALAPPDATA% -ExcludeVersion```
7. Download this repo as a zip file (use the ```<> Code``` button in the root of the repo in GitHub)
8. Extract the contents of the folder ```FitNesseFitSharpFibonacciDemo``` of the zip file into ```%LOCALAPPDATA%\FitNesse```. 
9. Verify that the file ```plugins.properties``` is in that folder afterwards (this is FitNesse's configuration file).
10. Build the fixture solution: ```dotnet build %LOCALAPPDATA%\FitNesse\ExtendedMath\ExtendedMath.sln```
11. Go to the fixture assembly folder: ```cd /D %LOCALAPPDATA%\FitNesse\ExtendedMath\ExtendedMathFixtures\bin\debug\net5.0```
12. Start FitNesse: ```java -jar %LOCALAPPDATA%\FitNesse\fitnesse-standalone.jar -d %LOCALAPPDATA%\FitNesse -e 0```	

## Mac
1. Install [HomeBrew](https://brew.sh). This might require administrative privileges.
1. Install a Java JRE (preferably 11) if you don't have one already: ```brew install java11```
1. Add Java to the path: ```echo 'export PATH="/usr/local/opt/openjdk@11/bin:$PATH"' >> ~/.zshrc```
1. Create a folder for FitNesse: ```mkdir ~/Documents/FitNesse```
1. Download FitNesse from  http://fitnesse.org/FitNesseDownload and copy or move ```fitnesse-standalone.jar``` to ```~/Documents/FitNesse```
1. Install nuget: ``` brew install nuget```
1. Download FitSharp: ```nuget install fitsharp -OutputDirectory ~/Documents -ExcludeVersion```
1. Download this repo as a ZIP file (use the ```<> Code``` button in the root of the repo in GitHub) 
1. Extract the contents of the folder ```FitNesseFitSharpFibonacciDemo``` of the zip file into ```~/Documents/FitNesse```. 
1. Verify that the file ```plugins.properties``` is in that folder afterwards (this is FitNesse's configuration file).
1. Remove or comment out the Windows specific lines in ```plugins.properties```, and uncomment (remove ```#```) the Mac specific ones.
1. If you installed any applications via brew, start a new terminal window to ensure commands are found.
1. Build the fixture solution: ```dotnet build ~/Documents/FitNesse/ExtendedMath/ExtendedMath.sln```
1. Go to the fixture assembly folder: ```cd ~/Documents/FitNesse/ExtendedMath/ExtendedMathFixtures/bin/debug/net5.0```
1. Start FitNesse: ```java -jar ~/Documents/FitNesse/fitnesse-standalone.jar -d ~/Documents/FitNesse -e 0```

## Afterwards (for both)
1. The first time FitNesse runs, it will unpack its resources. Wait until you see ```Starting FitNesse on port: 8080``` in the log
1. Open a browser and enter the URL http://localhost:8080/FibonacciTest?test. You should then see a test table with Fibonacci numbers.

![Fibonacci Test Results](images/FitNesseFibonacciTest.png "Running your first FitNesse test")

# Contribute
Enter an issue or provide a pull request. 
