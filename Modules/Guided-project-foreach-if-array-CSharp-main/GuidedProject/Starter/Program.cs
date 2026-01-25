/*
    Este código toma una lista de nombres de estudiantes, lo cuales deben tener
    una lista de notas para evaluar los promedios de examenes/tareas, puntos extra
    y total.

    se pueden agregar nuevos estudiantes y notas, el bucle externo trabajará con los
    nombres para asignarle un arreglo de notas al bucle interno y realizar los 
    respectivos calculos.
*/


const int examAssignments = 5;
const int extraScorePorcentage = 10;

var studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Yoi" };

var sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
var andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
var emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
var loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
var yoiScores = new int[] { 85, 87, 98, 88, 96, 96 };

var studentScores = new int[10];
var currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\tOverall  Grade\t\tExtra Credit\n");
foreach (var name in studentNames)
{
    var currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Yoi")
        studentScores = yoiScores;
    else
        Console.WriteLine("student not foud!");

    var currentStudentGrade = 0m;
    var gradedAssignments = 0;

    var sumExamScores = 0;
    var averageExamScores = 0m;

    var sumExtraCredits = 0m;
    var averageExtraCredits = 0m;

    foreach (int score in studentScores)
    {
        gradedAssignments++;

        if (gradedAssignments <= examAssignments)
            sumExamScores += score;
        else
            sumExtraCredits += (decimal)score / extraScorePorcentage;
    }

    averageExamScores = sumExamScores / (decimal)examAssignments;
    averageExtraCredits = sumExtraCredits / (decimal)examAssignments;

    currentStudentGrade = averageExamScores + averageExtraCredits;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}:\t\t{averageExamScores}\t\t{currentStudentGrade}\t {currentStudentLetterGrade:N2}\t\t{(int)averageExamScores} ({averageExtraCredits:N2} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();