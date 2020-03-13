using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using PDFBuilder.Components.Interfaces;
using PDFBuilder.Enums;

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

        /// <summary>
        /// Allows to set the text alignment
        /// </summary>
        public Alignment alignment { get; set; }

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
            paragraph.Format.Alignment = getAlignment();
             

        }

        #endregion Public Methods

        #region Non Public Methods

        /// <summary>
        /// Gets the MigraDoc alignment based on our alignment
        /// </summary>
        private ParagraphAlignment getAlignment()
        {
            switch (this.alignment)
            {
                case Alignment.Left: return ParagraphAlignment.Left;
                case Alignment.Center: return ParagraphAlignment.Center;
                case Alignment.Right: return ParagraphAlignment.Right;
                case Alignment.Justify: return ParagraphAlignment.Justify;
                default: return ParagraphAlignment.Left;
            }
        }

        #endregion Non Public Methods
    }
}
