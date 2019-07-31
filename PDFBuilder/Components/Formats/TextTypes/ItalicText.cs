using MigraDoc.DocumentObjectModel;
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components.TextTypes
{
    public class ItalicText : IText
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
        public ItalicText(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Adds the text to an existing paragraph setting format to italic
        /// </summary>
        public void AddTo(MigraDoc.DocumentObjectModel.Paragraph paragrapgh)
        {
            paragrapgh.AddFormattedText(this.text, TextFormat.Italic);
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}

