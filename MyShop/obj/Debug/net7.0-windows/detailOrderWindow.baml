   M S B A M L   `   `   `  ����A  =MyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyShopMyShop  5   	       MyShop.detailOrderWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MyShop     5   	   -   5          � Title$  Detail��5   	   $	��480��6   $	��640��6%    � 
ResizeMode$ NoResize=�61    � 	Resources 5	      (   "MyShop.RelativeToAbsoluteConverter   absolute&    MyShop.NumberToCurrencyConverter  currency��%:   &	        &	        5
   
   6,     5   
   6*   5      .��5      ]� $
��True��6   .+�5   
   �� $��40��6   $
��Bold"�6   $��26(�6.   $	��Top=�6<   $��Center=�6o   $��Center=�6�   ��6Q   �� *	MaDonHang+6�   �� 5   
   $	��190��6   .+�5      �� $��20��6   $	��190��6$   $��Giá trị đơn hàng��60    �� TextAlignment$ Center=�6H   $
��Bold"�6_   $��Center=�6q   $	��Top=�6�   �� 5      $��20��6   $	��190��6$   $ Center=�6m   
���  ��$
��Bold"�6�   $��Center=�6�   
 �� Top$ 25��6�   $	��Top=�6�   ��60   �� *TriGia+ �� 	Converter# [ 6�   �� 5      $��20��6   $	��190��6$   $��Tổng số lượng��60   $ Center=�6E   $
��Bold"�6\   $��Center=�6n   $ 50��6�   $	��Top=�6�   �� 5      $��20��6   $	��190��6$   $ Center=�6I   
���  ��$
��Bold"�6q   $ 75��6�   $��Center=�6�   $	��Top=�6�   ��60   �� *	SoLuong+6�   �� 5      $��20��6   $	��190��6$   $��Ngày��60   $ Center=�6<   $
��Bold"�6S   $	 100��6e   $��Center=�6v   $	��Top=�6�   �� 5      $��20��6   $	��190��6$   $ Center=�6n   
���  ��$
��Bold"�6�   $	 125��6�   $��Center=�6�   $	��Top=�6�   ��60   �� *NgayDonHang+ �� StringFormat$ {0:dd/MM/yyyy}��6�   5      �� 5   
   -   5        $��ProductsListView��5   \   $
��Auto=�6   $��10, 10, 0, 0q�6E   ��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6!   $	��140��68   $	��140��6D   .+�5      ��  �� BitmapScalingMode$ HighQuality=�6    $��
0, 0, 5, 0q�5   `   $��60��5       $��60��6+   ��5       �� *	HinhAnh+# [  5   +   �� 5       
���  ��$��Center=�6J   ��6$   �� *Ten+6J   �� 5!      $
��Bold"�6=   $��Center=�6O   ��6$   �� *	SanXuat+6O   �� 5"      $
��Bold"�6^   $��Center=�6p   ��6$   �� *Gia+# [ 6p   �� 5#      $
��Bold"�6$   $��Center=�66   �� 5$      $�Đơn Giá:��6"   64    �� 5%      �6"   �� *Gia+# [ 6^   5&      �� 5(      $��Center=�6$   �� 5)      $�Số Lượng:��6"   65    �� 5*      �6"   �� *	SoLuong+6=   5+      5,      5-      ��50      �� 51      .R�52      � 53      56      57      58      