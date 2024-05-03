

# net5-webapi

.NET 5.0 Docker-ready C# REST API example using JWT authentication, Swagger, Newtonsoft JSON, and Dapper with SQL Server.

![net5-webapi](https://github.com/nunogois/net5-webapi/blob/master/net5-webapi-thumbnail.png)

![.NET 5.0](https://img.shields.io/badge/-.NET_5.0-141321?style=for-the-badge&logo=.net&logoColor=ba46d8)&nbsp;
![C#](https://img.shields.io/badge/-C%23-141321?style=for-the-badge&logo=c-sharp&logoColor=239120)&nbsp;
![Docker-ready](https://img.shields.io/badge/-Docker--ready-141321?style=for-the-badge&logo=Docker&logoColor=2496ED)&nbsp;
![Swagger](https://img.shields.io/badge/-Swagger-141321?style=for-the-badge&logo=Swagger&logoColor=85EA2D)&nbsp;
![JWT Authentication](https://img.shields.io/badge/-JWT_Authentication-141321?style=for-the-badge&logo=JSON-Web-Tokens&logoColor=ffffff)&nbsp;
![Dapper -> SQL Server](https://img.shields.io/badge/-Dapper_-->_SQL%20Server-141321?style=for-the-badge&logo=Microsoft-SQL-Server&logoColor=CC2927)&nbsp;

## Swagger

When you first run this project on dev, you should be greeted by [Swagger](https://swagger.io/), listing all the available endpoints automatically and allowing you to try them.

This assumes the methods are working properly, so you'll need to setup your own JWT configuration, database connection and queries first. Check below for more information.

### Swagger - Authorization

After logging in with `POST /api/Auth/Login` you will receive a token ([JWT](https://jwt.io/)) along with session info. 

You can use that token to authenticate in Swagger. Simply click on **Authorize** on the top right corner and enter `Bearer *your_token*` in the dialog. If the token is valid, you should be able to request authenticated routes like the ones in **Notes**.

## DBConnection (Dapper -> SQL Server)

I'm using **DBEngine** as an example interface for your preferred database. Feel free to use Entity Framework if you prefer, for example. I like using [Dapper](https://github.com/StackExchange/Dapper) because I find it extremely fast and flexible.

The connection string is currently being fetched from **ConnectionStrings.DBConnection** in **appsettings.json**.

The [SQL Server](https://www.microsoft.com/sql-server/sql-server-2019?rtc=1) queries I'm using are just examples, adapt to your own database schema and needs.

## Docker

Since this is a [.NET 5.0](https://docs.microsoft.com/en-us/dotnet/core/dotnet-five) project, it is cross-platform and this means it can also be easily containerized in Docker. Obviously, this doesn't mean you need to run this project in Docker, however the option is available. If you're using Visual Studio, you can easily switch between debug profiles on the debug dropdown.

I suggest exploring **Dockerfile** and **launchSettings.json** for more information.

## Controllers

### Auth

 - **POST /api/Auth/Login** - Ok si existe el usuario

 
### Notes

 - **POST /api/Awa** - agregar awita
 - **GET /api/Awa/{id}** - cabecera
 - **GET /api/Awa/AwaDetail/{id}** - detalle

 
