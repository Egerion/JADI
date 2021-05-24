#include "pch.h"
#include "Injector.h"

EXTERN_DLL_EXPORT int CreateProcessWithDll(const char* ExeDir, const char* CurrentDir, const char* DllDir, bool IsSuspended) {

	STARTUPINFO si; PROCESS_INFORMATION pi;
	ZeroMemory(&si, sizeof(STARTUPINFO));
	ZeroMemory(&pi, sizeof(PROCESS_INFORMATION));
	
	if (IsSuspended) {
		if (!DetourCreateProcessWithDll(ExeDir, NULL, NULL, NULL, TRUE,
			CREATE_DEFAULT_ERROR_MODE | CREATE_SUSPENDED, NULL, CurrentDir, &si, &pi, DllDir, NULL)) {
			MessageBox(NULL, "Error Occured", "Process with Dll cannot be created...", MB_OK | MB_ICONHAND);
			return EXIT_FAILURE;
		}
		ResumeThread(pi.hThread);
		WaitForSingleObject(pi.hProcess, INFINITE);
		CloseHandle(&si);
		CloseHandle(&pi);
	}
	else {
		if (!DetourCreateProcessWithDll(ExeDir, NULL, NULL, NULL, TRUE,
			CREATE_DEFAULT_ERROR_MODE, NULL, CurrentDir, &si, &pi, DllDir, NULL)) {
			MessageBox(NULL, "Error Occured", "Process with Dll cannot be created...", MB_OK | MB_ICONHAND);
			return EXIT_FAILURE;
		}
	}
	return EXIT_SUCCESS;
}