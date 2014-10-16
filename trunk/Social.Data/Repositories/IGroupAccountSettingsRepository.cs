﻿using Social.Data.DatabaseContext;
using Social.Data.Repositories.Base;
using System;
namespace Social.Data.Repositories
{
    interface IGroupAccountSettingsRepository : IBaseRepository<GroupAccountSetting> 
    {
        void TestMethod();
    }
}
