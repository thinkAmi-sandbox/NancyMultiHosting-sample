using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NancyApp
{
    public class HomeModule : Nancy.NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "hello world";

            // `View["bin/Views/static"];`では、AspNetHostingは動作するが、SelfHostingが動作しない
            //Get["/static"] = _ => View["bin/Views/static"];
            Get["/static"] = _ => View["static"];
        }
    }
}
