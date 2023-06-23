using System;
using System.Collections.ObjectModel;

namespace MAUI_ChartAxis
{
    public class ChartViewModel 
    {
        public ObservableCollection<ChartDataModel> SalesData { get; set; }
        public ChartViewModel()
        {
            SalesData = new ObservableCollection<ChartDataModel>()
            {
                new ChartDataModel( new DateTime(2023,06,22), 50),
                new ChartDataModel( new DateTime(2023,06,24), 65),
                new ChartDataModel(new DateTime(2023,06,26), 42),
                new ChartDataModel( new DateTime(2023,06,28), 64),
                new ChartDataModel( new DateTime(2023,06,30), 42),
                new ChartDataModel( new DateTime(2023,07,02), 20),
            };

        }
    }
}
