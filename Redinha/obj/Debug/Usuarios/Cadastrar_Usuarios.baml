   M S B A M L   `   `   `  ����B  >Redinha, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RedinhaRedinha  5   	        Redinha.Cadastrar_Usuarios   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Redinha     5   	   -   5          � Title$  Cadastrar_Usuarios��5   	   $��577.423��6$   $��762.117��65    � 	Resources 5	         Redinha.RedinhaDataSet   redinhaDataSet  usuarioSistemaViewSource �� Source �� Source��%_   &	        &	      7     5
   
   6   �� 5   
    6@   �� *UsuarioSistema+8   5      .��5      �  � DataContext# [ 6    � ColumnDefinitions 5   
   �� 5      $
��293* �6   �� 5      $	��84* �6   .+�5   
   �� -   5         ��Name$ 	LbUsuario��5      $��Usuario��6#   $
��Left=�65   $��
458,57,0,0q�6P   $	��Top=�6d   $��26��6|   $��50��6�   �� 5   
   $
��Left=�6   $��23��6-   $��
542,60,0,0q�69    �� TextWrapping$
 Wrap=�6M   $��TextBox��6a   $	��Top=�6p   $	��120��6�   $��2��6�   �� 5   
   $
��Left=�6   $��	2,239,0,0q�6.   $	��Top=�6A   $	��120��6Y   $��1��6e   $��22��6u   .@�5      �� $��Prestador de Servico��6   �� 5      $��Administrador��6   �� 5      $��Funcionario Institucional��6   5      �� 5   
   $��Senha��6   $
��Left=�6    $��458,116,0,0q�6;   $	��Top=�6P   $��26��6h   $��42��6t   �� 5   
   $ ��Classificação de Usuario��6   $
��Left=�63   $��458,239,0,0q�6N   $	��Top=�6c   $��2��6{   $��26��6�   $	��137��6�   �� 5   
   $��Repita Senha��6   $
��Left=�6'   $��458,170,0,0q�6B   $	��Top=�6W   $��26��6o   $��79��6{   �� 5   
   $
��Left=�6   $��23��6-   $��542,116,0,0q�69   $
 Wrap=�6N   $��TextBox��6b   $	��Top=�6q   $	��120��6�   $��2��6�   �� 5   
   $
��Left=�6   $��23��6-   $��542,174,0,0q�69   $
 Wrap=�6N   $��TextBox��6b   $	��Top=�6q   $	��120��6�   $��2��6�   �� 5   
   $��Salvar��6   $
��Left=�6"   $��45��6=   $��440,313,0,0q�6I   $	��Top=�6^   $��97��6v   �� 5   
   $��Fechar��6   $
��Left=�6"   $��45��6=   $��	2,313,0,0q�6I   $	��Top=�6\   $��97��6t   $��1��6   � 5    
   -   5         �Name$ grid1��5       # [ 6   $
��Left=�6V   $��
143,36,0,0q�6q   $	��Top=�6�    5!      �� 5"      $
��Auto �6#   �� 5#      $
��Auto �6#   	 � RowDefinitions	 5%      �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    .+�5+      �� $��Usuario Sistema ID:��6   $��0��62   $
��Left=�6B   $��3q�6]   $��0��6h   $��Center=�6u   �� 5,      -   5        
 ��Name$
 usuarioSistemaIDTextBox��5,      $��1��67   $
��Left=�6G   $��23��6b   $��3q�6n   $��0��6y   $��Center=�6�   $	��120��6
  ��6�   �� *UsuarioSistemaID+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6
  �� 5-      $��Usuario Sistema Nome:��6   $��0��64   $
��Left=�6D   $��3q�6_   $��1��6j   $��Center=�6w   �� 5.      -   5        $
 usuarioSistemaNomeTextBox��5.      $��1��69   $
��Left=�6I   $��23��6d   $��3q�6p   $��1��6{   $��Center=�6�   $	��120��6  ��6�   �� *UsuarioSistemaNome+$ TwoWay=� .  . 6  �� 5/      $��Usuario Sistema Senha:��6   $��0��65   $
��Left=�6E   $��3q�6`   $��2��6k   $��Center=�6x   �� 50      -   5        $ 
 usuarioSistemaSenhaTextBox��50      $��1��6:   $
��Left=�6J   $��23��6e   $��3q�6q   $��2��6|   $��Center=�6�   $	��120��6  ��6�   �� *UsuarioSistemaSenha+$ TwoWay=� .  . 6  �� 51      $��Usuario Sistema Vinculo:��6   $��0��67   $
��Left=�6G   $��3q�6b   $��3��6m   $��Center=�6z   �� 52      -   5        $"
 usuarioSistemaVinculoTextBox��52      $��1��6<   $
��Left=�6L   $��23��6g   $��3q�6s   $��3��6~   $��Center=�6�   $	��120��6  ��6�   �� *UsuarioSistemaVinculo+$ TwoWay=� .  . 6  53      � 54   
   -   5        $ grid2��54      $
��Left=�6   $��304,188,0,0q�69   $	��Top=�6N   $��59��6f   $��95��6r    55      �� 56      $
��Auto �6#   �� 57      $
��Auto �6#   	 59      �� 5:      $
��Auto �6    .+�5<      �� $��foto:��6   $��0��6$   $
��Left=�64   $��3q�6O   $��0��6Z   $��Center=�6g   �� 5=      -	   5         ��Name$ 	fotoImage��5=      $��1��6'   $
��Left=�67   $��3q�6R   $��0��6]   $��Center=�6�   ��6j   �� *foto+6�   5>      &   System.Windows.Controls.DataGrid  5?   
   -
   5          Name$ usuarioSistemaDataGrid��5?         AutoGenerateColumns .     EnableRowVirtualization . $��15,313,171,33q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6n   ��    Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      -   5        usuarioSistemaIDColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Usuario Sistema ID��5A   j      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *UsuarioSistemaID+6�     5B      -   5        usuarioSistemaNomeColumn��$ Usuario Sistema Nome��5B   n   $ SizeToHeader 6�    6G   �� *UsuarioSistemaNome+6�     5C      -   5        usuarioSistemaSenhaColumn��$ Usuario Sistema Senha��5C   p   $ SizeToHeader 6�    6H   �� *UsuarioSistemaSenha+6�     5D      -   5        usuarioSistemaVinculoColumn��$ Usuario Sistema Vinculo��5D   t   $ SizeToHeader 6�    6J   �� *UsuarioSistemaVinculo+6�   4  .System.Windows.Controls.DataGridTemplateColumn  5E      -   5        
fotoColumn��$
 foto��5E   =   $ SizeToHeader 6K      CellTemplate 5F      �� 5G      .R�5H      �� ��6$   �� *foto+5I      5K      5M      5O      5P      