using EllieMae.Encompass.Automation;
using Encompass.UiJack.UiProxy;
using Encompass.UIJack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encompass.UiJack
{
    public class UiJackMain
    {
        
        public event HomeUiLoadedHandler HomeUiLoaded;
        public event PipelineUiLoadedHandler PipelineUiLoaded;
        public event LoanUiLoadedHandler LoanUiLoaded;

        public UiJackMain()
        {

            mainUi = new MainUi();
            var mainTabs = mainUi.MainTabs;
            
            foreach (TabPage tabPage in mainTabs.TabPages)
            {
                tabPage.ControlAdded += TabPage_ControlAdded;
            }

            mainTabs.ControlAdded += mainTabs_ControlAdded;
            mainTabs.ControlRemoved += mainTabs_ControlRemoved;
         
            
        }

        private void mainTabs_ControlAdded(object sender, ControlEventArgs e)
        {
            if (e.Control is TabPage)
            {
                TabPage tabPage = e.Control as TabPage;
                tabPage.ControlAdded += TabPage_ControlAdded;

                RaiseLoadedEvent(tabPage);
            }
        }

        private void mainTabs_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control is TabPage)
            {
                TabPage tabPage = e.Control as TabPage;
                tabPage.ControlAdded -= TabPage_ControlAdded;
            }
        }
        
        private void TabPage_ControlAdded(object sender, ControlEventArgs e)
        {

            TabPage tab = sender as TabPage;
            RaiseLoadedEvent(tab);

        }

        private void RaiseLoadedEvent(TabPage tab)
        {
            switch (tab.Text)
            {
                case "Home":
                    if (!isHomeLoaded)
                    {
                        if (HomeUiLoaded != null)
                        {
                            HomeUiLoaded(this, new HomeUiLoadedEventArgs(HomeUi));
                        }
                        isHomeLoaded = true;
                    }
                    break;
                case "Pipeline":
                    if (!isPipelineLoaded)
                    {
                        if (PipelineUiLoaded != null)
                        {
                            PipelineUiLoaded(this, new PipelineUiLoadedEventArgs(PipelineUi));
                        }
                        isPipelineLoaded = true;
                    }
                    break;
                case "Loan":
                    if (!isLoanLoaded)
                    {
                        if (LoanUiLoaded != null)
                        {
                            LoanUiLoaded(this, new LoanUiLoadedEventArgs(LoanUi));
                        }
                        isLoanLoaded = true;
                    }
                    break;
                case "Trades":
                    break;
                case "Contacts":
                    break;
                case "Reports":
                    break;
                case "Dashboard":
                    break;
            }
        }
        

        private bool isPipelineLoaded;
        private PipelineUi pipelineUi;
        public PipelineUi PipelineUi
        {
            get { 
                
                if (pipelineUi == null)
                {
                    pipelineUi = new PipelineUi(mainUi.MainUiControl);
                }
                return pipelineUi; 
            }
        }

        private bool isHomeLoaded;
        private HomeUi homeUi;
        public HomeUi HomeUi
        {
            get
            {

                if (homeUi == null)
                {
                    homeUi = new HomeUi(mainUi.MainUiControl);
                }
                return homeUi;
            }
        }

        private bool isLoanLoaded;
        private LoanUi loanUi;
        public LoanUi LoanUi
        {
            get
            {

                if (loanUi == null)
                {
                    loanUi = new LoanUi(mainUi.MainUiControl);
                }
                return loanUi;
            }
        }

        MainUi mainUi;
        public MainUi MainUi
        {
            get
            {

                if (mainUi == null)
                {
                    mainUi = new MainUi();
                }
                return mainUi;
            }
        }
        
    }
}
