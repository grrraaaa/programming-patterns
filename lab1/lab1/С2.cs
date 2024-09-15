using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class C2 : I1
    {
        private const int PrivateConstant = 1;
        public const int PublicConstant = 2;
        protected const int ProtectedConstant = 3;
        private int privateField = 1111;
        public int publicField = 1111;
        protected int protectedField = 1111;

        protected int ProtectedProperty { get; set; }
        private int PrivateProperty { get; set; }

        public int PublicProperty
        {
            get { return publicField; }
            set { publicField = value; }
        }


        //
        public event EventHandler InfoDisplayed;

        public string this[int index]
        {
            get { return $"Index: {index}"; }
        }

        public C2()
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

        public C2(C2 other)
        {
            Console.WriteLine("Вызвали 2 конструктор (КОПИРОВАНИЯ) ");
            Console.WriteLine($"other.privateField {other.privateField}\n" +
                $"other.publicField {other.publicField}\n" +
                $"other.protectedField {other.protectedField}\n" +
                $"other.PrivateProperty {other.PrivateProperty}\n" +
                $"other.PublicProperty {other.PublicProperty}\n" +
                $"other.ProtectedProperty {other.ProtectedProperty}\n");
        }

        public C2(int privateField, int publicField, int protectedField)
        {
            Console.WriteLine("Вызвали 3 конструктор ");
            this.privateField = privateField;
            Console.WriteLine($" THIS PRIVATE FIELD {this.privateField} ");
            this.publicField = publicField;
            Console.WriteLine($" THIS PUBLIC FIELD {this.publicField} ");
            this.protectedField = protectedField;
            Console.WriteLine($" THIS PROTECTED FIELD {this.protectedField} ");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private method called.");
        }

        public void PublicMethod()
        {
            Console.WriteLine("Public method called.");
            PrivateMethod();
            InfoDisplayed?.Invoke(this, new EventArgs());
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method called.");
        }
    }
}
