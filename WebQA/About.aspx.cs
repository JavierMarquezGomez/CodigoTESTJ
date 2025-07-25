using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQA
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int c = 20;
            int mul = 4 * c;
#if DEBUG
            Console.WriteLine("hol");
            Console.WriteLine("Total : " +mul);
#endif
        }
    }
}