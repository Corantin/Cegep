   M S B A M L   `   `   `  ����K  GAnimation, Version=1.0.5365.37454, Culture=neutral, PublicKeyToken=null%clr-namespace:Animation	Animation  5   	       Animation.Superposition   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   )localclr-namespace:Animation     5   	   -   5        $��window��5   +     � Title$  Superposition��5   	   $	��600��6   $	��800��6,    � 	Resources 5      #   Animation.ArithmeticConverter   	converter��%   &	          5   
   68   5	       � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� TargetProperty$ (Canvas.Left)�6&    �� 
TargetName$
 rect��6P    g� AutoReverse .  g� RepeatBehavior$ Forever��6�    g� Duration$ 0:0:15D�5       		 W� To	 5      �� 
 �� ElementName$
 window�� �� Path$ Width� �� 	Converter# [   �� ConverterParameter$
 -100��5   4   5      5      5      .��5      � $��5q�6    � RowDefinitions 5   
   �� 5      6   �� 5      $
��Auto �6   6,   .+�5   
   �� -   5        $��canvas��5      .+�5      F� -   5        $��pathBackground��5      
���  ��$��1��6:   6Q   �� 5      -   5        $
��rect��5       �� Left$ 10��6$   
 �� Top$	 100��65   
����  �$��75��6R   $��75��6]   5       5!      �� 5#   
   -   5         ��Name$ chkCache��5#       $��2��6   $��Enable Caching��62    d� 	IsChecked$ FalseY�5$      6/   5%      5&      