﻿using System.Collections.Generic;
using System.Windows.Controls;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace Netling.Client
{
    public partial class LineGraphControl : UserControl
    {
        public LineGraphControl()
        {
            InitializeComponent();
        }

        public void Draw(IEnumerable<DataPoint> points)
        {
            var plotModel = new PlotModel
            {
                PlotMargins = new OxyThickness(0),
                AutoAdjustPlotMargins = false, 
                PlotAreaBorderThickness = 0
            };

            plotModel.Axes.Add(new LinearAxis
            {
                MinimumPadding = 0.01,
                MaximumPadding = 0.01,
                IsAxisVisible = false,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                Position = AxisPosition.Bottom
            });

            plotModel.Axes.Add(new LinearAxis
            {
                Minimum = 0.0,
                MaximumPadding = 0.1,
                TickStyle = TickStyle.None,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                IsZoomEnabled = false,
                IsPanEnabled = false
            });

            var ls = new LineSeries(OxyColor.Parse("#ff0079c5"));

            foreach (var point in points)
            {
                ls.Points.Add(point);
            }

            plotModel.Series.Add(ls);
            Graph.Model = plotModel;
        }
    }
}
