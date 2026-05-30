How i did?
1. At first i found the alternative way for winforms in macOS, i.e. Avalonia
2. I installed the Avalonia Environment, which gives me a prepared app.
3. Then i wrote my GUI and replaced to the GUI of Avalonia like buttons for numbers, expression and clear.
4. After that i wrote the code for the functionality of GUI, where user can click the buttons and use the calculator.

Code to make environmet of Avalonia:
1. dotnet new install Avalonia.Template
2. dotnet new avalonia.app -o CalculatorApp
3. cd CalculatorApp
4. Code .
5. dotnet run

How to run?
1. You can find executable app for both macOS and Windows.
2. For macOS, you go to bin/Release/net10.0/CalculatorApp(run this)
3. For Windows, you can go to bin/Release/net10.0/win-x64/CalculatorApp.exe(run this)

Programs used:
1. CS
2. Avalonia
3. VS Code
