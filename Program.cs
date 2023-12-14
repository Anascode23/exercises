namespace exercises;

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


        //Exercise #4
        /* var numbers = new List<int>();
        Console.WriteLine("Enter a number or type 'done' to stop the program");
        while (true)
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();

            if (input is "done")
            {
                break;
            }
            if (int.TryParse(input, out int currentnumber))
            {
                var duplicates = false;

                foreach (var number in numbers)
                {
                    if (currentnumber == number)
                    {
                        duplicates = true;
                        break;
                    }
                }
                if (duplicates)
                {       
                    numbers.Remove(currentnumber);
                }
                else
                {
                    numbers.Add(currentnumber);
                }


            }
            else
                Console.WriteLine("Invaild input");


        }
         foreach (var number in numbers)
            Console.WriteLine(number); 


 */
        /*      //Exercise #4 (Loops)
                Console.WriteLine("Enter five numbers separated numbers (e.g 5, 1, 9, 2, 10)");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invaild list");
                } 

                Console.WriteLine(input); */

        /*  var random = new Random();
         Console.WriteLine("Guess a number between 1 and 10 (You have four chances!)");
         var input = Convert.ToInt32(Console.ReadLine());
         var guess = random.Next(1, 10);

         for (int i = 4; i > 1; i--)
         {
             Console.Write($"You have {i - 1} tries left: ");
             Console.ReadLine();
         } 
             if (input == guess)
             {
                 Console.WriteLine("You won!");

             }
             else
             Console.WriteLine($"You lost the number was: {guess}");
       */



         /* 
                //Exercise #5 (Loops)
                Console.WriteLine("enter how many numbers you want to enter: ");
                var input = Convert.ToInt32(Console.ReadLine());
                var max = 0;

                for (int i = 0; i < input; i++)
                {
                   Console.Write("Enter a number: ");
                    var num = Convert.ToInt32(Console.ReadLine());
                    if (num > max)
                    {
                        max = num;
                    }
                }
                Console.WriteLine(max);  */


        /*      Exercise #4 (conditions)  
         Console.Write("Enter the speed of the lane: ");
          var lane = Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter the speed of the car: ");
          var car = Convert.ToInt32(Console.ReadLine());

          if (lane > car)
          {
              Console.WriteLine("Ok");
          }
          if (lane < car)
          {
              var dermitpoint = (car - lane) / 5;
              if (dermitpoint > 12)
              {
                  Console.WriteLine("License Suspended");
              }
              else
                  Console.WriteLine("dermitpoint: " + dermitpoint);
          } */
    }
}
