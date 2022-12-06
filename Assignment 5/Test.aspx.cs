using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5
{
    public partial class Test : System.Web.UI.Page
    {
        DbOperation db = new DbOperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string eid = Request.QueryString["id"].ToString();
                DataTable dt = db.Executedatatable("select * from tbL_Employee where Employee_id='"+eid+"'" );
                lblempname.Text = dt.Rows[0]["Employee_Name"].ToString();
                lblempage.Text = dt.Rows[0]["Age"].ToString();
                lblempemail.Text = dt.Rows[0]["Email"].ToString();
                lblempphone.Text = dt.Rows[0]["Phone"].ToString();
            }

        }
    }
}