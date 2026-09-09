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
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Book List");
            stringBuilder.Append("-Updated");
            Console.WriteLine(stringBuilder);
            #endregion

            #region 4th answer
            //it uses the StringBuilder object from the peravious region
            stringBuilder.Replace("Book List", "Library");
            Console.WriteLine(stringBuilder);
            #endregion
        }
    }
}
