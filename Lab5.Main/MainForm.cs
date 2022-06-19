using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InputString;
using Lab5.Models;
using System.Reflection;

namespace Lab5.Main
{
    public partial class MainForm : Form
    {
        List<ViewObject> viewObjects;
        object viewObjectsLocker;

        List<ViewModel> viewModels;
        object viewModelsLocker;
        Painter painter;

        ViewObject baseOfEmergenceServices, depo;

        List<Driver> Drivers;
        object DriversLocker;
        List<Trolleybus> Trolleybuss;
        int maxTrolleybussNumber;

        IEnumerable<Type> EmergencyServiceTypes;
        List<string> notifications;

        public MainForm()
        {
            InitializeComponent();

            viewObjects = new List<ViewObject>();
            viewObjectsLocker = new object();

            viewModels = new List<ViewModel>();
            viewModelsLocker = new object();

            Drivers = new List<Driver>();
            DriversLocker = new object();

            EmergencyServiceTypes = Assembly.Load("Lab5.Models").GetTypes()
                .Where(type => !type.IsAbstract && type.GetInterface("IEmergencyService") != null);

            notifications = new List<string>();

            maxTrolleybussNumber = (int)(pictureBox.Height / Properties.Resources.depo1.Height);

            Trolleybuss = new List<Trolleybus>();
        }

        void Notification(string message)
        {
            notificationTextBox.Invoke((MethodInvoker)delegate
            {
                notifications.Add(message);

                if (notifications.Count >= 15)
                {
                    // clear
                    notifications = notifications.GetRange(5, 9);

                    notificationTextBox.Text = "";

                    foreach (var item in notifications)
                    {
                        notificationTextBox.Text += item + "\r\n\r\n";
                    }
                }

                notificationTextBox.Text += message + "\r\n\r\n";
            });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            painter.Stop();

            foreach (var item in Trolleybuss)
            {
                item.IsCanceled = true;
            }

            foreach (var item in viewModels)
            {
                if (item is ViewModel viewModel)
                    viewModel.Model.IsCanceled = true;
            }
        }

        void InputTransportService(TransportService transportService)
        {

            InputStringDialog inputnameOfObject = new InputStringDialog(new WordValidator(), "Введите название");

            if (inputnameOfObject.ShowDialog() == DialogResult.OK)
            {
                transportService.nameOfObject = inputnameOfObject.Value; 
            }
            
            InputStringDialog inputnumberOfObject = new InputStringDialog(new  IntValidator(), "Введите Номер машины");

            if (inputnumberOfObject.ShowDialog() == DialogResult.OK)
            {
                transportService.numberOfObject = Convert.ToInt32(inputnumberOfObject.Value);
            }
        }
  

        void SetBuildingsSize()
        {
            baseOfEmergenceServices.X = pictureBox.Width - Properties.Resources.emergencyService.Width / 2;
            baseOfEmergenceServices.Y = Properties.Resources.emergencyService.Height / 2;
            depo.X = pictureBox.Width - Properties.Resources.depo.Width / 2;
            depo.Y = pictureBox.Height - Properties.Resources.depo.Height / 2;
        }
    
        void AddTrolleybus(string TrolleybusName, int maxParticipatingDriverNumber = 3)
        {
            float x = Properties.Resources.depo1.Width / 2,
                y = Properties.Resources.depo1.Height / 2;

            y += Trolleybuss.Count() * Properties.Resources.depo1.Height;

            Trolleybuss.Add(new Trolleybus(Notification, Drivers, DriversLocker, x, y, TrolleybusName, maxParticipatingDriverNumber));

            lock (viewObjectsLocker)
            {
                viewObjects.Add(new ViewObject(Properties.Resources.depo1, x, y));
            }

            Task.Run(Trolleybuss[Trolleybuss.Count() - 1].Start);

            if (Trolleybuss.Count() >= maxTrolleybussNumber)
                addTrolleybusToolStripMenuItem.Enabled = false;
        }

