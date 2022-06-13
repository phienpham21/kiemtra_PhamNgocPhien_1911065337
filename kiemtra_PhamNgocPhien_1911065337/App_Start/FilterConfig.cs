using System.Web;
using System.Web.Mvc;

namespace kiemtra_PhamNgocPhien_1911065337
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
