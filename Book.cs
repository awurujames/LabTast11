namespace UniversityLibrary
{
    public class Book
    {
        public string BookName{get;set;}
        public string BookID{get;set;}

        public Book(string bookname, string bookid) 
        {
            BookName = bookname;
            BookID = bookid;
        }
    }
}