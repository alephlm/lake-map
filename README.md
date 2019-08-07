# Lake map
Requirements:
-------------
- [.NET Core 2.2](https://dotnet.microsoft.com/)
___
### How to execute:

- open terminal / cmd

- navigate to LakeMap directory

- execute command: "dotnet run", it will be running on "http://localhost:5000"

___
### Sending requests:
- send a POST request content type "application/json"
with string map in the body to http://localhost:5000/api/map.

- example of body :
```
"OOO#
O#O#
OO##
OOO#"
```
- this example should return 10 as result.

___
### Swagger:
- To access swagger UI go to http://localhost:5000/swagger
- To access swagger api go to: http://localhost:5000/swagger/v1/swagger.json

___
### Running Tests:
- to run unit tests use the command "dotnet test"