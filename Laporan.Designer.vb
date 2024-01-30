<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class laporan
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
        tableTransaksi = New DataGridView()
        printLaporan = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        history = New Button()
        akun = New Button()
        barang = New Button()
        Kasir = New Button()
        PrintDocument2 = New Printing.PrintDocument()
        CType(tableTransaksi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tableTransaksi
        ' 
        tableTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tableTransaksi.Location = New Point(10, 50)
        tableTransaksi.Margin = New Padding(4, 3, 4, 3)
        tableTransaksi.Name = "tableTransaksi"
        tableTransaksi.Size = New Size(1151, 350)
        tableTransaksi.TabIndex = 0
        ' 
        ' printLaporan
        ' 
        printLaporan.Location = New Point(10, 406)
        printLaporan.Margin = New Padding(4, 3, 4, 3)
        printLaporan.Name = "printLaporan"
        printLaporan.Size = New Size(177, 27)
        printLaporan.TabIndex = 6
        printLaporan.Text = "cetak"
        printLaporan.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' history
        ' 
        history.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        history.Location = New Point(293, 12)
        history.Name = "history"
        history.Size = New Size(75, 23)
        history.TabIndex = 10
        history.Text = "Laporan"
        history.UseVisualStyleBackColor = True
        ' 
        ' akun
        ' 
        akun.Location = New Point(193, 12)
        akun.Name = "akun"
        akun.Size = New Size(94, 23)
        akun.TabIndex = 9
        akun.Text = "CRUD Akun"
        akun.UseVisualStyleBackColor = True
        ' 
        ' barang
        ' 
        barang.Location = New Point(93, 12)
        barang.Name = "barang"
        barang.Size = New Size(94, 23)
        barang.TabIndex = 8
        barang.Text = "CRUD Barang"
        barang.UseVisualStyleBackColor = True
        ' 
        ' Kasir
        ' 
        Kasir.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Kasir.Location = New Point(12, 12)
        Kasir.Name = "Kasir"
        Kasir.Size = New Size(75, 23)
        Kasir.TabIndex = 7
        Kasir.Text = "Kasir"
        Kasir.UseVisualStyleBackColor = True
        ' 
        ' laporan
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1176, 461)
        Controls.Add(history)
        Controls.Add(akun)
        Controls.Add(barang)
        Controls.Add(Kasir)
        Controls.Add(printLaporan)
        Controls.Add(tableTransaksi)
        Margin = New Padding(4, 3, 4, 3)
        Name = "laporan"
        Text = "Form1"
        CType(tableTransaksi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents tableTransaksi As DataGridView
    Friend WithEvents printLaporan As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents history As Button
    Friend WithEvents akun As Button
    Friend WithEvents barang As Button
    Friend WithEvents Kasir As Button
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
End Class
