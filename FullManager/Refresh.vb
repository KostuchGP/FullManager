Public Class Refresh
    Inherits System.Windows.Forms.Button

    'Prywatne dane, na których będziemy pracować.
    Private instanceButton As System.Windows.Forms.Button

    'konstruktor
    Sub New(ByVal instanceBtn As System.Windows.Forms.Button)
        instanceButton = instanceBtn
    End Sub

    'Metoda sub, która będzie wykonywana na obiekcie
    Public Sub SetShape(ByVal picture As System.Drawing.Bitmap, ByVal bordersize As Integer, ByVal borderColor As System.Drawing.Color)
        instanceButton.BackgroundImage = picture
        instanceButton.FlatAppearance.BorderSize = bordersize
        instanceButton.FlatAppearance.BorderColor = borderColor
    End Sub

    'Metoda sub na start
    Public Sub StartShape(ByVal bordersize As Integer, ByVal flatstyle As FlatStyle, ByVal usevisualstylebackcolor As Boolean, ByVal backcolor As System.Drawing.Color, _
                          ByVal mouseoverbackcolor As System.Drawing.Color, ByVal bordercolor As System.Drawing.Color)
        instanceButton.FlatAppearance.BorderSize = bordersize
        instanceButton.FlatStyle = flatstyle
        instanceButton.UseVisualStyleBackColor = usevisualstylebackcolor
        instanceButton.BackColor = backcolor
        instanceButton.FlatAppearance.MouseOverBackColor = mouseoverbackcolor
        instanceButton.FlatAppearance.BorderColor = bordercolor
    End Sub

End Class
