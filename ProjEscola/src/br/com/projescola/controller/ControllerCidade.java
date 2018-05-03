package br.com.projescola.controller;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import br.com.projescola.db.CidadeDB;
import br.com.projescola.model.Cidade;

@WebServlet("/ControllerCidade")
public class ControllerCidade extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public ControllerCidade() {
        super();

    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

		String nome = request.getParameter("nome");
		int qtdHabitantes =
			Integer.parseInt(request.getParameter("qtdHabitantes"));
		
		Cidade cidade = new Cidade();
		
		cidade.setNome(nome);
		cidade.setQtdHabitantes(qtdHabitantes);
		
		if (new CidadeDB().insert(cidade)) {
			request.setAttribute("msg", "Registro inserido com sucesso!");
			request.getRequestDispatcher("CadastroCidade.jsp")
			.forward(request, response);
		}else {
			request.setAttribute("msg", "Erro ao inserir Registro!");
			request.getRequestDispatcher("CadastroCidade.jsp")
			.forward(request, response);
		}
	}
}
