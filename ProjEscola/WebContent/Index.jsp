<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Login</title>

<link href="bootstrap/css/bootstrap.css" rel="stylesheet"/>

</head>
<body>

<form action="ControllerLogin" method="post">
<div class="col-sm-3">
<div class="form-group">
<label>Usuário</label>
<input type="text" class="form-control" id="usuario" name="usuario"/>
</div>
<div class="form-group">
<label>Senha</label>
<input type="password" class="form-control"  id="senha" name="senha"/>
</div>
<input type="submit" class="btn btn-primary" value="Login">
</div>
</form>

</body>
</html>