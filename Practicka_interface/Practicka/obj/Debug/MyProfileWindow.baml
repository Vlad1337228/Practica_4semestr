   M S B A M L   `   `   `  ����D  @Practicka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Practicka	Practicka  5   	       Practicka.MyProfileWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Practicka     5   	     � Title$  MyProfileWindow��5   	   $	��450��6!   $	��600��6.   ��5	      �� 5
   
   .��5      � ��5   
   �� 5       �� ImageSource$ backgroundProfile.png��6    j� Stretch$ UniformToFill=�6=   .+�5   
   �� -   5         ��Name$ 	labelLogo��5      $��Мой профиль��6#   $��192,15,192,0q�69   $	��Top=�6O   $��Verdana)�6g   $��24(�6|   
���������5      �� 5       �� Color$ Transparent��6"    �� Opacity$ 0Q�66   5      �� 5   
   -   5        $ 	labelName��5      $��Имя��6#   $��111,93,415,0q�61   $	��Top=�6G   $��Verdana)�6_   $��24(�6t   
���������5      �� 5      $ Transparent��6"   $ 0Q�66   5      �� 5   
   -   5        $ 
labelEmail��5      $��Эл.Почта��6$   $��111,139,350,0q�67   $	��Top=�6N   $��Verdana)�6f   $��24(�6{   
���������5      �� 5      $ Transparent��6"   $ 0Q�66   5      �� 5   
   -   5        $ labelvoucher��5      $��Мои путевки��6&   $��111,182,298,0q�6<   $	��Top=�6S   $��Verdana)�6k   $��24(�6�   
���������5       �� 5!      $ Transparent��6"   $ 0Q�66   5#      �� 5$   
   -   5        $�� ��5$      $
��Left=�6   $��6,6,0,0q�67   $	��Top=�6H   $��36��6`   $��30��6k   ��5%      �� 5&      $ 	arrow.png��6   ��5(      �� 5)      $ 	arrow.png��6   5+      �� 5,   
   -   5         ��Name$ listVoucher��5,      $	��189��6'   $��98,221,98,0q�64   $	��Top=�6I   $��1,1,1,1q�6a   $��Verdana)�6{   $��18(�6�   
���������5-      �� 5.      $ White��6"   $	 0.1Q�60   50      �� 51   
   -   5        $ labelNameUser��51      $�� ��6'   $��284,93,125,0q�62   $	��Top=�6H   $��Verdana)�6`   $��24(�6u   
�������
�������$��0,0,0,1q�6�   ��52      �� 53      $ Transparent��6"   $ 0Q�66   55      �� 56   
   -   5        $ labelEmailUser��56      $�� ��6(   $��284,139,125,0q�63   $	��Top=�6J   $��Verdana)�6b   $��24(�6w   
�������
�������$��0,0,0,1q�6�   ��57      �� 58      $ Transparent��6"   $ 0Q�66   5:      �� 5;   
   -	   5         ��Name$ updateVoucher��5;      $#��Удалить путевку��6(   $
��Left=�6B   $��376,196,0,0q�6]   $	��Top=�6r   $	��118��6�   $��Verdana)�6�   
���������5<      �� 5=      $ 	#FF35FF08��6"   ��5?      �� 5@      $ 	#FF3D493A��6"   $ 0Q�64   5B      5D      5E      