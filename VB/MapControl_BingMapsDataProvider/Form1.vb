Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace MapControl_BingMapsDataProvider
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
'            #Region "#BingMapsDataProvider"
            mapControl1.Layers.Add(New ImageTilesLayer() With { _
                .DataProvider = New BingMapDataProvider() With {.BingKey = "YOUR BING KEY"} _
            })
'            #End Region ' #BingMapsDataProvider
        End Sub
    End Class
End Namespace
