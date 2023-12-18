using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace nhom_9
{
    class ThongBao
    {
        private System.Timers.Timer _timer;
        public void setTask(DateTime dueTime, string tieude)
        {
            TimeSpan alertSpan = TimeSpan.FromMinutes(3); // Thời gian cảnh báo trước 3 phút
            DateTime alertTime = dueTime.Subtract(alertSpan);

            double alertInterval = (alertTime - DateTime.Now).TotalMilliseconds;
            double taskInterval = (dueTime - DateTime.Now).TotalMilliseconds;
            if (alertInterval > 0)
            {
                // Tạo timer để thông báo trước 3 phút
                System.Timers.Timer alertTimer = new System.Timers.Timer(alertInterval);
                alertTimer.Elapsed += (sender, e) =>AlertEvent(sender, e, tieude);
                alertTimer.AutoReset = false;
                alertTimer.Enabled = true;
            }

            if (taskInterval > 0)
            {
                // Tạo timer để thông báo đến thời gian làm việc
                _timer = new System.Timers.Timer(taskInterval);
                _timer.Elapsed += (sender, e) =>OnTimedEvent(sender, e, tieude);
                _timer.AutoReset = false;
                _timer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thông báo sắp đến giờ", "Nhắc Nhở");
            }
        }
        private void AlertEvent(object source, ElapsedEventArgs e, string tieude)
        {
            MessageBox.Show("Sắp đến giờ làm việc "+tieude, "Nhắc Nhở");
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e, string tieude)
        {
            MessageBox.Show("Đến thời gian làm việc "+tieude, "Nhắc nhở");
            _timer.Stop();
            _timer.Dispose();
        }
    }
}

