using System;
using lab1;
using static lab1.С4;
public class C1
{
    private const int PrivateConstant = 1;
    public const int PublicConstant = 2;
    protected const int ProtectedConstant = 3;
    private int privateField = 1111;
    public int publicField=1111;
    protected int protectedField=1111;


    protected int ProtectedProperty { get; set; } 
    private int PrivateProperty { get; set; }
    public int PublicProperty {
        get { 
            return publicField;
        } }

    public C1()
    {
        privateField = 10;
        publicField = 20;
        protectedField = 30;
        Console.WriteLine(
            "ВЫЗВАЛИ 1 КОНСТРУКТОР\n" +
            $"ТЕПЕРЬ НАШИ ПЕРЕМЕННЫЕ\n " +
            $"  privateField = 10; {privateField}\n" +
            $"  publicField = 20; {publicField}\n" +
            $" protectedField = 30; {protectedField}\n");
    }

    public C1(C1 other)
    {
        Console.WriteLine("Вызвали 2 конструктор (КОПИРОВАНИЯ) ");
        Console.WriteLine($"other.priviteField{other.privateField}\n" +
            $"other.publicField {other.publicField}\n" +
            $"other.protectedField{other.protectedField}\n" +
            $"other.PrivateProperty{other.PrivateProperty}\n" +
            $"other.PublicProperty{other.PublicProperty}\n" +
            $"other.ProtectedProperty{other.ProtectedProperty}\n");
    }

    public C1(int privateField, int publicField, int protectedField)
    {
        Console.WriteLine("Вызвали 3 конструктор ");
        this.privateField = privateField;
        Console.WriteLine($" THIS PRIVATE FIELD{this.privateField} ");
        this.publicField = publicField;
        Console.WriteLine($" THIS PUBLIC FIELD{this.publicField} ");

        this.protectedField = protectedField;
        Console.WriteLine($" THIS PROTECTED FIELD{this.protectedField} ");

    }

    private void PrivateMethod()
    {
        Console.WriteLine("Private method called.");
    }

    public void PublicMethod()
    {
        Console.WriteLine("Public method called. I wanna call private method as i can , but Main cant do that");
        PrivateMethod();
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method called.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        C1 first = new C1();
        C1 second = new C1(first);
        C1 third = new C1(1, 2, 3);
        Console.WriteLine($"\n\n ПРОБУЕМ МЕТОДЫ");
        //first.PrivateMethod();
        first.PublicMethod();
        //first.ProtectedMethod();
        Console.WriteLine($"\n\n ПРОБУЕМ СВОЙСТВА");

        //first.PrivateProperty ;
        Console.WriteLine($"public prop is {first.PublicProperty}");
        // first.ProtectedPropert();
        Console.WriteLine($"\n\n It can not be changed (no set info)");
        //first.PublicProperty=1;



        Console.WriteLine("\n\n\n С2");
        C2 c2 = new C2();

        // Подписка на событие
        c2.InfoDisplayed += (sender, e) =>
        {
            Console.WriteLine("Вызвано событие");
        };

        // Вызов метода, который вызывает событие
        c2.PublicMethod();


        Console.WriteLine("\n\n\n С3 AND C4");

        C4 obj = new C4();
        obj.PublicMethod();
        obj.C4Method();
        Console.WriteLine(obj.PublicField);
        Console.WriteLine(obj.PublicProperty);
        obj.PublicProperty = "Modified Public Property in C3";
        Console.WriteLine(obj.PublicProperty);
    }
}