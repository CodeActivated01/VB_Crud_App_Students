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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        TextBox5 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell Extra Bold", 20.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(610, -4)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 47)
        Label1.TabIndex = 0
        Label1.Text = "CRUD APP"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonFace
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Rockwell Extra Bold", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.GrayText
        Label2.Location = New Point(589, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 37)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(736, 101)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Please Enter Name"
        TextBox1.Size = New Size(181, 31)
        TextBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonFace
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Rockwell Extra Bold", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.GrayText
        Label3.Location = New Point(551, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 37)
        Label3.TabIndex = 3
        Label3.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonFace
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Rockwell Extra Bold", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.GrayText
        Label4.Location = New Point(600, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 37)
        Label4.TabIndex = 4
        Label4.Text = "Class"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonFace
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Rockwell Extra Bold", 15.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.GrayText
        Label5.Location = New Point(423, 245)
        Label5.Name = "Label5"
        Label5.Size = New Size(289, 37)
        Label5.TabIndex = 5
        Label5.Text = "Phone Number"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(736, 251)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Please Enter Number"
        TextBox2.Size = New Size(181, 31)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(736, 202)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Please Enter Address"
        TextBox3.Size = New Size(181, 31)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(736, 153)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Please Enter Class"
        TextBox4.Size = New Size(181, 31)
        TextBox4.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Font = New Font("Rockwell", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(502, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 34)
        Button1.TabIndex = 9
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Rockwell", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(854, 305)
        Button2.Name = "Button2"
        Button2.Size = New Size(133, 34)
        Button2.TabIndex = 10
        Button2.Text = "DELETE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Aqua
        Button3.Font = New Font("Rockwell", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(681, 305)
        Button3.Name = "Button3"
        Button3.Size = New Size(133, 34)
        Button3.TabIndex = 11
        Button3.Text = "UPDATE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(334, 345)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(800, 400)
        DataGridView1.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(736, 64)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "Id"
        TextBox5.Size = New Size(181, 31)
        TextBox5.TabIndex = 13
        TextBox5.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1398, 687)
        Controls.Add(TextBox5)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox5 As TextBox

End Class
