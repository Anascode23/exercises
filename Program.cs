﻿namespace exercises;

class Program
{
    static void Main(string[] args)
    {

        /*  var likedpost = new List<string>();
         Console.WriteLine("Enter the names of people who liked you post: ");
         var input = Console.ReadLine();

         if (input == "done")
             System.Console.WriteLine("Program stopped...");


         else
         {
             likedpost.Add(input);
             while (input != "")
             {
                 Console.WriteLine("Enter another name:");
                 input = Console.ReadLine();
                 likedpost.Add(input);

             }

             int count = likedpost.Count;

             if (count == 1)
             {
                 Console.WriteLine($"{likedpost[0]} likes your post.");
             }
             else if (count == 2)
             {
                 Console.WriteLine($"{likedpost[0]} and {likedpost[1]} likes your post.");
             }
             else
             {

                 Console.WriteLine($"{likedpost[0]} , {likedpost[1]} and {count - 3} others like your post.");
             }


         } */

        //Exercise #2

        /*   Console.Write("Enter a name to reverse: ");

          var input = Console.ReadLine();

          if(string.IsNullOrEmpty(input)){
              Console.WriteLine("Please try again");
          }
          else{
              char[] reversed = input.ToCharArray();
              Array.Reverse(reversed);
              string reversedName = new(reversed);


              Console.WriteLine(reversedName);
          } */







/*         
        Exercise #3
int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter the {i + 1} number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        var duplicates = false;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    duplicates = true;
                    break;
                }
                if (duplicates)
                    break;
            }
        }
        if (duplicates)
            Console.WriteLine("The number entered has duplicates. Please try again!");

        else
        {
            Array.Sort(numbers);
            foreach (var number in numbers)
                Console.WriteLine(number);
        } */



    }
}
