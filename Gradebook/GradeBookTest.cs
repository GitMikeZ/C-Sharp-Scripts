using System;

class GradeBookTest
{
    static void Main(string[] args)
    {
        int[,] gradesArray = { {87, 97, 70},
                               {62, 87, 90},
                               {100, 81, 82},
                               {83, 62, 85},
                               {73, 87, 65},
                               {85, 75, 83},
                               {91, 90, 100},
                               {79, 72, 84},
                               {87, 93, 73}};

        GradeBook myGradeBook = new GradeBook(
            "CS101 Introduction to C# Programming", gradesArray);
        myGradeBook.DisplayMessage();
        myGradeBook.ProcessGrades();
    }
}

