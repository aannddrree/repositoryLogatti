<%@ page import = "br.com.projaulabanco.dados.CadastroDB"%>
<%@ page import = "br.com.projaulabanco.entidade.Cadastro"%>
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
String nome = request.getParameter("nome");
String telefone = request.getParameter("telefone");

Cadastro cadastro = new Cadastro();

cadastro.setNome(nome);
cadastro.setTelefone(telefone);

if (new CadastroDB().inserir(cadastro)){
%>	

Registro Inserido!


<%}%>
</body>
</html>