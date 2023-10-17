using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOMAAPP.Models
{
    public class prisontable
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string office { get; set; }
        public string employer { get; set; }
        public string NameZ { get; set; }
        public string gender { get; set; }
        public string MotherName { get; set; }
        public string Miratgr { get; set; }
        public string paywandi { get; set; }
        public string city { get; set; }
        public string place { get; set; }
        public string BerwarGiran { get; set; }
        public string BerwarAzad { get; set; }
        public int roj { get; set; }
        public int mang { get; set; }
        public int sal { get; set; }
        public string joriZendani { get; set; }
        public int code { get; set; }
        public string mobile { get; set; }
        public string DOBZ { get; set; }
        public string DOBM { get; set; }
        public int mnha { get; set; }
        public string bank { get; set; }
        public bool education { get; set; }
        public bool zawi { get; set; }
        public bool house { get; set; }
        public bool health { get; set; }
        public bool married { get; set; }
        public string note { get; set; }
        public byte[] pic { get; set; }
        public string wajba { get; set; }
        public string kartMeli { get; set; }
        public string jnsya { get; set; }
        public string nfus { get; set; }
        public string datenfus { get; set; }
        public string placenfus { get; set; }
        public string sjl { get; set; }
        public string sahifa { get; set; }
        public string job1 { get; set; }
        public string job2 { get; set; }
        public string bio { get; set; }
        public bool issalary { get; set; }
        public int much { get; set; }
        public bool isminha { get; set; }
        public string placesalary { get; set; }
        public string bio2 { get; set; }
        public string nation { get; set; }
        public string DOBplace { get; set; }
        public string f1 { get; set; }
        public string f2 { get; set; }
        public string f3 { get; set; }
        public string upn { get; set; }
        public string w1 { get; set; }
        public string w2 { get; set; }
        public string w3 { get; set; }
        public string IDw { get; set; }
        public string GenderW { get; set; }
        public string f4 { get; set; }
        public string m2 { get; set; }
        public string m3 { get; set; }
        public string FreeHokar { get; set; }
        public string PlaceZ { get; set; }
    }
}
