using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia.CastErrorSample.ViewModels
{
    public class ChildViewModel : ReactiveObject
    {
        private string? stringProperty1;
        private string? stringProperty2;
        private double numberProperty1;
        private double numberProperty2;

        public string? StringProperty1 { get => stringProperty1; set => this.RaiseAndSetIfChanged(ref stringProperty1, value); }
        public string? StringProperty2 { get => stringProperty2; set => this.RaiseAndSetIfChanged(ref stringProperty2, value); }
        public double NumberProperty1 { get => numberProperty1; set => this.RaiseAndSetIfChanged(ref numberProperty1, value); }
        public double NumberProperty2 { get => numberProperty2; set => this.RaiseAndSetIfChanged(ref numberProperty2, value); }

        public ChildViewModel() 
        { 
            stringProperty1 = "Prop1";
            stringProperty2 = "Prop2";
            numberProperty1 = Random.Shared.NextDouble();
            numberProperty2 = Random.Shared.NextDouble();
        }
    }
}
