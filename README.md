# Introduction 
This repo contains a demo on how to setup and use FitNesse with FitSharp. It include a FitNesse test page as well as a corresponding C# fixture. 

# Installation and Startup

## Windows
1. Ensure you have a Java JRE installed (version 8 or higher, preferably 11). OpenJDK 11 has been tested and works well.
2. Ensure that Java is in the path.
3. Create folder for FitNesse: `mkdir %LOCALAPPDATA%\FitNesse` 
4. Download FitNesse from http://fitnesse.org/FitNesseDownload and copy or move `fitnesse-standalone.jar` to `%LOCALAPPDATA%\FitNesse`
5. If you don't have the NuGet CLI already, get it from https://dist.nuget.org/win-x86-commandline/latest/nuget.exe).
6. Install FitSharp: `nuget install fitsharp -OutputDirectory %LOCALAPPDATA% -ExcludeVersion`
7. Download this repo as a zip file (use the `<> Code` button in the root of the repo in GitHub)
8. Extract the contents of the folder `FitNesseFitSharpFibonacciDemo` of the zip file into `%LOCALAPPDATA%\FitNesse`. 
9. Verify that the file `plugins.properties` is in that folder afterwards (this is FitNesse's configuration file).
10. Go to the solution folder : `cd /D %LOCALAPPDATA%\FitNesse\ExtendedMath`
11. Build the fixture solution: `dotnet build --configuration release ExtendedMath.sln`
12. Go to the fixture folder: `cd ExtendedMathFixtures`
13. Publish the fixture including potential dependencies: `dotnet publish ExtendedMathFixtures.csproj --output bin\Deploy\net5.0 --framework net5.0 --configuration release`
14. Go to the fixture assembly folder: `cd bin\Deploy\net5.0`
15. Start FitNesse: `java -jar %LOCALAPPDATA%\FitNesse\fitnesse-standalone.jar -d %LOCALAPPDATA%\FitNesse -e 0`	

## Mac
1. Install [HomeBrew](https://brew.sh). This might require administrative privileges.
1. Install a Java JRE (preferably 11) if you don't have one already: `brew install java11`
1. Add Java to the path: `echo 'export PATH="/usr/local/opt/openjdk@11/bin:$PATH"' >> ~/.zshrc`
1. Create a folder for FitNesse: `mkdir ~/Documents/FitNesse`
1. Download FitNesse from  http://fitnesse.org/FitNesseDownload and copy or move `fitnesse-standalone.jar` to `~/Documents/FitNesse`
1. Install nuget: `brew install nuget`
1. Install FitSharp: `nuget install fitsharp -OutputDirectory ~/Documents -ExcludeVersion`
1. Download this repo as a ZIP file (use the `<> Code` button in the root of the repo in GitHub) 
1. Extract the contents of the folder `FitNesseFitSharpFibonacciDemo` of the zip file into `~/Documents/FitNesse`. 
1. Verify that the file `plugins.properties` is in that folder afterwards (this is FitNesse's configuration file).
1. Remove or comment out the Windows specific lines in `plugins.properties`, and uncomment (remove `#`) the Mac specific ones.
1. If you installed any applications via brew, start a new terminal window to ensure commands are found.
1. Go to the solution folder : `cd ~/Documents/FitNesse/ExtendedMath`
1. Build the fixture solution: `dotnet build --configuration release ExtendedMath.sln`
1. Go to the fixture folder: `cd ExtendedMathFixtures`
1. Publish the fixture including potential dependencies: `dotnet publish ExtendedMathFixtures.csproj --output bin/Deploy/net5.0 --framework net5.0 --configuration release`
1. Go to the fixture assembly folder: `cd bin/Deploy/net5.0`
1. Start FitNesse: `java -jar ~/Documents/FitNesse/fitnesse-standalone.jar -d ~/Documents/FitNesse -e 0`

## Validation (for both)
1. The first time FitNesse runs, it will unpack its resources. Wait until you see `Starting FitNesse on port: 8080` in the log
    ```
    Bootstrapping FitNesse, the fully integrated standalone wiki and acceptance testing framework.
    root page: fitnesse.wiki.fs.WikiFilePage: FitNesseRoot
    logger: none
    authenticator: fitnesse.authentication.PromiscuousAuthenticator
    page factory: fitnesse.html.template.PageFactory
    page theme: bootstrap
    Unpacking new version of FitNesse resources. Please be patient...
    **********************************************************
    Files have been updated to a new version.
    Please read the release notes on
    http://localhost:8080/FitNesse.ReleaseNotes
    to find out about the new features and fixes.
    **********************************************************
    Starting FitNesse on port: 8080
    ```

    In case you see something else, validate that Java was correctly installed and that the location of `fitnesse-standalone.jar` is correctly specified.

  1. Open a browser and enter the URL http://localhost:8080/FibonacciTest?test. If you then see a test table with Fibonacci numbers, you have configured FitNesse and FitSharp correctly.

![Fibonacci Test Results](images/FitNesseFibonacciTest.png "Running your first FitNesse test")

## Troubleshooting
If you see something else (like an amberish line with ```Testing was interrupted and results are incomplete.``` then there is something wrong with the configuration. Check the `Execution Log` button for clues (although the messages are not always helpful). 

Causes could be:
* Can't find the test runner or one of its dependencies: ensure that the dotnet command is available and that FitSharp is installed in the right folder.
* Can't find the fixture assemblies: ensure that the build succeeded and that the DLLs exist in the right folder, ensure that FitNesse was started from the right folder, ensure that `config.xml` file points to the correct assemblies.
* There is a configuration issue in `plugins.properties`. Note that if you make a change in that file, you need to restart FitNesse to let it pick up the change.

# Contribute
Enter an [issue](issues) or provide a pull request. 
