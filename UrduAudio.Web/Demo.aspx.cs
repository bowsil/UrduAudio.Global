using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrduAudio.Log;

namespace UrduAudio.Web
{
    public partial class Demo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UrduAudio.Log.ErrLog.LogDefaultError("This is for testing");

            //Declare an instance for log4net

        }
    }
}