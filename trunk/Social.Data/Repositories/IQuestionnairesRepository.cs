﻿using Social.Data.DatabaseContext;
using Social.Data.Repositories.Base;
using System;
namespace Social.Data.Repositories
{
    interface IQuestionnairesRepository : IBaseRepository<Questionnaire> 
    {
        void TestMethod();
    }
}
