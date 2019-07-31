using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components
{
    public class Paragraph : ITextContent, ICell
    {

        #region Internal fields

        #endregion Internal fields

        #region Properties

        /// <summary>
        /// Paragraph border
        /// </summary>
        public Formats.Border border { get; set; }

        /// <summary>
        /// Paragraph shading
        /// </summary>
        public Formats.Shading shading { get; set; }

        /// <summary>
        /// Paragraph style
        /// </summary>
        public string style { get; set; } = "Normal";

        #endregion Properties

        #region Custom Events

        #endregion Custom Events

        #region Events methods

        #endregion Events methods

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Paragraph(IText text)
        {
            this.childs.Add(text);
        }

        /// <summary>
        /// Render a paragraph into a section
        /// </summary>
        public override void RenderInto(MigraDoc.DocumentObjectModel.Section section)
        {
            MigraDoc.DocumentObjectModel.Paragraph paragraph = this.Create();

            section.Add(paragraph);
        }

        /// <summary>
        /// Render a paragraph into a header or footer
        /// </summary>
        public override void RenderInto(HeaderFooter headerFooter)
        {
            MigraDoc.DocumentObjectModel.Paragraph paragraph = this.Create();

            headerFooter.Add(paragraph);
        }

        /// <summary>
        /// Render a paragraph into a table cell
        /// </summary>
        public void RenderInto(Cell cell)
        {
            cell.Add(this.Create());
        }

        #endregion Public Methods

        #region Non Public Methods

        /// <summary>
        /// Creates a MigraDoc paragraph component based on properties
        /// </summary>
        private MigraDoc.DocumentObjectModel.Paragraph Create()
        {
            MigraDoc.DocumentObjectModel.Paragraph paragraph = new MigraDoc.DocumentObjectModel.Paragraph();

            paragraph.Style = this.style;
            this.RenderTextInto(paragraph);

            paragraph.Format.Alignment = this.GetPosition();

            if (this.border != null)
                this.border.RenderInto(paragraph);

            if(this.shading != null)
                this.shading.RenderInto(paragraph);

            return paragraph;
        }

        #endregion Non Public Methods
    }
}
