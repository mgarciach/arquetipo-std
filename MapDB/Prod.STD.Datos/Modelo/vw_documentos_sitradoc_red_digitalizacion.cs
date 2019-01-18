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
    
    [Table("vw_documentos_sitradoc_red_digitalizacion", Schema = "web_tramite")]
    
    public partial class vw_documentos_sitradoc_red_digitalizacion
    {
    	[Key()]	
    	public int id_documento { get; set; }
    	public Nullable<int> id_anexo { get; set; }
    	public int tipo_registro { get; set; }
    	public string numero_tramite { get; set; }
    	public string razon_social { get; set; }
    	public string asunto { get; set; }
    	public Nullable<int> folios { get; set; }
    	public Nullable<int> coddep { get; set; }
    	public System.DateTime fecha_registro { get; set; }
    	public string fecha_registro_v { get; set; }
    	public string usuario { get; set; }
    	public string estado_documento { get; set; }
    	public string ruta { get; set; }
    	public string pdf { get; set; }
    	public string audit_recibido_str { get; set; }
    	public string dat_documento_digitalizado { get; set; }
    	public Nullable<int> numero_reporte { get; set; }
    }
}
