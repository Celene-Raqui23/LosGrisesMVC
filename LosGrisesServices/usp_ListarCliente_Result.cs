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
    
    public partial class usp_ListarCliente_Result
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string DNI { get; set; }
        public string Ubigeo { get; set; }
        public string Region { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public Nullable<System.DateTime> Fecha_de_nacimiento { get; set; }
        public string Sexo { get; set; }
        public byte[] Foto { get; set; }
        public string Creado_por { get; set; }
        public Nullable<System.DateTime> Creado_el { get; set; }
        public string Modificado_por { get; set; }
        public Nullable<System.DateTime> Modificado_el { get; set; }
        public Nullable<bool> Estado { get; set; }
    }
}
