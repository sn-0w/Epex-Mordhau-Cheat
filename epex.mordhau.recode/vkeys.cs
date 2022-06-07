using System;
using System.Collections.Generic;

namespace epex.mordhau.recode
{
	// Token: 0x02000004 RID: 4
	public class vkeys
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000030C0 File Offset: 0x000012C0
		public void load_keys()
		{
			this.d.Add(0, "Unbound");
			this.d.Add(1, "Mouse Left");
			this.d.Add(2, "Mouse Right");
			this.d.Add(4, "Mouse Middle");
			this.d.Add(5, "Mouse X1");
			this.d.Add(6, "Mouse X2");
			this.d.Add(8, "Backspace");
			this.d.Add(9, "Tab");
			this.d.Add(12, "Clear");
			this.d.Add(13, "Enter");
			this.d.Add(16, "Shift");
			this.d.Add(17, "Ctrl");
			this.d.Add(18, "Alt");
			this.d.Add(19, "Pause");
			this.d.Add(20, "Caps Lock");
			this.d.Add(27, "Esc");
			this.d.Add(32, "Spacebar");
			this.d.Add(33, "Page Up");
			this.d.Add(34, "Page Down");
			this.d.Add(35, "End");
			this.d.Add(36, "Home");
			this.d.Add(37, "Left Arrow");
			this.d.Add(38, "Up Arrow");
			this.d.Add(39, "Right Arrow");
			this.d.Add(40, "Down_Arrow");
			this.d.Add(41, "Select");
			this.d.Add(42, "Print");
			this.d.Add(43, "Execute");
			this.d.Add(44, "Print Screen");
			this.d.Add(45, "Insert");
			this.d.Add(46, "Delete");
			this.d.Add(47, "Help");
			this.d.Add(48, "0");
			this.d.Add(49, "1");
			this.d.Add(50, "2");
			this.d.Add(51, "3");
			this.d.Add(52, "4");
			this.d.Add(53, "5");
			this.d.Add(54, "6");
			this.d.Add(55, "7");
			this.d.Add(56, "8");
			this.d.Add(57, "9");
			this.d.Add(65, "A");
			this.d.Add(66, "B");
			this.d.Add(67, "C");
			this.d.Add(68, "D");
			this.d.Add(69, "E");
			this.d.Add(70, "F");
			this.d.Add(71, "G");
			this.d.Add(72, "H");
			this.d.Add(73, "I");
			this.d.Add(74, "J");
			this.d.Add(75, "K");
			this.d.Add(76, "L");
			this.d.Add(77, "M");
			this.d.Add(78, "N");
			this.d.Add(79, "O");
			this.d.Add(80, "P");
			this.d.Add(81, "Q");
			this.d.Add(82, "R");
			this.d.Add(83, "S");
			this.d.Add(84, "T");
			this.d.Add(85, "U");
			this.d.Add(86, "V");
			this.d.Add(87, "W");
			this.d.Add(88, "X");
			this.d.Add(89, "Y");
			this.d.Add(90, "Z");
			this.d.Add(91, "Left Windows");
			this.d.Add(92, "Right Windows");
			this.d.Add(96, "Numpad 0");
			this.d.Add(97, "Numpad 1");
			this.d.Add(98, "Numpad 2");
			this.d.Add(99, "Numpad 3");
			this.d.Add(100, "Numpad 4");
			this.d.Add(101, "Numpad 5");
			this.d.Add(102, "Numpad 6");
			this.d.Add(103, "Numpad 7");
			this.d.Add(104, "Numpad 8");
			this.d.Add(105, "Numpad 9");
			this.d.Add(106, "Multiply");
			this.d.Add(107, "Add");
			this.d.Add(108, "Separator");
			this.d.Add(109, "Subtract");
			this.d.Add(111, "Divide");
			this.d.Add(112, "F1");
			this.d.Add(113, "F2");
			this.d.Add(114, "F3");
			this.d.Add(115, "F4");
			this.d.Add(116, "F5");
			this.d.Add(117, "F6");
			this.d.Add(118, "F7");
			this.d.Add(119, "F8");
			this.d.Add(120, "F9");
			this.d.Add(121, "F10");
			this.d.Add(122, "F11");
			this.d.Add(123, "F12");
			this.d.Add(144, "Num Lock");
			this.d.Add(145, "Scroll Lock");
			this.d.Add(160, "Left Shift");
			this.d.Add(161, "Right Shift");
			this.d.Add(162, "Left Control");
			this.d.Add(163, "Right Control");
			this.d.Add(164, "Left Alt");
			this.d.Add(165, "Right Alt");
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002161 File Offset: 0x00000361
		public vkeys()
		{
		}

		// Token: 0x0400000C RID: 12
		public Dictionary<int, string> d = new Dictionary<int, string>();
	}
}
