using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.WPF.Demo.ViewModel
{
    public class NotificationObject : INotifyPropertyChanged
    {
        /// <summary>
        /// 实现接口
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 通知属性的改变
        /// </summary>
        /// <param name="propertyName"></param>
        public void RaisePropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
