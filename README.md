# Visual-Basic-Windows
Visual Basic .NET创建窗口
Imports System.Windows.Forms：导入命名空间System.Windows.Forms，其中包含创建窗口应用程序所需的类和方法。
Public Class Form1 Inherits Form：定义一个名为Form1的公共类，并使其继承自Form类。这将创建一个窗体类。
Public Sub New()：定义Form1类的构造函数。这个函数在创建Form1类的新实例时被调用。
Me.Text = "黄文定的窗口"：将窗体的标题设置为"黄文定的窗口"。
Dim label As New Label()：创建一个名为label的新Label对象。Label是一个用于显示文本的控件。
label.Text = "Hello, HuangWending"：将label控件的文本属性设置为"Hello, HuangWending"，即要显示的文本内容。
Me.Controls.Add(label)：将label控件添加到窗体的控件集合中，以便在窗体中显示它。
Public Shared Sub Main()：定义一个名为Main的公共静态方法，它将作为程序的入口点。
Application.Run(New Form1())：运行应用程序并创建一个新的Form1窗体实例作为主窗体。
