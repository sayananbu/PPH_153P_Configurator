   M S B A M L   `   `   `  ????P  LPPH_153P_Configurator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PPH_153P_Configurator.WindowsPPH_153P_Configurator.Windows  5   	   1    +PPH_153P_Configurator.Windows.ChannelChoose   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:PPH_153P_Configurator.Windows     5   	     ? Title$!  Выберите канал??5   	   $	??350??5	   	   $	??300??6    ? WindowStartupLocation$ CenterScreen=?5
   	    ? 	Resources 5         MouseOverBrush ?? 
StartPoint ?? EndPoint ? Color ? Offset ?? 
TargetType ?? Property	 ?? Value
 ?? Triggers P? Property P? Value ?? 	Resources??%E  &	        '?? ?     7   ?? 5   
   $	 0,0&?65   $	 0,1&?6F   ??5      ? ? 5      $ #E4F0FD??6#   $ 0Q?63   ? 5      $ #D7EAFD??6#   $ 1Q?63   5      5      ?? 5   
   " ??6   .?5      ??  ? ??$	 Normal"?6+   
 5      P? 5       ?@J?IsMouseOver . . ?5      ??  ? ??8	   63   5      P? 5       ?@??
IsSelected . . ?5      ??  ? ??
	 ?   ?63   5       5      ???? 5       '??       " ??6   .?5!      ??  ?@??CornerRadius$	 5??65   5"      5#      5$      5%      .??5&      ?  ? RowDefinitions 5(   
   ?? 5)      ?? 5*      $
??2.8* ?6   ?? 5+       ? ColumnDefinitions 5-   
   ?? 5.      ?? 5/      .+?51   
   ?? $??0??52      $??0 0 0 0q?53      $??2??54      $??Название:??55      $??Center=?56      $	??Top=?57      $??18(?58      ?? 5:   
   -   5         ??Name$ config??5:      $??2??5;      $??30??5=       ?? TextAlignment$ Center=?5>      $??18(?5?      $??0??5@      $
??auto??5A      $??Bottom=?5B      $??	10 0 10 5q?5C      ??5<      ?? *
ConfigName+5C      ?? 5E   
   -   5         ??Name$ 
ChanChoose??5E      $
??auto??5F      $
??auto??5G      $??1??5H       ?? CornerRadius$ 5??5I      $??0??5J      $??2??5K      $??1q?5L      ???	#4CFFFFFF???#000$??5q?5O      ._?5Q      ?? -   5         ??Name$ 
ChannelLst??5R       ?? SelectionMode$ Single=?5S      $??18(?5T      5V      5W      ?? 5X   
   -   5        $
??auto??5Y      $
??auto??5Z      $??2??5[      $??5 5 5 5q?5\      ???#fff$??18(?5^       5`      ??%^   '??       ?? 5a      " ??6   .?5b      ??  ?@??CornerRadius$	 5??65   5c      5d      .??5e      ?? $
??Wrap=?5f       ?? TextAlignment$ Center=?5g      $??Подтвердить??5h      5j      ?? 5k   
   $
??auto??5l      $
??auto??5m      $??2??5n      $??1??5o      $??5 5 5 5q?5p      ???#fff$??18(?5r       ?? IsCancel .  5u      ??%^   '??       ?? 5v      " ??6   .?5w      ??  ?@??CornerRadius$	 5??65   5x      5y      .??5z      ?? $
??Wrap=?5{      $ Center=?5|      $??Отмена??5}      5?      5?      5?      