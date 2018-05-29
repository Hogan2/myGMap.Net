using MapTest.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapTest
{
    public class MapTestModule : IModule
    {
        IRegionManager _regionManager;
        public MapTestModule(RegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MapRegion", typeof(MapTestView));
        }
    }
}
