using System.Web.Mvc;

namespace NewFlucompMVC.Areas.Admin534139597
{
    public class Admin534139597AreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin534139597";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin534139597_default",
                "Admin534139597/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional, controller="Dash" }
            );
        }
    }
}
