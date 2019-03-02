# Create .NET Core solution from CLI

## Create the app
    APP=MyApp
    
    dotnet new sln -o $APP
    cd $APP
    dotnet new console -n Main -o Main -lang f#
    dotnet new xunit -n Tests -o Tests -lang f#
    dotnet sln add Tests/Tests.fsproj Main/Main.fsproj
    dotnet add Tests/Tests.fsproj reference Main/Main.fsproj

Note that the above app is also modified to work with type providers by adding fcs.props [as described in this Github issue](https://github.com/Microsoft/visualfsharp/issues/3303)

## Optionally add more packages
    dotnet add Tests/Tests.fsproj package unquote
    dotnet add Main/Main.fsproj package System.Composition
 
## Run it
    dotnet test
    dotnet run -p Main/Main.fsproj
