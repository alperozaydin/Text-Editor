   M S B A M L   `   `   `  ����E  ATextEditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:TextEditor
TextEditor  5   	       TextEditor.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   *localclr-namespace:TextEditor     5   	     � Title$  Text Editor��5   	   $	��600��6   $	��800��6*    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.New��5      5        5	   
   -   5        $ ApplicationCommands.Open��5	      5
        5   
   -   5        $ ApplicationCommands.Save��5      5        5   
   -   5        $  ApplicationCommands.SaveAs��5      5        5   
   -   5        $ ApplicationCommands.Close��5      5        5   
   -   5        $ ApplicationCommands.Print��5      5        5   
   -   5        $&  ApplicationCommands.PrintPreview��5      5       J� InputBindings 5      d� 5   
    d� Gesture$ Control+WheelClicka�6    �� Command$  ApplicationCommands.SaveAs��5      .��5      ]� .+�5   
      TextEditor.TextEditorMenu  -   5          Name$
 menu��5      $	��Top=�5      "   TextEditor.TextEditorToolbar  5   
   -	   5          Name$ toolbar��5   "   $	��Top=�5    "   5!   "   �� 5#   
   $��Bottom=�6   .@�5$      �� -
   5         ��Name$ status��5$      5%      �� 5'   
   -   5        	 ��Name$
	 body��5'      
 �� 	IsEnabled
 .  �� AcceptsReturn .  �� 
AcceptsTab . $��0 2 0 0q�5,      5-      5.      