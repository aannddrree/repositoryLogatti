<%@page import="br.com.projescola.db.CidadeDB"%>
<%@page import="br.com.projescola.model.Cidade"%>
<%@page import="org.apache.jasper.tagplugins.jstl.core.ForEach"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Cadastro de Alunos</title>

<link href="bootstrap/css/bootstrap.css" rel="stylesheet"/>
</head>
<body>

<h1>Cadastro de Alunos</h1>


<form action="ControllerAluno" method="post">
<div class="col-sm-6">
<div class="form-group">
<label>Nome</label>
<input class="form-control" type="text" id="nome" name="nome"/> 
</div>

<div class="form-group">
<label>Telefone</label>
<input class="form-control" type="text" id="telefone" name="telefone" /> 
</div>

<div class="form-group">
    <label for="selectCidade">Cidade</label>
    <select class="form-control" id="selectCidade" 
    name="selectCidade">
     
    <option>Selecione</option>
    <% for (Cidade cidade : new CidadeDB().all()) { %>
      <option value="<%=cidade.getId() %>" ><%=cidade.getNome() %>
      </option>
    <% } %>
    
    </select>
</div>

<div class="form-group">
<label>Nota</label>
<input class="form-control" type="number" id="nota" name="nota" />
</div>

<input type="submit" class="btn btn-primary" value="Salvar" /> 

</div>

</form>
<br>
<a href="Principal.jsp" class="btn btn-default">Voltar</a>


</body>
</html>