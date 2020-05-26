Imports myUCLib
Imports System.Drawing.Color
Public Class AxisController
    Dim Axis1 As Axis

    Sub New(axis As Axis)
        Axis1 = axis
    End Sub
    Public Sub InitAxis(xBase As Double, yBase As Double)
        Axis1.Axis_Type = 3
        Axis1.Pix_type = 1
        Axis1.x_Base = xBase
        Axis1.y_Base = yBase
        Axis1.Pix_type = 3
        Axis1.Pix_Size = 0.05
        Axis1.x_Name = "X"
        Axis1.y_Name = "Y"
        Axis1.BackColor = Gray
        Axis1.AxisDraw()
    End Sub

    Public Sub DrawCore(x As Double, y As Double, PixColor As Color)
        SetPixSize(x, y, PixColor, 2, 0.02)
        Axis1.DinToPic()
    End Sub

    Public Sub DrawTrajectory(x As Double, y As Double, PixColor As Color)
        SetPixSize(x, y, PixColor, 1, 0.005)
        Axis1.StatToDin()
    End Sub

    Private Sub SetPixSize(x As Double, y As Double, PixColor As Color, drawMode As Byte, pixSize As Double)
        Axis1.Pix_Size = pixSize
        Axis1.PixDraw(x, y, PixColor, drawMode)
    End Sub
End Class
