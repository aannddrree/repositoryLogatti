package com.projSpring1.controller;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import com.projSpring1.model.Conta;
import com.projSpring1.repository.ContaRepository;

@RestController
public class ContaController {
	
	@Autowired
	ContaRepository repository;
	
	//http://localhost:8080/api/save	
	/*
	 * INSERIR
	   {
	    "numConta": 10,
	    "descricao": "Conta Corrente",
	    "valor": 1500
	   }
	 * 
	 * ALTERAR
	   {
	    "id" : 1
	    "numConta": 10,
	    "descricao": "Conta Poupança",
	    "valor": 1500
	   }
	 * */
	@PostMapping("api/save")
	public Conta save(@RequestBody Conta conta){
		return repository.save(conta);
	}
	
	//http://localhost:8080/api/all
	@GetMapping("api/all")
	public List<Conta> all(){
		return (List<Conta>) repository.findAll();
	}
	
	//http://localhost:8080/api/delete/2
	@GetMapping("api/delete/{id}")
	public boolean delete(@PathVariable("id") Long id) {
		try {
			repository.deleteById(id);
			
		} catch (Exception e) {
			e.printStackTrace();
			return false;
		}
		return true;
	}
}
