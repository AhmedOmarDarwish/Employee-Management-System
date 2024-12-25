using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Employee_Management_System
{
    internal class EmployeeData
    {
        //public int ID { get; set; }
        //public string EmployeeId { get; set; }
        //public string FullName { get; set; }
        //public char Gender { get; set; }
        //public string ContactNumber { get; set; }
        //public string Position { get; set; }
        //public string Image { get; set; }
        //public double Salary { get; set; }
        //public string Status { get; set; }
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\DEPI\C#\Pro\Employee Management System\Employee.mdf"";Integrated Security=True;Connect Timeout=30");

        //public List<EmployeeData> employeesListData() {
        
        //List<EmployeeData> listdata = new List<EmployeeData>();

        //    if (connect.State != ConnectionState.Open) {

        //        try
        //        {
        //       //     connect.Open();
        //            //string selectData = " Select * from employees where delete_date IS NULL";
        //            string selectData = " Select * from employees";

        //            using (SqlCommand cmd = new SqlCommand(selectData, connect)) { 
                    
        //            SqlDataReader reader = cmd.ExecuteReader();
        //                while (reader.Read()) { 
                        
        //                    EmployeeData employeedata = new EmployeeData();
        //                    employeedata.ID = (int)reader["ID"];
        //                    employeedata.EmployeeId = reader["Employee_Id"].ToString();
        //                    employeedata.FullName = reader["Full_Name"].ToString();
        //                    employeedata.Gender = char.Parse(reader["Gender"].ToString());
        //                    employeedata.ContactNumber = reader["Contact_Number"].ToString();
        //                    employeedata.Position = reader["Position"].ToString();
        //                    employeedata.Image = reader["Image"].ToString();
        //                    employeedata.Salary = Double.Parse(reader["Salary"].ToString());
        //                    employeedata.Status = reader["Status"].ToString();

        //                    listdata.Add(employeedata);

        //                }

        //            }

        //        }
        //        catch (Exception ex) 
        //        {
        //           Console.WriteLine("Error: " + ex);
        //        }
        //        finally { 
        //            connect.Close();
        //        }




        //    }
        //    return listdata;
        
        //}

    }
}
