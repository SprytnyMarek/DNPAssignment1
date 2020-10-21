using System.Collections.Generic;
using Models;

namespace DNPAssignment.Data
{
    public interface InterfaceGetAdults
    {
        List<Person> GetAllAdults();

        void AddAdult(Person adult);
        
        void RemovePerson(int personId);
    }
}