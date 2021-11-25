# BloodBank-Backend

## Installation

Restore dependencies

```bash
  dotnet restore
```
Get the .NET Core CLI tools
```bash
  dotnet tool install --global dotnet-ef
```
Create database
```bash
  dotnet-ef migrations add CreateDB
  dotnet-ef database update
```

Run development server
```bash
  dotnet watch run
```

Publish production build
```bash
  dotnet publish --configuration Release
``` 
