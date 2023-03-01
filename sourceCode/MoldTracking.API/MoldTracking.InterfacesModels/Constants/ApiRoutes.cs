using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoldTracking.InterfacesModels
{
    public static class ApiRoutes
    {
        public const string Get = "{id}";
        public const string GetAll = "";
        public const string Insert = "insert";
        public const string Update = "update";

        public static class ModlChangeInfo
        {
            public const string BasePath = "api/MoldChange";
        }
    }
}
