using System.Web.Mvc;

namespace Cojac.Web.Areas.NBA
{
    public class NBAAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "NBA";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "NBA_default",
                "NBA/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
