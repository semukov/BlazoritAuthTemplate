# BlazoritAuthTemplate 
## Blazor template for authentication and authorization via PostgreSQL DB or SQL Server

#### At the beginning, you need add file "appsettings.json" in this template solution in folder /Blazorit/Server/appsettings.json.
FileText for /Blazorit/Server/appsettings.json:

{
  "ConnectionStrings": {
    "DefaultConnection": "server=server_address;Port=5432; Database=db_name; Username=user_name; Password=pass"
  },
  "AppSettings": {
    "SecurityKey": "some long secret key"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

You need change DefaultConnection for your Database.
