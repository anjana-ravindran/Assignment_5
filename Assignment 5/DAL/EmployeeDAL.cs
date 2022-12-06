using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Assignment_5.DAL
{
    public class EmployeeDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public EmployeeDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int employeeInsert(BAL.EmployeeBAL obj)
        {
            string qry = "insert into tbl_Employee values('" + obj.EmployeeName + "','" + obj.EmployeeAge+ "','" + obj.EmployeeEmail + "','" + obj.EmployeePhone + "')";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            return cmd.ExecuteNonQuery();
        }


        public DataTable employeeView()
        {
            string s = "select * from tbl_employee";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int employeeUpdate(BAL.EmployeeBAL obj)
        {
            string s = "update tbl_Employee set Employee_Name='" + obj.EmployeeName + "',Age='" + obj.EmployeeAge+ "',Email='" + obj.EmployeeEmail + "',Phone='" + obj.EmployeePhone + "' where Employee_id='" + obj.EmployeeId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();

        }
        public int employeeDelete(BAL.EmployeeBAL obj)
        {
            string s = "Delete from tbl_Employee where Employee_id='" + obj.EmployeeId + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();

        }
    }
}