namespace cSharp_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myCat = new Cat();  // Create a Cat object
            Animal myDog = new Dog();  // Create a Dog object
            //Dog dog = new Animal();

            myAnimal.animalSound();
            myCat.animalSound();
            myDog.animalSound();

            add(2, 3);
        }


        static int add(int a, int b)
        {
            return a + b;
        }
        static int add(int a, int b, int c)
        {
            return (a + b + c);
        }
        static double add(double a, double b)
        {
            return a + b;
        }
        class Animal  // Base class (parent) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Cat : Animal  // Child class
        {
            public override void animalSound()
            {
                Console.WriteLine("The cat says: meow");
            }
        }

        class Dog : Animal  // Child class
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }


    }
}