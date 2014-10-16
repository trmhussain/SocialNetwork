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
    
    public partial class CommitmentGroup
    {
        public CommitmentGroup()
        {
            this.AccountCommitmentLinks = new HashSet<AccountCommitmentLink>();
            this.Commitments = new HashSet<Commitment>();
            this.CommitmentNotes = new HashSet<CommitmentNote>();
            this.CommitmentQuestionnaireLinks = new HashSet<CommitmentQuestionnaireLink>();
            this.QuestionnaireQuestions = new HashSet<QuestionnaireQuestion>();
            this.QuestionnaireQuestionMultichoiceAnswers = new HashSet<QuestionnaireQuestionMultichoiceAnswer>();
            this.QuestionnaireQuestionnaireQuestionLinks = new HashSet<QuestionnaireQuestionnaireQuestionLink>();
            this.QuestionnaireQuestionQuestionnaireQuestionMultichoiceAnswerLinks = new HashSet<QuestionnaireQuestionQuestionnaireQuestionMultichoiceAnswerLink>();
            this.RCAccountTransactions = new HashSet<RCAccountTransaction>();
        }
    
        public System.Guid CommitmentGroupID { get; set; }
        public System.Guid CommitmentGroupStatusTypeID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<AccountCommitmentLink> AccountCommitmentLinks { get; set; }
        public virtual ICollection<Commitment> Commitments { get; set; }
        public virtual CommitmentGroupStatusType CommitmentGroupStatusType { get; set; }
        public virtual ICollection<CommitmentNote> CommitmentNotes { get; set; }
        public virtual ICollection<CommitmentQuestionnaireLink> CommitmentQuestionnaireLinks { get; set; }
        public virtual ICollection<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public virtual ICollection<QuestionnaireQuestionMultichoiceAnswer> QuestionnaireQuestionMultichoiceAnswers { get; set; }
        public virtual ICollection<QuestionnaireQuestionnaireQuestionLink> QuestionnaireQuestionnaireQuestionLinks { get; set; }
        public virtual ICollection<QuestionnaireQuestionQuestionnaireQuestionMultichoiceAnswerLink> QuestionnaireQuestionQuestionnaireQuestionMultichoiceAnswerLinks { get; set; }
        public virtual ICollection<RCAccountTransaction> RCAccountTransactions { get; set; }
    }
}
