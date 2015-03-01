using EllieMae.EMLite.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encompass.UiJack.UiProxy
{
    public class HomeUi
    {

        private EllieMae.EMLite.MainUI.s mainUi;

        public HomeUi(EllieMae.EMLite.MainUI.s mainUi)
        {

            this.mainUi = mainUi;

        }
        
        public EllieMae.EMLite.ePass.k HomePageBrowser
        {
            get { return mainUi.AllControls<EllieMae.EMLite.ePass.k>().FirstOrDefault(f => f.Name == "homePageBrowser"); }
        }

        
    }
}
