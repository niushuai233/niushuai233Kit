using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace niushuai233Kit.Util
{
	public class WinAPI
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		public const int MOUSEWHEEL = 0x020A;

		[DllImportAttribute("user32.dll")]
		internal static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[DllImportAttribute("user32.dll")]
		internal static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		[DllImportAttribute("user32.dll")]
		internal static extern bool ReleaseCapture();

		// 设置此窗体为活动窗体：
		// 将创建指定窗口的线程带到前台并激活该窗口。键盘输入直接指向窗口，并为用户更改各种视觉提示。
		// 系统为创建前台窗口的线程分配的优先级略高于其他线程。
		[DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		// 设置此窗体为活动窗体：
		// 激活窗口。窗口必须附加到调用线程的消息队列。
		[DllImport("user32.dll", EntryPoint = "SetActiveWindow")]
		public static extern IntPtr SetActiveWindow(IntPtr hWnd);

		// 设置窗体位置
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags);
	}
}
