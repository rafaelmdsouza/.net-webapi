using Microsoft.AspNetCore.Mvc;

namespace Companies.API
{
    public class ApiRoutes
    {
        public const string BaseRoute = "api/v1/[controller]";

        public class Companies
        {
            public const string GetById = "{id}";
            public const string CreateEmployee = "create_employee";


        }
    }
}
