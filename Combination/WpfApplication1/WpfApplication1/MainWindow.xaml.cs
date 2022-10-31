using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int[]arr=new int[7];
            int[]cou=new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=i;
            }
            List<int> lis = new List<int>();
            lis = Combine(arr, arr.Length, 3, 3, cou, lis);
        }
        private List<int> Combine(int[] arrays, int M, int N, int Oldcount, int[] selectcount, List<int> lis)
        {
            for (int j = M; j >= N; j--)
            {
                selectcount[N - 1] = j - 1;
                if ((N > 1) && (M >= N))
                {
                    lis = Combine(arrays, j - 1, N - 1, Oldcount, selectcount, lis);
                }
                else
                {
                    for (int i = 0; i < Oldcount; i++)
                    {
                        lis.Add(arrays[selectcount[i]]);
                    }
                }
            }
            return lis;
        }
    }
}
