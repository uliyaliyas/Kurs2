   M S B A M L   `   `   `  ����@  <Kurs2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kurs2.ValidationKurs2.Validation  5   	   'clr-namespace:Kurs2.View
Kurs2.View  5   	       Kurs2.View.AddMagazine   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5
validationclr-namespace:Kurs2.Validation     5   	   *localclr-namespace:Kurs2.View     5   	     � Title$)  #Добавление журнала��5	      $	��350��64   $	��400��6A   
������� � 	Resources 5
      )  #Kurs2.Validation.NameValidationRule   nameValidation/  )Kurs2.Validation.OnlyDigitsValidationRule  onlyDigitsValidation  Kurs2.Validation.NotEmpty  	nameEmpty.  (Kurs2.Validation.SelectionValidationRule  SelectValidate*  $Kurs2.Validation.PhoneValidationRule  phoneValidate  InputControlErrors �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path  ErrorTemplate��%  &	        &	      &	 &     &	 9     &	 L     &	 _     &	 )      5   
   6(     5   
   6.     5   
   6     5   
   6-     5   
   6)   �� 5   
   " ��6+    5      P� 5       �@=�HasError$
 true��69   . �5      ��  �@�ToolTip 5      �� #	 Z $)
 #(Validation.Errors)[0].ErrorContent�5      5      �� 5   
   .R�5      ]� .+�5      �� 
���  ��$��1q�6+   ._�5      �� 5      �� 5      
���  ��$��20(�6-   $��!��6;   5       5!      5"      .��5#      �  � ColumnDefinitions 5$   
   �� 5%      �� 5&       � RowDefinitions 5(   
   �� 5)      �� 5*      �� 5+      .+�5-   
   �� $4��.Введите название журнала��6   $	��5 0q�64   $��0��6A   $��0��6N   $��Center=�6^   �� 5.   
   -   5         ��Name$ Number��5.      $��16(�6"   $��0��60   $��1��6=   $
��10 0q�6M   $��Center=�6[    =� ErrorTemplate# [ 5/   
   #��[ 6E   .��6q   ��50      �� 51      $
 Number�6    �� UpdateSourceTrigger$ PropertyChanged=�6(    �� ValidationRules 52        53      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated$
 True��68     54      $
 True��6.   56      .��57      58      �� 59   
   $.��(Выберите дату выпуска��6   $��1��61   $��0��6>   $��Center=�6N   $��WrapWithOverflow=�5:      $	��5 0q�6,   (  "System.Windows.Controls.DatePicker  5;   
   -   5          Name$ ReleaseDate��5;      $
��10 0q�6*   $��16(�68   $��1��6F   $��1��6S   $��Center=�5<         SelectedDate 6(   �� *ReleaseDate+$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��� 5?   
   $��0��6   $��2��6   $��2��6,    5@      �� 5A      �� 5B      .+�5D      �� -   5        $��Сохранить��5D      $��20,10,20,10q�6)   
�������6S   �� 5E      -   5        $��Отмена��5E      $��20,10,20,10q�6&   $��1��6R   
�������6b   5F      5H      5I      