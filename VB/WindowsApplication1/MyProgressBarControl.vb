Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraPrinting
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace WindowsApplication1
    Public Class MyProgressBarControl
        Inherits ProgressBarControl
        Shared Sub New()
            RepositoryItemMyProgressBarControl.RegisterMyProgressBarControl()
        End Sub

        Public Sub New()
            MyBase.New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName() As String
            Get
                Return RepositoryItemMyProgressBarControl.MyProgressBarControlName
            End Get
        End Property

        Public Shadows ReadOnly Property Properties() As RepositoryItemMyProgressBarControl
            Get
                Return CType(MyBase.Properties, RepositoryItemMyProgressBarControl)
            End Get
        End Property

        <UserRepositoryItem("RegisterMyProgressBarControl")> _
        Public Class RepositoryItemMyProgressBarControl
            Inherits RepositoryItemProgressBar
            Public Const MyProgressBarControlName As String = "MyProgressBarControl"

            Shared Sub New()
                RegisterMyProgressBarControl()
            End Sub
            Public Sub New()
                MyBase.New()
            End Sub

            Public Overrides Function GetBrick(ByVal info As PrintCellHelperInfo) As DevExpress.XtraPrinting.IVisualBrick
                Dim bmp As New Bitmap(info.Rectangle.Width, info.Rectangle.Height)
                Dim gr As Graphics = Graphics.FromImage(bmp)

                gr.FillRectangle(New SolidBrush(Color.White), info.Rectangle)
                Dim brick As New ImageBrick(BorderSide.None, 0, Color.Transparent, Color.Transparent)
                Dim width As Integer = Convert.ToInt32(info.Rectangle.Width * Convert.ToDouble(info.EditValue) / (CDbl(100)))
                If width > 0 Then
                    gr.FillRectangle(New LinearGradientBrush(New Rectangle(0, 0, width, info.Rectangle.Height), Color.LightBlue, Color.White, 90, True), New Rectangle(0, 0, width, info.Rectangle.Height))
                    brick.Image = bmp
                End If
                gr.DrawString(info.DisplayText, info.Appearace.Font, New SolidBrush(Color.Black), New PointF(0, 0))
                brick.Rect = info.Rectangle
                Return brick
            End Function

            Public Shared Sub RegisterMyProgressBarControl()
                EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(MyProgressBarControlName, GetType(MyProgressBarControl), GetType(RepositoryItemMyProgressBarControl), GetType(MyProgressBarViewInfo), New ProgressBarPainter(), True))
            End Sub

            Public Overrides ReadOnly Property EditorTypeName() As String
                Get
                    Return MyProgressBarControlName
                End Get
            End Property
        End Class

        Public Class MyProgressBarViewInfo
            Inherits ProgressBarViewInfo
            Public Sub New(ByVal item As RepositoryItem)
                MyBase.New(item)
            End Sub
        End Class
    End Class
End Namespace
