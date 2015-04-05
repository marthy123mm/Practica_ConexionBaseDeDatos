
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Agenda
{

	public class MyConexion : MySQL
	{
		public MyConexion()
		{
		}
		
		public DataSet verContactos(){
			this.abrirConexion();
			MySqlDataAdapter datosContactos = new MySqlDataAdapter(querySelect(), this.myConnection);
			DataSet dsContactos = new DataSet ();
			datosContactos.Fill(dsContactos,"contactos");
			this.cerrarConexion();
			return dsContactos;
		}
		
		public void agregarRegistro(Contacto c){
			try{
				this.abrirConexion();
				string sql = "INSERT INTO contactos  VALUES (" + c.getDatosBase() + ")";
				this.ejecutarComando(sql);
				this.cerrarConexion();
			}catch (Exception){
				
			}
		}
		
		
		public int eliminarContactoPorId(string id){
			int afectadas=0;
			this.abrirConexion();
			string sql = "DELETE FROM contactos WHERE id_Contacto=" + int.Parse(id);
			afectadas=ejecutarComando(sql);
			this.cerrarConexion();
			return afectadas;
		}
		
		public int asingarID(){
			
			this.abrirConexion();
			int id=0;
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(),myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
            	id=int.Parse(myReader["id_Contacto"].ToString());
            }
            return id+1;
		}
		
		public Contacto buscarContactoPorID(String ids){
			this.abrirConexion();
			int id=0;
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(),myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
            	id=int.Parse(myReader["id_Contacto"].ToString());
            	if (int.Parse(ids)==id){
            		Contacto  contacto=new Contacto();
            		contacto.setId(int.Parse(myReader["id_Contacto"].ToString()));
            		contacto.setNombre(myReader["nombre"].ToString());
            		contacto.setApellidos(myReader["apellidos"].ToString());
            		contacto.setTelefono(Int64.Parse(myReader["telefono"].ToString()));
            		contacto.setDomicilio(myReader["domicilio"].ToString());
            		contacto.setEmail(myReader["email"].ToString());
            		return contacto;
            	}  		
            }
            return null;
            
		}
		
		public void actualizarContactoPorId(String id, Contacto contactoM){
			
			this.abrirConexion();
			string sql = "UPDATE contactos SET " + contactoM.getDatosModificarBase() + " where id_Contacto = '" + id + "'";
			this.ejecutarComando(sql);
			this.cerrarConexion();
			
		}
		
		
		
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		
		private string querySelect(){
			return "SELECT * " +
	           	"FROM contactos";
		}
		 
		
	}
}
