Sharepoint.Startup
===============

Simulate the "Application_Start" of a Global.asax file within a Sharepoint project.

"Application_Start"
---------------
Within the main master page, run the "Start" method of Sharepoint.Startup and include code you want to be run when the application starts.

```csharp
Sharepoint.Startup.Application.Start(() =>
{
    // todo: add code here that you want to run when the application starts
});
```