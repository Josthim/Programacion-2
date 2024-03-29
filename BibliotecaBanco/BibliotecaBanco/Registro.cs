﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaBanco
{
    public class Registro
    {
        private int cuenta;
        private string primerNombre;
        private string apellidoPaterno;
        private decimal saldo;

        public Registro() : this(0, "", "", 0.0M)
        {

        }

        public Registro(int valorCuenta, string valorprimerNombre, string valorapellidoPaterno, decimal valorsaldo)
        {
            Cuenta = valorCuenta;
            PrimerNombre = valorprimerNombre;
            ApellidoPaterno = valorapellidoPaterno;
            Saldo = valorsaldo; 
        }

        public int Cuenta { get => cuenta; set => cuenta = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
    }
}
