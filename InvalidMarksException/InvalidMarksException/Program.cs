namespace InvalidMarksException
{
     class Program
     {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());
                GradingSystem.CheckMarks(marks);
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
     }
     
}
