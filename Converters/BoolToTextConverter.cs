using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfPass.Converters { 
    internal class BoolToTextConverter : IValueConverter {  
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {

            if (value != null) {        

                if (value is bool boolvalue) { 

                    if (boolvalue) { 
                    
                        return "Пароли совпадают";
                    }
                    else { 
                    
                        return "Пароли не совпадают";
                    }
                }
            }

            else { 

                return string.Empty;
            }
            
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) { 
      
            throw new NotImplementedException();
        }
    }
}
