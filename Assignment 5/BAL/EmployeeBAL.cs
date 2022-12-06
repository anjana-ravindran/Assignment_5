using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Assignment_5.BAL
{
    public class EmployeeBAL
    {
        DAL.EmployeeDAL objemployeeDAL = new DAL.EmployeeDAL();
        private int _employeeid;
        private string _employeename;
        private int _employeeage;
        private string _employeeemail;
        private string _employeephone;
        public int EmployeeId
        {
            get
            {
                return _employeeid;
            }
            set
            {
                _employeeid = value;
            }

        }
        public string EmployeeName
        {
            get
            {
                return _employeename;
            }
            set
            {
                _employeename = value;
            }

        }
        public int EmployeeAge
        {
            get
            {
                return _employeeage;
            }
            set
            {
                _employeeage = value;
            }

        }
        public string EmployeeEmail
        {
            get
            {
                return _employeeemail;
            }
            set
            {
                _employeeemail = value;
            }

        }
        public string EmployeePhone
        {
            get
            {
                return _employeephone;
            }
            set
            {
                _employeephone = value;
            }

        }
        public int insertEmployee()
        {
            return objemployeeDAL.employeeInsert(this);
        }

        public DataTable viewEmployee()
        {
            return objemployeeDAL.employeeView();
        }
        public int updateEmployee()
        {
            return objemployeeDAL.employeeUpdate(this);
        }

        public int deleteEmployee()
        {
            return objemployeeDAL.employeeDelete(this);
        }
    }
}
