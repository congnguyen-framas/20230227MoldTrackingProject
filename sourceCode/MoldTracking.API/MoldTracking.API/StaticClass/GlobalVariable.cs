using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MoldTracking.API
{
    public static class GlobalVariable
    {
        public static String Secret { get; } = "ITFramasBDVN";
        /// <summary>
        /// Default Database.
        /// </summary>
        public static string DogeWhConnection { get; set; }
        public static string HydraConnection { get; set; }
        /// <summary>
        /// DB Get Account info for login.
        /// </summary>
        public static string RecycleConnection { get; set; }
        /// <summary>
        /// Provider Doge_Wh. Default provider.
        /// </summary>
        /// <returns></returns>
        public static IDbConnection GetDbDogeWhProvider()
        {
            return new SqlConnection(DogeWhConnection);
        }

        /// <summary>
        /// Provider DB Hydra.
        /// </summary>
        /// <returns></returns>
        public static IDbConnection GetDbHydraProvider()
        {
            return new SqlConnection(HydraConnection);
        }

        /// <summary>
        /// Provider DB Recycle.
        /// </summary>
        /// <returns></returns>
        public static IDbConnection GetDbRecycleProvider()
        {
            return new SqlConnection(RecycleConnection);
        }
    }
}
