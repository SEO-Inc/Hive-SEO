using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hive.Data
{
    public class HiveRepository : IHiveRepository
    {
        HiveContext _ctx;
        public HiveRepository(HiveContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Domain> GetDomains()
        {
            return _ctx.Domains;
        }

        public bool Save()
        {
            try
            {
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                //TODO log this error
                return false;
            }
        }

        public int GetDomainId(string domainName)
        {
            int domainid = 0;
            try
            {
                var domain = _ctx.Domains.First(d => d.Name == domainName);
                if (domain != null)
                    return domain.Id;
                else
                    return domainid;
            }
            catch (Exception ex)
            {
                return domainid;
            }
        }

        public int AddDomain(string newDomain)
        {
            int domainid = 0;
            try
            {
                domainid = GetDomainId(newDomain);
                if (domainid == 0)
                {
                    var domain = new Domain();
                    domain.Name = newDomain;
                    _ctx.Domains.Add(domain);
                    _ctx.SaveChanges();
                    domainid = GetDomainId(newDomain);
                }
                return domainid;
            }
            catch (Exception ex)
            {
                return domainid;
            }
        }

        public bool AddContact(Contact newContact)
        {
            try
            {
                _ctx.Contacts.Add(newContact);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IQueryable<Contact> GetContacts()
        {
            return _ctx.Contacts.Include("Country").Include("Domain");
        }

        public bool AddAccount(Account newAccount)
        {
            try
            {
                _ctx.Accounts.Add(newAccount);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IQueryable<Account> GetAccounts()
        {
            return _ctx.Accounts.Include("Domain");
        }

        public IList<Country> GetCountries()
        {
            var query = from countries in _ctx.Countries
                        where countries.Active.Equals(true)
                        select countries;
            var content = query.ToList<Country>();
            return content;   
        }

        public bool AddCountry(Country newCountry)
        {
            try
            {
                _ctx.Countries.Add(newCountry);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IList<State> GetStatesByCountryId(int countryId)
        {
            var query = from states in _ctx.States
                        where states.CountryId == countryId
                        select states;
            var content = query.ToList<State>();
            return content;
        }

        public IQueryable<Service> GetServices()
        {
            return _ctx.Services.Include("ServiceCategory"); ;
        }

        public IQueryable<Project> GetProjects()
        {
            return _ctx.Projects.Include("Account").Include("Domain").Include("ProjectStatus");
        }

        public bool AddProject(Project newProject)
        {
            try
            {
                _ctx.Projects.Add(newProject);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddContract(Contract newContract)
        {
            try
            {
                _ctx.Contracts.Add(newContract);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IQueryable<Contract> GetContracts()
        {
            return _ctx.Contracts.Include("Account");
        }

        public IList<Project> GetProjectsByAccountId(int accountId)
        {
            var query = from projects in _ctx.Projects
                        where projects.AccountId == accountId
                        select projects;
            var content = query.ToList<Project>();
            return content;
        }

    }
}