# ASP.NET Core role based authentication and custom role creation
Code sample detailing how to create custom roles in ASP.NET core on startup and role-based authentication using role checks and policy based checks.

## This application consists of:

*   Sample pages using ASP.NET Core MVC
*   [Gulp](https://go.microsoft.com/fwlink/?LinkId=518007) and [Bower](https://go.microsoft.com/fwlink/?LinkId=518004) for managing client-side libraries
*   Theming using [Bootstrap](https://go.microsoft.com/fwlink/?LinkID=398939)

## Run & Deploy

restore the .NET core packages described in the `package.json`, install the npm and bower dependencies,and then update database with the migrations and run the project:

```bash
dotnet restore
npm install
bower install
dotnet ef database update
dotnet run

```

The `dotnet restore` command first restores the necessary packages required to run the application, 
the `dotnet run` command simultaneously re-compiles and runs the `kestrel-server`.

I would love to hear your [feedback](https://temilajumoke.com)
