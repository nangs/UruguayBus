   M S B A M L   `   `   `  ����C  ?Terminal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TerminalTerminal  5   	       Terminal.FyH_selectViaje   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Terminal     5   	     � Title$  
UruguayBus��5   	   $	��450��6   $	��800��6)    � Icon$ /background/icon.png��5	   	    � WindowStartupLocation$ CenterScreen=�5
   
   .��5      � -   5         �Name$ FyH_selectViaje1��5      ��5   
   �� 5       j� Stretch$
 Fill=�6    �� ImageSource$ background\bg.png��6(    j� 
AlignmentY$	 Top=�5       j� 
AlignmentX$ Center=�6"   .+�5   
   �� -   5         ��Name$ 	btnVolver��5      
������
�������$��Volver��6Q   $
��Left=�6b   $��
51,343,0,0q�6}   $	��Top=�6�   $��74��6�   $��18(�6�   $��29��6�   6�   �� 5   
   -   5        $ btnSig��5      $��	Siguiente��6!   
������
�������$
��Left=�6b   $��645,344,0,0q�6}   $	��Top=�6�   $��96��6�   $��18(�6�   $��29��6�   6�   �� 5   
   -   5        	 ��Name$	 lbHdS��5      
�������$
��Bold"�62   $��Seleccione Hora de Salida��6D   $
��Left=�6h   $��	45,77,0,0q�6�   $	��Top=�6�   $��14(�6�   $	��192��6�   $��30��6�   �� 5   
   -   5        
 ��Name$
 
lsHdSalida��5      
������ 
�������$
��Left=�6S   $	��213��6n   $��
51,112,0,0q�6{   $	��Top=�6�   $	��242��6�   ��5      �� 5      .R�5      �� 
��������� 5      �6   �� *
IdSalida+ �� 5      $�-��6    �� 5      �6   �� *
HoraInicio+5      5      5      �� 5   
   -   5        $	 lbFdS��5      
�������$
��Bold"�62   $ ��Seleccione fecha de salida��6E   $
��Left=�6j   $��
309,77,0,0q�6�   $	��Top=�6�   $��14(�6�   $��30��6�   �� 5   
   -   5        $

 lsFs��5      $
��Left=�6    
������ 
�������$	��213��6i   $��309,112,0,0q�6v   $	��Top=�6�   $	��249��6�   ��5       �� 5!      .R�5"      �� 
��������� 5#      �6   �� *	IdViaje+ �� 5$      $�-��6    �� 5%      �6   �� *Fecha+ �� StringFormat$ {0:dd-mm-yyyy}��5&      5'      5)      �� 5*   
   -   5        $		 lbA��5*      
�������$
��Bold"�60   $��Seleccione asiento��6B   $
��Left=�6_   $��
568,77,0,0q�6z   $	��Top=�6�   $��14(�6�   $��30��6�   �� 5+   
   -	   5        $	
 lsA��5+      
������ 
�������
�������$
��Left=�6_   $	��213��6z   $��573,112,0,0q�6�   $	��Top=�6�   $	��169��6�   6�   �� 5,   
   -
   5        $	 lbTit��5,      
�������$
��Bold"�62   $#��Terminal de compra de pasajes��6D   $
��Left=�6l   $��
149,16,0,0q�6�   $	��Top=�6�   $��36(�6�   5.      5/      