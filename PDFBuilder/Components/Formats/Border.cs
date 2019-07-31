using MigraDoc.DocumentObjectModel;

namespace PDFBuilder.Components.Formats
{
    public class Border
    {

        #region Internal fields

        /// <summary>
        /// Width in milimeters
        /// </summary>
        private double width;

        /// <summary>
        /// Distance in milimeters
        /// </summary>
        private double distance;

        /// <summary>
        /// Color
        /// </summary>
        private Color color;

        #endregion Internal fields

        #region Properties

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Border(double width, double distance, Color color)
        {
            this.width = width;
            this.distance = distance;
            this.color = color;
        }

        /// <summary>
        /// Render border into paragraph
        /// </summary>
        public void RenderInto(MigraDoc.DocumentObjectModel.Paragraph paragrapgh)
        {
            paragrapgh.Format.Borders.Width = this.width;
            paragrapgh.Format.Borders.Distance = this.distance;
            paragrapgh.Format.Borders.Color = this.color.GetColor();
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}
