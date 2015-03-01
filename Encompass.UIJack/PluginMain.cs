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
            uiJack.HomeUiLoaded += uiJack_HomeUiLoaded;
            uiJack.LoanUiLoaded += uiJack_LoanUiLoaded;

            var tabs = uiJack.MainUi.MainTabs;
            var menu = uiJack.MainUi.MainMenu;

            //menu.Items.Add("New Menu Item");
            //AddCustomTab(tabs);

            EncompassApplication.Login += EncompassApplication_Login;

            var test = uiJack.HomeUi.HomePageBrowser;
            test.Enabled = false;
        }

        private void uiJack_LoanUiLoaded(object source, LoanUiLoadedEventArgs e)
        {

            Button b = new Button();
            b.Text = "This is a test";

            e.LoanUi.LoanToolbarRight.Controls.Add(b);

        }

        private void uiJack_HomeUiLoaded(object source, HomeUiLoadedEventArgs e)
        {
            var test = e.HomeUi.HomePageBrowser;
            test.Enabled = false;
            
        }

        private void uiJack_PipelineUiLoaded(object source, PipelineUiLoadedEventArgs e)
        {
            Button b = new Button();
            b.Text = "This is a test";

            e.PipelineUi.PipelineMiddleToolbar.Controls.Add(b);

        }

        void EncompassApplication_LoanClosing(object sender, EventArgs e)
        {
            
        }

        void EncompassApplication_LoanOpened(object sender, EventArgs e)
        {

        }
        
        private void EncompassApplication_Login(object sender, EventArgs e)
        {

            
            
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

            tabs.TabPages.Insert(0, tab);

            tabs.SelectedTab = tab;
        }
   
    }
}
