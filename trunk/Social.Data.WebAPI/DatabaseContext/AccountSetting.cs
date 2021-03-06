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
    
    public partial class AccountSetting
    {
        public AccountSetting()
        {
            this.AccountAccountSettingsLinks = new HashSet<AccountAccountSettingsLink>();
            this.AccountSettingsAccountSettingsMultichoiceAnswerLinks = new HashSet<AccountSettingsAccountSettingsMultichoiceAnswerLink>();
        }
    
        public System.Guid AccountSettingsID { get; set; }
        public System.Guid AccountSettingsTypeID { get; set; }
        public string Section { get; set; }
        public string Name { get; set; }
        public string DefaultValue { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
    
        public virtual ICollection<AccountAccountSettingsLink> AccountAccountSettingsLinks { get; set; }
        public virtual AccountSettingsType AccountSettingsType { get; set; }
        public virtual ICollection<AccountSettingsAccountSettingsMultichoiceAnswerLink> AccountSettingsAccountSettingsMultichoiceAnswerLinks { get; set; }
    }
}
