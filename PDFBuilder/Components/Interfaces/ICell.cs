using MigraDoc.DocumentObjectModel.Tables;

namespace PDFBuilder.Components.Interfaces
{
    public interface ICell
    {
        /// <summary>
        /// Render text or image into a cell
        /// </summary>
        void RenderInto(Cell cell);
    }
}
