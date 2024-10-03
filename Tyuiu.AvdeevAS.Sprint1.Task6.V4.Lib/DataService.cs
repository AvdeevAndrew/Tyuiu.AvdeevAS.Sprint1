using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AvdeevAS.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {



            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Создание списка для хранения найденных слов
            List<string> doubleNWords = new List<string>();

            // Поиск слов с "нн"
            foreach (string word in words)
            {
                if (word.Contains("нн"))
                {
                    doubleNWords.Add(word);
                }
            }

            // Возвращение всех найденных слов в виде строки, разделенной пробелами
            return doubleNWords.Count > 0 ? string.Join(" ", doubleNWords) : "Нет слов с 'нн'";

        }
    }
}
