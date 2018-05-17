package br.com.projescola.model;

public class Cidade {

	private int id;
	private String nome;
	private int qtdHabitantes;
	
	public Cidade() {}
	
	public Cidade(int id) {
		this.id = id;
	}
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public int getQtdHabitantes() {
		return qtdHabitantes;
	}
	public void setQtdHabitantes(int qtdHabitantes) {
		this.qtdHabitantes = qtdHabitantes;
	}
	
	
}
