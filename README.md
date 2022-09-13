
# Contact List Backend

 C# .NET backend webapi 

Built on: .net 6

## API Reference
| **API**                           | **Description**                 | **Request body** | **Response body**    |
|-----------------------------------|---------------------------------|------------------|----------------------|
| GET /contact/getAllContact        | Get all contacts                | None             | Array of to-do items |
| GET /contact/getContact{id}           | Get contact Item                | Contact Item     | Contact Item         |
| POST /contact/addContact          | Add a new contact               | Contact Item     | Contact Item         |
| PUT /contact/updateContact{id}    | Update an existing contact item | Contact item     | None                 |
| DELETE /contact/deleteContact{id} | Delete an contact item          | None             | None                 |

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
    
