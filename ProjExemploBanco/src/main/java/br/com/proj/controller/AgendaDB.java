package br.com.proj.controller;

import java.util.List;

import javax.persistence.EntityManager;

import br.com.proj.model.Agenda;
import br.com.proj.util.HibernateUtil;

public class AgendaDB {

	EntityManager entityManager;

	public AgendaDB() {
		entityManager = HibernateUtil.getEntityManager();
	}

	public boolean insert(Agenda agenda) {
		try {
			entityManager.getTransaction().begin();
			entityManager.persist(agenda);
			entityManager.getTransaction().commit();
			entityManager.close();
		} catch (Exception e) {
			return false;
		}
		return true;
	}
	
	public boolean update(Agenda agenda) {
		try {
			entityManager.getTransaction().begin();
			entityManager.merge(agenda);
			entityManager.getTransaction().commit();
			entityManager.close();
		} catch (Exception e) {
			return false;
		}
		return true;
	}
	
	public boolean delete (Agenda agenda) {
		try {
			entityManager.getTransaction().begin();
			agenda = entityManager.find(Agenda.class, agenda.getCodigo());
			entityManager.remove(agenda);
			entityManager.getTransaction().commit();
			entityManager.close();
		} catch (Exception e) {
			return false;
		}
		return true;
	}
	
	public Agenda selectTo (int codigo) {
		try {
			entityManager.getTransaction().begin();
			Agenda agenda = entityManager.find(Agenda.class, codigo);
			entityManager.getTransaction().commit();
			entityManager.close();
			return agenda;
		} catch (Exception e) {
		}
		return null;
	}
	
	@SuppressWarnings("unchecked")
	public List<Agenda> selectAll () {
		return entityManager.createQuery("FROM " + Agenda.class.getName()).getResultList();
	}
}
