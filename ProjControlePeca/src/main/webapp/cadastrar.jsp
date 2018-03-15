
<%@page import="br.com.proj.dados.PecaDB"%>
<%@page import="br.com.proj.entidade.Peca"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Cadastrar</title>
</head>
<body>

	<%
		String id = request.getParameter("id");
		String nome = request.getParameter("nome");
		String peso = request.getParameter("peso");
		String tipo = request.getParameter("tipo");
		String dataCadastro = request.getParameter("dataCadastro");
		String valor = request.getParameter("valor");

		Peca peca = new Peca();

		peca.setNome(nome);
		peca.setPeso(Double.parseDouble(peso));
		peca.setTipo(tipo);
		peca.setDataCadastro(dataCadastro);
		peca.setValor(Double.parseDouble(valor));

		if (!(id.isEmpty() || id.equals(null))) {
			peca.setId(Integer.parseInt(id));
			new PecaDB().update(peca);
		} else {
			new PecaDB().insert(peca);
		}
		response.sendRedirect("consultar.jsp");
	%>
</body>
</html>