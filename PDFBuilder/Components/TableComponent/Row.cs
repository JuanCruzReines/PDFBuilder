using MigraDoc.DocumentObjectModel.Tables;
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components.TableComponents
{
    public class Row : ITableComponent
    {

        #region Internal fields

        /// <summary>
        /// Row values
        /// </summary>
        private ICell[] values;

        #endregion Internal fields

        #region Properties

        /// <summary>
        /// Row color
        /// </summary>
        public Components.Formats.Color color { get; set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Row(ICell[] values)
        {
            this.values = values;
        }

        /// <summary>
        /// Render row into the table
        /// </summary>
        public void RenderInto(MigraDoc.DocumentObjectModel.Tables.Table table)
        {
            MigraDoc.DocumentObjectModel.Tables.Row row = table.AddRow();

            for (int i = 0; i < this.values.Length; i++)
            {
                Cell cell = row.Cells[i];
                cell.VerticalAlignment = VerticalAlignment.Center;
                cell.Format.Alignment = cell.Column.Format.Alignment;

                this.values[i].RenderInto(cell);
            }

            if(this.color != null)
                row.Shading.Color = this.color.GetColor();
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods

    }
}
