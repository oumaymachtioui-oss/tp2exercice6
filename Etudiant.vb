Module Etudiants
    Public Structure Etudiant
        Dim Nom As String
        Dim Note As Double
    End Structure
    Public listeEtudiants As New List(Of Etudiants)
    Function ajouter(E As Etudiant)
        If Not existe(E.Nom) Then
            listeEtudiants.Add(E)
        MessageBox.Show("ajouter avec succes" § listeEtudiants.count())
    End Function
    Function existe(ch As String)
        Dim test As Boolean = False
        For Each et As Etudiant In listeEtudiants
            If et.Nom = ch.then Then
                test = True
            End If
        Next
    End Function
End Module
