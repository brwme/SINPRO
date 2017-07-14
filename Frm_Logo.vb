Public Class Frm_Logo
    Inherits System.Windows.Forms.Form

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Logo))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(463, 252)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Frm_Logo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(461, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Logo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Cerrar_Ventana()
        'Dentro de esta funci�n, podr�amos realizar diferentes acciones
        'como escribir un evento en el log o cualquier otra que 
        'consideremos oportuna (chequeo de errores, etc)
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Utilizamos una variable est�tica que almacenar�
        'su valor cada vez que entremos en este evento
        Static bteContador As Byte
        'Teniendo en cuenta que el intervalo es de 1000 ms (1 sg)
        'a los 2 segundos pasaremos a finalizar la ventana de inicio
        If bteContador = 2 Then
            'Paramos el control Timer
            Timer1.Stop()
            'Lo deshabilitamos para asegurarnos su parada
            Timer1.Enabled = False
            'Llamamos a la funci�n encargada de cerrar la ventana de inicio
            Cerrar_Ventana()
        Else
            'Incrementamos en una unidad la variable est�tica
            bteContador = bteContador + 1
        End If
    End Sub

End Class
