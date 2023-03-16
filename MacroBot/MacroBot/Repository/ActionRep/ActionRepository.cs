using MacroBot.Helper;
using MacroBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroBot.Repository
{
    public class ActionRepository
    {
        public List<BotActionList> actionList = null;

        public List<ScreenReadActionList> screenReadActionList = null;
        public ActionRepository()
        {
            actionList = new List<BotActionList>();

            screenReadActionList = new List<ScreenReadActionList>();
        }

        /// <summary>
        /// Botun Yapabileceği İşlem Türleri
        /// </summary>
        /// <returns></returns>
        public List<ActionTypeModel> getActionList()
        {
            List<ActionTypeModel> types = new List<ActionTypeModel>();

            foreach (EnumActionType actionType in (EnumActionType[])Enum.GetValues(typeof(EnumActionType)))
            {
                types.Add(new ActionTypeModel() { typeID = (int)actionType, typeName = actionType.GetDisplayName(), visibleMouseEvent = actionType == EnumActionType.EkranOku ? false : true });
            }

            return types;
        }

        /// <summary>
        /// Formda Eklenen Aksiyonları Liste Olarak Tutar
        /// </summary>
        /// <param name="actionQueue"></param>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <param name="actionTypeValue"></param>
        /// <param name="screenReadID"></param>
        public void addActionList(int actionQueue, int xPoint, int yPoint, int actionTypeValue, int screenReadID = 0, int waitingSecond = 0)
        {
            actionList.Add(new BotActionList()
            {
                actionID = actionTypeValue,
                xCoordinate = xPoint,
                yCoordinate = yPoint,
                actionQueue = actionQueue,
                screenReadID = screenReadID,
                waitingSecond = waitingSecond
            });
        }

        public void editActionList(int selectedActionQueue, int xPoint, int yPoint, int actionTypeValue, int screenReadID = 0, int waitingSecond = 0)
        {

            BotActionList selectedAction = actionList.Where(a => a.actionQueue == selectedActionQueue).FirstOrDefault();

            int index = 0;

            if (selectedAction == null)
            {
                return;
            }

            index = actionList.FindIndex(a => a.actionQueue == selectedActionQueue);

            selectedAction.actionID = actionTypeValue;
            selectedAction.xCoordinate = xPoint;
            selectedAction.yCoordinate = yPoint;
            selectedAction.screenReadID = screenReadID;
            selectedAction.waitingSecond = waitingSecond;

            actionList[index] = selectedAction;
        }

        /// <summary>
        /// Aksiyonlar içerisinde ki Görsel Okuma Bilgilerinin Detaylarını Tutar
        /// </summary>
        /// <param name="actionID"></param>
        /// <param name="ekListesi"></param>
        /// <param name="xPoint"></param>
        /// <param name="yPoint"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void addScreenReadList(int actionID, List<string> ekListesi, int xPoint, int yPoint, int width, int height)
        {
            screenReadActionList.Add(new ScreenReadActionList()
            {
                recordID = actionID,
                ekListesi = ekListesi,
                xCoordinate = xPoint,
                yCoordinate = yPoint,
                width = width,
                height = height
            });
        }

        public void editScreenReadList(int selectedActionID, List<string> ekListesi, int xPoint, int yPoint, int width, int height)
        {
            ScreenReadActionList selectedReadAction = screenReadActionList.Where(a => a.recordID == selectedActionID).FirstOrDefault();

            int index = 0;

            if (selectedReadAction == null)
            {
                return;
            }

            index = screenReadActionList.FindIndex(a => a.recordID == selectedActionID);

            selectedReadAction.ekListesi = ekListesi;
            selectedReadAction.xCoordinate = xPoint;
            selectedReadAction.yCoordinate = yPoint;
            selectedReadAction.width = width;
            selectedReadAction.height = height;

            screenReadActionList[index] = selectedReadAction;
        }

    }
}
