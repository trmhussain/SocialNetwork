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
    
    public partial class AccountStatusType
    {
        public AccountStatusType()
        {
            this.AccountMetaDatas = new HashSet<AccountMetaData>();
        }
    
        public System.Guid AccountStatusTypeID { get; set; }
        public string Type { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<AccountMetaData> AccountMetaDatas { get; set; }
    }
}
