package br.com.proj.entidade;

import java.io.Serializable;

public class PessoaFisica extends Pessoa implements Serializable {

	private String CPF;

	public String getCPF() {
		return CPF;
	}

	public void setCPF(String cPF) {
		CPF = cPF;
	}
}
