int numberOfNotes = 5;

int sohpiaNote1 = 93;
int sohpiaNote2 = 87;
int sohpiaNote3 = 98;
int sohpiaNote4 = 95;
int sohpiaNote5 = 100;

int nicolasNote1 = 80;
int nicolasNote2 = 83;
int nicolasNote3 = 82;
int nicolasNote4 = 88;
int nicolasNote5 = 85;

int zahirahNote1 = 84;
int zahirahNote2 = 96;
int zahirahNote3 = 73;
int zahirahNote4 = 85;
int zahirahNote5 = 79;

int jeongNote1 = 90;
int jeongNote2 = 92;
int jeongNote3 = 98;
int jeongNote4 = 100;
int jeongNote5 = 97;

int sophiaSum = sohpiaNote1 + sohpiaNote2 + sohpiaNote3 + sohpiaNote4 + sohpiaNote5;
int nicolasSum = nicolasNote1 + nicolasNote2 + nicolasNote3 + nicolasNote4 + nicolasNote5;
int zahirahSum = zahirahNote1 + zahirahNote2 + zahirahNote3 + zahirahNote4 + zahirahNote5;
int jeongSum = jeongNote1 + jeongNote2 + jeongNote3 + jeongNote4 + jeongNote5;

Console.WriteLine($"Sophia's sum of notes: {sophiaSum}");
Console.WriteLine($"Nicolas's sum of notes: {nicolasSum}");
Console.WriteLine($"Zahirah's sum of notes: {zahirahSum}");
Console.WriteLine($"Jeong's sum of notes: {jeongSum}");

decimal sophiaScore = (decimal)sophiaSum / numberOfNotes;
decimal nicolasScore = (decimal)nicolasSum / numberOfNotes;
decimal zahirahScore = (decimal)zahirahSum / numberOfNotes;
decimal jeongScore = (decimal)jeongSum / numberOfNotes;

Console.WriteLine($"\nSophia's average score: {sophiaScore}");
Console.WriteLine($"Nicolas's average score: {nicolasScore}");
Console.WriteLine($"Zahirah's average score: {zahirahScore}");
Console.WriteLine($"Jeong's average score: {jeongScore}");

Console.WriteLine("\nStudent\t\tGrade\n");
Console.WriteLine($"Sophia:\t\t {sophiaScore} \tA");
Console.WriteLine($"Nicolas:\t {nicolasScore} \tB");
Console.WriteLine($"Zahirah:\t {zahirahScore} \tB");
Console.WriteLine($"Jeong:\t\t {jeongScore} \tA");