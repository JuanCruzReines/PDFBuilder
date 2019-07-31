using MigraDoc.DocumentObjectModel.Tables;

namespace PDFBuilder.Components.Interfaces
{
    public interface ITableComponent
    {
        /// <summary>
        /// Render row or column into table
        /// </summary>
        void RenderInto(MigraDoc.DocumentObjectModel.Tables.Table table);
    }
}
