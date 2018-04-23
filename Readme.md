# How to select different templates when PrintCellStyle is used


<p>To make selection of different templates into View’s PrintCellStyle, create a style based on View’s DefaultPrintCellStyle style. In this style, set MultiBinding, which will collect all necessary information for selection needed DataTemplate. Also, add DataTemplateSelector to this style to select the required template.</p>

<br/>


