using System;
using System.Web;
using System.Web.UI;
using NbboService;
using System.Collections.Generic;

namespace NBBO_UI
{

    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
            try
            {
                PricesGenerator priceGenerator = new PricesGenerator(NBBOService.getInstance());
                priceGenerator.Start();

                // button1.Text = "You clicked me";

                button1.Style.Add("display", "none");
                buttonFetch.Visible = true;
                txtTicker.Visible = true;
                lbltext.Visible = true;
            }
            catch(Exception ex){
                Console.WriteLine("Error in an application " + ex.Message);
            }
        }

        public void buttonFetchClicked(object sender, EventArgs args)
        {
            try
            {
                string ticker = txtTicker.Text.ToUpper();
                List<Order> lst = (List<Order>)NbboService.NBBOService.getInstance().GetMarketData(ticker);
                if(lst.Count==0)
                {
                    lblError.Visible = true;
                    lblError.Text = "Please try some other ticker";

                }
                    
                NBBO nBBO = (NBBO)NbboService.NBBOService.getInstance().GetNbboData(ticker);

                List<NBBO> lstNBBO = new List<NBBO>();
                lstNBBO.Add(nBBO);

                dgDataGrid.DataSource = lst;
                dgDataGrid.DataBind();
                dgNBBOGrid.DataSource = lstNBBO;
                dgNBBOGrid.DataBind();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in an application " + ex.Message);
                lblError.Visible = true;
                lblError.Text = "Please try some other ticker";
            }
        }


    }
}
