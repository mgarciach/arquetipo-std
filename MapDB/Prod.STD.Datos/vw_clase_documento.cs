//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prod.STD.Servicios.Modelo
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
    using System;
    using System.Collections.Generic;
    
    [Table("VW_CLASE_DOCUMENTO", Schema = "dbo")]
    
    public partial class vw_clase_documento
    {
    	[Key()]	
    	public int id_clase_documento_interno { get; set; }
    	public string descripcion { get; set; }
    	public string procedencia { get; set; }
    	public string categoria { get; set; }
    }
}
