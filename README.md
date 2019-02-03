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
1) Addition of filtering to the GET products route (e.g. filter by Brand).
2) Creation of a light weight UI for querying the API.

## Instruction to Run the WebAPI
1) Download/Clone the repository.
2) Open project/folder in [Visual Studio](https://visualstudio.microsoft.com/) (preferably 2017)
3) Double-click and load the solution - "**WebAPI.sln**".
4) Build the solution by pressing `Ctrl+Shift+B` _(Output: ===== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped =====)_.
5) Now run the successfully built solution by pressing `F5`.
6) Security warning about SSL certificate: Select _Yes_; then _Yes_ once again to install the certificate _(this will open up your browser on 'https://localhost:<port>/')_.
7) _Accept_ the privacy and cookie use policy from the on-screen prompt.
8) Voilà! You're all done. Now use the UI in the browser or [Postman](https://www.getpostman.com/) to make the API calls.

## Reference(s)

[ASP.NET](https://www.asp.net/)
[ASP.NET Documentation](https://docs.microsoft.com/en-us/aspnet/)
[.NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
[Visual Studio Documentation](https://docs.microsoft.com/en-us/visualstudio/?view=vs-2017)
[NuGet Documentation](https://docs.microsoft.com/en-us/nuget/)
[PowerShell Documentation](https://docs.microsoft.com/en-us/powershell/)
