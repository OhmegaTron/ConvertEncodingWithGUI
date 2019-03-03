<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TextConverterMainForm
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmbBoxOutputEncoding = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBrowseForOutputFile = New System.Windows.Forms.Button()
        Me.txtBoxFilePathOutput = New System.Windows.Forms.TextBox()
        Me.btnCloseProgram = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxFilePathInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBrowseForInputFile = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbBoxInputEncoding = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(675, 187)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "&Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(2, 26)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(294, 13)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Choose inputfile and save file + encodings and press convert"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 22)
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
        Me.Panel2.Controls.Add(Me.btnBrowseForOutputFile)
        Me.Panel2.Controls.Add(Me.txtBoxFilePathOutput)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(446, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 112)
        Me.Panel2.TabIndex = 17
        '
        'cmbBoxOutputEncoding
        '
        Me.cmbBoxOutputEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxOutputEncoding.FormattingEnabled = True
        Me.cmbBoxOutputEncoding.Location = New System.Drawing.Point(79, 73)
        Me.cmbBoxOutputEncoding.Name = "cmbBoxOutputEncoding"
        Me.cmbBoxOutputEncoding.Size = New System.Drawing.Size(306, 21)
        Me.cmbBoxOutputEncoding.Sorted = True
        Me.cmbBoxOutputEncoding.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Encoding"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "FilePath"
        '
        'btnBrowseForOutputFile
        '
        Me.btnBrowseForOutputFile.Location = New System.Drawing.Point(310, 43)
        Me.btnBrowseForOutputFile.Name = "btnBrowseForOutputFile"
        Me.btnBrowseForOutputFile.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseForOutputFile.TabIndex = 16
        Me.btnBrowseForOutputFile.Text = "Browse"
        Me.btnBrowseForOutputFile.UseVisualStyleBackColor = True
        '
        'txtBoxFilePathOutput
        '
        Me.txtBoxFilePathOutput.Location = New System.Drawing.Point(79, 45)
        Me.txtBoxFilePathOutput.Name = "txtBoxFilePathOutput"
        Me.txtBoxFilePathOutput.Size = New System.Drawing.Size(225, 20)
        Me.txtBoxFilePathOutput.TabIndex = 14
        '
        'btnCloseProgram
        '
        Me.btnCloseProgram.Location = New System.Drawing.Point(774, 187)
        Me.btnCloseProgram.Name = "btnCloseProgram"
        Me.btnCloseProgram.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseProgram.TabIndex = 18
        Me.btnCloseProgram.Text = "E&xit"
        Me.btnCloseProgram.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Input file and encoding"
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
        Me.Label3.Location = New System.Drawing.Point(10, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "FilePath"
        '
        'btnBrowseForInputFile
        '
        Me.btnBrowseForInputFile.Location = New System.Drawing.Point(312, 44)
        Me.btnBrowseForInputFile.Name = "btnBrowseForInputFile"
        Me.btnBrowseForInputFile.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseForInputFile.TabIndex = 14
        Me.btnBrowseForInputFile.Text = "Browse"
        Me.btnBrowseForInputFile.UseVisualStyleBackColor = True
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
        Me.Panel1.Controls.Add(Me.btnBrowseForInputFile)
        Me.Panel1.Controls.Add(Me.txtBoxFilePathInput)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(3, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 112)
        Me.Panel1.TabIndex = 16
        '
        'cmbBoxInputEncoding
        '
        Me.cmbBoxInputEncoding.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.cmbBoxInputEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoxInputEncoding.FormattingEnabled = True
        Me.cmbBoxInputEncoding.Location = New System.Drawing.Point(68, 76)
        Me.cmbBoxInputEncoding.Name = "cmbBoxInputEncoding"
        Me.cmbBoxInputEncoding.Size = New System.Drawing.Size(319, 21)
        Me.cmbBoxInputEncoding.Sorted = True
        Me.cmbBoxInputEncoding.TabIndex = 16
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(858, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "menuMainForm"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TextConverterMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 225)
        Me.Controls.Add(Me.btnCloseProgram)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "TextConverterMainForm"
        Me.Text = "Text converter"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBoxFilePathOutput As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBrowseForOutputFile As Button
    Friend WithEvents btnCloseProgram As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxFilePathInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBrowseForInputFile As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbBoxInputEncoding As ComboBox
    Friend WithEvents cmbBoxOutputEncoding As ComboBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
