using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

public class Injector
{
    //[DllImport(@"C:\\Users\Ege\\Documents\\GitHub\\JADI\\JADI\\Release\\JADEditorLib.dll", CallingConvention = CallingConvention.Cdecl)]
    [DllImport("JADEditorLib.dll", CallingConvention = CallingConvention.Cdecl)]
    internal static extern int CreateProcessWithDll(string ExeName, string ExeDir, string DllDir, bool IsSuspended);

    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool CloseHandle(IntPtr hHandle);

    [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
    static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

    [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
    static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress,
        uint dwSize, uint flAllocationType, uint flProtect);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

    [DllImport("kernel32.dll")]
    static extern IntPtr CreateRemoteThread(IntPtr hProcess,
        IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);

    [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
    static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, uint nSize, UInt32 dwFreeType);

    const int PROCESS_CREATE_THREAD         = 0x0002;
    const int PROCESS_QUERY_INFORMATION     = 0x0400;
    const int PROCESS_VM_OPERATION          = 0x0008;
    const int PROCESS_VM_WRITE              = 0x0020;
    const int PROCESS_VM_READ               = 0x0010;
    const uint MEM_COMMIT                   = 0x00001000;
    const uint MEM_RESERVE                  = 0x00002000;
    const uint PAGE_READWRITE               = 4;
    const uint INFINITE                     = 0xFFFFFFFF;
    const uint MEM_RELEASE                  = 0x00008000;
    const uint MEM_DECOMMIT                 = 0x00004000;

    public static bool DllInject(string ProcessName, string DllName)
    {
        Process targetProcess = Process.GetProcessesByName(ProcessName)[0];

        IntPtr procHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, targetProcess.Id);
        IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

        IntPtr allocMemAddress = VirtualAllocEx(procHandle, IntPtr.Zero, (uint)((DllName.Length + 1) * Marshal.SizeOf(typeof(char))), MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);

        UIntPtr bytesWritten;
        WriteProcessMemory(procHandle, allocMemAddress, System.Text.Encoding.Default.GetBytes(DllName), (uint)((DllName.Length + 1) * Marshal.SizeOf(typeof(char))), out bytesWritten);

        IntPtr hLoadThread = CreateRemoteThread(procHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);

        //WaitForSingleObject(hLoadThread, INFINITE);
        VirtualFreeEx(procHandle, allocMemAddress, (uint)((DllName.Length + 1) * Marshal.SizeOf(typeof(char))), MEM_RELEASE);
        CloseHandle(procHandle);

        return true;
    }

    public static bool DllEject(string ProcessName, string DllName)
    {
        Process targetProcess = Process.GetProcessesByName(ProcessName)[0];

        IntPtr procHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, targetProcess.Id);
        IntPtr ModuleHandle = GetModuleHandle(Path.GetFileNameWithoutExtension(DllName));

        IntPtr loc = VirtualAllocEx(procHandle, IntPtr.Zero, 4, MEM_COMMIT | MEM_RESERVE, PAGE_READWRITE);
        UIntPtr bytesWritten;
        WriteProcessMemory(procHandle, loc, System.Text.Encoding.Default.GetBytes(DllName), (uint)((DllName.Length + 1) * Marshal.SizeOf(typeof(char))), out bytesWritten);

        IntPtr MethodAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "FreeLibrary");

        IntPtr hThread = CreateRemoteThread(procHandle, IntPtr.Zero, 0, MethodAddr, ModuleHandle, 0, IntPtr.Zero);
        WaitForSingleObject(hThread, INFINITE);
        CloseHandle(procHandle);

        return true;
    }
}