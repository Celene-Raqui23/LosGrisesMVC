//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LosGrisesServices
{
    using System;
    
    public partial class usp_ConsultarAutor_Result
    {
        public int aut_id { get; set; }
        public string aut_nom { get; set; }
        public string aut_ape { get; set; }
        public byte[] aut_foto { get; set; }
        public string aut_pais { get; set; }
        public string aut_user_reg { get; set; }
        public System.DateTime aut_fec_reg { get; set; }
        public string aut_user_mod { get; set; }
        public Nullable<System.DateTime> aut_fec_mod { get; set; }
        public bool aut_state { get; set; }
    }
}
