   M S B A M L   `   `   `  ����E  AMidProjWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MidProjWPF
MidProjWPF  5   	   #    MidProjWPF.EditPlatformWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MidProjWPF     5   	     � Title$  EditPlatformWindow��5   	   $	��550��6$   $	��700��61   ���#696969.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��50* �6   �� 5      $	��50* �6   .+�5   
   �� $��10q�6   $��0��6!   .+�5      �� -   5         ��Name$ lblAdd��5      $��ADD NEW PLATFORM��6%   $��25(�6A   $	��Top=�6O   $��Center=�6d   $��Center=�6�   �� 5      $��5��6   �� 5      $��20q�6   .+�5      ]� $��5q�6   .+�5      �� -   5        $ 	lblAddOne��5      $��
Platform :��6/   $
��Left=�6D   $	��Top=�6Z   �� 5      -   5         ��Name$ 	txtAddOne��5      5      ]� 5      $��5q�6   .+�5      �� -   5        $ 	lblAddTwo��5      $��Brand :��6/   $
��Left=�6A   $	��Top=�6W   �� 5      -   5        $ 	txtAddTwo��5      5      �� 5      -   5         ��Name$ btnSave��5      $
��SAVE��6*   $��0��69   $��5q�6I   6T   5      �� 5!      $��5��6   �� 5"      -   5        $ lblView��5"      $��EDIT SELECTED PLATFORM��6&   $��25(�6H   $	��Top=�6V   $��Center=�6k   $��Center=�6�   �� 5#      $��5��6   �� 5%      $��20q�6   .+�5&      ]� $��5q�6   .+�5'      �� -   5        $ lblSelectOne��5'      $
��ID :��62   $
��Left=�6A   $	��Top=�6W   �� 5(      -	   5        $ txtSelectOne��5(       �� 
IsReadOnly$
 True��64   5)      ]� 5*      $��5q�6   .+�5+      �� -
   5        $ lblSelectTwo��5+      $��Name :��62   $
��Left=�6C   $	��Top=�6Y   �� 5,      -   5        $ txtSelectTwo��5,      $
 True��64   5-      ]� 5.      $��5q�6   .+�5/      �� -   5        $ lblSelectThree��5/      $��Brand :��64   $
��Left=�6F   $	��Top=�6\   �� 50      -   5        $ txtSelectThree��50      $
 True��66   51      �� 53      -   5        $ 	btnDelete��53      $��DELETE��6,   $��1��6=   $��5q�6M   6X   57      59      �� 5;   
   -   5         ��Name$ lvPlatforms��5;      $��1��6(    �� View 5<      �� 5=      .P�5>      �� $��	Platforms��6%    �� Width$	 350��6l   	 �� DisplayMemberBinding	 68   �� 
 �� Path$
 PlatformName�6l   5?      ��5A      �� 5B       �� 
TargetType" ��6   .�5C      -   5        5D      5F      5G      5H      