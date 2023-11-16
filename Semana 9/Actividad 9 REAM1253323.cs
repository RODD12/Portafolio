using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T9_REAM_1253323
{
    class Motocicleta
    {
        private string modelo;
        private string marca;
        private decimal precio;
        private decimal porcentajeIVA;

        public void SetDatos(string modelo, string marca, decimal precio, decimal porcentajeIVA)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.precio = precio;
            this.porcentajeIVA = porcentajeIVA;
        }

        public string GetDatos()
        {
            return $"Modelo: {modelo}\nMarca: {marca}\nPrecio: {precio:C}\nPorcentaje de IVA: {porcentajeIVA}%";
        }

        public decimal PrecioSinIVA()
        {
            return precio;
        }

        public decimal PrecioConIVA()
        {
            return precio * (1 + porcentajeIVA / 100);
        }

        public decimal MontoIVA()
        {
            return precio * (porcentajeIVA / 100);
        }
    }
}