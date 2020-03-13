
namespace PDFBuilder.Components.Formats
{
    public class Color
    {

        #region Internal fields

        /// <summary>
        /// Color in hexadecimal
        /// </summary>
        private string Colorhex; 

        #endregion Internal fields

        #region Properties

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Color(string color)
        {
            this.Colorhex = color;
        }

        /// <summary>
        /// Creates a MigraDoc Color based on RGB values
        /// </summary>
        public MigraDoc.DocumentObjectModel.Color GetColor()
        {
            return MigraDoc.DocumentObjectModel.Color.Parse(this.Colorhex);
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}
