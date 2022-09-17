
# Contact List Backend

 C# .NET backend webapi . Uses EntityFramework and Sqlite.
 
 Built on: .net 6
 
 Includes Angular frontend in wwwroot folder (source is [here](https://github.com/georgedimac/contacts_webapi_frontend/))
Runs on : http://localhost:5076/


## API Reference
| **API**                           | **Description**                 | **Request body** | **Response body**    |
|-----------------------------------|---------------------------------|------------------|----------------------|
| GET /contact/getAllContact        | Get all contacts                | None             | Array of to-do items |
| GET /contact/getContact?id={id}           | Get contact Item                | Contact Item     | Contact Item         |
| POST /contact/addContact          | Add a new contact               | Contact Item     | Contact Item         |
| PUT /contact/updateContact?id={id}    | Update an existing contact item | Contact item     | None                 |
| DELETE /contact/deleteContact?id={id} | Delete an contact item          | None             | None                 |

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
    
