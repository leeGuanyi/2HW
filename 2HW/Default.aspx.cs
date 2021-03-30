using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2HW {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int N = 18;
            int sum = 0;
            for (int a = 1; a <= N; a++)
            {
                if ((a % 2 == 0) || (a % 3 == 0))
                {
                    if ((a%2 == 0)&&(a%3 == 0))
                    {
                        sum += a;
                    }
                    else
                    {
                        sum += a;
                    }
                }
            }
            Response.Write(sum);

        }
    }
}
