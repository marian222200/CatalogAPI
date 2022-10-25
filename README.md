# CatalogAPI

A demo REST API that manages a colection of items for sale. It can be used as a backend for a simple site.

![image](https://user-images.githubusercontent.com/30511514/197758809-7ebb4135-bb9b-41af-abf6-8cdabd523766.png)

## Technology used

The API manages [CRUD](https://en.wikipedia.org/wiki/Create,_read,_update_and_delete "Wikipedia CRUD") operations on a colection of items and is made in C# programming language using the .net 5 Core framework. The connection with the database is made using [Entity Framework](https://learn.microsoft.com/en-us/ef/core/ "Entity Framework Doc"), the database being hosted locally using [SQLExpress](https://www.microsoft.com/en-us/sql-server/sql-server-downloads?rtc=1 "SQLExpress download") and managed using [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16 "SSMS download").

![image](https://user-images.githubusercontent.com/30511514/197760857-8d3098d7-cd42-4003-a428-a499e19a36da.png)

## Requests examples

## Contents

🔹 The Item entity model

![image](https://user-images.githubusercontent.com/30511514/197762844-9a7992d0-1d75-4a71-8b98-e37b052f5047.png)

🔹 A controller that manages the routes for the items operations: ( Get item, Get all items, Create item, Update item, Delete item).

🔹 Data Transfer Objects (DTOs) used so the web API des not expose the database entities to the client.

![image](https://user-images.githubusercontent.com/30511514/197763555-112ec5d5-b51d-46aa-a447-08de3616e34a.png)

🔹 A service used to communicate with the database.!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

![image](https://user-images.githubusercontent.com/30511514/197763793-9f79db87-5115-40dc-8529-ad5a6d43f85a.png)




