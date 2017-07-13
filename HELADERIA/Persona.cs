using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HELADERIA
{
    class Persona
    {
        public int Id_Persona{ get; set; }
        public string Name { get; set; }
        public string P_Lastname { get; set; }
        public string M_Lastname { get; set; }
        public string CI { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public string Sex { get; set; }

        public Persona() { }

        public Persona(int id_Persona, int id_Rol, string name, string p_Lastname, string m_Lastname, string ci, string address, int telephone,
            string sex)
        {
            this.Id_Persona = id_Persona;
            this.Name = name;
            this.P_Lastname = p_Lastname;
            this.M_Lastname = m_Lastname;
            this.CI = ci;
            this.Address = address;
            this.Telephone = telephone;
            this.Sex = sex;
        }
    }
}
