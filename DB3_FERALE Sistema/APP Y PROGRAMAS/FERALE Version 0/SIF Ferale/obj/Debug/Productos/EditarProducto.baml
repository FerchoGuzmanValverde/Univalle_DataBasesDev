   M S B A M L   `   `   `  ����  
SIF Ferale)    #SIF_Ferale.Productos.EditarProducto   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  6F     � Title$  EditarProducto��5   	   $��719.68��5   	   $��1023.775��6    � WindowStartupLocation$ CenterScreen=�6*    � 
ResizeMode$ NoResize=�6O    � WindowStyle$
 None=�6e   .��5      �� -   5        .+�5	   
   � $��50��6   $	��Top=�6   ���#003300.+�5
      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $
��10 0q�6N   .+�5      �� -   5        
���������5      Z� ��6/   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ 	Backspace=�6.   5      5      �� 5      $*��$SISTEMA DE INFORMACIÓN FERALE - SIF��6   $��Center=�6C   $��Center=�6`   
�������$��18(�6�   �� 5      $
��Left=�6   $��30��63   $��	10,10,0,0q�6?   
���   �$	��Top=�6a   $��40��6y   ��5      �� 5       �� ImageSource$- '/SIF Ferale;component/Imagenes/Logo.jpg��6!   5      5      � 5   
   $��90��6   $	��Top=�6   ���#1b5e20.+�5      �� $��Editar Producto��6   $��Center=�6/   $
��Left=�6J   $��365,24,0,30q�6e   $��30(�6z   
�������$��Stencil)�6�   $	��280��6�   �� 5      $ 
Horizontal=�6   $��Right=�62   $��0,24,357,31q�6N   $��Center=�6c   .+�5        $ Package=�6*   
�������$��25��6L   $��25��6W   $��Center=�6c   $��5q�6~   5      5      � 5   
   $��200,20,244,20q�6   $	��Top=�6&   ���#fdd835$	��483��6S    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#   	   ShadowDepth$	 1Q�63   .+�5       �� $��Información del producto��6   $
��Left=�69   $��	32,10,0,0q�6T   $	��Top=�6g   $	��463��6   $	��511��6�   
�������$
��Bold"�6�   .��5!      � $	��421��6   $��	0,-13,0,0q�6$   $	��Top=�67   $	��484��6O   .+�5"      �� $��Nombre Producto:��6   $
��Left=�67   $��
128,51,0,0q�6R   $	��Top=�6f   �� 5#      $��Precio Base:��6   $
��Left=�63   $��128,138,0,0q�6N   $	��Top=�6c   �� 5$      $��	Variedad:��6   $
��Left=�60   $��128,213,0,0q�6K   $	��Top=�6`   �� 5%      $��Area Producto:��6   $
��Left=�65   $��128,289,0,0q�6P   $	��Top=�6e   �� 5&      -   5        
 ��Name$
 txtNombreProducto��5&      $
��Left=�69   $��23��6T   $��
132,81,0,0q�6`    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��178��6�   $��Normal"�6�   $��Segoe UI Historic)�6�   �� 5'      -   5        $
 txtPrecioBase��5'      $
��Left=�65   $��23��6P   $��132,168,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $	��178��6�   $��Normal"�6�   $��Segoe UI Historic)�6�   �� 5(      -   5        $
 txtVariedad��5(      $
��Left=�63   $��23��6N   $��132,243,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��182��6�   $��Normal"�6�   $��Segoe UI Historic)�6�   �� 5)      -   5         ��Name$ cbxAreaProducto��5)      $
��Left=�68   $��132,336,0,0q�6S   $	��Top=�6h   $	��182��6�   .@�5*      �� -   5        $��Viveros��5*   '    �� 
IsSelected . .��6H   	Viveros6Q   �� 5+      -   5        $��Comercializacion��5+   '   .��6?   Comercializacion6Q   5,      5-      5.      5/      � 50   
   $��42��6   $
��20,0q�6   .+�51      �� -	   5         ��Name$ 	btnEditar��51      $��Editar��6(   $
��Left=�69   $��	220,0,0,0q�6T   $	��Top=�6g   $	��152��6   ���#fdd835���#fdd835$
��Bold"�6�   $��Perpetua Titling MT)�6�   6�   �� 52      -
   5        $ 
btnLimpiar��52      $��Limpiar��6)   $
��Left=�6;   $��	396,0,0,0q�6V   $	��Top=�6i   $	��152��6�   ���#fdd835���#fdd835$
��Bold"�6�   $��Perpetua Titling MT)�6�   6�   �� 53      -   5        $ Cancelar��53      $��Cancelar��6'   $
��Left=�6:   $��	570,0,0,0q�6U   $	��Top=�6h   $	��152��6�   ���#fdd835���#fdd835$
��Bold"�6�   $��Perpetua Titling MT)�6�   6�   54      55      56      