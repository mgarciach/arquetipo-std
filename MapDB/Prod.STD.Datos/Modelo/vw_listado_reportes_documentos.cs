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
    
    [Table("vw_listado_reportes_documentos", Schema = "web_tramite")]
    
    public partial class vw_listado_reportes_documentos
    {
    	[Key()]	
    	public int id_reporte { get; set; }
    	public string fecha_registro { get; set; }
    	public string user_registro { get; set; }
    	public string ip_user_registro { get; set; }
    	public string numero_reporte { get; set; }
    	public Nullable<int> numero_reporte_int { get; set; }
    	public int estado { get; set; }
    	public Nullable<int> coddep_entregado { get; set; }
    	public string dep_entregado { get; set; }
    	public string siglas_dep_entregado { get; set; }
    	public Nullable<int> codigo_trabajador_entregado { get; set; }
    	public string trabajador_entregado { get; set; }
    	public Nullable<int> coddep_recibido { get; set; }
    	public string dep_recibido { get; set; }
    	public string siglas_dep_recibido { get; set; }
    	public Nullable<int> codigo_trabajador_recibido { get; set; }
    	public string trabajador_recibido { get; set; }
    	public string fecha_recibido { get; set; }
    	public string hora_recibido { get; set; }
    	public string fecha_audit { get; set; }
    	public string user_audit { get; set; }
    	public string ip_audit { get; set; }
    	public string observacion { get; set; }
    	public string fecha_filtro_ini { get; set; }
    	public string fecha_filtro_fin { get; set; }
    }
}
