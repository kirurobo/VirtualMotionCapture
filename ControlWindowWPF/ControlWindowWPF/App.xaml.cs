using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace VirtualMotionCaptureControlPanel
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        public static string[] CommandLineArgs { get; private set; }
        private void Application_Startup(object sender, StartupEventArgs e) {
            if (e.Args.Length == 0)
            {
                // 引数省略時は、VMCのデフォルトパイプ名を利用する
                CommandLineArgs = new string[] { "/pipeName", "VMCTest" };
            }
            else
            {
                CommandLineArgs = e.Args;
            }
            LanguageSelector.SetAutoLanguage();
        }
    }
}
