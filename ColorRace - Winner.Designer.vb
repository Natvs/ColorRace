<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorRace_Winner
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.winnerLabel = New System.Windows.Forms.Label()
        Me.reenitializeButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'winnerLabel
        '
        Me.winnerLabel.AutoSize = True
        Me.winnerLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.winnerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winnerLabel.Location = New System.Drawing.Point(3, 0)
        Me.winnerLabel.Name = "winnerLabel"
        Me.winnerLabel.Size = New System.Drawing.Size(278, 97)
        Me.winnerLabel.TabIndex = 0
        Me.winnerLabel.Text = "Le joueur + couleur + a gagné"
        Me.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'reenitializeButton
        '
        Me.reenitializeButton.BackColor = System.Drawing.Color.White
        Me.reenitializeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reenitializeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reenitializeButton.Location = New System.Drawing.Point(3, 100)
        Me.reenitializeButton.Name = "reenitializeButton"
        Me.reenitializeButton.Size = New System.Drawing.Size(278, 91)
        Me.reenitializeButton.TabIndex = 1
        Me.reenitializeButton.Text = "Quitter"
        Me.reenitializeButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.winnerLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.reenitializeButton, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(284, 194)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ColorRace_Winner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 194)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ColorRace_Winner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vous avez gagné !!!"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents winnerLabel As Label
    Friend WithEvents reenitializeButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
