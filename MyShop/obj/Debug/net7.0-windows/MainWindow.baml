   M S B A M L   `   `   `  ����A  =MyShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyShopMyShop  5      M IFluent, Version=9.0.0.0, Culture=neutral, PublicKeyToken=3e436e32a8c5546f/$clr-namespace:Fluent;assembly=FluentFluent 5          MyShop.MainWindow   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      &localclr-namespace:MyShop     5      7Fluent$clr-namespace:Fluent;assembly=Fluent     5      -   5          � Title$
  Main��5	      $	��480��6#   $	��640��60    � 
ResizeMode$ NoResize=�6<    � 	Resources 5
      (   "MyShop.RelativeToAbsoluteConverter   absolute&    MyShop.NumberToCurrencyConverter  currency��%:   &	        &	        5   
   6,     5   
   6*   5      .��5      �� .+�5   
   �� $��Center=�6   $��26(�64   $
��Bold"�6B   $��	Dashboard��6T   $
��Left=�6h   $	��Top=�6�   $	��437��6�    �� Left$	 116��6�   
 �� Top$	 101��6�   6�   �� 5   
   $"��Số sản phẩm đang bán��6   $	 116��6/   $	 151��6A   6T   �� 5   
   -   5        $��TextBlockSoLuongSanPham��5      $��0��63   $
��Left=�6<   $��Center=�6W   $��86��6r   $	 248��6}   $	 155��6�   6�     Fluent.Ribbon  5   
   $��Center=�6   $��96��65      Menu 5        Fluent.Backstage  5        Fluent.RibbonControl   Header$
 Main��6#      Content. 5         Fluent.BackstageTabControl  .@�5        Fluent.BackstageTabItem  -   5           Header$ Import��5   2   6r     5      -   5        $
 Exit��5   2   6n   5      5      	   Tabs.	 5        Fluent.RibbonTabItem  
   Header$
 
Quản Lý��6#      Groups. 5      	  Fluent.RibbonGroupBox	  .@�5       
  Fluent.Button
  -   5        $��buttonCategory��5    $   $
��Bold"�6W    
  Header$ Loại Hàng��6i    
  Icon 5!      �� 5"      $ ��Data/Icon/ico_category.png��6$    �� BitmapScalingMode$ HighQuality=�6H   6x   5$      
  5%      -   5        $��buttonProduct��5%   $   $
��Bold"�6U   $ Sản Phẩm��6g    5&      �� 5'      $��Data/Icon/ico_product.jpg��6$   $ HighQuality=�6G   6w   5)      
  5*      -   5        $��buttonOrder��5*   $   $
��Bold"�6Q   $ Đơn Hàng��6c    5+      �� 5,      $��Data/Icon/ico_order.png��6$   $ HighQuality=�6E   6u   5.      5/      50        52      $
 	Báo Cáo��6#   . 53      	  .@�54      
  -   5        $��buttonRevenueProfit��54   $   $
��Bold"�6a   $ Doanh Thu - Lợi Nhuận��6s    55      �� 56      $��Data/Icon/ico_revenue.png��6$   $ HighQuality=�6G   6w   58      
  59      -	   5        $��buttonReportProduct��59   $   $
��Bold"�6a   $ Số lượng bán��6s    5:      �� 5;      $%��Data/Icon/ico_reportproduct.png��6$   $ HighQuality=�6M   6}   5=      5>      5?        5A      $
 Database��6#   . 5B      	  .@�5C      
  -
   5        $��buttonBackup��5C   $   $
��Bold"�6S   $ Backup��6e    5D      �� 5E      $��Data/Icon/ico_backup.png��6$   $ HighQuality=�6F   6v   5G      
  5I      -   5        $��buttonRestore��5I   $   $
��Bold"�6U   $ Restore��6g    5J      �� 5K      $��Data/Icon/ico_restore.png��6$   $ HighQuality=�6G   6w   5M      5N      5O      5P      �� 5Q   
   $��Số đơn trong tuần��6   $	 116��6,   $	 178��6>   $��Center=�6O   $	��Top=�6l   �� 5R   
   -   5         ��Name$&  TextBlockSoLuongDonHangTrongTuan��5R      $��0��6>   $��86��6G   $	 248��6R   $	 182��6d   $��Center=�6u   $	��Top=�6�   �� 5S   
   $$��Sản phẩm sắp hết hàng��6   $	 116��60   $	 209��6B   $��Center=�6S   $	��Top=�6p   �� 5T   
   -   5        $��ProductsListView��5T   `   $��Disabled=�6   $��10, 10, 0, 0q�6I   $	��182��6x   $	��412��6�   $	 114��6�   $	 240��6�   ��5U      �� 5V      .R�5W      ��  �� Orientation$ Vertical=�6!   $	��128��68   $	��128��6D   .+�5X      �� $ HighQuality=�6    $��
0, 0, 5, 0q�5Y   `   $��60��5Z       $��60��6+   ��5Y       �� *	HinhAnh+ �� 	Converter# [  5Z   +   �� 5[      
���  ��$��Center=�6J   ��6$   �� *Ten+6J   �� 5\      $
��Bold"�6=   $��Center=�6O   ��6$   �� *	SanXuat+6O   �� 5]      $
��Bold"�6^   $��Center=�6p   ��6$   �� *Gia+# [ 6p   �� 5^      $��Center=�6$   �� 5_      $�Số Lượng: ��6"   66    �� 5`      �6"   �� *	SoLuong+6=   5a      5b      5c      ��5f      �� 5g      .R�5h      � 5i      5k      5l      5m      