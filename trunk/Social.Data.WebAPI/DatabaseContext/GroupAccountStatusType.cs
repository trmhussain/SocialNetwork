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
    
    public partial class GroupAccountStatusType
    {
        public GroupAccountStatusType()
        {
            this.GroupAccountMetaDatas = new HashSet<GroupAccountMetaData>();
        }
    
        public System.Guid GroupAccountStatusTypeID { get; set; }
        public string Type { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    
        public virtual ICollection<GroupAccountMetaData> GroupAccountMetaDatas { get; set; }
    }
}
