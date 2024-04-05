using System;
using System.Collections.Generic;

namespace Milestone
{
  internal class Program
  {
    private static void Main()
    {
      EnumExample();
      ListExample();
      DictionaryExample();
      CustomCollectionExample();
    }

    private static void EnumExample()
    {
      var today = DateTime.Today;
      var currentSeason = GetCurrentSeason(today);

      Console.WriteLine($"Current season is {currentSeason}");
      Console.WriteLine($"In 5 months it will be {GetCurrentSeason(today.AddMonths(5))}");
      Console.WriteLine($"Convert to Season {(Season)42}");

      var date = new Date
      {
        DayOfMonth = 15,
        Season = Season.Spring
      };
    }

    private static void ListExample()
    {
      // "Make a variable called "family" using a List of strings, by creating a new instance of the List Collection, specifying type string"
      var mentors = new List<string>
      {
        "Slavica",
        "Edin",
        "Lazar",
        "Nikola",
        "Goran"
      };

      foreach (var mentor in mentors)
        Console.WriteLine(mentor);

      var numbers = new List<int> { 1, 5, 11, 20, 55 };
      foreach (var num in numbers)
        Console.WriteLine($"{num} * {num} is {num * num}");
    }

    private static void DictionaryExample()
    {
      var myDictionary = new Dictionary<int, string>();

      myDictionary.Add(1, "Slayer");
      myDictionary.Add(2, "Slipknot");
      myDictionary.Add(3, "Megadeth");
      myDictionary.Add(4, "Bleed from Within");
      myDictionary.Add(5, "Parkway drive");
      myDictionary.Add(6, "Dream theater");

      myDictionary.TryGetValue(3, out var band);
      Console.WriteLine(band);
      Console.WriteLine(myDictionary[5]);

      // another way to initialize dictionary
      var myGuitars = new Dictionary<string, int>
      {
        { "Solar", 3 },
        { "ESP LTD", 2 },
        { "Jackson", 4 }
      };
      Console.WriteLine(myGuitars["Solar"]);

      // JS: Object.keys.forEach( key => {} );
      foreach (var theBand in myDictionary)
        Console.WriteLine("Key: {0}, Value: {1}", theBand.Key, theBand.Value);
    }

    private static void CustomCollectionExample()
    {
      var numbers = new CustomCollection<int>();
      numbers.Add(2);
      numbers.Add(4);
      numbers.Add(6);
      numbers.Add(8);
      numbers.Add(10);

      foreach (var number in numbers)
        Console.WriteLine($"The number is {number}");

      var ages = new CustomCollection<int> { 15, 22, 50, 52 };

      foreach (var age in ages)
        Console.WriteLine($"The age is {age}");
    }

    private static Season GetCurrentSeason(DateTime date)
    {
      var month = date.Month;

      return month switch
      {
        >= 3 and <= 5 => Season.Spring,
        >= 6 and <= 8 => Season.Summer,
        >= 9 and <= 11 => Season.Autumn,
        _ => Season.Winter
      };
    }
  }
}
