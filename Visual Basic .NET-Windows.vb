Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Public Sub New()
        Me.Text = "黄文定的窗口" ' 设置窗口标题为"黄文定的窗口"
        Dim label As New Label() ' 创建一个标签控件
        label.Text = "Hello, HuangWending" ' 设置标签控件显示的文本为"Hello, HuangWending"
        Me.Controls.Add(label) ' 将标签控件添加到窗口中
    End Sub

    Public Shared Sub Main()
        Application.Run(New Form1()) ' 运行窗口应用程序
    End Sub
End Class
