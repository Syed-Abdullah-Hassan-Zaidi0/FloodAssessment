using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class LarkanaDAL
    {
        public static int SaveLarkanaInfo (LarkanaModel tm)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_Larkana", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@heading", tm.heading);
            cmd.Parameters.AddWithValue("@info", tm.info);
            cmd.Parameters.AddWithValue("@imageURL3", tm.imageURL3);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<LarkanaModel> GetLarkanaInfo()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_GetLarkana", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            List<LarkanaModel> infoList = new List<LarkanaModel>();
            while (sdr.Read())
            {
                LarkanaModel info = new LarkanaModel();
                info.pid = (int)sdr["pid"];
                info.heading = sdr["heading"].ToString();
                info.info = sdr["info"].ToString();
                info.imageURL3 = sdr["imageURL3"].ToString();
                infoList.Add(info);
            }
            con.Close();
            return infoList;
        }

        public static int DeleteLarkanaInfo(int pid)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_DeleteLarkana", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
