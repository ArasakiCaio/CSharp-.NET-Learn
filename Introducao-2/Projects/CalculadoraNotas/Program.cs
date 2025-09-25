using System;

int examAssignments = 5;

int[] sophiaNotes = [90, 86, 87, 98, 100, 94, 90];
int[] andrewNotes = [92, 89, 81, 96, 90, 89];
int[] emmaNotes =   [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganNotes =  [90, 95, 87, 88, 96, 96];

int[] studentNotes = new int[10];

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

string currentStudent;

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    currentStudent = name;

    if (currentStudent == "Sophia")
    {
        studentNotes = sophiaNotes;
    }
    else if (currentStudent == "Andrew")
    {
        studentNotes = andrewNotes;
    }
    else if (currentStudent == "Emma")
    {
        studentNotes = emmaNotes;
    }
    else if (currentStudent == "Logan")
    {
        studentNotes = loganNotes;
    }

    int sum = 0;
    decimal score = 0;
    int currentAssignments = 0;

    foreach (int note in studentNotes)
    {
        if (currentAssignments >= examAssignments)
        {
            sum += note / 10;
        }
        else
        {
            sum += note;
        }
        
        currentAssignments += 1;
    }
    score = (decimal)sum / examAssignments;

    string currentStudentLetterGrade = "";

    if (score >= 97)
        currentStudentLetterGrade = "A+";

    else if (score >= 93)
        currentStudentLetterGrade = "A";

    else if (score >= 90)
        currentStudentLetterGrade = "A-";

    else if (score >= 87)
        currentStudentLetterGrade = "B+";

    else if (score >= 83)
        currentStudentLetterGrade = "B";

    else if (score >= 80)
        currentStudentLetterGrade = "B-";

    else if (score >= 77)
        currentStudentLetterGrade = "C+";

    else if (score >= 73)
        currentStudentLetterGrade = "C";

    else if (score >= 70)
        currentStudentLetterGrade = "C-";

    else if (score >= 67)
        currentStudentLetterGrade = "D+";

    else if (score >= 63)
        currentStudentLetterGrade = "D";

    else if (score >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}:\t\t{score}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();