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
    
    public partial class CommitmentNoteType
    {
        public CommitmentNoteType()
        {
            this.CommitmentNotes = new HashSet<CommitmentNote>();
        }
    
        public System.Guid CommitmentNoteTypeID { get; set; }
        public string Type { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<CommitmentNote> CommitmentNotes { get; set; }
    }
}