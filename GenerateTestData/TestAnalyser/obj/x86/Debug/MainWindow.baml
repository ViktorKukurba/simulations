   M S B A M L   `   `   `  ����|  xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting  5   L    TestAnalyser   TestAnalyser.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   �chartingToolkit{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit     5   L     � Title$6  0Аналіз процесу тестування��6	   $��601.716��6+   $��985.896��6<   .��5      � $��10,0,-150,-58q�6   $	��531��6"   $��Bottom=�6/    � RowDefinitions 5   
   �� 5      $
��484* �6   �� 5      $	��47* �6    � ColumnDefinitions 5
   
   �� 5      $	��23* �6   �� 5      $
��Auto �6   �� 5      $
��195* �6   �� 5      $��76 �6   �� 5      $
��824* �6   .+�5   
   �� -   5        $��
tabControl��5   =   $	��557��6   $
��Left=�6"   $	��Top=�6O   $	��954��6g   $��
-5,-93,0,0q�6s   $��5��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.139Q�6&   T� 5      5      .@�5      �� -   5        $��testProcess��5   >   $@��:Моделювання процесу тестування��6    � DataContext 6Q   �� .��5      � $��
0,-7,16,19q�6    5      �� 5      $
��255* �6+   �� 5      $
��673* �6+   .+�5       �� -   5        $��	groupBox1��5    v   $'��!Процес тестування��6   $	��208��6:   $
��Left=�6G   $��
188,10,0,0q�6b   $	��Top=�6�   $	��731��6�   $��2��6�   .��5!      &   System.Windows.Controls.DataGrid  -   5        $��processDataGrid��5!   ^   $	��700��6#      AutoGenerateColumns .     
IsReadOnly . $	��100��6u   $	��Top=�6�      	RowHeight$ 30Q�6�   	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 40 6�   
   Columns
 5"      0  *System.Windows.Controls.DataGridTextColumn  5#   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Інтервал��65      Width$
 Auto 6G      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6g   ��  �� Path$ Number�  5$   "   $ К-сть подій��65   $
 Auto 6J    .  6j   �� $ Value�  5%   "   $+ %Загальна к-сть подій��65   $
 Auto 6S    .  6s   �� $ SumValue� � LayoutTransform 5'      V� 5(   "   .~�5)   &   �� $ 90Q�66   u� 5*   &    u� Matrix$ -1,0,0,1,0,0x�66   5+   #      ColumnHeaderStyle 5-      �� 5.   "    �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6(    �� BasedOn# [B 6S   .�5/   &   ��  �� Property �@�LayoutTransform �� Value 50   *   V� 51   .   .~�52   2   �� $	 -90Q�6B   �� 53   2    �� ScaleX$ 1Q�6A    �� ScaleY$ -1Q�6L   54   /   56   '   57   #      	CellStyle 59      �� 5:   "   *  $System.Windows.Controls.DataGridCell"  6)   .�5;   &   ��  �@�LayoutTransform 5<   *   V� 5=   .   .~�5>   2   �� $	 -90Q�6B   �� 5?   2   $ 1Q�6A   $ -1Q�6L   5@   /   5B   '   5C   #   5E      5F      �� 5G      -   5        $��
averagelbl��5G   _   $%��Середнє значення��6   $��28��67   $��77.691,142,352,343q�6C   $��1��6q   �� 5H      -   5        $��displbl��5H   X   $��Дисперсія��6   $��28��60   $��77.691,174,398,311q�6<   $��1��6g   �� 5I      -   5        $��	groupBox2��5I   Z   $	��208��6   $
��Left=�6,   $��	10,10,0,0q�6G   $	��Top=�6k   $	��178��6�   $/��)Параметри поделювання��6�   .��5J      �� -   5         ��Name$ label1_Copy1��5J   T   $��b:��6    $��25��6-   $
��Left=�69   $	��Top=�6j   $��26��6�   $��
81,125,0,0q�6�   5K      �� 5L      -	   5        $��txtInterval��5L   D   $��23��6   $��97,96,89.309,394q�6*   $��1��6W   �� 5M      -
   5        $��label4��5M   V   $��Інтервал��6   $��28��6/   $��10,91,168.309,394q�6;   6V   �� 5N      -   5        $��txtIntensity��5N   B   $��23��6   $��97,39,89.309,0q�6*   $	��Top=�6V   $��10��6n   �� 5O      -   5        $��label1��5O   n   $ ��Інтенсивність��6   $��28��64   $
��Left=�6@   $��	10,37,0,0q�6[   $	��Top=�6|   $��83��6�   �� 5P      -   5        $��distributionsCombo��5P   Z   $��23��6   $
��Left=�6+   $��
25,122,0,0q�6F   $	��Top=�6t   $	��141��6�   �� 5Q      -   5        $��txtDuration��5Q   B   $��23��6   $��97,67,89.309,0q�6*   $	��Top=�6U   $	��120��6m   �� 5R      -   5        $��	BaseLabel��5R   X   $��Тривалість��6   $��28��61   $
��Left=�6=   $	��Top=�6i   $��	10,65,0,0q�6�   �� 5S      -   5        $��simulateTestProcessBtn��5S   >   $��Моделювати��6   $��23��62   $��27,182,88.309,308q�6\   6w   �� 5T      -   5         ��Name$ testModelingSavebtn��5T      $��Зберегти��6:   $
��Left=�6M   $��214,142,0,0q�6h   $	��Top=�6}   $��94��6�   $��23��6�   $��2��6�   �� 5U      -   5        $ testModelingLoadbtn��5U      $��Завантажити��6:   $
��Left=�6P   $��214,175,0,0q�6k   $	��Top=�6�   $��94��6�   $��23��6�   $��2��6�   �� 5V      $
��Auto=�6#   $
��Auto=�6H   $��10,223,10,10q�6k   $��2��6�   .��5W      � $	��649��6   $	��840��6,   .+�5X      � $	��274��6#   $	��837��60   $��1��6<    5Y   "   �� 5Z   &   $
��187* �67   �� 5[   &   $
��650* �67    5]   "   �� 5^   &   $
��270* �64   .+�5`   "   >   8System.Windows.Controls.DataVisualization.Charting.Chart  -   5        $��eventsChart��5`   x   $	��253��68   $
��Left=�6E   $��-10,-165,0,186q�6`      Title$ 
Події��6�   $��Bottom=�6�   $	��400��6�   $��2��6�      LegendStyle 5a   &   �� 5b   *   " ��60   .�5c   .   ��  � ��$ 0��6F   5d   +      Series. 5f   &   F	   @System.Windows.Controls.DataVisualization.Charting.ScatterSeries	  H
   BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries 
  DependentValuePath$ Value1��6D     
  IndependentValuePath$  	TimePoint��6`   ! 
  IsSelectionEnabled! . " 
  ItemsSource" 6�   �� 6�   5g   #     5h   "   -   5        $��empireChart��5h   9   $: 4Емпірична функція розподілу��6L   $	��Top=�6p   $	��253��6�   $��2��6�   $��229,-165,19,0q�6�    5i   &   �� 5j   *   " ��60   .�5k   .   ��  � ��$ 0��6F   5l   +   . 5n   &   C   =System.Windows.Controls.DataVisualization.Charting.LineSeries  $ EmpValue��6A   $  	TimePoint��6_   ! . " 6�   �� 6�   5o   #   5p        5q      -   5        $��poissonChart��5q   5   $/ )Пуассонівський процес��6I   $	��Top=�6g   $	��261��6�   $��
