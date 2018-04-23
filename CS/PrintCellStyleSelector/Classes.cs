using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using DevExpress.Xpf.Grid;

namespace PrintCellStyleSelector
{
    public class Data
    {
        public static List<Customer> GetData()
        {
                List<Customer> list = new List<Customer>();
                for (int i = 0; i < 10; i++)
                {
                    list.Add(new Customer()
                    {
                       ID=i,
                        FirstName="FirstName"+i,
                        LastName="LastName"+i,
                        Birthday=new DateTime(1980+i,i+1,10+i)
                    });
                }
                return list;
        }
    }

    public class Customer
    {
        public int ID{get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
    }

    public class Converter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return values.ToList<object>(); ;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return new object[0];
        }
    }

    public class TemplateSelector : DataTemplateSelector
    {
        public ResourceDictionary Dictionary { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            List<object> values = item as List<object>;
            int n = 0;
            Math.DivRem(Math.Abs((int) values[0]),2,out n);
            if ( n>= 1)
                return Dictionary["DefaultPrintTextEdit"] as DataTemplate;
            else
                return Dictionary["CustomPrintTextEdit"] as DataTemplate;
        }
    }
}
