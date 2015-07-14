using System;
using System.Windows.Forms;

namespace PowerPoint.AddIn
{
    public partial class RemoteControlForm : Form
    {
        IRemoteControl _remote;

        public RemoteControlForm()
        {
            InitializeComponent();
        }

        public RemoteControlForm(IRemoteControl remote) : this()
        {
            _remote = remote;
            _remote.NotesChanged += OnNotesChanged;
        }

        private void OnNotesChanged(object sender, NotesChangedEventArgs args)
        {
            Action setText = () => _notes.Text = args.Notes;
            if(InvokeRequired)
                Invoke(setText);
            else
                setText();
        }

        private void OnStop(object sender, EventArgs e)
        {
            _remote.StopPresentation();
        }

        private void OnPrev(object sender, EventArgs e)
        {
            _remote.PreviousSlide();
        }

        private void OnNext(object sender, EventArgs e)
        {
            _remote.NextSlide();
        }
    }
}
