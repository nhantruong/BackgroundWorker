using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorker
{
    public partial class BackgroundWorker : Form
    {
        public BackgroundWorker()
        {
            InitializeComponent();
            //Việc 1
            bgw_delay5.WorkerReportsProgress = true;
            bgw_delay5.WorkerSupportsCancellation = true;
            //Việc 2
            bgw_delay10.WorkerReportsProgress = true;
            bgw_delay10.WorkerSupportsCancellation = true;
        }
        #region thread1

        private void startAsyncButton_Click(object sender, EventArgs e)
        {
            if (bgw_delay5.IsBusy != true) bgw_delay5.RunWorkerAsync();            
        }

        private void cancelAsyncButton_Click(object sender, EventArgs e)
        {
            if (bgw_delay5.WorkerSupportsCancellation) bgw_delay5.CancelAsync();            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {           
            for (int i = 1; i < 10; i++)
            {
                if (bgw_delay5.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                    bgw_delay5.ReportProgress(i * 10);
                }
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLable1.Text = "Tiến trình 1: " + e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                resultLable1.Text = "Hủy";
            }
            else if (e.Error != null)
            {
                resultLable1.Text = "Có lỗi do: " + e.Error.Message;
            }
            else
            {
                resultLable1.Text = "Hoàn tất";
            }
        }

        #endregion

        #region Thread2

        private void startAsyncButton2_Click(object sender, EventArgs e)
        {
            if (bgw_delay10.IsBusy != true) bgw_delay10.RunWorkerAsync();
            
        }

        private void bgw_delay10_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (bgw_delay10.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(100);
                    bgw_delay10.ReportProgress(i);
                }
            }
        }

        private void bgw_delay10_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLable2.Text = "Tiến trình 2: " + e.ProgressPercentage.ToString() + "%";
        }

        private void bgw_delay10_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                resultLable2.Text = "Bạn đã Hủy";
            }
            else if (e.Error != null)
            {
                resultLable2.Text = "Có lỗi do: " + e.Error.Message;
            }
            else
            {
                resultLable2.Text = "Hoàn tất";
            }
        }
        #endregion

    }
}
