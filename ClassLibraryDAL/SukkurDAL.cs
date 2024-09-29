using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class SukkurDAL
    {
        public static int SaveSukkurInfo(SukkurModel tm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_AddSukkur", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@heading", tm.heading);
            cmd.Parameters.AddWithValue("@info", tm.info);
            cmd.Parameters.AddWithValue("@imageURL4", tm.imageURL4);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<SukkurModel> GetSukkurInfo()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetSukkur", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<SukkurModel> infoList = new List<SukkurModel>();
            while (sdr.Read())
            {
                SukkurModel info = new SukkurModel();
                info.pid = (int)sdr["pid"];
                info.heading = sdr["heading"].ToString();
                info.info = sdr["info"].ToString();
                info.imageURL4 = sdr["imageURL4"].ToString();
                infoList.Add(info);
            }
            con.Close();
            return infoList;
        }

        public static int DeleteSukkurInfo(int pid)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteSukkur", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
