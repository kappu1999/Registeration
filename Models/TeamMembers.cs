using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registeration.Models
{
    public class TeamMembers
    {
        public int Id { get; set; }
        public string teamtitle { get; set; }
        public string FullName1 { get; set; }
        public string University1 { get; set; }
        public string Phone1 { get; set; }
        public string Email1 { get; set; }
        public DateTime DOB1 { get; set; }
        public string FullName2 { get; set; }
        public string University2 { get; set; }
        public string Phone2 { get; set; }
        public string Email2 { get; set; }
        public DateTime DOB2 { get; set; }

        public string Userfile { get; set; }
        public string Userfile2 { get; set; }

    }
}