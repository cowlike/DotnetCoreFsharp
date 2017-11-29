# Create .NET Core solution from CLI

## Create the app
    dotnet new sln -o MyApp
    cd MyApp
    dotnet new console -n Main -o Main -lang f#
    dotnet new xunit -n Tests -o Tests -lang f#
    dotnet sln add Tests/Tests.fsproj Main/Main.fsproj
    dotnet add Tests/Tests.fsproj reference Main/Main.fsproj
 
## Optionally add more packages
    dotnet add Tests/Tests.fsproj package unquote
    dotnet add Main/Main.fsproj package System.Composition
 
## Run it
    dotnet test
    dotnet run