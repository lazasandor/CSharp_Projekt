   M S B A M L   `   `   `  ����M  IWebApi_Client_Jobs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WebApi_Client_JobsWebApi_Client_Jobs  5   	   #    WebApi_Client_Jobs.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WebApi_Client_Jobs     5   	   $	��700��5   	   $
��1500��6     � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      �� 5   
    �� RelativeSource 6   ��  �� Mode$
 Self=�.��5      �� -   5         ��Name$ WindowBorder��5      ���#272560 �� CornerRadius$ 15��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��225 �6#   �� 5      	 � RowDefinitions	 5      �� 5      $��75 �6    �� 5      .+�5      �� $��Munkafelvevő Kliens��6   $��Center=�5       $
��Left=�5!      
�������$��22(�5#      $��20,0,0,0q�5$      �� 5&      $��1��6   .+�5(      �� -   5        $��Munka módosítása��5(      $��50��5*      
�������$��14(�5,         MenuButtonTheme#��[  5-      �� 5/      -   5        $��Új munka felvétele��5/      $��50��51      
�������$��14(�53      $��	0,0,0,100q�54      #��[  55      �� 57      -   5        
 ��Name$
 FullName��58      
 � Tag$ Teljes Név��57      $
��Left=�59      $	��Top=�5:      $��
20 20 0 10q�5;        TextBoxTheme#��[ 5<      �� 5>      -   5        $
 CarType��5?      $ Autó típus��5>      $
��Left=�5@      $	��Top=�5A      $��
20 20 0 10q�5B      #��[ 5C      �� 5E      -   5        $
 	RegNumber��5F      $ 	Rendszám��5E      $
��Left=�5G      $	��Top=�5H      $��
20 20 0 10q�5I      #��[ 5J      �� 5L      -   5        $
 TechnicalFailureDesc��5M      $ Rövid hibaleírás��5L      $
��Left=�5N      $	��Top=�5O      $��	20 20 0 0q�5P      #��[ 5Q      �� 5S      -   5         ��Name$ ComboBox��5S      $��20,20,10,20q�5T      $
��Left=�5U      $��Center=�5V      $��Center=�5W      
����ح����	#FF272560$��1q�5Z      $	��195��5[      ��5\      �� 5]       �� 
TargetType" ��6    .�5^      ��  �� Property � �� �� Value �#2725606;   �� 5_       � �� �#2725606<   �� 5`       � ��
 �����6;   5a      .@�5d      �� .��6#   Felvett munka62   �� 5e      .��6#   Elvégzés alatt63   �� 5f      .��6#   Befejezett munka65   5g      5i      �� 5k      $��1��6   $��1��5l      $��10q�5m      .��5o      &   System.Windows.Controls.DataGrid  -	   5          Name$ DataGrid��5o      "   VerticalScrollBarVisibility$ Visible=�5p      $   HorizontalScrollBarVisibility$ Disabled=�5q      $��1��5r         AutoGenerateColumns$ False��5s         RowHeaderWidth$ 0Q�5t      $��0q�5u      $	��Top=�5w         
IsReadOnly$
 True��5x        DataGridTheme#��[ 5z      $	��615��6:   ��5v      �� *jobs+ �� UpdateSourceTrigger$ PropertyChanged=� � 	Resources 5|      ��%�   '��       �� 5}      " ��6    .�5~      ��  � �� �#2527606;   �� 5       � ��$ 0q�68   �� 5�       � ��$ 0q�6@   �� 5�       �@�UseLayoutRounding$
 True��6B   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Id+6P     5�      $ Ügyfél��6-   $	 150 6Z    6=   �� *
Customer+6Z     5�      $ Autó Típus��6-   $	 150 6]    6A   �� *	CarType+6]     5�      $ 	Rendszám��6-   $	 150 6f    6?   �� *LicensePlateNumber+6f     5�      $ Dátum��6-   $	 150 6U    6<   �� *Date+6U     5�      $ Leírás��6-   $	 300 6]    6=   �� *Description+6]     5�      $ Állapot��6-   $	 500 6Y    6>   �� *Status+6Y   5�      5�      �� 5�      -
   5         ��Name$ 
ExitButton��5�      $��1��5�      $��X��5�      $��28��5�      $��1220,10,19,37q�5�      $��36��5�        ControlButtonTheme#��[ 5�       J� RenderTransformOrigin$ 0.528,0.571&�6A   �� 5�      -   5        $ Tray_Button��5�      $��1��5�      $��-��5�      $��28��5�      $��1166,10,60,37q�5�      #��[ 5�      5�      5�      5�      