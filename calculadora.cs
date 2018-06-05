using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Calculadora{
    private double memoria=0;
     
    public double Sumar(double sumando1,double sumando2)
            {
               
                 memoria = sumando1+sumando2;
                return memoria;
            }
 

    public double Sumar(double sumando)
            {
                        
                        
                memoria= memoria + sumando;
                return memoria;
                        
            }

    public double Restar(double minuendo,double sustraendo)
            {
                        
                        
                 memoria= minuendo-sustraendo;
                return memoria;
            }

    public double Restar(double resto)
            {
                        
                        
                memoria= memoria - resto;
                return memoria;
                        
            }


     public double Multiplicar(double multiplicando,double multplicador)
    {
                
                
                memoria= multiplicando*multplicador;
                return memoria;
    }

    public double Multiplicar(double multiplicando1)
            {
                        
                        
               memoria = memoria*multiplicando1;
               return memoria;
            }

    public double Dividir(double dividendo ,double divisor )
    {
               
               
             memoria= dividendo/divisor;
             return memoria;
    } 

    public double Dividir(double dividendo1)
            {
                        
                        
                memoria= memoria / dividendo1;
                return memoria;
                        
            }




    public double Raiz(double radicando)
        {
                    
                    
                memoria= Math.Sqrt(radicando);
                return memoria;
                    
        }

        

    public double Raiz()
        {
                    
                    memoria= Math.Sqrt(memoria);
                    return memoria;
                    
        }

}