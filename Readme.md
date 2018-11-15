<!-- default file list -->
*Files to look at*:

* [Classes.cs](./CS/PrintCellStyleSelector/Classes.cs) (VB: [Classes.vb](./VB/PrintCellStyleSelector/Classes.vb))
* [Dictionary.xaml](./CS/PrintCellStyleSelector/Dictionary.xaml) (VB: [Dictionary.xaml](./VB/PrintCellStyleSelector/Dictionary.xaml))
* **[MainWindow.xaml](./CS/PrintCellStyleSelector/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/PrintCellStyleSelector/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/PrintCellStyleSelector/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/PrintCellStyleSelector/MainWindow.xaml))
<!-- default file list end -->
# How to select different templates when PrintCellStyle is used


<p>To make selection of different templates into View’s PrintCellStyle, create a style based on View’s DefaultPrintCellStyle style. In this style, set MultiBinding, which will collect all necessary information for selection needed DataTemplate. Also, add DataTemplateSelector to this style to select the required template.</p>

<br/>


