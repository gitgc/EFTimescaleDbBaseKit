EFTimescaleDbContextExample
===========================

This project demonstrates how to implement AbstractTimescaleDbContext. In order to use the commands below, you must first run:

    dotnet tool restore

from the root of this project to restore the [Entity Framework CLI tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet).

Deploying the Schema (Migrate the Database)
-------------------------------------------
The following command will apply any pending migrations to a database, or build from an empty one.

    dotnet dotnet-ef database update


Generating a New Schema Migration
---------------------------------
Use the command

    dotnet dotnet-ef migrations add <name>


Rolling Back a Schema Migration
-------------------------------
use the command

    dontnet dotnet-ef migrations remove
