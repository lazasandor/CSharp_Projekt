   M S B A M L   `   `   `  ����Q  MWebApi_Client_Workshop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WebApi_Client_WorkshopWebApi_Client_Workshop  5   	   '    !WebApi_Client_Workshop.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:WebApi_Client_Workshop     5   	     � Title$  Műhely Kliens��5   	   $	��700��5	   	   $
��1280��6    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      �� 5   
    �� RelativeSource 6   ��  �� Mode$
 Self=�.��5      �� -   5         ��Name$ WindowBorder��5      ���#272560 �� CornerRadius$ 15��5      ._�5   
   � 	 � RowDefinitions	 5      �� 5      $��75 �6    �� 5      $
��Auto �6    .+�5      �� $A��;Műhely Kliens | Kattintson egy munkára a módosításhoz!��6   $��Center=�5      $
��Left=�5      
�������$��22(�5       $��20,0,0,0q�5!      &   System.Windows.Controls.DataGrid  5%      -   5        
  Name$
 WorkShop_DataGrid��5%      "   VerticalScrollBarVisibility$ Visible=�5&      $   HorizontalScrollBarVisibility$ Disabled=�5'      $��1��5(         AutoGenerateColumns$ False��5)         RowHeaderWidth$ 0Q�5*      $��0q�5+      $	��Top=�5-         
IsReadOnly$
 True��5.         DataGridTheme#��[  50      $	��615��6:   ��5,      �� *jobs+ �� UpdateSourceTrigger$ PropertyChanged=� � 	Resources 52       �� 
TargetType �� Property �� Value��%�   '��       �� 53      " ��6   .�54      ��  � �� �#25276067   �� 55       � ��$ 0q�64   �� 56       � ��$ 0q�6<   �� 57       �@�UseLayoutRounding$
 True��6>   59      5;         Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5>      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     5?      $ Ügyfél��6)   $	 150 6V    69   �� *
Customer+6V     5@      $ Autó Típus��6)   $	 150 6Y    6=   �� *	CarType+6Y     5A      $ 	Rendszám��6)   $	 150 6b    6;   �� *LicensePlateNumber+6b     5B      $ Dátum��6)   $	 150 6Q    68   �� *Date+6Q     5C      $ Leírás��6)   $	 300 6Y    69   �� *Description+6Y     5D      $ Állapot��6)   $	 500 6U    6:   �� *Status+6U   5J      �� 5L      -   5         ��Name$ 
ExitButton��5L      $��X��5M      $��28��5N      $��1234,10,10,37q�5O      $��36��5P        ControlButtonTheme#��[ 5R      �� 5T      -   5        $ Tray_Button��5T      $��-��5U      $��28��5V      $��1188,10,51,37q�5W      #��[ 5Y      5Z      5[      5\      