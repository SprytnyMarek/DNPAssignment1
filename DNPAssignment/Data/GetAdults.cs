using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace DNPAssignment.Data
{
    public class GetAdults : InterfaceGetAdults
    {
        private string peopleFile = "adults.json";
        private IList<Person> _adults;

        public GetAdults()
        {
            if (!File.Exists(peopleFile))
            {
                WritePeopleToFile();
            }
            else
            {
                string content = File.ReadAllText(peopleFile);
                _adults = JsonSerializer.Deserialize<List<Person>>(content);
            }
        }

        private void WritePeopleToFile()
        {
            string productAsJson = JsonSerializer.Serialize(_adults);
            File.WriteAllText(peopleFile, productAsJson);
        }

        public List<Person> GetAllAdults()
        {
            List<Person> tmp = new List<Person>(_adults);
            return tmp;
        }

        public void AddAdult(Person person)
        {
            int max = _adults.Max(adult => adult.Id);
            person.Id = max++;
            _adults.Add(person);
            WritePeopleToFile();
        }



        public void RemovePerson(int adultId)
        {
            Person toRemove = _adults.First(t => t.Id == adultId);
            _adults.Remove(toRemove);
            WritePeopleToFile();
        }


    }
}