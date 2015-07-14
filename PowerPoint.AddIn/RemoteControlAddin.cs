using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.Runtime.InteropServices;

namespace PowerPoint.AddIn
{
    public partial class RemoteControlAddin
    {
        RemoteControlForm _form;
        SlideShowWindow _win;

        private void OnStartup(object sender, System.EventArgs e)
        {
            _form = new RemoteControlForm(this);

            Application.SlideShowBegin += OnSlideShowBegin;
            Application.SlideShowEnd += OnSlideShowEnd;
            Application.SlideShowNextSlide += OnNextSlide;
        }

        private void OnShutdown(object sender, System.EventArgs e)
        {
            if (_form != null)
            {
                _form.Dispose();
                _form = null;
            }

            Application.SlideShowBegin -= OnSlideShowBegin;
            Application.SlideShowEnd -= OnSlideShowEnd;
            Application.SlideShowNextSlide -= OnNextSlide;
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Startup += OnStartup;
            Shutdown += OnShutdown;
        }

        private void OnNextSlide(SlideShowWindow window)
        {
            if (_form != null)
            {
                _form.Notes = GetNotes(window.View.Slide);
            }
        }

        private void OnSlideShowBegin(SlideShowWindow window)
        {
            _win = window;
            if(_form != null)
            {
                _form.Show();
            }
        }

        private void OnSlideShowEnd(Presentation presentation)
        {
            _win = null;
            if (_form != null)
            {
                _form.Hide();
            }
        }

        private string GetNotes(Slide slide)
        {
            if (slide.HasNotesPage == Office.MsoTriState.msoFalse)
                return string.Empty;
            
            foreach(Shape shape in slide.NotesPage.Shapes)
            {
                if(shape.Type == Office.MsoShapeType.msoPlaceholder &&
                   shape.PlaceholderFormat.Type == PpPlaceholderType.ppPlaceholderBody )
                {
                    return shape.TextFrame.TextRange.Text;
                }
            }
            return string.Empty;
        }

        #endregion

        #region Public Methods

        internal void NextSlide()
        {
            if( _win != null )
            {
                _win.View.Next();
            }
        }

        internal void PrevSlide()
        {
            if (_win != null)
            {
                _win.View.Previous();
            }
        }

        internal void StopPresentation()
        {
            if (_win != null)
            {
                _win.View.Exit();
            }
        }

        #endregion
    }
}
