using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TF2FPR.model
{
    public class UserModel
    {
        [PrimaryKey, AutoIncrement]
        public int User_Id { get; set; }
        [MaxLength(50)]
        public string NombreApellido { get; set; }

        public string Usuario { get; set; }
        public string Contraseña { get; set; }
    
    }
}