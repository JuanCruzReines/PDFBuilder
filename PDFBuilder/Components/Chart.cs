using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.DocumentObjectModel.Tables;
using PDFBuilder.Components.Interfaces;
using System.Collections.Generic;

namespace PDFBuilder.Components
{
    public class Chart : IContent
    {

        #region Internal fields

        #endregion Internal fields

        #region Properties
        /// <summary>
        /// Chart height
        /// </summary>
        public float ChartHeight { get; set; }

        /// <summary>
        /// Chart width
        /// </summary>
        public float ChartWidth { get; set; }

        /// <summary>
        /// Chart Type
        /// </summary>
        public ChartType ChartType { get; set; }

        /// <summary>
        /// Chart values
        /// </summary>
        public List<List<double>> Values { get; set; }

        /// <summary>
        /// Chart values
        /// </summary>
        public List<Formats.Color> LineColors { get; set; }

        #endregion Properties

        #region Custom Events

        #endregion Custom Events

        #region Events methods

        #endregion Events methods

        #region Public Methods

        /// <summary>
        /// Ctor.
        /// </summary>
        public Chart(List<List<double>> chartValues, float chartHeight, float chartWidth, ChartType type, List<string> lineColors)
        {
            this.ChartHeight = chartHeight;
            this.ChartWidth = chartWidth;
            this.Values = chartValues;
            this.ChartType = type;

            this.LineColors = new List<Formats.Color>();
            lineColors.ForEach(color => LineColors.Add(new Formats.Color(color)));
        }

        /// <summary>
        /// Render a paragraph into a section
        /// </summary>
        public void RenderInto(MigraDoc.DocumentObjectModel.Section section)
        {
            MigraDoc.DocumentObjectModel.Shapes.Charts.Chart chart = this.Create();

            section.Add(chart);
        }

        /// <summary>
        /// Render a paragraph into a header or footer
        /// </summary>
        public void RenderInto(HeaderFooter headerFooter)
        {
            MigraDoc.DocumentObjectModel.Shapes.Charts.Chart chart = this.Create();

            headerFooter.Add(chart);
        }


        #endregion Public Methods

        #region Non Public Methods

        /// <summary>
        /// Creates a MigraDoc paragraph component based on properties
        /// </summary>
        private MigraDoc.DocumentObjectModel.Shapes.Charts.Chart Create()
        {
            MigraDoc.DocumentObjectModel.Shapes.Charts.Chart chart = new MigraDoc.DocumentObjectModel.Shapes.Charts.Chart(ChartType);

            chart.Width = Unit.FromMillimeter(this.ChartHeight);
            chart.Height = Unit.FromMillimeter(this.ChartHeight);
            Series series;

            for(int i = 0; i < Values.Count; i++)
            {
                series = chart.SeriesCollection.AddSeries();
                series.Add(Values[i].ToArray());
                series.MarkerStyle = MarkerStyle.None;
                series.LineFormat.Color = LineColors[i].GetColor();
            };
            

            if (ChartType == ChartType.Pie2D)
            {
                chart.DataLabel.Type = DataLabelType.Percent;
                chart.DataLabel.Position = DataLabelPosition.OutsideEnd;
            }
            else
            {
                chart.XAxis.MajorTickMark = TickMarkType.Outside;
                chart.YAxis.MajorTickMark = TickMarkType.Outside;
                chart.YAxis.HasMajorGridlines = true;
            }

            if(ChartType == ChartType.Line)
            {
                //xAxis values
                XSeries xseries = chart.XValues.AddXSeries();

                this.Values.ForEach( _ => xseries.Add(string.Empty));
            }
            
            return chart;
        }

        #endregion Non Public Methods
    }
}
