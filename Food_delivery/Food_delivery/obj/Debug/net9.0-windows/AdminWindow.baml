   M S B A M L   `   `   `  ����  Food_delivery    Food_delivery.AdminWindow   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Адмін Панель��5   	   $	��450��6   $	��600��6+    � WindowStartupLocation$ CenterScreen=�5   	   ���	#FFF8F8F8.��5      � $��10q�6    � RowDefinitions 5   
   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $%��Редагування меню��6   $��20(�6,   $
��Bold"�6:   $��0 0 0 10q�6L   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $��0 0 0 10q�6;   .+�5      �� -   5         ��Name$ DishNameTextBox��5      $	��150��6/   $��0 0 10 0q�6;   $��Назва страви��5      
�������5   2   �� 5      -   5        $ DishPriceTextBox��5      $	��100��60   $��0 0 10 0q�6<   $��Ціна��5      
�������5   2   �� 5      -   5        $��Додати страву��5      $	��120��6C   5      �� 5   
   -   5         ��Name$ AdminMenuListBox��5      $��2��6,   $	��300��69   ��5      �� 5       .R�5!      �� $��14(�66   ��6    �� *Name+66   5"      5$      �� 5'   
   $ 
Horizontal=�6   $��3��6.   $��0 10 0 0q�6;   $��Right=�6M   .+�5(      �� -   5        $%��Видалити вибране��5(      $��0 0 10 0q�6I   �� 5)      -   5        $��
Назад��5)      6%   5*      5+      5,      