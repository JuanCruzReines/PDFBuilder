using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFBuilder
{
    class Renderer
    {
        #region Internal Fields

        /// A flag indicating whether to create a Unicode PDF or a WinAnsi PDF file.
        /// This setting applies to all fonts used in the PDF document.
        /// This setting has no effect on the RTF renderer.
        const bool unicode = false;

        /// MigraDoc renderer
        private PdfDocumentRenderer renderer;

        #endregion

        #region Properties

        #endregion

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Renderer()
        {
            this.renderer = new PdfDocumentRenderer(unicode);
        }

        /// <summary>
        /// Render a document in PDF format
        /// </summary>
        public PdfDocument RenderPDF(MigraDoc.DocumentObjectModel.Document document)
        {
            this.renderer.Document = document;

            this.renderer.RenderDocument();

            return this.renderer.PdfDocument;
        }

        #endregion Public Methods

        #region Non Public Methods

        #endregion
    }
}
