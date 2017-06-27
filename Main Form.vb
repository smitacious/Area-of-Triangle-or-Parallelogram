' Name:         Formula Project
' Purpose:      Displays the area of either a parallelogram or a triangle
' Programmer:   Norris Smith on 4/25/17

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) Handles txtBase.KeyPress, txtHeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles radParallelogram.CheckedChanged, radTriangle.CheckedChanged, txtBase.TextChanged, txtHeight.TextChanged
        lblAnswer.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' declare variables
        Dim answer As Double
        Dim base As Double
        Dim height As Double

        ' assigns the input base value to base variable
        Double.TryParse(txtBase.Text, base)

        ' assigns the input height value to height variable
        Double.TryParse(txtHeight.Text, height)

        ' checks where the parallelogram radio button is selected
        ' if yes instantiate the object for base class and calculates the area of the parallelogram
        ' if not instantiate the object for derived and calculates the area of the triangle
        If radParallelogram.Checked Then
            ' instantiate the object for parellolgram base class
            Dim myParallelogram As New Parallelogram(base, height)

            'calculates the ares of parallelogram by calling the GetArea() method through myParallelogram object base class
            answer = myParallelogram.GetArea()
        Else
            'instantiate the object for Triangle class by using the myTrianble then passing the two parameters to invoke the constructor
            Dim myTriangle As New Triangle(base, height)

            'calculates the of a triangle by calling GetArea() method through myTriangle object of the derived class
            answer = myTriangle.GetArea()
        End If

        'displays the area of the parallelogram or the triangle 
        lblAnswer.Text = answer.ToString("n2")

    End Sub
End Class
