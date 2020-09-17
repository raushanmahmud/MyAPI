<h3> Simple web API in C# ASP .NET </h3>

API methods:

<h4>GET all Employees. EXAMPLE: </h4>
https://testapiraushan.azurewebsites.net/api/employees/

<h4>GET an Employee by ID. EXAMPlE:</h4>
https://testapiraushan.azurewebsites.net/api/employees/2

<h4>PUT to Update Employee information by ID. EXAMPLE: </h4>
https://testapiraushan.azurewebsites.net/api/employees/10

need to send JSON data with the POST request, for example:
{
    'id': 10,
    'firstName': 'Jane',
    'lastName': 'dummyLasti'
}
is the same as:
https://testapiraushan.azurewebsites.net/api/employees/

need to send JSON data with the POST request, for example:
{
    'id': 10,
    'firstName': 'Jane',
    'lastName': 'dummyLasti'
}

<b>NOTE:</b>

id field can be given in URI as an optional parameter for readability, but id has to be present in the json file.

<h4>POST to Create  a new Employee https://testapiraushan.azurewebsites.net/api/employees/</h4>
need to send JSON data with the POST request, for example:
{
    'firstName': 'Jane',
    'lastName': 'dummyLasti'
}
<b>NOTE:</b>
No need to send the Id field in JSON data, it is set automatically in the DB

<h4>DELETE to DELETE  an Employee by ID given in the URI https://testapiraushan.azurewebsites.net/api/employees/12</h4>




