using System;
using System.Collections.Generic;
using System.Text;
using MedOrganization.DAL.Model;
using MedOrganization.DAL;

namespace MedOrganization
{
    class UserService
    {
        public void AddPatient(Patient patient)
        {
            AddToDB.CreatePatient(patient);
        }
        public void AddUser(User user)
        {
            AddToDB.CreateUser(user);
        }
        public void AddOraganization(Organization organization)
        {
            AddToDB.CreateOrganization(organization);
        }

    }
}
