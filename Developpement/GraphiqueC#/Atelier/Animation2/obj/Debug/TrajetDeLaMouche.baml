   M S B A M L   `   `   `  ����  	Animation     Animation.TrajetDeLaMouche   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  TrajetDeLaMouche��5   	   $��381.6��6"   $��521.6��61    � 	Resources 5         path E� IsClosed �� Point �� Size �� SweepDirection��%�   &	        B� 5   
   .��5      E�  . .��5      �� $ 100,200&�6   $ 15,10��6-   $ 	Clockwise=�6:   6W   �� 5	      $ 400,50&�6   $	 5,5��6,   6:   5
      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   [�5      �� 5      .��5      �� .��5      T�  �� 
TargetName$ image��63   	 �� TargetProperty$	 (Canvas.Left)�5   '   
 T� PathGeometry#
 [  5   &    g� Duration$ 0:0:5D�5   '    g� RepeatBehavior$ Forever��68    T� Source$ X=�6Q   T� 5      $ image��63   $	 (Canvas.Top)�5   '   #
 [  5   &   $ 0:0:5D�5   '   $ Forever��68   $ Y=�6Q   5      5      5      .��5      �� $��10q�6   .+�5    
   F� 
���  ��$��1��6   #��[  60   
 �� Top$ 10��6M    �� Left$ 10��6]   5!      �� 5"   
   -   5        $��image��5"      ��5#      H� 5$       H� Drawing 5%      � 5&       � Brush
 ��İ� � Geometry 5'      � 5(   "   .��5)   &   @�  @� Center$ 10,10&�66    @� RadiusX$ 9Q�6E    @� RadiusY$ 4Q�6Q   @� 5*   &   $ 10,10&�66   $ 4Q�6E   $ 9Q�6Q   5+   #   
 � Pen 5-      >� 5.   "    >� 	Thickness$ 1Q�6&    >� Brush
 �   �64   50      52      54      55      56      