﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes.PartialUpdate;

namespace Recipes.Ado.PartialUpdate
{
    [TestClass]
    public class PartialUpdateTests : PartialUpdateTests<EmployeeClassification>
    {
        protected override IPartialUpdateScenario<EmployeeClassification> GetScenario()
        {
            return new PartialUpdateScenario(Setup.ConnectionString);
        }
    }
}
