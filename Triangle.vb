' Class filename:       Areas.vb
' Created/revised by:   Norris Smith on 4/25/17

Option Explicit On
Option Strict On
Option Infer Off

Public Class Triangle
    Inherits Parallelogram
    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal dblB As Double, ByVal dblH As Double)
        'passing paramemters
        MyBase.New(dblB, dblH)
    End Sub

    Public Overrides Function GetArea() As Double
        Return MyBase.GetArea / 2
    End Function
End Class