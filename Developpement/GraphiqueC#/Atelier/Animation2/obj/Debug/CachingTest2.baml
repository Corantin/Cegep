   M S B A M L   `   `   `  ����  	Animation    Animation.CachingTest2   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$  CachingTest2��5      $	��300��6   $	��300��6'    � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   [�5      �� 5      .��5
      �� -   5         ��Name$ 
storyboard��5
   !   .��5      W�  �� 
TargetName$ rotateTransform��6*    �� TargetProperty$ Angle�5      	 W� To$	 360X�5       g� Duration$ 0:0:2D�6    g� RepeatBehavior$ Forever��6   69   W� 5      $ scaleTransform��6*   $ ScaleX�5      	 g� AutoReverse	 . $ 20X�5      $ 0:0:1.8D�6   $ Forever��6   6:   W� 5      $ scaleTransform��6*   $ ScaleY�5      	 . $ 20X�5      $ 0:0:1.8D�6   $ Forever��6   6:   5      5      5      .��5      � 
 � RowDefinitions
 5   
   �� 5      6   �� 5      $
��Auto �6   6,   .+�5!   
   �� .+�5"      �� -   5         ��Name$	 img��5"      $��phone_booth.jpg��6!   $
��None=�6:    J� 	CacheMode-  'System.Windows.Media.CacheModeConverter$ BitmapCache 6I   z�5#      �� 5$      -   5        rotateTransform�� �� CenterX$	 300Q�5$   ?    �� CenterY$	 100Q�6M   6]   5&      �� 5(      -   5         ��Name$	 cmd��5(      $��I GROW and SHRINK.��6"   
 �� Top$ 70��6?    �� Left$ 10��6O    5)      &   System.Windows.Media.BitmapCache  5*         RenderAtScale$ 5Q�6"   66   z�5,      �� 5-      -   5        scaleTransform��5-   ?   5/      50      �� 52   
   -   5         ��Name$ chkCache��52       $��2��6   $��Enable Caching��62    d� 	IsChecked$
 TrueY�53      6.   54      55      