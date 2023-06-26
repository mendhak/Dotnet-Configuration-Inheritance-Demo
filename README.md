

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

With Docker

```
$ docker build -t dotnetconfigdemo:latest .

$ docker run -e ENVIRONMENT_NAME=production --rm dotnetconfigdemo:latest 
Hello, From Production!

$ docker run -e ENVIRONMENT_NAME=production -e SUBJECT__NAME=Harry --rm dotnetconfigdemo:latest
Hello, Harry
```
