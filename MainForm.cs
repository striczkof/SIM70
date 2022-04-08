using Gma.System.MouseKeyHook;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Octokit;

namespace Sim70
{
    public partial class MainForm : Form
    {
        private Point location;
        private Point serverlocation;
        private IKeyboardMouseEvents m_GlobalHook = Hook.GlobalEvents();
        private bool isRunning;
        private bool isAdvanced;
        private int ver = 2;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        [DllImport("user32.dll")]
        private static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        public MainForm()
        {
            InitializeComponent();
            m_GlobalHook.KeyDown += new KeyEventHandler(OnKeyDown);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // AllocConsole();
            
            var client = new GitHubClient(new ProductHeaderValue("SIM70"));
            var releases = client.Repository.Release.GetAll("lkd70", "SIM70");
            var latest = releases.Result[0];

            Console.WriteLine("The latest release is tagged at {0} and is named {1}", latest.TagName, latest.Name);

            if (latest.Id < ver)
            {

                string message = $"An update is available for Sim70." +
                 $"\nYou're currently on version {ver}, however version {latest.Id} is available." +
                 $"\nDownload the new verison now?";
                DialogResult result = MessageBox.Show(message, "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    OpenBrowser(latest.Assets[0].BrowserDownloadUrl);
                    MessageBox.Show("Download has started in your browser. Please close Sim70 and re-open the new file.");
                }
            }

            Text = $"SIM70 v{ver} - Kibble on top";

            Width = 358;
            Height = 249;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                toggleSimming();
            }
        }

        private void toggleSimming()
        {
            isRunning = !isRunning;
            if (location.IsEmpty)
            {
                MessageBox.Show("Please drag the box in the UI to the Join button on the ARK Screen.");
            } else
            {
                if (isRunning)
                {

                    btnStatus.Text = "Stop (F2)";
                    new Task(new Action(loopClicker)).Start();
                }
                else
                {
                    btnStatus.Text = "Start (F2)";
                }
            }

        }
        private Point getJoinCoords(IntPtr hWnd_pc)
        {
            Rect window = new Rect();
            GetWindowRect(hWnd_pc, ref window);
            Point joinCoords = new Point();
            joinCoords.X = location.X - window.Left;
            joinCoords.Y = location.Y;
            return joinCoords;
        }

        private void loopClicker()
        {
            int loopCount = 0;

            Process[] processesByName = Process.GetProcessesByName("Shootergame");
            if (processesByName.Length != 0)
            {
                IntPtr hWnd_pc = processesByName[0].MainWindowHandle;
                while (isRunning)
                {
                    loopCount = loopCount + 1;
                    Point mousePosition = MousePosition;
                    SetCursorPos(location.X, location.Y);
                    PostMessage(hWnd_pc, 513U, 0, 0);
                    PostMessage(hWnd_pc, 514U, 0, 0);
                    Thread.Sleep(1);

                    if (chkAdvanced.Checked && chkSelectServer.Checked && (loopCount % nudSelectServerEvery.Value) == 0 && !serverlocation.IsEmpty)
                    {
                        SetCursorPos(serverlocation.X, serverlocation.Y);
                        PostMessage(hWnd_pc, 513U, 0, 0);
                        PostMessage(hWnd_pc, 514U, 0, 0);
                        Thread.Sleep(2);
                        SetCursorPos(mousePosition.X, mousePosition.Y);
                        Thread.Sleep((int)nudDelay.Value);
                        Thread.Sleep((int)nudDelay.Value);

                    }
                    SetCursorPos(mousePosition.X, mousePosition.Y);
                    Thread.Sleep((int)nudDelay.Value);

                }
            }
            else
            {
                MessageBox.Show("Please start ARK");
            }
        }

        private void screenColorPicker1_MouseUp(object sender, MouseEventArgs e)
        {
            location = Cursor.Position;
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            toggleSimming();
        }

        private void chkAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            isAdvanced = !isAdvanced;

            if (isAdvanced)
            {
                Width = 358;
                Height = 421;
            } else
            {
                Width = 358;
                Height = 249;
            }
        }

        public static void OpenBrowser(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            }
        }

        private void scpServerSelect_MouseUp(object sender, MouseEventArgs e)
        {
            serverlocation = Cursor.Position;
        }

        private void chkSelectServer_CheckStateChanged(object sender, EventArgs e)
        {
            nudSelectServerEvery.Visible = chkSelectServer.Checked;
            scpServerSelect.Visible = chkSelectServer.Checked;
            lblServerSelectMode.Visible = chkSelectServer.Checked;
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            OpenBrowser("https://github.com/lkd70/SIM70/releases");
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            OpenBrowser("https://github.com/sponsors/lkd70");
        }
    }
}