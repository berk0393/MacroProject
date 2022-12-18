using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MacroBot.Repository
{
    public class TextSearch
    {
        public bool searchData(List<string> worldList, string readedData)
        {
            bool isMatch = false;

            readedData = readedData.ToLower();

            worldList = worldList.ConvertAll(a => a.ToLower()).ToList();

            foreach (string key in worldList)
            {
                isMatch = Regex.IsMatch(readedData, key);

                if (isMatch)
                    break;
            }

            return isMatch;
        }

        //public int searchText(string text, List<string> words)
        //{
        //    int textLenght = text.Length;

        //    string controlText = string.Empty;

        //    List<string> searchedList = null;

        //    for (int i = 0; i < textLenght; i++)
        //    {
        //        controlText += text[i].ToString();

        //        searchedList = words.Where(a => a.StartsWith(controlText)).ToList();
        //    }

        //    return 0;
        //}

        //public static bool checkWords(List<string> worldList, string readedData)
        //{
        //    List<string> _readedData = readedData.Split(null).ToList();

        //    _readedData.RemoveAll(a => string.IsNullOrWhiteSpace(a));

        //    _readedData = _readedData.ConvertAll(a => a.ToLower()).Distinct().ToList();

        //    worldList = _readedData.ConvertAll(a => a.ToLower()).ToList();

        //    List<string> filterWord = null;

        //    foreach (string item in worldList)
        //    {
        //        string _itemLower = item.ToLower();

        //        if (_readedData.Any(a => a == _itemLower))
        //            return true;

        //        if (_readedData.Contains(_itemLower))
        //            return true;
        //    }

        //    return false;
        //}
    }
}
