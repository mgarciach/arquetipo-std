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
    
    [Table("CAT_SERVICIO", Schema = "dbo")]
    
    public partial class cat_servicio
    {
    	[Key()]	
    	public int id_servicio { get; set; }
    	public Nullable<int> id_aplicacion { get; set; }
    	public string nombre_servicio { get; set; }
    	public string descripcion_servicio { get; set; }
    	public Nullable<int> orden { get; set; }
    	public Nullable<bool> flag { get; set; }
    	public string enlace { get; set; }
    	public Nullable<int> id_sector { get; set; }
    }
}
