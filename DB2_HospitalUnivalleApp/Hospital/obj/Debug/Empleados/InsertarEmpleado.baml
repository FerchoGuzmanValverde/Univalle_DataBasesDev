   M S B A M L   `   `   `  ����v  rUnivalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Sclr-namespace:Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.EmpleadosEUnivalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Empleados  5   	   �Sclr-namespace:Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.TelefonosEUnivalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Telefonos  5   	   \    VUnivalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Empleados.InsertarEmpleado   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   hHospitalSclr-namespace:Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Empleados     5   	   i	TelefonosSclr-namespace:Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Telefonos     5   	     � Title$  Empleado��5   	   $��496.181��6   $��613.543��6+    � WindowStartupLocation$ CenterScreen=�6;    � WindowStyle$ 
ToolWindow=�6`   .��5      �� $��Crear empleado��6   $��0,0,-8,0q�6'   .��5	   
   � $	��358��6   $	��Top=�6    � RowDefinitions 5
      �� 5      $
��Auto �6    60   �� 5      $
��Auto �6    60    � ColumnDefinitions 5      �� 5      $
��Auto �6#   $	��333��60   6A   �� 5      $
��Auto �6#   $	��246��60   6A   .+�5      �� -   5         ��Name$ gbxInformacionGeneral��5   $   $��0��6   $��Información general��6C   $
��Left=�6`   $	��Top=�6|   $��5,5,0,0q�6�   $	��168��6�   $	��318��6�   .��5      � $	��260��6   $
��Left=�6#   $��0,0,0,-5q�6>   $	��Top=�6P   $	��121��6h   .+�5      �� -   5         ��Name$ 	lblNombre��5      $��Nombre��6/   $
��Left=�6@   $��0,2,0,0q�6[   $	��Top=�6l   �� 5      -   5         ��Name$ 	txtNombre��5      $��23��61    �� TextWrapping$
 Wrap=�6=   $��	113,2,0,0q�6Q   $
��Left=�6d   $	��139��6   $	��Top=�6�   �� 5      -   5        $ lblPrimerApellido��5      $��Primer Apellido��67   $
��Left=�6Q   $��0,30,0,0q�6l   $	��Top=�6~   �� 5      -   5        $ txtPrimerApellido��5      $��23��69   $
 Wrap=�6E   $��
113,30,0,0q�6Y   $
��Left=�6m   $	��139��6�   $	��Top=�6�   �� 5      -   5        $ lblSegundoApellido��5      $��Segundo Apellido��68   $
��Left=�6S   $��0,58,0,0q�6n   $	��Top=�6�   �� 5      -   5        $ txtSegundoApellido��5      $��23��6:   $
 Wrap=�6F   $��
113,58,0,0q�6Z   $
��Left=�6n   $	��139��6�   $	��Top=�6�   �� 5      -   5        $ lblFechaContratacion��5      $��Fecha contratación��6:   $
��Left=�6W   $��	0,83,0,10q�6r   (  "System.Windows.Controls.DatePicker  5      -	   5        	  Name$	 dtpFechaContratacion��5   !   $
��Left=�6?   $��
113,81,0,0q�6Z   $	��Top=�6n   $	��139��6�   5      5      �� 5      -
   5        $ 
gbxUsuario��5   4   $��0��6   $��1��6$   $��Usuario��6H   $
��Left=�6Y   $	��Top=�6u   $��5,5,0,0q�6�   $	��168��6�   $	��238��6�   .��5       � $	��260��6   $
��Left=�6#   $��0,0,0,-5q�6>   $	��Top=�6P   $	��121��6h   .+�5!      �� -   5        $ lblNombreUsuario��5!      $��Nombre��66   $
��Left=�6G   $��0,2,0,0q�6b   $	��Top=�6s   �� 5"      -   5        $ txtNombreUsuario��5"      $��23��68   $
 Wrap=�6D   $��	113,2,0,0q�6X   $
��Left=�6k   $��99��6�   $	��Top=�6�   �� 5#      -   5        $ lblContrasenia��5#      $��Contraseña��64   $
��Left=�6I   $��0,30,0,0q�6d   $	��Top=�6v   �� 5$      -   5        $ txtContrasenia��5$      $��23��66   $
 Wrap=�6B   $��
113,30,0,0q�6V   $
��Left=�6j   $��99��6�   $	��Top=�6�   �� 5%      -   5        $ lblRepetirContrasenia��5%      $��Repetir contraseña��6;   $
��Left=�6X   $��0,58,0,0q�6s   $	��Top=�6�   �� 5&      -   5        $ txtRepetirContrasenia��5&      $��23��6=   $
 Wrap=�6I   $��
114,58,0,0q�6]   $
��Left=�6q   $��99��6�   $	��Top=�6�   5'      5)      �� 5*      -   5        $ gbxTelefonos��5*   4   $��1��6   $��0��6$   $��
Télefonos��6J   $
��Left=�6]   $	��Top=�6y   $��5,5,0,0q�6�   $	��168��6�   $	��318��6�   � 5+      $
��Left=�6   $	��118��6.   $��	10,46,0,0q�6;   $��1��6N   $	��Top=�6[   $	��313��6s   .+�5,      \   VUnivalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Telefonos.InsertarTelefono  -   5        
  Name$
 ucTelefono1��5,   -   $��	0,0,17,83q�6B     5-      -   5        $
 ucTelefono2��5-   -   $
��Left=�6B   $��0,35,0,0q�6]   $	��Top=�6o   $��35��6�   $	��296��6�     5.      -   5        $
 ucTelefono3��5.   -   $
��Left=�6B   $��0,70,0,0q�6]   $	��Top=�6o   $��35��6�   $	��296��6�   5/      �� 50      -   5         ��Name$ btnCancelar��50      $��	_Cancelar��6*   $��1��6>   $
��Left=�6N   $��168,202,0,-55q�6i   $��1��6�   $	��Top=�6�   $��75��6�   6�   �� 51      -   5        $ btnCrear��51      $��C_rear��6'   $��1��68   $
��Left=�6H   $��88,202,0,-56q�6c   $��1��6y   $	��Top=�6�   $��75��6�   6�   53      54      58      