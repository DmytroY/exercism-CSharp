To create and run new C# app:

```
> dotnet new console -n <Folder/App name>
> cd <Folder/App name>
> dotnet run
```

To run one C# File
```
> dotnet tool install -g dotnet-script
> dotnet-script <filename>
```
be avare if dotnet-script used you shouldn't use Main() in one-file sourcecode. 
With dotnet-script, write code directly at the top level