## Database

### Sql setup
1. Download Sql server mgt. studio: https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15
2. Download sql server express localdb: https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15
3. Create a new db and Run db setup script

### Alternative setup
*Install SQL Server Studio*: [Download](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)

*Setup LocalDB* : [Download and install](https://www.sqlshack.com/install-microsoft-sql-server-express-localdb/) or [direct download](http://download.microsoft.com/download/8/D/D/8DD7BDBA-CEF7-4D8E-8C16-D9F69527F909/ENU/x64/SqlLocalDB.MSI)

*Set up a local db instance using this guide*: [Setup your LocalDB.](https://www.sqlshack.com/how-to-connect-and-use-microsoft-sql-server-express-localdb/)

### Alternative setup 2
[Microsoft guide](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15)
1. Install using link above or through the Visual Studio Installer, as part of the ASP.NET and web development workload, or as an individual component.
2. It should automatically be running. If it isn't you can start it by running in command prompt
```
SqlLocalDB start MSSQLLocalDB
```
3. Connect to it via SQL Server.    
Server name: (localdb)\MSSQLLocalDB  
Authentication: Windows Authentication
4. Create a new database in SQL Server
5. Run database setup script (to be provided by a colleague)

## Project setup
Create a db project with these libraries:
![image](https://user-images.githubusercontent.com/63453969/182610077-fae29d0d-08ad-4a4e-9277-f912de292d58.png)

### Scaffolding DB:
You can automatically generate the c# code for a db table using scaffolding

https://docs.microsoft.com/en-us/ef/core/managing-schemas/scaffolding?tabs=dotnet-core-cli

1. Set db project SwiftProposal.Data as startup project
2. Open up Package Manager Console
3. Set default project in the package manager window to SwiftProposal.Data 
4. Run below
```
Scaffold-DbContext "data source=[Your db ConnectionString]" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Scaffolded
```

Replace with your db connection string. E.g.
```
Scaffold-DbContext "data source=(LocalDB)\MSSQLLocalDB;initial catalog=Bank;MultipleActiveResultSets=True;App=EntityFramework" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Scaffolded
```

5. I normally copy relevant bits from the Scaffolded folder
6. You can specify specific tables using the -table parameter
