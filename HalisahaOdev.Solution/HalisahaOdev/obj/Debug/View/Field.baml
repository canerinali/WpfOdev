   M S B A M L   `   `   `  ����G  CHalisahaOdev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HalisahaOdev.ViewHalisahaOdev.View  5          HalisahaOdev.View.Field   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HalisahaOdev.View     5        N� Title$  Field��5	      .��5      � -   5        ���	#FF53E4D7$��	0,0,44,31q�5   7   .+�5   
   �� -   5         ��Name$ btn_add_saha��5      $
��Ekle��6(   $
��Left=�67   $��561,100,0,0q�6R   $	��Top=�6g   $��75��6   $��20��6�   �� 5   
   -   5         ��Name$ txt_sahaName��5      $
��Left=�6)   $��21��6D   $��140,102,0,0q�6P    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��105��6�   �� 5   
   -   5        $ txt_sahaPrice��5      $
��Left=�6)   $��21��6D   $��
277,99,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��105��6�   �� 5   
   -   5        $ txt_sahaLimit��5      $
��Left=�6*   $��21��6E   $��418,102,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��105��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$	 tb1��5      $��0��6       AutoGenerateColumns .  $��Right=�6L   $��
0,142,10,0q�6h   $	��Top=�6|   $	��227��6�   $	��736��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Saha Adı��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6A   �� *
FieldsName+  5      $ Saha Fiyati��6%   $ * 6:   	 6D   �� *FieldsPrice+  5      $ Saha Kapasitesi��6%   $ * 6>   	 6H   �� *FieldsCapacity+  5      $ Saha Aktif Mi ?��6%   $ * 6>   	 6H   �� *
isActive+5      �� 5   
   -   5        $ btn_saha_sil��5      $	��Sil��6'   $
��Left=�65   $��
64,389,0,0q�6P   $	��Top=�6d   $��75��6|   $��20��6�   �� 5   
   -   5        $ btn_saha_pasif��5      $��Aktif - Pasif��6)   $
��Left=�6A   $��653,389,0,0q�6\   $	��Top=�6q   $��75��6�   $��20��6�   �� 5   
   $��	Saha Adı��6   $
��Left=�6#   $��
140,79,0,0q�6>   $	��Top=�6R   $��23��6j   $��76��6v   �� 5   
   $��Saha Fiyatı��6   $
��Left=�6&   $��
277,76,0,0q�6A   $	��Top=�6U   $��23��6m   $��81��6y   �� 5   
   $��Saha Kapasitesi��6   $
��Left=�6*   $��
418,78,0,0q�6E   $	��Top=�6Y   $��23��6q   $	��105��6}   �� 5   
   $��SAHA YÖNETİMİ��6   $
��Left=�6(   $��	19,12,0,0q�6C   $	��Top=�6V   $��36(�6n   $��58��6|   $	��272��6�   5      5       