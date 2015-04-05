/*
 * Created by SharpDevelop.
 * User: Martin
 * Date: 27/03/2015
 * Time: 10:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Agenda
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnMofificar;
		private System.Windows.Forms.Button btnVer;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label ldescripcion;
		private System.Windows.Forms.Panel panelAgregar;
		private System.Windows.Forms.Label lbNombre;
		private System.Windows.Forms.TextBox tbEmail;
		private System.Windows.Forms.TextBox tbDomicilio;
		private System.Windows.Forms.TextBox tbTelefono;
		private System.Windows.Forms.TextBox tbApellidos;
		private System.Windows.Forms.TextBox tbNombre;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.Label lbDomicilio;
		private System.Windows.Forms.Label lbTelefono;
		private System.Windows.Forms.Label lbApellidos;
		private System.Windows.Forms.Button btnAgregarListo;
		private System.Windows.Forms.Panel panelModificar;
		private System.Windows.Forms.Label lbIdM;
		private System.Windows.Forms.TextBox tbIdM;
		private System.Windows.Forms.Button btnListoM;
		private System.Windows.Forms.TextBox tbEmailM;
		private System.Windows.Forms.TextBox tbDomiclioM;
		private System.Windows.Forms.TextBox tbTelefonoM;
		private System.Windows.Forms.TextBox tbApellidosM;
		private System.Windows.Forms.TextBox tbNombreM;
		private System.Windows.Forms.Label lbEmailM;
		private System.Windows.Forms.Label lbDomicilioM;
		private System.Windows.Forms.Label lbTelefonoM;
		private System.Windows.Forms.Label lbApellidoM;
		private System.Windows.Forms.Label lbNombreM;
		private System.Windows.Forms.Button btnBuscarM;
		private System.Windows.Forms.Panel panelVer;
		private System.Windows.Forms.Panel panelEliminar;
		private System.Windows.Forms.TextBox tbIdE;
		private System.Windows.Forms.Label lbIdE;
		private System.Windows.Forms.Button btnEliminarC;
		private System.Windows.Forms.DataGridView dataVContactos;
		private System.Windows.Forms.ErrorProvider errorNotFound;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnMofificar = new System.Windows.Forms.Button();
			this.btnVer = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.ldescripcion = new System.Windows.Forms.Label();
			this.panelAgregar = new System.Windows.Forms.Panel();
			this.btnAgregarListo = new System.Windows.Forms.Button();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbDomicilio = new System.Windows.Forms.TextBox();
			this.tbTelefono = new System.Windows.Forms.TextBox();
			this.tbApellidos = new System.Windows.Forms.TextBox();
			this.tbNombre = new System.Windows.Forms.TextBox();
			this.lbEmail = new System.Windows.Forms.Label();
			this.lbDomicilio = new System.Windows.Forms.Label();
			this.lbTelefono = new System.Windows.Forms.Label();
			this.lbApellidos = new System.Windows.Forms.Label();
			this.lbNombre = new System.Windows.Forms.Label();
			this.panelModificar = new System.Windows.Forms.Panel();
			this.btnBuscarM = new System.Windows.Forms.Button();
			this.lbIdM = new System.Windows.Forms.Label();
			this.tbIdM = new System.Windows.Forms.TextBox();
			this.btnListoM = new System.Windows.Forms.Button();
			this.tbEmailM = new System.Windows.Forms.TextBox();
			this.tbDomiclioM = new System.Windows.Forms.TextBox();
			this.tbTelefonoM = new System.Windows.Forms.TextBox();
			this.tbApellidosM = new System.Windows.Forms.TextBox();
			this.tbNombreM = new System.Windows.Forms.TextBox();
			this.lbEmailM = new System.Windows.Forms.Label();
			this.lbDomicilioM = new System.Windows.Forms.Label();
			this.lbTelefonoM = new System.Windows.Forms.Label();
			this.lbApellidoM = new System.Windows.Forms.Label();
			this.lbNombreM = new System.Windows.Forms.Label();
			this.panelEliminar = new System.Windows.Forms.Panel();
			this.btnEliminarC = new System.Windows.Forms.Button();
			this.tbIdE = new System.Windows.Forms.TextBox();
			this.lbIdE = new System.Windows.Forms.Label();
			this.panelVer = new System.Windows.Forms.Panel();
			this.dataVContactos = new System.Windows.Forms.DataGridView();
			this.errorNotFound = new System.Windows.Forms.ErrorProvider(this.components);
			this.panelAgregar.SuspendLayout();
			this.panelModificar.SuspendLayout();
			this.panelEliminar.SuspendLayout();
			this.panelVer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataVContactos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorNotFound)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.Location = new System.Drawing.Point(216, 54);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(64, 64);
			this.btnAgregar.TabIndex = 0;
			this.btnAgregar.Tag = "";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnMofificar
			// 
			this.btnMofificar.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnMofificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMofificar.Image = ((System.Drawing.Image)(resources.GetObject("btnMofificar.Image")));
			this.btnMofificar.Location = new System.Drawing.Point(297, 54);
			this.btnMofificar.Name = "btnMofificar";
			this.btnMofificar.Size = new System.Drawing.Size(64, 64);
			this.btnMofificar.TabIndex = 1;
			this.btnMofificar.UseVisualStyleBackColor = false;
			this.btnMofificar.Click += new System.EventHandler(this.BtnMofificarClick);
			// 
			// btnVer
			// 
			this.btnVer.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVer.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
			this.btnVer.Location = new System.Drawing.Point(377, 54);
			this.btnVer.Name = "btnVer";
			this.btnVer.Size = new System.Drawing.Size(64, 64);
			this.btnVer.TabIndex = 2;
			this.btnVer.UseVisualStyleBackColor = false;
			this.btnVer.Click += new System.EventHandler(this.BtnVerClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.Location = new System.Drawing.Point(458, 54);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(64, 64);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// ldescripcion
			// 
			this.ldescripcion.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
			this.ldescripcion.Location = new System.Drawing.Point(319, 16);
			this.ldescripcion.Name = "ldescripcion";
			this.ldescripcion.Size = new System.Drawing.Size(121, 26);
			this.ldescripcion.TabIndex = 4;
			this.ldescripcion.Text = "Contactos";
			// 
			// panelAgregar
			// 
			this.panelAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelAgregar.Controls.Add(this.btnAgregarListo);
			this.panelAgregar.Controls.Add(this.tbEmail);
			this.panelAgregar.Controls.Add(this.tbDomicilio);
			this.panelAgregar.Controls.Add(this.tbTelefono);
			this.panelAgregar.Controls.Add(this.tbApellidos);
			this.panelAgregar.Controls.Add(this.tbNombre);
			this.panelAgregar.Controls.Add(this.lbEmail);
			this.panelAgregar.Controls.Add(this.lbDomicilio);
			this.panelAgregar.Controls.Add(this.lbTelefono);
			this.panelAgregar.Controls.Add(this.lbApellidos);
			this.panelAgregar.Controls.Add(this.lbNombre);
			this.panelAgregar.Enabled = false;
			this.panelAgregar.Location = new System.Drawing.Point(224, 130);
			this.panelAgregar.Name = "panelAgregar";
			this.panelAgregar.Size = new System.Drawing.Size(292, 235);
			this.panelAgregar.TabIndex = 5;
			this.panelAgregar.Visible = false;
			// 
			// btnAgregarListo
			// 
			this.btnAgregarListo.Location = new System.Drawing.Point(124, 188);
			this.btnAgregarListo.Name = "btnAgregarListo";
			this.btnAgregarListo.Size = new System.Drawing.Size(75, 23);
			this.btnAgregarListo.TabIndex = 10;
			this.btnAgregarListo.Text = "Listo";
			this.btnAgregarListo.UseVisualStyleBackColor = true;
			this.btnAgregarListo.Click += new System.EventHandler(this.BtnAgregarListoClick);
			// 
			// tbEmail
			// 
			this.tbEmail.Location = new System.Drawing.Point(81, 157);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(182, 20);
			this.tbEmail.TabIndex = 9;
			// 
			// tbDomicilio
			// 
			this.tbDomicilio.Location = new System.Drawing.Point(81, 122);
			this.tbDomicilio.Name = "tbDomicilio";
			this.tbDomicilio.Size = new System.Drawing.Size(182, 20);
			this.tbDomicilio.TabIndex = 8;
			// 
			// tbTelefono
			// 
			this.tbTelefono.Location = new System.Drawing.Point(81, 86);
			this.tbTelefono.Name = "tbTelefono";
			this.tbTelefono.Size = new System.Drawing.Size(182, 20);
			this.tbTelefono.TabIndex = 7;
			// 
			// tbApellidos
			// 
			this.tbApellidos.Location = new System.Drawing.Point(81, 53);
			this.tbApellidos.Name = "tbApellidos";
			this.tbApellidos.Size = new System.Drawing.Size(182, 20);
			this.tbApellidos.TabIndex = 6;
			// 
			// tbNombre
			// 
			this.tbNombre.Location = new System.Drawing.Point(81, 21);
			this.tbNombre.Name = "tbNombre";
			this.tbNombre.Size = new System.Drawing.Size(182, 20);
			this.tbNombre.TabIndex = 5;
			// 
			// lbEmail
			// 
			this.lbEmail.AutoSize = true;
			this.lbEmail.Location = new System.Drawing.Point(24, 160);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(32, 13);
			this.lbEmail.TabIndex = 4;
			this.lbEmail.Text = "Email";
			// 
			// lbDomicilio
			// 
			this.lbDomicilio.AutoSize = true;
			this.lbDomicilio.Location = new System.Drawing.Point(12, 125);
			this.lbDomicilio.Name = "lbDomicilio";
			this.lbDomicilio.Size = new System.Drawing.Size(49, 13);
			this.lbDomicilio.TabIndex = 3;
			this.lbDomicilio.Text = "Domicilio";
			// 
			// lbTelefono
			// 
			this.lbTelefono.AutoSize = true;
			this.lbTelefono.Location = new System.Drawing.Point(12, 89);
			this.lbTelefono.Name = "lbTelefono";
			this.lbTelefono.Size = new System.Drawing.Size(49, 13);
			this.lbTelefono.TabIndex = 2;
			this.lbTelefono.Text = "Telefono";
			// 
			// lbApellidos
			// 
			this.lbApellidos.AutoSize = true;
			this.lbApellidos.Location = new System.Drawing.Point(12, 56);
			this.lbApellidos.Name = "lbApellidos";
			this.lbApellidos.Size = new System.Drawing.Size(49, 13);
			this.lbApellidos.TabIndex = 1;
			this.lbApellidos.Text = "Apellidos";
			// 
			// lbNombre
			// 
			this.lbNombre.AutoSize = true;
			this.lbNombre.Location = new System.Drawing.Point(12, 24);
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Size = new System.Drawing.Size(44, 13);
			this.lbNombre.TabIndex = 0;
			this.lbNombre.Text = "Nombre";
			// 
			// panelModificar
			// 
			this.panelModificar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelModificar.Controls.Add(this.btnBuscarM);
			this.panelModificar.Controls.Add(this.lbIdM);
			this.panelModificar.Controls.Add(this.tbIdM);
			this.panelModificar.Controls.Add(this.btnListoM);
			this.panelModificar.Controls.Add(this.tbEmailM);
			this.panelModificar.Controls.Add(this.tbDomiclioM);
			this.panelModificar.Controls.Add(this.tbTelefonoM);
			this.panelModificar.Controls.Add(this.tbApellidosM);
			this.panelModificar.Controls.Add(this.tbNombreM);
			this.panelModificar.Controls.Add(this.lbEmailM);
			this.panelModificar.Controls.Add(this.lbDomicilioM);
			this.panelModificar.Controls.Add(this.lbTelefonoM);
			this.panelModificar.Controls.Add(this.lbApellidoM);
			this.panelModificar.Controls.Add(this.lbNombreM);
			this.panelModificar.Enabled = false;
			this.panelModificar.Location = new System.Drawing.Point(224, 130);
			this.panelModificar.Name = "panelModificar";
			this.panelModificar.Size = new System.Drawing.Size(292, 235);
			this.panelModificar.TabIndex = 16;
			this.panelModificar.Visible = false;
			// 
			// btnBuscarM
			// 
			this.btnBuscarM.Location = new System.Drawing.Point(203, 16);
			this.btnBuscarM.Name = "btnBuscarM";
			this.btnBuscarM.Size = new System.Drawing.Size(60, 21);
			this.btnBuscarM.TabIndex = 13;
			this.btnBuscarM.Text = "Buscar";
			this.btnBuscarM.UseVisualStyleBackColor = true;
			this.btnBuscarM.Click += new System.EventHandler(this.BtnBuscarMClick);
			// 
			// lbIdM
			// 
			this.lbIdM.AutoSize = true;
			this.lbIdM.Location = new System.Drawing.Point(37, 24);
			this.lbIdM.Name = "lbIdM";
			this.lbIdM.Size = new System.Drawing.Size(18, 13);
			this.lbIdM.TabIndex = 12;
			this.lbIdM.Text = "ID";
			// 
			// tbIdM
			// 
			this.tbIdM.Location = new System.Drawing.Point(81, 17);
			this.tbIdM.Name = "tbIdM";
			this.tbIdM.Size = new System.Drawing.Size(116, 20);
			this.tbIdM.TabIndex = 11;
			// 
			// btnListoM
			// 
			this.btnListoM.Location = new System.Drawing.Point(124, 205);
			this.btnListoM.Name = "btnListoM";
			this.btnListoM.Size = new System.Drawing.Size(75, 23);
			this.btnListoM.TabIndex = 10;
			this.btnListoM.Text = "Listo";
			this.btnListoM.UseVisualStyleBackColor = true;
			this.btnListoM.Click += new System.EventHandler(this.BtnListoMClick);
			// 
			// tbEmailM
			// 
			this.tbEmailM.Location = new System.Drawing.Point(81, 181);
			this.tbEmailM.Name = "tbEmailM";
			this.tbEmailM.Size = new System.Drawing.Size(182, 20);
			this.tbEmailM.TabIndex = 9;
			// 
			// tbDomiclioM
			// 
			this.tbDomiclioM.Location = new System.Drawing.Point(81, 148);
			this.tbDomiclioM.Name = "tbDomiclioM";
			this.tbDomiclioM.Size = new System.Drawing.Size(182, 20);
			this.tbDomiclioM.TabIndex = 8;
			// 
			// tbTelefonoM
			// 
			this.tbTelefonoM.Location = new System.Drawing.Point(81, 112);
			this.tbTelefonoM.Name = "tbTelefonoM";
			this.tbTelefonoM.Size = new System.Drawing.Size(182, 20);
			this.tbTelefonoM.TabIndex = 7;
			// 
			// tbApellidosM
			// 
			this.tbApellidosM.Location = new System.Drawing.Point(81, 79);
			this.tbApellidosM.Name = "tbApellidosM";
			this.tbApellidosM.Size = new System.Drawing.Size(182, 20);
			this.tbApellidosM.TabIndex = 6;
			// 
			// tbNombreM
			// 
			this.tbNombreM.Location = new System.Drawing.Point(81, 47);
			this.tbNombreM.Name = "tbNombreM";
			this.tbNombreM.Size = new System.Drawing.Size(182, 20);
			this.tbNombreM.TabIndex = 5;
			// 
			// lbEmailM
			// 
			this.lbEmailM.AutoSize = true;
			this.lbEmailM.Location = new System.Drawing.Point(24, 184);
			this.lbEmailM.Name = "lbEmailM";
			this.lbEmailM.Size = new System.Drawing.Size(32, 13);
			this.lbEmailM.TabIndex = 4;
			this.lbEmailM.Text = "Email";
			// 
			// lbDomicilioM
			// 
			this.lbDomicilioM.AutoSize = true;
			this.lbDomicilioM.Location = new System.Drawing.Point(12, 151);
			this.lbDomicilioM.Name = "lbDomicilioM";
			this.lbDomicilioM.Size = new System.Drawing.Size(49, 13);
			this.lbDomicilioM.TabIndex = 3;
			this.lbDomicilioM.Text = "Domicilio";
			// 
			// lbTelefonoM
			// 
			this.lbTelefonoM.AutoSize = true;
			this.lbTelefonoM.Location = new System.Drawing.Point(12, 115);
			this.lbTelefonoM.Name = "lbTelefonoM";
			this.lbTelefonoM.Size = new System.Drawing.Size(49, 13);
			this.lbTelefonoM.TabIndex = 2;
			this.lbTelefonoM.Text = "Telefono";
			// 
			// lbApellidoM
			// 
			this.lbApellidoM.AutoSize = true;
			this.lbApellidoM.Location = new System.Drawing.Point(12, 82);
			this.lbApellidoM.Name = "lbApellidoM";
			this.lbApellidoM.Size = new System.Drawing.Size(49, 13);
			this.lbApellidoM.TabIndex = 1;
			this.lbApellidoM.Text = "Apellidos";
			// 
			// lbNombreM
			// 
			this.lbNombreM.AutoSize = true;
			this.lbNombreM.Location = new System.Drawing.Point(17, 50);
			this.lbNombreM.Name = "lbNombreM";
			this.lbNombreM.Size = new System.Drawing.Size(44, 13);
			this.lbNombreM.TabIndex = 0;
			this.lbNombreM.Text = "Nombre";
			// 
			// panelEliminar
			// 
			this.panelEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelEliminar.Controls.Add(this.btnEliminarC);
			this.panelEliminar.Controls.Add(this.tbIdE);
			this.panelEliminar.Controls.Add(this.lbIdE);
			this.panelEliminar.Enabled = false;
			this.panelEliminar.Location = new System.Drawing.Point(224, 130);
			this.panelEliminar.Name = "panelEliminar";
			this.panelEliminar.Size = new System.Drawing.Size(292, 235);
			this.panelEliminar.TabIndex = 17;
			this.panelEliminar.Visible = false;
			// 
			// btnEliminarC
			// 
			this.btnEliminarC.Location = new System.Drawing.Point(110, 125);
			this.btnEliminarC.Name = "btnEliminarC";
			this.btnEliminarC.Size = new System.Drawing.Size(75, 23);
			this.btnEliminarC.TabIndex = 2;
			this.btnEliminarC.Text = "Eliminar";
			this.btnEliminarC.UseVisualStyleBackColor = true;
			this.btnEliminarC.Click += new System.EventHandler(this.BtnEliminarCClick);
			// 
			// tbIdE
			// 
			this.tbIdE.Location = new System.Drawing.Point(148, 78);
			this.tbIdE.Name = "tbIdE";
			this.tbIdE.Size = new System.Drawing.Size(100, 20);
			this.tbIdE.TabIndex = 1;
			// 
			// lbIdE
			// 
			this.lbIdE.Location = new System.Drawing.Point(56, 81);
			this.lbIdE.Name = "lbIdE";
			this.lbIdE.Size = new System.Drawing.Size(100, 23);
			this.lbIdE.TabIndex = 0;
			this.lbIdE.Text = "ID del Contacto";
			// 
			// panelVer
			// 
			this.panelVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelVer.Controls.Add(this.dataVContactos);
			this.panelVer.Enabled = false;
			this.panelVer.Location = new System.Drawing.Point(30, 130);
			this.panelVer.Name = "panelVer";
			this.panelVer.Size = new System.Drawing.Size(695, 235);
			this.panelVer.TabIndex = 18;
			this.panelVer.Visible = false;
			// 
			// dataVContactos
			// 
			this.dataVContactos.AllowUserToAddRows = false;
			this.dataVContactos.AllowUserToDeleteRows = false;
			this.dataVContactos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dataVContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataVContactos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataVContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataVContactos.Location = new System.Drawing.Point(0, 0);
			this.dataVContactos.Name = "dataVContactos";
			this.dataVContactos.ReadOnly = true;
			this.dataVContactos.Size = new System.Drawing.Size(695, 235);
			this.dataVContactos.TabIndex = 4;
			// 
			// errorNotFound
			// 
			this.errorNotFound.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorNotFound.ContainerControl = this;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 397);
			this.Controls.Add(this.panelVer);
			this.Controls.Add(this.panelEliminar);
			this.Controls.Add(this.panelModificar);
			this.Controls.Add(this.panelAgregar);
			this.Controls.Add(this.ldescripcion);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnVer);
			this.Controls.Add(this.btnMofificar);
			this.Controls.Add(this.btnAgregar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Agenda";
			this.panelAgregar.ResumeLayout(false);
			this.panelAgregar.PerformLayout();
			this.panelModificar.ResumeLayout(false);
			this.panelModificar.PerformLayout();
			this.panelEliminar.ResumeLayout(false);
			this.panelEliminar.PerformLayout();
			this.panelVer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataVContactos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorNotFound)).EndInit();
			this.ResumeLayout(false);

		}
		
	}
}
