﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CloudShop.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.CreateUserWizard1.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }
    }
}
