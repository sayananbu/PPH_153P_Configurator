   M S B A M L   `   `   `  ???? P  LPPH_153P_Configurator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PPH_153P_ConfiguratorPPH_153P_Configurator  &     PPH_153P_Configurator.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2vm#clr-namespace:PPH_153P_Configurator     -   $??MainWindow1??  ? Title$+  %ППХ-153Р Конфигуратор??$	??720??$
??1280?? ? 
ResizeMode$ NoResize=? ? Icon$" /Images/шестерня.png?? ? DataContext &    PPH_153P_Configurator.Controller   ? 	Resources    ScrollBarThumbStyleRed ?? 
TargetType ?? Property ?? Value ?? 
TargetType  ScrollBarThumbStyleYellow  VerticalScrollBarRed	 ? RowDefinitions
 ]? Thumb  VerticalScrollBarYellow  YellowScrollbar  RedScrollbar??%  &	        &	 ?     &	     7   &	 ?    7  &	 |    7  &	 ?    7  ?? " n?.???  ? ?? .  ??  ? |? .  ??  ? ??$ 0q???  ? ?? ?? " n?.R??? 
???  ??$??4??
???   ??? " n?.???  ? ?? .  ??  ? |? .  ??  ? ??$ 0q???  ? ?? ?? " n?.R??? ???	#FFFFEA00$??4??
???   ??? " ??.R?? 	 ?? $??2???? $??* ??? $??2??.+??? ???#000$??80??$??0??]? $??
PART_Track??$??1??
 n? 8??  ?? ???#000$??80??$??2???? " ??.R?? 	 ?? $??2???? $??* ??? $??2??.+??? ???#000$??80??$??0??]? $??
PART_Track??$??1??
 n? 8??  ?? ???#000$??80??$??2???? " ??.???  ? ??8   ?? " ??.???  ? ??8   .??? -    ?Name$ MainGrid?????	#4CC77D39 J? Opacity$ 1Q?|?.  ? ColumnDefinitions ?? ?? $
??1.5* ??? $
??1.5* ??? 	 ?? $
??1.2* ??? $??2* ??? .+??? -    ??Name$ 	Histogram??$
??auto??$
??auto??$??2??$??0??$??0??$??	10 10 5 5q? ?? CornerRadius$ 5??$??1q????	#4CFFFFFF???#000._?? .+??? $
??Left=?$??0 20 0 0q?????  ?? Source$ MainData?? ?? Path$ Value??? $	??Max??$??20(?$??40 0 0 0q??? $??20(?$??	150 0 0 0q????? *MainData.MaxSignalRange+?? $	??Min??$??20(?$??Bottom=?$??40 0 0 0q??? $??20(?$??Bottom=?$??	150 0 0 0q????? *MainData.MinSignalRange+? $
??0 32q?$??40?? ? Orientation$ Vertical=? ? Value ?? *MainData.Value+ ? Minimum ?? *MainData.MinSignalRange+ ? Maximum ?? *MainData.MaxSignalRange+??Z? ??Z? ???? *ColorChange+ ?? Mode$ OneWay=??? -    ??Name$ BottomAZ??$??60??$
??0 30q? ? SmallChange$ 1Q?#??[  ?? *MainData.MinSignalRange+ ?? *MainData.MaxSignalRange+??Z? ??Z?  ?? *MainData.BottomAZ.Value+?? -   $ BottomPS??$??60??$
??0 30q?$ 1Q?#??[ {?.   ?? *MainData.MinSignalRange+ ?? *MainData.MaxSignalRange+??Z? ??Z?  ?? *MainData.BottomPS.Value+?? -   $ TopPS??$??60??$
??0 30q?$ 1Q?#??[ {?.   ?? *MainData.MinSignalRange+ ?? *MainData.MaxSignalRange+??Z? ??Z?  ?? *MainData.TopPS.Value+?? -   $ TopAZ??$??60??$
??0 30q?$ 1Q?#??[ {?.   ?? *MainData.MinSignalRange+ ?? *MainData.MaxSignalRange+??Z? ??Z?  ?? *MainData.TopAZ.Value+?? -   $ 	DebugData??$
??auto??$
??auto??$??3??$??0??$??	10 5 5 10q?$ 5??$??1q????	#4CFFFFFF???#000._?? 	 ?? ?? ??  ?? $
??1.7* ??? .+??? $!??Код вх.сигнала:??$??20(?$??Right=?$??Center=?$??0??$??0???? $??Статус узла:??$??20(?$??Right=?$??Center=?$??1??$??0???? $??Значение:??$??20(?$??Right=?$??Center=?$??2??$??0???? -	    ??Name$ InputSignalCode??$??20(?$??Center=?$??Center=?$??0??$??1?????? *MainData.InputSignalCode+?? -
   $ DeviceStatus??$??20(?$??Center=?$??Center=?$??1??$??1?????? *MainData.DeviceStatus+?? -   $ 
InputValue??$??20(?$??Center=?$??Center=?$??2??$??1?????? *MainData.Value+?? -   $ StatusCodes??$
??auto??$
??auto??$??0??$??1??$??	5 10 5 10q?$ 5??$??1q????	#4CFFFFFF???#000._?? 	 ?? ?? ?? ?? ??  ?? $??3* ??? .+??? $??Исправность:??$??20(?$??Right=?$??Center=?$??0??$??0???? $??Проверка:??$??20(?$??Right=?$??Center=?$??1??$??0???? $??Блокировка:??$??20(?$??Right=?$??Center=?$??2??$??0???? $0??*Выход за нижний предел:??$??20(?$??Right=?$??Center=?$??3??$??0???? $2??,Выход за верхний предел:??$??20(?$??Right=?$??Center=?$??4??$??0???? $??20(?$
??Left=?$??Center=?$??0??$??1?????? *MainData.StateBitArray[7]+?? $??20(?$
??Left=?$??Center=?$??1??$??1?????? *MainData.StateBitArray[6]+?? $??20(?$
??Left=?$??Center=?$??2??$??1?????? *MainData.StateBitArray[5]+?? $??20(?$
??Left=?$??Center=?$??3??$??1?????? *MainData.StateBitArray[2]+?? $??20(?$
??Left=?$??Center=?$??4??$??1?????? *MainData.StateBitArray[1]+?? -   $ GeneralSettings??$
??auto??$
??auto??$??0??$??2??$??	5 10 5 10q?$ 5??$??1q????	#4CFFFFFF???#000._?? 	 ?? ?? ??  ?? $
??1.5* ??? ?? .+??? $??NodeID узла??$??20(?$??Center=?$??Center=?$??0??$??0???? $*??$Диапазон вх.сигнала??$
??Wrap=?$??20(?$??Center=?$??Center=?$??1??$??0???? $??Усреднение??$??20(?$??Center=?$??Center=?$??2??$??0???? -   $??1??$??2??$??0??$??10q?$??20(?$??Center=?$??Center=????? *InputData.NodeId+$ TwoWay=??? -   $??1??$??2??$??2??$??10q?$??20(?$??Center=?$??Center=????? *InputData.Averaging+?? -   $??1??$??1??$??10q?$??Center=?$??Center=?$??20(????? *InputData.MinSignalRange+?? -   $??2??$??1??$??10q?$??Center=?$??Center=?$??20(????? *InputData.MaxSignalRange+?? -   $ SpecialSettings??$
??auto??$
??auto??$??1??$??1??$??2??$??5q?$ 5??$??1q????	#4CFFFFFF???#000._?? 	 ?? ?? ?? ?? ?? .+??? ._??  ?? ?? ?? ?? ?? .+??? $??Уставки??$??20(?$??Center=?$??Center=?$??1???? $??Гистерезис, %??$??20(?$??Center=?$??Center=?$??2???? $??Наличие??$??20(?$??Center=?$??Center=?$??3???? $%??Задатчик уставок??$??20(?$??Center=?$??Center=?$??4??$
??Wrap=??? $??5??$??1??$??1q?$ 5?????#000$
??10 5q?._??  ?? ?? ?? ?? ?? .+??? $??АЗ↑??$??20(?$??Center=?$??Center=?$??0???? -   $??1??$
??15 3q?$??Center=?$??Center=?$??20(????? *InputData.TopAZ.Value+?? $??2??$
??20 3q?
???????$??Center=?$??Center=?$??20(?
???   ? ?? SelectedIndex ?? *InputData.TopAZ.Histeresis+??Z? .@??? $??1%???? $??2%???? $??3%???? $??4%???? $??3??$??Center=?$??Center=?$??Center=?$??Center=?$??0,0,0,0q? d? 	IsChecked ?? *InputData.TopAZ.IsSet+ ? LayoutTransform ??  ?? ScaleX$ 3Q? ?? ScaleY$ 3Q??? $??4??$??Center=?$??Center=?$??Center=?$??Center=?$??0,0,0,0q? ?? *InputData.TopAZ.SettingSetter+ ?? $ 3Q?$ 3Q??? $??5??$??2??$??1q?$ 5?????#000$
??10 5q?._??  ?? ?? ?? ?? ?? .+??? $??ПС↑??$??20(?$??Center=?$??Center=?$??0???? -   $??1??$
??15 3q?$??Center=?$??Center=?$??20(????? *InputData.TopPS.Histeresis+?? $??2??$
??20 3q?
???????$??Center=?$??Center=?$??20(? ?? *InputData.TopPS.Value+.@??? $??1%???? $??2%???? $??3%???? $??4%???? $??3??$??Center=?$??Center=?$??Center=?$??Center=?$??0,0,0,0q? ?? *InputData.TopPS.IsSet+ ?? $ 3Q?$ 3Q??? $??4??$??Center=?$??Center=?$??Center=?$??Center=?$??0,0,0,0q? ?? *InputData.TopPS.SettingSetter+ ?? $ 3Q?$ 3Q??? $??5??$??3??$??1q?$ 5?????#000$
??10 5q?._??  ?? ?? ?? ?? ?? .+??? $??ПС↓??$??20(?$??Center=?$??Center=?$??0???? -   $??1??$
??15 3q?$??Center=?$??Center=?$??20(????? *InputData.BottomPS.Value+?? $??2??$
??20 3q?
???????$??Center=?$??Center=?$??20(? ?? *InputData.BottomPS.Histeresis+.@??? $??1%???? $??2%???? $??3%???? $??4%???? $??3??$??Center=?$??Center=?$??Center=?$??Center=?$??0,0,0,0q? ?? *InputData.BottomPS.IsSet+ ?? $ 3Q?$ 3Q??? $??4??$??Center=?$??Center=?$??Center=?$??Center=?$??0,0,0,0q? ?? *" InputData.BottomPS.SettingSetter+ ?? $ 3Q?$ 3Q??? $??5??$??4??$??1q?$ 5?????#000$
??10 5q?._??  ?? ?? ?? ?? ?? .+??? $??АЗ↓??$??20(?$??Center=?$??Center=?$??0???? -   $??1??$
??15 3q?$??Center=?$??Center=?$??20(????? *InputData.BottomAZ.Value+?? $??2??$
??20 3q?
???????$??Center=?$??Center=?$??20(? ?? *InputData.BottomAZ.Histeresis+.@??? $??1%???? $??2%???? $??3%???? $??4%???? $??3??$??Center=?$??Center=?$??Center=?$??Center=?$??0,0,0,0q? ?? *InputData.BottomAZ.IsSet+ ?? $ 3Q?$ 3Q??? $??4??$??Center=?$??Center=?$??Center=?$??Center=?$??0,0,0,0q? ?? *" InputData.BottomAZ.SettingSetter+ ?? $ 3Q?$ 3Q??? -   $ ChannelChoose??$
??auto??$
??auto??$??0??$??3??$??2??$??5 10 5 5q?$ 5??$??1q????	#4CFFFFFF???#000?? $
??auto??$??50??$??3??$??3??$1??+Загрузить конфигурацию??$	??Top=?$??5 5 5 0q????#fff$??16(??? -    ??Name$ scroll??$??1??$??	0,118,0,0q?$??2??$ 1Q?  ?? TickPlacement$  TopLeft=?! ?? TickFrequency$! 0Q? ?? *MainData.MaxSignalRange+ ?? *InputData.TopAZ.Value+?? $??2??$
??Left=?$??163,-190,0,0q?$
??Wrap=?$??	TextBlock??$	??Top=??? $??1??$
??Left=?$??	57,30,0,0q?$??2??$
??Wrap=?$	??Top=?$??20(?$	??250??$??78?????? *InputData.TopAZ.Value+" ?? StringFormat$" Text {0}???? $??2??$
??Left=?$??
127,81,0,0q?$??2??# ?? TextWrapping$
# Wrap=?$	??Top=?$	??120?????? *InputData.Value+$ TwoWay=?