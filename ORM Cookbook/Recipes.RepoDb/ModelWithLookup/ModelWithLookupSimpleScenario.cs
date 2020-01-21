﻿using Recipes.ModelWithLookup;
using Recipes.RepoDb.Models;
using RepoDb;
using RepoDb.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Recipes.RepoDb.ModelWithLookup
{
    public class ModelWithLookupSimpleScenario : DbRepository<SqlConnection>,
        IModelWithLookupSimpleScenario<EmployeeSimple>
    {
        public ModelWithLookupSimpleScenario(string connectionString)
            : base(connectionString)
        { }

        public int Create(EmployeeSimple employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee), $"{nameof(employee)} is null.");

            return Insert<EmployeeSimple, int>(employee);
        }

        public void Delete(EmployeeSimple employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee), $"{nameof(employee)} is null.");

            base.Delete(employee);
        }

        public void DeleteByKey(int employeeKey)
        {
            Delete<EmployeeSimple>(employeeKey);
        }

        public IList<EmployeeSimple> FindByLastName(string lastName)
        {
            return Query<EmployeeSimple>(e => e.LastName == lastName).AsList();
        }

        public IList<EmployeeSimple> GetAll()
        {
            return QueryAll<EmployeeSimple>().AsList();
        }

        public EmployeeSimple? GetByKey(int employeeKey)
        {
            return Query<EmployeeSimple>(employeeKey).FirstOrDefault();
        }

        public IEmployeeClassification? GetClassification(int employeeClassificationKey)
        {
            return Query<EmployeeClassification>(employeeClassificationKey).FirstOrDefault();
        }

        public void Update(EmployeeSimple employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee), $"{nameof(employee)} is null.");

            base.Update(employee);
        }
    }
}
