   M S B A M L   `   `   `  ����B  >WpfApp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp6WpfApp6  5   	       WpfApp6.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp6     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   ]� -   5        $��
dockPanel1��5
      $��Stretch=�6&   $��Stretch=�6B   .+�5      o� $	��Top=�6   $
��Auto��6(   .@�5      m� $��_File��6   .@�5      m� -   5        $��_Exit��5      6.   5      m� 5      $��_Edit��6   .@�5      m� $��_Copy��6    m� Command$
 Copy��6.   m� 5      $
��C_ut��6   $	 Cut��6-   m� 5      $��_Paste��6   $ Paste��6/   5      m� 5      $��_View��6   .@�5      m� -   5        $��menuItemWordWrap��5   G   $��	_Wordwrap��6     m� IsCheckable . 6_   5      5      `� 5      $	��Top=�6   .�5      c� .@�5      �� $��ApplicationCommands.Copy��6   .��5      �� $��Copy.png��6     J� Opacity$ 1Q�62   6@   5      �� 5      -   5         d� 	IsChecked 5      ��  �� Mode$ TwoWay=� �� ElementName$ menuItemWordWrap�� �� Path$ 	IsChecked�.��5      �� $��WordWrap.png��6     J� OpacityMask
 �����6L   5      5       5!      �� 5"      $��Bottom=�6   .@�5#      �� �� 6   ��6'   �� $ textBox��$ Text.Length�	 �� StringFormat$	 N0�� characters6}   5$      �� 5%      -   5        $��textBox��5%   G   
 �� AcceptsReturn
 .  �� 	IsEnabled . $ �� HorizontalScrollBarVisibility$
 Auto=�6V   " �� VerticalScrollBarVisibility$
 Auto=�6{   6�   5&      5(      5)      