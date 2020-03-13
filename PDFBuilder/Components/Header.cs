using MigraDoc.DocumentObjectModel;
using PDFBuilder.Components.Interfaces;

namespace PDFBuilder.Components
{
    public class Header : IComponent
    {

        #region Internal fields

        #endregion Internal fields

        #region Properties

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Renders content into section header
        /// </summary>
        public void RenderInto(MigraDoc.DocumentObjectModel.Section section)
        {
            HeaderFooter header = section.Headers.Primary;
            header.Format.SpaceBefore = Unit.FromMillimeter(50);

            this.childs.ForEach(child => child.RenderInto(header));
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion Non Public Methods

    }
}
