﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageNavigation1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulePage : ContentPage
    {
        public SchedulePage()
        {
            InitializeComponent();
        }
        async void OnUpcomingAppointmentsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpcomingAppointmentsPage());
        }
    }
}