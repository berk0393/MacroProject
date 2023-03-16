using MacroBot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroBot.Repository.RectangleRep
{
   public class RectangleRepository
    {
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
