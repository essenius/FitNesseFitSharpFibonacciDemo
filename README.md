# Introduction 
This repo contains a few demo on how to use FitNesse with FitSharp. It include FitNesse test pages as well as 
corresponding C# fixtures. The intention is that the root folder of this repo becomes the data folder of FitNesse.

# Getting Started
1. Ensure you have a Java JRE installed (1.7 or higher)
1. Download FitNesse (http://fitnesse.org) and install it to C:\Apps\FitNesse
1. Install FitSharp 2.8.2.1 or higher into C:\Apps\FitSharp. The easiest way to do that is using the NuGet CLI which you can get from from https://dist.nuget.org/win-x86-commandline/latest/nuget.exe:
```
nuget install fitsharp -OutputDirectory C:\Apps -ExcludeVersion
```
4. Clone the repo to a local folder (C:\Data\FitNesseDemo)
5. If you took a different folder for FitSharp, update ```plugins.properties``` accordingly.
6. Build the solution ```ExtendedMath```
8. Start FitNesse with the root repo folder as the data folder, and the assembly folder as the current directory:
```
	cd /D C:\Data\FitNesseDemo\ExtendedMath\ExtendedMathFixtures\bin\debug\net5.0
	java -jar C:\Apps\FitNesse\fitnesse-standalone.jar -d C:\Data\FitNesseDemo
```	
8. Open a browser and enter the URL http://localhost:8080/FibonacciTest?test

# Contribute
Enter an issue or provide a pull request. 
