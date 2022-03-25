﻿using Data.Interfaces.DataConnector;
using Data.Repository;
using Domain.Entities;
using Domain.Interfaces.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class CustomerImplementation : Repository<Customer>, ICustomerImplementation
    {
        public CustomerImplementation(IDbConnector dbConnector) : base(dbConnector)
        {
        }

        protected override string InsertQuery => throw new NotImplementedException();

        protected override string InsertQueryReturnInserted => throw new NotImplementedException();

        protected override string UpdateByIdQuery => throw new NotImplementedException();

        protected override string DeleteByIdQuery => throw new NotImplementedException();

        protected override string SelectByIdQuery => throw new NotImplementedException();

        protected override string SelectAllQuery => "SELECT * FROM Customer";
    }
}