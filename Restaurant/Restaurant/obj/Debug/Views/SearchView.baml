   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Restaurant.ViewsRestaurant.Views  5   	   =#clr-namespace:Restaurant.ViewModelsRestaurant.ViewModels  5   	   !    Restaurant.Views.SearchView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Restaurant.Views     5   	   3ctx#clr-namespace:Restaurant.ViewModels     5   	     � Title$  Cautare��5	   	   $	��600��6   $	��900��6&    � WindowStartupLocation$ CenterScreen=�62   ���#f8edeb � DataContext 5
      +   %Restaurant.ViewModels.SearchViewModel  5   
    � 	Resources 5         RoundedBorder �� 
TargetType �� Property �� Value  RoundedTextBoxStyle �� Triggers P� Property	 P� Value
 �� 
TargetType �� CornerRadius ��Name  RoundedButtonStyle ��Name��%M  &	        &	 T     7   7   &	 �    7   �� 5   
   " ��6&   .�5      ��  �@��CornerRadius$ 5��6-   5      �� 5   
   " ��6,   .�5      ��  � ��$	 500"�6+   �� 5       � ��
 �   �6+   �� 5       � ��$ Lucida Calligraphy)�6+   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 15(�6)   �� 5       � ��$ 5q�6(    5      P� 5       � {�	 . . �5      ��  � �� �#ffb5a763   �� 5       � �� 5      �� 5      "
 ��6.   .R�5   "   �� $ 10,10,10,10��6)   #��z��6D   8��  ._�5    &   �� $ PART_ContentHost��63   5!   #   5"      5$      5%      P� 5'       �@J�	IsFocused	 . . �5(      ��  � �� �#ffb5a763   �� 5)       � �� 5*      �� 5+      "
 ��6.   .R�5,   "   �� #��z��6)   8�� ._�5-   &   �� $ PART_ContentHost��63   5.   #   5/      51      52      54      �� 55   
   " ��6+   .�56      ��  � �� �#f8edeb6+   �� 57       � ��
 �   �6+   �� 58       � �� 59      �� 5:      "
 ��6&   .R�5;      �� $ 10,10,10,10��6!   #��z��6<   8��  ._�5<      �� $ contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6	  5=      5>      5@       5A      P� 5B       �@J�IsMouseOver	 . . �5C      ��  � �� �#f0808063   �� 5D       � ��
 �   �63   5E      P� 5F       � {�	 .  . �5G      ��  � �� �#f9dcc463   �� 5H       � ��
 �   �63   5I      5K      5L      .��5M      �  � RowDefinitions 5N   
   �� 5O      $
��122* �6   �� 5P      $	��92* �6   �� 5Q      $	��50* �6   �� 5R      $
��260* �6   �� 5S      $	��45* �6   .+�5U   
   �� $#��../Resources/Images/logo1.png��6   $
��Left=�67   $��-160,-10,0,0q�6R   $	��619��6h   �� 5V   
   $(��"../Resources/Images/restaurant.png��6   $��Right=�6<   $
��0,10q�6X   $	��198��6f   6t   �� 5W   
   $��0��6   $��Cautare��6   $��Center=�6/   $��Center=�6L   $��Lucida Calligraphy)�6g   $��40(�5X      $��64��6   $��371,26,330,32q�6*   $	��191��6A   �� 5Y   
   $��1��6    �� Orientation$ 
Horizontal=�6"   ���#ffb5a7.+�5Z      �� $��Cauta preparate care:��6   $��Lucida Calligraphy)�64   $��50��6T   $	��226��6`   $��18(�6l   $��Center=�5[      $��Center=�66   $
��0,21q�6Z   �� 5\      $��
10,21,0,21q�6   $��50��6+   $	��169��67   $��Center=�6C   $��Lucida Calligraphy)�5]      ���#f8edeb$��Center=�6L   $��18(�6n    �� SelectedItem 6|   �� *SelectedContainsOrNot+.@�5^      �� $��30��6   $��Contin��6+   $��Lucida Calligraphy)�6<   $��Center=�6\   $��Center=�6�   $��18(�6�   ���#f8edeb6�   �� 5_      $��30��6   $��	Nu contin��6+   $��Lucida Calligraphy)�6?   $��Center=�6_   $��Center=�6�   $��18(�6�   ���#f8edeb6�   5`      �� 5a      $��
10,21,0,21q�6   $��50��6+   $	��174��67   $��Center=�6C   $��Lucida Calligraphy)�5b      ���#f8edeb$��Center=�6L   $��18(�6n    6|   �� *SelectedAllergenProduct+.@�5c      �� $��30��6   $��Produsul��6+   $��Lucida Calligraphy)�6>   $��Center=�6^   $��Center=�6�   $��18(�6�   ���#f8edeb6�   �� 5d      $��30��6   $��	Alergenul��6+   $��Lucida Calligraphy)�6?   $��Center=�6_   $��Center=�6�   $��18(�6�   ���#f8edeb6�   5e      �� 5f      $��
10,21,0,21q�6   $��50��6*   $	��178��66   ���#f8edeb#��[ 6W   ��6�   �� *ContentTextBox+�� 5g      $��
10,21,0,21q�6   $��59��6)   #��[ 64   $
��🔍��6`   $��25(�6m   ��6{   �� *SearchCommand+5h      �� 5i   
   $��2��6   $��	Categorie��6   $��20(�61   $��Lucida Calligraphy)�6?   $��-38,0,673,0q�6_   $��Center=�5j      $��Center=�5k      �� 5l   
   $��2��6   $��Preparat��6   $��20(�60   $��Lucida Calligraphy)�6>   $��
77,0,368,0q�6^   $��Center=�5m      $��Center=�5n      �� 5o   
   $��2��6   $��Cantitate(gr/ml)��6   $��20(�68   $��Lucida Calligraphy)�6F   $��459,0,136,0q�6f   $��Center=�5p      $��Center=�5q      5r      �� 5s   
   $��2��6   $��	Pret(RON)��6   $��20(�61   $��Lucida Calligraphy)�6?   $��663,0,-30,0q�6_   $��Center=�5t      $��Center=�5u      5v      �� 5x   
   $��3��6   $��Stretch=�6    $��Stretch=�6>   ��6Z   �� *ProductsCollection+ 6�   �� *SelectedProduct+��5y      �� 5z      .R�5{      A�  A� Columns$ 1��6"   5|      ��5~      �� 5      .R�5�      �� $ 
Horizontal=�6!   $	��900��6:   $��50��6F   $	��Top=�6R   $��Stretch=�6j   .+�5�      �� $	��100��6    $��50��6,   $��Lucida Calligraphy)�6Y   $��12(�6y   $��Center=�5�      $��Center=�5�      $��30,0,0,0q�62   ��5�   8   �� *CategoryName+5�   2   �� 5�      $	��350��6    $��50��6,   $��Lucida Calligraphy)�6Q   $��12(�6q   $��Center=�5�      $��Center=�5�      ��5�   8   �� *Name+5�      �� 5�      $	��150��6    $��50��6,   $��Lucida Calligraphy)�68   $��15(�6X   $��Center=�5�      $��Center=�5�      $��30,0,0,0q�5�   =   ��6    �� *
Quantity+6=   �� 5�      $��50��6    $��50��6+   $��Lucida Calligraphy)�67   $��15(�6W   $��Center=�5�      $��Center=�5�      $��	100,0,0,0q�5�   :   ��6    �� *Price+6:   5�      5�      5�      �� 5�   
   $��4��6   $��40��6   $
��Left=�6)   $��10,2,0,5q�6D   #��[ 5�      $��20(�6=   ��6K   �� *BackCommand+.��5�      �� $'��!../Resources/Images/back-icon.png��6   $��82��6?   6L   5�      5�      5�      