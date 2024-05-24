using System;
# region Abstract Explanaiton

/*   1. What is the Abstraction ?
     A. Abstraction is a fundamental concept in object-oriented programming that involves hiding the complex implementation details 
        and exposing only the essential features of an object. object is nothing but feature in the csharp like class , enum , delegate , interface

       
*/
#endregion


// Think logically _ Create the case study or situaion should be good(IMP)

//private vs public vs internal  vs protected internal vs protected -- Access Modifiers

//static vs normal class  --> You can directly members from the class(static)

//static vs normal members in the class

//abstract vs normal class

//static vs abstract 

namespace Games
{
    //1. I do't want to implement the logic in the parent class.
    // Because no meaning 
    abstract class Character
    {
        static int ID;
        public string Name;
        public string Health;
        public string AttackPower;

        public abstract void Attack(string targetName);

        public void abc()
        {
            ID = 0;
        }

    }
    class Warrior : Character
    {
        public override void Attack(string targetName)
        {
            Console.WriteLine($"Charcter : {Name} swings a sword to the {targetName} ");

        }
    }

    class Mage : Character
    {
        public override void Attack(string target)
        {
            Console.WriteLine($"{Name} casts a fireball at {target}!");
            // Perform attack logic
        }
    }

    class MainProgram
    {
        static void Main()
        {
            //Character character = new Character(); // YOu cannot create the instance tot he abstract class . Normal class you can crete the instance.

            Character character = new Warrior()
            {
                Name = "Conan", //UI
                Health = "100",
                AttackPower = "20"
            };
            character.Attack("Robert");

            Character character1 = new Mage()
            {
                Name = "Robert", //UI
                Health = "100",
                AttackPower = "20"
            };
            character1.Attack("Peter");
          //  character1.Attack()




            Console.ReadLine();
        }
    }

}



