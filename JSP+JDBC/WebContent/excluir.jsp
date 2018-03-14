<%@page import="br.com.projaulabanco.dados.CadastroDB"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<% 
int codigo = Integer.parseInt(request.getParameter("codigo"));
CadastroDB db = new CadastroDB();
db.excluir(codigo);
response.sendRedirect("consultar.jsp");
%>
</body>
</html>