   M S B A M L   `   `   `  ����B  >Redinha, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:RedinhaRedinha  5   	       Redinha.Pesquisar_Cliente   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Redinha     5   	   -   5          � Title$  Pesquisar_Cliente��5   	   $	��450��6#   $	��585��60    � 	Resources 5	         Redinha.RedinhaDataSet   redinhaDataSet  clienteViewSource �� Source �� Source��%X   &	        &	      7     5
   
   6   �� 5   
    69   �� *	Cliente+8   5      .��5      �  � DataContext# [ 6   .+�5   
   �� -   5         ��Name$ BtnPesquisar��5      $��Buscar��6'   $
��Left=�68   $��
417,51,0,0q�6S   $	��Top=�6g   $��91��6   $��27��6�   �� 5   
   -   5         ��Name$ CBPesquisar��5      $
��Left=�6(   $��
271,51,0,0q�6C   $	��Top=�6W   $	��120��6o   .@�5      �� $
��Nome��6   �� 5      $��Bairro��6   �� 5      $
��F.A.��6   5      �� 5   
   $��Nova Pequisa��6   $
��Left=�6(   $��41��6C   $��399,191,0,0q�6O   $	��Top=�6d   $	��109��6|   �� 5   
   -   5        $��Fechar��5      $
��Left=�6"   $��41��6=   $��399,256,0,0q�6I   $	��Top=�6^   $	��109��6v   6�   �� 5   
   -   5        $��Adicionar na agenda��5      $
��Left=�6/   $��42��6J   $��398,113,0,0q�6V   $	��Top=�6k   $	��128��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ clienteDataGrid��5         AutoGenerateColumns .  	   EnableRowVirtualization	 . $��10,155,207,64q�6   
   RowDetailsVisibilityMode$
 VisibleWhenSelected=�6�   ��6g   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        clienteIDColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 
Cliente ID��5   \      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6p   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *	ClienteID+6p     5      -   5        fichaAtendimentoColumn��$ Ficha Atendimento��5   j   $ SizeToHeader 6�    6E   �� *FichaAtendimento+6�     5      -	   5        nomeClienteColumn��$ Nome Cliente��5   `   $ SizeToHeader 6v    6@   �� *NomeCliente+6v     5      -
   5        	ruaColumn��$	 Rua��5   P   $ SizeToHeader 6]    68   �� *Rua+6]     5      -   5        numeroColumn��$ Numero��5   V   $ SizeToHeader 6f    6;   �� *Numero+6f     5      -   5        bairroColumn��$ Bairro��5   V   $ SizeToHeader 6f    6;   �� *Bairro+6f     5      -   5        moradiaColumn��$ Moradia��5   X   $ SizeToHeader 6i    6<   �� *	Moradia+6i   5!      � 5"   
   -   5         �Name$ grid1��5"      $
��Left=�6   $��	12,46,0,0q�69   $	��Top=�6L    � ColumnDefinitions 5#      �� 5$      $
��Auto �6#   �� 5%      $
��Auto �6#    � RowDefinitions 5'      �� 5(      $
��Auto �6    .+�5*      �� $��Ficha Atendimento:��6   $��0��61   $
��Left=�6A   $��3q�6\   $��0��6g   $��Center=�6t   �� 5+      -   5         ��Name$ fichaAtendimentoTextBox��5+      $��1��67   $
��Left=�6G   $��23��6b   $��3q�6n   $��0��6y   $��Center=�6�   $	��120��6
  ��6�   �� *FichaAtendimento+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6
  5,      5.      5/      