   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Restaurant.ViewsRestaurant.Views  5   	   #    Restaurant.Views.ActiveOrders   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Restaurant.Views     5   	     � Title$  ActiveOrders��5   	   $	��450��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�67   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��140* �6   �� 5      $	��50* �6   �� 5      $
��238* �6   �� 5      $	��41* �6   .+�5   
   �� $#��../Resources/Images/logo1.png��6   $
��Left=�67   $��-160,-10,0,0q�6R   $	��619��6h   �� 5   
   $(��"../Resources/Images/restaurant.png��6   $��Right=�6<   $
��0,10q�6X   $	��279��6f   6t   �� 5   
   $��0��6   $��Comenzi active��6   $��Center=�66   $��Center=�6S   $��Lucida Calligraphy)�6n   $��30(�5      $��64��6   $��279,35,247,41q�6*   $	��266��6A   �� 5   
   $��1��6   $��Preparat��6   $��20(�60   $��Lucida Calligraphy)�6>   $��
10,0,500,0q�6^   $��Center=�5      $��Center=�5      �� 5   
   $��1��6   $��	Cantitate��6   $��20(�61   $��Lucida Calligraphy)�6?   $��459,0,145,0q�6_   $��Center=�5      $��Center=�5      5      �� 5   
   $��1��6   $
��Data��6   $��20(�6,   $��Lucida Calligraphy)�6:   $��344,0,316,0q�6Z   $��Center=�5      $��Center=�5      5      �� 5   
   $��1��6   $��	Pret(RON)��6   $��20(�61   $��Lucida Calligraphy)�6?   $��	647,0,0,0q�6_   $��Center=�5       $��Center=�5!      5"      �� 5#   
   $��2��6   $��Stretch=�6    $��Stretch=�6>   ��6Z   �� *ProductsCollection+ �� SelectedItem 6�   �� *SelectedProduct+��5$      �� 5%      .R�5&      A�  A� Columns$ 1��6"   $��Stretch=�6.   5'      ��5)      �� 5*      .R�5+      ��  �� Orientation$ 
Horizontal=�6!   $	��900��6:   $��50��6F   $	��Top=�6R   $��Stretch=�6j   .+�5,      �� $	��350��6    $��50��6,   $��Lucida Calligraphy)�6Q   $��12(�6q   $��Center=�5-      $
��Left=�5.      ��5,   8   �� *Name+5.      �� 5/      $	��350��6    $��50��6,   $��Lucida Calligraphy)�6Q   $��12(�6q   $��Center=�50      $
��Left=�51      ��5/   8   �� *Data+51      �� 52      $	��150��6    $��50��6,   $��Lucida Calligraphy)�68   $��15(�6X   $��Center=�53      $��Center=�54      $��80,0,0,0q�55   =   ��6    �� *
Quantity+6=   �� 56      $��50��6    $��50��6+   $��Lucida Calligraphy)�67   $��15(�6W   $��Center=�57      $��Center=�58      $��	150,0,0,0q�59   :   ��6    �� *Price+6:   5;      5<      5>      5?      5@      