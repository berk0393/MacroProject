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
            types.Add(new ActionTypeModel() { typeID = 1, typeName = "Sol Click" });
            types.Add(new ActionTypeModel() { typeID = 2, typeName = "Sağ Click" });
            types.Add(new ActionTypeModel() { typeID = 3, typeName = "Sol Çift Click" });
            types.Add(new ActionTypeModel() { typeID = 4, typeName = "Sağ Çift Click" });
            types.Add(new ActionTypeModel() { typeID = 6, typeName = "Yönlendir" });
            types.Add(new ActionTypeModel() { typeID = 7, typeName = "Bekle" });
            types.Add(new ActionTypeModel() { typeID = 5, typeName = "Ekran Oku", visibleMouseEvent = false });

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

        /// <summary>
        /// Seçilen 4 Noktayı Hesaplayarak X,Y koordinatları ve Width Heigt Olacak Şekilde Dikdörtgen Bilgileri Verir
        /// </summary>
        /// <param name="rectangleDrawingCoordiantList"></param>
        /// <returns></returns>
        public CreatedRectangleInfo defineRectangle(List<RectangleCooridant> rectangleDrawingCoordiantList)
        {
            List<RectangleCooridant> minYCoordinantList = rectangleDrawingCoordiantList.OrderBy(a => a.yCoordinate).Take(2).ToList();

            int xCoordinant = findXCoordinate(minYCoordinantList);
            int yCoordinant = findYCoordinate(minYCoordinantList);

            int width = rectangleDrawingCoordiantList.Max(a => a.xCoordinate) - rectangleDrawingCoordiantList.Min(a => a.xCoordinate);

            int height = rectangleDrawingCoordiantList.Max(a => a.yCoordinate) - rectangleDrawingCoordiantList.Min(a => a.yCoordinate);

            CreatedRectangleInfo info = new CreatedRectangleInfo()
            {
                xCoordinate = xCoordinant,
                yCoordinate = yCoordinant,
                width = width,
                height = height
            };

            return info;
        }

        /// <summary>
        /// En Küçük Y koordinanta Sahip 2 Değer Verilir. Buradan X Coordiant'ı bulunur
        /// </summary>
        /// <param name="minYCoordinantList"></param>
        private int findXCoordinate(List<RectangleCooridant> minYCoordinantList)
        {
            return minYCoordinantList.OrderBy(a => a.xCoordinate).FirstOrDefault().xCoordinate;
        }

        /// <summary>
        /// En büyük Y koordinanta Sahip olan 2 Değer Verilir. Buradan Y coordinantı Bulunur
        /// </summary>
        /// <param name="maxYCoordinantList"></param>
        private int findYCoordinate(List<RectangleCooridant> maxYCoordinantList)
        {
            return maxYCoordinantList.OrderBy(a => a.xCoordinate).FirstOrDefault().yCoordinate;
        }

    }
}
