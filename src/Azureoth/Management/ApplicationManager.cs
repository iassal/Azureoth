using Azureoth.Datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azureoth.Utility;
using Azureoth.Database;
namespace Azureoth.Management
{
    public static class ApplicationManager
    {
        public static List<UserApplication> GetUserApps(string userName)
        {
            return new List<UserApplication>();
        }

        public static UserApplication GetUserApp(string userName, string appId)
        {
            ParamValidators.ValidateAppId(appId);

            return new UserApplication();
        }

        public static bool AddUserApp(string userName, UserApplication application)
        {
            ParamValidators.ValidateApp(application);

            return true;
        }
        public static bool EditUserApp(string userName, UserApplication application)
        {
            ParamValidators.ValidateApp(application);

            return true;
        }
    }
}
