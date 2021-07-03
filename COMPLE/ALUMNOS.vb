Imports System.Data.SqlClient
Public Class ALUMNOS

    Private Sub btmregistrar_Click(sender As Object, e As EventArgs) Handles btmregistrar.Click
        Dim sexo As String = ""
        Dim conexion As String
        conexion = "Data Source=DESKTOP-9VF9AVL;Initial Catalog=alumnos;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        If radioF.Checked = True Then
            sexo = "F"
        End If

        If radioM.Checked = True Then
            sexo = "M"
        End If

        If (txtid.Text <> "" And txtnom.Text <> "" And txtape.Text <> "" And txtdir.Text <> "" And txttelefono.Text <> "" And txtedad.Text <> "" And txtid.Text <> "" And sexo <> "" And Val(txtedad.Text) >= 0 And Val(txtid.Text) >= 0) Then
            Dim adaptador As New SqlCommand("Insert into alumno values('" & txtid.Text & "', '" & txtnom.Text & "', '" & txtape.Text & "', '" & txtdir.Text & "', '" & txttelefono.Text & "', '" & sexo & "', '" & txtedad.Text & "')", cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MessageBox.Show("se registro correctamente")

            txtid.Text = ""
            txtnom.Text = ""
            txtape.Text = ""
            txtdir.Text = ""
            txttelefono.Text = ""
            txtedad.Text = ""

            cn.Close()
            cargardato()

        Else
            MessageBox.Show("no puede dejar campos vacios")
        End If

    End Sub

    Private Sub btmBuscar_Click(sender As Object, e As EventArgs) Handles btmBuscar.Click
        Dim radioFM As String
        Dim conexion As String
        conexion = "Data Source=DESKTOP-9VF9AVL;Initial Catalog=alumnos;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion

        Dim adaptador As New SqlDataAdapter("select * from alumno where codigo=" & txtid.Text & "", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            txtid.Text = ds.Tables("datos").Rows(0).Item(0).ToString
            txtnom.Text = ds.Tables("datos").Rows(0).Item(1).ToString
            txtape.Text = ds.Tables("datos").Rows(0).Item(2).ToString
            txtdir.Text = ds.Tables("datos").Rows(0).Item(3).ToString
            txttelefono.Text = ds.Tables("datos").Rows(0).Item(4).ToString
            radioFM = ds.Tables("datos").Rows(0).Item(5).ToString
            txtedad.Text = ds.Tables("datos").Rows(0).Item(6).ToString

            If radioFM = "F" Then
                radioF.Checked = True
            ElseIf radioFM = "M" Then
                radioM.Checked = True
            End If


        Else
            MessageBox.Show("no existe")
        End If

    End Sub

    Private Sub btmeliminar_Click(sender As Object, e As EventArgs) Handles btmeliminar.Click

        Dim conexion As String
        conexion = "Data Source=DESKTOP-9VF9AVL;Initial Catalog=alumnos;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()

        Dim comando As New SqlCommand("delete from alumno where codigo =" & txtid.Text & " ", cn)
        comando.ExecuteNonQuery()
        MessageBox.Show("se elimino correctamente")

        txtid.Text = ""
        txtnom.Text = ""
        txtape.Text = ""
        txtdir.Text = ""
        txttelefono.Text = ""
        txtedad.Text = ""

        cn.Close()
        cargardato()

    End Sub

    Private Sub btmactualizar_Click(sender As Object, e As EventArgs) Handles btmactualizar.Click
        Dim sexo As String = ""
        Dim conexion As String
        conexion = "Data Source=DESKTOP-9VF9AVL;Initial Catalog=alumnos;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        If radioF.Checked = True Then
            sexo = "F"
        End If

        If radioM.Checked = True Then
            sexo = "M"
        End If

        If (txtid.Text <> "" And txtnom.Text <> "" And txtape.Text <> "" And txtdir.Text <> "" And txttelefono.Text <> "" And txtedad.Text <> "" And txtid.Text <> "" And sexo <> "" And Val(txtedad.Text) >= 0 And Val(txtid.Text) >= 0) Then
            Dim adaptador As New SqlCommand("update alumno set codigo = '" & txtid.Text & "', nombre = '" & txtnom.Text & "', apellido = '" & txtape.Text & "', direccion = '" & txtdir.Text & "', telefono = '" & txttelefono.Text & "', sexo = '" & sexo & "', edad = " & txtedad.Text & " Where codigo = " & txtid.Text, cn)
            cn.Open()
            adaptador.ExecuteNonQuery()
            MessageBox.Show("datos actualizados")

            txtid.Text = ""
            txtnom.Text = ""
            txtape.Text = ""
            txtdir.Text = ""
            txttelefono.Text = ""
            txtedad.Text = ""

            cn.Close()
            cargardato()

        Else
            MessageBox.Show("no puede dejar campos vacios")
        End If

    End Sub

    Private Sub cargardato()

        Me.lvAlumnos.Items.Clear()

        Dim conexion As String
        conexion = "Data Source=DESKTOP-9VF9AVL;Initial Catalog=alumnos;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        Dim adaptador As New SqlDataAdapter("select * from alumno ", cn)
        Dim ds As New DataSet
        adaptador.Fill(ds, "datos")

        If ds.Tables("datos").Rows.Count > 0 Then
            Dim conteo = ds.Tables("datos").Rows.Count
            For i = 0 To conteo - 1
                Dim arr(7) As String
                arr(0) = ds.Tables("datos").Rows(i).Item(0).ToString
                arr(1) = ds.Tables("datos").Rows(i).Item(1).ToString
                arr(2) = ds.Tables("datos").Rows(i).Item(2).ToString
                arr(3) = ds.Tables("datos").Rows(i).Item(3).ToString
                arr(4) = ds.Tables("datos").Rows(i).Item(4).ToString
                arr(5) = ds.Tables("datos").Rows(i).Item(5).ToString
                arr(6) = ds.Tables("datos").Rows(i).Item(6).ToString

                Dim items As ListViewItem
                items = New ListViewItem(arr)
                Me.lvAlumnos.Items.Add(items)
            Next

        Else
            MessageBox.Show("no hay datos")
        End If

    End Sub

    Private Sub ALUMNOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardato()
    End Sub

    Private Sub btmlimpiar_Click(sender As Object, e As EventArgs) Handles btmlimpiar.Click

        Dim conexion As String
        conexion = "Data Source=DESKTOP-9VF9AVL;Initial Catalog=alumnos;Integrated Security=True"
        Dim cn As New SqlConnection
        cn.ConnectionString = conexion
        cn.Open()

        txtid.Text = ""
        txtnom.Text = ""
        txtape.Text = ""
        txtdir.Text = ""
        txttelefono.Text = ""
        txtedad.Text = ""

        cn.Close()

    End Sub
End Class
