   M S B A M L   `   `   `  ����B  >WpfPass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfPass.ViewsWpfPass.Views  5      7 clr-namespace:WpfPass.ConvertersWpfPass.Converters  5      7 clr-namespace:WpfPass.ViewModelsWpfPass.ViewModels  5	          WpfPass.Views.PassWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfPass.Views     5      7
Converters clr-namespace:WpfPass.Converters     5      7
viewModels clr-namespace:WpfPass.ViewModels     5	      _ [MaterialDesignThemes.Wpf, Version=4.4.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$&   Окно ввода пароля��5      $	��300��6!   $	��300��6.    � DataContext 5      ,  &WpfPass.ViewModels.PassWindowViewModel  5   
    � 	Resources 5      -   'WpfPass.Converters.BoolToColorConverter   
ConvertCol,  &WpfPass.Converters.BoolToTextConverter  ConvertText��%:   &	        &	        5   
   6*     5   
   6)   5      .��5      � ���#E4E4E4 � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       �� 5!      $��50 �6   .+�5$   
   �� -   5         ��Name$ Border��5%      $��Center=�5&       �� Padding$ 10q�5'       �� CornerRadius$ 20��5(      $��5q�5)      
������� J� Effect 5,      3  -System.Windows.Media.Effects.DropShadowEffect  5-         
BlurRadius$ 10Q�5.      	   Color$	 	LightGray��5/      
   ShadowDepth$
 0Q�50      51      ._�54      �� $��Добрый день!��55      $��15(�56      $
��Bold"�57      $��Center=�58      59      5:      �� 5<   
   -   5         ��Name$ TextBox1��5=      $��1��5>      $��Stretch=�5?      $��Stretch=�5@      $��5,5,0,5q�5A      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$! Введите пароль��5B         
FontFamily$ Default)�5C       % !MaterialDesignFloatingHintTextBox#��[ 5D      $0��*pack://application:,,,/Resources/#password)�5F      ��5E      �� *AuthInfo.Password+.��5F   E   5G      �� 5J   
   $��2��5K      $��Stretch=�5L      $��Stretch=�5M      $��5q�5N      $) #Подтвердите пароль��5O      $ Default)�5P      #��[ 5Q      $0��*pack://application:,,,/Resources/#password)�5S      ��5R      �� *AuthInfo.NewPassword+.��5S   E   5T      �� 5V   
   $��3��5W      ���#B5B5B5$��Stretch=�5Y      $��Stretch=�5Z      $��10q�5[      $��12(�5^       �� TextAlignment$ Center=�5_      ��5\      �� *AuthInfo.Answer+ �� 	Converter# [ ��5]      �� *AuthInfo.Answer+# [  5`      �� 5b   
   $��4��5c      $��Stretch=�5d      $��Stretch=�5e      $
��10,1q�5f      $!��Сверить пароли��5h        MaterialDesignFlatButton#��[ 5i      ��5g      �� *	CheckPass+5j      5l      5n      