using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MOMAAPP.Models
{
    public class SalaryService
    {
        string constr = @"Server=.;Database=MyDB;Trusted_Connection=True;
               MultipleActiveResultSets=true";
        public DataTable GetEmploiyeeSalaryInfo()
        {
            var dt = new DataTable();
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("select * from tblMainZ", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
    }
}
