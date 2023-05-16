using StudyingDesignPatternsDotNet;

string[] files = { "01_SingleResponbilityPrinciple.cs", "02_OpenClosedPrinciple.cs", "03_LiskovSubstitutionPrinciple.cs" };

Console.WriteLine("Choose a file:\n");
foreach (var file in files)
{
    Console.WriteLine(file);
}
Console.WriteLine();

var choosed = Convert.ToInt32(Console.ReadLine());

Console.Clear();
switch (choosed)
{
    case 1:
        new Demo01().Main(default);
        break;
    case 2:
        new Demo02().Main(default);
        break;
    case 3:
        new Demo03().Main(default);
        break;
}
