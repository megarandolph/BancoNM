//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BancoNM
{
    using System;
    using System.Collections.Generic;
    
    public partial class PagoPrestamos
    {
        public int idPago { get; set; }
        public Nullable<int> idPrestamo { get; set; }
        public Nullable<int> idCliente { get; set; }
        public Nullable<System.DateTime> fechaPago { get; set; }
        public Nullable<decimal> cuota { get; set; }
        public Nullable<decimal> capital { get; set; }
        public Nullable<decimal> interes { get; set; }
        public Nullable<decimal> balance { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Prestamos Prestamos { get; set; }
    }
}
