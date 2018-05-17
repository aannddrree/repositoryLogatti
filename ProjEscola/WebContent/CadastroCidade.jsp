<%@page import="br.com.projescola.db.CidadeDB"%>
<%@page import="br.com.projescola.model.Cidade"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Cadastro de Cidades</title>
<link href="bootstrap/css/bootstrap.css" rel="stylesheet"/>
</head>
<body>

<h1>Cadastro de Cidades</h1>



<form action="ControllerCidade" method="post">
<div class="col-sm-6">

<%if (request.getAttribute("msg") != null){%>
<div class="alert alert-primary" role="alert">
  <%=request.getAttribute("msg")%>
</div>
<%} %>

<div class="form-group">
<label>Nome</label>
<input class="form-control" type="text" id="nome" name="nome" /><br>
</div>
<div class="form-group">
<label>Qtd. Habitantes</label>
<input class="form-control" type="number" id="qtdHabitantes" name="qtdHabitantes" /><br>
</div>
<input class="btn btn-primary" type="submit" value="Salvar" />
</div>
</form>
<br>
<div class="col-sm-6">
<table class="table table-hover table-dark">
  <thead>
    <tr>
      <th scope="col">Id</th>
      <th scope="col">Nome</th>
      <th scope="col">Qtd. Habitantes</th>
    </tr>
  </thead>
  <tbody>
  
  <% for(Cidade cidade : new CidadeDB().all()) { %>
    
    <tr>
      <td><%=cidade.getId() %></td>
      <td><%=cidade.getNome() %></td>
      <td><%=cidade.getQtdHabitantes() %></td>
    </tr>
    
  <% } %>
  
  </tbody>
</table>
</div>

<br>
<a href="Principal.jsp" class="btn btn-default">Voltar</a>

</body>
</html>