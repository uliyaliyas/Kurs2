   M S B A M L   `   `   `  ����@  <Kurs2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kurs2.ValidationKurs2.Validation  5   	   'clr-namespace:Kurs2.View
Kurs2.View  5   	       Kurs2.View.AddAutor   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5
validationclr-namespace:Kurs2.Validation     5   	   *localclr-namespace:Kurs2.View     5   	     � Title$'  !Добавление автора��5	      $	��450��6+   $	��400��68   
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
 true��69   . �5      ��  �@�ToolTip 5      �� #	 Z $)
 #(Validation.Errors)[0].ErrorContent�5      5      �� 5   
   .R�5      ]� .+�5      �� 
���  ��$��1q�6+   ._�5      �� 5      �� 5      
���  ��$��20(�6-   $��!��6;   5       5!      5"      .��5#      �  � ColumnDefinitions 5$   
   �� 5%      $
��0.6* �6   �� 5&       � RowDefinitions 5(   
   �� 5)      �� 5*      �� 5+      �� 5,      �� 5-      .+�5/   
   �� $(��"Введите фио автора��6   $	��5 0q�6/   $��0��6<   $��0��6I   $��Center=�6Y   �� 50   
   -   5         ��Name$	 Fio��50      $
��10 0q�6   $��16(�6-   $��0��6;   $��1��6H   $��Center=�51       =� ErrorTemplate# [ 6-   #��[ 52      .��6>   ��53      �� 54      $	
 Fio�6    �� UpdateSourceTrigger$ PropertyChanged=�6%    �� ValidationRules 55        56      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated$
 True��68     57      $
 True��6.   59      .��5:      5;      �� 5<   
   $,��&Введите почту автора��6   $	��5 0q�60   $��2��6=   $��0��6J   $��Center=�6Z   �� 5=   
   -   5        $ Email��5=      $��16(�6!   $��2��6/   $��1��6<   $
��10 0q�6L   $��Center=�6Z   # [ 5>      #��[ 6M   .��6y   ��5?      �� 5@      $
 Email�6   $ PropertyChanged=�6'    5A        5B      $
 True��68     5C      $
 True��6.   5E      .��5F      5G      �� 5I   
   $��Введите номер��6   $	��5 0q�6)   $��1��66   $��0��6C   $��Center=�6S   �� 5J   
   -   5        $ Phone��5J      $
��10 0q�6!   $��16(�6/   $��1��6=   $��1��5K      $��Center=�5L      # [ 5M      #��[ 6L   .��6x   ��5N      �� 5O      $
 Phone�6   $ PropertyChanged=�6'    5P        5Q      $
 True��69   5S      .��5T      5U      �� 5V   
   $=��7Выберите день рождения автора��6   $��3��69   $��0��6F   $��Center=�6V   $��WrapWithOverflow=�5W      $	��5 0q�64   (  "System.Windows.Controls.DatePicker  5X   
   -   5          Name$ BirthDay��5X      $
��10 0q�6'   $��16(�65   $��3��6C   $��1��6P   $��Center=�5Y         SelectedDate 60   �� *
BirthDay+$ PropertyChanged=� �� ValidatesOnDataErrors$
 True��� 5\   
   $��0��6   $��4��6   $��2��6,    5]      �� 5^      �� 5_      .+�5a      �� -   5        $��Сохранить��5a      $��20,10,20,10q�6)   
�������6S   �� 5b      -   5        $��Отмена��5b      $��20,10,20,10q�6&   $��1��6R   
�������6b   5c      5e      5f      