using System.Web;
using System.Web.Mvc;

namespace rekry_tehtava_ville_aho
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
