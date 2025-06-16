Blazor
       
to run the backend
dotnet run --project .\ECommerceBrazorNet7.API\ECommerceBrazorNet7.API.csproj
to run the frontend
dotnet run --project .\ECommerce.WebAssembly\ECommerce.WebAssembly.csproj


commands to create and update the migrations
dotnet ef migrations add InitialCreate --project .\ECommerceBrazorNet7.Repository\ECommerceBrazorNet7.Repository.csproj --startup-project .\ECommerceBrazorNet7.API\ECommerceBrazorNet7.API.csproj

dotnet ef database update --project .\ECommerceBrazorNet7.Repository\ECommerceBrazorNet7.Repository.csproj --startup-project .\ECommerceBrazorNet7.API\ECommerceBrazorNet7.API.csproj


