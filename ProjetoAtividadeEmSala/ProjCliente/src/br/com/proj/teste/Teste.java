package br.com.proj.teste;
import br.com.proj.entidade.Pessoa;
import br.com.proj.entidade.PessoaFisica;
	
public class Teste {

	
	public static void main(String[] args) {
		
		PessoaFisica p1 = new PessoaFisica();
		p1.setNome("André");
		p1.setTelefone("16 8787 6565");
		
		PessoaFisica p2 = new PessoaFisica();
		p2.setNome("Bruna");
		p2.setTelefone("16 7474 8989");
		
		//Teste de inclusão de consulta das informações:
		PessoaFisica pf = new PessoaFisica();
		


		pf.add(p1);
		pf.add(p2);
		
		for (Pessoa pessoaFisica : pf.getAll()) {
			System.out.println("Nome: "+ pessoaFisica.getNome());
			System.out.println("Telefone: "+ pessoaFisica.getTelefone());
		}
		
		
		
		
	}
}
