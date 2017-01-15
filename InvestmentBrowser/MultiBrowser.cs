using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentBrowser {
    public partial class MultiBrowser : Form {
        bool isRefreshing = false;
        bool maximized = true;

        WebBrowserPanel[] panels = new WebBrowserPanel[4];

        Screen[] screens = Screen.AllScreens;
        int currentScreen = -1;

        public MultiBrowser() {
            this.WindowState = FormWindowState.Maximized;
            this.Opacity = 0;
            fadeOn();

            InitializeComponent();
            panels[0] = webBrowserPanel1;
            panels[1] = webBrowserPanel2;
            panels[2] = webBrowserPanel3;
            panels[3] = webBrowserPanel4;
            currentScreen = screens.Length;
            populateProfiles();
            initializePanels();
        }
        void timerTicked(int panelID){
            setRefreshTimeLabel(panelID);
        }
        private void AutoRefreshButton_Click(object sender, EventArgs e){
            isRefreshing = !isRefreshing;
            if(isRefreshing){
                AutoRefreshButton.BackgroundImage = Properties.Resources.RedButton1;
                AutoRefreshButton.Text = "Stop Refresh";
                toggleRefreshing(true);
            }else{
                AutoRefreshButton.BackgroundImage = Properties.Resources.GreenButton1;
                AutoRefreshButton.Text = "Auto Refresh";
                toggleRefreshing(false);
            }

        }
        void setRefreshTimeLabel(int label) {
            string timeRemaining = (((float)(panels[label].refreshRate - panels[label].currentTime)/1000)).ToString() + " s";
            switch (label) {
                case 0:
                    Browser1TimeLabel.Text = timeRemaining;
                    break;
                case 1:
                    Browser2TimeLabel.Text = timeRemaining;
                    break;
                case 2:
                    Browser3TimeLabel.Text = timeRemaining;
                    break;
                case 3:
                    Browser4TimeLabel.Text = timeRemaining;
                    break;
                default:
                    break;
            }
        }
        int getPanelNumber(object sender){
            if (sender == webBrowserPanel1){
                return 0;
            }
            if (sender == webBrowserPanel2){
                return 1;
            }
            if (sender == webBrowserPanel3){
                return 2;
            }
            if (sender == webBrowserPanel4){
                return 3;
            }
            return 0;
        }
        int getPanelNumberFromTimer(object sender){
            if (sender == webBrowserPanel1) {
                return 0;
            }
            if (sender == webBrowserPanel2) {
                return 1;
            }
            if (sender == webBrowserPanel3) {
                return 2;
            }
            if (sender == webBrowserPanel4) {
                return 3;
            }
            return 0;
        }
        void toggleRefreshing(bool refresh) {
            for(int i=0; i<4; i++) {
                panels[i].refreshTimer.Enabled = refresh;
            }
        }
        private void initializePanels(){
            for (int i = 0; i < 4; i++) {
                panels[i].ID = i;
                panels[i].tickTimer += new WebBrowserPanel.timerTicked(timerTicked);
                panels[i].refreshRate = 10000 + i * 1000;
                panels[i].RefreshTimerBox.Text = (((float)panels[i].refreshRate / 1000)).ToString() + " s";
                panels[i].currentTime = 0;
                toggleRefreshing(false);
                setRefreshTimeLabel(i);
            }
        }
        void initializeProfiles() {
            
        }
        void addProfile(string profileName) {
            string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "MultiBrowser", profileName + ".dat");

            if (Directory.Exists(path)) {
                //Exists
            }else{
                //Needs to be created
            }
        }
        private void ResetAllButton_Click(object sender, EventArgs e) {
            initializePanels();
        }
        private void ResetTimersButton_Click(object sender, EventArgs e) {
            for (int i = 0; i < 4; i++) {
                panels[i].currentTime = 0;
                setRefreshTimeLabel(i);
            }
        }
        private void MaximizeButton_Click(object sender, EventArgs e){
            if(maximized){
                this.WindowState = FormWindowState.Normal;
            }else{
                this.WindowState = FormWindowState.Maximized;
            }
            maximized = !maximized;
        }
        private void changeScreen(int screen) {
            if(screen < screens.Length) {
                if(maximized) {
                    this.WindowState = FormWindowState.Normal;
                }

                Point p = new Point();
                p.X = screens[screen].WorkingArea.X;
                p.Y = screens[screen].WorkingArea.Y;
                this.Location = p;
                System.Diagnostics.Debug.Write(screen);
                currentScreen = screen;
                if (maximized) { 
                    this.WindowState = FormWindowState.Maximized;
                }
                currentScreen = screen;
            }
        }
        private async void CloseButton_Click(object sender, EventArgs e){
            fadeOff();

            await Task.Delay(120);
            System.Windows.Forms.Application.Exit();
        }
        private async void fadeOn(){
            while (this.Opacity < 1.0) {
                await Task.Delay(5);
                this.Opacity += 0.1;
            }
            this.Opacity = 1;    
        }
        private async void fadeOff() {
            while (this.Opacity > 0.0){
                await Task.Delay(10);
                this.Opacity -= 0.1;
            }
            this.Opacity = 0;
        }

        private void ChangeMonitorsButton_Click(object sender, EventArgs e) {
            if (currentScreen < screens.Length-1) {
                changeScreen(currentScreen+1);
            }else{
                changeScreen(0);
            }
        }
        public void createAndSaveProfile(String profileName) {
            string[] lines = {"Panel1:" + panels[0].WebBrowser.Url.ToString(),"Panel2:" +  panels[1].WebBrowser.Url.ToString(),"Panel3:" +  panels[2].WebBrowser.Url.ToString(),
               "Panel4:" +  panels[3].WebBrowser.Url.ToString(), "Screen:" + currentScreen.ToString()};
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\MultiBrowser");
            System.IO.File.WriteAllLines(@"C:\Users\Public\MultiBrowser\" + profileName + ".mbp", lines);
            populateProfiles();
        }
        public void populateProfiles(){
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\MultiBrowser");
            DirectoryInfo tempDirectory = new DirectoryInfo(@"C:\Users\Public\MultiBrowser");
            FileInfo[] tempFiles = tempDirectory.GetFiles("*.mbp");
            ProfilesComboBox.Items.Clear();
            foreach (FileInfo file in tempFiles) {
                ProfilesComboBox.Items.Add(file.Name.Substring(0, file.Name.Length - 4));
            }
            if(ProfilesComboBox.Items.Count > 0){
                ProfilesComboBox.SelectedItem = ProfilesComboBox.Items[0];
            }

        }
        public void loadFromProfile(String profileName) {
            string path = @"C:\Users\Public\MultiBrowser\" + profileName + ".mbp";
            using (StreamReader sr = File.OpenText(path)){
                string s = "";
                int currentPanel = 0;
                while ((s = sr.ReadLine()) != null) {
                    if(s.StartsWith("Screen:")) {
                        changeScreen(Int32.Parse(s.Substring(7)));
                    }else{
                        panels[currentPanel].WebBrowser.Navigate(s.Substring(7));
                    }
                    currentPanel++;
                    Console.WriteLine(s);
                }
            }
        }
        private void CreateProfileButton_Click(object sender, EventArgs e){
            createAndSaveProfile(ProfileInput.Text);
        }

        private void SetProfileButton_Click(object sender, EventArgs e) {
            loadFromProfile(ProfilesComboBox.SelectedItem.ToString());
        }

        private void RemoveProfileButton_Click(object sender, EventArgs e) {
            if(ProfilesComboBox.SelectedItem != null) {
                string path = @"C:\Users\Public\MultiBrowser\" + ProfilesComboBox.SelectedItem.ToString() + ".mbp";
                if (System.IO.File.Exists(path)){
                    System.IO.File.Delete(path);
                    populateProfiles();
                }
            }
        }
    }
}
