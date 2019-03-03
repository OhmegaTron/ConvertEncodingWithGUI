Imports System.IO

Public Class TextConverterMainForm
    Public Function EncodingList() As DataTable
        Dim encodingTable As New DataTable()
        encodingTable.Columns.Add("id")
        encodingTable.Columns.Add("name")
        encodingTable.Columns.Add("description")

        encodingTable.Rows.Add("37", "IBM037", "IBM EBCDIC (US-Canada)")
        encodingTable.Rows.Add("437", "IBM437", "OEM United States")
        encodingTable.Rows.Add("500", "IBM500", "IBM EBCDIC (International)")
        encodingTable.Rows.Add("708", "ASMO-708", "Arabic (ASMO 708)")
        encodingTable.Rows.Add("720", "DOS-720", "Arabic (DOS)")
        encodingTable.Rows.Add("737", "ibm737", "Greek (DOS)")
        encodingTable.Rows.Add("775", "ibm775", "Baltic (DOS)")
        encodingTable.Rows.Add("850", "ibm850", "Western European (DOS)")
        encodingTable.Rows.Add("852", "ibm852", "Central European (DOS)")
        encodingTable.Rows.Add("855", "IBM855", "OEM Cyrillic")
        encodingTable.Rows.Add("857", "ibm857", "Turkish (DOS)")
        encodingTable.Rows.Add("858", "IBM00858", "OEM Multilingual Latin I")
        encodingTable.Rows.Add("860", "IBM860", "Portuguese (DOS)")
        encodingTable.Rows.Add("861", "ibm861", "Icelandic (DOS)")
        encodingTable.Rows.Add("862", "DOS-862", "Hebrew (DOS)")
        encodingTable.Rows.Add("863", "IBM863", "French Canadian (DOS)")
        encodingTable.Rows.Add("864", "IBM864", "Arabic (864)")
        encodingTable.Rows.Add("865", "IBM865", "Nordic (DOS)")
        encodingTable.Rows.Add("866", "cp866", "Cyrillic (DOS)")
        encodingTable.Rows.Add("869", "ibm869", "Greek, Modern (DOS)")
        encodingTable.Rows.Add("870", "IBM870", "IBM EBCDIC (Multilingual Latin-2)")
        encodingTable.Rows.Add("874", "windows-874", "Thai (Windows)")
        encodingTable.Rows.Add("875", "cp875", "IBM EBCDIC (Greek Modern)")
        encodingTable.Rows.Add("932", "shift_jis", "Japanese (Shift-JIS)")
        encodingTable.Rows.Add("936", "gb2312", "Chinese Simplified (GB2312)")
        encodingTable.Rows.Add("949", "ks_c_5601-1987", "Korean")
        encodingTable.Rows.Add("950", "big5", "Chinese Traditional (Big5)")
        encodingTable.Rows.Add("1026", "IBM1026", "IBM EBCDIC (Turkish Latin-5)")
        encodingTable.Rows.Add("1047", "IBM01047", "IBM Latin-1")
        encodingTable.Rows.Add("1140", "IBM01140", "IBM EBCDIC (US-Canada-Euro)")
        encodingTable.Rows.Add("1141", "IBM01141", "IBM EBCDIC (Germany-Euro)")
        encodingTable.Rows.Add("1142", "IBM01142", "IBM EBCDIC (Denmark-Norway-Euro)")
        encodingTable.Rows.Add("1143", "IBM01143", "IBM EBCDIC (Finland-Sweden-Euro)")
        encodingTable.Rows.Add("1144", "IBM01144", "IBM EBCDIC (Italy-Euro)")
        encodingTable.Rows.Add("1145", "IBM01145", "IBM EBCDIC (Spain-Euro)")
        encodingTable.Rows.Add("1146", "IBM01146", "IBM EBCDIC (UK-Euro)")
        encodingTable.Rows.Add("1147", "IBM01147", "IBM EBCDIC (France-Euro)")
        encodingTable.Rows.Add("1148", "IBM01148", "IBM EBCDIC (International-Euro)")
        encodingTable.Rows.Add("1149", "IBM01149", "IBM EBCDIC (Icelandic-Euro)")
        encodingTable.Rows.Add("1200", "utf-16", "Unicode")
        encodingTable.Rows.Add("1201", "unicodeFFFE", "Unicode (Big endian)")
        encodingTable.Rows.Add("1250", "windows-1250", "Central European (Windows)")
        encodingTable.Rows.Add("1251", "windows-1251", "Cyrillic (Windows)")
        encodingTable.Rows.Add("1252", "Windows-1252", "Western European (Windows)")
        encodingTable.Rows.Add("1253", "windows-1253", "Greek (Windows)")
        encodingTable.Rows.Add("1254", "windows-1254", "Turkish (Windows)")
        encodingTable.Rows.Add("1255", "windows-1255", "Hebrew (Windows)")
        encodingTable.Rows.Add("1256", "windows-1256", "Arabic (Windows)")
        encodingTable.Rows.Add("1257", "windows-1257", "Baltic (Windows)")
        encodingTable.Rows.Add("1258", "windows-1258", "Vietnamese (Windows)")
        encodingTable.Rows.Add("1361", "Johab", "Korean (Johab)")
        encodingTable.Rows.Add("10000", "macintosh", "Western European (Mac)")
        encodingTable.Rows.Add("10001", "x-mac-japanese", "Japanese (Mac)")
        encodingTable.Rows.Add("10002", "x-mac-chinesetrad", "Chinese Traditional (Mac)")
        encodingTable.Rows.Add("10003", "x-mac-korean", "Korean (Mac)")
        encodingTable.Rows.Add("10004", "x-mac-arabic", "Arabic (Mac)")
        encodingTable.Rows.Add("10005", "x-mac-hebrew", "Hebrew (Mac)")
        encodingTable.Rows.Add("10006", "x-mac-greek", "Greek (Mac)")
        encodingTable.Rows.Add("10007", "x-mac-cyrillic", "Cyrillic (Mac)")
        encodingTable.Rows.Add("10008", "x-mac-chinesesimp", "Chinese Simplified (Mac)")
        encodingTable.Rows.Add("10010", "x-mac-romanian", "Romanian (Mac)")
        encodingTable.Rows.Add("10017", "x-mac-ukrainian", "Ukrainian (Mac)")
        encodingTable.Rows.Add("10021", "x-mac-thai", "Thai (Mac)")
        encodingTable.Rows.Add("10029", "x-mac-ce", "Central European (Mac)")
        encodingTable.Rows.Add("10079", "x-mac-icelandic", "Icelandic (Mac)")
        encodingTable.Rows.Add("10081", "x-mac-turkish", "Turkish (Mac)")
        encodingTable.Rows.Add("10082", "x-mac-croatian", "Croatian (Mac)")
        encodingTable.Rows.Add("12000", "utf-32", "Unicode (UTF-32)")
        encodingTable.Rows.Add("12001", "utf-32BE", "Unicode (UTF-32 Big endian)")
        encodingTable.Rows.Add("20000", "x-Chinese-CNS", "Chinese Traditional (CNS)")
        encodingTable.Rows.Add("20001", "x-cp20001", "TCA Taiwan")
        encodingTable.Rows.Add("20002", "x-Chinese-Eten", "Chinese Traditional (Eten)")
        encodingTable.Rows.Add("20003", "x-cp20003", "IBM5550 Taiwan")
        encodingTable.Rows.Add("20004", "x-cp20004", "TeleText Taiwan")
        encodingTable.Rows.Add("20005", "x-cp20005", "Wang Taiwan")
        encodingTable.Rows.Add("20105", "x-IA5", "Western European (IA5)")
        encodingTable.Rows.Add("20106", "x-IA5-German", "German (IA5)")
        encodingTable.Rows.Add("20107", "x-IA5-Swedish", "Swedish (IA5)")
        encodingTable.Rows.Add("20108", "x-IA5-Norwegian", "Norwegian (IA5)")
        encodingTable.Rows.Add("20127", "us-ascii", "US-ASCII")
        encodingTable.Rows.Add("20261", "x-cp20261", "T.61")
        encodingTable.Rows.Add("20269", "x-cp20269", "ISO-6937")
        encodingTable.Rows.Add("20273", "IBM273", "IBM EBCDIC (Germany)")
        encodingTable.Rows.Add("20277", "IBM277", "IBM EBCDIC (Denmark-Norway)")
        encodingTable.Rows.Add("20278", "IBM278", "IBM EBCDIC (Finland-Sweden)")
        encodingTable.Rows.Add("20280", "IBM280", "IBM EBCDIC (Italy)")
        encodingTable.Rows.Add("20284", "IBM284", "IBM EBCDIC (Spain)")
        encodingTable.Rows.Add("20285", "IBM285", "IBM EBCDIC (UK)")
        encodingTable.Rows.Add("20290", "IBM290", "IBM EBCDIC (Japanese katakana)")
        encodingTable.Rows.Add("20297", "IBM297", "IBM EBCDIC (France)")
        encodingTable.Rows.Add("20420", "IBM420", "IBM EBCDIC (Arabic)")
        encodingTable.Rows.Add("20423", "IBM423", "IBM EBCDIC (Greek)")
        encodingTable.Rows.Add("20424", "IBM424", "IBM EBCDIC (Hebrew)")
        encodingTable.Rows.Add("20833", "x-EBCDIC-KoreanExtended", "IBM EBCDIC (Korean Extended)")
        encodingTable.Rows.Add("20838", "IBM-Thai", "IBM EBCDIC (Thai)")
        encodingTable.Rows.Add("20866", "koi8-r", "Cyrillic (KOI8-R)")
        encodingTable.Rows.Add("20871", "IBM871", "IBM EBCDIC (Icelandic)")
        encodingTable.Rows.Add("20880", "IBM880", "IBM EBCDIC (Cyrillic Russian)")
        encodingTable.Rows.Add("20905", "IBM905", "IBM EBCDIC (Turkish)")
        encodingTable.Rows.Add("20924", "IBM00924", "IBM Latin-1")
        encodingTable.Rows.Add("20932", "EUC-JP", "Japanese (JIS 0208-1990 and 0212-1990)")
        encodingTable.Rows.Add("20936", "x-cp20936", "Chinese Simplified (GB2312-80)")
        encodingTable.Rows.Add("20949", "x-cp20949", "Korean Wansung")
        encodingTable.Rows.Add("21025", "cp1025", "IBM EBCDIC (Cyrillic Serbian-Bulgarian)")
        encodingTable.Rows.Add("21866", "koi8-u", "Cyrillic (KOI8-U)")
        encodingTable.Rows.Add("28591", "iso-8859-1", "Western European (ISO)")
        encodingTable.Rows.Add("28592", "iso-8859-2", "Central European (ISO)")
        encodingTable.Rows.Add("28593", "iso-8859-3", "Latin 3 (ISO)")
        encodingTable.Rows.Add("28594", "iso-8859-4", "Baltic (ISO)")
        encodingTable.Rows.Add("28595", "iso-8859-5", "Cyrillic (ISO)")
        encodingTable.Rows.Add("28596", "iso-8859-6", "Arabic (ISO)")
        encodingTable.Rows.Add("28597", "iso-8859-7", "Greek (ISO)")
        encodingTable.Rows.Add("28598", "iso-8859-8", "Hebrew (ISO-Visual)")
        encodingTable.Rows.Add("28599", "iso-8859-9", "Turkish (ISO)")
        encodingTable.Rows.Add("28603", "iso-8859-13", "Estonian (ISO)")
        encodingTable.Rows.Add("28605", "iso-8859-15", "Latin 9 (ISO)")
        encodingTable.Rows.Add("29001", "x-Europa", "Europa")
        encodingTable.Rows.Add("38598", "iso-8859-8-i", "Hebrew (ISO-Logical)")
        encodingTable.Rows.Add("50220", "iso-2022-jp", "Japanese (JIS)")
        encodingTable.Rows.Add("50221", "csISO2022JP", "Japanese (JIS-Allow 1 byte Kana)")
        encodingTable.Rows.Add("50222", "iso-2022-jp", "Japanese (JIS-Allow 1 byte Kana - SO/SI)")
        encodingTable.Rows.Add("50225", "iso-2022-kr", "Korean (ISO)")
        encodingTable.Rows.Add("50227", "x-cp50227", "Chinese Simplified (ISO-2022)")
        encodingTable.Rows.Add("51932", "euc-jp", "Japanese (EUC)")
        encodingTable.Rows.Add("51936", "EUC-CN", "Chinese Simplified (EUC)")
        encodingTable.Rows.Add("51949", "euc-kr", "Korean (EUC)")
        encodingTable.Rows.Add("52936", "hz-gb-2312", "Chinese Simplified (HZ)")
        encodingTable.Rows.Add("54936", "GB18030", "Chinese Simplified (GB18030)")
        encodingTable.Rows.Add("57002", "x-iscii-de", "ISCII Devanagari")
        encodingTable.Rows.Add("57003", "x-iscii-be", "ISCII Bengali")
        encodingTable.Rows.Add("57004", "x-iscii-ta", "ISCII Tamil")
        encodingTable.Rows.Add("57005", "x-iscii-te", "ISCII Telugu")
        encodingTable.Rows.Add("57006", "x-iscii-as", "ISCII Assamese")
        encodingTable.Rows.Add("57007", "x-iscii-or", "ISCII Oriya")
        encodingTable.Rows.Add("57008", "x-iscii-ka", "ISCII Kannada")
        encodingTable.Rows.Add("57009", "x-iscii-ma", "ISCII Malayalam")
        encodingTable.Rows.Add("57010", "x-iscii-gu", "ISCII Gujarati")
        encodingTable.Rows.Add("57011", "x-iscii-pa", "ISCII Punjabi")
        encodingTable.Rows.Add("65000", "utf-7", "Unicode (UTF-7)")
        encodingTable.Rows.Add("65001", "utf-8", "Unicode (UTF-8)")

        EncodingList = encodingTable
    End Function

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        ' Endcodings https://docs.microsoft.com/en-us/dotnet/api/system.text.encoding?view=netframework-4.7.2
        'Private Sub TranslateFile(ByVal sourceEbcdicFilePath As String, ByVal newAsciiFilePath As String)
        ' System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)

        'Get encoding objects from values in comboboxes
        Dim inputEncodingID As Integer = Convert.ToInt32(cmbBoxInputEncoding.SelectedValue("id"))
        Dim outputEncodingID As Integer = Convert.ToInt32(cmbBoxOutputEncoding.SelectedValue("id"))
        Dim inputEncoding As System.Text.Encoding = System.Text.Encoding.GetEncoding(inputEncodingID)
        Dim outputEncoding As System.Text.Encoding = System.Text.Encoding.GetEncoding(outputEncodingID)


        'Set the encoding to the EBCDIC code page.
        'Dim encoding As System.Text.Encoding = System.Text.Encoding.GetEncoding(37)

        'Set this to the length of an EBCDIC line or block.
        Dim lineLength As Integer = 134

        'Buffer used to store characters read in from the statement input file.
        Dim buffer(lineLength - 1) As Char

        'Open the EBCDIC file for reading using the EBCDIC encoding.
        Dim reader As New IO.StreamReader(txtBoxFilePathInput.Text, inputEncoding)

        'Open a file to write out the data to.
        Dim writer As New IO.StreamWriter(txtBoxFilePathOutput.Text, False, outputEncoding)

        'This is a string to store the translated line.
        Dim strAscii As String = String.Empty

        'This variable increments every time a block of data is read
        Dim iLoops As Integer = 0

        'Loop through the EBCDIC file.
        Do Until reader.EndOfStream = True

            'Read in a block of data from the EBCDIC file.
            reader.ReadBlock(buffer, 0, lineLength)

            'Translate the string using the EBCDIC encoding.
            strAscii = inputEncoding.GetString(inputEncoding.GetBytes(buffer))

            'Write the translated string out to a file.
            writer.WriteLine(strAscii)

            'Only call DoEvents every 1000 loops (increases performance)
            ' iLoops += 1
            ' If iLoops = 1000 Then

            '  Application.DoEvents()

            '  iLoops = 0 'reset

            ' End If

        Loop

        'Close files.
        reader.Close()
        writer.Close()

        'Release resources.
        reader.Dispose()
        writer.Dispose()

    End Sub


    Private Sub CloseProgram(sender As Object, e As EventArgs) Handles btnCloseProgram.Click
        'Exit button, closes the program
        Me.Close()
    End Sub

    Private Sub comboBoxLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate input encoding combobox
        cmbBoxInputEncoding.DataSource = EncodingList()
        cmbBoxInputEncoding.DisplayMember = "description"
    End Sub

    Private Sub cmbBoxOutputEncoding_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate output encoding combobox
        cmbBoxOutputEncoding.DataSource = EncodingList()
        cmbBoxOutputEncoding.DisplayMember = "description"
    End Sub

    Private Sub btnBrowseForInputFile_Click(sender As Object, e As EventArgs) Handles btnBrowseForInputFile.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtBoxFilePathInput.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnBrowseForOutputFile_Click(sender As Object, e As EventArgs) Handles btnBrowseForOutputFile.Click
        If SaveFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtBoxFilePathOutput.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub lblDescription_Click(sender As Object, e As EventArgs) Handles lblDescription.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub
End Class
