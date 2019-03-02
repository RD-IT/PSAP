using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace PSAP.PSAPCommon
{
    class IconHelper
    {

        public static Icon GetIcon(string path)
        {
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr hImgLarge = Win32.SHGetFileInfo(path, 0,
            ref shinfo, (uint)Marshal.SizeOf(shinfo),
            Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);
            System.Drawing.Icon myIcon = System.Drawing.Icon.FromHandle(shinfo.hIcon);
            return myIcon;
        }


        public static string  GetTypeName(string path)
        {
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr hImgLarge = Win32.SHGetFileInfo(path, 0,
            ref shinfo, (uint)Marshal.SizeOf(shinfo),
            Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);
            return shinfo.dwAttributes.ToString();
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SHFILEINFO
    {
        public IntPtr hIcon;
        public IntPtr iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
        public string szTypeName;
    };

    class Win32
    {
        public const uint SHGFI_ICON = 0x100;
        public const uint SHGFI_LARGEICON = 0x0;    // Large icon
        public const uint SHGFI_SMALLICON = 0x1;    // Small icon

        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(string pszPath,
                                    uint dwFileAttributes,
                                    ref SHFILEINFO psfi,
                                    uint cbSizeFileInfo,
                                    uint uFlags);
    }
}
