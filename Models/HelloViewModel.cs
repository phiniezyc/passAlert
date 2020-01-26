using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaHelloViewModels.Models
{
  class HelloViewModel : INotifyPropertyChanged
  {
    private string _greeting;
    private string _name;
    public event PropertyChangedHandler PropertyChanged;
    protected virtual void onPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

  }
}