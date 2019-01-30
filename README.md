# WebAPI

Implemention of a RESTful web service that performs CRUD operations (Create, Read, Update, and Delete) for a *Product* entity.

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

Initial expectation(s):
1) Use C# and the Web API 2 framework.
2) Implement some form of automated testing.
3) Use some form of in-memory persistence.

For extension:
1) Apply some form of authentication and/or authorisation (provide us with details as to what and why).
2) Add filtering to the GET products route (e.g. filter by Description/Model/Brand).
3) Create a light weight UI for querying the API.
