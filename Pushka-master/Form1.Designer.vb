<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonInit = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxAlpha0 = New System.Windows.Forms.TextBox()
        Me.TextBoxV0 = New System.Windows.Forms.TextBox()
        Me.TextBoxDt = New System.Windows.Forms.TextBox()
        Me.TextBoxH = New System.Windows.Forms.TextBox()
        Me.TextBoxXBase = New System.Windows.Forms.TextBox()
        Me.TextBoxYBase = New System.Windows.Forms.TextBox()
        Me.Axis1 = New myUCLib.Axis()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxXmax = New System.Windows.Forms.TextBox()
        Me.TextBoxYmax = New System.Windows.Forms.TextBox()
        Me.TextBoxVmax = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ButtonInit
        '
        Me.ButtonInit.BackColor = System.Drawing.Color.Gray
        Me.ButtonInit.Location = New System.Drawing.Point(14, 325)
        Me.ButtonInit.Name = "ButtonInit"
        Me.ButtonInit.Size = New System.Drawing.Size(99, 23)
        Me.ButtonInit.TabIndex = 0
        Me.ButtonInit.Text = "Init Axis"
        Me.ButtonInit.UseVisualStyleBackColor = False
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.Color.Gray
        Me.ButtonStart.Location = New System.Drawing.Point(14, 355)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(99, 23)
        Me.ButtonStart.TabIndex = 1
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = False
        '
        'ButtonStop
        '
        Me.ButtonStop.BackColor = System.Drawing.Color.Gray
        Me.ButtonStop.Location = New System.Drawing.Point(14, 384)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(99, 23)
        Me.ButtonStop.TabIndex = 1
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = False
        '
        'TextBoxAlpha0
        '
        Me.TextBoxAlpha0.BackColor = System.Drawing.Color.Gray
        Me.TextBoxAlpha0.Location = New System.Drawing.Point(13, 13)
        Me.TextBoxAlpha0.Name = "TextBoxAlpha0"
        Me.TextBoxAlpha0.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAlpha0.TabIndex = 2
        Me.TextBoxAlpha0.Text = "35"
        '
        'TextBoxV0
        '
        Me.TextBoxV0.BackColor = System.Drawing.Color.Gray
        Me.TextBoxV0.Location = New System.Drawing.Point(13, 39)
        Me.TextBoxV0.Name = "TextBoxV0"
        Me.TextBoxV0.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxV0.TabIndex = 2
        Me.TextBoxV0.Text = "4"
        '
        'TextBoxDt
        '
        Me.TextBoxDt.BackColor = System.Drawing.Color.Gray
        Me.TextBoxDt.Location = New System.Drawing.Point(13, 65)
        Me.TextBoxDt.Name = "TextBoxDt"
        Me.TextBoxDt.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDt.TabIndex = 2
        Me.TextBoxDt.Text = "0.01"
        '
        'TextBoxH
        '
        Me.TextBoxH.BackColor = System.Drawing.Color.Gray
        Me.TextBoxH.Location = New System.Drawing.Point(13, 91)
        Me.TextBoxH.Name = "TextBoxH"
        Me.TextBoxH.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxH.TabIndex = 2
        Me.TextBoxH.Text = "0"
        '
        'TextBoxXBase
        '
        Me.TextBoxXBase.BackColor = System.Drawing.Color.Gray
        Me.TextBoxXBase.Location = New System.Drawing.Point(12, 117)
        Me.TextBoxXBase.Name = "TextBoxXBase"
        Me.TextBoxXBase.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxXBase.TabIndex = 2
        Me.TextBoxXBase.Text = "6"
        '
        'TextBoxYBase
        '
        Me.TextBoxYBase.BackColor = System.Drawing.Color.Gray
        Me.TextBoxYBase.Location = New System.Drawing.Point(12, 143)
        Me.TextBoxYBase.Name = "TextBoxYBase"
        Me.TextBoxYBase.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxYBase.TabIndex = 2
        Me.TextBoxYBase.Text = "6"
        '
        'Axis1
        '
        Me.Axis1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.Axis1.axis_bkcolor = System.Drawing.Color.Gray
        Me.Axis1.axis_color = System.Drawing.SystemColors.ControlText
        Me.Axis1.Axis_Type = CType(1, Byte)
        Me.Axis1.BackColor = System.Drawing.Color.Gray
        Me.Axis1.E_x = 0
        Me.Axis1.E_y = 0
        Me.Axis1.Location = New System.Drawing.Point(166, 12)
        Me.Axis1.Name = "Axis1"
        Me.Axis1.Pix_color = System.Drawing.Color.Black
        Me.Axis1.Pix_Size = 2.0!
        Me.Axis1.Pix_type = CType(1, Byte)
        Me.Axis1.Size = New System.Drawing.Size(485, 425)
        Me.Axis1.TabIndex = 3
        Me.Axis1.x_Base = 1.0!
        Me.Axis1.x_Name = "X"
        Me.Axis1.y_Base = 1.0!
        Me.Axis1.y_Name = "Y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Alpha0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "V0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "H"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "XBase"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(120, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "YBase"
        '
        'TextBoxXmax
        '
        Me.TextBoxXmax.BackColor = System.Drawing.Color.Gray
        Me.TextBoxXmax.Location = New System.Drawing.Point(13, 169)
        Me.TextBoxXmax.Name = "TextBoxXmax"
        Me.TextBoxXmax.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxXmax.TabIndex = 2
        '
        'TextBoxYmax
        '
        Me.TextBoxYmax.BackColor = System.Drawing.Color.Gray
        Me.TextBoxYmax.Location = New System.Drawing.Point(12, 195)
        Me.TextBoxYmax.Name = "TextBoxYmax"
        Me.TextBoxYmax.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxYmax.TabIndex = 2
        '
        'TextBoxVmax
        '
        Me.TextBoxVmax.BackColor = System.Drawing.Color.Gray
        Me.TextBoxVmax.Location = New System.Drawing.Point(12, 221)
        Me.TextBoxVmax.Name = "TextBoxVmax"
        Me.TextBoxVmax.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVmax.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(120, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Xmax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(120, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Ymax"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(120, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Vmax"
        '
        'TextBoxT
        '
        Me.TextBoxT.BackColor = System.Drawing.Color.Gray
        Me.TextBoxT.Location = New System.Drawing.Point(12, 247)
        Me.TextBoxT.Name = "TextBoxT"
        Me.TextBoxT.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxT.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(120, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "T"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(13, 273)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(130, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "considering resistance"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(14, 296)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(110, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "without resistance"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 450)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Axis1)
        Me.Controls.Add(Me.TextBoxT)
        Me.Controls.Add(Me.TextBoxVmax)
        Me.Controls.Add(Me.TextBoxYBase)
        Me.Controls.Add(Me.TextBoxYmax)
        Me.Controls.Add(Me.TextBoxXBase)
        Me.Controls.Add(Me.TextBoxXmax)
        Me.Controls.Add(Me.TextBoxH)
        Me.Controls.Add(Me.TextBoxDt)
        Me.Controls.Add(Me.TextBoxV0)
        Me.Controls.Add(Me.TextBoxAlpha0)
        Me.Controls.Add(Me.ButtonStop)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.ButtonInit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonInit As Button
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonStop As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBoxAlpha0 As TextBox
    Friend WithEvents TextBoxV0 As TextBox
    Friend WithEvents TextBoxDt As TextBox
    Friend WithEvents TextBoxH As TextBox
    Friend WithEvents TextBoxXBase As TextBox
    Friend WithEvents TextBoxYBase As TextBox
    Friend WithEvents Axis1 As myUCLib.Axis
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxXmax As TextBox
    Friend WithEvents TextBoxYmax As TextBox
    Friend WithEvents TextBoxVmax As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxT As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
