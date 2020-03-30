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
    
    public partial class CuentaA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuentaA()
        {
            this.CreditoCA = new HashSet<CreditoCA>();
            this.DebitoCA = new HashSet<DebitoCA>();
        }
    
        public int numCuenta { get; set; }
        public Nullable<int> idCliente { get; set; }
        public Nullable<int> idMoneda { get; set; }
        public Nullable<bool> estado { get; set; }
        public Nullable<decimal> balanceDisp { get; set; }
        public Nullable<decimal> balanceTotal { get; set; }
        public Nullable<System.DateTime> ultimoCorte { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreditoCA> CreditoCA { get; set; }
        public virtual Monedas Monedas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DebitoCA> DebitoCA { get; set; }
    }
}