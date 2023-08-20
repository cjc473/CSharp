// See https://aka.ms/new-console-template for more information


using System;

namespace CSharpFundamentals
{
    class Program
    {
        //public static bool Coprime(int a, int b)
        //{
        //    for (int i = 2; i < Math.Min(a, b); i++)
        //    {
        //        if (a % i == 0 && b % i == 0)
        //            return false;
        //    }

        //    return true;
        //}

        //public static bool Coprime(int a, int b)
        //{
        //    int min = Math.Min(a, b);
        //    return Enumerable.Range(2, min - 1).All(factor => !(a % factor == 0 && b % factor == 0));
        //}

        //public class Person
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //}


        static void Main(string[] args)
        {

            //Console.WriteLine(Coprime(25, 12));
            //Console.WriteLine(Coprime(7, 11));
            //Console.WriteLine(Coprime(30, 9));
            //Console.WriteLine(Coprime(6, 24));

            //    var people1 = new List<Person>
            //    {
            //    new Person { Name = "Jack", Age = 17 },
            //    new Person { Name = "Jill", Age = 21 },
            //    new Person { Name = "Alice", Age = 15 },
            //    new Person { Name = "Bob", Age = 16 }
            //};
            //    Console.WriteLine(AdultInGroup(people1));    // => True

            //    var people2 = new List<Person>
            //    {
            //    new Person { Name = "Jane", Age = 12 },
            //    new Person { Name = "John", Age = 13 },
            //    new Person { Name = "Ashley", Age = 10 },
            //    new Person { Name = "Bill", Age = 16 }
            //};
            //    Console.WriteLine(AdultInGroup(people2));    // => False

            //Console.WriteLine(OnlyVowels("aaoeee"));  // => True
            //Console.WriteLine(OnlyVowels("iou"));     // => True
            //Console.WriteLine(OnlyVowels("cat"));     // => False
            //Console.WriteLine(OnlyVowels("over"));    // => False

            //Console.WriteLine(string.Join(", ", FilterLengths(new List<string> { "pear", "dragonfruit", "fig", "clementine" }, 4)));   // => pear, dragonfruit, clementine
            //Console.WriteLine(string.Join(", ", FilterLengths(new List<string> { "pear", "dragonfruit", "fig", "clementine" })));      // => dragonfruit, clementine
            //Console.WriteLine(string.Join(", ", FilterLengths(new List<string> { "cat", "dog", "capybara", "mouse" }, 7)));            // => capybara
            //Console.WriteLine(string.Join(", ", FilterLengths(new List<string> { "cat", "dog", "capybara", "mouse" })));

            //Console.WriteLine(MaxInject(1, -4, 0, 7, 5));  // => 7
            //Console.WriteLine(MaxInject(30, 28, 18));      // => 30

            //Console.WriteLine(string.Join(", ", Union(new object[] { "a", "b" }, new object[] { 1, 2, 3 }))); // => a, b, 1, 2, 3
            //Console.WriteLine(string.Join(", ", Union(new object[] { "x", "y" }, new object[] { true, false }, new object[] { 20, 21, 23 }))); // => x, y, True, False, 20, 21, 23

            object[] arr1 =
                {
                    new int[] {4, 3, 1},
                    new int[] {8, 1},
                    2
                };

            Console.WriteLine(MultiDimensionalSum(arr1));    // Outputs: 19

            object[] arr2 =
            {
                new object[] { new int[] {3, 6}, new int[] {7} },
                new object[] { new int[] {5, 2}, 1 }
            };

            Console.WriteLine(MultiDimensionalSum(arr2));    // Outputs: 24

        }

        public static int MultiDimensionalSum(object[] array)
        {
            int sum = 0;

            foreach (var element in array)
            {
                if (element is int integerElement)
                {
                    sum += integerElement;
                }
                else if (element is object[] arrayElement)
                {
                    Console.WriteLine("value of recursion");
                    int res = MultiDimensionalSum(arrayElement);
                    Console.WriteLine(res);
                    sum += MultiDimensionalSum(arrayElement);
                }
            }

            return sum;
        }





        //public static object[] Union(params object[][] objects)
        //{
        //    return objects.SelectMany(arr => arr).ToArray();
        //}

        //public static int MaxInject(params int[] numbers)
        //{
        //    return numbers.Max();
        //}

        //public static List<string> FilterLengths(List<string> names, int len = 5)
        //{
        //    return names.Where(name => name.Length >= len).ToList();
        //}

        //public static bool OnlyVowels(string str)
        //{
        //    string vowels = "aeiou";
        //    return str.All(letter => vowels.Contains(letter));
        //}

        //public static bool AdultInGroup(List<Person> people)
        //{
        //    return people.Any(person => person.Age > 17);
        //}
    }
}


//testing git