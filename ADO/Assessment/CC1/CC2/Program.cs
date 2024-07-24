using System;
using System.Data;
using System.Data.SqlClient;

namespace CC1

{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static void Main(string[] args)
        {
            InsertData();

            Console.Read();

        }
        private static SqlConnection getConnection()
        {
            con = new SqlConnection("data source=ICS-LT-CRY19C3; initial catalog=Employeemanagement; integrated security=true;");
            con.Open();
            return con;
        }

        public static void InsertData()
        {
            con = getConnection();

            string empname;
            decimal empsal;
            char emptype;

            Console.WriteLine("Enter employee details:");
            empname = Console.ReadLine();
            empsal = Convert.ToDecimal(Console.ReadLine());
            emptype = Convert.ToChar(Console.ReadLine());

            cmd = new SqlCommand("AddingEmpDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@empname", empname);
            cmd.Parameters.AddWithValue("@empsal", empsal);
            cmd.Parameters.AddWithValue("@emptype", emptype);

            cmd.ExecuteNonQuery();

            //Console.WriteLine($"Employee added with Empno: {empno}");


            con.Close();

            DisplayAllEmployees();
        }

        public static void DisplayAllEmployees()
        {
            con = getConnection();

            cmd = new SqlCommand("Select * From Employee_Details", con);

            dr = cmd.ExecuteReader();

            Console.WriteLine("All Employee Details:");
            while (dr.Read())
            {
                Console.WriteLine($"Empnumber : {dr["empno"]}, Empname : {dr["empname"]}, Empsalary : {dr["empsal"]}, Emptype : {dr["emptype"]}");
            }

            dr.Close();
            con.Close();

        }
    }
}



