package br.com.proj.test;

import br.com.proj.controller.AgendaDB;
import br.com.proj.model.Agenda;
import junit.framework.TestCase;

public class Test extends TestCase {

	public void testInsert() {
		Agenda agenda = new Agenda();
		agenda.setNome("Teste");
		agenda.setTelefone("2345");
		assertEquals(new AgendaDB().insert(agenda), true);
	}

	public void testUpdate() {
		Agenda agenda = new Agenda();
		agenda.setCodigo(2);
		agenda.setNome("Luiz Gonzaga");
		agenda.setTelefone("9633");
		assertEquals(new AgendaDB().update(agenda), true);
	}

	public void testDelete() {
		Agenda agenda = new Agenda();
		agenda.setCodigo(12);
		assertEquals(new AgendaDB().delete(agenda), true);
	}

	public void testSelectTo() {
		assertNotNull(new AgendaDB().selectTo(1));
	}
	
	public void testSelectAll() {
		assertNotNull(new AgendaDB().selectAll());
	}

}
