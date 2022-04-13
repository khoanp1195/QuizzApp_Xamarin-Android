using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ToolCreateQuery
{
    class Program
    {

        public static string ConvertToUnsign(string str)
        {

            //Convert Unicode to ascii character
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty)
                    .Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        private static List<string> getListCountry()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\khoanp\Desktop\Xamarin Android\FlagQuizz\FlagQuizz\Resources\drawable");
            FileInfo[] files = d.GetFiles("*.png");
            List<string> lstName = new List<string>();
            foreach(var file in files)
            {
                File.Move(file.FullName, ConvertToUnsign(file.FullName.ToLower().Replace("'", String.Empty).Replace("-",String.Empty)));
                lstName.Add(file.Name.Replace(".png", string.Empty));
            }
            return lstName;
        }
        private static List<string> getNameRandom(string name, List<string>lstNames)
        {
            HashSet<string> myHashSet = new HashSet<string>();
            myHashSet.Add(name);

            while(myHashSet.Count < 4)
            {
                myHashSet.Add(lstNames.OrderBy(s => Guid.NewGuid()).First());

            }
            return myHashSet.OrderBy(s => Guid.NewGuid()).ToList();
        }
        private static async Task generateQuery()
        {
            List<string> lstQuery = new List<string>();
            List<string> lstCountryName = getListCountry();
            string query = String.Empty;
            foreach(var name in lstCountryName)
            {
                List<string> answerList = getNameRandom(name, lstCountryName);
                query = "INSERT INTO Question(Image,AnswerA,AnswerB,AnswerC, AnswerD,CorrectAnswer)"
                + $"VALUES(\"{name}\",\"{answerList[0]}\",\"{answerList[1]}\",\"{answerList[2]}\",\"{answerList[3]}\",\"{name}\");";
                lstQuery.Add(query);
            }
            System.IO.File.WriteAllLines(@".//QueryGenerate.txt", lstQuery);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Tool Generate Quesry 1.0!");
            Console.WriteLine("Please Wait");
            generateQuery();
            Console.WriteLine("Successs....");
            Console.ReadKey();
        }
    }
}
   
