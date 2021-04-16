# MVCJWTTokenDemo

MVC JWT Token Demo 

## ASP.NET Core web API documentation with Swagger / OpenAPI

     - Install Swashbuckle.Aspnetcore
            1.Right-click the API project in Solution Explorer and select Manage NuGet Packages
            2.Type Swashbuckle.AspNetCore in the search box
            3.Select Swashbuckle.AspNetCore and click Install

    - Configure Swagger Middleware
        services.AddSwaggerGen();

    - Configure
        // This middleware serves generated Swagger document as a JSON endpoint
        app.UseSwagger();

        // This middleware serves the Swagger documentation UI
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee API V1");
        });


 URL for document:  https://localhost:44379/swagger/index.html
 
                     https://localhost:44379/swagger/v1/swagger.json
