using System;
using System.Collections.Generic;
using System.Text;
using MedOrganization.DAL.Model;
using System.Linq;
using MedOrganization.DAL;

namespace MedOrganization
{
   public class AdditionlModele
    {

        public AdditionlModele()
        {
            Patients.AddRange(AddToDB.ReturnAllPatient());
            Organizations.AddRange(AddToDB.ReturnAllOrganizations());
        }
        List<Patient> Patients;
        List<Organization> Organizations;

        public List<Patient> Search(string FName, string SName)
        {
            return Patients.Where(x => x.FName == FName && x.Sname == SName).ToList();
        }
        public List<Patient> Search(string IIN)
        {
            return Patients.Where(x => x.IIN == IIN).ToList();
        }

        public bool ChangeAttachmentStatus(RequestToAdd request, Status status)
        {
            request.Status = status;
            try
            {
                if (status == Status.Approved)
                {
                    
                    //Patient p = Patients.FirstOrDefault(x => x.IIN == request.Patient.IIN);
                    //if (p != null)
                       // p.Organization = request.Organization;
                    AddToDB.UpdatePatient(request.Patient);

                    //Organization o = Organizations.FirstOrDefault(x =>
                    //x.Name.Equals(request.Organization.Name));
                    //if (o != null)
                        // o.Patients.Add(request.Patient);
                        AddToDB.UpdateOrganization(request.Organization);

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
