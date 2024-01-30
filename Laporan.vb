Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class Laporan

    Dim cs As String = "Server=localhost;Database=penjualan-vb;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(cs)
    Private Sub barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' SQL query to retrieve data
        Dim query As String = "SELECT id_struk,id,id_barang,jumlah_barang,diskon,tunai,jumlah_total,kembalian FROM struk"

        ' Create a SqlConnection and a SqlDataAdapter
        Dim cm As New MySqlCommand(query, c)

        Dim adapter As New MySqlDataAdapter(cm)
        ' Create a DataTable to hold the data
        Dim dataTable As New DataTable()


        ' Fill the DataTable with data from the database
        adapter.Fill(dataTable)

        ' Bind the DataTable to the DataGridView
        tableTransaksi.DataSource = dataTable
        tableTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill



    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim leftmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left

        ' Print the header
        Dim tall As Integer = 10
        For Each column As DataGridViewColumn In tableTransaksi.Columns
            e.Graphics.DrawString(column.HeaderText, f10b, Brushes.Black, leftmargin, tall)
            leftmargin += 120 ' Adjust the horizontal spacing based on your needs
        Next

        ' Select all cells in the DataGridView
        tableTransaksi.SelectAll()

        ' Content
        tall += 20
        For Each erow As DataGridViewRow In tableTransaksi.SelectedRows
            leftmargin = PrintDocument1.DefaultPageSettings.Margins.Left
            tall += 20
            For Each cell As DataGridViewCell In erow.Cells
                e.Graphics.DrawString($"{cell.Value}", f8, Brushes.Black, leftmargin, tall)
                leftmargin += 120 ' Adjust the horizontal spacing based on your needs
            Next
        Next
    End Sub
    Private Sub printLaporan_Click(sender As Object, e As EventArgs) Handles printLaporan.Click
        ' Call the Print method to start the printing process
        PrintDocument1.Print()
    End Sub

    Private Sub akun_Click(sender As Object, e As EventArgs)
        Hide()
        Dim akun As New akun
        akun.Show()
    End Sub

    Private Sub barang_Click(sender As Object, e As EventArgs) Handles barang.Click
        Me.Hide()
        Dim barang As New barang()
        barang.Show()
    End Sub

    Private Sub Kasir_Click(sender As Object, e As EventArgs)
        Hide()
        Dim admin As New admin
        admin.Show()
    End Sub

    Private Sub history_Click(sender As Object, e As EventArgs) Handles history.Click
        Dim history As New Laporan()
        Me.Hide()
        history.Show()
    End Sub
End Class