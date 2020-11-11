using System;

namespace UniversityLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
             
                Students studentdetails1 = new Students("Jim Nad", "I4C345", "2020");
                Students studentdetails2 = new Students("Naresh Mash", "I4C343", "2019");
                Students studentdetails3= new Students("Ben Hood", "I4C344", "2018");
                Students studentdetails4 = new Students("Kim Nim", "I4C345", "2017");
                Students studentdetails5 = new Students("Lam Tish", "I4C346", "2016");


                Book bookdetails1 = new Book("Think Like A Woman Act Like A Man", "icu456");
                Book bookdetails2= new Book("The Man Behind The Wheel", "icu456");
                Book bookdetails3 = new Book("The Power", "icu457");
                Book bookdetails4 = new Book("Let Change The World", "icu458");
                Book bookdetails5 = new Book("C# Programming", "icu459");

                Library library1 = new Library(studentdetails1, bookdetails1,"2,25,2017", "3,1,2017");
                Library library2 = new Library(studentdetails2, bookdetails2, "8,2,2017", "8,20,2017");
                Library library3 = new Library(studentdetails3, bookdetails3, "12,18,2019", "1,3,2017");
                Library library4 = new Library(studentdetails4, bookdetails4, "1,19,2019", "2,4,2017");
                Library library5 = new Library(studentdetails5, bookdetails5, "2,20,2019", "3,5,2017");


                GenericDefaulterList<IDefaulters> library = new GenericDefaulterList<IDefaulters>(); 


               library.Add(library1);                     
               library.Add(library2);                     
               library.Add(library3);                     
               library.Add(library4);                     
               library.Add(library5);  
             

             foreach(var item in library.GetDefaulter())
             {
                Console.WriteLine(item);
             }
               

          
            
            
              
            }
            catch(System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
