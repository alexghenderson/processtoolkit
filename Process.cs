using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessToolkit
{
    public class Process
    {

        public enum MessageType
        {
            LEFT_BUTTON_DOWN = 0x201,
            LEFT_BUTTON_UP = 0x202,
            LEFT_BUTTON_DOUBLECLICK = 0x203,
            RIGHT_BUTTON_DOWN = 0x204,
            RIGHT_BUTTON_UP = 0x205,
            RIGHT_BUTTON_DOUBLECLICK = 0x206,
            KEYDOWN = 0x100,
            KEYUP = 0x101
        }

        public enum Key
        {
            VK_LBUTTON = 0x01,   //Left mouse button 
            VK_RBUTTON = 0x02,   //Right mouse button 
            VK_CANCEL = 0x03,   //Control-break processing 
            VK_MBUTTON = 0x04,   //Middle mouse button (three-button mouse) 
            VK_BACK = 0x08,   //BACKSPACE key 
            VK_TAB = 0x09,   //TAB key 
            VK_CLEAR = 0x0C,   //CLEAR key 
            VK_RETURN = 0x0D,   //ENTER key 
            VK_SHIFT = 0x10,   //SHIFT key 
            VK_CONTROL = 0x11,   //CTRL key 
            VK_MENU = 0x12,   //ALT key 
            VK_PAUSE = 0x13,   //PAUSE key 
            VK_CAPITAL = 0x14,   //CAPS LOCK key 
            VK_ESCAPE = 0x1B,   //ESC key 
            VK_SPACE = 0x20,   //SPACEBAR 
            VK_PRIOR = 0x21,   //PAGE UP key 
            VK_NEXT = 0x22,   //PAGE DOWN key 
            VK_END = 0x23,   //END key 
            VK_HOME = 0x24,   //HOME key 
            VK_LEFT = 0x25,   //LEFT ARROW key 
            VK_UP = 0x26,   //UP ARROW key 
            VK_RIGHT = 0x27,   //RIGHT ARROW key 
            VK_DOWN = 0x28,   //DOWN ARROW key 
            VK_SELECT = 0x29,   //SELECT key 
            VK_PRINT = 0x2A,   //PRINT key
            VK_EXECUTE = 0x2B,   //EXECUTE key 
            VK_SNAPSHOT = 0x2C,   //PRINT SCREEN key 
            VK_INSERT = 0x2D,   //INS key 
            VK_DELETE = 0x2E,   //DEL key 
            VK_HELP = 0x2F,   //HELP key
            VK_0 = 0x30,   //0 key 
            VK_1 = 0x31,   //1 key 
            VK_2 = 0x32,   //2 key 
            VK_3 = 0x33,   //3 key 
            VK_4 = 0x34,   //4 key 
            VK_5 = 0x35,   //5 key 
            VK_6 = 0x36,    //6 key 
            VK_7 = 0x37,    //7 key 
            VK_8 = 0x38,   //8 key 
            VK_9 = 0x39,    //9 key 
            VK_A = 0x41,   //A key 
            VK_B = 0x42,   //B key 
            VK_C = 0x43,   //C key 
            VK_D = 0x44,   //D key 
            VK_E = 0x45,   //E key 
            VK_F = 0x46,   //F key 
            VK_G = 0x47,   //G key 
            VK_H = 0x48,   //H key 
            VK_I = 0x49,    //I key 
            VK_J = 0x4A,   //J key 
            VK_K = 0x4B,   //K key 
            VK_L = 0x4C,   //L key 
            VK_M = 0x4D,   //M key 
            VK_N = 0x4E,    //N key 
            VK_O = 0x4F,   //O key 
            VK_P = 0x50,    //P key 
            VK_Q = 0x51,   //Q key 
            VK_R = 0x52,   //R key 
            VK_S = 0x53,   //S key 
            VK_T = 0x54,   //T key 
            VK_U = 0x55,   //U key 
            VK_V = 0x56,   //V key 
            VK_W = 0x57,   //W key 
            VK_X = 0x58,   //X key 
            VK_Y = 0x59,   //Y key 
            VK_Z = 0x5A,    //Z key
            VK_NUMPAD0 = 0x60,   //Numeric keypad 0 key 
            VK_NUMPAD1 = 0x61,   //Numeric keypad 1 key 
            VK_NUMPAD2 = 0x62,   //Numeric keypad 2 key 
            VK_NUMPAD3 = 0x63,   //Numeric keypad 3 key 
            VK_NUMPAD4 = 0x64,   //Numeric keypad 4 key 
            VK_NUMPAD5 = 0x65,   //Numeric keypad 5 key 
            VK_NUMPAD6 = 0x66,   //Numeric keypad 6 key 
            VK_NUMPAD7 = 0x67,   //Numeric keypad 7 key 
            VK_NUMPAD8 = 0x68,   //Numeric keypad 8 key 
            VK_NUMPAD9 = 0x69,   //Numeric keypad 9 key 
            VK_SEPARATOR = 0x6C,   //Separator key 
            VK_SUBTRACT = 0x6D,   //Subtract key 
            VK_DECIMAL = 0x6E,   //Decimal key 
            VK_DIVIDE = 0x6F,   //Divide key
            VK_F1 = 0x70,   //F1 key 
            VK_F2 = 0x71,   //F2 key 
            VK_F3 = 0x72,   //F3 key 
            VK_F4 = 0x73,   //F4 key 
            VK_F5 = 0x74,   //F5 key 
            VK_F6 = 0x75,   //F6 key 
            VK_F7 = 0x76,   //F7 key 
            VK_F8 = 0x77,   //F8 key 
            VK_F9 = 0x78,   //F9 key 
            VK_F10 = 0x79,   //F10 key 
            VK_F11 = 0x7A,   //F11 key 
            VK_F12 = 0x7B,   //F12 key
            VK_SCROLL = 0x91,   //SCROLL LOCK key 
            VK_LSHIFT = 0xA0,   //Left SHIFT key
            VK_RSHIFT = 0xA1,   //Right SHIFT key
            VK_LCONTROL = 0xA2,   //Left CONTROL key
            VK_RCONTROL = 0xA3,    //Right CONTROL key
            VK_LMENU = 0xA4,      //Left MENU key
            VK_RMENU = 0xA5,   //Right MENU key
            VK_PLAY = 0xFA,   //Play key
            VK_ZOOM = 0xFB, //Zoom key 
        }

        private IntPtr m_hProcess = IntPtr.Zero;
        private System.Diagnostics.Process m_ReadProcess = null;
        public System.Diagnostics.Process ReadProcess
        {
            get
            {
                return m_ReadProcess;
            }
        }

        public int PID
        {
            get { return m_ReadProcess.Id; }
        }

        public int BaseAddress
        {
            get { return m_ReadProcess.MainModule.BaseAddress.ToInt32(); }
        }

        public Process()
        {

        }

        public void Open()
        {
            MemoryAPI.ProcessAccessType access = MemoryAPI.ProcessAccessType.PROCESS_VM_READ | MemoryAPI.ProcessAccessType.PROCESS_VM_WRITE | MemoryAPI.ProcessAccessType.PROCESS_VM_OPERATION;
            m_hProcess = MemoryAPI.OpenProcess((uint)access, 1, (uint)m_ReadProcess.Id);
            if(m_hProcess == IntPtr.Zero)
                throw new Exception("Failed to open process");
        }

        public void OpenProcess(System.Diagnostics.Process process)
        {
            m_ReadProcess = process;
            Open();
        }

        public void OpenProcessByName(string processName, int index = 0)
        {
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(processName);
            if (processes.Length > index)
            {
                m_ReadProcess = processes[index];
                Open();
            }
            else
            {
                throw new Exception("Process does not exist or index is out of bounds");
            }
        }

        public void OpenProcessById(int processId)
        {
            System.Diagnostics.Process process = System.Diagnostics.Process.GetProcessById(processId);
            if (process != null)
            {
                m_ReadProcess = process;
                Open();
            }
            else
            {
                throw new Exception("Process does not exist");
            }
            
        }

        public void Close()
        {
            if (MemoryAPI.CloseHandle(m_hProcess) == 0)
                throw new Exception("Failed to close process");
        }

        public void BringToFront()
        {
            MemoryAPI.SetForegroundWindow(m_ReadProcess.MainWindowHandle);
        }
        public void SendMessage(MessageType message, int wParam, int lword, int hword)
        {
            SendMessage(message, wParam, ((hword << 16) | (lword & 0xFFFF)));
        }

        public void SendMessage(MessageType message, int wParam, int lParam)
        {
            MemoryAPI.SendMessage(m_ReadProcess.MainWindowHandle, (int)message, wParam, lParam);
        }

        public void SendKeyDown(Key key)
        {
            SendMessage(MessageType.KEYDOWN, (int)key, 0);
        }
        public void SendKeyUp(Key key)
        {
            SendMessage(MessageType.KEYUP, (int)key, 0);
        }

        #region Read_Raw
        public Double ReadDouble(IntPtr address)
        {
            int bytesRead = 0;
            return BitConverter.ToDouble(Read(address, 8, out bytesRead), 0);
        }
        public Single ReadFloat(IntPtr address)
        {
            int bytesRead = 0;
            return BitConverter.ToSingle(Read(address, 4, out bytesRead), 0);
        }
        public Int16 ReadInt16(IntPtr address)
        {
            int bytesRead = 0;
            return BitConverter.ToInt16(Read(address, 2, out bytesRead), 0);
        }
        public Int32 ReadInt32(IntPtr address)
        {
            int bytesRead = 0;
            return BitConverter.ToInt32(Read(address, 4, out bytesRead), 0);
        }
        public Int64 ReadInt64(IntPtr address)
        {
            int bytesRead = 0;
            return BitConverter.ToInt64(Read(address, 8, out bytesRead), 0);
        }
        public String ReadString(IntPtr address, uint length)
        {
            int bytesRead = 0;
            return BitConverter.ToString(Read(address, length, out bytesRead));
        }
        public UInt16 ReadUInt16(IntPtr address)
        {
            int bytesRead = 0;
            return BitConverter.ToUInt16(Read(address, 2, out bytesRead), 0);
        }
        public UInt32 ReadUInt32(IntPtr address)
        {
            int bytesRead = 0;
            return BitConverter.ToUInt32(Read(address, 4, out bytesRead), 0);
        }
        public UInt64 ReadUInt64(IntPtr address)
        {
            int bytesRead = 0;
            return BitConverter.ToUInt64(Read(address, 8, out bytesRead), 0);
        }

        public byte[] Read(IntPtr address, uint count, out int bytesRead)
        {
            byte[] buffer = new byte[count];
            IntPtr lpBytesRead;
            MemoryAPI.ReadProcessMemory(m_hProcess, address, buffer, count, out lpBytesRead);
            bytesRead = lpBytesRead.ToInt32();
            return buffer;
        }
        #endregion
        #region Read_Pointers
        public Double PointerReadDouble(IntPtr address, int[] offset)
        {
            int bytesRead = 0;
            return BitConverter.ToDouble(PointerRead(address, 8, offset, out bytesRead), 0);
        }
        public Single PointerReadFloat(IntPtr address, int[] offset)
        {
            int bytesRead = 0;
            return BitConverter.ToSingle(PointerRead(address, 4, offset, out bytesRead), 0);
        }
        public Int16 PointerReadInt16(IntPtr address, int[] offset)
        {
            int bytesRead = 0;
            return BitConverter.ToInt16(PointerRead(address, 2, offset, out bytesRead), 0);
        }
        public Int32 PointerReadInt32(IntPtr address, int[] offset)
        {
            int bytesRead = 0;
            return BitConverter.ToInt32(PointerRead(address, 4, offset, out bytesRead), 0);
        }
        public Int64 PointerReadInt64(IntPtr address, int[] offset)
        {
            int bytesRead = 0;
            return BitConverter.ToInt64(PointerRead(address, 8, offset, out bytesRead), 0);
        }
        public UInt16 PointerReadUInt16(IntPtr address, int[] offset)
        {
            int bytesRead = 0;
            return BitConverter.ToUInt16(PointerRead(address, 2, offset, out bytesRead), 0);
        }
        public UInt32 PointerReadUInt32(IntPtr address, int[] offset)
        {
            int bytesRead = 0;
            return BitConverter.ToUInt32(PointerRead(address, 4, offset, out bytesRead), 0);
        }
        public UInt64 PointerReadUInt64(IntPtr address, int[] offset)
        {
            int bytesRead = 0;
            return BitConverter.ToUInt64(PointerRead(address, 8, offset, out bytesRead), 0);
        }

        public byte[] PointerRead(IntPtr address, uint count, int[] offset, out int bytesRead)
        {
            int pointerSize = IntPtr.Size;
            bytesRead = 0;
            byte[] pointerBuffer = new byte[pointerSize];
            IntPtr tempAddress = address;

            for (int i = 0; i < offset.Length; i++)
            {
                int currentOffset = offset[i];
                IntPtr currentAddress = IntPtr.Zero;
                if (pointerSize == 4) //32 bits, most cases
                {
                    currentAddress = (IntPtr)ReadInt32(tempAddress);
                }
                else if (pointerSize == 8)
                {
                    currentAddress = (IntPtr)ReadInt64(tempAddress);
                }
                else
                {
                    throw new Exception("Unrecognized Pointer Length");
                }
                String currentAddressH = String.Format("{0:X}", (Int32)currentAddress);
                String currentOffsetH = String.Format("{0:X}", (Int32)currentOffset);
                IntPtr nextAddress = currentAddress + currentOffset;
                String NextAddressH = String.Format("{0:X}", (Int32)(nextAddress));
                tempAddress = currentAddress + currentOffset;
                String debug = String.Format("{0:X}", (Int32)tempAddress);
            }
            return Read(tempAddress, count, out bytesRead);

            /*OLD:
            int pointerCount = offset.Length - 1;
            IntPtr lpBytesRead;
            bytesRead = 0;
            byte[] buffer = new byte[4];
            int tempAddress = 0;

            if (pointerCount == 0)
            {
                MemoryAPI.ReadProcessMemory(m_hProcess, address, buffer, 4, out lpBytesRead);
                tempAddress = Address.ToDecimal(Address.Make(buffer)) + offset[0];

                buffer = new byte[count];
                MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, count, out lpBytesRead);

                bytesRead = lpBytesRead.ToInt32();
                return buffer;
            }

            for (int i = 0; i <= pointerCount; i++)
            {
                if (i == pointerCount)
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out lpBytesRead);
                    tempAddress = Address.ToDecimal(Address.Make(buffer)) + offset[i];

                    buffer = new byte[count];
                    MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, count, out lpBytesRead);

                    bytesRead = lpBytesRead.ToInt32();
                    return buffer;
                }
                else if (i == 0)
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, address, buffer, 4, out lpBytesRead);
                    tempAddress = Address.ToDecimal(Address.Make(buffer)) + offset[i];
                }
                else
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out lpBytesRead);
                    tempAddress = Address.ToDecimal(Address.Make(buffer)) + offset[i];
                }
            }
            return buffer;
             * */
        }
        #endregion

        #region EasyReads
        public MultiType ReadValue(IntPtr address)
        {
            return new MultiType(ReadDouble(address), ReadFloat(address), ReadInt16(address), ReadInt32(address), ReadInt64(address), ReadUInt16(address), ReadUInt32(address), ReadUInt64(address));
        }
        public MultiType PointerReadValue(IntPtr address, int[] offset)
        {
            return new MultiType(PointerReadDouble(address, offset), PointerReadFloat(address, offset), PointerReadInt16(address, offset), PointerReadInt32(address, offset), PointerReadInt64(address, offset), PointerReadUInt16(address, offset), PointerReadUInt32(address, offset), PointerReadUInt64(address, offset));
        }
        #endregion

        #region Write_Raw
        public void WriteDouble(IntPtr address, Double value)
        {
            int bytesWritten = 0;
            Write(address, BitConverter.GetBytes(value), out bytesWritten);
        }
        public void WriteFloat(IntPtr address, Single value)
        {
            int bytesWritten = 0;
            Write(address, BitConverter.GetBytes(value), out bytesWritten);
        }
        public void WriteInt16(IntPtr address, Int16 value)
        {
            int bytesWritten = 0;
            Write(address, BitConverter.GetBytes(value), out bytesWritten);
        }
        public void WriteInt32(IntPtr address, Int32 value)
        {
            int bytesWritten = 0;
            Write(address, BitConverter.GetBytes(value), out bytesWritten);
        }
        public void WriteInt64(IntPtr address, Int64 value)
        {
            int bytesWritten = 0;
            Write(address, BitConverter.GetBytes(value), out bytesWritten);
        }
        public void WriteUInt16(IntPtr address, UInt16 value)
        {
            int bytesWritten = 0;
            Write(address, BitConverter.GetBytes(value), out bytesWritten);
        }
        public void WriteUInt32(IntPtr address, UInt32 value)
        {
            int bytesWritten = 0;
            Write(address, BitConverter.GetBytes(value), out bytesWritten);
        }
        public void WriteUInt64(IntPtr address, UInt64 value)
        {
            int bytesWritten = 0;
            Write(address, BitConverter.GetBytes(value), out bytesWritten);
        }

        public void Write(IntPtr address, byte[] buffer, out int bytesWritten)
        {
            IntPtr lpBytesWritten;
            MemoryAPI.WriteProcessMemory(m_hProcess, address, buffer, (uint)buffer.Length, out lpBytesWritten);
            bytesWritten = lpBytesWritten.ToInt32();
        }
        #endregion
        #region Write_Pointers
        public void PointerWriteDouble(IntPtr address, int[] offset, Double value)
        {
            int bytesWritten = 0;
            PointerWrite(address, BitConverter.GetBytes(value), offset, out bytesWritten);
        }
        public void PointerWriteFloat(IntPtr address, int[] offset, Single value)
        {
            int bytesWritten = 0;
            PointerWrite(address, BitConverter.GetBytes(value), offset, out bytesWritten);
        }
        public void PointerWriteInt16(IntPtr address, int[] offset, Int16 value)
        {
            int bytesWritten = 0;
            PointerWrite(address, BitConverter.GetBytes(value), offset, out bytesWritten);
        }
        public void PointerWriteInt32(IntPtr address, int[] offset, Int32 value)
        {
            int bytesWritten = 0;
            PointerWrite(address, BitConverter.GetBytes(value), offset, out bytesWritten);
        }
        public void PointerWriteInt64(IntPtr address, int[] offset, Int64 value)
        {
            int bytesWritten = 0;
            PointerWrite(address, BitConverter.GetBytes(value), offset, out bytesWritten);
        }
        public void PointerWriteUInt16(IntPtr address, int[] offset, UInt16 value)
        {
            int bytesWritten = 0;
            PointerWrite(address, BitConverter.GetBytes(value), offset, out bytesWritten);
        }
        public void PointerWriteUInt32(IntPtr address, int[] offset, UInt32 value)
        {
            int bytesWritten = 0;
            PointerWrite(address, BitConverter.GetBytes(value), offset, out bytesWritten);
        }
        public void PointerWriteUInt64(IntPtr address, int[] offset, UInt64 value)
        {
            int bytesWritten = 0;
            PointerWrite(address, BitConverter.GetBytes(value), offset, out bytesWritten);
        }

        public int PointerWrite(IntPtr address, byte[] writeBuffer, int[] offset, out int bytesWritten)
        {
            int pointerCount = offset.Length - 1;
            IntPtr lpBytesWritten;
            bytesWritten = 0;
            byte[] buffer = new byte[4];
            int tempAddress = 0;

            if (pointerCount == 0)
            {
                MemoryAPI.ReadProcessMemory(m_hProcess, address, buffer, 4, out lpBytesWritten);
                tempAddress = Address.ToDecimal(Address.Make(buffer)) + offset[0];
                MemoryAPI.WriteProcessMemory(m_hProcess, (IntPtr)tempAddress, writeBuffer, (uint)writeBuffer.Length, out lpBytesWritten);

                bytesWritten = lpBytesWritten.ToInt32();
                return tempAddress;
            }

            for(int i = 0; i <= pointerCount; i++)
            {
                if(i == pointerCount)
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out lpBytesWritten);
                    tempAddress = Address.ToDecimal(Address.Make(buffer)) + offset[i];
                    MemoryAPI.WriteProcessMemory(m_hProcess, (IntPtr)tempAddress, writeBuffer, (uint)writeBuffer.Length, out lpBytesWritten);

                    bytesWritten = lpBytesWritten.ToInt32();
                    return tempAddress;
                }
                else if(i == 0)
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, address, buffer, 4, out lpBytesWritten);
                    tempAddress = Address.ToDecimal(Address.Make(buffer)) + offset[i];
                }
                else
                {
                    MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)address, buffer, 4, out lpBytesWritten);
                    tempAddress = Address.ToDecimal(Address.Make(buffer)) + offset[i];
                }
            }
            return tempAddress;
        }
        #endregion

        #region EasyWrites
        public void WriteValue(IntPtr address, Double value)
        {
            WriteDouble(address, value);
        }
        public void WriteValue(IntPtr address, Single value)
        {
            WriteFloat(address, value);
        }
        public void WriteValue(IntPtr address, Int16 value)
        {
            WriteInt16(address, value);
        }
        public void WriteValue(IntPtr address, Int32 value)
        {
            WriteInt32(address, value);
        }
        public void WriteValue(IntPtr address, Int64 value)
        {
            WriteInt64(address, value);
        }
        public void WriteValue(IntPtr address, UInt16 value)
        {
            WriteUInt16(address, value);
        }
        public void WriteValue(IntPtr address, UInt32 value)
        {
            WriteUInt32(address, value);
        }
        public void WriteValue(IntPtr address, UInt64 value)
        {
            WriteUInt64(address, value);
        }

        public void PointerWriteValue(IntPtr address, int[] offset, Double value)
        {
            PointerWriteDouble(address, offset, value);
        }
        public void PointerWriteValue(IntPtr address, int[] offset, Single value)
        {
            PointerWriteFloat(address, offset, value);
        }
        public void PointerWriteValue(IntPtr address, int[] offset, Int16 value)
        {
            PointerWriteInt16(address, offset, value);
        }
        public void PointerWriteValue(IntPtr address, int[] offset, Int32 value)
        {
            PointerWriteInt32(address, offset, value);
        }
        public void PointerWriteValue(IntPtr address, int[] offset, Int64 value)
        {
            PointerWriteInt64(address, offset, value);
        }
        public void PointerWriteValue(IntPtr address, int[] offset, UInt16 value)
        {
            PointerWriteUInt16(address, offset, value);
        }
        public void PointerWriteValue(IntPtr address, int[] offset, UInt32 value)
        {
            PointerWriteUInt32(address, offset, value);
        }
        public void PointerWriteValue(IntPtr address, int[] offset, UInt64 value)
        {
            PointerWriteUInt64(address, offset, value);
        }
        #endregion


    }
}
