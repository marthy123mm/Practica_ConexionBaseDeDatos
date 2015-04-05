
using System;

namespace Agenda
{

	public class Contacto	
	{
		private int id;
		private String nombre;
		private String apellidos;
		private Int64 telefono;
		private String domicilio;
		private String email;
		
		public Contacto(int id, String nombre, String apellidos, Int64 telefono, String domicilio, String email)
		{
			this.id=id;
			this.nombre=nombre;
			this.apellidos=apellidos;
			this.telefono=telefono;
			this.domicilio=domicilio;
			this.email=email;
			
		}
		
		public Contacto(int id){
			this.id=id;
		}
		
		public Contacto(){
			
		}
		
		//METODOS SET
		
		public void setId(int id){
			this.id=id;
		}
		
		public void setNombre(String nombre){
			this.nombre=nombre;
		}
		
		public void setApellidos(String apellidos){
			this.apellidos=apellidos;
		}
		
		public void setTelefono(Int64 telefono){
			this.telefono=telefono;
		}
		
		public void setDomicilio(String domicilio){
			this.domicilio=domicilio;
		}
		
		public void setEmail(String email){
			this.email=email;
		}
		
		//METODOS GET
		
		public int getId(){
			return this.id;
		}
		
		public String getNombre(){
			return this.nombre;
		}
		
		public String getApellidos(){
			return this.apellidos;
		}
		
		public Int64 getTelefono(){
			return this.telefono;
		}
		
		public String getDomicilio(){
			return this.domicilio;
		}
		
		public String getEmail(){
			return this.email;
		}
		
		public String getDatos(){
			return "id: " + id + "\n" +
				   "Nombre: " + nombre + " " + apellidos + "\n" +
				   "telefono: " + telefono + "\n" +
				   "domicilio: " + domicilio + "\n" +
				   "Email: " + email;
		}
		
		public String getDatosBase(){
			return 	"'" + id + "'" + "," +
					"'" + nombre + "'" + "," +
				   	"'" + apellidos + "'" + "," +
					"'" + telefono + "'" + "," +
					"'" + domicilio + "'" + "," +
					"'" + email + "'";
		}
		
		public String getDatosModificarBase(){
			
			return 	"id_Contacto = " + "'" + id + "'" + "," +
					"nombre = "  + "'" + nombre + "'" + "," +
					"apellidos =" + "'" + apellidos + "'" + "," +
					"telefono = " + "'" + telefono + "'" + "," +
					"domicilio = " + "'" + domicilio + "'" + "," +
					"email = " + "'" + email + "'";
		}
		
	
	
	}
}
