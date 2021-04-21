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
        MY_DB mydb = new MY_DB();
        public bool insertUser(int Id, string fname, string lname, DateTime birthDate, string gender, int phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO listUser (id, fname, lname, birthdate, gender, phone, picture, address) VALUES (@id, @fname, @lname, @birthdate, @gender, @phone, @picture, @address)", mydb.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@birthdate", System.Data.SqlDbType.DateTime).Value = birthDate;
            command.Parameters.Add("@gender", System.Data.SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phone", System.Data.SqlDbType.Int).Value = phone;
            command.Parameters.Add("@address", System.Data.SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            } else {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable userList()
        {
            MY_DB db = new MY_DB();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM listUser", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(tb);
            return tb;
        }
        public bool deleteUser(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM listUser WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            mydb.openConnection();
            if((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool editUser(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE listUser SET fname = @fname, lname = @lname, birthdate = @bdate, gender = @gender, phone = @phone, address = @adrs, picture = @picture WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", System.Data.SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@lname", System.Data.SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdate", System.Data.SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gender", System.Data.SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phone", System.Data.SqlDbType.Int).Value = Convert.ToInt32(phone);
            command.Parameters.Add("@adrs", System.Data.SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@picture", System.Data.SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
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


        public bool addCourse(int studentID, int courseID, float score, string description)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO score (student_id, course_id) VALUES (@student_id, @course_id)", mydb.getConnection);
            cmd.Parameters.Add("@student_id", SqlDbType.Int).Value = studentID;
            cmd.Parameters.Add("@course_id", SqlDbType.Int).Value = courseID;

            mydb.openConnection();
            
            if(cmd.ExecuteNonQuery() > 0)
            {
                mydb.closeConnection();
                return true;
            } else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
