   M S B A M L   `   `   `  ����E  AReadAllDTC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ReadAllDTC
ReadAllDTC  5         ReadAllDTC.MainWindow   6   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    6"   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6d   @d2http://schemas.microsoft.com/expression/blend/2008     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   *localclr-namespace:ReadAllDTC     6  V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  
ReadAllDTC��5      $	��733��5      $	��643��5         MaterialDesignBody#���   5      $��Regular"�5	      $��13(�5
      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      ]� .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�5      $��16q�5      $	��Top=�5      .��5      ]� .+�5      �� -   5        $��	btnExport��5        MaterialDesignToolButton#���  5       � ToolTip$ Export to Excel��5      $��8 0 0 0q�5      
�������$��Right=�5      .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Download=�5      $��22��5      $��32��5       5!      �� 5"      -   5        $��btnRun��5(      #���  5#      $	 Run��5$      $��8 0 0 0q�5%      
�������$��Right=�5'      .��5*        $
 Send=�5+      $��29��5,      $��22��5-      5.      �� 5/      -   5        $
��Help��52      #��[ 50      $1 +MaterialDesignFloatingActionMiniLightButton��51      .��54        $
 Help=�55      
�������$��24��57      $��24��58      59        5;      $ Standard=�5<      $��8 4 8 4q�5=         CornerRadius$ 2��5>       K� ZIndex$ 1��5?      $��16 0 0 0q�5@      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5A      .��5B      � 	 � ColumnDefinitions	 5C      �� 5D      $
��Auto �5E   	   �� 5F      $��* �5G   	   �� 5H      $
��Auto �5I   	   .+�5K      �� -   5        $��txtTextPath��5S      $��1��5L      $��8 0 0 0q�5M      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$%
 Drag and drop or copy .txt path��5N      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�5O      $��0q�5P      $	��200��5Q      $��Center=�5R       J� 	AllowDrop . 5V      5W      5X      5Y      5Z      � 5[   
   	 5\      �� 5]      $��1* �5^      �� 5_      $��1* �5`      .+�5b      �� $��Input��5c      $��8 16 8 8q�5d      .��5e      �� .��5f      �� -   5        $��txtInput��5i      $
��Wrap=�5g      $��Visible=�5h      5i      5j      5k      �� 5l      $��Output��5m      $��	6,16,10,8q�5n      $��1��5o      .��5p      �� .��5q      �� -   5        $��	txtOutput��5t      $
��Wrap=�5r      $��Visible=�5s      5t      5u      5v      5w      5x      5y      