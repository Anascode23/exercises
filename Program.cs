namespace exercises;

class Program
{
    static void Main(string[] args)
    {

        var likedpost = new List<string>();
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


        }



    }
}
