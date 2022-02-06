<?php if ( ! defined('BASEPATH')) exit('No direct script access allowed');

class Ciudades extends CI_Controller {

	public function __construct()
	{
		parent::__construct();
		$this->load->model('ciudades_model');
	}

	public function index()
	{
		$lista=$this->ciudades_model->listaciudades();
		$data['lista']=$lista;
		$this->load->view('inc/template_header');
		$this->load->view('inicio',$data);
		$this->load->view('inc/template_footer');
	}

	public function modificar()
	{
		$idciudad=$_POST['idciudad'];
		$data['infociudad']=$this->ciudades_model->recuperarciudad($idciudad);
		$this->load->view('inc/template_header');
		$this->load->view('mod_ciudad',$data);
		$this->load->view('inc/template_footer');
	}

	public function modificarbd()
	{
		$idciudad=$_POST['idciudad'];
		$data['ciudad']=$_POST['ciudad'];
		$data['pais']=$_POST['pais'];
		$data['pobciudad']=$_POST['pobciudad'];
		$data['pobpais']=$_POST['pobpais'];
		$this->ciudades_model->modificarciudad($idciudad,$data);
		redirect('ciudades/index','refresh');
	}

	public function agregar()
	{
		$this->load->view('inc/template_header');
		$this->load->view('add_ciudad');
		$this->load->view('inc/template_footer');
	}

	public function agregarbd()
	{
		$data['ciudad']=$_POST['ciudad'];
		$data['pais']=$_POST['pais'];
		$data['pobciudad']=$_POST['pobciudad'];
		$data['pobpais']=$_POST['pobpais'];
		$this->ciudades_model->agregarciudad($data);
		redirect('ciudades/index','refresh');
	}

	public function eliminarbd()
	{
		$idciudad=$_POST['idciudad'];
		$this->ciudades_model->eliminarciudad($idciudad);
		redirect('ciudades/index','refresh');
	}

	public function ocultarbd()
	{
		$idciudad=$_POST['idciudad'];
		$data['estado']=0;
		$this->ciudades_model->ocultarciudad($idciudad,$data);
		redirect('ciudades/index','refresh');
	}
}
