   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Restaurant.ViewsRestaurant.Views  5   	   =#clr-namespace:Restaurant.ViewModelsRestaurant.ViewModels  5   	   #    Restaurant.Views.CustomerView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Restaurant.Views     5   	   3ctx#clr-namespace:Restaurant.ViewModels     5   	     � Title$  La Burtanica��5	   	   $	��650��6   $	��450��6+    � WindowStartupLocation$ CenterScreen=�67   ���#f8edeb � DataContext 5
      -  'Restaurant.ViewModels.CustomerViewModel  5   
    � 	Resources 5         RoundedBorder �� 
TargetType �� Property �� Value  RoundedButtonStyle �� 
TargetType �� CornerRadius	 ��Name
 �� Triggers P� Property P� Value��%�  &	        &	 T     7   �� 5   
   " ��6&   .�5      ��  �@��CornerRadius$ 5��6-   5      �� 5   
   " ��6+   .�5      ��  � �� �#ffb5a76+   �� 5       � ��
 �   �6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 10,10,10,10��6!   #��z��6<   8��  ._�5      �� $	 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6	  5      5      5      
 5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �#e5989b63   �� 5        � ��
 �   �63   5!      P� 5"       � {� .  . �5#      ��  � �� �#f9dcc463   �� 5$       � ��
 �   �63   5%      5'      5(      .��5)      �  � ColumnDefinitions 5*   
   �� 5+      $	��73* �6    � RowDefinitions 5-   
   �� 5.      $
��102* �6   �� 5/      $
��317* �6   �� 50      $��50 �6   .+�52   
   �� $��0��6   $#��../Resources/Images/logo1.png��6   $��-308,0,-328,0q�6D   �� 53   
   $'��!../Resources/Images/chefmenu1.png��6   $��-71,79,-63,0q�6;   $��2��6Q   �� 54   
   $��0,10,0,0q�6   $��2��6&   �� 55   
   $��1��6   #��[ 6   $�� Vezi
meniul��56      $��Lucida Calligraphy)�6,   $��271,152,46,122q�6L   $��25(�6d   $��Center=�6r   $��Center=�57      ��63   �� *
ViewMenu+59      �� 5:   
   $��0��6   $��2��6!   $��60��6.   $
��Left=�69   $��10,2,0,5q�6T   #��[ 5;      $��20(�6=   ��6K   �� *BackCommand+.��5<      �� $'��!../Resources/Images/back-icon.png��6   $��80��6?   6L   5=      5>      5@      