//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Social.Data.WebAPI.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class SDBOVersion
    {
        public long id { get; set; }
        public string repository_path { get; set; }
        public string version { get; set; }
        public Nullable<System.DateTime> entry_date { get; set; }
        public Nullable<System.DateTime> modified_date { get; set; }
        public string entered_by { get; set; }
    }
}
