   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:TP_Feugere_Adipietro_GarrachTP_Feugere_Adipietro_Garrach  5   	   3    -TP_Feugere_Adipietro_Garrach.ListeDesContacts   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:TP_Feugere_Adipietro_Garrach     5   	     � Title$  Liste Des Contacts��5   	   $��691.333��6$   $	��673��65    � Left$ 50��6A   
 � Top$ 10��6K   .��5	      � $��0,0,0,0q�6   ��5
   
   �� 5       �� ImageSource$ Ressources/background.jpg��6    � ColumnDefinitions 5   
   �� 5      $
��173* �6   �� 5      $
��160* �6   .+�5   
   �� -   5         ��Name$ listBoxContact��5      $
��Left=�6*   $	��332��6E   $��
21,186,0,0q�6R   $	��Top=�6f   $	��578��6~   ���	#FF170B0B J� Opacity$	 0.5Q�6�   ���	#FFF9F9F9$��2��6�   $��Verdana)�6�   $��16(�6�   � 5   
   $
��Left=�6   $	��113��6*   $��	21,36,0,0q�67   $	��Top=�6J   $	��578��6b   $��2��6n   
���   �$	 0.6Q�6�   .+�5      �� -   5         ��Name$ 	NomSearch��5      $
��Left=�6)   $��35��6D   $��	10,10,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $��Nom...��6w   $	��Top=�6�   $	��151��6�   $	 0.4Q�6�   $��Verdana)�6�   $��0,0,0,2q�6�   
�������$��16(�6  ��6�   Z� 6  �� 5      -   5        $ VilleSearch��5      $
��Left=�6+   $��35��6F   $��
186,65,0,0q�6R   $
 Wrap=�6f   $��Ville...��6z   $	��Top=�6�   $	��134��6�   $	 0.4Q�6�   $��Verdana)�6�   $��0,0,0,2q�6�   
�������$��16(�6  ��6�   Z� 6%  �� 5      -   5        $ 
PaysSearch��5      $
��Left=�6*   $��35��6E   $��	10,65,0,0q�6Q   $
 Wrap=�6d   $��Pays...��6x   $	��Top=�6�   $	��151��6�   $	 0.4Q�6�   $��Verdana)�6�   $��0,0,0,2q�6�   
�������$��16(�6  ��6�   Z� 6"  �� 5      -   5        	 ��Name$	 buttonSearch��5      $�� ��6+   $
��Left=�66   $��
500,50,0,0q�6Q   $	��Top=�6e   $��68��6}   $��50��6�   $��0q�6�   
 J� RenderTransformOrigin$
 0.015,-1.46&�6�   ��5      �� 5      $ Ressources/search.png��6!    j� Stretch$ UniformToFill=�6E   5      �� 5      -   5        $ Prenom_Search��5      $
��Left=�6-   $��35��6H   $��
186,10,0,0q�6T   $
 Wrap=�6h   $��	Prenom...��6|   $	��Top=�6�   $	��134��6�   $	 0.4Q�6�   $��Verdana)�6�   $��0,0,0,2q�6�   
�������$��16(�6  ��6�   Z� 6(  5      �� 5   
   -   5        $	 buttonUpdate��5      $��Update��6'   $
��Left=�68   $��
88,556,0,0q�6S   $	��Top=�6g   $	��138��6   $��41��6�   ���	#FF439AA8$��Verdana)�6�   
�������6�   �� 5   
   -   5        $	 buttonDelete��5      $��2��6'   $��Delete��6;   $
��Left=�6L   $��280,556,0,0q�6g   $	��Top=�6|   $	��123��6�   $��41��6�   ���	#FF439AA8$��Verdana)�6�   
�������6�   �� 5   
   -	   5        $	 buttonRetour��5      $��Retour��6'   $��1��68   $
��Left=�6H   $��140,556,0,0q�6c   $	��Top=�6x   $	��114��6�   $��41��6�   ���	#FF439AA8$��Verdana)�6�   
�������6�   5"      5#      