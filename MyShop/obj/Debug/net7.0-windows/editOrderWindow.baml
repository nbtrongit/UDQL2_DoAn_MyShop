   M S B A M L   `   `   `  ����A  =MyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyShopMyShop  5   	       MyShop.editOrderWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MyShop     5   	   -   5          � Title$  EditOrderWindow��5   	   $	��378��6!   $	��601��6.    � 
ResizeMode$ NoResize=�6:    � 	Resources 5	      (   "MyShop.RelativeToAbsoluteConverter   absolute&    MyShop.NumberToCurrencyConverter  currency��%:   &	        &	        5
   
   6,     5   
   6*   5      .��5      �� .+�5   
   �� $
��Bold"�6   $��26(�6"   $��Sửa Đơn Hàng��60   $
��Left=�6G    �� Left$	 202��6b   $��Center=�6t   
 �� Top$ 10��6�   �� 5   
   $��Mã Đơn Hàng��6   $��20(�6&   $��40��64   $ 82��6@   $ 82��6Q   $
��Left=�6a   $��Center=�6|   �� 5   
   -   5        $��textBoxMaDonHang��5      $��20(�6*   $�� ��68   $��40��6@   $
��Left=�6L   $��Center=�6n   $��Center=�6�   $��Center=�6�   $	��150��6�   $	 221��6�   $ 82��6�   �� 5   
   $��Ngày Đơn Hàng��6   $��20(�6(   $��40��66   $ 64��6B   $	 172��6S   $
��Left=�6d   $��Center=�6   �� 5   
   -   5         ��Name$ textBoxNgayDonHang��5      $��20(�6.   $�� ��6<   $��40��6D   $
��Left=�6P   $��Center=�6r   $	��150��6�   $	 221��6�   $	 172��6�   $��Center=�6�   $	��Top=�6�   �� 5   
   -   5        $��	buttonAdd��5      $��20(�6:   $��35��6H   $��80��6T   $��Sửa��6_    �� 	IsDefault$
 True��6m   $	 100��6~   $	 257��6�   $
��Left=�6�   $	��Top=�6�   �� 5   
   -   5        $��buttonCancel��5      $��20(�6@   $��35��6N   $��80��6Z   $��Cancel��6e    �� IsCancel$
 True��6v   $	 386��6�   $	 257��6�   $
��Left=�6�   $	��Top=�6�   5      5      