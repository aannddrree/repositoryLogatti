package br.com.projaulabanco.dados;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;

import br.com.projaulabanco.entidade.Cadastro;
import br.com.projaulabanco.util.Conexao;

public class CadastroDB {

	private Connection connection;
	private PreparedStatement ps;
	private ResultSet rs;

	public CadastroDB() {
		connection = Conexao.getConnection();
	}

	public boolean inserir(Cadastro cadastro) throws SQLException {

		try {

			PreparedStatement stmt = this.connection
					.prepareStatement("INSERT INTO AGENDA (nome, telefone) values (?, ?)");

			stmt.setString(1, cadastro.getNome());
			stmt.setString(2, cadastro.getTelefone());

			stmt.execute();
			return true;

		} catch (SQLException e) {
			System.err.println(e.toString());
		} finally {

			connection.close();

		}
		return false;
	}

	public List<Cadastro> getAll() {

		List<Cadastro> lstCadastro = new ArrayList<>();
		try {
			ps = this.connection.prepareStatement("SELECT codigo, nome, telefone FROM AGENDA");
			rs = ps.executeQuery();

			while (rs.next()) {
				lstCadastro.add(new Cadastro(rs.getInt("codigo"), rs.getString("nome"), rs.getString("telefone")));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
		return lstCadastro;
	}
}
