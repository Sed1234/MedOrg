using System;
using System.Collections.Generic;
using System.Text;
using LiteDB;
using MedOrganization.DAL.Model;

namespace MedOrganization.DAL
{
    public class AddToDB
    {
        public static void CreateRequest(RequestToAdd request)
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
                var requests = db.GetCollection<RequestToAdd>("RequestToAdd");
                requests.Insert(request);
            }
        }

        public static IEnumerable<RequestToAdd> ReturnAllRequests()
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
               return db.GetCollection<RequestToAdd>("RequestToAdd").FindAll();      
            }
        }

        public static void UpdateRequest(RequestToAdd request)
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
                var requests = db.GetCollection<RequestToAdd>("RequestToAdd");
                requests.Update(request);
            }

        }

        public static void CreateUser(User user)
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
                var users = db.GetCollection<User>("Users");
                users.Insert(user);
            }
        }

        public static IEnumerable<User> ReturnAllUsers()
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
                return db.GetCollection<User>("Users").FindAll();
            }
        }

        public static void UpdateUser(User user)
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
                var users = db.GetCollection<User>("Users");
                users.Update(user);
            }

        }


        public static void CreatePatient(Patient patient)
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
                var patients = db.GetCollection<Patient>("Patients");
                patients.Insert(patient);
            }
        }

        public static IEnumerable<Patient> ReturnAllPatient()
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
                return db.GetCollection<Patient>("Patients").FindAll();
            }
        }

        public static void UpdatePatient(Patient patient)
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
                var patients = db.GetCollection<Patient>("Patients");
                patients.Update(patient);
            }

        }

        public static void CreateOrganization(Organization organization)
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
                var organizations = db.GetCollection<Organization>("Organizations");
                organizations.Insert(organization);
            }
        }

        public static IEnumerable<Organization> ReturnAllOrganizations()
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
                return db.GetCollection<Organization>("Organizations").FindAll();
            }
        }

        public static void UpdateOrganization(Organization organization)
        {
            using (var db = new LiteDatabase(@"MedOrganization.db"))
            {
                var organizations = db.GetCollection<Organization>("Organizations");
                organizations.Update(organization);
            }

        }

    }
}
