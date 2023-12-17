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
        public void setTask(DateTime dueTime)
        {
            TimeSpan alertSpan = TimeSpan.FromMinutes(3); // Thời gian cảnh báo trước 3 phút
            DateTime alertTime = dueTime.Subtract(alertSpan);

            double alertInterval = (alertTime - DateTime.Now).TotalMilliseconds;
            double taskInterval = (dueTime - DateTime.Now).TotalMilliseconds;
            if (alertInterval > 0)
            {
                // Tạo timer để thông báo trước 3 phút
                System.Timers.Timer alertTimer = new System.Timers.Timer(alertInterval);
                alertTimer.Elapsed += AlertEvent;
                alertTimer.AutoReset = false;
                alertTimer.Enabled = true;
            }

            if (taskInterval > 0)
            {
                // Tạo timer để thông báo đến thời gian làm việc
                _timer = new System.Timers.Timer(taskInterval);
                _timer.Elapsed += OnTimedEvent;
                _timer.AutoReset = false;
                _timer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thông báo sắp đến giờ", "Nhắc Nhở");
            }
        }
        private void AlertEvent(object source, ElapsedEventArgs e)
        {
            MessageBox.Show("Sắp đến giờ làm việc", "Nhắc Nhở");
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            MessageBox.Show("Đến thời gian làm việc", "Nhắc nhở");
            _timer.Stop();
            _timer.Dispose();
        }
    }
}

