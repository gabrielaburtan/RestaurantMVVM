   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Restaurant.ViewsRestaurant.Views  5   	   =#clr-namespace:Restaurant.ViewModelsRestaurant.ViewModels  5   	   )    #Restaurant.Views.ProductDetailsView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Restaurant.Views     5   	   3ctx#clr-namespace:Restaurant.ViewModels     5   	     � Title$  ProductDetailsView��5	   	   $	��500��6$   $	��800��61    � WindowStartupLocation$ CenterScreen=�6=   ���#f8edeb � 	Resources 5
         RoundedBorder �� 
TargetType �� Property �� Value  RoundedButtonStyle �� 
TargetType �� CornerRadius ��Name	 �� Triggers
 P� Property P� Value��%�  &	        &	 T     7   �� 5   
   " ��6&   .�5      ��  �@��CornerRadius$ 5��6-   5      �� 5   
   " ��6+   .�5      ��  � �� �#ffb5a76+   �� 5       � ��
 �   �6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 10,10,10,10��6!   #��z��6<   8��  ._�5      �� $ contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6	  5      5      5      	 5      P� 5      
 �@J�IsMouseOver . . �5      ��  � �� �#f0808063   �� 5       � ��
 �   �63   5      P� 5      
 � {� .  . �5       ��  � �� �#f9dcc463   �� 5!       � ��
 �   �63   5"      5$      5%       � DataContext 5&      3  -Restaurant.ViewModels.ProductDetailsViewModel  5'   
   .��5)      �  � RowDefinitions 5*   
   �� 5+      $	��94* �6   �� 5,      $
��133* �6   �� 5-      $	��49* �6   �� 5.      $
��149* �6   �� 5/      $	��44* �6   .+�51   
   �� $#��../Resources/Images/logo1.png��6   $
��Left=�67   $��-140,-10,0,0q�6R   $	��547��6h   �� 52   
   $(��"../Resources/Images/restaurant.png��6   $��Right=�6<   $
��0,10q�6X   $	��203��6f   6t   �� 53   
   $��0��6   $��Detalii produs��6   $��Center=�66   $��Center=�6S   $��Lucida Calligraphy)�6n   $��30(�54      $��64��6   $��207,13,203,17q�6*   $	��382��6A   $��Center=�6M   $��Center=�55      �� 56   
   $��2��6   $��	57,0,49,0q�6   $��Center=�60   $��Center=�57      $��20(�6V   $��Lucida Calligraphy)�58      ��57   6   �� *ProductName+58      �� 59   
    �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5:      �� $	��200��6   $��50,0,0,0q�6    ��62   �� *
FirstImage+�� 5<      $	��200��6   $��	300,0,0,0q�6    ��63   �� *SecondImage+5=      �� 5>   
   $��3��6   $ Vertical=�6"   .+�5?      �� $ 
Horizontal=�6   .+�5@      �� $��
Categorie:��6   $��36��6-   $��20(�69   $��Lucida Calligraphy)�6G   $��Center=�6g   $	��Top=�6�   $	��126��6�   $��	230,0,0,0q�6�   �� 5A      $��34��6   $��18(�6$   $	��254��62   $��Lucida Calligraphy)�6>   $	��Top=�5B      $
��Left=�6,   ��6N   �� *
Category+5C      �� 5D      $ 
Horizontal=�6   .+�5E      �� $��Pret:��6   $��36��6(   $��20(�64   $��Lucida Calligraphy)�6B   $��Right=�6b   $	��Top=�6�   $	��149��6�   $��	200,0,0,0q�6�   �� 5F      $��34��6   $��20(�6$   $	��245��62   $��Lucida Calligraphy)�6>   $	��Top=�5G      $
��Left=�6,   $��0,0,0,0q�6h   ��6N   �� *Price+6h   5H      �� 5I      $ 
Horizontal=�6   .+�5J      �� $��
Cantitate:��6   $��36��6-   $��20(�69   $��Lucida Calligraphy)�6G   $��Center=�6g   $	��Top=�6�   $	��120��6�   $��	230,0,0,0q�6�   �� 5K      $��34��6   $��20(�6$   $	��252��62   $��Lucida Calligraphy)�6>   $	��Top=�5L      $
��Left=�6,   ��6N   �� *
Quantity+5M      �� 5N      $ 
Horizontal=�6   .+�5O      �� $��	Alergeni:��6   $��36��6,   $��20(�68   $��Lucida Calligraphy)�6F   $��Center=�6f   $	��Top=�6�   $	��123��6�   $��	230,0,0,0q�6�   �� 5P      $��34��6   $��20(�6$   $	��254��62   $��Lucida Calligraphy)�6>   $	��Top=�5Q      $
��Left=�6,   ��6N   �� *	Allergens+5R      5S      �� 5T   
   $��5��6   $��40��6   $
��Left=�6)   $��10,2,0,5q�6D   #��[ 5U      $��20(�6=   ��6K   �� *BackCommand+.��5V      �� $'��!../Resources/Images/back-icon.png��6   $��82��6?   6L   5W      5X      5Y      