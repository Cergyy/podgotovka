   M S B A M L   `   `   `  ����E  APodgotovka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Podgotovka
Podgotovka  5   	       Podgotovka.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Podgotovka     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ShowGridLines .  � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      $
��Auto �6   6,    � ColumnDefinitions 5   
   �� 5      $	��250 �6   6-   �� 5      6!   .+�5   
   �� $��Bottom=�6   $��3��60   .+�5      �� $��
Выход��6   $��50��6%   5      &   System.Windows.Controls.DataGrid  5   
   $��1��5      $��1��5         CanUserAddRows .     AutoGenerateColumns .  ��5      �� *	BusList+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Марка��5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *Name+  5       $# Количество Мест��5!       5"      �� *	KolMest+  5#      $ Расход��5$       5%      �� *Rasxod+  5&      $ Дата��5'       5(      �� *Vremiy+  5)      $ Вид��5*       5+      �� *Vvid+5-      � 5.   
   $��1��6   .+�5/      �� $��	Виды:��50      $��Center=�51      �� 53      -   5        $��VvidFilterComboBox��54      $��Center=�56      $	��100��57      	 �� SelectedIndex$	 0��58      ��59      �� *
VvidList+��5;      �� 5<      .R�5=      �� ��5>      �� *Title+5?      5A      5B      � 5C   
   $��1��6   $	��250��6$   .+�5D      �� $��искать��5E      $��Center=�5F      �� 5G      -   5        
 ��Name$
 SearchFilterTextBox��5J      $	��100��5H      $��Center=�5I      5K      �� 5M      $��1��6   $��Кол Мест:��5N      $��Center=�5O      	� 5P      -   5         	� 	GroupName$ KolMest��5Q      
 � Tag$ 1��5R      $!��по возрастанию��5S       d� 	IsChecked$
 TrueY�5T      $��Center=�5V      	� 5W      -   5        $ KolMest��5X      $ 2��5Y      $��по убыванию��5Z      $��Center=�5\      5]      5^      5_      