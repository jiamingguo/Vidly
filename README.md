# Vidly
a project used to learn C# and ASP.NET

## ASP.NET MVC Fundamentals
### ActionsResults
- ActionResult is used as the return value of a function in Controller
- There are many types of ActionResult


| Type                  | HelperMethod       |
|-----------------------|--------------------|
| ViewResult            | View()             |
| PartialViewResult     | PartialView()      |
| ContentResult         | Content()          |
| RedirectResult        | Redirect()         |
| RedirectToRouteResult | RedirectToAction() |
| JsonResult            | Json()             |
| FileResult            | File()             |
| HttpNotFoundResult    | HttpNotFound()     |
| EmptyResult           |                    |

### Action Parameters
- Parameter binding: Request -> MVC Framework -> Action
- several ways to pass parameters to function
  - in url: localhost:53982/movies/1
  - also: localhost:53982/movies?pageIndex=1&sortBy=Name

### Custom Route
- goto RouteConfig.cs
- before Default route, add a new route. Attention! Must before the default route
### Attribute Routing
- Easier and better way to do custom routing
- The normal way to do Custom routing in previous session is also needed since the attribute routing enabled after 2013
- `routes.MapMvcAttributeRoutes();` method instead of `routes.MapRoute()`
- You can also add constraints to it with Regex. Just like the old ways

### Passing Data to Views
- put the Model in View(#model) as a parameter
- Or, you can use a ViewDataDictionary.
  - `ViewData["Movie"] = movie;`
- Or, a ViewBag
- IMPORTANT: These two are not the best practice.
- the Best Practice is simply passing the model as a parameter (the first way above)

### View Model
- When you want to display more than one object in the view;
- In this Project, when we want to display Customer and Movie, you can't simply use Model;
- So we create a new folder called ViewModels
- Create new class (ViewModel) that contains both Movie and Customer object as attributes
- Put this new ViewModel into View(#Model) as the Model parameter
- Remember, change the @model delcaration on he top of Random.cshtml;
- 