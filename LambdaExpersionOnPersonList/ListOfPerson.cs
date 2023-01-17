using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpersionOnPersonList
{
    public class ListOfPerson
    {
        public static void AddingPersonListDetail(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("25468752", "Ankit", "62 Main Market,New Delhi,IN", 24));
            listPersonInCity.Add(new Person("25468753", "Aman", "13 Main Market,Lucknow,IN", 19));
            listPersonInCity.Add(new Person("25468754", "Rishabh", "25 Sarafa Market,New Delhi,IN", 20));
            listPersonInCity.Add(new Person("25468755", "Ritik", "102 South Road,New Delhi,IN", 23));
            listPersonInCity.Add(new Person("25468756", "Bittu", "11 Main Market,Kanpur,IN", 55));
            listPersonInCity.Add(new Person("25468757", "Deeksha", "13 Main Market,Agra,IN", 24));
            listPersonInCity.Add(new Person("25468758", "Honey", "14 Main Market,New Delhi,IN", 30));
            listPersonInCity.Add(new Person("25468759", "Sheetal", "19 Main Market,Mathura,IN", 24));
            DisplayEachPersonDetails(listPersonInCity);
        }
        public static void DisplayEachPersonDetails(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity)
            {
                {
                    Console.WriteLine(person);
                }
            }
        }
        public static void RetrievingTop2OlderPersonAgedOlderThan60(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(s => (s.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine($"Name : {person.Name}        Age : {person.Age}");
            }
        }
        public static void FindingTeenAgers(List<Person> listPersonsInCity)     //between 13 to 19 years
        {
            if (listPersonsInCity.Any(e => (e.Age >= 13 && e.Age <= 19)))
            {
                Console.WriteLine("Yes,we have some teen-agers in the list");
            }
        }
        public static void ChecksWhetherAllAgedGreaterThan10(List<Person> listPersonsInCity)
        {
            if (listPersonsInCity.All(e => (e.Age > 10)))    //checks whether all the people's ages are greater than Ten years or not:
            {
                Console.WriteLine("Yes , all the persons older than 10 years");
            }
        }
        public static void AverageAge(List<Person> listPersonsInCity)   //Average Age
        {
            Console.WriteLine("\nGetting Average of all the person's age...");
            double avgAge = listPersonsInCity.Average(e => e.Age);
            Console.WriteLine("The average of all the person's age is: " + avgAge);
        }
        public static void GivenNameExistsOrNot(List<Person> listPersonsInCity)
        {
            if (listPersonsInCity.Exists(e => (e.Name == "Bittu")))//checks whether a person having the name 'SAM' exists or not:
            {
                Console.WriteLine("Yes, A person having name  'Bittu' exists in our list");
            }
        }
        public static void FindingPositionOfGivenPerson(List<Person> listPersonsInCity) //index position of given name
        {
            Console.WriteLine("\nChecking the index position of a person having name 'Honey' ...");
            int indexForHoney = listPersonsInCity.FindIndex(e => e.Name == "Honey");
            Console.WriteLine("In the list, The index position of a person having name 'Honey' is : " + indexForHoney);
        }
        public static void OldestPersonInList(List<Person> listPersonsInCity)//the oldest person in the list
        {
            Console.WriteLine("\nGetting the name of the most aged person in the list ...");
            Person p = listPersonsInCity.First(m => m.Age == (listPersonsInCity.Max(e => e.Age)));
            Console.WriteLine("The most aged person in our list is: " + p.Name + " whose age is: " + p.Age);
        }
        public static void TotalOfAllPeoplesAge(List<Person> listPersonsInCity) //total of all the peoples ages
        {
            Console.WriteLine("\nGetting Sum of all the person's age...");
            int sumOfAges = listPersonsInCity.Sum(e => e.Age);
            Console.WriteLine("The sum of all the persons's age = " + sumOfAges);
        }
        public static void SkipPersonWhoseAgeIsLessThan60(List<Person> listPersonsInCity)
        {
            Console.WriteLine("\nSkipping every person whose age is less than 60 years...");
            foreach (Person person in listPersonsInCity.SkipWhile(e => e.Age < 60))
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }
        }
        public static void FindPersonWithNameBeginningWithAnyLetterOtherThan_S(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.TakeWhile(e => e.Name.StartsWith("H")))
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }
        }
        public static void ChecksWhetherAllPersonsHaveSSN(List<Person> listPersonsInCity)
        {
            Console.WriteLine("\nChecking all the persons have SSN or not ...");
            if (listPersonsInCity.TrueForAll(e => e.SSN != null))
            {
                Console.WriteLine("No person is found without SSN");
            }
        }
        public static void RemovePerson(List<Person> listPersonsInCity)
        {
            Console.WriteLine("\nRemoving all the persons record from list that have \"Bittu\" name");
            listPersonsInCity.TrueForAll(e => e.Name == "Bittu");
            if (listPersonsInCity.TrueForAll(e => e.Name != "Bittu"))
            {
                Console.WriteLine("No person is found with 'Bittu' name in current list");
            }
        }
        public static void SearchPersonViaSSN(List<Person> listPersonsInCity)
        {
            Console.WriteLine("\nFinding the person whose SSN = 25468753 in the list");
            Person person = listPersonsInCity.Find(e => (e.SSN == "25468753"));
            Console.WriteLine("The person having SSN '25468753' is : " + person.Name + " \t\tAge: " + person.Age);
        }
    }

}
