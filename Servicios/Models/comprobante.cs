//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class comprobante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public comprobante()
        {
            this.detalleFactura = new HashSet<detalleFactura>();
            this.movimientoCaja = new HashSet<movimientoCaja>();
            this.movimientoStock = new HashSet<movimientoStock>();
        }
    
        public int ComprobanteId { get; set; }
        public string codigo { get; set; }
        public double importe { get; set; }
        public double bonificacion { get; set; }
        public System.DateTime fechaAlta { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public int PersonaJuridicaId { get; set; }
        public int TipoComprobanteId { get; set; }
        public int SucursalId { get; set; }
        public double efectivo { get; set; }
        public double tarjeta { get; set; }
        public string UserName { get; set; }
        public Nullable<double> Tarjeta1 { get; set; }
        public Nullable<double> Tarjeta2 { get; set; }
        public Nullable<double> TarjDebito { get; set; }
        public Nullable<double> Transferencia { get; set; }
        public Nullable<double> GedNet { get; set; }
        public Nullable<double> Mercadopago { get; set; }
    
        public virtual personaJuridica personaJuridica { get; set; }
        public virtual sucursal sucursal { get; set; }
        public virtual tipoComprobante tipoComprobante { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detalleFactura> detalleFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movimientoCaja> movimientoCaja { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movimientoStock> movimientoStock { get; set; }
    }
}