﻿#pragma checksum "C:\Users\jonathan\Documents\GitHub\OneCard\OneCard\BusinessPages\ChosenCustomerPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "356DF15BACC1097B0CC338CE726F5BDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneCard.BusinessPages
{
    partial class ChosenCustomerPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Int32 value)
            {
                obj.SelectedIndex = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        private class ChosenCustomerPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IChosenCustomerPage_Bindings
        {
            private global::OneCard.BusinessPages.ChosenCustomerPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.TextBox obj5;
            private global::Windows.UI.Xaml.Controls.TextBox obj6;
            private global::Windows.UI.Xaml.Controls.ComboBox obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj13;
            private global::Windows.UI.Xaml.Controls.TextBlock obj14;
            private global::Windows.UI.Xaml.Controls.TextBlock obj15;
            private global::Windows.UI.Xaml.Controls.TextBlock obj16;
            private global::Windows.UI.Xaml.Controls.TextBlock obj17;
            private global::Windows.UI.Xaml.Controls.TextBlock obj18;
            private global::Windows.UI.Xaml.Controls.TextBlock obj19;
            private global::Windows.UI.Xaml.Controls.TextBlock obj20;
            private global::Windows.UI.Xaml.Controls.TextBlock obj21;
            private global::Windows.UI.Xaml.Controls.TextBlock obj22;
            private global::Windows.UI.Xaml.Controls.Image obj23;

            public ChosenCustomerPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    case 12:
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 13:
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 14:
                        this.obj14 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 15:
                        this.obj15 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 16:
                        this.obj16 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 17:
                        this.obj17 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 18:
                        this.obj18 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 19:
                        this.obj19 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 20:
                        this.obj20 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 21:
                        this.obj21 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 22:
                        this.obj22 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 23:
                        this.obj23 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            // IChosenCustomerPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // ChosenCustomerPage_obj1_Bindings

            public void SetDataRoot(global::OneCard.BusinessPages.ChosenCustomerPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::OneCard.BusinessPages.ChosenCustomerPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_DetailedSelectedCustomer(obj.DetailedSelectedCustomer, phase);
                    }
                }
            }
            private void Update_DetailedSelectedCustomer(global::OneCard.DetailedCustomer obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_DetailedSelectedCustomer_FullName(obj.FullName, phase);
                        this.Update_DetailedSelectedCustomer_subscriptionInfo(obj.subscriptionInfo, phase);
                        this.Update_DetailedSelectedCustomer_contactInfo(obj.contactInfo, phase);
                        this.Update_DetailedSelectedCustomer_userName(obj.userName, phase);
                        this.Update_DetailedSelectedCustomer_dateOfBirth(obj.dateOfBirth, phase);
                        this.Update_DetailedSelectedCustomer_demoLogo(obj.demoLogo, phase);
                    }
                }
            }
            private void Update_DetailedSelectedCustomer_FullName(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }
            private void Update_DetailedSelectedCustomer_subscriptionInfo(global::OneCard.SubscriptionInfo obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_DetailedSelectedCustomer_subscriptionInfo_description(obj.description, phase);
                        this.Update_DetailedSelectedCustomer_subscriptionInfo_type(obj.type, phase);
                        this.Update_DetailedSelectedCustomer_subscriptionInfo_TagsInUseOfAllowed(obj.TagsInUseOfAllowed, phase);
                        this.Update_DetailedSelectedCustomer_subscriptionInfo_expiryDate(obj.expiryDate, phase);
                        this.Update_DetailedSelectedCustomer_subscriptionInfo_lastUse(obj.lastUse, phase);
                    }
                }
            }
            private void Update_DetailedSelectedCustomer_subscriptionInfo_description(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj5, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj18, (global::System.String)this.LookupConverter("DescriptionStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_DetailedSelectedCustomer_subscriptionInfo_type(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj6, obj, null);
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj19, (global::System.String)this.LookupConverter("TypeStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_DetailedSelectedCustomer_subscriptionInfo_TagsInUseOfAllowed(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj8, (global::System.Int32) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Int32), obj));
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj22, (global::System.String)this.LookupConverter("TagsStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_DetailedSelectedCustomer_contactInfo(global::OneCard.ContactInfo obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_DetailedSelectedCustomer_contactInfo_address(obj.address, phase);
                        this.Update_DetailedSelectedCustomer_contactInfo_country(obj.country, phase);
                        this.Update_DetailedSelectedCustomer_contactInfo_email(obj.email, phase);
                        this.Update_DetailedSelectedCustomer_contactInfo_contactNumber(obj.contactNumber, phase);
                    }
                }
            }
            private void Update_DetailedSelectedCustomer_contactInfo_address(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, (global::System.String)this.LookupConverter("AddressStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_DetailedSelectedCustomer_contactInfo_country(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj13, (global::System.String)this.LookupConverter("CountryStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_DetailedSelectedCustomer_contactInfo_email(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj14, (global::System.String)this.LookupConverter("EmailStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_DetailedSelectedCustomer_contactInfo_contactNumber(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj15, (global::System.String)this.LookupConverter("NumberStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_DetailedSelectedCustomer_userName(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj16, (global::System.String)this.LookupConverter("UserStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_DetailedSelectedCustomer_dateOfBirth(global::System.DateTime obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj17, (global::System.String)this.LookupConverter("DobStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_DetailedSelectedCustomer_subscriptionInfo_expiryDate(global::System.DateTime obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj20, (global::System.String)this.LookupConverter("ExpiryStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_DetailedSelectedCustomer_subscriptionInfo_lastUse(global::System.DateTime obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj21, (global::System.String)this.LookupConverter("LastUseStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_DetailedSelectedCustomer_demoLogo(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj23, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 36 "..\..\..\BusinessPages\ChosenCustomerPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.ShowSplitSubscriptionEdit;
                    #line default
                }
                break;
            case 4:
                {
                    this.SubscriptionEditSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 5:
                {
                    this.DescriptionTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.TypeTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.ExpiryDateDatePicker = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                }
                break;
            case 8:
                {
                    this.AllowedTagsComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 125 "..\..\..\BusinessPages\ChosenCustomerPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.ApproveCahngesClicked;
                    #line default
                }
                break;
            case 10:
                {
                    this.CancelTagsCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 11:
                {
                    this.ResetLastUseCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 23:
                {
                    this.customerImage = (global::Windows.UI.Xaml.Controls.Image)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    ChosenCustomerPage_obj1_Bindings bindings = new ChosenCustomerPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

