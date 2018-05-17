package br.com.projescola.db;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import br.com.projescola.model.Cidade;
import br.com.projescola.util.ConnectionFactory;

public class CidadeDB {

	Connection con;
	PreparedStatement ps;
	
	public CidadeDB() {
		con = ConnectionFactory.getConnection();
	}
	
	public boolean insert(Cidade cidade) {

		try {
			
			StringBuilder sb = new StringBuilder();
			
			sb.append("insert into tb_cidade (nome, qtd_habitantes) ");
			sb.append("values (?,?)");
			
			ps = this.con.prepareStatement(sb.toString());
			
			ps.setString(1, cidade.getNome());
			ps.setInt(2, cidade.getQtdHabitantes());
			
			
			//ps.setInt(3,aluno.getCidade().getId());~
			
			
			ps.execute();
			
			return true;
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return false;
		
	}
	
	public List<Cidade> all(){
		
		List<Cidade> lstCidade = new ArrayList<>();
		
		String sql = "SELECT id, nome, qtd_habitantes FROM TB_CIDADE";
		
		try {
			
			ps = this.con.prepareStatement(sql);
			ResultSet rs = ps.executeQuery();
			
			while (rs.next()) {
				
				Cidade cidade = new Cidade();
				
				cidade.setId(rs.getInt("id"));
				cidade.setNome(rs.getString("nome"));
				cidade.setQtdHabitantes(rs.getInt("qtd_habitantes"));
				
				lstCidade.add(cidade);
			}
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return lstCidade;
	}
	

	
}
