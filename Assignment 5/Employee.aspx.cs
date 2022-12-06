using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5
{
    public partial class Employee : System.Web.UI.Page
    {
        BAL.EmployeeBAL objemployeebal = new BAL.EmployeeBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objemployeebal.viewEmployee();
                GridView1.DataBind();
            }

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            objemployeebal.EmployeeId = id;
            int i = objemployeebal.deleteEmployee();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objemployeebal.viewEmployee();
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objemployeebal.viewEmployee();
            GridView1.DataBind();

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txtemployeename = new TextBox();
            txtemployeename = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox txtemployeeage= new TextBox();
            txtemployeeage = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox txtemployeeemail = new TextBox();
            txtemployeeemail = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];
            TextBox txtemployeephone = new TextBox();
            txtemployeephone = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];
            objemployeebal.EmployeeId = id;
            objemployeebal.EmployeeName= txtemployeename.Text;
            objemployeebal.EmployeeAge = Convert.ToInt32(txtemployeeage.Text);
            objemployeebal.EmployeeEmail = txtemployeeemail.Text;
            objemployeebal.EmployeePhone = txtemployeephone.Text;
            int i = objemployeebal.updateEmployee();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objemployeebal.viewEmployee();
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objemployeebal.viewEmployee();
            GridView1.DataBind();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            objemployeebal.EmployeeName = txtempname.Text;
            objemployeebal.EmployeeAge = Convert.ToInt32(txtage.Text);
            objemployeebal.EmployeeEmail = txtemail.Text;
            objemployeebal.EmployeePhone = Convert.ToInt64(txtphone.Text).ToString();
            int i = objemployeebal.insertEmployee();
            GridView1.DataSource = objemployeebal.viewEmployee();
            GridView1.DataBind();
            if (i == 1)
            {
                Response.Write("<script>alert('Inserted Successfully');</script>");
            }
            else
            {
                Response.Write("<script>alert('Insertion Failed');</script>");
            }
            txtempname.Text = "";
            txtage.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";

        }
    }
}