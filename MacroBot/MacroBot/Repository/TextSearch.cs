using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroBot.Repository
{
    public class TextSearch
    {
        public int searchText(string text, List<string> words)
        {
            int textLenght = text.Length;

            string controlText = string.Empty;

            List<string> searchedList = null;

            for (int i = 0; i < textLenght; i++)
            {
                controlText += text[i].ToString();

                searchedList = words.Where(a => a.StartsWith(controlText)).ToList();



            }

            return 0;
        }

        public static bool checkWords(List<string> worldList, string readedData)
        {

            string _readedData = @"Enchant has succeeded.

                                        of Asmodi(Sufﬁx) has been acquired.
                                        Enchant has succeeded.
                                        
                                        Enchant has succeeded.
                                        
                                        of Guardian(Sufﬁx) has been acquired.
                                        Enchant has succeeded.";

            //List<string> _readedData = readedData.Split(null).ToList();

            //_readedData.RemoveAll(a => string.IsNullOrWhiteSpace(a));

            //_readedData = _readedData.ConvertAll(a => a.ToLower()).Distinct().ToList();

            //worldList = _readedData.ConvertAll(a => a.ToLower()).ToList();

            //List<string> filterWord = null;

            //TextSearch s = new TextSearch();

            //foreach (string item in _readedData)
            //{
            //    filterWord = worldList.Where(a => a.StartsWith(item[0].ToString().ToLower())).ToList();

            //    //foreach (string targetWord in worldList)
            //    //{
            //    //    var targetLow = targetWord.ToLower();

            //    //    var result = item.StartsWith(targetLow);

            //    //}
            //}

            //foreach (string item in worldList)
            //{
            //    string _itemLower = item.ToLower();

            //    if (_readedData.Any(a => a == _itemLower))
            //        return true;

            //    if (_readedData.Contains(_itemLower))
            //        return true;

            //    var b = _readedData.IndexOf(_itemLower);



            //}

            return false;
        }

    }
}
