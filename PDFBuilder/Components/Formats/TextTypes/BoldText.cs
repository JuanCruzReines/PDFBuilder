using MigraDoc.DocumentObjectModel;
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components.TextTypes
{
    public class BoldText : IText
    {

        #region Internal fields

        /// <summary>
        /// Text
        /// </summary>
        private string text;

        #endregion Internal fields

        #region Properties

        #endregion Properties

        #region Custom Events

        #endregion Custom Events

        #region Events methods

        #endregion Events methods

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public BoldText(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Adds the text to an existing paragraph setting format to bold
        /// </summary>
        public void AddTo(MigraDoc.DocumentObjectModel.Paragraph paragrapgh)
        {
            paragrapgh.AddFormattedText(this.text, TextFormat.Bold);
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}

