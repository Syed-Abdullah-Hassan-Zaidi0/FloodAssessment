using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class PakFloodInfoDAL
    {
        public static int SavePakFloodInfo(PakFloodInfoModel tm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_AddPakFloodInfo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@heading", tm.heading);
            cmd.Parameters.AddWithValue("@info", tm.info);
            cmd.Parameters.AddWithValue("@imageURL6", tm.imageURL6);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<PakFloodInfoModel> GetPakFloodInfo()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetPakFloodInfo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<PakFloodInfoModel> infoList = new List<PakFloodInfoModel>();
            while (sdr.Read())
            {
               PakFloodInfoModel info = new PakFloodInfoModel();
                info.pid = (int)sdr["pid"];
                info.heading = sdr["heading"].ToString();
                info.info = sdr["info"].ToString();
                info.imageURL6 = sdr["imageURL6"].ToString();
                infoList.Add(info);
            }
            con.Close();
            return infoList;
        }

        public static int DeletePakFloodInfo(int pid)
        {

            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeletePakFloodInfo", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
