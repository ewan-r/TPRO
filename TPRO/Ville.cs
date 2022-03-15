using System;
using System.Collections.Generic;
using System.Text;

namespace TPRO
{
    class Ville
    {
        private int numero;
        public int Numero { get => this.numero; }
        private string nom;
        public string Nom{ get => this.nom; }
        private double latitude;
        public double Latitude { get => this.latitude; }
        private double longitude;
        public double Longitude{ get => this.longitude; }
        public Ville(int numero, string nom, double latitude, double longitude)
        {
            this.numero = numero;
            this.nom = nom;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public double Distance (Ville v2)
        {
            double r = 6371;
            double x1 = this.longitude * (Math.PI / 180);
            double y1 = this.latitude * (Math.PI / 180);
            double x2 = v2.Longitude * (Math.PI / 180);
            double y2 = v2.Latitude * (Math.PI / 180);
            return Math.Abs(r * Math.Acos((Math.Sin(y1) * Math.Sin(y2)) + (Math.Cos(y1) * Math.Cos(y2) * Math.Cos(x1 - x2))));
        }
    }
}
