//Math >= 90 OR Chemistry >= 90
// math && chemistry || math && biology || chemistry && biology
 
int math, biology, chemistry;
Console.WriteLine("Enter your math results:");
math = Int32.Parse(Console.ReadLine());


Console.WriteLine("Enter your Chemistry results:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90 || math >= 90 && biology >=90) || ( chemistry >= 90 && biology >= 90) )
    {
        Console.WriteLine("Congratulatiojns! You got accepted");
    }
    else
    {
        Console.WriteLine("Your application cannot be approved.");
    }
 
 