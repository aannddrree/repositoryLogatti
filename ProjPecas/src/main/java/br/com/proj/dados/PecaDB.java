package br.com.proj.dados;

import java.util.List;

import javax.persistence.EntityManager;

import br.com.proj.entidade.Peca;
import br.com.proj.util.Conexao;

public class PecaDB {

	EntityManager entityManager;

	public PecaDB() {
		entityManager = Conexao.getEntityManager();
	}

	public boolean insert(Peca peca) {

		entityManager.getTransaction().begin();
		entityManager.persist(peca);
		entityManager.getTransaction().commit();
		entityManager.close();
		return true;
	}

	public boolean update(Peca peca) {
		
		System.out.println("Nome: "+ peca.getNome());
		
		entityManager.getTransaction().begin();
		entityManager.merge(peca);
		entityManager.getTransaction().commit();
		entityManager.close();
		return true;
	}

	public boolean delete(int id) {
		Peca peca = entityManager.find(Peca.class, id);
		entityManager.getTransaction().begin();
		entityManager.remove(peca);
		entityManager.getTransaction().commit();
		entityManager.close();
		return true;
	}

	@SuppressWarnings("unchecked")
	public List<Peca> getAll() {
		return entityManager.createQuery("From Peca").getResultList();
	}

}
