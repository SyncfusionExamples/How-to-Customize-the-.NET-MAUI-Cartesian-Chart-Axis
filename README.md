# How-to-Customize-the-.NET-MAUI-Cartesian-Chart-Axis
The [.NET MAUI Chart]() control offers built-in support for customizing the axis range in a Cartesian chart. This range customization can be applied to [NumericalAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html?tabs=tabid-1%2Ctabid-13%2Ctabid-11%2Ctabid-3%2Ctabid-7%2Ctabid-5%2Ctabid-9), [DateTimeAxes](), and [LogarithmicAxes](). You can achieve this support by setting the Minimum, Maximum, and Interval values on both the X and Y axes. 

**Range customization on Numerical axis**

The following code example illustrates how to customize the range on a numerical axis:

**XAML**
 ```XAML
  <chart:SfCartesianChart.XAxes>
      <chart:NumericalAxis Interval="1" />
  </chart:SfCartesianChart.XAxes>
  
  <chart:SfCartesianChart.YAxes>
      <chart:NumericalAxis Interval="20" Minimum="20" Maximum="200" />
  </chart:SfCartesianChart.YAxes>
 ```

**C#**
 
 ```C#
SfCartesianChart chart = new SfCartesianChart();
      
NumericalAxis xAxis = new NumericalAxis
{
    Interval = 1
};
       
chart.XAxes.Add(xAxis);
     
NumericalAxis yAxis = new NumericalAxis
{
Interval = 20,
Minimum = 20,
Maximum = 200
};
     
chart.YAxes.Add(yAxis);
 ```


**Output for the range customization on Numerical axis**

![Numeriacl Axis.png](https://support.syncfusion.com/kb/agent/attachment/article/13220/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjkwNjIiLCJvcmdpZCI6IjMiLCJpc3MiOiJzdXBwb3J0LnN5bmNmdXNpb24uY29tIn0.UHXVvz7-cYbQlqLX5batyWLFNcvYd4YrKxIfWRDvUos)

**Range customization on  DateTime axis**

You can customize the range on a DateTime axis in the .NET MAUI Chart control by setting properties such as [Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html?tabs=tabid-1%2Ctabid-13%2Ctabid-11%2Ctabid-3%2Ctabid-7%2Ctabid-5%2Ctabid-9#Syncfusion_Maui_Charts_NumericalAxis_Minimum), [Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html?tabs=tabid-1%2Ctabid-13%2Ctabid-11%2Ctabid-3%2Ctabid-7%2Ctabid-5%2Ctabid-9#Syncfusion_Maui_Charts_NumericalAxis_Maximum), [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html?tabs=tabid-1%2Ctabid-13%2Ctabid-11%2Ctabid-3%2Ctabid-7%2Ctabid-5%2Ctabid-9#Syncfusion_Maui_Charts_NumericalAxis_Interval), and [IntervalType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_IntervalType). The code example below illustrates how to achieve this:

**XAML**

 
 ```XAML
<chart:SfCartesianChart.XAxes>
    <chart:DateTimeAxis Minimum="2023/06/01" Maximum="2023/06/07" Interval="1" IntervalType="Days" />
</chart:SfCartesianChart.XAxes>

<chart:SfCartesianChart.YAxes>
    <chart:NumericalAxis  />
</chart:SfCartesianChart.YAxes>
 ```

**C#**

 
 ```C#
SfCartesianChart chart = new SfCartesianChart();
      
DateTimeAxis xAxis = new DateTimeAxis
{
    Minimum="2023/06/01",
    Maximum="2023/06/07",
    Interval="1",
    IntervalType="Days"
};
       
chart.XAxes.Add(xAxis);
     
NumericalAxis yAxis = new NumericalAxis{};

chart.YAxes.Add(yAxis);
 ```



**Output for the range customization on DateTime axis**

![DateTime.png](https://support.syncfusion.com/kb/agent/attachment/article/13220/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjkwNjgiLCJvcmdpZCI6IjMiLCJpc3MiOiJzdXBwb3J0LnN5bmNmdXNpb24uY29tIn0.D912GsnpVxadqo1tpn8yazuXA3ezZiP68TUW8tY6MLQ)

**Range customization on  Logarithmic  axis**

You can customize the range on a Logarithmic axis in the .NET MAUI Chart control by setting properties such as [Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html?tabs=tabid-1%2Ctabid-13%2Ctabid-11%2Ctabid-3%2Ctabid-7%2Ctabid-5%2Ctabid-9#Syncfusion_Maui_Charts_NumericalAxis_Minimum), [Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html?tabs=tabid-1%2Ctabid-13%2Ctabid-11%2Ctabid-3%2Ctabid-7%2Ctabid-5%2Ctabid-9#Syncfusion_Maui_Charts_NumericalAxis_Maximum), [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html?tabs=tabid-1%2Ctabid-13%2Ctabid-11%2Ctabid-3%2Ctabid-7%2Ctabid-5%2Ctabid-9#Syncfusion_Maui_Charts_NumericalAxis_Interval), and [LogarithmicBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html#Syncfusion_Maui_Charts_LogarithmicAxis_LogarithmicBase). The code example below illustrates how to achieve this:

**XAML**

 
 ```XAML
<chart:SfCartesianChart.XAxes>
    <chart:CategoryAxis />
</chart:SfCartesianChart.XAxes>

<chart:SfCartesianChart.YAxes>
    <chart:LogarithmicAxis  Minimum="5" Maximum="125"  LogarithmicBase="5"/>
</chart:SfCartesianChart.YAxes>
 ```


**C#**

 
 ```C#
SfCartesianChart chart = new SfCartesianChart();

CategoryAxis xAxis = new CategoryAxis();
chart.PrimaryAxis = xAxis;

LogarithmicAxis yAxis = new LogarithmicAxis
{
    Minimum = 5,
    Maximum = 125,
    LogarithmicBase = 5
};

chart.SecondaryAxis = yAxis;
 ```

**Output for the range customization on Logarithmic  axis**

![Logarithmic.png](https://support.syncfusion.com/kb/agent/attachment/article/13220/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjkwNzMiLCJvcmdpZCI6IjMiLCJpc3MiOiJzdXBwb3J0LnN5bmNmdXNpb24uY29tIn0.vCiXSEQ-47uESxMlsUvqVD8uAvMsmxiY4QaOTI8y_sI)


**Conclusion**

I hope you enjoyed learning about how to customize axis range for .NET MAUI (SfCartesianChart).

You can refer to our [.NET MAUI Chart’s feature tour](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) page to know about its other groundbreaking feature representations. You can also explore our [.NET MAUI Chart documentation](https://help.syncfusion.com/maui/cartesian-charts/getting-started) to understand how to present and manipulate data. 

For current customers, you can check out our .NET MAUI from the [License and Downloads](https://www.syncfusion.com/account/downloads) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui/confirm) to check out our .NET MAUI Chart and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/agent/tickets?brandids=all&page=1&filterid=2), or [feedback portal.](https://www.syncfusion.com/feedback/maui?control=sfcartesianchart) We are always happy to assist you!

