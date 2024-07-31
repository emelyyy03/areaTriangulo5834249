using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaTriangulo5834249
{
    public partial class AreaModelo : ObservableObject
    {
        [ObservableProperty]
        public string? lado1;

        [ObservableProperty]
        public string? lado2;

        [ObservableProperty]
        public string? lado3;

        [ObservableProperty]
        public double s;

        [ObservableProperty]
        public double sml;

        [ObservableProperty]
        public string? area;

        [RelayCommand]
        private void ActualizarDatos()
        {
            if (double.TryParse(Lado1, out double l1) && double.TryParse(Lado2, out double l2)
                && double.TryParse(Lado3,out double l3))
            {
                S = (l1 + l2 + l3) / 2;

                Sml = S * (S - l1) * (S - l2) * (S - l3);

                Area = Math.Sqrt(Sml).ToString();
            }
            else
            {
                Area = "Digite valores numericos";
            }
        }
    }
}
