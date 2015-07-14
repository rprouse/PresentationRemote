using System;

namespace PowerPoint.AddIn
{
    public delegate void NotesChangedEventHandler(object sender, NotesChangedEventArgs args);

    public class NotesChangedEventArgs : EventArgs
    {
        public NotesChangedEventArgs(string notes)
        {
            Notes = notes;
        }

        /// <summary>
        /// The changed notes
        /// </summary>
        public string Notes { get; private set; }
    }

    public interface IRemoteControl
    {
        /// <summary>
        /// Indicates that the notes for the slide have
        /// changed, likely because the slide has changed
        /// </summary>
        event NotesChangedEventHandler NotesChanged;

        /// <summary>
        /// Advances to the next slide
        /// </summary>
        void NextSlide();

        /// <summary>
        /// Shows the previous slide
        /// </summary>
        void PreviousSlide();

        /// <summary>
        /// Stops the presentation
        /// </summary>
        void StopPresentation();
    }
}
