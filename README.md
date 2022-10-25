# CatalogAPI

A demo REST API that manages a colection of items for sale. It can be used as a backend for a simple site.

![image](https://user-images.githubusercontent.com/30511514/197758809-7ebb4135-bb9b-41af-abf6-8cdabd523766.png)

## Technology used

The API manages [CRUD](https://en.wikipedia.org/wiki/Create,_read,_update_and_delete "Wikipedia CRUD") operations on a colection of items and is made in C# programming language using the .net 5 Core framework. The connection with the database is made using [Entity Framework](https://learn.microsoft.com/en-us/ef/core/ "Entity Framework Doc"), the database being hosted locally using [SQLExpress](https://www.microsoft.com/en-us/sql-server/sql-server-downloads?rtc=1 "SQLExpress download") and managed using [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16 "SSMS download"). For the interface I used [Swagger UI](https://swagger.io/tools/swagger-ui/ "Swagger UI doc").

![image](https://user-images.githubusercontent.com/30511514/197760857-8d3098d7-cd42-4003-a428-a499e19a36da.png)

## Requests examples
🔹 Get all items list:

![image](https://user-images.githubusercontent.com/30511514/197766805-5818bf13-a20b-49a7-b7e2-c5d74c0f9f9e.png)

🔹 Create an item:

![image](https://user-images.githubusercontent.com/30511514/197767136-a69e9235-de1b-41d7-8851-5ebbad334fda.png)

![image](https://user-images.githubusercontent.com/30511514/197767213-ca422c4a-24ce-4398-b9e5-ec7408492131.png)

And now when we request get items list, the new item is there:

![image](https://user-images.githubusercontent.com/30511514/197767603-7d6273aa-5323-47ee-82be-1f178ad902de.png)

🔹 Get a specific item (the golden apple id is used as example):

![image](https://user-images.githubusercontent.com/30511514/197767866-ad3e3ad1-8def-4c69-971a-cdfaf035513c.png)

![image](https://user-images.githubusercontent.com/30511514/197768214-9f404e13-0ad8-4622-ba1a-bc2f8f1bab74.png)

🔹 Update (golden apple):

![image](https://user-images.githubusercontent.com/30511514/197768660-7bc889de-a174-4400-8976-bf09bd7705e4.png)

![image](https://user-images.githubusercontent.com/30511514/197768696-dd1a464e-db4f-42ec-843c-87e7b8a092b5.png)

The change is visible:

![image](https://user-images.githubusercontent.com/30511514/197768760-70bb80db-9c75-4c61-8546-8cb50fe63ff6.png)

🔹 Delete (Hellstone Ring used as example):
![image](https://user-images.githubusercontent.com/30511514/197769072-08005af3-8f2d-41bd-a4e1-256f806bf237.png)

![image](https://user-images.githubusercontent.com/30511514/197769099-3f0f2da1-c2c3-40a4-a2f7-99ae4dfd2bd4.png)

The items list after delete:

![image](https://user-images.githubusercontent.com/30511514/197769201-026d8d2b-0039-4a99-a1b6-2800e4e46876.png)

## Contents

🔹 The Item entity model

![image](https://user-images.githubusercontent.com/30511514/197762844-9a7992d0-1d75-4a71-8b98-e37b052f5047.png)

🔹 A controller that manages the routes for the items operations: ( Get item, Get all items, Create item, Update item, Delete item).

![image](https://user-images.githubusercontent.com/30511514/197766267-8fcd1163-0421-4e07-82e6-1d6f37adaf07.png)

🔹 Data [Transfer Objects (DTOs)](https://learn.microsoft.com/en-us/aspnet/web-api/overview/data/using-web-api-with-entity-framework/part-5 "About DTOs") used so the web API des not expose the database entities to the client.

![image](https://user-images.githubusercontent.com/30511514/197763555-112ec5d5-b51d-46aa-a447-08de3616e34a.png)

🔹 A service used to communicate with the database.

![image](https://user-images.githubusercontent.com/30511514/197763793-9f79db87-5115-40dc-8529-ad5a6d43f85a.png)

🔹 Items visible from SSMS.

![image](https://user-images.githubusercontent.com/30511514/197769575-37eefd1d-9873-48c2-94fe-16040d4150e0.png)





