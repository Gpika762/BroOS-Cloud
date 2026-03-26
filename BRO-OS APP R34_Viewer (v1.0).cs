/* * BRO-OS APP: R34_Viewer (v1.0)
 * COMPATIBILIDAD: Kernel v2.6 
 * ESTILO: Space Black / Neon Bayside
 */

// 1. INICIALIZACIÓN
Panel winR34 = CrearVentana("R34 PERFORMANCE & VIEWER", Color.FromArgb(10, 10, 15));

// 2. HEADER NEÓN (Bayside Blue)
Panel header = new Panel { 
    Dock = DockStyle.Top, 
    Height = 42, 
    BackColor = Color.FromArgb(25, 25, 30) 
};
Panel neonR34 = new Panel { 
    Dock = DockStyle.Bottom, 
    Height = 2, 
    BackColor = Color.FromArgb(0, 100, 255) 
};
header.Controls.Add(neonR34);

// 3. BOTÓN DE PÁNICO (Cerrado rápido con Lambda)
Button btnPanic = new Button { 
    Text = "X", 
    FlatStyle = FlatStyle.Flat, 
    Size = new Size(40, 40), 
    Dock = DockStyle.Right,
    ForeColor = Color.White 
};
btnPanic.FlatAppearance.BorderSize = 0;
btnPanic.Click += (s, e) => { 
    winR34.Dispose(); 
    MostrarNotificacion("R34_App: Sesión finalizada.", Color.DodgerBlue); 
};

// 4. CONTENEDOR DE IMÁGENES / TELEMETRÍA
PictureBox visor = new PictureBox {
    Dock = DockStyle.Fill,
    SizeMode = PictureBoxSizeMode.Zoom,
    BackColor = Color.Black
};

// 5. ENSAMBLAJE
header.Controls.Add(btnPanic);
winR34.Controls.Add(visor);
winR34.Controls.Add(header);

// NOTIFICACIÓN DE ARRANQUE
MostrarNotificacion("R34 Engine: READY BRO", Color.Cyan);