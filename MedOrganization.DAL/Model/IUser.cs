using System;
using System.Collections.Generic;
using System.Text;

namespace MedOrganization.DAL.Model
{
    public interface IUser
    {
        string FName { get; set; }
        string Sname { get; set; }
        string MName { get; set; }
        DateTime DoB { get; set; }
        Organization Organization { get; set; }
    }
}
