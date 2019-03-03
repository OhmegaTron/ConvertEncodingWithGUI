<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtBoxEncodingOutput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbBoxOutputEncoding = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtBoxFilePathOutput = New System.Windows.Forms.TextBox()
        Me.btnCloseProgram = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBxEncodingInput = New System.Windows.Forms.TextBox()
        Me.txtBoxFilePathInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbBoxInputEncoding = New System.Windows.Forms.ComboBox()
        Me.txtBoxTest = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(675, 261)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "&Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(12, 46)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(126, 13)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Desription of this program"
        '
        'txtBoxEncodingOutput
        '
        Me.txtBoxEncodingOutput.Location = New System.Drawing.Point(79, 70)
        Me.txtBoxEncodingOutput.Name = "txtBoxEncodingOutput"
        Me.txtBoxEncodingOutput.Size = New System.Drawing.Size(105, 20)
        Me.txtBoxEncodingOutput.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Output file and encoding"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbBoxOutputEncoding)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.txtBoxFilePathOutput)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtBoxEncodingOutput)
        Me.Panel2.Location = New System.Drawing.Point(446, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 150)
        Me.Panel2.TabIndex = 17
        '
        'cmbBoxOutputEncoding
        '
        Me.cmbBoxOutputEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxOutputEncoding.FormattingEnabled = True
        Me.cmbBoxOutputEncoding.Location = New System.Drawing.Point(24, 112)
        Me.cmbBoxOutputEncoding.Name = "cmbBoxOutputEncoding"
        Me.cmbBoxOutputEncoding.Size = New System.Drawing.Size(361, 21)
        Me.cmbBoxOutputEncoding.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Encoding"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "FilePath"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(310, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtBoxFilePathOutput
        '
        Me.txtBoxFilePathOutput.Location = New System.Drawing.Point(79, 40)
        Me.txtBoxFilePathOutput.Name = "txtBoxFilePathOutput"
        Me.txtBoxFilePathOutput.Size = New System.Drawing.Size(225, 20)
        Me.txtBoxFilePathOutput.TabIndex = 14
        '
        'btnCloseProgram
        '
        Me.btnCloseProgram.Location = New System.Drawing.Point(774, 261)
        Me.btnCloseProgram.Name = "btnCloseProgram"
        Me.btnCloseProgram.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseProgram.TabIndex = 18
        Me.btnCloseProgram.Text = "E&xit"
        Me.btnCloseProgram.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Input file and encoding"
        '
        'txtBxEncodingInput
        '
        Me.txtBxEncodingInput.Location = New System.Drawing.Point(68, 73)
        Me.txtBxEncodingInput.Name = "txtBxEncodingInput"
        Me.txtBxEncodingInput.Size = New System.Drawing.Size(121, 20)
        Me.txtBxEncodingInput.TabIndex = 2
        '
        'txtBoxFilePathInput
        '
        Me.txtBoxFilePathInput.Location = New System.Drawing.Point(68, 47)
        Me.txtBoxFilePathInput.Name = "txtBoxFilePathInput"
        Me.txtBoxFilePathInput.Size = New System.Drawing.Size(238, 20)
        Me.txtBoxFilePathInput.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "FilePath"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Encoding"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbBoxInputEncoding)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtBxEncodingInput)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtBoxFilePathInput)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 150)
        Me.Panel1.TabIndex = 16
        '
        'cmbBoxInputEncoding
        '
        Me.cmbBoxInputEncoding.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cmbBoxInputEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxInputEncoding.FormattingEnabled = True
        Me.cmbBoxInputEncoding.Location = New System.Drawing.Point(9, 112)
        Me.cmbBoxInputEncoding.Name = "cmbBoxInputEncoding"
        Me.cmbBoxInputEncoding.Size = New System.Drawing.Size(364, 21)
        Me.cmbBoxInputEncoding.TabIndex = 16
        '
        'txtBoxTest
        '
        Me.txtBoxTest.Location = New System.Drawing.Point(26, 261)
        Me.txtBoxTest.Name = "txtBoxTest"
        Me.txtBoxTest.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTest.TabIndex = 19
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(148, 261)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 20
        Me.btnTest.Text = "Button3"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 306)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.txtBoxTest)
        Me.Controls.Add(Me.btnCloseProgram)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtBoxEncodingOutput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBoxFilePathOutput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCloseProgram As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBxEncodingInput As TextBox
    Friend WithEvents txtBoxFilePathInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbBoxInputEncoding As ComboBox
    Friend WithEvents cmbBoxOutputEncoding As ComboBox
    Friend WithEvents txtBoxTest As TextBox
    Friend WithEvents btnTest As Button
End Class
