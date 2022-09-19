using System.Web;
using System.Web.Mvc;

namespace NetFrame61_Nhibernate_sqlserver
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
