//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Social.Data.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupAccountGroupAccountSettingsLink
    {
        public System.Guid GroupAccountGroupAccountSettingsLinkID { get; set; }
        public System.Guid GroupAccountID { get; set; }
        public System.Guid GroupAccountSettingsID { get; set; }
        public System.Guid GroupAccountSettingsTypeID { get; set; }
        public string Value { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual GroupAccount GroupAccount { get; set; }
        public virtual GroupAccountSetting GroupAccountSetting { get; set; }
        public virtual GroupAccountSettingsType GroupAccountSettingsType { get; set; }
    }
}
