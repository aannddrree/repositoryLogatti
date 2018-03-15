package br.com.proj.util;

import javax.persistence.EntityManager;
import javax.persistence.Persistence;

public class Conexao {

	public static EntityManager getEntityManager() {
		return Persistence.createEntityManagerFactory("bdagenda2").createEntityManager();
	}
}
