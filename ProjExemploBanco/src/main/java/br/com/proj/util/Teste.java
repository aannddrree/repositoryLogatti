package br.com.proj.util;

import br.com.proj.controller.AgendaDB;
import br.com.proj.model.Agenda;

public class Teste {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Agenda agenda = new Agenda();
		agenda.setNome("Teste");
		agenda.setTelefone("2345");
		new AgendaDB().insert(agenda);
	}

}
