   M S B A M L   `   `   `  ����@  <Kurs2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kurs2.ValidationKurs2.Validation  5   	   'clr-namespace:Kurs2.View
Kurs2.View  5   	       Kurs2.View.AddArticle   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5
validationclr-namespace:Kurs2.Validation     5   	   *localclr-namespace:Kurs2.View     5   	     � Title$'  !Добавление статьи��5	      $	��500��63   $	��400��6@   
������� � 	Resources 5
      )  #Kurs2.Validation.NameValidationRule   nameValidation/  )Kurs2.Validation.OnlyDigitsValidationRule  onlyDigitsValidation  Kurs2.Validation.NotEmpty  	nameEmpty.  (Kurs2.Validation.SelectionValidationRule  SelectValidate  InputControlErrors �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path  ComboBoxControlErrors  ErrorTemplate��%�  &	        &	      &	 &     &	 9     &	 L     &	     &	 �      5   
   6(     5   
   6.     5   
   6     5   
   6-   �� 5   
   " ��6+    5      P� 5       �@=�HasError$
 true��69   . �5      ��  �@�ToolTip 5      �� #	 Z $)
 #(Validation.Errors)[0].ErrorContent�5      5      �� 5   
   " ��6/    5      P� 5       �@=�HasError$
 true��69   . �5      ��  �@�ToolTip 5      �� #	 Z $)
 #(Validation.Errors)[0].ErrorContent�5      5       �� 5#   
   .R�5$      ]� .+�5%      �� 
���  ��$��1q�6+   ._�5&      �� 5'      �� 5(      
���  ��$��20(�6-   $��!��6;   5)      5*      5+      .��5,      �  � ColumnDefinitions 5-   
   �� 5.      �� 5/       � RowDefinitions 51   
   �� 52      �� 53      �� 54      �� 55      �� 56      �� 57      �� 58      �� 59      �� 5:      .+�5<   
   �� $2��,Введите название статьи��6   $	��5 0q�63   $��0��6@   $��0��6M   $��Center=�6]   �� 5=   
   -   5         ��Name$ Number��5=      $��16(�6"   $��0��60   $��1��6=   $
��10 0q�6M   $��Center=�6[    =� ErrorTemplate# [ 5>      #��[ 6<   .��6h   ��5?      �� 5@      $
 Number�6    �� UpdateSourceTrigger$ PropertyChanged=�6(    �� ValidationRules 5A        5B      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated$
 True��68     5C      $
 True��6.   5E      .��5F      5G      �� 5H   
   $7��1Выберите дату сдачи статьи��6   $��1��66   $��0��6C   $��Center=�6S   $��WrapWithOverflow=�5I      $	��5 0q�6%   (  "System.Windows.Controls.DatePicker  5J   
   -   5          Name$ DeliveryDate��5J      $
��10 0q�6+   $��16(�69   $��1��6G   $��1��6T   $��Center=�5K         SelectedDate 6!   �� *DeliveryDate+$ PropertyChanged=� �� ValidatesOnDataErrors$
 True���� 5N   
   $=��7Выберите дату принятия статьи��6   $��2��69   $��0��6F   $��Center=�6V   $��WrapWithOverflow=�5O      $	��5 0q�6%     5P   
   -   5        $ AdoptionDate��5P      $
��10 0q�6+   $��16(�69   $��2��6G   $��1��6T   $��Center=�5Q       6!   �� *AdoptionDate+$ PropertyChanged=�$
 True���� 5T   
   $;��5Выберите дату выпуска статьи��6   $��3��68   $��0��6E   $��Center=�6U   $��WrapWithOverflow=�5U      $	��5 0q�6%     5V   
   -   5        $ PublicationDate��5V      $
��10 0q�6.   $��16(�6<   $��3��6J   $��1��6W   $��Center=�5W       6!   �� *PublicationDate+$ PropertyChanged=�$
 True���� 5Z   
   $2��,Введите размер гонорара��6   $	��5 0q�63   $��4��6@   $��0��6M   $��Center=�6]   �� 5[   
   -   5        $	 Fee��5[      $
��10 0q�6   $��16(�6-   $��4��6;   $��1��5\   
   $��Center=�5]   
   # [ 5^   
   #��[ 5_   
   .��66   ��5`      �� 5a      $	
 Fee�6   $ PropertyChanged=�6%    5b        5c      $
 True��6>   5e      .��5f      5g      �� 5h   
   $#��Выберите автора��6   $��WrapWithOverflow=�6+   $��5��5i      $��0��6   $��Center=�6)   $	��5 0q�6D   �� 5j   
   -   5         ��Name$ AutorId��5j      $
��10 0q�6$   $��16(�62   $��5��6@   $��1��6M   $��Center=�5k       �� DisplayMemberPath$	 Fio��5l       �� SelectedValuePath$ AutorId��5o      # [ 5p      #��[ 5q       �� SelectedValue 5m      �� *	AutorId+��5n      �� *Items+ �� SelectedItem 5r      �� 5s      $
 AutorId�6   $ PropertyChanged=�6)    5t        5u      $
 True��6=   5w      5y      �� 5z   
   $#��Выберите журнал��6   $��WrapWithOverflow=�6+   $��6��5{      $��0��6   $��Center=�6#   $	��5 0q�6>   �� 5|   
   -   5        $ 
MagazineId��5|      $
��10 0q�6'   $��16(�65   $��6��6C   $��1��6P   $��Center=�5}      $ Number��5~   	   $ 
MagazineId��5�   	   # [ 5�   	   #��[ 5�   	    5   	   �� *
MagazineId+��5�   	   �� *Items+ 5�      �� 5�      $
 AutorId�6   $ PropertyChanged=�6)    5�        5�      $
 True��6=   5�      5�      �� 5�   
   $%��Выберите рубрику��6   $��WrapWithOverflow=�6,   $��7��5�      $��0��6   $��Center=�6   $	��5 0q�69   �� 5�   
   -   5        $ RubricId��5�      $
��10 0q�6%   $��16(�63   $��7��6A   $��1��6N   $��Center=�6^   $ 
NameRubric��5�   	   $ RubricId��5�   	   # [ 5�   	   #��[ 5�   	    5�   	   �� *
RubricId+��5�   	   �� *Items+ 5�      �� 5�      $
 RubricId�6   $ PropertyChanged=�6*    5�        5�      $
 True��6=   5�      5�      � 5�   
   $��0��6   $��8��6   $��2��6,    5�      �� 5�      �� 5�      .+�5�      �� -	   5        $��Сохранить��5�      $��20,10,20,10q�6)   
�������6S   �� 5�      -
   5        $��Отмена��5�      $��20,10,20,10q�6&   $��1��6R   
�������6b   5�      5�      5�      