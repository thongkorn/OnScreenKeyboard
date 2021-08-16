<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOnScreenKeyBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnShowKeyboard = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnHideKeyboard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnShowKeyboard
        '
        Me.btnShowKeyboard.Location = New System.Drawing.Point(22, 14)
        Me.btnShowKeyboard.Name = "btnShowKeyboard"
        Me.btnShowKeyboard.Size = New System.Drawing.Size(215, 45)
        Me.btnShowKeyboard.TabIndex = 0
        Me.btnShowKeyboard.Text = "Show keyboard"
        Me.btnShowKeyboard.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(22, 78)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(510, 243)
        Me.TextBox1.TabIndex = 2
        '
        'btnHideKeyboard
        '
        Me.btnHideKeyboard.Location = New System.Drawing.Point(317, 14)
        Me.btnHideKeyboard.Name = "btnHideKeyboard"
        Me.btnHideKeyboard.Size = New System.Drawing.Size(215, 45)
        Me.btnHideKeyboard.TabIndex = 3
        Me.btnHideKeyboard.Text = "Hide keyboard"
        Me.btnHideKeyboard.UseVisualStyleBackColor = True
        '
        'frmOnScreenKeyBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 333)
        Me.Controls.Add(Me.btnHideKeyboard)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnShowKeyboard)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmOnScreenKeyBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demo On Screen Keyboard - coDe bY: Thongkorn Tubtimkrob"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowKeyboard As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnHideKeyboard As System.Windows.Forms.Button
End Class
