using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components.TableComponents
{
    public class ImageCell : ICell
    {

        #region Internal fields

        /// <summary>
        /// Image path
        /// </summary>
        private string path;

        /// <summary>
        /// Image height
        /// </summary>
        private double height;

        /// <summary>
        /// Image width
        /// </summary>
        private double width;

        #endregion Internal fields

        #region Properties

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public ImageCell(string path, double height, double width)
        {
            this.path = path;
            this.height = height;
            this.width = width;
        }

        /// <summary>
        /// Render this component into a section
        /// </summary>
        public void RenderInto(Cell cell)
        {
            MigraDoc.DocumentObjectModel.Shapes.Image image = new MigraDoc.DocumentObjectModel.Shapes.Image();

            image.Name = this.path;
            image.Height = Unit.FromMillimeter(this.height);
            image.Width = Unit.FromMillimeter(this.width);

            cell.Add(image);
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}
