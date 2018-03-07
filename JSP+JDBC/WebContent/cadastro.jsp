<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Cadastro</title>
</head>
<body>

<div align ="center">
<h1>Cadastro</h1>
<form action = "cadastrar.jsp" method = "post">
<table>

<tr>
<td>Nome:</td>
<td><input name="nome" id="nome" /></td>
</tr>
<tr>
<td> Telefone </td>
<td><input name="telefone" id ="telefone"/></td> 

</tr>
</table>
<input type="submit" value= "Salvar" /></form>
</div>

</body>
</html>