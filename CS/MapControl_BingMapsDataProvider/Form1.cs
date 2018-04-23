using System.Windows.Forms;
using DevExpress.XtraMap;

namespace MapControl_BingMapsDataProvider {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            #region #BingMapsDataProvider
            mapControl1.Layers.Add(new ImageTilesLayer() {
                DataProvider = new BingMapDataProvider() {
                    BingKey = "YOUR BING KEY"
                }
            });
            #endregion #BingMapsDataProvider
        }
    }
}
