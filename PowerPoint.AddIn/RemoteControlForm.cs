﻿using System;
using System.Windows.Forms;

namespace PowerPoint.AddIn
{
    public partial class RemoteControlForm : Form
    {
        IRemoteControl _addin;

        public RemoteControlForm()
        {
            InitializeComponent();
        }

        public RemoteControlForm(IRemoteControl addin) : this()
        {
            _addin = addin;
        }

        internal string Notes
        {
            set
            {
                Action setText = () => _notes.Text = value;
                if(InvokeRequired)
                {
                    Invoke(setText);
                }
                else
                {
                    setText();
                }
            }
        }

        private void OnStop(object sender, EventArgs e)
        {
            _addin.StopPresentation();
        }

        private void OnPrev(object sender, EventArgs e)
        {
            _addin.PreviousSlide();
        }

        private void OnNext(object sender, EventArgs e)
        {
            _addin.NextSlide();
        }
    }
}
