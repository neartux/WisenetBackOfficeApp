﻿using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Windows.Input;
using WisenetBackOfficeApp.Views;

namespace WisenetBackOfficeApp.Models.Ordenes {

    class VentaTO {

        [JsonProperty(PropertyName = "idVenta")]
        public long IdVenta { get; set; }

        [JsonProperty(PropertyName ="fecha")]
        public DateTime Fecha { get; set; }

        [JsonProperty(PropertyName = "subTotal2")]
        public Double SubTotal { get; set; }

        [JsonProperty(PropertyName = "impuesto")]
        public Double Impuesto { get; set; }

        [JsonProperty(PropertyName = "envio")]
        public Double GastoEnvio { get; set; }

        [JsonProperty(PropertyName = "total")]
        public Double Total { get; set; }

        [JsonProperty(PropertyName = "puntos")]
        public Double TotalPuntos { get; set; }

        [JsonProperty(PropertyName = "nombreDistribuidor")]
        public string NombreDistribuidor { get; set; }

        public override string ToString() {
            return "VentaTO:{ " +
                "\n IdVenta = " + IdVenta +
                "\n Fecha = " + Fecha +
                "\n SubTotal = " + SubTotal +
                "\n Impuesto = " + Impuesto +
                "\n GastoEnvio = " + GastoEnvio +
                "\n Total = " + Total +
                "\n TotalPuntos = " + TotalPuntos +
                "\n}";
        }

        public ICommand ViewDetailOrderCommand {
            get {
                return new RelayCommand(GoToDetailOrder);
            }
        }

        private void GoToDetailOrder() {
            App.Navigator.PushAsync(new OrderDetail(IdVenta));
        }

    }
}
