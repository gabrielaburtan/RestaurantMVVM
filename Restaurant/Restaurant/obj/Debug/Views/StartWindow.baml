   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Restaurant.ViewsRestaurant.Views  5   	   =#clr-namespace:Restaurant.ViewModelsRestaurant.ViewModels  5   	   "    Restaurant.Views.StartWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Restaurant.Views     5   	   3ctx#clr-namespace:Restaurant.ViewModels     5   	     � Title$  La Burtanica��5	   	   $	��650��6   $	��450��6+    � WindowStartupLocation$ CenterScreen=�67   ���#ffb5a7 � DataContext 5
      0  *Restaurant.ViewModels.StartWindowViewModel  5   
    � 	Resources 5         RoundedBorder �� 
TargetType �� Property �� Value  RoundedButtonStyle �� 
TargetType �� CornerRadius	 ��Name
 �� Triggers P� Property P� Value��%�  &	        &	 T     7   �� 5   
   " ��6&   .�5      ��  �@��CornerRadius$ 5��6-   5      �� 5   
   " ��6+   .�5      ��  � �� �#ffb4a26+   �� 5       � ��
 �   �6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 10,10,10,10��6!   #��z��6<   8��  ._�5      �� $	 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6	  5      5      5      
 5      P� 5       �@J�IsMouseOver . . �5      ��  � �� �#e5989b63   �� 5        � ��
 �   �63   5!      P� 5"       � {� .  . �5#      ��  � �� �#f9dcc463   �� 5$       � ��
 �   �63   5%      5'      5(      .��5)      �  � RowDefinitions 5*   
   �� 5+      $
��139* �6   �� 5,      $
��168* �6   �� 5-      $
��312* �6    � ColumnDefinitions 5/   
   �� 50      �� 51      .+�53   
   �� $��2��6   $��0��6(   ���#f8edeb6F   �� 54   
   $��0��6   $��2��6   $#��../Resources/Images/logo1.png��61   $��-175,0,-187,0q�6X   �� 55   
   $��1��6   $��2��6   $ ��La Burtanica
 -Restaurant-��61   $��Center=�6[   $��Center=�56      $	��Top=�6/   $��45(�6G   $��Lucida Calligraphy)�6U   $	��180��6u   $��2��6�   �� 57   
   $��2��6   $��2��6!   ���#f8edeb6F   �� 58   
   $��0��6   $��2��6    $#��../Resources/Images/chef3.png��6-   $��	0,10,0,10q�6T   �� 59   
   $��1��6   $��2��6%    �� Orientation$ Vertical=�62   .+�5:      �� $��Intra in cont��6   $	��150��6-   $��35��69   $��0,60,0,0q�6E   $��20(�5;      #��[ 6#   $��Lucida Calligraphy)�5<      ��65   �� *SignInCommand+�� 5=      $��Creeaza cont��6   $	��150��6,   $��35��68   $��0,30,0,0q�6D   $��20(�5>      #��[ 6#   $��Lucida Calligraphy)�5?      ��65   �� *SignUpCommand+�� 5@      $��Continua
fara cont��6   $	��150��66   $��55��6B   $��0,30,0,0q�6N   $��20(�5A      #��[ 6#   $��Lucida Calligraphy)�6O   ��5B      �� *WithoutAccountCommand+5C      5D      5E      