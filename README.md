
# Contact List Backend

 C# .NET backend webapi . Uses EntityFramework and Sqlite.
 
 Built on: .net 6
 
 Includes Angular frontend in wwwroot folder (source is [here](https://github.com/georgedimac/contacts_webapi_frontend/tree/ver2))
Runs on : http://localhost:5076/


## API Reference
| **API**                           | **Description**                 
|-----------------------------------|---------------------------------|
| GET /contact/        | Get all contacts            
| GET, POST, PUT, DELETE /contact/{id}           | Get, Add, Update, Delete Contact               | 

| Parameter | Type     | 
| :-------- | :------- | 
| `name` | `string` | 
| `email` | `string` | 
| `phone` | `string` | 

## Installation


```bash
  cd contact_app
  dotnet run
```
    
