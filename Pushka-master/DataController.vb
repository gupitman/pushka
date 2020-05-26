Imports System.Math
Public Class DataController
    Const PI = 3.14

    Public Event DataCalculated()
    Public Event TextBoxDataUpdated()
    Public Event TimeTextBoxDataUpdated()

    Public X As Single
    Public Y As Single
    Public Xmax As Single
    Public Ymax As Single
    Public Vmax As Single
    Public T As Single
    Public IsResistanceIncluded As Boolean

    Dim _x0 As Single
    Dim _y0 As Single
    Dim _v As Single
    Dim _v0 As Single
    Dim _vx0 As Single
    Dim _vy0 As Single
    Dim _vx As Single
    Dim _vy As Single
    Dim _alpha0 As Single
    Dim _ax As Single
    Dim _ay As Single
    Dim _dt As Single

    Dim WithEvents _timer As Timer

    Public Sub InitData(alpha0 As Double, v0 As Double, dt As Double, h As Double)
        _alpha0 = alpha0
        _v0 = v0
        _dt = dt
        _y0 = h
        T = 0
        _v = _v0
        _vx0 = _v0 * Cos(_alpha0 * PI / 180)
        _vy0 = _v0 * Sin(_alpha0 * PI / 180)
        _x0 = 0
        Vmax = _v0
        Xmax = _x0
        Ymax = _y0
    End Sub


    Sub New(timer As Timer)
        _timer = timer
    End Sub


    Private Sub Timer1_Tick() Handles _timer.Tick
        T = T + _dt

        If IsResistanceIncluded Then
            _ax = -_v * _vx
            _ay = -1 - _v * _vy
        Else
            _ax = 0
            _ay = -1
        End If
        _vx = _vx0 + _ax * _dt
        _vy = _vy0 + _ay * _dt
        X = _x0 + (_vx0 + _vx) * _dt + _ax * _dt * _dt / 2
        Y = _y0 + (_vy0 + _vy) * _dt + _ay * _dt * _dt / 2
        RaiseEvent DataCalculated()

        If Y < 0 Then
            _timer.Enabled = False
            RaiseEvent TextBoxDataUpdated()
        End If

        _x0 = X
        _y0 = Y
        _vx0 = _vx
        _vy0 = _vy
        _v = Sqrt(_vx ^ 2 + _vy ^ 2)

        If Abs(X) > Xmax Then Xmax = Abs(X)
        If Abs(Y) > Ymax Then Ymax = Abs(Y)
        If _v > Vmax Then Vmax = _v
        RaiseEvent TimeTextBoxDataUpdated()
    End Sub

End Class
