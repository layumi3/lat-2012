'Public Class Form2
'    Private x As Integer
'    Private y As Integer
'    Public Sub New()
'        x = 0
'        y = 0

'        ' This call is required by the designer.
'        InitializeComponent()

'        ' Add any initialization after the InitializeComponent() call.

'    End Sub
'    Public Sub New(ByVal xcor As Integer, ByVal ycor As Integer)
'        x = xcor
'        y = ycor

'    End Sub
'    Public Property Xval() As Integer
'        Get
'            Return x
'        End Get
'        Set(ByVal value As Integer)
'            x = value
'        End Set

'    End Property
'    Public Property Yval() As Integer
'        Get
'            Return y
'        End Get
'        Set(ByVal value As Integer)
'            y = value
'        End Set

'    End Property
'    Public Overrides Function ToString() As String
'        Return x & "," & y
'    End Function
'    Public Function Equal(ByVal p As Point) As Boolean
'        If (Me.x = p.X) And (Me.y = p.Y) Then
'            Return True
'        Else
'            Return False
'        End If
'    End Function
'    Public Class Circle
'        Inherits Point
'        Private radius As Single
'        Private Sub setRadius(ByVal r As Single)
'            If (r > 0) Then
'                radius = r
'            Else
'                radius = 0.0
'            End If
'        End Sub
'    End Class
'    Public Sub New(ByVal r As Single, ByVal x As Integer, ByVal y As Integer)
'        MyBase.New(x, y)
'        setRadius(r)
'    End Sub
'    Public Sub New()
'        setRadius(0)
'        ' This call is required by the designer.
'        InitializeComponent()

'        ' Add any initialization after the InitializeComponent() call.

'    End Sub
'    Public ReadOnly Property getRadius() As Single
'        Get
'            Return getRadius

'        End Get
'    End Property
'    Public Function Area() As Single
'        Return Math.PI * radius * radius

'    End Function
'    Public Overrides Function toString() As String
'        Return "center = " & Me.Xval & "," & Me.Yval & ""_" - radius = " & radius
'    End Function
'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

'    End Sub
'End Class