   M S B A M L   `   `   `  ����G  CHalisahaOdev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HalisahaOdev.ViewHalisahaOdev.View  5      #    HalisahaOdev.View.Rezervasyon   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:HalisahaOdev.View     5        N� Title$  Rezervasyon��5	      .��5      � -   5        ���	#FF53E4D7$��
0,0,48,-16q�5   7   .+�5   
   �� -   5         ��Name$ btn_rezervasyon��5      $��
Rezerve Et��6*   $
��Left=�6?   $��577,104,0,0q�6Z   $	��Top=�6o   $��75��6�    J� RenderTransformOrigin$ 1.257,0.719&�6�   �� 5   
   -   5         ��Name$ tb_rezervasyondescreption��5      $
��Left=�65   $��23��6P   $��
304,54,0,0q�6\    �� TextWrapping$
 Wrap=�6p   $��Rezervasyon Notu��6�   $	��Top=�6�   $	��235��6�   �� 5   
   $��REZERVASYON YÖNETİMİ��6   $��Center=�6/   $
��Left=�6S   $��-55,10,-77,0q�6n   $	��Top=�6�   $	��772��6�   $��20(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��Tbl_Rezarvasyon��5      $��0��6*      AutoGenerateColumns .  $��Right=�6V   $��
0,155,35,0q�6r   $	��Top=�6�   $	��212��6�   $	��705��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6;   �� *RezervasyonID+  5      $ 	Saha Adı��6%   $ * 67   	 6A   �� *
FieldsName+  5      $ Saha Fiyati��6%   $ * 6:   	 6D   �� *FieldsPrice+  5      $ Saha Kapasitesi��6%   $ * 6>   	 6H   �� *FieldsCapacity+  5      $ Rezervasyon Zamanı��6%   $ * 6A   	 6K   �� *
AlinanDate+  5      $# Rezervasyon Çıkış Zamanı��6%   $ * 6G   	 6Q   �� *VerilenDate+5      �� 5   
   -   5        $ 	btn_iptal��5      $��Rezervasyonu İptal Et��6$   $
��Left=�6D   $��382,407,0,0q�6_   $	��Top=�6t   $	��134��6�   6�   �� 5   
   -   5        
 ��Name$
 
cmbx_Field��5      $
��Left=�6'   $��	10,52,0,0q�6B   $	��Top=�6U   $	��120��6m   $ 0.563,3.229&�6�   �� 5   
   -   5        $ tb_fieldsprice��5   $    �� 
IsReadOnly . $
��Left=�6<   $��23��6W   $��
158,55,0,0q�6c   $
 Wrap=�6w   $��Fiyat Çıktısı��6�   $	��Top=�6�   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	RezAlDate��5      $
��Left=�6(   $	��Top=�6C   $��
10,104,0,0q�6[   $	��155��6o      Text$ Alınan Tarih��6{     5   
   -	   5        $ DateVerilen��5      $
��Left=�6*   $	��Top=�6E   $��189,104,0,0q�6]   $	��155��6r   $ Verilen Tarih��6~   �� 5   
   -
   5        $
 cmb_ödendimi��5      $
��Left=�6)   $��
577,55,0,0q�6D   $	��Top=�6X   $	��120��6p   .@�5      �� $��Ödendi��6   �� 5       $��	Ödenmedi��6   5!      �� 5"   
   -   5        $
 cmbx_rezervasyon��5"      $
��Left=�6-   $��234,405,0,0q�6H   $	��Top=�6]   $	��120��6u   $ 0.563,3.229&�6�   5#      5%      