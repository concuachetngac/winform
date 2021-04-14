﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace WinFormsApp1
{
    class Course
    {
        MY_DB mydb = new MY_DB();
        public bool removeCourseById(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM course WHERE Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
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

        public bool insertCourse(int id, string label, int period, string des)
        {
            SqlCommand command = new SqlCommand("INSERT INTO course (id, label, period, description) VALUES (@id, @label, @period, @des)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@des", SqlDbType.Text).Value = des;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
        public bool checkCourseName(string courseName, int courseId = 0)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE label=@cName And id <> @cID", mydb.getConnection);

            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@cID", SqlDbType.Int).Value = courseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows.Count <= 0;

        }
        public bool editCourse(int id, string label, string newLabel, int period, string description)
        {
            SqlCommand cmd = new SqlCommand("UPDATE course SET id = @id, label = @newLabel, period =@period, description = @des WHERE label = @label", mydb.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@label", SqlDbType.NVarChar).Value = label;
            cmd.Parameters.Add("@newLabel", SqlDbType.NVarChar).Value = newLabel;
            cmd.Parameters.Add("@period", SqlDbType.Int).Value = period;
            cmd.Parameters.Add("@des", SqlDbType.NVarChar).Value = description;
            mydb.openConnection();
            if(cmd.ExecuteNonQuery() > 0)
            {
                mydb.closeConnection();
                return true;
            } else {
                mydb.closeConnection();
                return false;
            }
        }
    }
}