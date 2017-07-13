using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELADERIA
{
    class Empleado : Persona
    {
        public int Id_Employees { get; set; }
        public string TypeUser { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public Empleado() { }

        public Empleado(int id_Employees, string typeUser, string user, string password) 
        {
            this.Id_Employees = id_Employees;
            this.TypeUser = typeUser;
            this.User = user;
            this.Password = password;
        }
    }
}
