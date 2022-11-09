using BestOilMVP.Model;
using BestOilMVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOilMVP.Presenters
{
    public class MainPresenter
    {
        private IMainView _view;


        public MainPresenter(IMainView view)
        {
            _view = view;

            view.LiterRadioButtonClicked += ViewLiterRadioButtonClicked;
            view.PriceRadioButtonClicked += ViewPriceRadioButtonClicked;
            view.PriceSelectedIndexChanged += ViewPriceSelectedIndexChange;
            
        }

        private void ViewLiterRadioButtonClicked(object sender,EventArgs e)
        {

            var btn = sender as RadioButton;
            _view.isActive = false;
            
        }

        private void ViewPriceRadioButtonClicked(object sender,EventArgs e)
        {

        }

        private void ViewLiterTxtBChanged(object sender,EventArgs e)
        {

        }

        private void ViewPriceTxtBChanged(object sender,EventArgs e)
        {

        }

        private void ViewPriceSelectedIndexChange(object sender,EventArgs e)
        {
            
        }

    }
}
