   M S B A M L   `   `   `  ����H  DFood_delivery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Food_deliveryFood_delivery  5   	       Food_delivery.MainWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Food_delivery     5   	     � Title$  Food Delivery��5   	   $	��550��6   $	��600��6,    � WindowStartupLocation$ CenterScreen=�5	   	    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Padding	 J� SnapsToDevicePixels��%  '��       �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5   !   #��z��5   !   $ 20��5   !   $ 5q�5   !   $��35��5   !   $	��200��6-   $
	 True��5   !   ._�5      �� $��Center=�6/   $��Center=�5   /   $
��True��5   /   5      5      5      �� 5       � �� �	#FFDDDDDD6+   �� 5        � ��
 �   �6+   �� 5!       � ��$ 35��6'   �� 5"       � ��$	 0 5q�6'   5#      5$      .��5&      � ���#bbffa6.+�5'   
   �� $��30q�6   $��Center=�6!   .+�5)      �� $��Оберіть роль��6   $��20(�5*      $
��Bold"�5+      $��Center=�5,      $��0 0 0 20q�5-      �� 50      $3��-Вхід для адміністратора:��6   $��0 0 0 10q�51      $��SemiBold"�52      �� 54      -   5        
 ��Name$
 AdminEmailBox��54      $��Email��55   
   
�������$	��0 5q�59   
   $��30��6   � 5;      $	��0 5q�6   $��30��6    .+�5<      G� -   5         G�Name$ AdminPasswordBox��5<      $��0q�5=      $��5q�5>      5?      �� 5@      -   5         ��Name$ AdminPasswordPlaceholder��5E      $��Password��5@      
�������$��4,2,1,0q�5B      $	��Top=�5C       J� IsHitTestVisible$ False��5D      $y�Visible=�5F      5G      �� 5I      -   5        $2��,Увійти як Адміністратор��5I      ���#116062
�������5L   	   �� 5O      -   5        $"��Увійти як Гість��5O      ���#469594
�������5R      �� 5T      $
��0 20q�6   �� 5W      $+��%Поля для реєстрації:��6   $��0 0 0 10q�5X      $��SemiBold"�5Y      �� 5[      -   5        $
 EmailBox��5[      $��Email��5\      
�������$	��0 5q�5`      $��30��6#   � 5a      $	��0 5q�6   $��30��6    .+�5b      G� -   5        $ PasswordBox��5b      $��0q�5c      $��5q�5d      5e      �� 5f      -   5        $ PasswordPlaceholder��5k      $��Password��5f      
�������$��4,2,1,0q�5h      $	��Top=�5i      $ False��5j      $y�Visible=�5l      5m      �� 5n      -	   5        $$��Зареєструватись��5n      $��SemiBold"�5p      $
��0 10q�5q      ���#50c878
�������5s      5t      5u      5v      