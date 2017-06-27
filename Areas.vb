' Class filename:       Areas.vb
' Created/revised by:   Norris Smith on 4/25/17

Option Explicit On
Option Strict On
Option Infer Off

Public Class Parallelogram
    Public Property Base As Double
    Public Property Height As Double

    Public Sub New()
        _Base = 0
        _Height = 0
    End Sub

    Public Sub New(ByVal dblB As Double, ByVal dblH As Double)
        Base = dblB
        Height = dblH
    End Sub

    Public Overridable Function GetArea() As Double
        Return _Base * _Height
    End Function
End Class



