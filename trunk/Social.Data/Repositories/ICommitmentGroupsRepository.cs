﻿using Social.Data.DatabaseContext;
using Social.Data.Repositories.Base;
using System;
namespace Social.Data.Repositories
{
    public interface ICommitmentGroupsRepository : IBaseRepository<CommitmentGroup, SDBOAppContext> 
    {
        void TestMethod();
    }
}
