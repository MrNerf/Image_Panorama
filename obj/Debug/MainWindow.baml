   M S B A M L   `   `   `  ����I  EImage_panorama, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Image_panoramaImage_panorama  5   	       Image_panorama.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Image_panorama     5   	     � Title$  Image panorama��5   	   $��600         ��6    $
��1000��5	      .��5      �  � ShowGridLines .  � RowDefinitions 5   
   �� 5      $��80 �6   6+   �� 5      $��25 �6   6*   �� 5      6   �� 5      $��25 �6   6*    � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      6!   �� 5      6!   �� 5      $��70 �6   6,   �� 5      $��70 �6   6,   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $.��(Выберите режим работы��6    $	��Top=�6@   $��Center=�6X   $��16(�6u   �� 5   
   $��0��6   $��10,40,10,10q�6#   $��Center=�68   $	��180��6U   $��30��6a   ��5      �� *
WorkMode+ �� SelectedIndex 64   �� *SelectedWorkMode+�� 5   
   $��1��6   $��Открыть��6!   $��5,5,5,5q�63   $��16(�6D   $��	OpenFiles��5    2   ��6   �� *ClickCommand+{�5!      �� *IsOpenFilesEnabled+ �� Mode$ TwoWay=�6I   �� 5"   
   $��2��6   $��Выполнить��6!   $��5,5,5,5q�65   $��16(�6F   $	��Run��5#   2   ��6   �� *ClickCommand+{�5$      �� *IsRunEnabled+$ TwoWay=�6C   �� 5%   
   $��3��6   $��Шаг назад��6!   $��5,5,5,5q�65   $��16(�6F   $��BackStep��5&   2   ��6   �� *ClickCommand+{�5'      �� *IsBackStepEnabled+$ TwoWay=�6H   �� 5(   
   $��4��6   $��Шаг вперед��6!   $��5,5,5,5q�66   $��16(�6G   $
��Step��5)   2   ��6   �� *ClickCommand+{�5*      �� *IsStepEnabled+$ TwoWay=�6D   �� 5+   
   $��5��6   $��Сохранить��6!   $��5,5,5,5q�65   $��16(�6F   $
��Save��5,   2   ��6   �� *ClickCommand+{�5-      �� *IsSaveEnabled+$ TwoWay=�6D   �� 5.   
   $��6��6   $��Параметры��6!   $��5,5,5,5q�65   $��16(�6F   $��Settings��5/   2   ��6   �� *ClickCommand+50      �� 51   
   $��7��6   $��Информация��6!   $��5,5,5,5q�66   $��16(�6G   $
��Info��52   2   ��6   �� *ClickCommand+53      �� 55   
   -   5        $��image1��55   H   $��1��6   $��2��6    $
��Left=�6-   $��Uniform=�6V   $	��Top=�6h   $��3��6�   �� 56   
   -   5        $��image2��56   H   $��5��6   $��2��6    $
��Left=�6-   $��Uniform=�6V   $	��Top=�6h   $��3��6�   57      58      