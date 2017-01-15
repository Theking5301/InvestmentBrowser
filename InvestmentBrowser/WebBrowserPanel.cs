using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentBrowser {
    public partial class WebBrowserPanel : UserControl {
        public System.Windows.Forms.Timer refreshTimer = new System.Windows.Forms.Timer();
        public string initialURL = "http://finviz.com";
        public int refreshRate = 15000;
        public int currentTime = 0;
        public int ID = 0;
        public bool collapsed = false;
        public delegate void timerTicked(int panelID);
        public event timerTicked tickTimer;

        public WebBrowserPanel() {
            InitializeComponent();
            this.NavBar.KeyDown += new KeyEventHandler(this.NavBar_KeyDown);
            this.RefreshTimerBox.KeyDown += new KeyEventHandler(this.RefreshTimeChanged_KeyDown);
            WebBrowser.ScriptErrorsSuppressed = true;
            WebBrowser.Navigate(new Uri(initialURL));
            NavBar.Text = initialURL;
            refreshTimer.Interval = 500;
            RefreshTimerBox.Text = ((float)refreshRate/1000).ToString() + " s";
            refreshTimer.Tick += new EventHandler(TimerTick);
        }
        void TimerTick(object sender, EventArgs e){
            tickTimer(ID);
            if (currentTime >= refreshRate){
                if (!PauseCheckbox.Checked){
                    WebBrowser.Navigate(WebBrowser.Url);
                }
                currentTime = 0;
            }else{
                if(!PauseCheckbox.Checked) {
                    if (currentTime + 1000 <= refreshRate){
                        currentTime += 1000;
                    }else{
                        currentTime = refreshRate;
                    }
                }

            }
        }
        void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            WebBrowser.Document.Body.ScrollTop = 200;
            NavBar.Text = WebBrowser.Url.ToString();
        }
        private void RefreshTimeChanged_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                updateRefreshTimeFromInput();
            }
        }
        private void NavBar_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter){
                WebBrowser.Navigate(NavBar.Text);
            }
        }
        private void AcceptButton_Click(object sender, EventArgs e){
            updateRefreshTimeFromInput();
        }
        void updateRefreshTimeFromInput() {
            float time = 10;
            if(float.TryParse(RefreshTimerBox.Text, out time)) {
                refreshRate = (int)(time * 1000);
                RefreshTimerBox.Text = time.ToString() + " s";
            }
        }
        private void ForwardButton_Click(object sender, EventArgs e) {
            if (WebBrowser.CanGoForward){
                WebBrowser.GoForward();
            }
        }
        private void BackButton_Click(object sender, EventArgs e) {
            if (WebBrowser.CanGoBack){
                WebBrowser.GoBack();
            }
        }
        private void NavigateButton_Click(object sender, EventArgs e){
            WebBrowser.Navigate(NavBar.Text);
        }
        private void CollapseButton_Click(object sender, EventArgs e){
            collapsed = !collapsed;
            if(collapsed){
                CollapseButton.BackgroundImage = Properties.Resources.blue_checkmark;
                refreshTimer.Enabled = false;
                this.MaximumSize = new Size(10, 0);
            }else{
                CollapseButton.BackgroundImage = Properties.Resources.red_cross;
                refreshTimer.Enabled = true;
                this.MaximumSize = new Size(1000, 0);
            }
        }
    }
}
