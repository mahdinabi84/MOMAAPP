using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MOMAAPP.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace MOMAAPP.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration Configuration;
        public HomeController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        private string GetConnectionString()
        {
            return this.Configuration.GetConnectionString("DefaultConnection");
        }
        public IActionResult Index()
        {
          
            return View();
        }

            //offices

            public ActionResult check (Accounts acc)
        {
        
            SqlConnection con = new SqlConnection(GetConnectionString());
            SqlCommand com = new SqlCommand(@"select username,typename,office,password,statistic
               from tblUserRegister
               where  username=@username and password=@password and okey=1 ", con);
        
            com.Parameters.AddWithValue("@password", acc.password);
          
            com.Parameters.AddWithValue("@username", acc.username);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                acc.office = dr["office"].ToString();
                acc.typename = dr["typename"].ToString();
                acc.statistic = Convert.ToBoolean(dr["statistic"].ToString());
                ViewBag.username = acc.username;
                TempData["username"] = acc.username;
                ViewBag.office = acc.office;
                TempData["office"] = acc.office;
                ViewBag.typename = acc.typename;
                ViewBag.statistic = acc.statistic;
                if (ViewBag.typename =="زيندانى سياسى")
                {
                    con.Close();
                    return View("/Views/Home/main.cshtml");
                }
                if (ViewBag.typename == "شه‌هيدان")
                {
                    con.Close();
                    return View("/Areas/Martyr/Views/Martyr/index.cshtml");
                }
                else
                    return View("/Views/Home/Stop.cshtml");

            }
            else
            {
                con.Close();
                return View("/Views/Home/Stop.cshtml");
            }

        }


    }
    //


}
