   M S B A M L   `   `   `  ����J  FDB4ObjectsCRUDS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DB4ObjectsCRUDSDB4ObjectsCRUDS  5   	        DB4ObjectsCRUDS.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:DB4ObjectsCRUDS     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $��876.96��6)   .��5
      � .+�5   
   �� -   5         ��Name$ btnCrear��5      $��
Crear BDOO��6#   $
��Left=�68   $��	25,27,0,0q�6S   $	��Top=�6f   $	��114��6~   6�   �� 5   
   -   5         ��Name$ txtCi��5      $
��Left=�6!   $��23��6<   $��
146,73,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��145��6�   �� 5   
   -   5         ��Name$ label��5      $	��CI:��6   $
��Left=�6-   $��	25,69,0,0q�6H   $	��Top=�6[   �� 5   
   -   5        $ label1��5      $��Nombres:��6    $
��Left=�63   $��
25,112,0,0q�6N   $	��Top=�6b   �� 5   
   -   5        $ 
txtNombres��5      $
��Left=�6&   $��23��6A   $��146,116,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��145��6�   �� 5   
   -   5        $ label1_Copy��5      $��
Apellidos:��6%   $
��Left=�6:   $��
25,155,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ txtApellidos��5      $
��Left=�6(   $��23��6C   $��146,159,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��145��6�   �� 5   
   -	   5        $ label1_Copy1��5      $��Fecha nacimiento:��6&   $
��Left=�6B   $��
25,205,0,0q�6]   $	��Top=�6q   (  "System.Windows.Controls.DatePicker  5   
   -
   5          Name$ dtpFechaNacimiento��5      $
��Left=�61   $��146,205,0,0q�6L   $	��Top=�6a   �� 5   
   -   5        $ btnInsertar��5      $��Insertar��6&   $
��Left=�69   $��
25,242,0,0q�6T   $	��Top=�6h   $	��125��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgvDatos��5      $
��Left=�6%   $��
348,27,0,0q�6@   $	��Top=�6s   $	��250��6�   $	��471��6�      AutoGenerateColumns .  ��6T   �� *people+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        	dtcCI��,  &System.Windows.Controls.DataGridColumn	   Header$
	 C.I.��5   4   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 80 6B   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   �� *Ci+  5      -   5        
dtcNombres��$	 Nombres��5   9   $	
 120 6J    6V   �� *	Nombres+  5      -   5        dtcApellidos��$	 	Apellidos��5   ;   $	
 120 6N    6Z   �� *	Apellidos+  5      -   5        dtcFechaNacimiento��$	 Fecha Nacimiento��5   A    6[   �� *FechaNacimiento+5      �� 5   
   -   5        $ btnEliminar��5      $��Eliminar��6&   $
��Left=�69   $��170,257,0,0q�6T   $	��Top=�6i   $	��121��6�   6�   5      5       