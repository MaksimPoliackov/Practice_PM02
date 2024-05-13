using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Medical_Laboratory
{
    public partial class Timer : Form
    {
        private int sessionTime = 600; // 10 минут в секундах 
        private int warningTime = 300; // 5 минут в секундах 
        private int blockTime = 60; // 1 минута в секундах

        public Timer()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sessionTime--;

            // Обновление отображения времени
            int minutes = sessionTime / 60;
            int seconds = sessionTime % 60;
            TB1.Text = $"Осталось: {minutes:D2}:{seconds:D2}";

            // Проверка на окончание сеанса и предупреждения
            if (sessionTime == 0)
            {
                MessageBox.Show("Время сеанса истекло. Вы будете выведены из системы.");
                LogoutAndBlock();
            }
            else if (sessionTime == warningTime)
            {
                MessageBox.Show("Внимание! Время сеанса скоро истечет.");
            }
        }

        private void LogoutAndBlock()
        {
            // Запускаем таймер для разблокировки
            DispatcherTimer unblockTimer = new DispatcherTimer();
            unblockTimer.Interval = TimeSpan.FromSeconds(blockTime);
            unblockTimer.Tick += UnblockTimer_Tick;
            unblockTimer.Start();
            throw new NotImplementedException();
        }

        private void UnblockTimer_Tick(object sender, EventArgs e)
        {
            (sender as DispatcherTimer).Stop(); // Останавливаем таймер разблокировки
            throw new NotImplementedException();
        }
    }
}
