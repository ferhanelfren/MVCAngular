using System.Web.Http;
using WebActivatorEx;
using MVCAngular;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace MVCAngular
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        
                        c.SingleApiVersion("v1", "MVCAngular");

                        
                    })
                .EnableSwaggerUi(c =>
                    {
                        
                    });
        }
    }
}
