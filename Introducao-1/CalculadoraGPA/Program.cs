string studentName = "Caio Arasaki";

string course1 = "Algoritmos";
string course2 = "Estrutura de Dados";
string course3 = "Cálculo I";
string course4 = "Banco de Dados";
string course5 = "Engenharia de Software";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

Console.WriteLine($"\nStudent Name: {studentName}");
Console.WriteLine("\nCourse\t\t\t\tGrade\tCredit Hours");
Console.WriteLine($"{course1}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2}\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4}\t\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5}\t\t{course5Grade}\t\t{course5Credit}\n");

int sumCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

int sumGradePoints = 0;

sumGradePoints += course1Grade * course1Credit;
sumGradePoints += course2Grade * course2Credit;
sumGradePoints += course3Grade * course3Credit;
sumGradePoints += course4Grade * course4Credit;
sumGradePoints += course5Grade * course5Credit;

decimal GPA = (decimal)sumGradePoints / sumCreditHours;

int intPart = (int)GPA;
int firsDigit = (int)(GPA * 10) % 10;
int secondDigit = (int)(GPA * 100) % 10;


Console.WriteLine($"Grade Point Average (GPA):\t{intPart}.{firsDigit}{secondDigit}");