## Java Security Manager issue

FitNesse uses a deprecated Java feature called Securtity Manager. In more recent versions of Java, calling these functions raises an exception.
This will cause FitNesse tests to fail with the error message 
```
Could not complete testing: java.lang.UnsupportedOperationException: The Security Manager is deprecated and will be removed in a future release.
```
If you use Java 17+, you can work around this issue using the command line option `-Djava.security.manager=allow` when starting FitNesse. 

```
java -Djava.security.manager=allow -jar fitnesse-standalone.jar 
```

The log will still show warnings, but the tests will execute normally.

```
WARNING: A terminally deprecated method in java.lang.System has been called
WARNING: System::setSecurityManager has been called by fitnesse.slim.instructions.SystemExitSecurityManager (file:/C:/Users/me/AppData/Local/FitNesse/fitnesse-standalone.jar)
WARNING: Please consider reporting this to the maintainers of fitnesse.slim.instructions.SystemExitSecurityManager
WARNING: System::setSecurityManager will be removed in a future release
```
This issue was [reported to the FitNesse maintainers](https://github.com/unclebob/fitnesse/issues/1455).

An alternative is using Java 11.
