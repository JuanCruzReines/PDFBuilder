using MigraDoc.DocumentObjectModel;
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components
{
    public class Title : ITextContent
    {

        #region Internal fields

        #endregion Internal fields

        #region Properties

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Title(IText text)
        {
            this.childs.Add(text);
        }

        /// <summary>
        /// Render a title into a section
        /// </summary>
        public override void RenderInto(MigraDoc.DocumentObjectModel.Section section)
        {
            MigraDoc.DocumentObjectModel.Paragraph title = new MigraDoc.DocumentObjectModel.Paragraph();

            title.Style = "Heading1";
            this.RenderTextInto(title);

            section.Add(title);
        }

        /// <summary>
        /// Render a title into a header or footer
        /// </summary>
        public override void RenderInto(HeaderFooter headerFooter)
        {
            MigraDoc.DocumentObjectModel.Paragraph title = new MigraDoc.DocumentObjectModel.Paragraph();

            title.Style = "Heading1";
            this.RenderTextInto(title);

            headerFooter.Add(title);
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}
