using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace WinFormsApp1.csFile
{
    class Customer
    {

        MY_DB mydb = new MY_DB();

        public bool insertCustomer(int Id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO customer (id, fname, lname, username, password, picture) VALUES (@id, @fname, @lname, @username, @password, @picture)", mydb.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool checkExist(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT username FROM account WHERE username = @username", mydb.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);
            
            if(table.Rows.Count == 0)
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable getCustomerInfo(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM customer WHERE id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool editCustomer(int id, string fname, string lname, string username, string password, MemoryStream picture) 
        {
            SqlCommand cmd = new SqlCommand("UPDATE customer SET fname=@fname, lname=@lname, username=@username, password=@password, picture=@picture WHERE id=@id ", mydb.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if ((cmd.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        

    }
}
