#include "pch.h"
#include<vector>
#include <fstream>
#include "Injector.h"

#define MAX_ITEMS 100
//EXTERN_DLL_EXPORT const char*

std::vector<const char*> LoadUserSettings() {

	std::vector<const char*> ListArr;
	int ItemIndex = 0;

	std::fstream input("Settings.ini");
	for (std::string line; std::getline(input, line); )
	{
		if (!line.empty()) {
			ListArr[ItemIndex] = line.c_str();
			++ItemIndex;
		}
	}
	return ListArr;
}