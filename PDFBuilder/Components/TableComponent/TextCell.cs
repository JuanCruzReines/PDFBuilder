using MigraDoc.DocumentObjectModel.Tables;
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components.TableComponents
{
    public class TextCell : ICell
    { 

        #region Internal fields

        /// <summary>
        /// Cell text
        /// </summary>
        private string text;

        #endregion Internal fields

        #region Properties

        /// <summary>
        /// Allows to set the text style
        /// </summary>
        public string style { get; set; } = "Normal";

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public TextCell(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Ctor.
        /// </summary>
        public TextCell(string text, string style)
        {
            this.text = text;
            this.style = style;
        }

        /// <summary>
        /// Render this component into a section
        /// </summary>
        public void RenderInto(Cell cell)
        {
            MigraDoc.DocumentObjectModel.Paragraph paragraph = cell.AddParagraph(this.text);

            paragraph.Style = this.style;

        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}
