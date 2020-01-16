﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes.EntityFrameworkCore.Entities;
using Recipes.Immutable;
using System;

namespace Recipes.EntityFrameworkCore.Immutable
{
    [TestClass]
    public class ImmutableTests : ImmutableTests<ReadOnlyEmployeeClassification>
    {
        protected override IImmutableScenario<ReadOnlyEmployeeClassification> GetScenario()
        {
            return new ImmutableScenario(Setup.DBContextFactory);
        }

        protected override ReadOnlyEmployeeClassification CreateWithValues(string name, bool isExempt, bool isEmployee)
        {
            return new ReadOnlyEmployeeClassification(0, name, isExempt, isEmployee);
        }

        protected override ReadOnlyEmployeeClassification UpdateWithValues(ReadOnlyEmployeeClassification original, string name, bool isExempt, bool isEmployee)
        {
            if (original == null)
                throw new ArgumentNullException(nameof(original), $"{nameof(original)} is null.");

            return new ReadOnlyEmployeeClassification(original.EmployeeClassificationKey, name, isExempt, isEmployee);
        }
    }
}
