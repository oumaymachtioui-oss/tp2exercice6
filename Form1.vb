Public Class Form1
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim Nom As String
        Dim Prenom As String
        Dim Note As Double
        Dim etudiants As Etudiant

        Nom = txtNom.text
        Note = CDbl(txtNote.text)
        If Nom = "" Then
            MessageBox.Show("Veuillez indiquer le nom", "Erreur")
            Return
        End If
        If Prenom = "" Then
            MessageBox.Show("Veuillez indiquer le prénom", "Erreur")
            Return
        End If
        If Not (0 <= Note <= 20) Then
            MessageBox.Show("veuillez introduire une note entre 0 et 20", "erreur")
            Return
        End If
        etudiant.Nom = Nom
        etudiant.Note = Note
        ajouter(etudiant)
    End Sub