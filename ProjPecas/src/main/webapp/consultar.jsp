<%@page import="br.com.proj.entidade.Peca"%>
<%@page import="br.com.proj.dados.PecaDB"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Consulta Agenda</title>

<link rel="stylesheet" href="bootstrap/css/bootstrap.css">

<script type="text/javascript" src="bootstrap\jquery-3.3.1.min.js"></script>
<script type="text/javascript" src="bootstrap/js/bootstrap.js"></script>
</head>
<body>
<div style="padding-top: 5%"></div>
<div class="col-sm-6">
<h1>Agenda</h1>
<div style="padding-top: 5%"></div>
<a href="cadastro.jsp" class="btn btn-dark">Novo</a>

<div style="padding-top: 3%"></div>

<input type="hidden" class="form-control" id="codigo" name="codigo">

<table class="table table-hover table-dark">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">Nome</th>
      <th scope="col">Peso</th>
      <th scope="col">Tipo</th>
      <th scope="col">Data Cadastro</th>
      <th scope="col">Valor</th>
      <th scope="col">Opções</th>
    </tr>
  </thead>
  <tbody>
    <%for (Peca peca : new PecaDB().getAll()){%>
    <tr>
      <th scope="row"><%=peca.getId() %></th>
      <td><%=peca.getNome() %></td>
      <td><%=peca.getPeso() %></td>
      <td><%=peca.getTipo() %></td>
      <td><%=peca.getDataCadastro() %></td>
      <td><%=peca.getValor() %></td>
      <td>  
      <button class="btn btn-warning" onclick="alterar(<%=peca.getId() %>, 
      '<%=peca.getNome() %>', <%=peca.getPeso() %>, 
      '<%=peca.getTipo() %>', '<%=peca.getDataCadastro() %>', 
      <%=peca.getValor() %>)">Alterar</button>
      <button type="button" class="btn btn-danger" 
      data-toggle="modal" data-target="#confexcluir" 
      onclick="salvaCodigo(<%=peca.getId() %>)">Excluir</button>
      </td>
    </tr>
    <%}%>
  </tbody>
</table>
</div>

<!-- Modal -->
<div class="modal fade" id="confexcluir" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Confirmação</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        Tem certeza que deseja excluir este registro?
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Não</button>
        <button type="button" class="btn btn-danger" onclick="excluir()">Sim</button>
      </div>
    </div>
  </div>
</div>

</body>

<script>
function alterar(id, nome, peso, tipo, dataCadastro, valor) {
   location.href="cadastro.jsp?id="+id+"&nome="+nome+"&peso="+peso+"&tipo="+tipo+"&dataCadastro="+dataCadastro+"&valor="+valor;	
}

function salvaCodigo(idPeca) {
	var id = document.getElementById("codigo");
	id.value = idPeca;
}

function excluir() {
	var id = document.getElementById("codigo").value; 
	location.href="excluir.jsp?id="+id;	
}
</script>

</html>

