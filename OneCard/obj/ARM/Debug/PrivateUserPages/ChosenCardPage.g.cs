﻿#pragma checksum "C:\Users\jonathan\Documents\GitHub\OneCard\OneCard\PrivateUserPages\ChosenCardPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8DDF17993445512167555FA41E6D0A39"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OneCard.PrivateUserPages
{
    partial class ChosenCardPage : 
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
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        private class ChosenCardPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IChosenCardPage_Bindings
        {
            private global::OneCard.PrivateUserPages.ChosenCardPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj13;
            private global::Windows.UI.Xaml.Controls.TextBlock obj14;
            private global::Windows.UI.Xaml.Controls.TextBlock obj15;
            private global::Windows.UI.Xaml.Controls.TextBlock obj16;
            private global::Windows.UI.Xaml.Controls.Image obj18;
            private global::Windows.UI.Xaml.Controls.TextBlock obj19;

            public ChosenCardPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9:
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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
                    case 18:
                        this.obj18 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 19:
                        this.obj19 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IChosenCardPage_Bindings

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

            // ChosenCardPage_obj1_Bindings

            public void SetDataRoot(global::OneCard.PrivateUserPages.ChosenCardPage newDataRoot)
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
            private void Update_(global::OneCard.PrivateUserPages.ChosenCardPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FullSelectedCard(obj.FullSelectedCard, phase);
                    }
                }
            }
            private void Update_FullSelectedCard(global::OneCard.FullCard obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FullSelectedCard_businessInfo(obj.businessInfo, phase);
                        this.Update_FullSelectedCard_subscriptionInfo(obj.subscriptionInfo, phase);
                        this.Update_FullSelectedCard_demoLogo(obj.demoLogo, phase);
                        this.Update_FullSelectedCard_name(obj.name, phase);
                    }
                }
            }
            private void Update_FullSelectedCard_businessInfo(global::OneCard.BusinessInfo obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FullSelectedCard_businessInfo_offersAndSales(obj.offersAndSales, phase);
                        this.Update_FullSelectedCard_businessInfo_openingHours(obj.openingHours, phase);
                        this.Update_FullSelectedCard_businessInfo_contactInfo(obj.contactInfo, phase);
                    }
                }
            }
            private void Update_FullSelectedCard_businessInfo_offersAndSales(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                }
            }
            private void Update_FullSelectedCard_businessInfo_openingHours(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                }
            }
            private void Update_FullSelectedCard_businessInfo_contactInfo(global::OneCard.ContactInfo obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FullSelectedCard_businessInfo_contactInfo_address(obj.address, phase);
                        this.Update_FullSelectedCard_businessInfo_contactInfo_country(obj.country, phase);
                        this.Update_FullSelectedCard_businessInfo_contactInfo_email(obj.email, phase);
                        this.Update_FullSelectedCard_businessInfo_contactInfo_contactNumber(obj.contactNumber, phase);
                    }
                }
            }
            private void Update_FullSelectedCard_businessInfo_contactInfo_address(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, (global::System.String)this.LookupConverter("AddressStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_FullSelectedCard_businessInfo_contactInfo_country(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, (global::System.String)this.LookupConverter("CountryStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_FullSelectedCard_businessInfo_contactInfo_email(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, (global::System.String)this.LookupConverter("EmailStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_FullSelectedCard_businessInfo_contactInfo_contactNumber(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, (global::System.String)this.LookupConverter("NumberStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_FullSelectedCard_subscriptionInfo(global::OneCard.SubscriptionInfo obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FullSelectedCard_subscriptionInfo_description(obj.description, phase);
                        this.Update_FullSelectedCard_subscriptionInfo_type(obj.type, phase);
                        this.Update_FullSelectedCard_subscriptionInfo_expiryDate(obj.expiryDate, phase);
                        this.Update_FullSelectedCard_subscriptionInfo_lastUse(obj.lastUse, phase);
                        this.Update_FullSelectedCard_subscriptionInfo_TagsInUseOfAllowed(obj.TagsInUseOfAllowed, phase);
                    }
                }
            }
            private void Update_FullSelectedCard_subscriptionInfo_description(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj, null);
                }
            }
            private void Update_FullSelectedCard_subscriptionInfo_type(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj13, (global::System.String)this.LookupConverter("TypeStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_FullSelectedCard_subscriptionInfo_expiryDate(global::System.DateTime obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj14, (global::System.String)this.LookupConverter("ExpiryStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_FullSelectedCard_subscriptionInfo_lastUse(global::System.DateTime obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj15, (global::System.String)this.LookupConverter("LastUseStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_FullSelectedCard_subscriptionInfo_TagsInUseOfAllowed(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj16, (global::System.String)this.LookupConverter("TagsStringFormatConverter").Convert(obj, typeof(global::System.String), null, null), null);
                }
            }
            private void Update_FullSelectedCard_demoLogo(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj18, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_FullSelectedCard_name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj19, obj, null);
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
                    #line 78 "..\..\..\PrivateUserPages\ChosenCardPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.AddLocationClicked;
                    #line default
                }
                break;
            case 3:
                {
                    this.identificationDemendComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 10:
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 47 "..\..\..\PrivateUserPages\ChosenCardPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.DirectWriteClicked;
                    #line default
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 52 "..\..\..\PrivateUserPages\ChosenCardPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.TagWriteClicked;
                    #line default
                }
                break;
            case 17:
                {
                    this.favoriteImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 23 "..\..\..\PrivateUserPages\ChosenCardPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.favoriteImage).Loaded += this.FavoriteLoaded;
                    #line 23 "..\..\..\PrivateUserPages\ChosenCardPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.favoriteImage).Tapped += this.FavoriteStatusChangeTapped;
                    #line default
                }
                break;
            case 18:
                {
                    this.businessImage = (global::Windows.UI.Xaml.Controls.Image)(target);
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
                    ChosenCardPage_obj1_Bindings bindings = new ChosenCardPage_obj1_Bindings();
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

