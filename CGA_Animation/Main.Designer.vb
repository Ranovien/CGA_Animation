﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.Timer00 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(726, 547)
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(778, 32)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(142, 37)
        Me.btnMove.TabIndex = 1
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'Timer00
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 572)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.PictureBox)
        Me.Name = "Main"
        Me.Text = "Animation"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents btnMove As Button
    Friend WithEvents Timer00 As Timer
End Class
