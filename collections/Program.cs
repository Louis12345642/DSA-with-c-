using System;
using collections.ArrayLists.Questions;


using Collections;
namespace Program
{

    /*
    * users():: this is the collection of arraylist containing the user information
    * AddToLists() :: allows new users to be added to the list
    */

    class Program
    {
        public static void Main(string[] args)
        {
            //initializing the array list collection class here
            Arraylist users = new Arraylist();

            //adding a username to the list
            Console.WriteLine("Enter the users name: ");
            string username = Console.ReadLine();
            users.AddToList(username);


            //adding an email to the list
            Console.WriteLine("Enter the users Email: ");
            string email = Console.ReadLine();
              users.AddToList(email);

            //adding email to the list
            Console.WriteLine("Enter the users age: ");
            int age = Convert.ToInt32(Console.ReadLine());
              users.AddToList(age);


            //displaying all the users in the list

            Console.WriteLine("         ");
            Console.WriteLine("         ");
            users.DisplayElements();


            //testing   two sum problem

            Twosum ts = new Twosum();

            int target = 9;

            int[] nums = new int[]{2,7,11,15};
            Console.WriteLine(ts.TwoSum(nums,target));


            //calling the array test bed in the main classs
        
            

            


        }
    }
}