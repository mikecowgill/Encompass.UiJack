using Encompass.UiJack.UiProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encompass.UIJack
{

    public delegate void HomeUiLoadedHandler(object source, HomeUiLoadedEventArgs e);
    public delegate void PipelineUiLoadedHandler(object source, PipelineUiLoadedEventArgs e);
    public delegate void LoanUiLoadedHandler(object source, LoanUiLoadedEventArgs e);

    public class HomeUiLoadedEventArgs : EventArgs
    {
        private HomeUi homeUi;
        public HomeUiLoadedEventArgs(HomeUi homeUi)
        {
            this.homeUi = homeUi;
        }
        public HomeUi HomeUi
        {
            get { return homeUi; }
        }
    }

    public class PipelineUiLoadedEventArgs : EventArgs
    {
        private PipelineUi pipelineUi;
        public PipelineUiLoadedEventArgs(PipelineUi pipelineUi)
        {
            this.pipelineUi = pipelineUi;
        }
        public PipelineUi PipelineUi
        {
            get { return pipelineUi; }
        }
    }

    public class LoanUiLoadedEventArgs : EventArgs
    {
        private LoanUi loanUi;
        public LoanUiLoadedEventArgs(LoanUi loanUi)
        {
            this.loanUi = loanUi;
        }
        public LoanUi LoanUi
        {
            get { return loanUi; }
        }
    }

    
}
