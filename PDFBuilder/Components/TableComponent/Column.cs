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

        /// <summary>
        /// Column alignment
        /// </summary>
        public Alignment alignment { get; set; }

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
            column.Format.Alignment = this.getAlignment();
        }

        #endregion Public Methods

        #region Non Public Methods

        /// <summary>
        /// Gets the MigraDoc alignment based on our alignment
        /// </summary>
        private ParagraphAlignment getAlignment()
        {
            switch (this.alignment)
            {
                case Alignment.Left: return ParagraphAlignment.Left;
                case Alignment.Center: return ParagraphAlignment.Center;
                case Alignment.Right: return ParagraphAlignment.Right;
                case Alignment.Justify: return ParagraphAlignment.Justify;
                default: return ParagraphAlignment.Left;
            }
        }

        #endregion Non Public Methods

    }
}
