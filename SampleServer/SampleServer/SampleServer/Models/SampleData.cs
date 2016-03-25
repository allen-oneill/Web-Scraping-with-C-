using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleServer.Models
{
    public class SampleData
    {
        public List<Country> Countries;
        public List<PersonData> People;
        public int SelectedID;
        public int SelectedCountryID;
        public string SelectedName;

        public SampleData()
        {
            Countries = new List<Country>();
            People = new List<PersonData>();

            Countries.Add(new Country ( 1, "United Kingdom" ));
            Countries.Add(new Country ( 2, "United States" ));
            Countries.Add(new Country(3, "Republic of Ireland"));
            Countries.Add(new Country(4, "India"));
            Countries.Add(new Country(5, "France"));
            Countries.Add(new Country(6, "Canada"));

            People.Add(new PersonData(1, 1,"AJSON"));
            People.Add(new PersonData(2, 2, "Fred"));
            People.Add(new PersonData(3, 2, "Mary"));
            People.Add(new PersonData(4, 3, "Mahabir"));
            People.Add(new PersonData(5, 4, "Rajeet"));
            People.Add(new PersonData(6, 5, "Philippe"));
            People.Add(new PersonData(7, 6, "Anna"));
            People.Add(new PersonData(8, 5, "Paulette"));
            People.Add(new PersonData(9, 6, "Jean"));
            People.Add(new PersonData(10, 2, "Zakary"));
            People.Add(new PersonData(11, 1, "Edmund"));
            People.Add(new PersonData(12, 1, "Oliver"));
            People.Add(new PersonData(13, 4, "Sigfreid"));
        }

        public void SetSelected(int ID)
        {
            PersonData PD = People.Where(s => s.ID == ID).First();
            SelectedID = PD.ID;
            SelectedName = PD.PersonName;
            SelectedCountryID = PD.Nationality;
        }

    }



    public class PersonData
    {
        public int ID { get; set; }
        public string PersonName { get; set; }
        public int Nationality { get; set; }

        public PersonData(int id, int nationality, string Name)
        {
            ID = id;
            PersonName = Name;
            Nationality = nationality;
        }
    }

    public class Country
    {
        public int ID { get; set; }
        public string CountryName { get; set; }

        public Country(int id, string Name)
        {
            ID = id;
            CountryName = Name;
        }
    }


}