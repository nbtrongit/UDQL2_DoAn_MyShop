   M S B A M L   `   `   `  ����A  =MyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyShopMyShop  5   	       MyShop.CategoryWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:MyShop     5   	   -   5          � Title$  CategoryWindow��5   	   $	��450��6    $	��800��6-    � 
ResizeMode$ NoResize=�69   .��5	      ]� $
��True��6   .+�5
   
   ��  �� Orientation$ 
Horizontal=�6   $��50��6.   $	��Top=�6:   .+�5      �� -   5         ��Name$ addCategoryButton��5       $��5q�6   $	��Add��6;   $��80��6I   $��35��6T   5      �� 5      -   5        $ deleteCategoryButton��5   !   $��5q�6   $��Delete��6?   $��80��6P   $��35��6[    �� Left$	 144��5   4   
 �� Top$ 18��6F   �� 5      -   5        $ updateCategoryButton��5   !   $��5q�6   $��80��6?   $��35��6J   $��Update��6V   $	 245��5   4   $ 18��6F   5      �� 5   
   $��50��6   $	��Top=�6   $��0,5,0,5q�62   .+�5      �� -   5        $��textBoxNewCategory��5      $y�Hidden=�60   
�������$��50��6�   $	��175��6�   $&�� Nhập loại sản phẩm mới��6�   $��15(�6�   $
��Left=�6�   $��Center=�6�   $
��Left=�6	  $��Center=�6$  �� 5      -   5        $��textBoxEditCategory��5      $y�Hidden=�61   $�� ��6E   $��50��6M   $	��175��6Y   $��15(�6e   $
��Left=�6s   $��Center=�6�   $
��Left=�6�   $	 185��6�   $��Center=�6�   5      �� 5   
   -   5        $��CategorysListView��5   `   $��Disabled=�6   $��10, 10, 0, 0q�6I   ��5      �� 5      .R�5      �� $ Vertical=�6!   $	��100��68   $��30��6D   .+�5      �� $��Stretch=�6$   �� 5      �6   �� *Id+ - �� 5      �6   �� *Ten+5      5      5       ��5#      �� 5$      .R�5%      � 5&       � 	Resources 5)         listViewContextMenu m� Icon �� BitmapScalingMode��%<  &	        �� 5*      .@�5+      m� -   5        $��Delete��5+       5,      �� 5-      $ HighQuality=�6$   $��Data/Icon/delete.png��6R   5/      m� 50      -	   5        $
��Edit��50        51      �� 52      $ HighQuality=�6$   $��Data/Icon/pencil.png��6R   54      55      57      ��59      �� 5:      	 �� 
TargetType"	 ��6   .�5;      �� 
 �� Property
 �@�ContextMenu �� Value# [  5<      5=      5?      5@      5A      