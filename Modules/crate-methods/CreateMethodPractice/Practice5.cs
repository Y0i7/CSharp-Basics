
public class Practice4
{
    public static Practice4()
    {
        const string deployStudentName = "{0}, ";

        const string showArea = "Area = {0}";

        string[] students = ["Jenna", "Ayesha", "Carlos", "Viktor"];

        DisplayStudents(students);
        PrintCircleArea(12);


        DisplayStudents(["Robert", "Vanya"]);

        static void DisplayStudents(string[] students)
        {
            foreach (string student in students)
                Console.Write(
                    deployStudentName,
                    student
                );

            Console.WriteLine();
        }

        static void PrintCircleArea(int radius)
        {
            const double Pi = 3.14159;

            var area = Pi * (radius * radius);

            Console.WriteLine(
                showArea,
                area);
        }
    }

}