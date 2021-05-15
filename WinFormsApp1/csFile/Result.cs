using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;

namespace WinFormsApp1.csFile
{
    class Result
    {
        MY_DB mydb = new MY_DB();
        Course course = new Course();
        User user = new User();
        public DataTable getResultTable(DataTable getAllCourse)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id, fname, lname FROM listUser", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);
            table.Columns[0].ColumnName = "ID";
            table.Columns[1].ColumnName = "First Name";
            table.Columns[2].ColumnName = "Last Name";

            for (int i = 0; i < getAllCourse.Rows.Count; i++)
            {
                table.Columns.Add(getAllCourse.Rows[i].ItemArray[0].ToString(), typeof(float));
            }

            table.Columns.Add("Avarage Score", typeof(float));
            table.Columns.Add("Result", typeof(string));

            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i][table.Columns.Count - 2] = user.getAvgScore(Convert.ToInt32(table.Rows[i][0]));
                if (user.getAvgScore(Convert.ToInt32(table.Rows[i][0])) >= 5)
                {
                    table.Rows[i][table.Columns.Count - 1] = "pass";
                }
                else
                {
                    table.Rows[i][table.Columns.Count - 1] = "fail";
                }
            }

            return table;
        }

        //This function will return table with score of searched user
        public DataTable searchUserTable(DataTable getAllCourse, string id_fname)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id, fname, lname FROM listUser WHERE id = @id OR fname = @fname", mydb.getConnection);

            try
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id_fname);
                cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = "";
            }
            catch
            {

                cmd.Parameters.Clear();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = id_fname;

            }

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);
            table.Columns[0].ColumnName = "ID";
            table.Columns[1].ColumnName = "First Name";
            table.Columns[2].ColumnName = "Last Name";
         
            for (int i = 0; i < getAllCourse.Rows.Count; i++)
            {
                table.Columns.Add(getAllCourse.Rows[i].ItemArray[0].ToString(), typeof(float));
            }

            table.Columns.Add("Avarage Score", typeof(float));
            table.Columns.Add("Result", typeof(string));

            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i][table.Columns.Count - 2] = user.getAvgScore(Convert.ToInt32(table.Rows[i][0]));
                if (user.getAvgScore(Convert.ToInt32(table.Rows[i][0])) >= 5)
                {
                    table.Rows[i][table.Columns.Count - 1] = "pass";
                }
                else
                {
                    table.Rows[i][table.Columns.Count - 1] = "fail";
                }
            }

            return table;
        }

        public float getPassPercent()
        {
            SqlCommand cmd = new SqlCommand("SELECT description FROM score", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);
            int pass = 0;

            for(int i = 0; i < table.Rows.Count; i++)
            {
                if(table.Rows[i][0].ToString() == "pass")
                {
                    pass++;
                } 
            }

            return pass * 100 / table.Rows.Count;

        } 


    }
}
