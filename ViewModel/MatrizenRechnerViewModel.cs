using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MatrizenRechner.ViewModel
{
    // das ist das main View model, welches als data context an das fenster gebunden wird
    public class MatrizenRechnerViewModel : ViewModelBase
    {
        public MatrizenRechner_ViewMainBodyDisplayViewModel MatrizenRechner_ViewMainBodyDisplayViewModel { get; }
        public MatrizenRechner_ViewNavbarViewModel MatrizenRechner_ViewNavbarViewModel { get; }
        public ICommand AddMatrixCommand { get; }

        public MatrizenRechnerViewModel()
        {
            MatrizenRechner_ViewMainBodyDisplayViewModel = new MatrizenRechner_ViewMainBodyDisplayViewModel();
            MatrizenRechner_ViewNavbarViewModel = new MatrizenRechner_ViewNavbarViewModel();
        }
    }
}
