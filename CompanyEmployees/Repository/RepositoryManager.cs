﻿using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public ICompanyRepository Company
        {
            get 
            {
                if (_repositoryContext == null)
                    _companyRepository = new CompanyRepository(_repositoryContext);
                return _companyRepository;
            } 
        }

        public IEmployeeRepository Employee
        {
            get
            {
                if (_repositoryContext == null)
                    _employeeRepository = new EmployeeRepository(_repositoryContext);
                return _employeeRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}