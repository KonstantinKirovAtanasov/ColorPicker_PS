   M S B A M L   `   `   `  ����H  DCP_Konstantin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CP_KonstantinCP_Konstantin  5   	       CP_Konstantin.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CP_Konstantin     5   	   -   5          � Title$C  =Курсова Работа Константин 40група��5   	    � 
ResizeMode$ NoResize=�63   $	��500��6I   $	��800��6V   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��0.7* �6   6.   �� 5      $
��0.5* �6   6.    � RowDefinitions 5   
   �� 5      $
��0.7* �6   6,   �� 5      $
��0.5* �6   6,   .+�5   
   � $��0��6   $��0��6   .+�5      �� -   5         ��Name$ Colors��5      $
��Fill=�6F   $��0,0,0,0q�6U   ��6$   ��  �� Path$ 	ImagePath�6�   5      � 5   
   -   5        $��0��5      $��1��6   .+�5      �� -   5        $��
RedSlLabel��5      $��Red:  ��6&   $��
5,5,0.4,95q�67   6M   �� 5      -   5        $��	RedSlider��5       � Minimum$ 0Q�6o    � Maximum$	 255Q�6{   $��100,5,0.4,95q�6�    � Value 6'   �� $( "BindingInfo.MouseOverColor.Color.R�	 �� Mode$	 TwoWay=�6�   �� 5      -   5        $��GreenSlLabel��5      $��Green:��6(   $��5,35,0.4,65q�69   6P   �� 5      -   5        $��GreenSlider��5      $ 0Q�6o   $	 255Q�6{   $��100,35,0.4,65q�6�    6(   �� $( "BindingInfo.MouseOverColor.Color.G�$	 TwoWay=�6�   �� 5      -   5        $��BlueSlLabel��5      $��Blue: ��6'   $��5,65,0.4,35q�68   6O   �� 5      -	   5        $��
BlueSlider��5      $ 0Q�6n   $	 255Q�6z   $��100,65,0.4,35q�6�    6'   �� $( "BindingInfo.MouseOverColor.Color.B�$	 TwoWay=�6�   �� 5      -
   5        $��AlphaSlLabel��5      $��Alpha:��6(   $��
5,95,0.4,5q�69   6O   �� 5      -   5        $��AlphaSlider��5      $ 0Q�6o   $	 255Q�6{   $��100,95,0.4,5q�6�    6(   �� $( "BindingInfo.MouseOverColor.Color.A�$	 TwoWay=�6�   �� 5      -   5        $��OverAll��5      $��5,125,210.2,35q�6L   ��6#   �� $ BindingInfo.RGB�6f   �� 5      -   5        $��HexCode��5      $��5,160,210.2,5q�6L   ��6#   �� $ BindingInfo.HEX�6e   �� 5       -   5        $��CurrentMouseOver��5       $��375,136,5,10q�6a   ��60   �� $  BindingInfo.MouseOverColor�6z   �� 5!      -   5        $��CurrentSelected��5!      $��250,136,125,10q�6_   ��6/   �� $ BindingInfo.SelectedColor�6z   5"      � 5#   
   $��1��6   $��1��6   .+�5$      �� $��Brightness:��6   $��10,10,249.4,156q�6*   6E   �� 5%      -   5        $��
Brightness��5%      $ 0Q�6'   $	 -50Q�61   $	 +50Q�6?   $��10,40,10.4,132q�6M   
 J� RenderTransformOrigin$
 
0.528,0.64&�6e   6�   �� 5&      $��Lumia:��6   $��10,64,249.4,102q�6%   6@   �� 5'      -   5        $��Lumia��5'      $ 0Q�6"   $	 -50Q�6,   $	 +50Q�6:   $��10,94,10.4,78q�6H   $
 0.5,0.5&�6�   6�   �� 5(      -   5         ��Name$ GetColorReport��5(      $��Get Color Report (Copy)��6-   $
��Left=�6O   $��
10,159,0,0q�6j   $	��Top=�6~   $	��310��6�   $��21��6�   ���	#FFB4DCFA$
��Bold"�6�   $��Italic$�6�   6�   �� 5)      -   5        $ RandomColor��5)      $��Get Random Color��6*   $
��Left=�6E   $��
10,133,0,0q�6`   $	��Top=�6t   $	��310��6�   $��21��6�   ���	#FFB4DCFA$
��Bold"�6�   $��Italic$�6�   6�   5*      � 5+   
   $��1��6   $��0��6   .+�5,      �� $�� Color Information��6   $��10,10,10,10q�64   6K   �� 5-       J� IsManipulationEnabled .  $	��222��65   $��20,35,20,20q�6B    �� TextWrapping$
 Wrap=�6W   $	��Top=�6�   $	��288��6�   ��6k   �� $ BindingInfo.ColorReport�6�   5.      5/      50      