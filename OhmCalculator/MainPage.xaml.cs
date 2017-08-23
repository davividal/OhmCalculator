using OhmCalculator.Domain.Services;
using OhmCalculator.Domain.ValueObjects;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace OhmCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Int16 VoltageMagnitude;
        private Int16 ResistanceMagnitude;
        private Int16 CurrentMagnitude;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Toggle(ToggleButton press, ToggleButton o1, ToggleButton o2)
        {
            if (press.IsChecked == false)
            {
                press.IsChecked = true;
                return;
            }
            
            o1.IsChecked = false;
            o2.IsChecked = false;
        }

        private void VToggle_Click(object sender, RoutedEventArgs e)
        {
            Toggle((ToggleButton)sender, mVToggle, kVToggle);
            this.VoltageMagnitude = (Int16)Unit.Magnitude.UNIT;
        }

        private void kVToggle_Click(object sender, RoutedEventArgs e)
        {
            Toggle((ToggleButton)sender, mVToggle, VToggle);
            this.VoltageMagnitude = (Int16)Unit.Magnitude.KILO;
        }

        private void mVToggle_Click(object sender, RoutedEventArgs e)
        {
            Toggle((ToggleButton)sender, VToggle, kVToggle);
            this.VoltageMagnitude = (Int16)Unit.Magnitude.MILI;
        }

        private void OToggle_Click(object sender, RoutedEventArgs e)
        {
            Toggle((ToggleButton)sender, kOToggle, MOToggle);
            this.ResistanceMagnitude = (Int16)Unit.Magnitude.UNIT;
        }

        private void kOToggle_Click(object sender, RoutedEventArgs e)
        {
            Toggle((ToggleButton)sender, OToggle, MOToggle);
            this.ResistanceMagnitude = (Int16)Unit.Magnitude.KILO;
        }

        private void MOToggle_Click(object sender, RoutedEventArgs e)
        {
            Toggle((ToggleButton)sender, OToggle, kOToggle);
            this.ResistanceMagnitude = (Int16)Unit.Magnitude.MEGA;
        }

        private void nAToggle_Click(object sender, RoutedEventArgs e)
        {
            Toggle((ToggleButton)sender, uAToggle, mAToggle);
            this.CurrentMagnitude = (Int16)Unit.Magnitude.NANO;
        }

        private void uAToggle_Click(object sender, RoutedEventArgs e)
        {
            Toggle((ToggleButton)sender, nAToggle, mAToggle);
            this.CurrentMagnitude = (Int16)Unit.Magnitude.MICRO;
        }

        private void mAToggle_Click(object sender, RoutedEventArgs e)
        {
            Toggle((ToggleButton)sender, uAToggle, nAToggle);
            this.CurrentMagnitude = (Int16)Unit.Magnitude.MILI;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            mAToggle_Click(mAToggle, new RoutedEventArgs());
            kOToggle_Click(kOToggle, new RoutedEventArgs());
            VToggle_Click(VToggle, new RoutedEventArgs());
        }

        private void CalculateVoltage_Click(object sender, RoutedEventArgs e)
        {
            CalculateVoltage ohm = new CalculateVoltage()
            {
                r = new Resistance(Resistance.Text, ResistanceMagnitude),
                i = new Current(Current.Text, CurrentMagnitude)
            };
            Voltage.Text = ohm.GetVoltageByResistanceAndCurrent();
        }

        private void CalculateResistance_Click(object sender, RoutedEventArgs e)
        {
            CalculateResistance ohm = new CalculateResistance()
            {
                v = new Voltage(Voltage.Text, VoltageMagnitude),
                i = new Current(Current.Text, CurrentMagnitude)
            };
            Resistance.Text = ohm.GetResistanceByVoltageAndCurrent();
        }

        private void CalculateCurrent_Click(object sender, RoutedEventArgs e)
        {
            CalculateCurrent ohm = new CalculateCurrent()
            {
                v = new Voltage(Voltage.Text, VoltageMagnitude),
                r = new Resistance(Resistance.Text, ResistanceMagnitude)
            };
            Current.Text = ohm.GetCurrentByVoltageAndResistance();
        }
    }
}
