

using System.Collections;
/*
* Description :: this class contains all the implementation of a data structure for saving user data   using an arraylist
*         
*AddToList() :: this A Generic function is use for adding a user to the list
*Display() :: this function displays the information about all the users
*/

namespace Collections
{
    public class Arraylist
    {
        ArrayList users = new ArrayList();

        public void AddToList <T>(T username)
        {
            users.Add(username);

        }


        public void DisplayElements()
        {
            Console.WriteLine("**************users********************");
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine(users[i]);
            }
            Console.WriteLine("**************end********************");

        }


    }
}