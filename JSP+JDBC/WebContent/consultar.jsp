<%@page import="br.com.projaulabanco.dados.CadastroDB"%>
<%@page import="br.com.projaulabanco.entidade.Cadastro"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Consulta Agenda</title>
<link rel="stylesheet" href="bootstrap/css/bootstrap.css">
</head>
<body>

<div style="padding-top: 5%"></div>
<div class="col-sm-6">
<h1>Agenda</h1>
<div style="padding-top: 5%"></div>
<a href="cadastro.jsp" class="btn btn-dark">Novo</a>

<div style="padding-top: 3%"></div>
<table class="table table-hover table-dark">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Nome</th>
      <th scope="col">Telefone</th>
    </tr>
  </thead>
  <tbody>
    <%for (Cadastro cadastro : new CadastroDB().getAll()){%>
    <tr>
      <th scope="row"><%=cadastro.getCodigo() %></th>
      <td><%=cadastro.getNome() %></td>
      <td><%=cadastro.getTelefone() %></td>
    </tr>
    <%}%>
  </tbody>
</table>
</div>
</body>
</html>