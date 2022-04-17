using System.Security.Cryptography.X509Certificates;

namespace Homework
{
    public class InteractionWithString
    {
        /// <summary>
        /// Переворот строки
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReverseString(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }

        /// <summary>
        /// Поиск Mail-а по ФИО
        /// </summary>
        /// <param name="str"></param>
        public void SearchMail(ref string str)
        {
            string temp = str.Trim();
            string text = GetFullNameWithFile();
            string[] arr = text.Split("\r\n").
                Where(x => x.Contains(temp)).
                Select(x => x.Trim()).ToArray();

            string[] e = new string[1];

            foreach (var i in arr)
            {
                e = i.Split('&');
            }

            string[] result = e.Where(x => x.Contains('@'))
                .Select(x => x.Trim())
                .ToArray();

            str = result.Aggregate("", (current, i) => current + (i + "\n"));
        }

        /// <summary>
        /// Запись в файл всех Mail-ов с файла
        /// </summary>
        public void CreateFileWithMail()
        {
            string text = GetFullNameWithFile();

            text = text.Replace("\r\n", " & ");
            string[] arr = text.Split('&').
                Where(x => x.Contains('@')).
                Select(x => x.Trim()).ToArray();

            using (StreamWriter writer = new StreamWriter("mail.txt", true))
            {
                foreach (var i in arr)
                {
                    writer.WriteLine(i);
                }
                writer.Close();
            }
        }

        private string GetFullNameWithFile()
        {
            string text;

            using (StreamReader reader = new("FullNameAndMail.txt"))
            {
                text = reader.ReadToEnd();
                reader.Close();
            }

            return text;
        }
    }
}
