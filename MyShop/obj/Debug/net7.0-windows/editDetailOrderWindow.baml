   M S B A M L   `   `   `  ����A  =MyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyShopMyShop  5   	   "    MyShop.editDetailOrderWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MyShop     5   	   -   5          � Title$  editDetailOrderWindow��5   	   $	��720��6'   $
��1280��64    � 
ResizeMode$ NoResize=�6A    � 	Resources 5	      (   "MyShop.RelativeToAbsoluteConverter   absolute&    MyShop.NumberToCurrencyConverter  currency��%:   &	        &	        5
   
   6,     5   
   6*   5      .��5      ]� $
��True��6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��50��6.   $	��Top=�6:   .+�5      �� -   5         ��Name$ buttonEditOrder��5       $��5q�6   $
��Edit��69   $��80��6H   $��35��6S   5      �� 5      -   5        $ buttonDeleteOrder��5   !   $��5q�6   $��Delete��6<   $��80��6M   $��35��6X   5      5      �� 5   
   -   5        $��OrdersListView��5   `   $��Disabled=�6   $��10, 10, 0, 0q�6I   ��5      �� 5      .R�5      �� $ Vertical=�6!   $	��140��68   $��80��6D   .+�5      �� 
���  ��$��Center=�6P   ��6$   �� *	MaDonHang+6P   �� 5      $
��Bold"�6$   $��Center=�66   �� 5      $�Số Lượng: ��6"   66    �� 5      �6"   �� *	SoLuong+6=   5      �� 5      $
��Bold"�6$   $��Center=�66   �� 5      $�Trị Giá: ��6"   65    �� 5       �6"   �� *TriGia+ �� 	Converter# [ 6a   5!      �� 5"      $��Center=�6b   ��6$   �� *NgayDonHang+ �� StringFormat$ {0:dd/MM/yyyy}��6b   5#      5$      ��5'      �� 5(      .R�5)      � 5*       5-        listViewContextMenu m� Icon �� BitmapScalingMode��%<  &	       �� 5.      .@�5/      m� -   5        $��Delete��5/       50      �� 51      $ HighQuality=�6$   $��Data/Icon/delete.png��6R   53      m� 54      -   5        $
��Edit��54        55      �� 56      $ HighQuality=�6$   $��Data/Icon/pencil.png��6R   58      59      5:      ��5<      �� 5=      	 �� 
TargetType"	 ��6   .�5>      �� 
 �� Property
 �@�ContextMenu �� Value# [ 5?      5@      5C      5D      5E      