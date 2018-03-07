package br.com.projaulabanco.dados;

import java.sql.Connection;
import br.com.projaulabanco.entidade.Cadastro;
import br.com.projaulabanco.util.Conexao;
import java.sql.PreparedStatement;
import java.sql.SQLException;


public class CadastroDB {
	
	private Connection connection;
	
	public CadastroDB(){
		
		connection = Conexao.getConnection();
		
	}
	
	public boolean inserir (Cadastro cadastro) throws SQLException{
		
		boolean status = false;
		
		
		try{
			
			PreparedStatement stmt = this.connection
					.prepareStatement("INSERT INTO cliente (nome, telefone) values (?, ?)");
			
			
			stmt.setString(1,cadastro.getNome());
			stmt.setString(2, cadastro.getTelefone());
			
			stmt.execute();
			status = true;
			
			
		} catch (SQLException e){
			System.err.println(e.toString());
			status = false;
			
			
		} finally{
			
			
			connection.close();

			
		}
		
		return status;
		
	}

}
