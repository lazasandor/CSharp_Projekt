   M S B A M L   `   `   `  ����Q  MWebApi_Client_Workshop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WebApi_Client_WorkshopWebApi_Client_Workshop  5   	   2    ,WebApi_Client_Workshop.ChangeJobStatusWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:WebApi_Client_Workshop     5   	     � Title$  Munka Állapot��5   	   $	��300��6   $	��400��6,    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency$
 True��5   	   .��5      �� -   5         ��Name$ WindowBorder��5      ���#272560 �� CornerRadius$ 15��5      $	��1.5q�5      
�������._�5   
   �  � RowDefinitions 5      �� 5      $��75 �6    �� 5      $
��Auto �6    .+�5      �� $ ��Válasszon egy Állapotot!��6   $��Center=�5      $��Center=�5      
�������$��22(�5      $��20,0,0,0q�5       �� 5!      $��1��6   .+�5"      �� -   5        $��Felvett munka��5"      $��50��5%      
�������$��14(�5'         MenuButtonTheme#��[  5(      �� 5*      -   5        $��Elvégzés alatt��5*      $��50��5-      
�������$��14(�5/      #��[  50      �� 52      -   5        $��Befejezett munka��52      $��50��55      
�������$��14(�57      #��[  58      5;      �� 5<      -   5         ��Name$ 
ExitButton��5<      $��X��5=      $��28��5>      $��
361,0,0,47q�5?      $��36��5@        ControlButtonTheme#��[ 5B      5D      5E      5G      