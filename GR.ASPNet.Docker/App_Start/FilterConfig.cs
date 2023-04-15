using System.Web;
using System.Web.Mvc;

namespace GR.ASPNet.Docker
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}