﻿#pragma checksum "..\..\Update.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D9B256501F7FEB612B329C06D2B8BF2BE29DB73C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using TP_Feugere_Adipietro_Garrach;


namespace TP_Feugere_Adipietro_Garrach {
    
    
    /// <summary>
    /// Update
    /// </summary>
    public partial class Update : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid PanelUpdate;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxNom;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPrenom;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxAdresse;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxTelephone;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAnnuler;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonUpdate;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxVille;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxEtat;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPays;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelAjouter;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Update.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelMessage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/View;component/update.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Update.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.PanelUpdate = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TextBoxNom = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\Update.xaml"
            this.TextBoxNom.GotFocus += new System.Windows.RoutedEventHandler(this.TextBoxNom_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBoxPrenom = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\Update.xaml"
            this.TextBoxPrenom.GotFocus += new System.Windows.RoutedEventHandler(this.TextBoxPrenom_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBoxAdresse = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\Update.xaml"
            this.TextBoxAdresse.GotFocus += new System.Windows.RoutedEventHandler(this.TextBoxAdresse_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TextBoxTelephone = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\Update.xaml"
            this.TextBoxTelephone.GotFocus += new System.Windows.RoutedEventHandler(this.TextBoxTelephone_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonAnnuler = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\Update.xaml"
            this.ButtonAnnuler.Click += new System.Windows.RoutedEventHandler(this.ButtonAnnuler_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\Update.xaml"
            this.ButtonUpdate.Click += new System.Windows.RoutedEventHandler(this.ButtonUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TextBoxVille = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\Update.xaml"
            this.TextBoxVille.GotFocus += new System.Windows.RoutedEventHandler(this.TextBoxVille_GotFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TextBoxEtat = ((System.Windows.Controls.TextBox)(target));
            
            #line 52 "..\..\Update.xaml"
            this.TextBoxEtat.GotFocus += new System.Windows.RoutedEventHandler(this.TextBoxEtat_GotFocus);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TextBoxPays = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\Update.xaml"
            this.TextBoxPays.GotFocus += new System.Windows.RoutedEventHandler(this.TextBoxPays_GotFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.labelAjouter = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.labelMessage = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

