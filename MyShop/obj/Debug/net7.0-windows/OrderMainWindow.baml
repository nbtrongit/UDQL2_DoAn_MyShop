   M S B A M L   `   `   `  ����A  =MyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyShopMyShop  5   	       MyShop.OrderMainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MyShop     5   	   -   5          � Title$  OrderMainWindow��5   	   $	��720��6!   $
��1280��6.    � 
ResizeMode$ NoResize=�6;    � 	Resources 5	      (   "MyShop.RelativeToAbsoluteConverter   absolute&    MyShop.NumberToCurrencyConverter  currency��%:   &	        &	        5
   
   6,     5   
   6*   5      .��5      ]� $
��True��6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��50��6.   $	��Top=�6:   .+�5      �� -   5         ��Name$ buttonAddOrder��5       $��5q�6   $	��Add��68   $��80��6F   $��35��6Q   5      �� 5      -   5        $ buttonDeleteOrder��5   !   $��5q�6   $��Delete��6<   $��80��6M   $��35��6X   5      �� 5      -   5        $ buttonUpdateOrder��5   !   $��5q�6   $��80��6<   $��35��6G   $��Update��6S   5      �� 5      -   5        $ buttonFilterDate��5       $��5q�6   $��80��6:   $��34��6E   $
��Date��6Q   5      �� 5      -   5         ��Name$ textBoxFirstDate��5      $��
dd/mm/yyyy��60   
�������$��Center=�6}   $��Center=�6�   $��80��6�   $��34��6�   �� 5      $��-��6   $��Center=�6!   �� 5      -   5        $ textBoxLastDate��5      $��
dd/mm/yyyy��6/   
�������$��Center=�6{   $��Center=�6�   $��80��6�   $��34��6�   5      �� 5   
   $	��Top=�6   $��50��6&   $��0,5,0,5q�62   .+�5      �� -   5        $��textBoxNewOrder��5   '   $��5,0,0,0q�6   $y�Hidden=�6>   
�������$��50��6�   $	��175��6�   $��Nhập mã đơn hàng��6�   $��15(�6�   $
��Left=�6�   $��Center=�6�   $
��Left=�6  $��Center=�6)  5      �� 5   
   $��Bottom=�6   $��70��6)   .+�5       �� -	   5        $��pagingComboBox��5    J    �� Left$	 545��6a   
 �� Top$ 20��6s   $��Center=�6�   $��Center=�6�   $	��130��6�   $��34��6�   $��Center=�6�   $	��Top=�6�   ��5!      �� 5"      .R�5#      �� $��Stretch=�6$   �� 5$      �6   �� *Item1+ �� Mode$ OneTime=� / �� 6H   �6L   �� *Item2+$ OneTime=�5%      5&      5(      �� 5)      -
   5        $��
buttonPrev��5)      $��80��6'   $��34��62   $
��Prev��6W   $	 460��6f   $ 20��6x   $��Center=�6�   $	��Top=�6�   �� 5*      -   5        $��
buttonNext��5*      $��80��6'   $��34��62   $
��Next��6W   $	 680��6f   $ 20��6x   $��Center=�6�   $	��Top=�6�   5+      �� 5,   
   -   5        $��OrdersListView��5,   `   $��Disabled=�6   $��10, 10, 0, 0q�6I   ��5-      �� 5.      .R�5/      �� $ Vertical=�6!   $	��140��68   $��80��6D   .+�50      �� 
���  ��$��Center=�6P   ��6$   �� *	MaDonHang+6P   �� 51      $
��Bold"�6$   $��Center=�66   �� 52      $�Số Lượng: ��6"   66    �� 53      �6"   �� *	SoLuong+6=   54      �� 55      $
��Bold"�6$   $��Center=�66   �� 56      $�Trị Giá: ��6"   65    �� 57      �6"   �� *TriGia+	 �� 	Converter#	 [ 6a   58      �� 59      $��Center=�6b   ��6$   �� *NgayDonHang+
 �� StringFormat$
 {0:dd/MM/yyyy}��6b   5:      5;      ��5>      �� 5?      .R�5@      � 5A       5D        listViewContextMenu m� Icon �� BitmapScalingMode��%<  &	       �� 5E      .@�5F      m� -   5        $��Delete��5F       5G      �� 5H      $ HighQuality=�6$   $��Data/Icon/delete.png��6R   5J      m� 5K      -   5        $
��Edit��5K        5L      �� 5M      $ HighQuality=�6$   $��Data/Icon/pencil.png��6R   5O      5P      5Q      ��5S      �� 5T       �� 
TargetType" ��6   .�5U      ��  �� Property �@�ContextMenu �� Value# [ 5V      -   5        5Y      5\      5]      5^      