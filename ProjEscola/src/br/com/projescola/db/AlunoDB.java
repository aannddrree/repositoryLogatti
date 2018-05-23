package br.com.projescola.db;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import br.com.projescola.model.Aluno;
import br.com.projescola.model.Cidade;
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
	
	public List<Aluno> all(){
		
		List<Aluno> lstAluno = new ArrayList<>();
		
		try {
		
		StringBuilder sb = new StringBuilder();
		
		sb.append(" select a.id, ");
		sb.append("        a.nome, ");
		sb.append("        a.nota, ");
		sb.append("        c.NOME ");
		sb.append("   from tb_aluno a, tb_cidade c ");
		sb.append("  where a.idcidade = c.ID ");
		
		ps = this.con.prepareStatement(sb.toString());
		
		ResultSet rs = ps.executeQuery();
		
		while (rs.next()) {
			Aluno a = new Aluno();
			a.setId(rs.getInt("a.id"));
			a.setNome(rs.getString("a.nome"));
			a.setNota(rs.getInt("a.nota"));
			a.setCidade(new Cidade(rs.getString("c.NOME")));
			lstAluno.add(a);
		}
			
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return lstAluno;
	}

}
