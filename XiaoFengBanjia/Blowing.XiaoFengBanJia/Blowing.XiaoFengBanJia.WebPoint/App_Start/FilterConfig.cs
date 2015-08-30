using System.Web;
using System.Web.Mvc;

namespace Blowing.XiaoFengBanJia.WebPoint
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
