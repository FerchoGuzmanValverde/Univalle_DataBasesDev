<div class="container">
   <h3>Modificar ciudad
<div class="pull-right">
                        </div>
               <br>
            </h3>
<!-- START row-->
            <div class="row">
               <div class="col-lg-12">
                  <!-- START panel-->
                  <div class="panel panel-default">
                     <div class="panel-heading">Ingrese los datos
                     </div> 
                     <div class="panel-body">
                                
<?php
foreach ($infociudad->result() as $row)
{
   echo form_open_multipart('ciudades/modificarbd');
?>
   <input type="hidden" name="idciudad" value="<?php echo $row->idciudad; ?>">
   <input type="text" name="ciudad" value="<?php echo $row->ciudad; ?>">
   <input type="text" name="pais" value="<?php echo $row->pais; ?>">
   <input type="text" name="pobciudad" value="<?php echo $row->pobciudad; ?>">
   <input type="text" name="pobpais" value="<?php echo $row->pobpais; ?>">

      <button type="submit" class="btn btn-labeled btn-primary">
                           <span class="btn-label"><i class="fa fa-check"></i>
                           </span>Modificar</button>
<?php
echo form_close();
}
?>
</div>
                  </div>
                  <!-- END panel-->
               </div>
            </div>
            <!-- END row-->
         </div>