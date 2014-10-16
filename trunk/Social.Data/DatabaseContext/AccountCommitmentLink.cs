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
    
    public partial class AccountCommitmentLink
    {
        public System.Guid AccountCommitmentLinkID { get; set; }
        public System.Guid CommitmentGroupID { get; set; }
        public System.Guid HeadNodeCommitmentID { get; set; }
        public System.Guid GroupAccountID { get; set; }
        public System.Guid AccountID { get; set; }
        public System.Guid CommitmentTypeID { get; set; }
        public System.Guid CommitmentTypeSubTypeID { get; set; }
        public System.Guid AccountCommitmentLinkTypeID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual AccountCommitmentLinkType AccountCommitmentLinkType { get; set; }
        public virtual CommitmentGroup CommitmentGroup { get; set; }
        public virtual CommitmentType CommitmentType { get; set; }
        public virtual CommitmentTypeSubType CommitmentTypeSubType { get; set; }
        public virtual GroupAccount GroupAccount { get; set; }
        public virtual Commitment Commitment { get; set; }
    }
}
