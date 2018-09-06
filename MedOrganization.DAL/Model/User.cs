using System;
using System.Collections.Generic;
using System.Text;

namespace MedOrganization.DAL.Model
{
    public enum Role
    {
        Admin, Manager
    }
    public class User : IUser
    {
        public User()
        {

        }
        public User(string Login, string Password, Role role)
        {
            this.Login = Login;
            this.Password = Password;
            this.Role = role;
        }
        public User(string FName, string Sname) : this(FName, Sname, "") { }
        public User(string FName, string Sname, string MName)
        {
            this.FName = FName;
            this.Sname = Sname;
            this.MName = MName;
        }

        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public string FName { get; set; }
        public string Sname { get; set; }
        public string MName { get; set; }
        public DateTime DoB { get; set; }
        public Organization Organization { get; set; }
    }
}
