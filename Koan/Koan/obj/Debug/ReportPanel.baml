   M S B A M L   `   `   `  ����?  ;Koan, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BioSCADABioSCADA  5          BioSCADA.ReportPanel   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:BioSCADA     5      .��5      �   � 	Resources  5	   
    �� DataType �� XPath��%�  (��       5      *Acquisition+)�� 6   $ Acquisition��6   .R�5      �� $��Stretch=�6   .+�5      �� $
��Bold"�6    Id: �� 68   $��Normal"�6^   ��6B   �� $
 ./Id��6^   6v   �� 5      $
��Bold"�6    Timestamp: �� 6>   $��Normal"�6l   ��6I   �� $ ./Timestamp��6l   6�   �� 5      $
��Bold"�6    	Arquivo: �� 6<   $��Normal"�6e   ��6G   �� $ ./File��6e   6}   5      5      5       � RowDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
      BioSCADA.SessionPanel  -   5          Name$ session_panel��5      $��10,150,10,10q�65   $
��Auto��6K   $	��150��6X   $��Bottom=�6e   �� 5   
   -   5         ��Name$ lb_aquisitions��5      $ �� IsSynchronizedWithCurrentItem$
 TrueY�6*      ReportProvider � DataContext# �   6O   $��10,10,0,150q�6�   $	��300��6�   $
��Left=�6�   $��Roboto)�6�   $	��130��6M  $	��Top=�6Z  ��6   �� 6Z  �� 5   
   -   5         ��Name$ lb_filename��5      # �   6)   $
��Bold"�6Y   	 �� TextAlignment$	 Center=�6�   $��	0,10,10,0q�6�   $��Roboto)�6�   $��14(�6�   $	��Top=�6�   $��Right=�6�   $	��240��6	    
Foreground#���  6  $y�Hidden=�6?  $��17��6S  ��6k   �� $ ./File��6S  � 5   
   $
��Left=�6   $��
319,10,0,0q�6*   $	��333��6>   $	��106��6J   $	��Top=�6W   .+�5      �� -   5        
 ��Name$
 	lbl_rmssd��5      $��RMSSD��6'   $��
0,10,75,70q�67   $	��120��6K   $��Right=�6W   �� 5      -   5        $
 lbl_lf��5      $��LF��6$   $
��Left=�61   $��
10,10,0,70q�6L   $	��120��6`   �� 5       -   5        $
 lbl_hf��5       $��HF��6$   $
��Left=�61   $��	10,80,0,0q�6L   $	��120��6_   �� 5!      -   5        $
 lbl_sd1��5!      $	��SD1��6%   $
��Left=�63   $��
10,45,0,35q�6N   $	��120��6b   �� 5"      -   5        $
 lbl_sd2��5"      $	��SD2��6%   $��
0,45,75,35q�63   $��Right=�6G   $	��120��6c   �� 5#      -	   5        $
 lbl_d2��5#      $��D2��6$   $��	0,80,75,0q�61   $��Right=�6D   $	��120��6`   5$      5%      5&      