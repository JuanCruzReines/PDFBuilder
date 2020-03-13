using PDFBuilder.Components;
using PdfSharp.Pdf;
using System.Collections.Generic;

namespace PDFBuilder
{
    public class Document
    {
        #region Internal Fields

        /// <summary>
        /// Document name
        /// </summary>
        private string name;

        /// <summary>
        /// PDF Renderer
        /// </summary>
        private Renderer renderer;

        /// <summary>
        /// Document Sections
        /// </summary>
        private List<Section> sections;

        /// <summary>
        /// Document left margin
        /// </summary>
        private float leftMargin;

        #endregion

        #region Properties

        #endregion

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Document(string name, float leftMargin)
        {
            this.name = name;
            this.leftMargin = leftMargin;
            this.renderer = new Renderer();
            this.sections = new List<Section>();
        }

        /// <summary>
        /// Save the document as .PDF
        /// </summary>
        public void Save()
        {
            MigraDoc.DocumentObjectModel.Document document = new MigraDoc.DocumentObjectModel.Document();

            document.DefaultPageSetup.LeftMargin = MigraDoc.DocumentObjectModel.Unit.FromMillimeter(leftMargin);

            StyleManager.SetDocumentStyles(document);

            this.sections.ForEach(section => {
                var renderedSection = section.Render();
                document.Add((MigraDoc.DocumentObjectModel.Section)renderedSection);
                });

            PdfDocument pdf = this.renderer.RenderPDF(document);

            pdf.Save(this.name + ".PDF");

        }

        /// <summary>
        /// Add a child component
        /// </summary>
        public void AddSection(Section section)
        {
            this.sections.Add(section);
        }

        /// <summary>
        /// Remove a child component
        /// </summary>
        public void RemoveSection(Section section)
        {
            this.sections.Remove(section);
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion
    }
}
