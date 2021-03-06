﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SDBOAppContext : DbContext
    {
        public SDBOAppContext()
            : base("name=SDBOAppContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
    		this.Configuration.ProxyCreationEnabled = false; 
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountAccountSettingsLink> AccountAccountSettingsLinks { get; set; }
        public virtual DbSet<AccountCommitmentLink> AccountCommitmentLinks { get; set; }
        public virtual DbSet<AccountCommitmentLinkType> AccountCommitmentLinkTypes { get; set; }
        public virtual DbSet<AccountConfiguration> AccountConfigurations { get; set; }
        public virtual DbSet<AccountGroupAccountLink> AccountGroupAccountLinks { get; set; }
        public virtual DbSet<AccountMetaData> AccountMetaDatas { get; set; }
        public virtual DbSet<AccountRole> AccountRoles { get; set; }
        public virtual DbSet<AccountSetting> AccountSettings { get; set; }
        public virtual DbSet<AccountSettingsAccountSettingsMultichoiceAnswerLink> AccountSettingsAccountSettingsMultichoiceAnswerLinks { get; set; }
        public virtual DbSet<AccountSettingsMultichoiceAnswer> AccountSettingsMultichoiceAnswers { get; set; }
        public virtual DbSet<AccountSettingsType> AccountSettingsTypes { get; set; }
        public virtual DbSet<AccountStatusType> AccountStatusTypes { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Commitment> Commitments { get; set; }
        public virtual DbSet<CommitmentGroup> CommitmentGroups { get; set; }
        public virtual DbSet<CommitmentGroupStatusType> CommitmentGroupStatusTypes { get; set; }
        public virtual DbSet<CommitmentNote> CommitmentNotes { get; set; }
        public virtual DbSet<CommitmentNoteType> CommitmentNoteTypes { get; set; }
        public virtual DbSet<CommitmentQuestionnaireLink> CommitmentQuestionnaireLinks { get; set; }
        public virtual DbSet<CommitmentQuestionnaireLinkType> CommitmentQuestionnaireLinkTypes { get; set; }
        public virtual DbSet<CommitmentStatusType> CommitmentStatusTypes { get; set; }
        public virtual DbSet<CommitmentType> CommitmentTypes { get; set; }
        public virtual DbSet<CommitmentTypeSubType> CommitmentTypeSubTypes { get; set; }
        public virtual DbSet<GroupAccount> GroupAccounts { get; set; }
        public virtual DbSet<GroupAccountConfiguration> GroupAccountConfigurations { get; set; }
        public virtual DbSet<GroupAccountGroupAccountSettingsLink> GroupAccountGroupAccountSettingsLinks { get; set; }
        public virtual DbSet<GroupAccountMetaData> GroupAccountMetaDatas { get; set; }
        public virtual DbSet<GroupAccountRole> GroupAccountRoles { get; set; }
        public virtual DbSet<GroupAccountSetting> GroupAccountSettings { get; set; }
        public virtual DbSet<GroupAccountSettingsType> GroupAccountSettingsTypes { get; set; }
        public virtual DbSet<GroupAccountStatusType> GroupAccountStatusTypes { get; set; }
        public virtual DbSet<GroupAccountType> GroupAccountTypes { get; set; }
        public virtual DbSet<PaymentPlanAccount> PaymentPlanAccounts { get; set; }
        public virtual DbSet<PaymentPlanAccountFee> PaymentPlanAccountFees { get; set; }
        public virtual DbSet<PaymentPlanGroupAccount> PaymentPlanGroupAccounts { get; set; }
        public virtual DbSet<PaymentPlanGroupAccountFee> PaymentPlanGroupAccountFees { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<QuestionnaireQuestion> QuestionnaireQuestions { get; set; }
        public virtual DbSet<QuestionnaireQuestionAnswerType> QuestionnaireQuestionAnswerTypes { get; set; }
        public virtual DbSet<QuestionnaireQuestionMultichoiceAnswer> QuestionnaireQuestionMultichoiceAnswers { get; set; }
        public virtual DbSet<QuestionnaireQuestionnaireQuestionLink> QuestionnaireQuestionnaireQuestionLinks { get; set; }
        public virtual DbSet<QuestionnaireQuestionQuestionnaireQuestionMultichoiceAnswerLink> QuestionnaireQuestionQuestionnaireQuestionMultichoiceAnswerLinks { get; set; }
        public virtual DbSet<QuestionnaireQuestionType> QuestionnaireQuestionTypes { get; set; }
        public virtual DbSet<QuestionnaireType> QuestionnaireTypes { get; set; }
        public virtual DbSet<RCAccountBalance> RCAccountBalances { get; set; }
        public virtual DbSet<RCAccountTransaction> RCAccountTransactions { get; set; }
        public virtual DbSet<SDBOScriptsRun> SDBOScriptsRuns { get; set; }
        public virtual DbSet<SDBOScriptsRunError> SDBOScriptsRunErrors { get; set; }
        public virtual DbSet<SDBOVersion> SDBOVersions { get; set; }
    }
}
