using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{

    public class PakRemoteSensingDAL
    {
        public static int SaveInfo(PakRemoteSensingModel tm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_PakRemoteSensing", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@heading", tm.heading);
            cmd.Parameters.AddWithValue("@heading2", tm.heading2);
            cmd.Parameters.AddWithValue("@info", tm.info);
            cmd.Parameters.AddWithValue("@info2", tm.info2);
            cmd.Parameters.AddWithValue("@info3", tm.info3);
            cmd.Parameters.AddWithValue("@imageURL1", tm.imageURL1);
            cmd.Parameters.AddWithValue("@imageURL2", tm.imageURL2);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<PakRemoteSensingModel> GetModelInfo()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetPakRemoteSensing", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<PakRemoteSensingModel> infoList = new List<PakRemoteSensingModel>();
            while (sdr.Read())
            {
                PakRemoteSensingModel info = new PakRemoteSensingModel
                {
                    heading = sdr["heading"].ToString(),
                    heading2 = sdr["heading2"].ToString(),
                    info = sdr["info"].ToString(),
                    info2 = sdr["info2"].ToString(),
                    info3 = sdr["info3"].ToString(),
                    imageURL1 = sdr["imageURL1"].ToString(),
                    imageURL2 = sdr["imageURL2"].ToString()
                };
                infoList.Add(info);
            }
            con.Close();
            return infoList;
        }

        public static int DeleteInfo(int pid)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeletePakRemoteSensing", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
