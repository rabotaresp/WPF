   M S B A M L   `   `   `  ����D  @Open_Form, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Open_Form	Open_Form  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	       Open_Form.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Open_Form     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	     � Title$  
MainWindow��5	   	   $	��680��6   $
��auto��6)    � 	Resources 5
      ��%    5      .��5      � .+�5   
   o� $��25��6   $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5        $��Open Project��5      6K   �� 5      m� 5      -   5        $
��Exit��5      6E   5       c� 5!      $��25��6   $	��Top=�6"   .@�5"      �� -   5         ��Name$ toolbar_search_text��5"      
�������$	��100��6N   .��6�   Поиск...6�   5#      5$      &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ All_User_list��5%   %   $��0 30 0 0q�6      AutoGenerateColumns .     	RowHeight$	 200Q�6X      Columns 5&      4  .System.Windows.Controls.DataGridTemplateColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Фото��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 67   	   CellTemplate	 5(      �� 5)      .R�5*      �� 
 ��Name$
 ItemImageBorder��6%   $	��200��6>   $	��200��6J   ._�5+      �� ��6$   �� *Img+5,      5-      5/      0  *System.Windows.Controls.DataGridTextColumn  50      -   5        Fild_FIO��$ 	Ф.И.О.��50   7      FontSize$ 16Q�6G   $
 Auto 6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6U   �� *Fio+6m     51      -   5        
Fild_EMail��$ E-Mail��51   9   $ 16Q�6I   $
 Auto 6q    6W   �� *Email+6q     52      -   5        
Fild_Phone��$ Телефон��52   9   $ 16Q�6J   $
 Auto 6r    6X   �� *Phone+6r     53      -   5        Fild_Experience��$ Опыт��53   >   $ 16Q�6L   $
 Auto 6y    6Z   �� *
Experience+6y     54      $ Источники��6)   $
 Auto 6<   	 55      �� 56      .R�57      ��  ��Name$ Fild_Source��6'   $��16(�6<   $
��Auto��6o   ��6J   ��  �� Path$ Source�6o   58      5:      5<      5=      5>      