   M S B A M L   `   `   `  ����H  DFood_delivery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Food_deliveryFood_delivery  5   	       Food_delivery.CartWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Food_delivery     5   	     � Title$/  )Оформлення замовлення��5   	   $	��400��6'   $	��600��64   ���#D4FAD2 � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $/��)Оформлення замовлення��6   $��24(�5      $
��Bold"�5      $��Center=�5      $��0,0,0,20q�5      �� 5   
   $��1��6   $��0,0,0,20q�6"   .+�5      �� $$��Адреса доставки:��6   $��0,0,0,5q�60   �� 5      -   5         ��Name$ AddressTextBox��5      $	��400��5      $��30��5       $��0,0,0,10q�5!      $
��Left=�5"      5#      �� 5&   
   -   5        $��CartItemsList��5&       $��2��6   $��0,0,0,20q�65    �� View 5'      �� 5(      .P�5)      �� $��
Назва��6%    �� Width$	 200��6_    �� DisplayMemberBinding 64   �� *	Item.Name+6_   �� 5*      $��Кількість��6%   $	 100��6b    68   �� *
Quantity+6b   �� 5+      $��Ціна��6%   $	 100��6_    63   �� *
TotalPrice+6_   5,      5.      �� 53   
   $��3��6    �� Orientation$ 
Horizontal=�54      $��Right=�55      $��0,10,0,0q�56      .+�58      �� -   5        $9��3Оформити ще одне замовлення��58      $	��220��59      $��40��5:      $��0,0,10,0q�5;      ���#C8C8C8
���   �5>      �� 5@      -   5        $1��+Підтвердити замовлення��5@      $	��200��5A      $��40��5B      ���#00FF7F5D      5E      5H      5I      