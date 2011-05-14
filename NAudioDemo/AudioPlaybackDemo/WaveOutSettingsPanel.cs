﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave;

namespace NAudioDemo.AudioPlaybackDemo
{
    public partial class WaveOutSettingsPanel : UserControl
    {
        public WaveOutSettingsPanel()
        {
            InitializeComponent();
            InitialiseWaveOutControls();
        }

        private void InitialiseWaveOutControls()
        {
            for (int deviceId = 0; deviceId < WaveOut.DeviceCount; deviceId++)
            {
                var capabilities = WaveOut.GetCapabilities(deviceId);
                comboBoxWaveOutDevice.Items.Add(String.Format("Device {0} ({1})", deviceId, capabilities.ProductName));
            }
            if (comboBoxWaveOutDevice.Items.Count > 0)
            {
                comboBoxWaveOutDevice.SelectedIndex = 0;
            }
        }

        public int SelectedDeviceNumber { get { return comboBoxWaveOutDevice.SelectedIndex; } }

        public bool UseWindowCallbacks { get { return checkBoxWaveOutWindow.Checked; } }
    }
}