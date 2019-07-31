using MigraDoc.DocumentObjectModel;

namespace PDFBuilder.Components.Interfaces
{
    public interface IContent
    {
        /// <summary>
        /// Render content into section
        /// </summary>
        void RenderInto(MigraDoc.DocumentObjectModel.Section section);

        /// <summary>
        /// Render content into header
        /// </summary>
        void RenderInto(HeaderFooter headerFooter);
    }
}
