using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class ShikarpurDAL
    {
        public static int SaveShikarpurInfo(ShikarpurModel tm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_AddShikarpur", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@heading", tm.heading);
            cmd.Parameters.AddWithValue("@info", tm.info);
            cmd.Parameters.AddWithValue("@imageURL5", tm.imageURL5);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<ShikarpurModel> GetShikarpurInfo()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetShikarpur", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<ShikarpurModel> infoList = new List<ShikarpurModel>();
            while (sdr.Read())
            {
                ShikarpurModel info = new ShikarpurModel();
                info.pid = (int)sdr["pid"];
                info.heading = sdr["heading"].ToString();
                info.info = sdr["info"].ToString();
                info.imageURL5 = sdr["imageURL5"].ToString();
                infoList.Add(info);
            }
            con.Close();
            return infoList;
        }

        public static int DeleteShikarpurInfo(int pid)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteShikarpur", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}

