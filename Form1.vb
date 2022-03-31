Public Class Form1
    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub AdventureWorksDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles AdventureWorksDataSetBindingSource.CurrentChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdventureWorksDataSet1.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.AdventureWorksDataSet1.Employee)

    End Sub
End Class
