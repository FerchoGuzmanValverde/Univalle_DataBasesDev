   M S B A M L   `   `   `  ����  
SIF Ferale'    !SIF_Ferale.Usuarios.EditarUsuario   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  6F     � Title$  EditarUsuario��5   	   $��719.68��5   	   $��1023.775��6    � WindowStartupLocation$ CenterScreen=�6*    � 
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
   $��90��6   $	��Top=�6   ���#1b5e20.+�5      �� $��Editar Usuario��6   $��Center=�6.   $
��Left=�6I   $��367,24,0,30q�6d   $��30(�6y   
�������$��Stencil)�6�   $	��253��6�   �� 5      $ 
Horizontal=�6   $��Right=�62   $��0,24,369,31q�6N   $��Center=�6c   .+�5        $
 User=�6*   
�������$��25��6I   $��25��6T   $��Center=�6`   $��5q�6{   5      5      � 5   
   $��200,20,244,20q�6   $	��Top=�6&   ���#fdd835$	��483��6S    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6#   	   ShadowDepth$	 1Q�63   .+�5       �� $��Información del usuario��6   $
��Left=�68   $��	32,10,0,0q�6S   $	��Top=�6f   $	��463��6~   $	��511��6�   
�������$
��Bold"�6�   .��5!      � $	��421��6   $��	0,-13,0,0q�6$   $	��Top=�67   $	��484��6O   .+�5"      �� $��Login:��6   $
��Left=�6-   $��147,115,0,0q�6H   $	��Top=�6]   �� 5#      $��	Password:��6   $
��Left=�60   $��147,202,0,0q�6K   $	��Top=�6`   �� 5$      -   5        
 ��Name$
 txtLogin��5$      $
��Left=�60   $��23��6K   $��151,145,0,0q�6W    �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��178��6�   $��Normal"�6�   $��Segoe UI Historic)�6�   �� 5%      -   5        $
 txtPassword��5%      $
��Left=�63   $��23��6N   $��151,232,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $	��178��6�   $��Normal"�6�   $��Segoe UI Historic)�6�   5&      5'      5(      � 5)   
   $��42��6   $
��20,0q�6   .+�5*      �� -   5         ��Name$ 	btnEditar��5*      $��Editar��6(   $
��Left=�69   $��	220,0,0,0q�6T   $	��Top=�6g   $	��152��6   ���#fdd835���#fdd835$
��Bold"�6�   $��Perpetua Titling MT)�6�   6�   �� 5+      -   5        $ 
btnLimpiar��5+      $��Limpiar��6)   $
��Left=�6;   $��	396,0,0,0q�6V   $	��Top=�6i   $	��152��6�   ���#fdd835���#fdd835$
��Bold"�6�   $��Perpetua Titling MT)�6�   6�   �� 5,      -   5        $ Cancelar��5,      $��Cancelar��6'   $
��Left=�6:   $��	570,0,0,0q�6U   $	��Top=�6h   $	��152��6�   ���#fdd835���#fdd835$
��Bold"�6�   $��Perpetua Titling MT)�6�   6�   5-      5.      5/      