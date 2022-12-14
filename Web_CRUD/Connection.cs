using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Web_CRUD
{
    public class Connection
    {
        SqlConnection con = new SqlConnection("Server=MSI\\SQLEXPRESS;Integrated Security=true;Database=Northwind;");


        public SqlDataAdapter GetData()
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            SqlCommand cmd = new SqlCommand("select * from Labours", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            con.Close();

            return dr;
        }

        public void Update(string ID, string Name, string Surname, string Email, string Job, string Position)
        {
            if (con.State != ConnectionState.Open) con.Open();

            var Id = int.Parse(ID);
            SqlCommand cmd = new SqlCommand("update Labours set Name='" + Name + "',Surname='" + Surname + "',Email='" + Email + "',Job='" + Job + "', Position='" + Position + "' where ID='" + ID + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Delete(int ID)
        {
            if (con.State != ConnectionState.Open) con.Open();

            SqlCommand cmd = new SqlCommand("Delete from Labours where ID='" + ID + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}