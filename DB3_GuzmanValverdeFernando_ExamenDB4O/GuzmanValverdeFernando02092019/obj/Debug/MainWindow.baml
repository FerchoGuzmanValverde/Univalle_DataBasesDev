   M S B A M L   `   `   `  ����Y  UGuzmanValverdeFernando02092019, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:GuzmanValverdeFernando02092019GuzmanValverdeFernando02092019  5   	   /    )GuzmanValverdeFernando02092019.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:GuzmanValverdeFernando02092019     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgvLectures��5
         AutoGenerateColumns .  $
��Left=�6e   $	��224��6�   $��	25,65,0,0q�6�   $	��Top=�6�   $	��386��6�   ��6D   �� *
lectures+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        	dtcNombre��,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��5   8      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6S   �� *NombreLectura+  5      -   5        	dtcMotivo��$ Motivo��5   8   $	 100 6H    6T   �� *MotivoLectura+  5      -   5        	dtcInicio��$ Inicio��5   8   $	 100 6H    6T   �� *InicioLectura+  5      -   5        
dtcFin��$	 Fin��5   5   $	 150 6B    6N   �� *
FinLectura+  5      -   5        dtcResponsable��$ Responsable��5   =   $	 150 6R    6^   �� *NombreResponsable+5      �� 5   
   -   5         ��Name$ 	btnInsert��5      $��Insertar Lectura��6$   $
��Left=�6?   $��
416,65,0,0q�6Z   $	��Top=�6n   $��91��6�   $��24��6�   6�   �� 5   
   -	   5        $ btnEliminar��5      $��Eliminar Lectura��6&   $
��Left=�6A   $��
384,21,0,0q�6\   $	��Top=�6p   $��91��6�   $��22��6�   6�   �� 5   
   -
   5         ��Name$ label��5      $#��Nombre de Lectura a Eliminar:��6   $
��Left=�6G   $��	43,17,0,0q�6b   $	��Top=�6u   �� 5   
   -   5        	 ��Name$	 txtEliminar��5      $
��Left=�6'   $��23��6B   $��
222,21,0,0q�6N   
 �� TextWrapping$

 Wrap=�6b   $	��Top=�6v   $	��142��6�   �� 5   
   -   5        $ button��5      $��Ver Lectura��6!   $
��Left=�67   $��
416,94,0,0q�6R   $	��Top=�6f   $��91��6~   $��25��6�   5      5      