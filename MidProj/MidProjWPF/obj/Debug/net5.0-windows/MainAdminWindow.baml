   M S B A M L   `   `   `  ����E  AMidProjWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MidProjWPF
MidProjWPF  5   	        MidProjWPF.MainAdminWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MidProjWPF     5   	     � Title$  MainAdminWindow��5   	   $	��450��6!   $
��1000��6.   ���#696969.��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��10* �6   �� 5      $	��25* �6   .+�5   
   � -   5         �Name$ gameGrid��5      $��0��6!   $��Center=�62   $	��410��6O   $��0,10,0,0q�6\   $	��Top=�6n   $y�Hidden=�6�    � RowDefinitions 5      �� 5      $
��100* �6    �� 5      $	��40* �6    �� 5      $	��40* �6    �� 5      $	��40* �6    �� 5      $	��40* �6    �� 5      $
��100* �6    .+�5      �� 
���   �._�5      �� 
�����w�$��5q�6:   .+�5      �� -   5         ��Name$ viewGameTitle��5       �� TextWrapping$
 Wrap=�65   $��18(�6I   $��DemiBold"�6W   
��� ���$��Center=�6�   $��Center=�6�    �� 
IsReadOnly$
 True��6�   5      5      ]� 5      $��1��6   .+�5       �� $��Release Date: ��6   $
��Left=�61   $��Center=�6G   6d   (  "System.Windows.Controls.DatePicker  5!      -   5          Name$ editDate��5!      $��Center=�6/   $|�False��6J   5"      ]� 5$      $��2��6   .+�5%      �� $��Developer(s): ��6   $
��Left=�61   $��Center=�6G   6d   �� 5&      $��PLACEMAT��6   
����  �$��Center=�6>   $
��Wrap=�6Y   5'      ]� 5)      $��3��6   .+�5*      �� $��Platform(s): ��6   $
��Left=�60   $��Center=�6F   6c   �� 5+      $��PLACEMAT��6   $��Center=�6,   $
��Wrap=�6G   5,      ]� 5.      $��4��6   .+�5/      �� $��Platform Rating: ��6   $
��Left=�64   $��Center=�6J   6g   �� 50      -   5         ��Name$ imgStar��50      $$��\Images\Star_rating_0_of_5.png��6)   $
��Left=�6Q   $	��150��6g   �� 51      -   5        	 ��Name$	 tbRating��51      $��0��6.   $��Center=�67   $
��Wrap=�6R   $��Right=�6f   $	��5,0q�6}   52      �� 54      $��5��6   .+�55      �� -   5        
 ��Name$
 btnEditGame��55      $��Edit Game Details��6.   $
��Left=�6J   $��5q�6a   6l   �� 56      -   5         ��Name$ inEdit��56      $y�Hidden=�6-   .+�57      ]� .+�58      �� -   5        $
 btnSaveEdit��58   !   $��	Save Edit��66   $
��Left=�6K   $��5q�6g   6r   �� 59      -	   5        $
 btnDeleteGame��59   !   $��Delete Game��68   $��Right=�6N   $��5q�6j   6u   5:      �� 5;      -
   5        $
 btnCancelEdit��5;      $��Cancel Edit��64   $
��Left=�6J   $��5q�6a   6m   5<      5=      5?      � 5C   
   $��1��6   $��Center=�6   $	��410��6<   $��0,10,0,0q�6I   $	��Top=�6[   $	��700��6s    5D      �� 5E      $	��10* �6    �� 5F      $��5* �6    �� 5G      $	��30* �6    .+�5J      ]� $��5q�6   $
��True��6#   .+�5L      �� $��GAME SELECTION��6   $��25(�62   $	��Top=�6@   $��Center=�6U   $��Center=�6r   �� 5M      $��5��6   $	��Top=�6'   �� 5N      $��Filter By: ��6   $
��Left=�6.   $	��Top=�6D   �� 5O      $��20��6   $��Right=�6(   $	��Top=�6?   $��0,5,0,0q�6W   5P      ]� 5R      $��1��6   .+�5S      �� -   5        $
 
btnAddGame��5S      $��Add New Game��6-   $
��Left=�6D   $��5q�6Z   6e   �� 5T      -   5        $
 btnAddDeveloper��5T      $��Edit Developers��62   $
��Left=�6L   $��5q�6c   6n   �� 5U      -   5        $
 btnAddPlatform��5U      $��Edit Platforms��61   $
��Left=�6J   $��5q�6`   6k   �� 5V      -   5        $
 btnAddAdmin��5V      $��Add New Admin��6.   $
��Left=�6F   $��5q�6\   �� 5W      -   5        $
 btnEditUser��5W      $��Edit User Details��6.   $
��Left=�6J   $��5q�6`   5X      ]� 5Z      $��5q�6   $
��True��6#   $��2��68   .+�5\      �� -   5         ��Name$ lvGameSelection��5\      $��5q�64   $
��Left=�6?    �� View 5]      �� 5_      .P�5`      �� $��
Game Title��6-    �� Width$	 220��6A    �� DisplayMemberBinding 6M   ��  �� Path$ 	GameTitle��� 5a      $��Release Date��6-   $ 80��6C    6N   �� $ ReleaseDate� �� StringFormat$ dd MMM yyyy���� 5b      $��Rating��6-   $ 75��6=    6H   �� $ Rating�5c      ��5e      �� 5f       �� 
TargetType" ��6    .�5g      -   5        5h      5j      �� 5m      -   5        $ lvReviewSelection��5m      $��2��66   $��5q�6C    5n      �� 5p      .P�5q      �� $��Review Title��6-   $	 210��6C    6O   �� $ 	GameTitle��� 5r      $��Rating��6-   $ 75��6=    6H   �� $ Rating�5s      5u      5v      5w      5x      5y      