<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorRace_NumberOfPlayers
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.fourPlayersButton = New System.Windows.Forms.Button()
        Me.threePlayersButton = New System.Windows.Forms.Button()
        Me.twoPlayersButton = New System.Windows.Forms.Button()
        Me.onePlayerButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.fourPlayersButton, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.threePlayersButton, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.twoPlayersButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.onePlayerButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(313, 176)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'fourPlayersButton
        '
        Me.fourPlayersButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.fourPlayersButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fourPlayersButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourPlayersButton.Location = New System.Drawing.Point(3, 143)
        Me.fourPlayersButton.Name = "fourPlayersButton"
        Me.fourPlayersButton.Size = New System.Drawing.Size(307, 30)
        Me.fourPlayersButton.TabIndex = 4
        Me.fourPlayersButton.Tag = "4"
        Me.fourPlayersButton.Text = "4 joueurs"
        Me.fourPlayersButton.UseMnemonic = False
        Me.fourPlayersButton.UseVisualStyleBackColor = True
        '
        'threePlayersButton
        '
        Me.threePlayersButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.threePlayersButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.threePlayersButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.threePlayersButton.Location = New System.Drawing.Point(3, 108)
        Me.threePlayersButton.Name = "threePlayersButton"
        Me.threePlayersButton.Size = New System.Drawing.Size(307, 29)
        Me.threePlayersButton.TabIndex = 3
        Me.threePlayersButton.Tag = "3"
        Me.threePlayersButton.Text = "3 joueurs"
        Me.threePlayersButton.UseVisualStyleBackColor = True
        '
        'twoPlayersButton
        '
        Me.twoPlayersButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.twoPlayersButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.twoPlayersButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.twoPlayersButton.Location = New System.Drawing.Point(3, 73)
        Me.twoPlayersButton.Name = "twoPlayersButton"
        Me.twoPlayersButton.Size = New System.Drawing.Size(307, 29)
        Me.twoPlayersButton.TabIndex = 2
        Me.twoPlayersButton.Tag = "2"
        Me.twoPlayersButton.Text = "2 joueurs"
        Me.twoPlayersButton.UseVisualStyleBackColor = True
        '
        'onePlayerButton
        '
        Me.onePlayerButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.onePlayerButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.onePlayerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onePlayerButton.Location = New System.Drawing.Point(3, 38)
        Me.onePlayerButton.Name = "onePlayerButton"
        Me.onePlayerButton.Size = New System.Drawing.Size(307, 29)
        Me.onePlayerButton.TabIndex = 1
        Me.onePlayerButton.Tag = "1"
        Me.onePlayerButton.Text = "1 joueur"
        Me.onePlayerButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choisissez le nombre de joueurs :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColorRace_NumberOfPlayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 176)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ColorRace_NumberOfPlayers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sélectionnez le nombre de joueurs"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents fourPlayersButton As Button
    Friend WithEvents threePlayersButton As Button
    Friend WithEvents twoPlayersButton As Button
    Friend WithEvents onePlayerButton As Button
    Friend WithEvents Label1 As Label
End Class
