using MigraDoc.DocumentObjectModel;
using PDFBuilder.Components.Interfaces;
using PDFBuilder.Components.TableComponents;
using System.Collections.Generic;

namespace PDFBuilder.Components
{
    public class Table : IContent
    {

        #region Internal fields

        /// <summary>
        /// Table columns
        /// </summary>
        private List<Column> columns;

        /// <summary>
        /// Table rows
        /// </summary>
        private List<Row> rows = new List<Row>();

        #endregion Internal fields

        #region Properties

        /// <summary>
        /// Enable and disable table borders
        /// </summary>
        public bool showBorders { get; set; } = true;

        /// <summary>
        /// Rows height in milimiters
        /// </summary>
        public double? rowHeight { get; set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Table(List<Column> columns)
        {
            this.columns = columns;
        }

        /// <summary>
        /// Render table into section
        /// </summary>
        public void RenderInto(MigraDoc.DocumentObjectModel.Section section)
        {
            MigraDoc.DocumentObjectModel.Tables.Table table = section.AddTable();

            this.RenderComponents(table);
        }

        /// <summary>
        /// Render table into header or footer
        /// </summary>
        public void RenderInto(HeaderFooter headerFooter)
        {
            MigraDoc.DocumentObjectModel.Tables.Table table = headerFooter.AddTable();

            this.RenderComponents(table);
        }

        /// <summary>
        /// Adds a row
        /// </summary>
        public void AddRow(Row row)
        {
            this.rows.Add(row);
        }

        /// <summary>
        /// Removes a row
        /// </summary>
        public void RemoveRow(Row row)
        {
            this.rows.Remove(row);
        }

        #endregion Public Methods

        #region Non Public Methods

        /// <summary>
        /// Creates a MigraDoc table object from its components
        /// </summary>
        public void RenderComponents(MigraDoc.DocumentObjectModel.Tables.Table table)
        {
            this.columns.ForEach(columns => columns.RenderInto(table));

            this.rows.ForEach(row => row.RenderInto(table));

            table.Borders.Visible = this.showBorders;

            if (this.rowHeight.HasValue)
                table.Rows.Height = Unit.FromMillimeter(this.rowHeight.Value);
        }

        #endregion Non Public Methods

    }
}
