using System ;
class program
{
    static void Main()
    {
        unitconverter feettoinchesconverter = new unitconverter(12);   //defining the unitconverter's value 12& miletofeetconverter value 5280 
        unitconverter milestofeetconverter = new unitconverter(5280);

        Console.WriteLine(feettoinchesconverter.convert(30));
        Console.WriteLine(feettoinchesconverter.convert (80));

        Console.WriteLine(feettoinchesconverter.convert(milestofeetconverter.convert(1))); //CHAINED CONVERSION
    }
}
public class unitconverter //creating a class "unitconverter" 
{
    int ratio;             //declaring the variables to be used "field part"
    public unitconverter (int unitratio)   //constructor
    {
        ratio = unitratio;
    }
    public int convert (int unit)  //defining a functioning method 
    {
        return unit*ratio;
    }
}

