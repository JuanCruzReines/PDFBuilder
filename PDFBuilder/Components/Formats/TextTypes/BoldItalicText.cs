using MigraDoc.DocumentObjectModel;
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components.TextTypes
{
    public class BoldItalicText : IText
    {

        #region Internal fields

        /// <summary>
        /// Text
        /// </summary>
        private string text;

        #endregion Internal fields

        #region Properties

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public BoldItalicText(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Adds the text to an existing paragraph setting format to bold and italic
        /// </summary>
        public void AddTo(MigraDoc.DocumentObjectModel.Paragraph paragrapgh)
        {
            paragrapgh.AddFormattedText(this.text, TextFormat.Bold | TextFormat.Italic);
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}

