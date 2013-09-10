using System.Web;
using System.Web.Mvc;

namespace MySql_SimpleMembership
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}