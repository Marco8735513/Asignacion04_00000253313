using RaicesLogica.Model;
using RaicesLogica.Funciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RaicesLogica.Servicio
{
    public class Resultado
    {
        public List<Iteracion> Biseccion(double xi, double xf, double eamax)
        {
            //Aquí se creamos el objeto iteraciones
            var iteraciones = new List<Iteracion>();

            double xr;
            //Le damos un valor inicial de cero por defecto, pero al final del siclo
            //se le da el valor de xr
            double xrAnterior = 0;

            //ea es el error aproximado, antes de la interación es un valor muy grande
            //para que el primer caso entre al ciclo
            double ea = double.PositiveInfinity;

            //Como no usamos for este es nuestro contador
            int contador = 0;

            if (xi == xf)
                throw new ArgumentException("xi y xf no pueden ser iguales");

         


            do
            {
                //Aumentamos el contador
                contador++;

                //Se saca la raiz
                xr = (xi + xf) / 2.0;

                //Se saca la f de xi y xr
                //F ya es una fucnión que se creo dentro de FuncionesMatematicas, en la carpeta funciones
                double fxi = FuncionesMatematicas.F(xi);
                double fxr = FuncionesMatematicas.F(xr);
                

                //Aquí sucede el cambio de valores
                if (fxi * fxr < 0.0)
                {
                    xf = xr;

                }

                else if (fxi * fxr > 0.0)
                {
                    xi = xr;
                }

                else
                {
                    
                    eamax = 0; // La raíz exacta se ha encontrado

                    //Esto es por que uno de los valores sea fxi o fxr es cero por eso la raiz exacta es cero

                }

                //Aquí se afuerzas el contador tiene que ser mayor a uno, recordemos que el error
                //se saca xr nueva - xr vieja / xr nueva por eso en la primera iteración no se puede sacar
                if (contador > 1)
                {
                    ea = FuncionesMatematicas.ErrorRelativo(xr, xrAnterior);
                }

                //Aquí se guarda todo en la lista de iteraciones, es un modelo que guarda todo los valores

                iteraciones.Add(new Iteracion
                {
                    Numero = contador,
                    Xi = xi,
                    Xf = xf,
                    Xr = xr,
                    FxR = fxr,
                    Error = ea
                });

                //Aquí es donde el valor de xrAnterior se actualiza por xr
                xrAnterior = xr;


                //Aquí podemos preguntar ¿Por que ea > eamax?
                //Si ea es menor que eamax que nosotros pusimos en la aplicacion quiere decir
                //que ya estabamos abajo del eamax que nosotros pusimos y es donde el clico termina
                //por eso tiene que ser ea mayor que eamax para que el clico siga hasta que ea sea menor que eamax, ahí ya 
                //termina.

            } while (ea > eamax );

            return iteraciones;
        }
        public List<Iteracion> ReglaFalsa(double xi, double xf, double eamax)
        {
            var iteraciones = new List<Iteracion>();
            int contador = 0;

            double xr = 0;
            double xrAnterior = 0;
            double ea = double.PositiveInfinity;

            if (xi == xf)
                throw new ArgumentException("xi y xf no pueden ser iguales");

            if (FuncionesMatematicas.F(xi) * FuncionesMatematicas.F(xf) > 0)
                throw new ArgumentException("Los valores f(xi) y f(xf) deben tener signos opuestos");

            do
            {
                contador++;

                double fxi = FuncionesMatematicas.F(xi);
                double fxf = FuncionesMatematicas.F(xf);

                // Fórmula de Regla Falsa
                xr = (xi * fxf - xf * fxi) / (fxf - fxi);
                double fxr = FuncionesMatematicas.F(xr);

                // Actualización de intervalos
                if (fxi * fxr < 0)
                {
                    xf = xr;
                    fxf = fxr;
                }
                else if (fxi * fxr > 0)
                {
                    xi = xr;
                    fxi = fxr;
                }
                else
                {
                    ea = 0; // raíz exacta encontrada
                }

                if (contador > 1)
                {
                    ea = FuncionesMatematicas.ErrorRelativo(xr, xrAnterior);
                }

                iteraciones.Add(new Iteracion
                {
                    Numero = contador,
                    Xi = xi,
                    Xf = xf,
                    Xr = xr,
                    FxR = fxr,
                    Error = ea
                });

                xrAnterior = xr;

            } while (ea > eamax);

            return iteraciones;
        }





    }
}
