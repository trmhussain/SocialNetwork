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
    
    public partial class AccountSettingsMultichoiceAnswer
    {
        public AccountSettingsMultichoiceAnswer()
        {
            this.AccountSettingsAccountSettingsMultichoiceAnswerLinks = new HashSet<AccountSettingsAccountSettingsMultichoiceAnswerLink>();
        }
    
        public System.Guid AccountSettingsMultichoiceAnswerID { get; set; }
        public string Answer { get; set; }
        public string Helptext { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    
        public virtual ICollection<AccountSettingsAccountSettingsMultichoiceAnswerLink> AccountSettingsAccountSettingsMultichoiceAnswerLinks { get; set; }
    }
}