        void GenerateDrivers(int driversNumber)
        {
            for (int i = 0; i < driversNumber; i++)
            {
                var newDriver = new Driver(Notification, depo.X, depo.Y)
                {
                    nameOfObject = "Driver" + i.ToString(),
                    numberOfObject =  i
                };

                Drivers.Add(newDriver);

                viewModels.Add(new ViewModel(newDriver, Properties.Resources.driver));

                Task.Run(newDriver.Start);
            }
        }

        void GenerateEmergenceServices(int EmergenceServicesNumber)
        {
            object[] EmergenceServiceArgs = new object[]
           { (Action<string>)Notification,
                baseOfEmergenceServices.X,
                baseOfEmergenceServices.Y,
                Drivers,
                DriversLocker };

            for (int i = 0; i < EmergenceServicesNumber; i++)
            {
                foreach (var item in EmergencyServiceTypes)
                {
                    EmergencyService newEmergenceService = Activator.CreateInstance(item, EmergenceServiceArgs) as EmergencyService;
                    newEmergenceService.nameOfObject = "ES" + i.ToString();
                    newEmergenceService.numberOfObject =  i;

                    viewModels.Add(new ViewModel(newEmergenceService, Properties.Resources.people));

                    Task.Run(newEmergenceService.Start);
                }
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addDriverToolStripMenuItem.Enabled = true;
            addEmergencyServiceToolStripMenuItem.Enabled = true;
            startToolStripMenuItem.Enabled = false;
            addTrolleybusToolStripMenuItem.Enabled = true;

            painter = new Painter(pictureBox, Color.FromArgb(0, 0, 0),
               new Font(notificationTextBox.Font.FontFamily, 10f, notificationTextBox.Font.Style),
               viewObjects, viewObjectsLocker, viewModels, viewModelsLocker);
            baseOfEmergenceServices = new ViewObject(Properties.Resources.emergencyService);
            depo = new ViewObject(Properties.Resources.depo);

            SetBuildingsSize();
            viewObjects.Add(baseOfEmergenceServices);
            viewObjects.Add(depo);

            AddTrolleybus("Троллейбус 1");
            GenerateDrivers(5);
            GenerateEmergenceServices(1);

            painter.Start();
        }

        private void addEmergencyServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type EmergencyServiceType = typeof(Police);

            SelectEmergenceServiceType selectEmergencyServiceType = new SelectEmergenceServiceType(EmergencyServiceTypes);

            if (selectEmergencyServiceType.ShowDialog() == DialogResult.OK)
            {
                EmergencyServiceType = selectEmergencyServiceType.SelectedType;
            }

            EmergencyService EmergencyService = Activator.CreateInstance(EmergencyServiceType,
                new object[] { (Action<string>)Notification, baseOfEmergenceServices.X, baseOfEmergenceServices.Y, Drivers, DriversLocker }) as EmergencyService;

            InputTransportService(EmergencyService);

            lock (viewModelsLocker)
            {
                viewModels.Add(new ViewModel(EmergencyService, Properties.Resources.people));
            }

            Task.Run(EmergencyService.Start);
        }

        private void addDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driver newDriver = new Driver(Notification, depo.X, depo.Y);

            InputTransportService(newDriver);
            lock (DriversLocker)
            {
                Drivers.Add(newDriver);
            }

            lock (viewModels)
            {
                viewModels.Add(new ViewModel(newDriver, Properties.Resources.driver));
            }
            Task.Run(newDriver.Start);
        }

        private void addCompatitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputStringDialog inputTrolleyBus = new InputStringDialog(new WordValidator(), "Введите название троллейбуса");

            string name = "";

            if (inputTrolleyBus.ShowDialog() == DialogResult.OK)
                name = inputTrolleyBus.Value;

            InputStringDialog inputMaxParticipatingDriversNumber = new InputStringDialog(new NotNegativeIntValidator(),
                "Введите максимальное количество водителей в тролейбусе");

            if (inputMaxParticipatingDriversNumber.ShowDialog() == DialogResult.OK)
                AddTrolleybus(name, Int32.Parse(inputMaxParticipatingDriversNumber.Value));
            else
                AddTrolleybus(name);
        }
    }
}
