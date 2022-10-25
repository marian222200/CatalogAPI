# CatalogAPI

A demo REST API that manages a colection of items for sale. It can be used as a backend for a simple site.

![image](https://user-images.githubusercontent.com/30511514/197758809-7ebb4135-bb9b-41af-abf6-8cdabd523766.png)

## Technology used

The API manages [CRUD](https://en.wikipedia.org/wiki/Create,_read,_update_and_delete "Wikipedia CRUD") operations on a colection of items and is made in C# programming language using the .net 5 Core framework. The connection with the database is made using [Entity Framework](https://learn.microsoft.com/en-us/ef/core/ "Entity Framework Doc"), the database being hosted locally using [SQLExpress](https://www.microsoft.com/en-us/sql-server/sql-server-downloads?rtc=1 "SQLExpress download") and managed using [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16 "SSMS download"). For the interface I used [Swagger UI](https://swagger.io/tools/swagger-ui/ "Swagger UI doc").

![image](https://user-images.githubusercontent.com/30511514/197760857-8d3098d7-cd42-4003-a428-a499e19a36da.png)

## Requests examples

### Get all items list:

![image](https://user-images.githubusercontent.com/30511514/197766805-5818bf13-a20b-49a7-b7e2-c5d74c0f9f9e.png)

### Create an item:

![image](https://user-images.githubusercontent.com/30511514/197767136-a69e9235-de1b-41d7-8851-5ebbad334fda.png)

![image](https://user-images.githubusercontent.com/30511514/197767213-ca422c4a-24ce-4398-b9e5-ec7408492131.png)

And now when we request get items list, the new item is there:

![image](https://user-images.githubusercontent.com/30511514/197767603-7d6273aa-5323-47ee-82be-1f178ad902de.png)

### Get a specific item (the golden apple id is used as example):

![image](https://user-images.githubusercontent.com/30511514/197767866-ad3e3ad1-8def-4c69-971a-cdfaf035513c.png)

![image](https://user-images.githubusercontent.com/30511514/197768214-9f404e13-0ad8-4622-ba1a-bc2f8f1bab74.png)

### Update (golden apple):

![image](https://user-images.githubusercontent.com/30511514/197768660-7bc889de-a174-4400-8976-bf09bd7705e4.png)

![image](https://user-images.githubusercontent.com/30511514/197768696-dd1a464e-db4f-42ec-843c-87e7b8a092b5.png)

The change is visible:

![image](https://user-images.githubusercontent.com/30511514/197768760-70bb80db-9c75-4c61-8546-8cb50fe63ff6.png)

### Delete (Hellstone Ring used as example):

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

🔹 Migrations and Database Context (from Entity Framework).

![image](https://user-images.githubusercontent.com/30511514/197773509-d4c86bb6-809c-41a3-8246-495c5608fdc3.png)

## Repository service

For the repository I used dependency Inversion Principle. I used an interface that the controller class depends on, and the class that I used to communicate with the database implements that interface. 

![image](https://user-images.githubusercontent.com/30511514/197772995-93efb986-c0aa-4527-94ca-d225808285b4.png)

By having our code depend upon abstractions we are decoupling implementations from each other. This makes the code cleaner, easier to modify and easier to reuse. In this case the database "manager" class can be modified independently from the main class. More about: [Depedency Injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection ".net documentation - Depedency injection").

![image](https://user-images.githubusercontent.com/30511514/197771445-da2f7e86-5b41-4aec-8a54-fd222f7549ba.png)

![image](https://user-images.githubusercontent.com/30511514/197772046-697c303a-b384-453d-b7d0-00cd7f13b3f7.png)

## Conclusion

In creating this API I remembered a lot of the knoledge that I learned at the ASP.net MVC 5 course that I did at University back in 2020, and also I got a more profound grasp on the C# and the .NET Framework.

## Resources

Besides the [C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/ "C# doc"), [.NET documentation](https://learn.microsoft.com/en-us/dotnet/ ".NET doc") and [Entity Framework documentation](https://learn.microsoft.com/en-us/ef/ "Entity Framework doc") I also watched multiple tutorials on youtube, I will list the most important ones below:

🔹 [C# Tutorial - Full Course for Beginners](https://www.youtube.com/watch?v=GhQdlIFylQ8&ab_channel=freeCodeCamp.org "Starter C# course - Youtube")

🔹 [C#.NET Tutorials](https://www.youtube.com/playlist?list=PLTjRvDozrdlz3_FPXwb6lX_HoGXa09Yef "Programming with Mosh Youtube Playlist")

🔹 [C# Tutorial](https://www.youtube.com/playlist?list=PLGLfVvz_LVvRX6xK1oi0reKci6ignjdSa "In depth C# language tutorial Youtube playlist from Derek Banas") - My personal favourite

🔹 [.NET 5 REST API Tutorial - Build From Scratch With C#](https://www.youtube.com/watch?v=ZXdFisA_hOY&ab_channel=freeCodeCamp.org "Complete API tutorial .NET 5 - Youtube")

🔹 [.NET 6 Web API with Entity Framework Core and SQL Server. Angular 13 CRUD App. Full stack.](https://www.youtube.com/watch?v=rzPFEuKlPhM&ab_channel=JamesSchneider "Full Stack Web App - Youtube")
