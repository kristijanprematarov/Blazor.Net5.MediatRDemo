using DemoLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        Task<List<PersonModel>> GetPeople();
        Task<PersonModel> InsertPerson(string firstName, string lastName);
    }
}