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
    
    public partial class AccountGroupAccountLink
    {
        public System.Guid AccountGroupAccountLinkID { get; set; }
        public System.Guid GroupAccountID { get; set; }
        public System.Guid GroupAccountRoleID { get; set; }
        public System.Guid AccountID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual GroupAccount GroupAccount { get; set; }
        public virtual GroupAccountRole GroupAccountRole { get; set; }
    }
}
