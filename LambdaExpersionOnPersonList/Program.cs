using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpersionOnPersonList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            ListOfPerson.AddingPersonListDetail(listPersonsInCity);
            ListOfPerson.RetrievingTop2OlderPersonAgedOlderThan60(listPersonsInCity);
            ListOfPerson.FindingTeenAgers(listPersonsInCity);
            ListOfPerson.ChecksWhetherAllAgedGreaterThan10(listPersonsInCity);
            ListOfPerson.AverageAge(listPersonsInCity);
            ListOfPerson.GivenNameExistsOrNot(listPersonsInCity);
            ListOfPerson.FindingPositionOfGivenPerson(listPersonsInCity);
            ListOfPerson.OldestPersonInList(listPersonsInCity);
            ListOfPerson.TotalOfAllPeoplesAge(listPersonsInCity);
            ListOfPerson.SkipPersonWhoseAgeIsLessThan60(listPersonsInCity);
            ListOfPerson.FindPersonWithNameBeginningWithAnyLetterOtherThan_S(listPersonsInCity);
            ListOfPerson.ChecksWhetherAllPersonsHaveSSN(listPersonsInCity);
            ListOfPerson.RemovePerson(listPersonsInCity);
            ListOfPerson.SearchPersonViaSSN(listPersonsInCity);
        }
    }
}
