// See https://aka.ms/new-console-template for more information

using lab10ex1.Models;
/*
Exercitiul – 1
• Un student este caracterizat de
    • Id (unic)
    • Nume
    • Prenume
    • Varsta
    • Specializare
• Specializarile vor fi
    • Informatica
    • Litere
    • Constructii
• Creeati modelul, adaugati EF 3.1,Adaugati DB
• Creeati in clasa “main” o functie “Seed” care va popula DB-ul
• Afisati toti studentii din DB in ordine alfabetica
• Afisati cel mai tanar student de la constructii cu varsta de peste
20 de ani

 */

//using var ctx = new UniversityContext();
//await ctx.Database.EnsureDeletedAsync();

Seed();
ShowAlphabetically();
ShowFirstOverTwenty();


static void Seed()
{
    


    using var ctx = new UniversityDbContext();


    ctx.Students.Add(new Student
    {
        Last = "Mickey",
        First = "Mouse",
        Age = 18,
        Degree = Degree.Info
    }); 
    ctx.Students.Add(new Student
    {
        Last = "Minnie",
        First = "Mouse",
        Age = 19,
        Degree = Degree.Litere
    });
    ctx.Students.Add(new Student
    {
        Last = "Donald",
        First = "Duck",
        Age = 20,
        Degree = Degree.Litere
    });
    ctx.Students.Add(new Student
    {
        Last = "Daisy",
        First = "Duck",
        Age = 21,
        Degree = Degree.Litere
    });
    ctx.Students.Add(new Student
    {
        Last = "Della",
        First = "Duck",
        Age = 22,
        Degree = Degree.Info
    });
    ctx.Students.Add(new Student
    {
        Last = "Scrooge",
        First = "McDuck",
        Age = 20,
        Degree = Degree.Info
    });
    ctx.Students.Add(new Student
    {
        Last ="Louie",
        First = "Duck",
        Age = 23,
        Degree = Degree.Info
    });
    ctx.Students.Add(new Student
    {
        Last = "Quackmore",
        First = "Duck",
        Age = 18,
        Degree = Degree.Info
    });
    ctx.Students.Add(new Student
    {
        Last = "Huey",
        First = "Duck",
        Age = 22,
        Degree = Degree.Constructii
    });
    ctx.Students.Add(new Student
    {
        Last = "Dewey",
        First = "Duck",
        Age = 19,
        Degree = Degree.Constructii
    });
    ctx.Students.Add(new Student
    {
        Last = "Hortense",
        First = "Duck",
        Age = 23,
        Degree = Degree.Constructii
    });


    ctx.SaveChanges();

}

static void ShowAlphabetically()
{
    using var ctx = new UniversityDbContext();
    foreach (var student in ctx.Students.OrderBy(e=>e.Last).ThenBy(e=>e.First))
    {
        Console.WriteLine(student);
    }


}

static void ShowFirstOverTwenty()
{
    using var ctx = new UniversityDbContext();

    ctx.Students
        .Where(e => e.Age > 20 && e.Degree == Degree.Constructii)
        .OrderBy(e => e.Age)
        .Take(1)
        .ToList()
        .ForEach(e => Console.WriteLine(e));
}

