using MigraDoc.DocumentObjectModel;

namespace PDFBuilder.Components.Interfaces
{
    public interface IText
    {
        /// <summary>
        /// Adds a text with format to a paragraph
        /// </summary>
        void AddTo(MigraDoc.DocumentObjectModel.Paragraph paragrapgh);
    }
}
