   M S B A M L   `   `   `  ����M  IMusicPlayer, Version=1.0.6035.30504, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MusicPlayer.Views.MainWindowMusicPlayer.Views.MainWindow  5      1    +MusicPlayer.Views.MainWindow.MainWindowView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:MusicPlayer.Views.MainWindow     5      ^ ZCaliburn.Micro.Platform, Version=3.0.1.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5      
���   �.��5      � $��3q�6     � ColumnDefinitions  5   
   �� 5      �� 5      $��4* �6#   �� 5      $
��Auto �6#   �� 5      .+�5   
   � $��
0, 0, 2, 0q�6   .+�5      �� 
����� �$��Placeholder for album art��5      5      � 5    
   $��1��6   $��2,0,2, 0q�6    � RowDefinitions 5!      �� 5"      $��2* �6$   �� 5#      $��2* �6$   �� 5$      $��1* �6$   �� 5%      $��1* �6$   .+�5)      � .+�5*      �� $��
0, 0, 0, 2q�5+      
����� �$��15(�5.      $��Italic$�5/      ��5,      �� *
ArtistName+5/      51      � 52      $��1��6   .+�53      �� $��
0, 0, 0, 2q�54      
��� ���$��20(�57      ��55      �� *
SongName+57      59      � 5<      $��2��6   .+�5=      ��  � Value$ 0Q�5>       � Maximum$	 100Q�5?      5@      � 5C      $��3��6     5E      �� 5F      �� 5G      �� 5H      �� 5I      �� 5J      �� 5K      .+�5N      �� $��
0, 0, 0, 0q�5O      $��
Play/Pause��5P        Caliburn.Micro.Message   Attach$, &[Event Click] = [Action PlaceHolder()]��62   �� 5R      $��
2, 0, 0, 0q�5S      $��1��5T      $
��Stop��5U      $, &[Event Click] = [Action PlaceHolder()]��6,   �� 5W      $��
2, 0, 0, 0q�5X      $��2��5Y      $
��Next��5Z      $, &[Event Click] = [Action PlaceHolder()]��6,   �� 5\      $��
2, 0, 0, 0q�5]      $��3��5^      $��Previous��5_      $, &[Event Click] = [Action PlaceHolder()]��60   �� 5a      $��
2, 0, 0, 0q�5b      $��4��5c      $��	Open File��5d      $, &[Event Click] = [Action PlaceHolder()]��61   �� 5f      $��
2, 0, 0, 0q�5g      $��5��5h      $��Open Folder��5i      $, &[Event Click] = [Action PlaceHolder()]��63   5k      5l      � 5o   
   $��2��6   $��
2, 0, 2, 0q�6   
���P��.+�5p      ��  �� Orientation$ Vertical=�5q      $	 100Q�5r      $	 100Q�5s      5t      � 5w   
   $��3��6    5x      �� 5y      �� 5z      �� 5{      �� 5|      �� 5}      .+�5�      � .+�5�      �� $��2,0,0,0q�5�      $��Timer��5�      
�������5�      5�      � 5�      $��1��6     5�      �� 5�      �� 5�      .+�5�      �� $��
2, 2, 1, 2q�5�      $��Repeat��5�      $, &[Event Click] = [Action PlaceHolder()]��6'   �� 5�      $��1��5�      $��
1, 2, 0, 2q�5�      $��Shuffle��5�      $, &[Event Click] = [Action PlaceHolder()]��6'   5�      � 5�      $��2��6   .+�5�      �� $��
2, 0, 0, 2q�5�      $��Playlist��5�      $, &[Event Click] = [Action PlaceHolder()]��6(   5�      � 5�      $��3��6   .+�5�      �� $��
2, 0, 0, 2q�5�      $��	Equalizer��5�      $, &[Event Click] = [Action PlaceHolder()]��6)   5�      � 5�      $��4��6   .+�5�      �� $��
2, 0, 0, 0q�5�      $��Settings��5�      $, &[Event Click] = [Action PlaceHolder()]��6(   5�      5�      5�      5�      