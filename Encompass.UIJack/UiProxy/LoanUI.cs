using EllieMae.EMLite.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encompass.UiJack.UiProxy
{
    public class LoanUi
    {

        private EllieMae.EMLite.MainUI.s mainUi;
        private EllieMae.EMLite.MainUI.f loanUi;

        public LoanUi(EllieMae.EMLite.MainUI.s mainUi)
        {
            this.mainUi = mainUi;
            loanUi = mainUi.AllControls<EllieMae.EMLite.MainUI.f>().FirstOrDefault(f => f.Name == "LoanPage");
        }

        public EllieMae.EMLite.MainUI.f LoanUiControl
        {
            get { 
                return loanUi;
            }
        }

        public GradientPanel LoanToolbarMain
        {
            get { return loanUi.AllControls<GradientPanel>().FirstOrDefault(f => f.Name == "pnlHeader"); }
        }

        public FlowLayoutPanel LoanToolbarRight
        {
            get { return loanUi.AllControls<FlowLayoutPanel>().FirstOrDefault(f => f.Name == "flowLayoutPanel1"); }
        }

        public TabControl FormToolServicesTabControl
        {
            get { return loanUi.AllControls<TabControl>().FirstOrDefault(f => f.Name == "toolsFormsTabControl"); }
        }

        public EllieMae.EMLite.Common.UI.u FormsListbox
        {
            get { return loanUi.AllControls<EllieMae.EMLite.Common.UI.u>().FirstOrDefault(f => f.Name == "emFormMenuBox"); }
        }

        public EllieMae.EMLite.Common.UI.u ToolsListbox
        {
            get { return loanUi.AllControls<EllieMae.EMLite.Common.UI.u>().FirstOrDefault(f => f.Name == "emToolMenuBox"); }
        }

        public EllieMae.EMLite.ePass.Services.d ServicesListbox
        {
            get { return loanUi.AllControls<EllieMae.EMLite.ePass.Services.d>().FirstOrDefault(f => f.Name == "EpassCategoryControl"); }
        }

        public System.Windows.Forms.Panel LoanFormPanel
        {
            get { return loanUi.AllControls<System.Windows.Forms.Panel>().FirstOrDefault(f => f.Name == "rightPanel"); }
        }

    }
}
