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
    
    public partial class CommitmentQuestionnaireLink
    {
        public System.Guid CommitmentQuestionnaireLinkID { get; set; }
        public System.Guid CommitmentQuestionnaireLinkTypeID { get; set; }
        public System.Guid CommitmentGroupID { get; set; }
        public System.Guid CommitmentID { get; set; }
        public System.Guid AccountID { get; set; }
        public System.Guid SendToAccountID { get; set; }
        public System.Guid QuestionnaireID { get; set; }
        public string Name { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Account Account1 { get; set; }
        public virtual Commitment Commitment { get; set; }
        public virtual CommitmentGroup CommitmentGroup { get; set; }
        public virtual CommitmentQuestionnaireLinkType CommitmentQuestionnaireLinkType { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
    }
}
