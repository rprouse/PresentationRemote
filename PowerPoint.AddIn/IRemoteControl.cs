namespace PowerPoint.AddIn
{
    public interface IRemoteControl
    {
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
