   M S B A M L   `   `   `  ????P  LPPH_153P_Configurator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PPH_153P_ConfiguratorPPH_153P_Configurator  5   	   &     PPH_153P_Configurator.AddChannel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:PPH_153P_Configurator     5   	     ? Title$&   Задайте название:??5   	   $	??150??6#   $	??350??60    ? WindowStartupLocation$ CenterScreen=?5	   	    ? WindowStyle$ SingleBorderWindow=?5
   	    ? 
ResizeMode$ NoResize=?5   	    ? ShowInTaskbar .   ? Icon$ /add_icon_129463.png??5   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??0.8* ?6   ?? 5      $	??.4* ?6    ? ColumnDefinitions 5   
   ?? 5      ?? 5      .+?5   
   ?? $??0??5      $??0 10 0 0q?5      $??2??5      $$??Название канала:??5      $??Center=?5      $	??Top=?5      $??18(?5      ?? 5    
   -   5         ??Name$ config??5       $??2??5!      $??30??5#      	 ?? TextAlignment$	 Center=?5$      $??18(?5%      $??0??5&      $
??auto??5'      $??Bottom=?5(      $??5 0 5 10q?5)      ??5"      ?? *
ConfigName+5)      ?? 5+   
   -   5        
 ??Name$
 Submit??5+      $??0??5,      $??3??5-      $??5q?5.       ?? 	IsDefault . $??Сохранить??51      
 ? Tag 50      ?? *Text+ ?? ElementName$ 	InputName??51   !   ?? 54   
   $??1??55      $??3??56      $??5q?57      $??Отмена??58       ?? IsCancel . 59      5;      5<      