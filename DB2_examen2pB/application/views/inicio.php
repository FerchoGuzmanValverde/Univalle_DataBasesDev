<div class="container">
   <h3>Estudiantes
<div class="pull-right">
   <a href="<?php echo base_url(); ?>index.php/ciudades/agregar">
      <button type="button" class="btn btn-labeled btn-success">
                           <span class="btn-label"><i class="fa fa-plus"></i>
                           </span>Agregar</button></a>

                        </div>

               <br>
               <small>Lista de estudiantes del curso</small>
            </h3>
<!-- START row-->
            <div class="row">
               <div class="col-lg-12">
                  <!-- START panel-->
                  <div class="panel panel-default">
                     <div class="panel-heading">Lista de estudiantes
                     </div>
                     <!-- START table-responsive-->
                     <div class="table-responsive">
                        <table class="table table-striped table-bordered table-hover">
                           <thead>
                              <tr>
                                 <th>No.</th>
                                 <th>Nombre</th>
                                 <th>Apellido</th>
                                 <th>Estado</th>
                                 <th>Habilitar</th>
                                 <th>Editar</th>
                                 <th>Eliminar</th>
                              </tr>
                           </thead>
                           <tbody>

<?php
$indice=1;
foreach ($lista->result() as $row)
{
   $relacionpais=($row->pobciudad/$row->pobpais)*100;
   if($relacionpais>=30)
   {
      $estilobarra="info";
   }
   else
   {
      $estilobarra="danger";
   }
?>
                              <tr>
                                 <td><?php echo $indice;?></td>
                                 <td><?php echo $row->ciudad; ?></td>
                                 <td><?php echo $row->pais; ?></td>
                                 <td>
                                    <div class="progress progress-striped progress-xs">
<div role="progressbar" aria-valuenow="<?php echo $relacionpais; ?>" aria-valuemin="0" aria-valuemax="100"
   style="width: <?php echo $relacionpais; ?>%;" class="progress-bar progress-bar-<?php echo $estilobarra; ?>">
                                          <span class="sr-only"><?php echo $relacionpais; ?>%</span>
                                       </div>
                                    </div>
                                 </td>
                                 <td>
                                    <?php echo form_open_multipart('ciudades/ocultarbd'); ?>
<input type="hidden" name="idciudad" value="<?php echo $row->idciudad;?>">
<button type="submit" class="btn btn-default btn-xs"><em class="fa fa-eye"></em></button>
<?php echo form_close(); ?>
                                 </td>
                                 <td>
<?php echo form_open_multipart('ciudades/modificar'); ?>
<input type="hidden" name="idciudad" value="<?php echo $row->idciudad;?>">
<button type="submit" class="btn btn-default btn-xs"><em class="fa fa-edit"></em></button>
<?php echo form_close(); ?>
                              </td>
                                 <td>

<?php echo form_open_multipart('ciudades/eliminarbd'); ?>
<input type="hidden" name="idciudad" value="<?php echo $row->idciudad;?>">
<button type="submit" class="btn btn-default btn-xs"><em class="fa fa-times"></em></button>
<?php echo form_close(); ?>
                                 </td>
                              </tr>
<?php
$indice++;
}
?>


                           </tbody>
                        </table>
                     </div>
                     <!-- END table-responsive-->
                  </div>
                  <!-- END panel-->
               </div>
            </div>
            <!-- END row-->
         </div>