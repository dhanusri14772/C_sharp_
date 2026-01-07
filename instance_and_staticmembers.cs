Student s1 = new Student ("nawf");
Student s2 = new Student ("anwer");
Console.WriteLine(s1.name);
Console.WriteLine(s2.name);
Console.WriteLine(Student.population);
public class Student
{
   public string name;     //INSTANCE BELONG TO OBJECTS 
   public static int population;  //STATIC BELONGS TO CLASS

   public Student (string n)     
    {
        name = n;
        population = population + 1;
    } 
}
