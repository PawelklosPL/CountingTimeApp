   M S B A M L   `   `   `  ����J  FCountingTimeApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CountingTimeAppCountingTimeApp  5   	        CountingTimeApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CountingTimeApp     5   	     � Title$  
MainWindow��5   	   $	��600��6   $
��1000��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ button��5      $��Stats��6!   $
��Left=�61   $��
106,70,0,0q�6L   $	��Top=�6`   $��74��6x   �� 5   
   -   5        $ button1��5      $��Add Activity��6"   $
��Left=�69   $��106,122,0,0q�6T   $	��Top=�6i   $��75��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5   M      
IsReadOnly . $��1��6_   $
��Left=�6o   $	��569��6�   $��10,0,0,0q�6�   $	��Top=�6�   $	��486��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6?   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+6?     5      $
 Path��6>    6%   �� *Path+6>     5      $
 Time��6Y    6%   �� *Time+ �� StringFormat$ 
hh\:mm\:ss��6Y   5      5      5      