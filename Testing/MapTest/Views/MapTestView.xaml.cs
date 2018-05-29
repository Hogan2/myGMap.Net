using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MapTest.Views
{
    /// <summary>
    /// MapTestView.xaml 的交互逻辑
    /// </summary>
    public partial class MapTestView : UserControl
    {
        public MapTestView()
        {
            InitializeComponent();

            GMapCtrl.CacheLocation = @"D:\LOG\CODE\MapDB";
            GMapCtrl.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
            GMapCtrl.Manager.Mode = AccessMode.CacheOnly;
            GMapCtrl.Position = new PointLatLng(30.6898, 103.9468);
            GMapCtrl.Zoom = 14;
            GMapCtrl.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            GMapCtrl.ShowCenter = false;
            GMapCtrl.DragButton = MouseButton.Left;
            GMapCtrl.ShowTileGridLines = false;
        }
    }
}
