using MigraDoc.DocumentObjectModel;

namespace PDFBuilder.Components.Formats
{
    public class Shading
    {

        #region Internal fields

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
        public Shading(Color color)
        {
            this.color = color;
        }

        /// <summary>
        /// Render shading into an existing paragraphd
        /// </summary>
        public void RenderInto(MigraDoc.DocumentObjectModel.Paragraph paragrapgh)
        {

            paragrapgh.Format.Shading.Color = this.color.GetColor();
        }

        #endregion Public Methods

        #region Non Public Methods


        #endregion Non Public Methods
    }
}
