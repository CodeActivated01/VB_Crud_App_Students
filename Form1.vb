Imports System.Data.SqlClient

Public Class Form1
    Dim connectionString As String = "Data Source=LAPTOP-2DC7CSUK\SQLEXPRESS;Initial Catalog=VBCrudTable;Integrated Security=True"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayData()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) OrElse String.IsNullOrWhiteSpace(TextBox3.Text) OrElse String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If
        If TextBox5.Text = "" Then

            Dim query As String = "INSERT INTO Student (Name, Class, Address, PhoneNumber) VALUES (@Name, @Class, @Address, @PhoneNumber)"
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@PhoneNumber", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@Address", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@Class", TextBox4.Text)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record added successfully!")
                End Using
            End Using
            DisplayData()
            ClearFields()
        Else
            MessageBox.Show("Please add new record it's already exists.")
            ClearFields()

        End If

    End Sub
    Private Sub DisplayData()
        Dim query As String = "SELECT * FROM Student"
        Using conn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridView1.DataSource = table
        End Using
    End Sub
    Private Sub ClearFields()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Id As Integer

        If Integer.TryParse(TextBox5.Text, Id) Then
            Dim query As String = "UPDATE Student SET Name = @Name, Class = @Class, Address = @Address, PhoneNumber = @PhoneNumber WHERE Id = @Id"
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Name", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@Class", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@Address", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@PhoneNumber", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@Id", TextBox5.Text)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully!")
                End Using
            End Using
            DisplayData()
            ClearFields()
        Else
            MessageBox.Show("You are trying to update new record..!! Please select records first from grid table to update.")
            ClearFields()

        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Populate textboxes with the selected row's data
            TextBox1.Text = row.Cells("Name").Value.ToString()
            TextBox2.Text = row.Cells("Class").Value.ToString()
            TextBox3.Text = row.Cells("Address").Value.ToString()
            TextBox4.Text = row.Cells("PhoneNumber").Value.ToString()
            TextBox5.Text = row.Cells("Id").Value.ToString()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Id As Integer

        If Integer.TryParse(TextBox5.Text, Id) Then
            Dim query As String = "Delete From Student  WHERE Id = @Id"
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Id", TextBox5.Text)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record deleted successfully!")
                End Using
            End Using
            DisplayData()
            ClearFields()
        Else
            MessageBox.Show("Can't delete new records ..!! Please select records first from grid table to delete.")
            ClearFields()
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' Allow control keys (e.g., backspace, delete, etc.)
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        ' Allow only digits and a single decimal point
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
        End If
    End Sub
End Class
