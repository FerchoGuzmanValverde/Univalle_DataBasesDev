<div class="container">
   <h3>Agregar ciudad
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
   echo form_open_multipart('ciudades/agregarbd');
?>
   <input type="hidden" name="idciudad">
   <input type="text" name="ciudad" placeholder="ciudad">
   <input type="text" name="pais" placeholder="pais">
   <input type="text" name="pobciudad" placeholder="pob. ciudad">
   <input type="text" name="pobpais" placeholder="pob. pais">

      <button type="submit" class="btn btn-labeled btn-primary">
                           <span class="btn-label"><i class="fa fa-check"></i>
                           </span>Agregar</button>
<?php
echo form_close();
?>
</div>
                  </div>
                  <!-- END panel-->
               </div>
            </div>
            <!-- END row-->
         </div>