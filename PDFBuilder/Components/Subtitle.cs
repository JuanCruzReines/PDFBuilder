using MigraDoc.DocumentObjectModel;
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components
{
    public class Subtitle : ITextContent
    {

        #region Internal fields

        #endregion Internal fields

        #region Properties

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Subtitle(IText text)
        {
            this.childs.Add(text);
        }

        /// <summary>
        /// Render a subtitle into a section
        /// </summary>
        public override void RenderInto(MigraDoc.DocumentObjectModel.Section section)
        {
            MigraDoc.DocumentObjectModel.Paragraph subtitle = new MigraDoc.DocumentObjectModel.Paragraph();

            subtitle.Style = "Heading2";
            this.RenderTextInto(subtitle);

            section.Add(subtitle);
        }

        /// <summary>
        /// Render a subtitle into a header or footer
        /// </summary>
        public override void RenderInto(HeaderFooter headerFooter)
        {
            MigraDoc.DocumentObjectModel.Paragraph subtitle = new MigraDoc.DocumentObjectModel.Paragraph();

            subtitle.Style = "Heading2";
            this.RenderTextInto(subtitle);

            headerFooter.Add(subtitle);
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}
