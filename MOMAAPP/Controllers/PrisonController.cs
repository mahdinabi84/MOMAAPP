using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MOMAAPP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace MOMAAPP.Controllers
{
    public class PrisonController : Controller
    {
        private readonly ILogger<PrisonController> _logger;
        private readonly IWebHostEnvironment _webHostEnv;
      
        public PrisonController(ILogger<PrisonController> logger, IWebHostEnvironment webHostEnv,
            IConfiguration _configuration)
        {
            _logger = logger;
            _webHostEnv = webHostEnv;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Configuration = _configuration;
        }
        //
        private IConfiguration Configuration;
        //public PrisonController(IConfiguration _configuration)
        //{
        //    Configuration = _configuration;
        //}
        private string GetConnectionString()
        {
            return this.Configuration.GetConnectionString("DefaultConnection");
        }


        //

        public IActionResult Index()
        {
            return View();
        }
        
        //prison
        [HttpPost]
        public IActionResult UploadFile(IFormFile postedFile, prisontable acc)
        {
            //string fileName = Path.GetFileName(postedFile.FileName);
            //string contentType = postedFile.ContentType;
            using (MemoryStream ms = new MemoryStream())
            {
                postedFile.CopyTo(ms);

                using (SqlConnection con = new SqlConnection(GetConnectionString()))
                {
                    string query = @"INSERT INTO tblMainZ VALUES (@office,@employer,@NameZ,@gender,
@MotherName,
@Miratgr,@paywandi,@city,@place,@BerwarGiran,@BerwarAzad,@roj,@mang,@sal,@joriZendani,@code,@mobile,
@DOBZ,@DOBM,@mnha,@bank,@education,
@zawi,@house,@health,@married,@note,@pic,@wajba,@kartMeli,@jnsya,@nfus,@datenfus,@placenfus,@sjl,
@sahifa,@job1,@job2,@bio,@issalary,@much,@isminha,
@placesalary,@bio2,@nation,@DOBplace,@f1,@f2,@f3,@upn,@w1,@w2,@w3,@IDw,@GenderW,@f4,@m2,@m3,
@FreeHokar,@PlaceZ)";
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Connection = con;

                        cmd.Parameters.AddWithValue("@office", "ب.كاروبارى زيندانييه‌سياسيه‌كان‌");
                        cmd.Parameters.AddWithValue("@employer", acc.employer);
                        cmd.Parameters.AddWithValue("@NameZ", acc.NameZ);
                        cmd.Parameters.AddWithValue("@gender", acc.gender);
                        cmd.Parameters.AddWithValue("@MotherName", acc.MotherName);
                        cmd.Parameters.AddWithValue("@Miratgr", acc.Miratgr);
                        cmd.Parameters.AddWithValue("@paywandi", acc.paywandi);
                        cmd.Parameters.AddWithValue("@city", acc.city);
                        cmd.Parameters.AddWithValue("@place", acc.place);
                        cmd.Parameters.AddWithValue("@BerwarGiran", acc.BerwarGiran);
                        cmd.Parameters.AddWithValue("@BerwarAzad", acc.BerwarAzad);
                        cmd.Parameters.AddWithValue("@roj", acc.roj);
                        cmd.Parameters.AddWithValue("@mang", acc.mang);
                        cmd.Parameters.AddWithValue("@sal", acc.sal);
                        cmd.Parameters.AddWithValue("@joriZendani", acc.joriZendani);
                        cmd.Parameters.AddWithValue("@code", acc.code);
                        cmd.Parameters.AddWithValue("@mobile", acc.mobile);
                        cmd.Parameters.AddWithValue("@DOBZ", acc.DOBZ);
                        cmd.Parameters.AddWithValue("@DOBM", acc.DOBM);
                        cmd.Parameters.AddWithValue("@mnha", acc.mnha);
                        cmd.Parameters.AddWithValue("@bank", acc.bank);
                        cmd.Parameters.AddWithValue("@education", acc.education);
                        cmd.Parameters.AddWithValue("@zawi", acc.zawi);
                        cmd.Parameters.AddWithValue("@house", acc.house);
                        cmd.Parameters.AddWithValue("@health", acc.health);
                        cmd.Parameters.AddWithValue("@married", acc.married);
                        cmd.Parameters.AddWithValue("@note", acc.note);
                        cmd.Parameters.AddWithValue("@pic", ms.ToArray());//pic
                        cmd.Parameters.AddWithValue("@wajba", acc.wajba);
                        cmd.Parameters.AddWithValue("@kartMeli", acc.kartMeli);
                        cmd.Parameters.AddWithValue("@jnsya", acc.jnsya);
                        cmd.Parameters.AddWithValue("@nfus", acc.nfus);
                        cmd.Parameters.AddWithValue("@datenfus", acc.datenfus);
                        cmd.Parameters.AddWithValue("@placenfus", acc.placenfus);
                        cmd.Parameters.AddWithValue("@sjl", acc.sjl);
                        cmd.Parameters.AddWithValue("@sahifa", acc.sahifa);
                        cmd.Parameters.AddWithValue("@job1", acc.job1);
                        cmd.Parameters.AddWithValue("@job2", acc.job2);
                        cmd.Parameters.AddWithValue("@bio", acc.bio);
                        cmd.Parameters.AddWithValue("@issalary", acc.issalary);
                        cmd.Parameters.AddWithValue("@much", acc.much);
                        cmd.Parameters.AddWithValue("@isminha", acc.isminha);
                        cmd.Parameters.AddWithValue("@placesalary", acc.placesalary);
                        cmd.Parameters.AddWithValue("@bio2", acc.bio2);
                        cmd.Parameters.AddWithValue("@nation", acc.nation);
                        cmd.Parameters.AddWithValue("@DOBplace", acc.DOBplace);
                        cmd.Parameters.AddWithValue("@f1", acc.f1);
                        cmd.Parameters.AddWithValue("@f2", acc.f2);
                        cmd.Parameters.AddWithValue("@f3", acc.f3);
                        cmd.Parameters.AddWithValue("@upn", acc.upn);
                        cmd.Parameters.AddWithValue("@w1", acc.w1);
                        cmd.Parameters.AddWithValue("@w2", acc.w2);
                        cmd.Parameters.AddWithValue("@w3", acc.w3);
                        cmd.Parameters.AddWithValue("@IDw", acc.IDw);
                        cmd.Parameters.AddWithValue("@GenderW", acc.GenderW);
                        cmd.Parameters.AddWithValue("@f4", acc.f4);
                        cmd.Parameters.AddWithValue("@m2", acc.m2);
                        cmd.Parameters.AddWithValue("@m3", acc.m3);
                        cmd.Parameters.AddWithValue("@FreeHokar", acc.FreeHokar);
                        cmd.Parameters.AddWithValue("@PlaceZ", acc.PlaceZ);



                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
          
            return RedirectToAction("Index", "Prison");
        }
        //Update
        [HttpPost]
        //update prison
        public List<prisontable> GetCustomers(int? code)
        {
            List<prisontable> customers = new List<prisontable>();
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                    if (code != null)
                    {
                        cmd.CommandText = "SELECT * FROM tblMainZ WHERE code = @code";
                        cmd.Parameters.AddWithValue("@code", code);
                    }
                    else
                    {
                        cmd.CommandText = "SELECT * FROM tblMainZ  ";
                        //cmd.Parameters.AddWithValue("@Id",code);
                    }
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        customers.Add(new prisontable()
                        {
                            code = Convert.ToInt32(rdr["code"]),
                            NameZ = rdr["NameZ"].ToString(),

                            gender = rdr["gender"].ToString(),
                            MotherName = rdr["MotherName"].ToString(),
                            Miratgr = rdr["Miratgr"].ToString(),
                            paywandi = rdr["paywandi"].ToString(),
                            city = rdr["city"].ToString(),
                            place = rdr["place"].ToString(),
                            BerwarGiran = rdr["BerwarGiran"].ToString(),
                            BerwarAzad = rdr["BerwarAzad"].ToString(),
                            roj = Convert.ToInt32(rdr["roj"]),
                            mang = Convert.ToInt32(rdr["mang"]),
                            sal = Convert.ToInt32(rdr["sal"]),
                            joriZendani = rdr["joriZendani"].ToString(),
                            mobile = rdr["mobile"].ToString(),
                            DOBZ = rdr["DOBZ"].ToString(),
                            DOBM = rdr["DOBM"].ToString(),
                            mnha = Convert.ToInt32(rdr["mnha"]),
                            bank = rdr["bank"].ToString(),
                            education = Convert.ToBoolean(rdr["education"]),
                            zawi = Convert.ToBoolean(rdr["zawi"]),
                            house = Convert.ToBoolean(rdr["house"]),
                            health = Convert.ToBoolean(rdr["health"]),
                            married = Convert.ToBoolean(rdr["married"]),
                            note = rdr["note"].ToString(),
                            wajba = rdr["wajba"].ToString(),
                            //cmd.Parameters.AddWithValue("@pic", ms.ToArray());//pic
                            kartMeli = rdr["kartMeli"].ToString(),
                            jnsya = rdr["jnsya"].ToString(),
                            nfus = rdr["nfus"].ToString(),
                            datenfus = rdr["datenfus"].ToString(),
                            placenfus = rdr["placenfus"].ToString(),
                            sjl = rdr["sjl"].ToString(),
                            sahifa = rdr["sahifa"].ToString(),
                            job1 = rdr["job1"].ToString(),
                            job2 = rdr["job2"].ToString(),
                            bio = rdr["bio"].ToString(),
                            issalary = Convert.ToBoolean(rdr["issalary"]),
                            much = Convert.ToInt32(rdr["issalary"]),
                            isminha = Convert.ToBoolean(rdr["isminha"]),
                            placesalary = rdr["placesalary"].ToString(),
                            bio2 = rdr["bio2"].ToString(),
                            nation = rdr["nation"].ToString(),
                            DOBplace = rdr["DOBplace"].ToString(),
                            f1 = rdr["f1"].ToString(),
                            f2 = rdr["f2"].ToString(),
                            f3 = rdr["f3"].ToString(),
                            upn = rdr["upn"].ToString(),
                            w1 = rdr["w1"].ToString(),
                            w2 = rdr["w2"].ToString(),
                            w3 = rdr["w3"].ToString(),
                            IDw = rdr["IDw"].ToString(),
                            GenderW = rdr["GenderW"].ToString(),
                            f4 = rdr["f4"].ToString(),
                            m2 = rdr["m2"].ToString(),
                            m3 = rdr["m3"].ToString(),
                            FreeHokar = rdr["FreeHokar"].ToString(),
                            PlaceZ = rdr["PlaceZ"].ToString(),

                        });
                    }
                    con.Close();
                }
            }

            return customers;
        }
        public void AddUpdateDeleteCustomer(prisontable customer, string action)
        {
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Clear();
                    //if (action == "Insert")
                    //{
                    //    cmd.CommandText = "INSERT INTO Customers VALUES (@Name,@Country)";
                    //    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    //    cmd.Parameters.AddWithValue("@Country", customer.Country);
                    //}
                    //else if (action == "Update")


                    if (action == "Update")

                    {
                        cmd.CommandText = @"UPDATE tblMainZ SET NameZ=@NameZ, gender=@gender,
MotherName=@MotherName, Miratgr=@Miratgr, paywandi=@paywandi, city=@city, place=@place,
BerwarGiran=@BerwarGiran, BerwarAzad=@BerwarAzad,
 roj=@roj, mang=@mang, sal=@sal, joriZendani=@joriZendani,mobile=@mobile,DOBZ=@DOBZ,DOBM=@DOBM, mnha=@mnha,
bank=@bank, education=@education, zawi=@zawi, house=@house, health=@health, married=@married, note=@note, 
 wajba=@wajba, kartMeli=@kartMeli, jnsya=@jnsya, nfus=@nfus, datenfus=@datenfus, 
placenfus=@placenfus, sjl=@sjl, sahifa=@sahifa, job1=@job1, job2=@job2, bio=@bio, issalary=@issalary,
much=@much, isminha=@isminha,placesalary=@placesalary, bio2=@bio2, nation=@nation, DOBplace=@DOBplace, 
f1=@f1, f2=@f2, f3=@f3, upn=@upn, w1=@w1, w2=@w2, w3=@w3, IDw=@IDw, GenderW=@GenderW, f4=@f4,
m2=@m2, m3=@m3, FreeHokar=@FreeHokar, PlaceZ=@PlaceZ WHERE code = @code";
                        cmd.Parameters.AddWithValue("@NameZ", customer.NameZ);
                        cmd.Parameters.AddWithValue("@code", customer.code);
                        cmd.Parameters.AddWithValue("@gender", customer.gender);
                        cmd.Parameters.AddWithValue("@MotherName", customer.MotherName);
                        cmd.Parameters.AddWithValue("@Miratgr", customer.Miratgr);
                        cmd.Parameters.AddWithValue("@paywandi", customer.paywandi);
                        cmd.Parameters.AddWithValue("@city", customer.city);
                        cmd.Parameters.AddWithValue("@place", customer.place);
                        cmd.Parameters.AddWithValue("@BerwarGiran", customer.BerwarGiran);
                        cmd.Parameters.AddWithValue("@BerwarAzad", customer.BerwarAzad);
                        cmd.Parameters.AddWithValue("@roj", customer.roj);
                        cmd.Parameters.AddWithValue("@mang", customer.mang);
                        cmd.Parameters.AddWithValue("@sal", customer.sal);
                        cmd.Parameters.AddWithValue("@joriZendani", customer.joriZendani);
                        cmd.Parameters.AddWithValue("@mobile", customer.mobile);

                        cmd.Parameters.AddWithValue("@DOBZ", customer.DOBZ);
                        cmd.Parameters.AddWithValue("@DOBM", customer.DOBM);
                        cmd.Parameters.AddWithValue("@mnha", customer.mnha);
                        cmd.Parameters.AddWithValue("@bank", customer.bank);
                        cmd.Parameters.AddWithValue("@education", customer.education);
                        cmd.Parameters.AddWithValue("@zawi", customer.zawi);
                        cmd.Parameters.AddWithValue("@house", customer.house);
                        cmd.Parameters.AddWithValue("@health", customer.health);
                        cmd.Parameters.AddWithValue("@married", customer.married);
                        cmd.Parameters.AddWithValue("@note", customer.note);
                        //cmd.Parameters.AddWithValue("@pic", customer.pic);//pic
                        cmd.Parameters.AddWithValue("@wajba", customer.wajba);
                        cmd.Parameters.AddWithValue("@kartMeli", customer.kartMeli);
                        cmd.Parameters.AddWithValue("@jnsya", customer.jnsya);
                        cmd.Parameters.AddWithValue("@nfus", customer.nfus);
                        cmd.Parameters.AddWithValue("@datenfus", customer.datenfus);
                        cmd.Parameters.AddWithValue("@placenfus", customer.placenfus);
                        cmd.Parameters.AddWithValue("@sjl", customer.sjl);
                        cmd.Parameters.AddWithValue("@sahifa", customer.sahifa);
                        cmd.Parameters.AddWithValue("@job1", customer.job1);
                        cmd.Parameters.AddWithValue("@job2", customer.job2);
                        cmd.Parameters.AddWithValue("@bio", customer.bio);
                        cmd.Parameters.AddWithValue("@issalary", customer.issalary);
                        cmd.Parameters.AddWithValue("@much", customer.much);
                        cmd.Parameters.AddWithValue("@isminha", customer.isminha);
                        cmd.Parameters.AddWithValue("@placesalary", customer.placesalary);
                        cmd.Parameters.AddWithValue("@bio2", customer.bio2);
                        cmd.Parameters.AddWithValue("@nation", customer.nation);
                        cmd.Parameters.AddWithValue("@DOBplace", customer.DOBplace);
                        cmd.Parameters.AddWithValue("@f1", customer.f1);
                        cmd.Parameters.AddWithValue("@f2", customer.f2);
                        cmd.Parameters.AddWithValue("@f3", customer.f3);
                        cmd.Parameters.AddWithValue("@upn", customer.upn);
                        cmd.Parameters.AddWithValue("@w1", customer.w1);
                        cmd.Parameters.AddWithValue("@w2", customer.w2);
                        cmd.Parameters.AddWithValue("@w3", customer.w3);
                        cmd.Parameters.AddWithValue("@IDw", customer.IDw);
                        cmd.Parameters.AddWithValue("@GenderW", customer.GenderW);
                        cmd.Parameters.AddWithValue("@f4", customer.f4);
                        cmd.Parameters.AddWithValue("@m2", customer.m2);
                        cmd.Parameters.AddWithValue("@m3", customer.m3);
                        cmd.Parameters.AddWithValue("@FreeHokar", customer.FreeHokar);
                        cmd.Parameters.AddWithValue("@PlaceZ", customer.PlaceZ);
                    }


                    else if (action == "Delete")
                    {
                        cmd.CommandText = "DELETE FROM tblMainZ WHERE code = @code";
                        cmd.Parameters.AddWithValue("@code", customer.code);
                    }
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        public IActionResult Edit(int code)
        {

            return View(GetCustomers(code).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult Edit(prisontable customer)
        {
            if (ModelState.IsValid)
            {
                AddUpdateDeleteCustomer(customer, "Update");
                return RedirectToAction("Edit", "Prison");
            }
            else
            {
                return View(customer);
            }
        }
        ///Delete
        public IActionResult Delete(int code)
        {

            return View(GetCustomers(code).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult Delete(prisontable customer)
        {
            if (ModelState.IsValid)
            {
                AddUpdateDeleteCustomer(customer, "Delete");
                return RedirectToAction("Index", "Prison");
            }
            else
            {
                return View(customer);
            }
        }
        //
        ///DataTable
        public DataTable GetEmploiyeeSalaryInfo()
        {
            var dt = new DataTable();
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("select * from tblMainZ where code=3048", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            return dt;
        }
        ///
        public IActionResult EmployeeSalaryInfo()
        {
            var dt = new DataTable();
            dt = GetEmploiyeeSalaryInfo();
            string mimeType = "";
            int extension = 1;
            var path = $"{_webHostEnv.WebRootPath}\\Reports\\Report1.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("prm1", "RDLC Report");
            parameters.Add("prm2", DateTime.Now.ToString("dd-MM-yyyy"));
            parameters.Add("prm3", "Employ Salary Report");
            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("dsEmployeeSalary", dt);
            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);
            return File(res.MainStream, "application/pdf");
        }


        //
    }
}
