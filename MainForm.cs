
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Agenda
{

	public partial class MainForm : Form
	{
		MyConexion mariaDB;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			mariaDB= new MyConexion();
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			panelAgregar.Enabled=true;
			panelAgregar.Show();
			
			panelModificar.Enabled=false;
			panelModificar.Hide();
			
			panelVer.Enabled=false;
			panelVer.Hide();
			
			panelEliminar.Enabled=false;
			panelEliminar.Hide();
			
			this.limpiarModificar();
			this.limpiarAgregar();
	
	
		}
		void BtnMofificarClick(object sender, EventArgs e)
		{
			panelAgregar.Enabled=false;
			panelAgregar.Hide();
			
			panelModificar.Enabled=true;
			panelModificar.Show();
			
			panelVer.Enabled=false;
			panelVer.Hide();
			
			panelEliminar.Enabled=false;
			panelEliminar.Hide();
			
			this.limpiarModificar();
			this.limpiarAgregar();
	
	
		}
		void BtnVerClick(object sender, EventArgs e)
		{
			lbCargando.Show();
			
			panelAgregar.Enabled=false;
			panelAgregar.Hide();
			
			panelModificar.Enabled=false;
			panelModificar.Hide();
			
			panelEliminar.Enabled=false;
			panelEliminar.Hide();
			
			panelVer.Enabled=true;
			panelVer.Show();
			
			dataVContactos.DataSource = mariaDB.verContactos();
			dataVContactos.DataMember = "contactos";
			lbCargando.Dispose();
			
				
			
			
			this.limpiarModificar();
			this.limpiarAgregar();
	
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			panelAgregar.Enabled=false;
			panelAgregar.Hide();
			
			panelModificar.Enabled=false;
			panelModificar.Hide();
			
			panelVer.Enabled=false;
			panelVer.Hide();
			
			panelEliminar.Enabled=true;
			panelEliminar.Show();
			
	
		}
		void BtnAgregarListoClick(object sender, EventArgs e)
		{
			int errores = 0;
			errorNotFound.Dispose();
			
			Contacto contactoNuevo = new Contacto();
			
			contactoNuevo.setId(mariaDB.asingarID());
			
			if (tbNombre.Text.Length >= 5 && tbNombre.Text.Length <= 20){
				contactoNuevo.setNombre(tbNombre.Text);
			}
			else {
				errorNotFound.SetError(tbNombre,"El nombre debe tener entre 5 y 20 caracteres");
				errores++;
			}
			
			if (tbApellidos.Text.Length >= 10 && tbApellidos.Text.Length <=30){
				contactoNuevo.setApellidos(tbApellidos.Text);
			}
			else{
				errorNotFound.SetError(tbApellidos," Los apellidos contener entre 10 y 30 caracteres");
				errores++;
			}
			
			if (tbTelefono.Text.Length >= 0 && tbTelefono.Text.Length <= 8){
				try{
					contactoNuevo.setTelefono(Int64.Parse(tbTelefono.Text));
				}
				catch (Exception){
					errorNotFound.SetError(tbTelefono,"Debes introducir solo numeros");
					errores++;
				}
				
			}
			
			else{
				errorNotFound.SetError(tbTelefono," el telefono contener solo de 0 a 8 numeros");
				errores++;
			}
			
			if (tbDomicilio.Text.Length >= 5 && tbDomicilio.Text.Length <= 30){
				contactoNuevo.setDomicilio(tbDomicilio.Text);
			}
			else {
				errorNotFound.SetError(tbDomicilio," El domicilio debe contener entre 5 y 30 caracteres");
				errores++;
			}
			
			if(tbEmail.Text.Length >= 10 && tbEmail.Text.Length <= 30){
				contactoNuevo.setEmail(tbEmail.Text);
			}
			
			else {
				errorNotFound.SetError(tbEmail," El email debe contener entre 10 y 30 caracteres");
				errores++;
			}
			
			if (errores == 0){
				mariaDB.agregarRegistro(contactoNuevo);
				this.limpiarAgregar();
			}
			errores=0;
	
		}
		
		void BtnBuscarMClick(object sender, EventArgs e)
		{
			try{
				Contacto contactoM = mariaDB.buscarContactoPorID(tbIdM.Text);
					if (mariaDB.buscarContactoPorID(tbIdM.Text)!=null){
						tbNombreM.Text = (contactoM.getNombre());
						tbApellidosM.Text = (contactoM.getApellidos());
						tbTelefonoM.Text = (string.Concat(contactoM.getTelefono()));
						tbDomiclioM.Text = (contactoM.getDomicilio());
						tbEmailM.Text = (contactoM.getEmail());
						errorNotFound.Dispose();
						tbIdM.Enabled=false;
						btnBuscarM.Enabled=false;
				}
			}catch (Exception){
				errorNotFound.SetError(tbIdM," El Numero De ID no es valido");
			  
			}
			
		}
		
		void BtnListoMClick(object sender, EventArgs e)
		{
			int errores=0;
			
			Contacto contactoMo = new Contacto();
			errorNotFound.Dispose();
			
			if (tbIdM.Text.Length > 0 && tbIdM.Text.Length<5){
					contactoMo.setId(int.Parse(tbIdM.Text));
			}
			else {
				errorNotFound.SetError(tbIdM," El Numero De ID no es valido");
				errores++;
			}
			
			if (tbNombreM.Text.Length >= 5 && tbNombreM.Text.Length <= 20){
				contactoMo.setNombre(tbNombreM.Text);
			}
			else {
				errorNotFound.SetError(tbNombreM," El Nombre No Es Valido");
				errores++;
			}
			
			if(tbApellidosM.Text.Length >= 10 && tbApellidosM.Text.Length <= 30){
				contactoMo.setApellidos(tbApellidosM.Text);	
			}
			else {
				errorNotFound.SetError(tbApellidosM," Los Apellidos  No Son Validos");
				errores++;
			}
			
			if (tbTelefonoM.Text.Length >= 0 && tbTelefonoM.Text.Length <= 8){
				try{
					contactoMo.setTelefono(Int64.Parse(tbTelefonoM.Text));
				}catch (Exception){
					errorNotFound.SetError(tbTelefonoM," Debes Ingresar Solo Numeros");
					errores++;
				}
			}
			else{
				errorNotFound.SetError(tbTelefonoM, "el telefono contener solo de 0 a 8 numeros ");
				errores++;
			}
			
			if (tbDomiclioM.Text.Length >= 5 && tbDomiclioM.Text.Length <= 30){
				contactoMo.setDomicilio(tbDomiclioM.Text);
			}
			else{
				errorNotFound.SetError(tbDomiclioM, "El domicilio debe contener entre 5 y 30 caracteres");
				errores++;
			}
			
			if (tbEmailM.Text.Length >= 10 && tbEmailM.Text.Length <= 30){
				contactoMo.setEmail(tbEmailM.Text);
			}
			else{
				errorNotFound.SetError(tbEmailM, "El email debe contener entre 10 y 30 caracteres");
				errores++;
			}
			
			
			if(errores == 0){
				mariaDB.actualizarContactoPorId(tbIdM.Text , contactoMo);
				this.limpiarModificar();
				tbIdM.Enabled=true;
				btnBuscarM.Enabled=true;
				
				
			}
			
	
		}
		void BtnEliminarCClick(object sender, EventArgs e)
		{
			errorNotFound.Dispose();
			try{
				if(mariaDB.eliminarContactoPorId(tbIdE.Text)>0)
					tbIdE.ResetText();
				else
					errorNotFound.SetError(tbIdE," El ID no es valido");
			}catch (Exception){
				errorNotFound.SetError(tbIdE," El ID solo contiene numeros");
			}
					
				
			
		}
		
		protected void limpiarAgregar(){
			tbNombre.ResetText();
			tbApellidos.ResetText();
			tbTelefono.ResetText();
			tbDomicilio.ResetText();
			tbEmail.ResetText();
			
		}
		
		protected void limpiarModificar(){
			tbIdM.ResetText();
			tbNombreM.ResetText();
			tbApellidosM.ResetText();
			tbTelefonoM.ResetText();
			tbDomiclioM.ResetText();
			tbEmailM.ResetText();
		}
		


	}
}
