namespace ValueReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking value types ...");

            //The struct is a data type which relates to value types.
            var valueTypeFirstRectangle=new Rectangle();
            valueTypeFirstRectangle.Width = 10;
            valueTypeFirstRectangle.Height = 10;
            Console.WriteLine("Initial Value ...");

            Console.WriteLine("First rectangle value type properties:");
            Console.WriteLine($"Width : {valueTypeFirstRectangle.Width}");
            Console.WriteLine($"Height : {valueTypeFirstRectangle.Height}");

            //Checking what happens when a value type is written on another value type variable.
            var valueTypeSecondRectangle = valueTypeFirstRectangle;
            valueTypeFirstRectangle.Width = 12;
            valueTypeFirstRectangle.Height = 12;
            Console.WriteLine("Checking while value changed ...");

            Console.WriteLine("First rectangle value type properties:");
            Console.WriteLine($"Width : {valueTypeFirstRectangle.Width}");
            Console.WriteLine($"Height : {valueTypeFirstRectangle.Height}");
            Console.WriteLine("Second rectangle value type properties:");
            Console.WriteLine($"Width : {valueTypeSecondRectangle.Width}");
            Console.WriteLine($"Height : {valueTypeSecondRectangle.Height}");


            Console.WriteLine("Checking reference types ...");

            //Instead the classes are referenced types
            var referenceTypeFirstRectangle=new RectangleEntity();
            referenceTypeFirstRectangle.Width = 10;
            referenceTypeFirstRectangle.Height = 10;

            Console.WriteLine("Initial Value ...");

            Console.WriteLine("First rectangle reference type properties:");
            Console.WriteLine($"Width : {referenceTypeFirstRectangle.Width}");
            Console.WriteLine($"Height : {referenceTypeFirstRectangle.Height}");

            //Checking what happens when a reference type variable is assigned to a new variable.
            //As the result shows only the reference of the object is assigned to the new variable, and when one variable's value is changed he other one would be changed.
            var referenceTypeSecondRectangle=referenceTypeFirstRectangle;
            referenceTypeFirstRectangle.Width = 12;
            referenceTypeFirstRectangle.Height = 12;

            Console.WriteLine("Checking while value changed ...");

            Console.WriteLine("First rectangle reference type properties:");
            Console.WriteLine($"Width : {referenceTypeFirstRectangle.Width}");
            Console.WriteLine($"Height : {referenceTypeFirstRectangle.Height}");
            Console.WriteLine("Second rectangle reference type properties:");
            Console.WriteLine($"Width : {referenceTypeSecondRectangle.Width}");
            Console.WriteLine($"Height : {referenceTypeSecondRectangle.Height}");

        }
    }


    internal struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }


    }

    internal class RectangleEntity
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
