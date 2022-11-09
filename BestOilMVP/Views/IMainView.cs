using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOilMVP.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> LiterRadioButtonClicked { get; set; }
        EventHandler<EventArgs> PriceRadioButtonClicked { get; set; }
        EventHandler<EventArgs> PriceSelectedIndexChanged { get; set; }
        public string LiterTxtB { get; set; }
        public string PriceTxtB { get; set; }

        public bool isActive { get; set; }


    }
}
