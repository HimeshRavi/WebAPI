# WebAPI

Implementation of a RESTful web service that performs CRUD operations (Create, Read, Update, and Delete) for a *Product* entity.

```
public class Product
{
public string Id { get; set; }
public string Description { get; set; }
public string Model { get; set; }
public string Brand { get; set; }
}
```

The RESTful service implements the following routes:
```
GET products
GET products/{id}
POST products
PUT products/{id}
DELETE products/{id}
```

## Initial scope(s):
1) Use C# and the Web API 2 framework.
2) Implementation of automated testing with the following scripts run in [Postman](https://www.getpostman.com/):
    1. **Status code : Code is 200**
    ```
    pm.test("Status code is 200", function () {
    pm.response.to.have.status(200);
    });
    ```
    2. **Response time is less than 200ms**
    ```
    pm.test("Response time is less than 200ms", function () {
    pm.expect(pm.response.responseTime).to.be.below(200);
    });
    ```
    3. **Successful POST request**
    ```
    pm.test("Successful POST request", function () {
    pm.expect(pm.response.code).to.be.oneOf([201,202]);
    });
    ```
3) Use of in-memory persistence (localDB).

## Further extension(s):
1) Apply some form of authentication and/or authorisation.
2) Added filtering to the GET products route (e.g. filter by Brand).
3) Creation of a light weight UI for querying the API.

## Instruction to Run the WebAPI

1) Download/Clone the repository.
2) Open the solution in [Visual Studio](https://visualstudio.microsoft.com/) (preferably 2017).
3) Press `Ctrl+F5` to build and run.
4) Use the UI in the browser or [Postman](https://www.getpostman.com/) to make the API calls.
