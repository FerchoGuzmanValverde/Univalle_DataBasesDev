   M S B A M L   `   `   `  ����Y  UGuzmanValverdeFernando02092019, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:GuzmanValverdeFernando02092019GuzmanValverdeFernando02092019  5   	   /    )GuzmanValverdeFernando02092019.VerLectura   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:GuzmanValverdeFernando02092019     5   	     � Title$  
VerLectura��5   	   $��293.852��6   $��562.5��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��Nombre Lectura:��6   $
��Left=�69   $��	20,10,0,0q�6T   $	��Top=�6g   �� 5   
   -   5        $ 
label_Copy��5      $��Motivo Lectura:��6$   $
��Left=�6>   $��	20,41,0,0q�6Y   $	��Top=�6l   �� 5   
   -   5        $ label_Copy1��5      $��Responsable:��6%   $
��Left=�6<   $��	20,72,0,0q�6W   $	��Top=�6j   �� 5   
   -   5        $ label_Copy2��5      $��Fecha-Hora Inicio:��6%   $
��Left=�6B   $��
20,103,0,0q�6]   $	��Top=�6q   �� 5   
   -   5        $ label_Copy3��5      $��Fecha-Hora Fin:��6%   $
��Left=�6?   $��
20,134,0,0q�6Z   $	��Top=�6n   �� 5   
   -   5        $ label1��5      $	��---��6    $
��Left=�6.   $��
144,10,0,0q�6I   $	��Top=�6]   $	��149��6u   �� 5   
   -   5        $ label1_Copy��5      $	��---��6%   $
��Left=�63   $��
144,41,0,0q�6N   $	��Top=�6b   $	��149��6z   �� 5   
   -   5        $ label1_Copy1��5      $	��---��6&   $
��Left=�64   $��
144,72,0,0q�6O   $	��Top=�6c   $	��149��6{   �� 5   
   -	   5        $ label1_Copy2��5      $	��---��6&   $
��Left=�64   $��144,103,0,0q�6O   $	��Top=�6d   $	��149��6|   �� 5   
   -
   5        $ label1_Copy3��5      $	��---��6&   $
��Left=�64   $��144,134,0,0q�6O   $	��Top=�6d   $	��149��6|   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5         AutoGenerateColumns .  $
��Left=�6c   $��
298,10,0,0q�6~   $	��Top=�6�   $	��150��6�   $	��246��6�   ��6A   �� *	registros+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        	dtcNombre��,  &System.Windows.Controls.DataGridColumn   Header$ Temperatura��5   8      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6X   �� *Temperatura+  5      -   5        	dtcMotivo��$ Presion Aire��5   8   $	 100 6N    6Z   �� *	Humedad+  5      -   5        	dtcInicio��$ Humedad��5   8   $	 100 6I    6U   �� *PresionAire+5      5      5      