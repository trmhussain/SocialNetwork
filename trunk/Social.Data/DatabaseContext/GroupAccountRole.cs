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
    
    public partial class GroupAccountRole
    {
        public GroupAccountRole()
        {
            this.AccountGroupAccountLinks = new HashSet<AccountGroupAccountLink>();
        }
    
        public System.Guid GroupAccountRoleID { get; set; }
        public string Role { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<AccountGroupAccountLink> AccountGroupAccountLinks { get; set; }
    }
}