using EllieMae.EMLite.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encompass.UiJack.UiProxy
{
    public class PipelineUi
    {

        private EllieMae.EMLite.MainUI.s mainUi;

        public PipelineUi(EllieMae.EMLite.MainUI.s mainUi)
        {
            this.mainUi = mainUi;
        }
        
        public EllieMae.EMLite.MainUI.q PipelineScreen
        {
            get { return mainUi.AllControls<EllieMae.EMLite.MainUI.q>().FirstOrDefault(f => f.Name == "PipelineScreen"); }
        }

        public EllieMae.EMLite.UI.GridView PipelineGrid
        {
            get { return PipelineScreen.AllControls<EllieMae.EMLite.UI.GridView>().FirstOrDefault(f => f.Name == "gvLoans"); }
        }

        public EllieMae.EMLite.UI.GradientPanel PipelineViewToolbar
        {
            get { return PipelineScreen.AllControls<EllieMae.EMLite.UI.GradientPanel>().FirstOrDefault(f => f.Name == "gradientPanel1"); }
        }

        public EllieMae.EMLite.UI.GradientPanel PipelineLoanFolderToolbar
        {
            get { return PipelineScreen.AllControls<EllieMae.EMLite.UI.GradientPanel>().FirstOrDefault(f => f.Name == "gradientPanel2"); }
        }
        public EllieMae.EMLite.UI.GradientPanel PipelineMiddleToolbar
        {
            get { return PipelineScreen.AllControls<EllieMae.EMLite.UI.GradientPanel>().FirstOrDefault(f => f.Name == "gradientPanel3"); }
        }
        public System.Windows.Forms.FlowLayoutPanel PipelineLowerToolbar
        {
            get { return PipelineScreen.AllControls<System.Windows.Forms.FlowLayoutPanel>().FirstOrDefault(f => f.Name == "flowLayoutPanel1"); }
        }

    }
}
