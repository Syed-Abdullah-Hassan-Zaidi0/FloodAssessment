using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class HomeFloodInfoDAL
    {
        public static int SaveInfo(HomeFloodInfoModel tm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_AddHomeFloodInfo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@heading", tm.heading);
            cmd.Parameters.AddWithValue("@info", tm.info);
            cmd.Parameters.AddWithValue("@imageURL", tm.imageURL);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<HomeFloodInfoModel> GetInfo()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetHomeFloodInfo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<HomeFloodInfoModel> infoList = new List<HomeFloodInfoModel>();
            while (sdr.Read())
            {
                HomeFloodInfoModel info = new HomeFloodInfoModel();
                info.pid = (int)sdr["pid"];
                info.heading = sdr["heading"].ToString();
                info.info = sdr["info"].ToString();
                info.imageURL = sdr["imageURL"].ToString();
                infoList.Add(info);
            }
            con.Close();
            return infoList;
        }

        public static int DeleteInfo(int pid)
        {
            
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteHomeFloodInfo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
