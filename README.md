# Introduction 
This repo contains a few demo on how to use FitNesse with FitSharp. It include FitNesse test pages as well as corresponding C# fixtures. 

# Getting Started

## Windows
1. Ensure you have a Java JRE installed (8 or higher, preferably 11). OpenJDK 11 has been tested and works well.
2. Create folder for FitNesse: ```mkdir %LOCALAPPDATA%\FitNesse``` 
3. Download FitNesse from http://fitnesse.org/FitNesseDownload and copy or move ```fitnesse-standalone.jar``` to the just created folder ```%LOCALAPPDATA%\FitNesse```
4. If you don't have the NuGet CLI already, get it from https://dist.nuget.org/win-x86-commandline/latest/nuget.exe).
5. Install FitSharp: ```nuget install fitsharp -OutputDirectory %LOCALAPPDATA% -ExcludeVersion```
6. Download this repo as a zip file (use the ```<> Code``` button in the root of the repo in GitHub)
7. Extract the contents of the folder ```FitNesseFitSharpFibonacciDemo``` of the zip file into ```%LOCALAPPDATA%\FitNesse```. 
8. Verify that the file ```plugins.properties``` is in that folder afterwards (this is FitNesse's configuration file).
9. Build the solution ```ExtendedMath```: ```dotnet build %LOCALAPPDATA%\FitNesse\ExtendedMath\ExtendedMath.sln```
10. Go to the assembly folder of the fixture: ```cd /D %LOCALAPPDATA%\FitNesse\ExtendedMath\ExtendedMathFixtures\bin\debug\net5.0```
11. Start FitNesse with the root repo folder as the data folder, and the assembly folder as the current directory: ```java -jar %LOCALAPPDATA%\FitNesse\fitnesse-standalone.jar -d %LOCALAPPDATA%\FitNesse -e 0```	
12. The first time FitNesse runs, it will unpack its resources. Wait until you see ```Starting FitNesse on port: 8080``` in the log
13. Open a browser and enter the URL http://localhost:8080/FibonacciTest?test

## Mac
1. Install [HomeBrew](https://brew.sh). This might require administrative privileges.
2. Install a Java JRE (preferably 11) if you don't have one already: ```brew install java11```
3. add Java to the path: ```echo 'export PATH="/usr/local/opt/openjdk@11/bin:$PATH"' >> ~/.zshrc```
4. Create a folder FitNesse: ```mkdir ~/Documents/FitNesse```
5. Download FitNesse from  http://fitnesse.org/FitNesseDownload and copy or move ```fitnesse-standalone.jar``` to the just created folder ```~/Documents/FitNesse```
6. Install nuget: ``` brew install nuget```
6. Download FitSharp: ```nuget install fitsharp -OutputDirectory ~/Documents -ExcludeVersion```
9. Download this repo as a ZIP file (use the ```<> Code``` button in the root of the repo in GitHub) 
10. Extract the contents of the folder ```FitNesseFitSharpFibonacciDemo``` of the zip file into ```~/Documents/FitNesse```. 
11. Verify that the file ```plugins.properties``` is in that folder afterwards (this is FitNesse's configuration file).
12. Add environment variable LOCALAPPDATA: ```echo 'export LOCALAPPDATA="~/Documents"' >> ~/.zshrc``` (alternatively, change ```plugins.properties``` to make FITSHARP_HOME point to the right folder)
13. Apply the settings in ./zshrc: ```. ~/.zshrc```
14. Build the solution ```ExtendedMath```: ```dotnet build ~/Documents/FitNesse/ExtendedMath/ExtendedMath.sln```
15. Go to the assembly folder: cd ~/Documents/FitNesse/ExtendedMath/ExtendedMathFixtures/bin/debug/net5.0
14: Start FitNesse: ```java -jar ~/Documents/FitNesse/fitnesse-standalone.jar -d ~/Documents/FitNesse -e 0
15. The first time FitNesse runs, it will unpack its resources. Wait until you see ```Starting FitNesse on port: 8080``` in the log
16. Open a browser and enter the URL http://localhost:8080/FibonacciTest?test

# Contribute
Enter an issue or provide a pull request. 
