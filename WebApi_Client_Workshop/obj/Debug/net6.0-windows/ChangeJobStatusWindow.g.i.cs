// Updated by XamlIntelliSenseFileGenerator 2022. 06. 05. 15:09:11
#pragma checksum "..\..\..\ChangeJobStatusWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E17E53E60236EC4FD17EF3A3E4DD08CCCA151273"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WebApi_Client_Workshop;


namespace WebApi_Client_Workshop
{


    /// <summary>
    /// ChangeJobStatusWindow
    /// </summary>
    public partial class ChangeJobStatusWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 15 "..\..\..\ChangeJobStatusWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border WindowBorder;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WebApi_Client_Workshop;component/changejobstatuswindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\ChangeJobStatusWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.WindowBorder = ((System.Windows.Controls.Border)(target));

#line 20 "..\..\..\ChangeJobStatusWindow.xaml"
                    this.WindowBorder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowBorder_MouseDown);

#line default
#line hidden
                    return;
                case 2:

#line 36 "..\..\..\ChangeJobStatusWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.JobStatusNew_ButtonClick);

#line default
#line hidden
                    return;
                case 3:

#line 44 "..\..\..\ChangeJobStatusWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.JobStatusWorking_ButtonClick);

#line default
#line hidden
                    return;
                case 4:

#line 52 "..\..\..\ChangeJobStatusWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.JobStatusDone_ButtonClick);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button ExitButton;
    }
}

