using System;
using System.Collections.Generic;
using System.Text;

namespace MedOrganization.DAL.Model
{
    public class Organization
    {
        public Organization():this("","",""){}

        public Organization(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Patients = new List<Patient>();
        }

        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Patient> Patients;

    }
}
