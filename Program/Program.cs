using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedOrganization;
using MedOrganization.DAL;
using MedOrganization.DAL.Model;
using GeneratorName;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreatePatient();
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Add request");
            Console.WriteLine("3. Get All Request");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        User user = new User();
                        Console.WriteLine("Input first name");
                        user.FName = Console.ReadLine();
                        Console.WriteLine("Input second name");
                        user.Sname = Console.ReadLine();
                        Console.WriteLine("Input login");
                        user.Login = Console.ReadLine();
                        Console.WriteLine("Input password");
                        user.Password = Console.ReadLine();
                        AddToDB.CreateUser(user);

                    }
                    break;
                case 2:
                    {
                        RequestToAdd request = new RequestToAdd();
                        Console.WriteLine("Choose patient by ID");
                        request.Patient.PatientId = Convert.ToInt32(Console.ReadLine());
                        AddToDB.CreateRequest(request);
                   
                    }
                    break;
                case 3:
                    {
                        foreach(var request in AddToDB.ReturnAllRequests())
                            {

                            Console.WriteLine($"{request.Patient.FName} {request.Patient.MName} {request.Organization.Name} {request.Status.ToString()}");
                        }
                    }
                    break;
            }
        }

        static void CreatePatient()
        {
            Random randon = new Random();
            Generator generator = new Generator();
            for (int i = 0; i < randon.Next(1, 10); i++)
            {
                Patient patient = new Patient();
                //Generator generator = new Generator();
                string name = generator.GenerateDefault(Gender.man);
                name = name.Replace("<center><b><font size=7>", "").
                        Replace("</font></b></center>", "").
                        Replace("\n", "");
                string[] str = name.Split(' ');
                patient.FName = str[0];
                patient.MName = str[1];
                patient.DoB = DateTime.Now.AddYears((randon.Next(20, 90) * -1));
                AddToDB.CreatePatient(patient);
            }

        }
    }
}
