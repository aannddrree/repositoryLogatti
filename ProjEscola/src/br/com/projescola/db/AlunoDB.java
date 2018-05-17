package br.com.projescola.db;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

import br.com.projescola.model.Aluno;
import br.com.projescola.util.ConnectionFactory;

public class AlunoDB {

	Connection con;
	PreparedStatement ps;
	
	public AlunoDB() {
		con = ConnectionFactory.getConnection();
	}
	
	public boolean insert(Aluno aluno) {

		try {
			
			StringBuilder sb = new StringBuilder();
			
			sb.append("insert into tb_aluno (nome, nota, telefone, idCidade) ");
			sb.append("values (?,?,?,?)");
			
			ps = this.con.prepareStatement(sb.toString());
			
			ps.setString(1, aluno.getNome());
			ps.setInt(2, aluno.getNota());
			ps.setString(3, aluno.getTelefone());
			ps.setInt(4, aluno.getCidade().getId());
			
			ps.execute();
			
			return true;
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return false;
		
	}

}
