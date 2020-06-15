using PlumTest.Shared.Models;
using PlumTest.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace PlumTest.Shared.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ConversationView : Page
    {
        public ConversationViewModel ViewModel { get; set; }

        public ConversationView()
        {
            ViewModel = new ConversationViewModel();

            this.InitializeComponent();
        }

        private void ListConversations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedConversation = (sender as ListView).SelectedItem as IConversationModel;
            ViewModel.CurrentConversation = selectedConversation;
        }
    }
}
