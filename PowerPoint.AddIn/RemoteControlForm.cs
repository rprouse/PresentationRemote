using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPoint.AddIn
{
    public partial class RemoteControlForm : Form
    {
        RemoteControlAddin _addin;

        public RemoteControlForm()
        {
            InitializeComponent();
        }

        public RemoteControlForm(RemoteControlAddin addin) : this()
        {
            _addin = addin;
        }

        private void OnStop(object sender, EventArgs e)
        {
            _addin.StopPresentation();
        }

        private void OnPrev(object sender, EventArgs e)
        {
            _addin.PrevSlide();
        }

        private void OnNext(object sender, EventArgs e)
        {
            _addin.NextSlide();
        }
    }
}
