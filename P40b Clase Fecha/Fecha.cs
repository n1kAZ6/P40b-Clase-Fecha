using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40b_Clase_Fecha
{
    class Fecha
    {
        //Atributos
        private int anyo, mes, dia;
        int[] maximoDiaMes = {-100,31,28,31,30,31,30,31,31,30,31,30,31 };

        //Constructores
        public Fecha(int anyo, int mes, int dia)
        {
            this.Anyo = anyo;
            this.Mes = mes;
            this.Dia = dia;
        }
        public Fecha() 
        {
            this.Anyo = DateTime.Now.Year;
            this.Mes = DateTime.Now.Month;
            this.Dia = DateTime.Now.Day;
        }

        //Getter & Setter
        public int Anyo { get => anyo;
            set 
            {
                anyo=value; 
                if (EsBisiesto)
                    maximoDiaMes[2] = 29;
                else
                    maximoDiaMes[2] = 28;
            }
        }
        public int Mes { get => mes; set => mes = value; }
        public int Dia { get => dia; set => dia = value; }

        //Propiedades
        public int FechaEntero
        {
            get => int.Parse((anyo % 100).ToString() + mes.ToString("00") + dia.ToString("00"));           
        }
        public string FechaStringSp
        {
            get => dia.ToString("00") + "/" + mes.ToString("00") + "/" + anyo;         
        }
        public string FechaStringTexto
        {
            get
            {
                string[] vMeses = {"" +"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
                return dia + " de " + vMeses[mes] + " de "+ anyo;
            }
        }
        public bool EsBisiesto
        {
            get => DateTime.IsLeapYear(anyo); 
            
        }
        public void AvanzaDia() 
        {
            dia++;

            if (dia > maximoDiaMes[mes])
            {
                dia = 1;
                mes++;
            }

            if (mes > 12)
            {
                mes = 1;
                anyo++;
                if (EsBisiesto)
                    maximoDiaMes[2] = 29;
                else
                    maximoDiaMes[2] = 28;
            }
        }

    }
}
