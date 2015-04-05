using System;
using MySql.Data.MySqlClient;

namespace  Agenda
{
	public class MySQL
	{
		protected MySqlConnection myConnection;
		public MySQL ()
		{
		}
		
		protected void abrirConexion(){
			string connectionString =
          		"Server = localhost;" + 
	          	"Database = agenda;" + 
	          	"User ID = root;" + 
	          	"Password = marthy123mm;" +
	          	"Pooling = false;"; 
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}
		
		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}
}