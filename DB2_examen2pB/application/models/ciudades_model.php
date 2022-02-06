<?php if ( ! defined('BASEPATH')) exit('No direct script access allowed');

class Ciudades_model extends CI_Model {

	public function listaciudades()
	{
		$this->db->select('*');
		$this->db->from('ciudades');
		$this->db->where('estado',1);
		return $this->db->get();
	}

	public function recuperarciudad($idciudad)
	{
		$this->db->select('*');
		$this->db->from('ciudades');
		$this->db->where('idciudad',$idciudad);
		return $this->db->get();
	}

	public function modificarciudad($idciudad,$data)
	{
		$this->db->where('idciudad',$idciudad);
		$this->db->update('ciudades',$data);
	}

	public function agregarciudad($data)
	{
		$this->db->insert('ciudades',$data);
	}

	public function eliminarciudad($idciudad)
	{
		$this->db->where('idciudad',$idciudad);
		$this->db->delete('ciudades');
	}

	public function ocultarciudad($idciudad,$data)
	{
		$this->db->where('idciudad',$idciudad);
		$this->db->update('ciudades',$data);
	}

}
