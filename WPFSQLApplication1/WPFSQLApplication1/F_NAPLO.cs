//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFSQLApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class F_NAPLO
    {
        public int ID { get; set; }
        public Nullable<int> SZAMID { get; set; }
        public Nullable<int> X_BANKSZID { get; set; }
        public Nullable<int> SZALLAFAID { get; set; }
        public Nullable<int> VEVOAFAID { get; set; }
        public Nullable<int> KPSZALLID { get; set; }
        public Nullable<int> KPVEVOID { get; set; }
        public Nullable<System.DateTime> ERVDATTOL { get; set; }
        public Nullable<System.DateTime> ERVDATIG { get; set; }
        public string MEGN { get; set; }
        public string TARTKOV { get; set; }
        public Nullable<int> afaid { get; set; }
        public Nullable<int> X_BANKSZID2 { get; set; }
        public string CLIPPERKOD { get; set; }
        public Nullable<System.DateTime> zardat { get; set; }
        public string DevizaKonyveles { get; set; }
        public string ArfKulKonyv { get; set; }
        public string BizonylatNyomtat { get; set; }
        public string RegiKod { get; set; }
        public string BruttoKonyveles { get; set; }
        public string AutoBizszam { get; set; }
        public Nullable<System.DateTime> ZardatSave { get; set; }
    
        public virtual F_TUKOR F_TUKOR { get; set; }
    }
}
