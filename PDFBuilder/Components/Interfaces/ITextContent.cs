using System.Collections.Generic;
using MigraDoc.DocumentObjectModel;
using PDFBuilder.Enums;

namespace PDFBuilder.Components.Interfaces
{
    public abstract class ITextContent : IContent
    {

        #region Internal fields

        /// <summary>
        /// List of child components
        /// </summary>
        protected List<IText> childs = new List<IText>();

        #endregion Internal fields

        #region Properties

        /// <summary>
        /// Image alignment
        /// </summary>
        public Alignment alignment { get; set; }

        #endregion Properties

        #region Public Methods

        /// <summary>
        /// Add a child component
        /// </summary>
        public void AddText(IText child)
        {
            this.childs.Add(child);
        }

        /// <summary>
        /// Remove a child component
        /// </summary>
        public void RemoveText(IText child)
        {
            this.childs.Remove(child);
        }

        /// <summary>
        /// Interface for rendering into a section
        /// </summary>
        public abstract void RenderInto(MigraDoc.DocumentObjectModel.Section section);

        /// <summary>
        /// Interface for rendering into a header
        /// </summary>
        public abstract void RenderInto(HeaderFooter headerFooter);

        #endregion Public Methods

        #region Non Public Methods

        /// <summary>
        /// Renders text components into a paragraph
        /// </summary>
        protected void RenderTextInto(MigraDoc.DocumentObjectModel.Paragraph paragraph)
        {
            this.childs.ForEach(text => text.AddTo(paragraph));
        }

        /// <summary>
        /// Gets the MigraDoc alignment based on our alignment
        /// </summary>
        protected ParagraphAlignment GetPosition()
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

