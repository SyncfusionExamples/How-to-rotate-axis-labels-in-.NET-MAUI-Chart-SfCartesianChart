# How-to-rotate-axis-labels-in-.NET-MAUI-Chart-SfCartesianChart
This sample demonstrate how to rotate axis labels in.NET MAUI Chart (SfCartesianChart)
The .NET MAUI Chart provides support for rotating the axis labels in Cartesian chart. The LabelRotation property is used to define the rotation angle for label content. This article explains how to rotate the axis labels in the SfCartesianChart, as shown in the following code example.
```
##[Xaml]
  <ContentPage.BindingContext>
        <model:ViewModel></model:ViewModel>
    </ContentPage.BindingContext>
    <chart:SfCartesianChart>
        <chart:SfCartesianChart.Title>
            <Label Text="Height Comparison" 
                   FontAttributes="Bold" 
                   FontSize="Title" 
                   VerticalOptions="Center" 
                   HorizontalOptions="Center"/>
        </chart:SfCartesianChart.Title>

        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis  LabelRotation="60" >
                <chart:CategoryAxis.Title>
                    <chart:ChartAxisTitle Text="Name"/>
                </chart:CategoryAxis.Title>
            </chart:CategoryAxis>
        </chart:SfCartesianChart.XAxes>
        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis LabelRotation="60">
                <chart:NumericalAxis.Title>
                    <chart:ChartAxisTitle Text="Height (in cm)"/>
                </chart:NumericalAxis.Title>
            </chart:NumericalAxis>
        </chart:SfCartesianChart.YAxes>
        <chart:ColumnSeries ItemsSource="{Binding Data}" 
                            XBindingPath="Name" 
                            YBindingPath="Height">
        </chart:ColumnSeries>
    </chart:SfCartesianChart>
```
```
##[C#]
SfCartesianChart chart = new SfCartesianChart();
        this.BindingContext = new ViewModel();

        chart.Title = new Label
        {
            Text = "Height Comparison",
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            FontSize = 15,
        };
       
        // Initializing primary axis
        CategoryAxis primaryAxis = new CategoryAxis()
        {
            LabelRotation = 60,
            Title = new ChartAxisTitle()
            {
                Text = "Name"
            },

        };
        chart.XAxes.Add(primaryAxis);

        //Initializing secondary Axis
        NumericalAxis secondaryAxis = new NumericalAxis()
        {
            LabelRotation = 60,
            Title = new ChartAxisTitle()
            {
                Text = "Height (in cm)",
            },
        };
        chart.YAxes.Add(secondaryAxis);

        //Initialize the two series for SfChart
        ColumnSeries series = new ColumnSeries()
        {
            ItemsSource = (new ViewModel()).Data,
            XBindingPath = "Name",
            YBindingPath = "Height"
        };
    
        //Adding Series to the Chart Series Collection
        chart.Series.Add(series);
        this.Content = chart;
```

##Output

<img width="706" alt="OutputImage" src="https://user-images.githubusercontent.com/105482474/209779277-e925ecf7-1f3f-4971-9b66-010059224f50.png">

##See Also:

[How to inverse chart axis in .NET MAUI Chart (SfCartesianChart)](https://www.syncfusion.com/kb/13746/how-to-inverse-the-chart-axis-in-net-maui-chart-sfcartesianchart)

[How to add multiple axis in .NET MAUI Chart (SfCartesianChart)](https://www.syncfusion.com/kb/13738/how-to-add-multiple-axes-in-net-maui-chart-sfcartesianchart)

[How to add a prefix and suffix for axis labels in .NET MAUI Chart (SfCartesianChart)](https://www.syncfusion.com/kb/13730/how-to-add-a-prefix-and-suffix-for-axis-labels-in-net-maui-chart-sfcartesianchart)
