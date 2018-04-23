Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid

Namespace PrintCellStyleSelector
    Public Class Data
        Public Shared Function GetData() As List(Of Customer)
                Dim list As New List(Of Customer)()
                For i As Integer = 0 To 9
                    list.Add(New Customer() With {.ID=i, .FirstName="FirstName" & i, .LastName="LastName" & i, .Birthday = New Date(1980+i,i+1,10+i)})
                Next i
                Return list
        End Function
    End Class

    Public Class Customer
        Public Property ID() As Integer
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property Birthday() As Date
    End Class

    Public Class Converter
        Implements IMultiValueConverter

        Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
            Return values.ToList()

        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Return New Object(){}
        End Function
    End Class

    Public Class TemplateSelector
        Inherits DataTemplateSelector

        Public Property Dictionary() As ResourceDictionary

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim values As List(Of Object) = TryCast(item, List(Of Object))
            Dim n As Integer = 0
            Math.DivRem(Math.Abs(DirectCast(values(0), Integer)),2,n)
            If n>= 1 Then
                Return TryCast(Dictionary("DefaultPrintTextEdit"), DataTemplate)
            Else
                Return TryCast(Dictionary("CustomPrintTextEdit"), DataTemplate)
            End If
        End Function
    End Class
End Namespace
