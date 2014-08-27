using System;

namespace Sharepoint.Startup.Example
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Sharepoint.Startup.Application.Start(() =>
            {
                // todo: add code here that you want to run when the application starts
            });
        }
    }
}