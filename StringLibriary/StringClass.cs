using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibriary
{
    public class StringClass
    {
        /// <summary>
        /// Фильтр запрещенных  слов
        /// </summary>
        /// <param name="textString">В качестве параметра передается строка, которая может быть пустой или содержать некоторый текст. В тексте может быть 0 или более слов "редиска", записанных в различном регистре.</param>
        /// <returns>Возвращается отфильтрованный текст, в котором все слова редиска заменены на звездочки ***</returns>
        public static string Censore(string textString)
        {
         
            textString= textString.ToLower().Replace("редиска","*******");
            return textString;
        }
    }
}
