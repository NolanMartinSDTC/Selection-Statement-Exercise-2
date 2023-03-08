namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject?");
            string favSubject = (Console.ReadLine().ToLower());

            switch (favSubject)
            {
                case "math":
                    Console.WriteLine("Math is fun!");
                    break;

                case "science":
                    Console.WriteLine("Science is cool!");
                    break;

                case "art":
                    Console.WriteLine("Art is beautiful!");
                    break;

                case "english":
                    Console.WriteLine("English is great! I'm not good at it though :(");
                    break;

                case "music":
                    Console.WriteLine("I cant play music, but I love to listen!");
                    break;

                default:
                    Console.WriteLine("I'm not familiar with that subject, but it sounds interesting!");
                    break;
            }
        }
    }
}