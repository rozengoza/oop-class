using ConsoleAppForFundamentals;
using OOPFundamentals.FileHandling;

/*Linq.LearnLinq();*/

var fileHandler = new FileHandler();
var emps = fileHandler.ReadFile();
fileHandler.ReadFile();
fileHandler.WriteFile();
fileHandler.WriteEmployeesFile(emps);