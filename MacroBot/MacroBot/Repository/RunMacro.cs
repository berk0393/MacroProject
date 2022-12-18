using MacroBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;

namespace MacroBot.Repository
{
    public class RunMacro
    {
        private SimKeyOperation _simKeyOperation = null;
        public Screenshot _screenshotService = null;
        private ReadImage _readImage = null;
        private TextSearch _textSearch = null;

        public RunMacro()
        {
            _simKeyOperation = new SimKeyOperation();
            _screenshotService = new Screenshot();
            _readImage = new ReadImage();
            _textSearch = new TextSearch();
        }

        /// <summary>
        /// Listedeki ilgili işlemler yapılmaya başlanır
        /// </summary>
        /// <param name="actionList"></param>
        /// <param name="screenReadActionList"></param>
        /// <returns></returns>
        public MacroResult runMacro(List<BotActionList> actionList, List<ScreenReadActionList> screenReadActionList)
        {
            ScreenReadActionList selectedScreenshot = new ScreenReadActionList();
            MacroResult _macroResult = new MacroResult();
            List<string> readedDataList = new List<string>();

            foreach (BotActionList item in actionList)
            {
                if (item.actionID == 7)
                {
                    Thread.Sleep(item.waitingSecond);
                    continue;
                }

                if (item.screenReadID != 0)
                {
                    string _readedData = string.Empty;

                    selectedScreenshot = screenReadActionList.Where(a => a.recordID == item.screenReadID).FirstOrDefault();

                    if (selectedScreenshot == null)
                        throw new Exception("Görsel İşlemi Bulunamadı");

                    _readedData = screenReadOperation(selectedScreenshot);

                    readedDataList.Add(_readedData);

                    if (selectedScreenshot.ekListesi.Count > 0)
                    {
                        if (_textSearch.searchData(selectedScreenshot.ekListesi, _readedData))
                        {
                            _macroResult.continueStatus = false;
                            _macroResult.findSearchedWord = true;
                            _macroResult.readedDataList = readedDataList;
                            return _macroResult;
                        }
                    }
                }
                else
                {
                    mouseOperations(item.actionID, item.xCoordinate, item.yCoordinate);
                }
                Thread.Sleep(50);
            }

            _macroResult.readedDataList = readedDataList;
            return _macroResult;
        }

        private void mouseOperations(int actionID, int x, int y)
        {
            _simKeyOperation.mouseCursor(x, y);
            Thread.Sleep(50);
            runMouseAction(actionID);

        }

        private string screenReadOperation(ScreenReadActionList ssOperation)
        {
            _screenshotService.takeScreenShot(ssOperation.xCoordinate, ssOperation.yCoordinate, ssOperation.width, ssOperation.height);
            var img = _screenshotService.getCropedImage(true);

            if (img == null)
                throw new Exception("Kırpılmış Görsel Bulunamadı");

            string _readData = _readImage.readData(img);

            return _readData;

        }

        private void runMouseAction(int actionID)
        {
            switch (actionID)
            {
                case 1:
                    _simKeyOperation.mouseLeftClickFunction();
                    break;
                case 2:
                    _simKeyOperation.mouseRightClickFunction();
                    break;
                case 3:
                    _simKeyOperation.mouseLeftDoubleClickFunction();
                    break;
                case 4:
                    _simKeyOperation.mouseRighttDoubleClickFunction();
                    break;
                case 6:
                    break;
                default:
                    throw new Exception("İşlem ID Bulunamadı. ID=" + actionID);
            }
        }
    }
}
