
namespace  ArrayTest

/*
* Description: this class implements an array with all the required functionality
* insert(): use for inserting elements in the array
* clear(): used for clearing all the elements in the array
 *  printArray(): prints out the entire array
 *constructor params: this takes in the size of the array
*
*/
{


    public class ArrayTest

    private int size;
    private int Element[]; 
    private int numberOfElements;
    private int uppperbound;


    public  static void ArrayTest(int size)
    {
        this.size = size;
    }

    //method to insert into the array

    public static void insert(int element)
    {
       this.Element[numberOfElements] = element;
       numberOfElements++;
    }

    //displaying the elements in the array

    public static void clear()
    {
        //check if there are elements in the array
        for(int i=0; i<Elements.Length;i++)
        {
            if(Elements[i] != 0){
                 numberOfElements=0;
                 Elements[i]=0;
            
            }
        
        }
       
    }
    ///displaying all the elements in the array
    
    public static void Display()
    {
        //loop througth the array and display all the possible values in the array

        for(int i =0; i<Elements.Length;i++)
        {
            Console.WriteLine("the values are "+ i);
        }
    }
  
}