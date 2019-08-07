# Lake map
Requirements:
-------------
- [.NET Core 2.2](https://dotnet.microsoft.com/)
___
### How to execute:

- Open terminal / cmd

- Navigate to LakeMap directory

- Execute command: `dotnet run`, it will be running on "http://localhost:5000"

___
### Sending requests:
- Send a POST request content type "application/json"
with string map in the body to http://localhost:5000/api/map.

- Example of body :
```
"OOO#
O#O#
OO##
OOO#"
```
- This example should return 10 as result.

___
### Swagger:
- To access swagger UI go to http://localhost:5000/swagger
- To access swagger api go to: http://localhost:5000/swagger/v1/swagger.json

___
### Running Tests:
- To run unit tests use the command `dotnet test`
