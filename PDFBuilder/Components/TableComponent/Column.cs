using MigraDoc.DocumentObjectModel;
using PDFBuilder.Components.Interfaces;
using PDFBuilder.Enums;

namespace PDFBuilder.Components.TableComponents
{
    public class Column : ITableComponent
    {

        #region Internal fields

        /// <summary>
        /// Column width in milimiters
        /// </summary>
        private double width;

        #endregion Internal fields

        #region Properties

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Column(double width)
        {
            this.width = width;
        }

        /// <summary>
        /// Render column into the table
        /// </summary>
        public void RenderInto(MigraDoc.DocumentObjectModel.Tables.Table table)
        {
            MigraDoc.DocumentObjectModel.Tables.Column column = table.AddColumn();

            column.Width = Unit.FromMillimeter(this.width);
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods

    }
}
