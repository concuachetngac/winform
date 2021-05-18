using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WinFormsApp1.csFile.CustomerCs
{
    class Group
    {
        MY_DB mydb = new MY_DB();

        public bool addGroup(string name, int userID) 
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO groups (name, userid) VALUES (@name, @userid)", mydb.getConnection);
            cmd.Parameters.Add("@userid", System.Data.SqlDbType.Int).Value = userID;
            cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;

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

        public DataTable getGroupList()
        {
            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT name FROM groups", mydb.getConnection);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(table);

            return table;
        }

        public int getGroupId(string groupName)
        {
            SqlCommand cmd = new SqlCommand("SELECT id FROM groups where name = @name", mydb.getConnection);
            cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = groupName;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            if(table.Rows.Count ==0)
            {
                return 0;
            }

            return Convert.ToInt32(table.Rows[0][0]);
        }

        public string getGroupName(int groupID)
        {
            SqlCommand cmd = new SqlCommand("SELECT name FROM groups where id = @id", mydb.getConnection);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = groupID;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            if (table.Rows.Count == 0)
            {
                return "";
            }

            return table.Rows[0][0].ToString();
        }

        public bool editGroup(string groupName, int groupID) 
        {
            SqlCommand cmd = new SqlCommand("UPDATE groups SET name=@name WHERE id = @groupid ", mydb.getConnection);
            cmd.Parameters.Add("@groupid", System.Data.SqlDbType.Int).Value = groupID;
            cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = groupName;


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

        public bool removeGroup(int groupID)
        {
            SqlCommand cmd = new SqlCommand("DELETE groups WHERE id = @groupid ", mydb.getConnection);
            cmd.Parameters.Add("@groupid", System.Data.SqlDbType.Int).Value = groupID;



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

        public bool checkAvailable(int userID, string groupName)
        {
            SqlCommand cmd = new SqlCommand("SELECT name FROM groups where userid = @userid", mydb.getConnection);
            cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = groupName;
            cmd.Parameters.Add("@userid", System.Data.SqlDbType.Int).Value = userID;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adpt.Fill(table);

            if(table.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }


    }
}
