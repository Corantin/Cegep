   M S B A M L   `   `   `  ����  	Animation    Animation.GadgetJourNuit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  GadgetJourNuit��5   	   $	��300��6    $	��300��6-    � Triggers 5      :� 5   
    :� 
SourceName$ cmdStart��6    :� RoutedEvent$ Button.Click��6-   .[�5      �� -   5         ��Name$ fadeStoryboardBegin��5      .��5      �� -   5         g�Name$ fadeStoryboard��5       g� 
SpeedRatio 5      ��  �� ElementName$ sldSpeed�� �� Path$ Value�.��5      W� 	 �� 
TargetName$	 imgDay��5      
 �� TargetProperty$
 Opacity�5       W� From$ 1X�5      	 W� To$ 0X�6    g� Duration$ 0:0:10D�6!   66   5      5      5      :� 5   
   $ cmdPause��6   $ Button.Click��6-   .[�5      ?�  �� BeginStoryboardName$ fadeStoryboardBegin��6   6J   5      :� 5   
   $ 	cmdResume��6   $ Button.Click��6.   .[�5      �� $ fadeStoryboardBegin��6   6K   5      :� 5   
   $ cmdStop��6   $ Button.Click��6,   .[�5      �� $ fadeStoryboardBegin��6   6I   5      :� 5   
   $ 	cmdMiddle��6   $ Button.Click��6.   .[�5      �� $ fadeStoryboardBegin��6    �� Offset$ 0:0:5h�5       6*   5!       � 	Resources 5#       �� 
TargetType �� Property �� Value��%~   '��       �� 5$   
   " ��6   .�5%      ��  � ��$ 5q�6(   64   �� 5&       � ��$ 1q�6'   63   5'      5(      .��5*      �  � RowDefinitions 5+   
   �� 5,      6   �� 5-      $
��Auto �6   6,   �� 5.      $
��Auto �6   6,   �� 5/      $
��Auto �6   6,   �� 50      $
��Auto �6   6,   .+�52   
   � .+�53      �� $��	night.jpg��6   6)   �� 54      -   5        $��imgDay��54   %   $��day.jpg��6   65   55      �� 57   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��5q�6X   .+�58      �� -   5        $��cmdStart��58      .��6%   Jouer6,   �� 59      -   5        $��cmdPause��59      .��6%   Pause6,   �� 5:      -   5        $��	cmdResume��5:      .��6&   	Reprendre61   �� 5;      -   5        $��cmdStop��5;      .��6$   Arrêt6+   �� 5<      -   5        $��	cmdMiddle��5<      .��6&   Milieu6.   5=      �� 5?   
   -	   5        $��lblTime��5?   !   $��2��6   $��Center=�60   [[ arrêté ]]6[   � 5@   
   $��3��6   $��5q�6    � ColumnDefinitions 5A      �� 5B      $
��Auto �6#   62   �� 5C      6%   .+�5E      �� 
Vitesse:6"   �� 5F      -
   5        $��sldSpeed��5F   %   $��1��6    � Minimum$ 0Q�5G       � Maximum$ 3Q�6    � Value$ 1Q�6'    �� TickPlacement$ BottomRight=�61    �� TickFrequency$	 0.1Q�6M   5H   6   5I      � 5J   
   -   5        $��progressBar��5J   A   $��4��6   $��0,5,0,0q�6#   $��10��64   $ 0Q�6T   $ 1Q�6`   6n   5K      5L      