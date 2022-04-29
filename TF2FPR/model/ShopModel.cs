using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TF2FPR.model
{

    public class ShopModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id_Producto { get; set; }
        [MaxLength(50)]
        public string NombreP { get; set; }
        public string CantidadP { get; set; }
        public string PrecioP { get; set; }
       
        public string Categoria { get; set; }

        public string EstadoP { get; set; }
        [MaxLength(6)]
        public string DescripcionP { get; set; }


        //  public byte[] MiImagen { get; set; }
    }

}
