   M S B A M L   `   `   `  ����I  ECoffeHouse3914, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CoffeHouse3914.WindowsCoffeHouse3914.Windows  5   	   '    !CoffeHouse3914.Windows.MenuWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:CoffeHouse3914.Windows     5   	     � Title$  
MainWindow��5   	   $	��800��5	   	   $
��1200��5
   	   .��5      � 
���`��� � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� -   5         ��Name$ BtnAddProduct��5      $��3��5      $
��Left=�5      
������ 
������ .��5      �� -   5         ��Name$ ImgAddProduct��5      $K��EC:\Users\IMac6\source\repos\CoffeHouse3914\CoffeHouse3914\Res\add.png��6+   5      �� 5   
   $8��2C:\Users\IMac6\source\repos\GS3ISP9-14\Res\cof.png��6    J� Opacity$	 0.7Q�6L   $��4��6Z   $��4��6n   �� 5    
   $!��Список товаров��6   $��Center=�5!      $��30(�5"      $
��Bold"�5#      �� 5%   
   -   5        $ GoToCart��5%      $��Корзина��5&      $��20(�5'      $��40��5(      $��90��5)      $��1��5*      $��Right=�5+      $��Center=�5,      6,   �� 5/   
   -   5         ��Name$ LvProductList��5/      $��2��50      $��Disabled=�52      
���`�����55      �� 56      .R�57      � 58      ��5;      �� 5<      .R�5=      �� 
���   �$��1q�5>      $��5q�5?      $	��200��5@      $	��300��5A      ._�5B      �� .+�5C      �� $	��170��6$   $	��200��5D   $   $
��Fill=�5E   $   ��5F   "   �� 5G   &    �� Path$ 	PhotoPath�6.    �� TargetNullValue 5H   *   ��5I   .   /Res/null.jpg��6I   5K   '   5M      �� 5N      $��18(�5O   (   $
��Bold"�5P   (   $��10 0 0 0q�5Q   (   $
��Wrap=�5R   (   ��5N   (   �� *Title+5R   (   �� 5T      $��18(�5U   (   $
��Bold"�5V   (   $��10 0 0 0q�5W   (   ��5T   (   �� *Price+5W   (   �� 5X       ��Name$
 Cart��6)   $��Right=�67   $��Center=�6S   $��0 0 5 5q�6n   .+�5Y   "   �� $ ToCart��6)   -   5        $��To cart��5Z   )   $��40��6;   $��40��6F   6R   5\      5]      5^      5_      5b      5c      5d      