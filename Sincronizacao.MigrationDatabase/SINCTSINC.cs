//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SincronizacaoMusical.MigrationDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class SINCTSINC
    {
        public int SINC_CD_CODIGO { get; set; }
        public int UNID_CD_CODIGO { get; set; }
        public int PROD_CD_CODIGO { get; set; }
        public Nullable<System.DateTime> SINC_DT_CRIACAO { get; set; }
        public Nullable<System.DateTime> SINC_DT_GRAVACAO { get; set; }
        public Nullable<System.DateTime> SINC_DT_EXIBICAO { get; set; }
        public Nullable<int> SINC_CD_RESPONSAVEL { get; set; }
        public Nullable<int> SINC_CD_SONOPLASTA { get; set; }
        public int SINC_CD_USUA_CRIACAO { get; set; }
        public string SINC_DS_OBS { get; set; }
        public Nullable<System.DateTime> SINC_DT_AP_SONOPLASTA { get; set; }
        public Nullable<System.DateTime> SINC_DT_AP_RESPONSAVEL { get; set; }
        public Nullable<System.DateTime> SINC_DT_AP_ADMIN { get; set; }
        public Nullable<int> sinc_cd_admin { get; set; }
        public Nullable<int> sinc_cd_tipo_criador { get; set; }
        public Nullable<int> WFNC_CD_CODIGO_SONOPLASTA { get; set; }
        public Nullable<int> WFNC_CD_CODIGO_PRODUCAO { get; set; }
        public Nullable<int> WFNC_CD_CODIGO_ADMINISTRACAO { get; set; }
        public string WFNC_CD_ETAPA_ULTIMA { get; set; }
    }
}
