using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using PDFBuilder.Components.Interfaces;
using PDFBuilder.Enums;

namespace PDFBuilder.Components
{
    public class Image : IContent, ICell
    {

        #region Internal fields

        /// <summary>
        /// Image Path
        /// </summary>
        private string path;

        /// <summary>
        /// Image width in milimeters
        /// </summary>
        private double width;

        /// <summary>
        /// Image height in milimeters
        /// </summary>
        private double height;

        #endregion Internal fields

        #region Properties

        /// <summary>
        /// Image alignment
        /// </summary>
        public Alignment alignment { get; set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Image(string path, double height, double width)
        {
            this.path = path;
            this.height = height;
            this.width = width;
        }

        /// <summary>
        /// Render a image into a section
        /// </summary>
        public void RenderInto(MigraDoc.DocumentObjectModel.Section section)
        {
            MigraDoc.DocumentObjectModel.Shapes.Image image = this.CreateImage();

            section.Add(image);
        }

        /// <summary>
        /// Render a image into a header or footer
        /// </summary>
        public void RenderInto(HeaderFooter headerFooter)
        {
            MigraDoc.DocumentObjectModel.Shapes.Image image = this.CreateImage();

            headerFooter.Add(image);
        }

        /// <summary>
        /// Render a image into a table cell
        /// </summary>
        public void RenderInto(Cell cell)
        {
            MigraDoc.DocumentObjectModel.Paragraph paragraph = cell.AddParagraph();
            paragraph.Add(this.CreateImage());
            paragraph.Format.Alignment = GetAlignment();
        }

        #endregion Public Methods

        #region Non Public Methods

        /// <summary>
        /// Creates a MigraDoc image component based on properties
        /// </summary>
        private MigraDoc.DocumentObjectModel.Shapes.Image CreateImage()
        {
            MigraDoc.DocumentObjectModel.Shapes.Image image = new MigraDoc.DocumentObjectModel.Shapes.Image();

            image.Name = this.path;
            image.Height = Unit.FromMillimeter(this.height);
            image.Width = Unit.FromMillimeter(this.width);
            image.Left = this.GetPosition();
            image.WrapFormat.DistanceBottom = Unit.FromMillimeter(5);

            return image;
        }

        /// <summary>
        /// Gets the MigraDoc ShapePosition based on our alignment
        /// </summary>
        private ShapePosition GetPosition()
        {
            switch (this.alignment)
            {
                case Alignment.Left: return ShapePosition.Left;
                case Alignment.Center: return ShapePosition.Center;
                case Alignment.Right: return ShapePosition.Right;
                default: return ShapePosition.Left;
            }
        }

        /// <summary>
        /// Gets the MigraDoc alignment based on our alignment
        /// </summary>
        private ParagraphAlignment GetAlignment()
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
