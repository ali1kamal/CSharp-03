using System.Text;

namespace Task_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region 1st answer
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion


            #region 2nd answer
            //string str1 = "Clean Code";
            //string str2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(str1,str2));

            ////We can also use this too
            //Console.WriteLine(str1 == str2);
            #endregion

            #region 3rd answer
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Book List");
            //stringBuilder.Append("-Updated");
            //Console.WriteLine(stringBuilder);
            #endregion

            #region 4th answer
            ////it uses the StringBuilder object from the peravious region
            //stringBuilder.Replace("Book List", "Library");
            //Console.WriteLine(stringBuilder);
            #endregion

            #region 5th, 6th, 7th answers
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("Book: " + title + "," + " " + "Pages: " + pages);
            //Console.WriteLine($"Book: {title}, Pages: {pages}");
            //string result = string.Format("Book: {0}, Pages: {1}", title, pages);
            //Console.WriteLine(result);
            #endregion

            #region 8th answer
            //int pages = 464;
            //if (pages > 300)
            //    Console.WriteLine("Long Book");
            //else Console.WriteLine("Short Book");
            #endregion\

            #region 9th answer
            //int pages = 464;
            //bool isAvailble = true;
            //if (pages > 300 && isAvailble == true)
            //    Console.WriteLine("You can borrow this book");
            //else Console.WriteLine("You can't borrow this book");
            #endregion

            #region 10th answer
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //    break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //    break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //    break ;
            //}
            #endregion

            #region 11th answer
            //int pages = 464;
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);
            #endregion

            #region 12, 13, 15 answers
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            ////for (int i = 0; i < books.Length; i++)
            ////    Console.WriteLine($"index {i+1}: {books[i]}");

            //int i = 0;
            //while (i < books.Length)
            //{
            //    Console.WriteLine($"index {i + 1}: {books[i]}");
            //    i++;
            //}

            int i = 1;
            foreach (string item in books)
            {
                Console.WriteLine($"index {i}: {item}");
                i++;
            }
            #endregion


            #region 14 answer
            //int i = 0;
            //do 
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //}
            //while (i < 3);
            #endregion
        }
    }
}
