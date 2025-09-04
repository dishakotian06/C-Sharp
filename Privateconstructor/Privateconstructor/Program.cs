namespace Privateconstructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Student s1 = Student.GetInstance(); // Only one object can be created
            }

        }
    }
}
