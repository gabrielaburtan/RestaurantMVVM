   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Restaurant.ViewsRestaurant.Views  5   	   =#clr-namespace:Restaurant.ViewModelsRestaurant.ViewModels  5   	   *    $Restaurant.Views.CustomerAccountView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Restaurant.Views     5   	   3ctx#clr-namespace:Restaurant.ViewModels     5   	     � Title$  La Burtanica��5	   	   $	��650��6   $	��450��6+    � WindowStartupLocation$ CenterScreen=�67   ���#f8edeb � DataContext 5
      4  .Restaurant.ViewModels.CustomerAccountViewModel  5   
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
   �� 5+      $	��73* �6   �� 5,      $	��73* �6    � RowDefinitions 5.   
   �� 5/      $
��126* �6   �� 50      $
��443* �6   �� 51      $��50 �6   .+�53   
   �� $��0��6   $#��../Resources/Images/logo1.png��6   $��-114,0,-148,0q�6D   $��2��6[   �� 54   
   $��0��6   $#��../Resources/Images/chef3.png��6    $��0,74,0,0q�6G   $��2��6Y   �� 55   
   $��1��6   $��1��6"    �� Orientation$ Vertical=�62   .+�56      �� #��[ 6   $��35��6A   $��10,100,10,0q�6M   $��☰ Vezi meniul��6b   $��Lucida Calligraphy)�57      $��18(�65   ��6C   �� *SeeMenuCommand+�� 58      #��[ 6   $��35��6A   $��
10,50,10,0q�6M   $��☰ Comenzi active��6a   $��Lucida Calligraphy)�59      $��18(�65   �� 5:      #��[ 6   $��35��6A   $��
10,50,10,0q�6M   $��☰ Istoric comenzi��6a   $��Lucida Calligraphy)�5;      $��18(�65   5=      �� 5>   
   $��2��6   $��0��6   $��50��6.   $
��Left=�69   $��10,2,0,5q�6T   #��[ 5?      $��20(�6=   $��34��6k   ��6K   �� *BackCommand+.��5@      �� $'��!../Resources/Images/back-icon.png��6   $��82��6?   6L   5A      5B      5C      