using MigraDoc.DocumentObjectModel;
using System.Configuration;

namespace PDFBuilder
{
    public class StyleManager
    {
        #region Static

        /// <summary>
        /// Configure main styles for document
        /// </summary>
        public static void SetDocumentStyles(MigraDoc.DocumentObjectModel.Document document)
        {
            setTitlesStyle(document);
            setSubtitlesStyle(document);
            setTextStyle(document);
            setTableTextStyle(document);
            setTableHeaderStyle(document);
            setCommentsStyle(document);
        }

        /// <summary>
        /// Configure title styles for document
        /// </summary>
        private static void setTitlesStyle(MigraDoc.DocumentObjectModel.Document document)
        {
            Style style = document.Styles["Heading1"];

            style.Font.Name = titleFont;

            style.Font.Size = titleFontSize;

            style.Font.Color = Color.FromRgb(titleRed, titleGreen, titleBlue);

            style.ParagraphFormat.SpaceAfter = titleSpacing;
        }

        /// <summary>
        /// Configure subtitle styles for document
        /// </summary>
        private static void setSubtitlesStyle(MigraDoc.DocumentObjectModel.Document document)
        {
            Style style = document.Styles["Heading2"];

            style.Font.Name = subtitleFont;

            style.Font.Size = subtitleFontSize;

            style.Font.Color = Color.FromRgb(subtitleRed, subtitleGreen, subtitleBlue);

            style.ParagraphFormat.SpaceAfter = subtitleSpacing;
        }

        /// <summary>
        /// Configure main text styles for document
        /// </summary>
        private static void setTextStyle(MigraDoc.DocumentObjectModel.Document document)
        {
            Style style = document.Styles["Normal"];

            style.Font.Name = textFont;

            style.Font.Size = textFontSize;

            style.Font.Color = Color.FromRgb(textRed, textRed, textBlue);

            style.ParagraphFormat.SpaceAfter = textSpacing;
        }

        /// <summary>
        /// Configure table text styles for document
        /// </summary>
        private static void setTableTextStyle(MigraDoc.DocumentObjectModel.Document document)
        {
            Style style = document.Styles.AddStyle("TableText","Normal");

            style.Font.Name = tableTextFont;

            style.Font.Size = tableTextFontSize;

            style.ParagraphFormat.SpaceAfter = tableTextSpacing;
            style.ParagraphFormat.Alignment = ParagraphAlignment.Center;
        }

        /// <summary>
        /// Configure table header text styles for document
        /// </summary>
        private static void setTableHeaderStyle(MigraDoc.DocumentObjectModel.Document document)
        {
            Style style = document.Styles.AddStyle("TableHeader", "TableText");

            style.Font.Name = tableHeaderFont;

            style.Font.Size = tableHeaderFontSize;
            style.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            style.ParagraphFormat.Font.Color = Color.FromRgb(byte.MaxValue, byte.MaxValue, byte.MaxValue);

        }

        /// <summary>
        /// Configure table header text styles for document
        /// </summary>
        private static void setCommentsStyle(MigraDoc.DocumentObjectModel.Document document)
        {
            Style style = document.Styles.AddStyle("Comments", "Normal");

            style.Font.Name = commentsFont;

            style.Font.Size = commentsFontSize;
            style.ParagraphFormat.Alignment = ParagraphAlignment.Justify;

        }

        #endregion Static

        #region Internal fields

        ///Title config 
        const string titleFont = "Verdana";
        const string titleFontSize = "0.75cm";
        const byte titleRed = 23;
        const byte titleGreen = 54;
        const byte titleBlue = 93;
        const string titleSpacing = "0.5cm";

        ///Subtitle config 
        const string subtitleFont = "Verdana";
        const string subtitleFontSize = "0.45cm";
        const byte subtitleRed = 40;
        const byte subtitleGreen = 96;
        const byte subtitleBlue = 164;
        const string subtitleSpacing = "0.388cm";

        ///Text config 
        const string textFont = "Verdana";
        const string textFontSize = "0.4cm";
        const byte textRed = 0;
        const byte textGreen = 0;
        const byte textBlue = 0;
        const string textSpacing = "0.2cm";

        ///Table Text config 
        const string tableTextFont = "Verdana";
        const string tableTextFontSize = "0.4cm";
        const string tableTextSpacing = "0.15cm";

        ///Table Header config 
        const string tableHeaderFont = "Verdana";
        const string tableHeaderFontSize = "0.4cm";

        ///Comments text config 
        const string commentsFont = "Verdana";
        const string commentsFontSize = "0.3cm";

        #endregion Internal fields

    }
}
