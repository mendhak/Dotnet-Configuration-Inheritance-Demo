

```
$ dotnet run
Hello, From Default

$ ENVIRONMENT_NAME=staging dotnet run
Hello, From Staging

$ ENVIRONMENT_NAME=production dotnet run
Hello, From Production!

$ SUBJECT__NAME=Dennis dotnet run
Hello, Dennis

$ ENVIRONMENT_NAME=production SUBJECT__NAME=Dennis dotnet run
Hello, Dennis
```

