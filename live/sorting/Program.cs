using System;
using System.Globalization;
using LiveCoding;

class Program
{
    static void Main(string[] args)
    {
        int one = 4;
        int two = 345;
        int three = 567;
        int four = 56;

        List<int> integers = new List<int>{
            one,
            two,
            three,
            four
        };
        integers.Sort();
        foreach (var integer in integers){
            Console.WriteLine(integer);
        }
         Console.WriteLine("---------------------------------------------------------\n");

        string thing1 = "blah";
        string thing2 = "stuff";
        string thing3 = "other thing";
        string thing4 = "dave";
        string thing5 = "apple";

        List<string> strings = new List<string>{
            thing1,
            thing2,
            thing3,
            thing4,
            thing5
        };
        strings.Sort();
        foreach (var word in strings){
            Console.WriteLine(word);
        }
         Console.WriteLine("---------------------------------------------------------\n");


        List<Rational> numbers = new List<Rational>{
            new Rational(4,6),
            new Rational(8,4),
            new Rational(2,66),
            new Rational(7,7),
        };
        sortThing sorter = new sortThing();
        
        foreach (var number in numbers){
                numbers.Sort(sorter);
            }






         Console.WriteLine("---------------------------------------------------------\n");
        Complex com3 = new Complex(23,76);
        Complex com1 = new Complex(4,5);
        Complex com2 = new Complex(6,8);
        Complex com4 = new Complex(34,56);

        List<double> com5 = new List<double>{
            com1.Modulus(),
            com2.Modulus(),
            com3.Modulus(),
            com4.Modulus(),
        };
        com5.Sort();
        foreach (var com in com5){
                Console.WriteLine(com);
            }




    
}
}