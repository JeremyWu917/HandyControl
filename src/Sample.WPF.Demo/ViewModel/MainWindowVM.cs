using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.WPF.Demo.Command;

namespace Sample.WPF.Demo.ViewModel
{
    public class MainWindowVM : NotificationObject
    {

        public MainWindowVM()
        {
            P1 = "123";
            P2 = "123";

            // 关联查询命令
            DoCommand = new DelegateCommand
            {
                ExecuteAction = new Action<object>(Do)
            };
        }


        public DelegateCommand DoCommand { get; set; }
        private void Do(object parameter)
        {
            P2 = P1;
        }

        private string _P1;

        public string P1
        {
            get { return _P1; }
            set
            {
                _P1 = value;
                RaisePropertyChanged(nameof(P1));
            }
        }

        private string _P2;

        public string P2
        {
            get { return _P2; }
            set
            {
                _P2 = value;
                RaisePropertyChanged(nameof(P2));
            }
        }


    }
}
