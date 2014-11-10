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
    
    public partial class AccountMetaData
    {
        public System.Guid AccountMetaDataID { get; set; }
        public System.Guid AccountID { get; set; }
        public System.Guid AccountStatusTypeID { get; set; }
        public string ProfileImage { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Headline { get; set; }
        public string LinkedInID { get; set; }
        public bool UserModified { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual AccountStatusType AccountStatusType { get; set; }
    }
}
