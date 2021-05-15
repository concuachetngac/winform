using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WinFormsApp1.csFile
{
    class Score
    {
        MY_DB mydb = new MY_DB();

        public bool addScore(int stdID, int courseID, float score, string description)
        {
            SqlCommand cmd = new SqlCommand("UPDATE score SET student_score = @score, description = @des WHERE student_id = @std_id AND course_id = @course_id", mydb.getConnection);
            cmd.Parameters.Add("@score", SqlDbType.Float).Value = score;
            cmd.Parameters.Add("@std_id", SqlDbType.Int).Value = stdID;
            cmd.Parameters.Add("@course_id", SqlDbType.Int).Value = courseID;
            cmd.Parameters.Add("@des", SqlDbType.NVarChar).Value = description;

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

        public bool removeScore(int stdID, int courseID)
        {
            SqlCommand cmd = new SqlCommand("DELETE score WHERE student_id = @std_id AND course_id = @course_id", mydb.getConnection);
            cmd.Parameters.Add("@std_id", SqlDbType.Int).Value = stdID;
            cmd.Parameters.Add("@course_id", SqlDbType.Int).Value = courseID;

            mydb.openConnection();

            if (cmd.ExecuteNonQuery() > 0)
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
