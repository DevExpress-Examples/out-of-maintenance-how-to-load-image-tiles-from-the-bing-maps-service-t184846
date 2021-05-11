Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace MapControl_BingMapsDataProvider
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
'			#Region "#BingMapsDataProvider"
			mapControl1.Layers.Add(New ImageLayer() With {
				.DataProvider = New BingMapDataProvider() With {
					.BingKey = "YOUR BING KEY",
					.Kind = BingMapKind.Road
				}
			})
'			#End Region ' #BingMapsDataProvider
		End Sub
	End Class
End Namespace
