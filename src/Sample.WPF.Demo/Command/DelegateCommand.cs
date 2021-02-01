using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sample.WPF.Demo.Command
{
    public class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// 判断判断命令是否可以被执行
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteFunc != null)
            {
                this.CanExecuteFunc(parameter);
            }
            else
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 执行相关的函数或者命令
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            if (this.ExecuteAction != null)
            {
                this.ExecuteAction(parameter);
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// 声明一个委托用来执行命令对应的方法
        /// </summary>
        public Action<object> ExecuteAction { get; set; }

        /// <summary>
        /// 声明一个方法，用来判断命令是否可以被执行
        /// </summary>
        public Func<object, bool> CanExecuteFunc { get; set; }

    }
}
