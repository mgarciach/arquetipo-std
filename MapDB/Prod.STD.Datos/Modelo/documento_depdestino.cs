//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prod.STD.Datos.Modelo
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
    using System;
    using System.Collections.Generic;
    
    [Table("DOCUMENTO_DEPDESTINO", Schema = "usr_std")]
    
    public partial class documento_depdestino
    {
    	public int ID_DOCUMENTO { get; set; }
    	public Nullable<int> CODDEP_DESTINO { get; set; }
    	public Nullable<bool> FLAG { get; set; }
    	[Key()]	
    	public int ID_DOCUMENTO_DEPDESTINO { get; set; }
    
        public virtual documento documento { get; set; }
    }
}