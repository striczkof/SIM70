using Gma.System.MouseKeyHook;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Sim70
{
    public partial class MainForm : Form
    {
        private Point location;
        private Color colour;
        private IKeyboardMouseEvents m_GlobalHook = Hook.GlobalEvents();
        private bool isRunning;

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

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);


        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        [DllImport("user32.dll")]
        private static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(
          IntPtr hWnd,
          int hWndInsertAfter,
          int X,
          int Y,
          int cx,
          int cy,
          uint uFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(
          uint dwFlags,
          int dx,
          int dy,
          uint dwData,
          UIntPtr dwExtraInfo);

        public MainForm()
        {
            InitializeComponent();
            m_GlobalHook.KeyDown += new KeyEventHandler(OnKeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // AllocConsole();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                toggleSimming();
            }
        }


        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(ushort vKey);

        public static Color GetPixelColor(IntPtr hwd, int x, int y)
        {
            IntPtr dc = MainForm.GetDC(hwd);
            uint pixel = MainForm.GetPixel(dc, x, y);
            MainForm.ReleaseDC(hwd, dc);
            return Color.FromArgb((int)pixel & (int)byte.MaxValue, ((int)pixel & 65280) >> 8, ((int)pixel & 16711680) >> 16);
        }

        private bool searchPixel(Color color, int tolerance)
        {
            Process[] processesByName = Process.GetProcessesByName("Shootergame");
            if (processesByName.Length == 0)
                return false;
            IntPtr mainWindowHandle = processesByName[0].MainWindowHandle;
            Point coords = getJoinCoords(mainWindowHandle);
            bool flag = true;
            while (flag)
            {
                Color pixelColor = MainForm.GetPixelColor(mainWindowHandle, coords.X, coords.Y);
                Console.WriteLine($"Couldn't Find Color: {pixelColor.ToString()} - x:{coords.X}, y:{coords.Y}");
                if ((Math.Abs(pixelColor.R - color.R) + Math.Abs(pixelColor.G - color.G) + Math.Abs(pixelColor.B - color.B)) < tolerance)
                {
                    Console.WriteLine("Found Color");
                    flag = false;
                }
                Thread.Sleep(100);
            }
            return true;
        }

        private bool searchJoinPixel() => this.searchPixel(colour, 20);

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
                    new Task(new Action(this.loopClicker)).Start();
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

        private async void loopClicker()
        {
            MainForm mainForm = this;
            Process[] processesByName = Process.GetProcessesByName("Shootergame");
            if (processesByName.Length != 0)
            {
                IntPtr hWnd_pc = processesByName[0].MainWindowHandle;
                while (mainForm.isRunning)
                {
                    if (!mainForm.chkDisableColours.Checked)
                    {
                        Task<bool> task = new Task<bool>(new Func<bool>(mainForm.searchJoinPixel));
                        task.Start();
                        if (await task)
                        {
                            Point mousePosition = Control.MousePosition;
                            SetCursorPos(location.X, location.Y);
                            PostMessage(hWnd_pc, 513U, 0, 0);
                            PostMessage(hWnd_pc, 514U, 0, 0);
                            Thread.Sleep(2);
                            SetCursorPos(mousePosition.X, mousePosition.Y);
                            Thread.Sleep((int)nudDelay.Value);
                        }
                        Thread.Sleep(200);
                    }
                    else
                    {
                        Point mousePosition = Control.MousePosition;
                        MainForm.SetCursorPos(location.X, location.Y);
                        MainForm.PostMessage(hWnd_pc, 513U, 0, 0);
                        MainForm.PostMessage(hWnd_pc, 514U, 0, 0);
                        Thread.Sleep(2);
                        MainForm.SetCursorPos(mousePosition.X, mousePosition.Y);
                        Thread.Sleep((int)nudDelay.Value);
                    }
                }
            }
            else
            {
                int num = (int)MessageBox.Show("ARK not Running");
            }
        }

        private void screenColorPicker1_MouseUp(object sender, MouseEventArgs e)
        {
            location = Cursor.Position;
            colour = screenColorPicker1.Color;
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            toggleSimming();
        }
    }
}