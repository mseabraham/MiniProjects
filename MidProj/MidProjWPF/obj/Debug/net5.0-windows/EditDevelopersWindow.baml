   M S B A M L   `   `   `  ����E  AMidProjWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MidProjWPF
MidProjWPF  5   	   %    MidProjWPF.EditDevelopersWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MidProjWPF     5   	     � Title$  EditDevelopersWindow��5   	   $	��450��6&   $	��700��63   ���#696969.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��50* �6   �� 5      $	��50* �6   .+�5   
   �� $��10q�6   $��0��6!   .+�5      �� -   5         ��Name$ lblAdd��5      $��ADD NEW DEVELOPER��6%   $��25(�6B   $	��Top=�6P   $��Center=�6e   $��Center=�6�   �� 5      $��5��6   �� 5      $��20q�6   .+�5      ]� $��5q�6   .+�5      �� $��Developer Name :��6   $
��Left=�67   $	��Top=�6M   �� 5      -   5         ��Name$ 	txtAddOne��5      5      �� 5      -   5         ��Name$ btnSave��5      $
��SAVE��6*   $��0��69   $��5q�6I   6T   5      �� 5      $��5��6   �� 5       -   5        $ lblView��5       $��EDIT SELECTED DEVELOPER��6&   $��25(�6I   $	��Top=�6W   $��Center=�6l   $��Center=�6�   �� 5!      $��5��6   �� 5#      $��20q�6   .+�5$      ]� $��5q�6   .+�5%      �� -   5        $ lblSelectOne��5%      $
��ID :��62   $
��Left=�6A   $	��Top=�6W   �� 5&      -   5        $ txtSelectOne��5&       �� 
IsReadOnly$
 True��64   5'      ]� 5(      $��5q�6   .+�5)      �� -   5        $ lblSelectTwo��5)      $��Name :��62   $
��Left=�6C   $	��Top=�6Y   �� 5*      -   5        $ txtSelectTwo��5*      $
 True��64   5+      �� 5-      -	   5        $ 	btnDelete��5-      $��DELETE��6,   $��1��6=   $��5q�6M   6X   5/      51      �� 53   
   -
   5         ��Name$ lvDevelopers��53      $��1��6)    �� View 54      �� 55      .P�56      �� $��
Developers��6%    �� Width$	 350��6k   	 �� DisplayMemberBinding	 69   �� 
 �� Path$
 CompanyName�6k   57      ��59      �� 5:       �� 
TargetType" ��6   .�5;      -   5        5<      5>      5?      5@      