using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EllieMae.Encompass.ComponentModel;
using EllieMae.Encompass.Automation;
using EllieMae.Encompass.BusinessObjects.Loans;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using Encompass.UiJack.UiProxy;
using Encompass.UIJack;

namespace Encompass.UiJack
{
    [Plugin]
    public class PluginMain
    {

        UiJackMain uiJack;
        
        public PluginMain()
        {

            uiJack = new UiJackMain();
            uiJack.PipelineUiLoaded += uiJack_PipelineUiLoaded;
            uiJack.LoanUiLoaded += uiJack_LoanUiLoaded;

            var tabs = uiJack.MainUi.MainTabs;
            
            AddCustomTab(tabs);

        }

        private void uiJack_LoanUiLoaded(object source, LoanUiLoadedEventArgs e)
        {

            Button b = new Button();
            b.Text = "This is a test";
            b.Width = 200;
            e.LoanUi.LoanToolbarRight.Controls.Add(b);

        }
        
        private void uiJack_PipelineUiLoaded(object source, PipelineUiLoadedEventArgs e)
        {

            Button b = new Button();
            b.Text = "Test";
            e.PipelineUi.PipelineLowerToolbar.Controls.Add(b);

        }
        
        private static void AddCustomTab(TabControl tabs)
        {
            TabPage tab = new TabPage();
            tab.Name = "tabTest";
            tab.Text = "Test";


            Panel pnl = new Panel();
            pnl.Name = "testPanel";
            pnl.Dock = DockStyle.Fill;
            pnl.AutoSize = true;
            pnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            tab.Controls.Add(pnl);

            tabs.TabPages.Add(tab);

            tabs.SelectedTab = tab;
        }
   
    }

}
