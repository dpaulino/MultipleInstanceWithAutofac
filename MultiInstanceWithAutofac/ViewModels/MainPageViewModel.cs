﻿using MultiInstanceWithAutofac.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInstanceWithAutofac.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly IIncrementService _service;

        public MainPageViewModel(IIncrementService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public int Count { get; set; }


        public void Increment()
        {
            Count = _service.Increment(Count);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
        }
    }
}
