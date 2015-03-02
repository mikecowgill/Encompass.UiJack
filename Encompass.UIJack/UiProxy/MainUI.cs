using EllieMae.EMLite.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encompass.UiJack.UiProxy
{
    public class MainUi
    {

        public MainUi()
        {

            Process p = Process.GetCurrentProcess();
            IntPtr handle = p.MainWindowHandle;

            mainUI = (EllieMae.EMLite.MainUI.s)Control.FromHandle(handle);

        }

        private EllieMae.EMLite.MainUI.s mainUI;
        public EllieMae.EMLite.MainUI.s MainUiControl
        {
            get { return mainUI; }
        }

        public GradientMenuStrip MainMenu
        {
            get { return mainUI.AllControls<GradientMenuStrip>().FirstOrDefault(f => f.Name == "mainMenu"); }
        }

        public TabControl MainTabs
        {
            get { return mainUI.AllControls<TabControl>().FirstOrDefault(f => f.Name == "tabControl"); }
        }
                
    }
}
