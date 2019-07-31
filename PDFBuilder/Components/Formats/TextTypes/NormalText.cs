
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components.TextTypes
{
    public class NormalText : IText
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
        public NormalText(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Adds the text to an existing paragraph without special format
        /// </summary>
        public void AddTo(MigraDoc.DocumentObjectModel.Paragraph paragrapgh)
        {
            paragrapgh.AddText(this.text);
        }


        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}

