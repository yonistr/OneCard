﻿#pragma checksum "C:\Users\jonathan\Documents\GitHub\OneCard\OneCard\MainOneCardPages\JoinPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6E491015E02EA35F7836ABCA7FDA232D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneCard
{
    partial class JoinPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.join_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\MainOneCardPages\JoinPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.join_button).Click += this.join_Button_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.sign_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\MainOneCardPages\JoinPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.sign_button).Click += this.sign_Button_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.business_join_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\MainOneCardPages\JoinPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.business_join_button).Click += this.businessJoin_Button_click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

