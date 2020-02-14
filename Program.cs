using System;

namespace Dog
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
    public class Dog
    {
        
        
        public String name;
        public String owner;
        public int age;
        public Gender gender;
        public Dog(String dogname, String dogowner, int dogage, Gender doggender)
        {
            name = dogname;
            owner = dogowner;
            age = dogage;
            gender = doggender;
        }

        public void Bark(int numBark)
        {
            for(int i = 0; i<numBark; i++)
            {
                Console.WriteLine("Bark!");
            }
        }

        public String GetTag()
        {
            string tag = String.Format("If lost, call " + owner);
            if(gender == 0)
            {
                tag = String.Concat(tag, ". His ");
            }
            else
            {
                tag = String.Concat(tag, ". Her ");
            }
            tag = String.Concat(tag, "name is ", name, " and ");

            if(gender == 0)
            {
                tag = String.Concat(tag, "he ");
            }
            else
            {
                tag = String.Concat(tag, "she ");
            }

            tag = String.Concat(tag, "is ", age);
            if(age == 1)
            {
                tag = String.Concat(tag, " year old.");
            }
            else
            {
                tag = String.Concat(tag, " years old.");
            }

            return tag;

        }
    }
}
