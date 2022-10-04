<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UserInputText = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DelButton = New System.Windows.Forms.Button()
        Me.DivideButton = New System.Windows.Forms.Button()
        Me.SevenButton = New System.Windows.Forms.Button()
        Me.EightButton = New System.Windows.Forms.Button()
        Me.NineButton = New System.Windows.Forms.Button()
        Me.TimesButton = New System.Windows.Forms.Button()
        Me.FourButton = New System.Windows.Forms.Button()
        Me.FiveButton = New System.Windows.Forms.Button()
        Me.SixButton = New System.Windows.Forms.Button()
        Me.MinusButton = New System.Windows.Forms.Button()
        Me.OneButton = New System.Windows.Forms.Button()
        Me.TwoButton = New System.Windows.Forms.Button()
        Me.ThreeButton = New System.Windows.Forms.Button()
        Me.PlusButton = New System.Windows.Forms.Button()
        Me.CEButton = New System.Windows.Forms.Button()
        Me.ZeroButton = New System.Windows.Forms.Button()
        Me.PointButton = New System.Windows.Forms.Button()
        Me.EqualsButton = New System.Windows.Forms.Button()
        Me.CalculationResultText = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserInputText
        '
        Me.UserInputText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserInputText.Location = New System.Drawing.Point(3, 18)
        Me.UserInputText.Name = "UserInputText"
        Me.UserInputText.Size = New System.Drawing.Size(479, 23)
        Me.UserInputText.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DelButton, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DivideButton, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SevenButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.EightButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NineButton, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TimesButton, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FourButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FiveButton, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SixButton, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MinusButton, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.OneButton, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TwoButton, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ThreeButton, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PlusButton, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CEButton, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ZeroButton, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PointButton, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.EqualsButton, 3, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 62)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(479, 418)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'DelButton
        '
        Me.DelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DelButton.Location = New System.Drawing.Point(241, 3)
        Me.DelButton.Name = "DelButton"
        Me.DelButton.Size = New System.Drawing.Size(113, 77)
        Me.DelButton.TabIndex = 2
        Me.DelButton.Text = "DEL"
        Me.DelButton.UseVisualStyleBackColor = True
        '
        'DivideButton
        '
        Me.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DivideButton.Location = New System.Drawing.Point(360, 3)
        Me.DivideButton.Name = "DivideButton"
        Me.DivideButton.Size = New System.Drawing.Size(116, 77)
        Me.DivideButton.TabIndex = 3
        Me.DivideButton.Text = "/"
        Me.DivideButton.UseVisualStyleBackColor = True
        '
        'SevenButton
        '
        Me.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SevenButton.Location = New System.Drawing.Point(3, 86)
        Me.SevenButton.Name = "SevenButton"
        Me.SevenButton.Size = New System.Drawing.Size(113, 77)
        Me.SevenButton.TabIndex = 4
        Me.SevenButton.Text = "7"
        Me.SevenButton.UseVisualStyleBackColor = True
        '
        'EightButton
        '
        Me.EightButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EightButton.Location = New System.Drawing.Point(122, 86)
        Me.EightButton.Name = "EightButton"
        Me.EightButton.Size = New System.Drawing.Size(113, 77)
        Me.EightButton.TabIndex = 5
        Me.EightButton.Text = "8"
        Me.EightButton.UseVisualStyleBackColor = True
        '
        'NineButton
        '
        Me.NineButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NineButton.Location = New System.Drawing.Point(241, 86)
        Me.NineButton.Name = "NineButton"
        Me.NineButton.Size = New System.Drawing.Size(113, 77)
        Me.NineButton.TabIndex = 6
        Me.NineButton.Text = "9"
        Me.NineButton.UseVisualStyleBackColor = True
        '
        'TimesButton
        '
        Me.TimesButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimesButton.Location = New System.Drawing.Point(360, 86)
        Me.TimesButton.Name = "TimesButton"
        Me.TimesButton.Size = New System.Drawing.Size(116, 77)
        Me.TimesButton.TabIndex = 7
        Me.TimesButton.Text = "X"
        Me.TimesButton.UseVisualStyleBackColor = True
        '
        'FourButton
        '
        Me.FourButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FourButton.Location = New System.Drawing.Point(3, 169)
        Me.FourButton.Name = "FourButton"
        Me.FourButton.Size = New System.Drawing.Size(113, 77)
        Me.FourButton.TabIndex = 8
        Me.FourButton.Text = "4"
        Me.FourButton.UseVisualStyleBackColor = True
        '
        'FiveButton
        '
        Me.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FiveButton.Location = New System.Drawing.Point(122, 169)
        Me.FiveButton.Name = "FiveButton"
        Me.FiveButton.Size = New System.Drawing.Size(113, 77)
        Me.FiveButton.TabIndex = 9
        Me.FiveButton.Text = "5"
        Me.FiveButton.UseVisualStyleBackColor = True
        '
        'SixButton
        '
        Me.SixButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SixButton.Location = New System.Drawing.Point(241, 169)
        Me.SixButton.Name = "SixButton"
        Me.SixButton.Size = New System.Drawing.Size(113, 77)
        Me.SixButton.TabIndex = 10
        Me.SixButton.Text = "6"
        Me.SixButton.UseVisualStyleBackColor = True
        '
        'MinusButton
        '
        Me.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MinusButton.Location = New System.Drawing.Point(360, 169)
        Me.MinusButton.Name = "MinusButton"
        Me.MinusButton.Size = New System.Drawing.Size(116, 77)
        Me.MinusButton.TabIndex = 11
        Me.MinusButton.Text = "-"
        Me.MinusButton.UseVisualStyleBackColor = True
        '
        'OneButton
        '
        Me.OneButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OneButton.Location = New System.Drawing.Point(3, 252)
        Me.OneButton.Name = "OneButton"
        Me.OneButton.Size = New System.Drawing.Size(113, 77)
        Me.OneButton.TabIndex = 12
        Me.OneButton.Text = "1"
        Me.OneButton.UseVisualStyleBackColor = True
        '
        'TwoButton
        '
        Me.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TwoButton.Location = New System.Drawing.Point(122, 252)
        Me.TwoButton.Name = "TwoButton"
        Me.TwoButton.Size = New System.Drawing.Size(113, 77)
        Me.TwoButton.TabIndex = 13
        Me.TwoButton.Text = "2"
        Me.TwoButton.UseVisualStyleBackColor = True
        '
        'ThreeButton
        '
        Me.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThreeButton.Location = New System.Drawing.Point(241, 252)
        Me.ThreeButton.Name = "ThreeButton"
        Me.ThreeButton.Size = New System.Drawing.Size(113, 77)
        Me.ThreeButton.TabIndex = 14
        Me.ThreeButton.Text = "3"
        Me.ThreeButton.UseVisualStyleBackColor = True
        '
        'PlusButton
        '
        Me.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlusButton.Location = New System.Drawing.Point(360, 252)
        Me.PlusButton.Name = "PlusButton"
        Me.PlusButton.Size = New System.Drawing.Size(116, 77)
        Me.PlusButton.TabIndex = 15
        Me.PlusButton.Text = "+"
        Me.PlusButton.UseVisualStyleBackColor = True
        '
        'CEButton
        '
        Me.CEButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CEButton.Location = New System.Drawing.Point(3, 335)
        Me.CEButton.Name = "CEButton"
        Me.CEButton.Size = New System.Drawing.Size(113, 80)
        Me.CEButton.TabIndex = 16
        Me.CEButton.Text = "CE"
        Me.CEButton.UseVisualStyleBackColor = True
        '
        'ZeroButton
        '
        Me.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZeroButton.Location = New System.Drawing.Point(122, 335)
        Me.ZeroButton.Name = "ZeroButton"
        Me.ZeroButton.Size = New System.Drawing.Size(113, 80)
        Me.ZeroButton.TabIndex = 17
        Me.ZeroButton.Text = "0"
        Me.ZeroButton.UseVisualStyleBackColor = True
        '
        'PointButton
        '
        Me.PointButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PointButton.Location = New System.Drawing.Point(241, 335)
        Me.PointButton.Name = "PointButton"
        Me.PointButton.Size = New System.Drawing.Size(113, 80)
        Me.PointButton.TabIndex = 18
        Me.PointButton.Text = "."
        Me.PointButton.UseVisualStyleBackColor = True
        '
        'EqualsButton
        '
        Me.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EqualsButton.Location = New System.Drawing.Point(360, 335)
        Me.EqualsButton.Name = "EqualsButton"
        Me.EqualsButton.Size = New System.Drawing.Size(116, 80)
        Me.EqualsButton.TabIndex = 19
        Me.EqualsButton.Text = "="
        Me.EqualsButton.UseVisualStyleBackColor = True
        '
        'CalculationResultText
        '
        Me.CalculationResultText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalculationResultText.AutoSize = True
        Me.CalculationResultText.Location = New System.Drawing.Point(3, 44)
        Me.CalculationResultText.Name = "CalculationResultText"
        Me.CalculationResultText.Size = New System.Drawing.Size(244, 15)
        Me.CalculationResultText.TabIndex = 2
        Me.CalculationResultText.Text = "Please enter an equation and press enter or ="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 481)
        Me.Controls.Add(Me.CalculationResultText)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.UserInputText)
        Me.MinimumSize = New System.Drawing.Size(500, 520)
        Me.Name = "Form1"
        Me.Text = "Basic Calculator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserInputText As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DelButton As Button
    Friend WithEvents DivideButton As Button
    Friend WithEvents SevenButton As Button
    Friend WithEvents EightButton As Button
    Friend WithEvents NineButton As Button
    Friend WithEvents TimesButton As Button
    Friend WithEvents FourButton As Button
    Friend WithEvents FiveButton As Button
    Friend WithEvents SixButton As Button
    Friend WithEvents MinusButton As Button
    Friend WithEvents OneButton As Button
    Friend WithEvents TwoButton As Button
    Friend WithEvents ThreeButton As Button
    Friend WithEvents PlusButton As Button
    Friend WithEvents CEButton As Button
    Friend WithEvents ZeroButton As Button
    Friend WithEvents PointButton As Button
    Friend WithEvents EqualsButton As Button
    Friend WithEvents CalculationResultText As Label
End Class
