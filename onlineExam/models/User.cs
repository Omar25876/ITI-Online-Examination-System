using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineExam.models
{
    public class User
    {
        string role;
        int userId;
        string firstName;
        string lastName;
        public User(String role,int userid,string firstName,string lastName)
        {
            this.role = role;
            this.userId = userid;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public String Role {set{ role = value; } get { return role; } }

        public int UserId { set { userId = value; } get { return userId; } }

        public String FirstName { set { firstName = value; } get { return firstName; } }

        public String LastName { set { lastName = value; } get { return lastName; } }
    }
}
