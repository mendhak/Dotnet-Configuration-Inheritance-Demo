Sample app to demonstrate dotnet's hierarchical configuration feature, and double underscore notation to override specific configuration values. 

With dotnet

```
# Reads from appsettings.json
$ dotnet run
Hello, From Default

# Reads from appsettings.staging.json
$ ENVIRONMENT_NAME=staging dotnet run
Hello, From Staging

# Reads from appsettings.production.json
$ ENVIRONMENT_NAME=production dotnet run
Hello, From Production!

# Overridden from 'external secret store'
$ SUBJECT__NAME=Dennis dotnet run
Hello, Dennis

# Overridden from 'external secret store', takes precedence over appsettings.x.json
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
