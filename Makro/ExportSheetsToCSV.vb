Sub ExportSheetsToCSV()
    Dim tdate As Date
    Dim curDir As String
    Dim fso As Object
    Dim xWs As Worksheet
    Dim xcsvFile As String
    Dim outDir As String


    tdate = Date
    Set fso = CreateObject("scripting.filesystemobject")
    curDir = Application.ThisWorkbook.Path
    outDir = curDir & "\output" & Format(tdate, "dd-mm-yyyy")

    If Not fso.folderexists(outDir) Then
        fso.createfolder(outDir)
    End If

    For Each xWs In Application.ActiveWorkbook.Worksheets
        xWs.Copy
        xcsvFile = outDir & "\" & xWs.Name & ".csv"
        Application.ActiveWorkbook.SaveAs Filename:=xcsvFile,
        FileFormat:=xlCSV, CreateBackup:=False
        Application.ActiveWorkbook.Saved = True
        Application.ActiveWorkbook.Close
    Next
End Sub