using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaHelloViewModels.Models
{
  class HelloViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedHandler PropertyChanged;

    protected virtual void onPropertyChanged([CallerMemberName] string propertyName = null)
    {
      
    }

  }
}