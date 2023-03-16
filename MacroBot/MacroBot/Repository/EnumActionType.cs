using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroBot.Repository
{
    public enum EnumActionType
    {
        [Display(Name = "Sol Click")]
        SolClick = 1,
        [Display(Name = "Sağ Click")]
        SagClick = 2,
        [Display(Name = "Sol Çift Click")]
        SolCiftClick = 3,
        [Display(Name = "Sağ Çift Click")]
        SagCiftClick = 4,
        [Display(Name = "Yönlendir")]
        Yonlendir = 6,
        [Display(Name = "Bekle")]
        Bekle = 7,
        [Display(Name = "Ekran Oku")]
        EkranOku = 5
    }
}
