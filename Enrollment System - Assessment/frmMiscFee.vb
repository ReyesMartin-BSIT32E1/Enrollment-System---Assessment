Public Class frmMiscFee
    Private Sub btnAddFee_Click(sender As Object, e As EventArgs) Handles btnAddFee.Click
        If String.IsNullOrWhiteSpace(txtFee.Text) Or numAmount.Value <= 0 Then
            Exit Sub
        End If
        For Each row As DataGridViewRow In frmStudentAssessment.dgvFee.Rows
            If row.Cells(0).Value = txtFee.Text Then
                frmStudentAssessment.dgvFee.Rows(row.Index).Cells(1).Value += Convert.ToDouble(numAmount.Text)
                Me.Close()
                Exit Sub
            End If
        Next
        Dim newrow = New DataGridViewRow
        newrow.CreateCells(frmStudentAssessment.dgvFee)
        newrow.Cells(0).Value = txtFee.Text
        newrow.Cells(1).Value = numAmount.Value
        frmStudentAssessment.dgvFee.Rows.Add(newrow)
        Me.Close()
    End Sub
End Class