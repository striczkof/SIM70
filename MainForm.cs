using System.Diagnostics;
using System.Runtime.InteropServices;
using Octokit;

namespace Sim70
{
    public partial class MainForm : Form
    {
        private Point joinButtonCoords;
        private Point serverCoords;
        private bool isRunning;
        private bool isColourCheckMode;
        private int ver = 3;

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

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
            RegisterHotKey(Handle, 1, 0, (int)Keys.F2);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // AllocConsole();

            for (int i = 1; i <= 10; i++)
            {
                cmbHotkey.Items.Add("F" + i.ToString());
            }
            cmbHotkey.SelectedIndex = 1;

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
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == 1)
            {
                toggleSimming();
            }
            base.WndProc(ref m);
        }

        IntPtr GetProcess(string name = "Shootergame")
        {
            Process[] processesByName = Process.GetProcessesByName(name);
            if (processesByName.Length != 0)
            {
                Console.WriteLine("process lookup: " + processesByName.Length + ", Handle: " + processesByName[0].MainWindowHandle);
                return processesByName[0].MainWindowHandle;
            } else
            {
                return IntPtr.Zero;
            }
        }

        private void toggleSimming()
        {
            isRunning = !isRunning;
            if (joinButtonCoords.IsEmpty)
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

        int WaitForJoinable(IntPtr process)
        {
            int seconds = 0;
            while (true)
            {
                seconds++;
                Thread.Sleep(1000);
                if (process != IntPtr.Zero)
                {
                    Console.WriteLine("Waiting for JOIN button, seconds: " + seconds);
                    Point coords = getAdjustedCoords(process, joinButtonCoords);
                    Color current = GetPixelColor(process, coords.X, coords.Y);
                    Console.WriteLine($"{pickerJoin.Color.R}, {pickerJoin.Color.G}, {pickerJoin.Color.B}");

                    Console.WriteLine($"{current.R}, {current.G}, {current.B}");

                    var redRange = Enumerable.Range(pickerJoin.Color.R - 5, pickerJoin.Color.R + 5);
                    var greenRange = Enumerable.Range(pickerJoin.Color.G - 5, pickerJoin.Color.G + 5);
                    var blueRange = Enumerable.Range(pickerJoin.Color.B - 5, pickerJoin.Color.B + 5);

                    if (redRange.Contains(current.R) && greenRange.Contains(current.G) && blueRange.Contains(current.B))
                    {
                        Console.WriteLine("Join detected - ");
                        return seconds;
                    } else if (seconds >= 30)
                    {
                        return 30;
                    }
                } else
                {
                    return 0;
                }
            }
        }

        private void loopClicker()
        {
            int loopCount = 0;
            IntPtr hWnd_pc = GetProcess();


            if (hWnd_pc != IntPtr.Zero)
            {
                while (isRunning)
                {

                    loopCount = loopCount + 1;
                    Point mousePosition = MousePosition;
                    SetCursorPos(joinButtonCoords.X, joinButtonCoords.Y);
                    PostMessage(hWnd_pc, 513U, 0, 0);
                    PostMessage(hWnd_pc, 514U, 0, 0);
                    Thread.Sleep(1);


                    SetCursorPos(mousePosition.X, mousePosition.Y);

                    int taken = 0;
                    if (chkAutoDelay.Checked)
                    {
                        taken = WaitForJoinable(hWnd_pc);
                        Console.WriteLine("Waited: " + taken);
                    }

                    if (chkSelectServer.Checked && (taken >=30) && !serverCoords.IsEmpty)
                    {
                        Console.WriteLine("Selecting server from list as 30 seconds have passed since last join button was visible.");
                        SetCursorPos(serverCoords.X, serverCoords.Y);
                        PostMessage(hWnd_pc, 513U, 0, 0);
                        PostMessage(hWnd_pc, 514U, 0, 0);
                        Thread.Sleep(1);
                        SetCursorPos(mousePosition.X, mousePosition.Y);
                        Thread.Sleep((int)nudDelay.Value);
                        Thread.Sleep((int)nudDelay.Value);

                    }


                    Thread.Sleep((int)nudDelay.Value);
                }
            } else
            {
                MessageBox.Show("Please ensure ARK is running, couldn't locate the process");
            }
        }

        private void screenColorPicker1_MouseUp(object sender, MouseEventArgs e)
        {
            joinButtonCoords = Cursor.Position;
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            toggleSimming();
        }

        private void chkColourCheckMode_CheckedChanged(object sender, EventArgs e)
        {
            chkAutoDelay.Enabled = chkColourCheckMode.Checked;
            chkSelectServer.Enabled = chkColourCheckMode.Checked;
            if (!chkColourCheckMode.Checked)
            {
                chkAutoDelay.Checked = false;
            }

            isColourCheckMode = !isColourCheckMode;
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
            serverCoords = Cursor.Position;
        }

        private void chkSelectServer_CheckStateChanged(object sender, EventArgs e)
        {
            scpServerSelect.Visible = chkSelectServer.Checked;
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            OpenBrowser("https://github.com/lkd70/SIM70/releases");
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            OpenBrowser("https://github.com/sponsors/lkd70");
        }

        public static Color GetPixelColor(IntPtr hwd, int x, int y)
        {
            IntPtr dc = GetDC(hwd);
            uint pixel = GetPixel(dc, x, y);
            ReleaseDC(hwd, dc);
            return Color.FromArgb((int)pixel & (int)byte.MaxValue, ((int)pixel & 65280) >> 8, ((int)pixel & 16711680) >> 16);
        }

        private Point getAdjustedCoords(IntPtr hWnd_pc, Point coords)
        {
            Rect window = new Rect();
            GetWindowRect(hWnd_pc, ref window);
            Point joinCoords = new Point();
            joinCoords.X = coords.X - window.Left;
            joinCoords.Y = coords.Y;
            return joinCoords;
        }

        Keys resolveHotkey()
        {
            if (cmbHotkey.SelectedItem.ToString() != null)
            {
                switch(cmbHotkey.SelectedItem.ToString())
                {
                    case "F1": return Keys.F1;
                    case "F2": return Keys.F2;
                    case "F3": return Keys.F3;
                    case "F4": return Keys.F4;
                    case "F5": return Keys.F5;
                    case "F6": return Keys.F6;
                    case "F7": return Keys.F7;
                    case "F8": return Keys.F8;
                    case "F9": return Keys.F9;
                    case "F10": return Keys.F10;
                    default: return Keys.F2;
                }
            }
            return Keys.F2;
        }

        private void cmbHotkey_SelectedIndexChanged(object sender, EventArgs e)
        {
            Keys hotkey = resolveHotkey();
            btnStatus.Text = (isRunning ? "Stop" : "Start") + " (" + hotkey.ToString() + ")";
            // RegisterHotKey(Handle, 1, 0, (int)Keys.F2);
            UnregisterHotKey(Handle, 1);
            RegisterHotKey(Handle, 1, 0, (int)hotkey);
        }
    }
}