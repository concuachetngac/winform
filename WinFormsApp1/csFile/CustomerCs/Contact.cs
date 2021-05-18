using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace WinFormsApp1.csFile.CustomerCs
{
    class Contact
    {
        MY_DB mydb = new MY_DB();
        public bool addContact(int Id, string fname, string lname, int group_id, string phone, string email, string address, MemoryStream picture, int userID)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO mycontact (id, fname, lname, group_id, phone, email, address, picture, userid) VALUES (@id, @fname, @lname, @group_id, @phone, @email, @address, @picture, @userid)", mydb.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@group_id", System.Data.SqlDbType.Int).Value = group_id;
            cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = phone;
            cmd.Parameters.Add("@address", System.Data.SqlDbType.NVarChar).Value = address;
            cmd.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();
            cmd.Parameters.Add("@userid", System.Data.SqlDbType.Int).Value = userID;

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

        public bool editContact(int id, string fname, string lname, int group_id, string phone, string email, string address, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("UPDATE mycontact SET fname=@fname, lname=@lname, group_id=@group_id, phone=@phone, email=@email, address=@address, picture=@picture WHERE id=@id ", mydb.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@group_id", System.Data.SqlDbType.Int).Value = group_id;
            cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = phone;
            cmd.Parameters.Add("@address", System.Data.SqlDbType.NVarChar).Value = address;
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

        public DataTable getContactInfo(int contactID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM mycontact WHERE id=@id", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = contactID;

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public DataTable getAllContactInfo()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM mycontact", mydb.getConnection);

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            return table;
        }

        public bool removeContact(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM mycontact WHERE id=@id ", mydb.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
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
