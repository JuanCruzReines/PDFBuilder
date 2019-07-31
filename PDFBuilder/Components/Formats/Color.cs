
namespace PDFBuilder.Components.Formats
{
    public class Color
    {

        #region Internal fields

        /// <summary>
        /// Red component
        /// </summary>
        private byte r;

        /// <summary>
        /// Green component
        /// </summary>
        private byte g;

        /// <summary>
        /// Blue component
        /// </summary>
        private byte b;

        #endregion Internal fields

        #region Properties

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Color(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        /// <summary>
        /// Creates a MigraDoc Color based on RGB values
        /// </summary>
        public MigraDoc.DocumentObjectModel.Color GetColor()
        {
            return new MigraDoc.DocumentObjectModel.Color(r, g, b);
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}