2,313,19,0q�6�    5r   "   �� 5s   &   " ��6,   .�5t   *   ��  � ��$ 0��6B   5u   '   . 5w   "     $ Value��6=   $  	TimePoint��6X   ! . " 6y   �� 6�   5x      5y      5z      �� 5{      -   5        $��txtDistributionB��5{   F   $��23��6   $��130,150,89.309,340q�6*   $��0��6^   �� 5|      -   5        $��txtDistributionA��5|   F   $��23��6   $��58,150,162.309,340q�6*   $��1��6^   �� 5}      -   5        $ label1_Copy��5}   d   $��a:��6   $��23��6)   $
��Left=�65   $��
27,150,0,0q�6P   $	��Top=�6y   $��26��6�   5~      5      �� 5�      -   5        $��analysis��5�   1   $'��!Модель тестування��6   .��5�      � $	��774��6   $	��837��6$   $��	0,0,108,0q�60    5�      �� 5�      $
��193* �6+   �� 5�      $
��644* �6+   .+�5�      �� -   5        $��testModelBox��5�   Y   $	��235��6   $
��Left=�6,   $��5,10,0,0q�6G   $	��Top=�6m   $	��286��6�   $'��!Модель тестування��6�   $��2��6�   .��5�      � $	��774��6   $	��837��6,    5�      �� 5�   "   $
��187* �63   �� 5�   "   $
��650* �63   .+�5�      �� -   5        $��txtAlpha��5�   I   $��23��6&   $��80,35,570,716q�62   $��65��6Y   $��2��6c   �� 5�      $��Alpha��6$   $��10,32,112,710q�64   �� 5�      -   5        $��txtBeta��5�   H   $��23��6&   $��0,69,570,682q�62   $
��0,01��6W   $��Right=�6c   $	��187��6   $��2��6�   �� 5�      $
��Beta��6$   $��28��63   $��10,66,112,680q�6?   �� 5�      -   5        $
��txtS��5�   J   $��23��6&   $��80,103,570,648q�62   $
��0,08��6V   $��2��6b   �� 5�      $��S��6$   $��28��60   $��10,98,112,648q�6<   �� 5�      -   5        $��testModelBtn��5�   %   $��Розв'язати��69   $��28��6N   $��80,182,570,564q�6Z   $��2��6r   6�   �� 5�      $6��0Початкові значення моделі��6$   $
��Left=�6H   $��10,0,0,0q�6c   $	��Top=�6u   �� 5�      -   5        $ testModelStatuslbl��5�   $   $*��$Статус нерозв'язано��6@   $
��Left=�6^   $��
10,135,0,0q�6y   $	��Top=�6�   � 5�      -    5        # �Name$# testModelProgress��5�   *   $
��Left=�6E   $��26��6`   $��135,135,0,0q�6l   $	��Top=�6�   $	��132��6�   $��2��6�   5�      5�      �� 5�      -!   5        $��testModelResultBox��5�   B   $	��235��6   $��119,10,386,0q�6,   $	��Top=�6\   $$��Розв'язок моделі��6t   $��1��6�   .��5�      � $	��774��6   $	��837��6,    5�      �� 5�   "   $
��154* �63   �� 5�   "   $
��683* �63   .+�5�      �� -"   5        $��testModelAlphaResult��5�   J   $��Alpha��6$   $��10,26,10,716q�64   6J   �� 5�      -#   5        $��testModelBetaResult��5�   I   $
��Beta��6$   $��10,64,35,682q�63   6I   �� 5�      -$   5        $��testModelSResult��5�   F   $��S��6$   $��10,98,10,648q�60   6F   �� 5�      -%   5        $��testModelTotalResult��5�   K   $��Total��6$   $��10,129,10,617q�64   6K   5�      5�      �� 5�      -&   5        $��SOPBox��5�   Z   $	��213��6   $
��Left=�6,   $��	5,250,0,0q�6G   $	��Top=�6h   $	��286��6�   $.��(ПСО моделі тестування��6�   $��2��6�   .��5�      � $	��774��6   $��0,0,-654,-583q�6,    5�      �� 5�   "   $
��133* �63   �� 5�   "   $
��331* �63   .+�5�      �� -'   5        $��txtSOPA��5�   ;   $��80,47,0,704q�6&   $��1��6J   �� 5�      $��A��6$   $��10,42,112,700q�60   �� 5�      $8��2Параметри керуючих функцій��6$   $��10,-2,0,744q�6I   �� 5�      -(   5        $��txtSOPB��5�   <   $��0,84,661,667q�6&   $��1��6K   $��Right=�6T   $	��187��6p   $��2��6|   �� 5�      $��B��6$   $��10,82,112,664q�60   �� 5�      -)   5        $��SOPBtn��5�   %   $��Розвя'зати��63   $��80,162,0,584q�6H   6^   �� 5�      -*   5        $ sopStatuslbl��5�   $   $*��$Статус нерозв'язано��6:   $��10,125,53,621q�6X   � 5�      -+   5        $# sopProgress��5�   *   $
��Left=�6?   $��28��6Z   $��134,125,0,0q�6f   $	��Top=�6{   $	��133��6�   $��2��6�   5�      5�      �� 5�      -,   5        $��SOPResultBox��5�   C   $	��213��6   $��119,250,386,0q�6,   $	��Top=�6W   $+��%Розв'язок ПСО моделі��6o   $��1��6�   .��5�      � $	��774��6   $��0,0,-376,-583q�6,    5�      �� 5�   "   $
��187* �63   �� 5�   "   $
��650* �63   .+�5�      �� --   5        $��SOPSlbl��5�   F   $��S��6$   $��10,26,10,716q�60   6F   �� 5�      -.   5        $��SOPTotallbl��5�   V   $��Total��6$   $��28��64   $��10,64,10,682q�6@   6V   5�      5�      � 5�      $��2��6   $��
0,62,-3,62q�6/   .+�5�      � $	��274��6   $��2,188,79,187q�6,    5�      �� 5�   "   $
��187* �63   �� 5�   "   $
��650* �63    5�      �� 5�   "   $
��270* �60   �� 5�   "   $
��270* �60   5�      � 5�      $��499,-42,10,467q�6   .+�5�      �� $ �� Orientation$$ Vertical=�6)   .+�5�   "   � $	��168��6'    5�   &   �� 5�   *   �� 5�   *   $��0* �6;    5�   &   �� 5�   *   $	��67* �68   �� 5�   *   $
��101* �68   .+�5�   &     -/   5        %  Name$% intensityChart��5�   =   $/ )Функція інтенсивності��6U   $��-43,0,-1,-61q�6s   $
��Left=�6�   $	��375��6�   $��2��6�   $ 0.505,0.364&�6�   $��2��6�   z�5�   *   V� 5�   .   .~�5�   2   �� �� 5�   2   �� 5�   2   $ 0.121Q�6B   T� 5�   2   & T� X$& 0.062Q�6E   ' T� Y$' 0.003Q�6O   5�   /    5�   *   �� 5�   .   " ��64   .�5�   2   ��  � ��$ 0��6J   5�   /   . 5�   *     $ EmpValue��6E   $  	TimePoint��6c   ! . $��0,0,0,-1q�6�   " 6�   �� ( 
  DataPointStyle( 5�   .   �� 5�   2   F   @System.Windows.Controls.DataVisualization.Charting.LineDataPoint"  68   .�5�   6   ��  �@J�Opacity$ 0Q�6P   �� 5�   6    � ��
 ��  �6S   5�   3   5�   +   5�   '   5�   #   5�      5�      � 5�      $��499,-42,-78,467q�6   .+�5�      �� $$ Vertical=�6)   $��	0,0,-98,0q�6@   .+�5�   "   � $	��168��6'   $��
0,0,-106,0q�64   .+�5�   &     -0   5        $% intensitySOPChart��5�   =   $6 0Функція інтенсивності ПСО��6X   $��-39,247,298,-304q�6z    5�   *   �� 5�   .   " ��64   .�5�   2   ��  � ��$ 0��6J   5�   /   . 5�   *     $ EmpValue��6E   $  	TimePoint��6c   ! . " 6�   �� ( 5�   *   �� 5�   .   "  64   .�5�   2   ��  �@J�Opacity$ 0Q�6L   �� 5�   2    � ��
 ��  �6O   5�   /   5�   +   5   '   5  #   5     5     5     5     5     5     a� 5  
   $��2��6   $
��Left=�6'   $��23��6B   $��
58,-95,0,0q�6N   $	��Top=�6b   $��84��6z   5	     5
     