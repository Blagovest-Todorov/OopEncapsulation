using System;

namespace _19.EncapsulationRealizedPerAccessModifiers
{
    //class Program
   // {
       // static void Main(string[] args)
       // {
           // Console.WriteLine("Hello World!");
            // Encapsulation is implemented -realized by using access modifiers- access specifiers;
            // Access specifier defines the scope and the visibility of the class member;
            // C# provides the following access Specifiers :

            // private, 
            // protected, 
            // public, --public member is accessible from outside the class
            // internal
            // protected internal

            //Encapsulation is process of  preventing, protecting- class -members from outside modification.
            //Encapsulation is a way to prevent data from  outside modification;
            //Encapsulation is the process of hiding the data from outside access., 
            //and giving access to only publicly exposed members(publicly accessed methods, and properties(get, set))
            //through  authenifications and validations! /utting the data into unit, package and hiding , 
            //providing a level of access  only to publicly exposed memners, through validations and authentication.
            //and givind access only to publicly exposed members, through authentifications, and validations !!
            //the data encapsulation is called data hiding! , becasue through this principle-encapsulation/
            //we can hide the the data from ouside exposure, .
            //the aim of the encapsulation is securing the data !!
            //
            //Encapsulation is achived by 1 .declaring the variables as private ;-> 
            //to restrict its direct access from the outside
            // 2. declaring one pair of getter and setter methods or get and set properties !!
            //
            //We declare the variables as private to stop the access from the ouside the class
            // the public setter and getter methods or properties  are used to access the private variables 
            //from outside class after specific validation.

            
       // }

        public class Bank
        {
            // hiding class data by declaring the  variable as private
            private double balance;  // declaring a private variable

            // creationg public getter and setter method 
            public double GetBalance()  // add validation logic if needed
            {
                return balance;
            }
            public void SetBalance( double balance)
            {
                //add validation to check if the data is correct or not
                this.balance = balance;
            }

        }

        class BankUser 
        {
            public static void Main()
            {
                Bank SBI = new Bank(); //We create an object of class Bank
                SBI.SetBalance(500);
                Console.WriteLine(SBI.GetBalance());
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
          
        } // What are the advantages of providing variable access via setter and getter methods in C#?
    // We can validate the used given date before we storing it into the variable
    
}
