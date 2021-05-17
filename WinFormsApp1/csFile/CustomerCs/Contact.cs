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
        public bool addContact(int Id, string fname, string lname, int group_id, string phone, string email, string address, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO mycontact (fname, lname, group_id, phone, email, address, picture, userid) VALUES (@fname, @lname, @group_id, @phone, @email, @address, @picture, @userid)", mydb.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = Id;
            cmd.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            cmd.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            cmd.Parameters.Add("@group_id", System.Data.SqlDbType.DateTime).Value = group_id;
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

    }
}
