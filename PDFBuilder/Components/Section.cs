using MigraDoc.DocumentObjectModel;
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components
{
    public class Section : IComponent
    {

        #region Internal fields

        #endregion Internal fields

        #region Properties

        /// <summary>
        /// Section header
        /// </summary>
        public Header header { get; set; }

        /// <summary>
        /// Section header height in milimiters
        /// </summary>
        public double? headerHeight { get; set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Returns a section rendered
        /// </summary>
        public DocumentObject Render()
        {
            MigraDoc.DocumentObjectModel.Section section = new MigraDoc.DocumentObjectModel.Section();

            this.childs.ForEach(child => child.RenderInto(section));

            if(this.header != null)
                this.header.RenderInto(section);

            if (this.headerHeight.HasValue)
                section.PageSetup.TopMargin = Unit.FromMillimeter(this.headerHeight.Value);

            section.PageSetup.HeaderDistance = Unit.FromMillimeter(0.8);

            return section;
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods
    }
}
