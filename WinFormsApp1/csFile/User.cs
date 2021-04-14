using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace WindowsFormsApp2
{
    class User
    {
        MY_DB listUserDB = new MY_DB();
        public bool insertUser(int Id, string fname, string lname, DateTime birthDate, string gender, int phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO listUser (id, fname, lname, birthdate, gender, phone, picture, address) VALUES (@id, @fname, @lname, @birthdate, @gender, @phone, @picture, @address)", listUserDB.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@birthdate", System.Data.SqlDbType.DateTime).Value = birthDate;
            command.Parameters.Add("@gender", System.Data.SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phone", System.Data.SqlDbType.Int).Value = phone;
            command.Parameters.Add("@address", System.Data.SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            listUserDB.openConnection();

            if((command.ExecuteNonQuery() == 1))
            {
                listUserDB.closeConnection();
                return true;
            } else {
                listUserDB.closeConnection();
                return false;
            }
        }
        public bool deleteUser(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM listUser WHERE Id = @id", listUserDB.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            listUserDB.openConnection();
            if((command.ExecuteNonQuery() == 1))
            {
                listUserDB.closeConnection();
                return true;
            } else
            {
                listUserDB.closeConnection();
                return false;
            }
        }
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = listUserDB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool editUser(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE listUser SET fname = @fname, lname = @lname, birthdate = @bdate, gender = @gender, phone = @phone, address = @adrs, picture = @picture WHERE Id = @id", listUserDB.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", System.Data.SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gender", System.Data.SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phone", System.Data.SqlDbType.Int).Value = Convert.ToInt32(phone);
            command.Parameters.Add("@adrs", System.Data.SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();
            listUserDB.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                listUserDB.closeConnection();
                return true;
            }
            else
            {
                listUserDB.closeConnection();
                return false;
            }
        }
    }
}
