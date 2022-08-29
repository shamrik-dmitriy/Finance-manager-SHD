﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using FM.SHDML.Core.Models.Dtos.UIDto;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace FM.SHD.Settings.Services
{
    public class SettingServices<T> where T : ISettingsServices
    {
        private readonly T _settings;
        private SettingsWriter<T> _writer;
        private SettingsReader<T> _reader;

        public SettingServices(T settings)
        {
            _settings = settings;
            
            _writer = new SettingsWriter<T>(_settings);
            _reader = new SettingsReader<T>(_settings);

            if (!File.Exists(_settings.Path))
                _writer.WriteSettings();

            var readSettings = _reader.ReadSettings();
            _settings.SetSettings(readSettings);
        }

        public void Save()
        {
            _writer.WriteSettings();
        }

        public T Extract()
        {
            return _settings;
        }
    }
}