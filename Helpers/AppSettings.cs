using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.Helpers
{
    public class AppSettings
    {
        /*
         * Class that contains properties defined in the appsettings.json file and is used for accesing
           application settings via objects that are injected into classes using the ASP.NET Core built
           in dependency injection system

            For example the User Service accesses app settings via an IOption<AppSettings> appSettings
            object that is injected into the constructor

        */

        // Mapping of configuration sections to classes is done in the ConfigureServices
        public string Secret { get; set; }
    }
}
