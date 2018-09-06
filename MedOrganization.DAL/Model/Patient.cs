using System;
using System.Collections.Generic;
using System.Text;

namespace MedOrganization.DAL.Model
{
    public class Patient : IUser
    {
        public Patient()
        {
                
        }
        public Patient(DateTime DoB)
        {
            this.DoB = DoB;
        }
        public Patient(string IIN)
        {
            this.IIN = IIN;
        }
        public Patient(string FName, string Sname):this(FName,Sname, ""){}
        public Patient(string FName, string Sname, string MName) 
        {
            this.FName = FName;
            this.Sname = Sname;
            this.MName = MName;
        }

        public int PatientId { get; set; }
        public string IIN { get; set; }
        public string FName { get; set; }
        public string Sname { get; set; }
        public string MName { get; set; }
        public DateTime DoB { get; set; }
        public Organization Organization { get; set; }
    }
}
