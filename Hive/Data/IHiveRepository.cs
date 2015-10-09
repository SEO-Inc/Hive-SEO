using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hive.Data
{
    public interface IHiveRepository
    {
        IQueryable<Domain> GetDomains();

        bool Save();

        int AddDomain(string newDomain);

        IQueryable<Account> GetAccounts();

        bool AddAccount(Account newAccount);

        IQueryable<Contact> GetContacts();

        bool AddContact(Contact newContact);

        IList<Country> GetCountries();

        bool AddCountry(Country newCountry);

        IList<State> GetStatesByCountryId(int countryId);

        IQueryable<Service> GetServices();

        IQueryable<Project> GetProjects();

        bool AddProject(Project newProject);

        bool AddContract(Contract newContract);

        IQueryable<Contract> GetContracts();

        IList<Project> GetProjectsByAccountId(int accountId);

    }
}
