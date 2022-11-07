// exercici 1

using System;

namespace n_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
            Console.WriteLine("Escriu el valor de a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriu el valor de b");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
                Console.WriteLine("Error divisió entre 0");
            else
            {
                x = -b / a;
                Console.WriteLine("El resultat es "+x);
                Console.WriteLine("El resultat es {0}", x);
                Console.WriteLine($"El resultat es {x}");
            }
        }
    }
}

// exercici 2

using System;

namespace n_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x1, x2, a, b, c;

            Console.WriteLine("Introduiu el valor de a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduiu el valor de b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduiu el valor de c");
            c = Convert.ToDouble(Console.ReadLine());

            if (((b * b) < (4 * a * c)))
                Console.WriteLine("No volem arrels negatives");
            else if (a == 0)
                Console.WriteLine("No volem divisions per 0");
            else {
                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine($"{a}x2 + {b}x + {c} = 0 ");
                Console.WriteLine($"x1 = {x1} ");
                Console.WriteLine($"x2 = {x2} ");

            }

        }
    }
}

// exercici 3

using System;

namespace n_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, absolut;

            Console.WriteLine("Indica el nombre");
            nombre= Convert.ToInt32(Console.ReadLine());

            if (nombre >= 0)
                absolut = nombre;
            else
                absolut =-nombre;

            Console.WriteLine("L'absolut de "+nombre+" es "+absolut);
            Console.WriteLine("L'absolut de {0} es {1}", nombre, absolut);
            Console.WriteLine($"L'absolut de {nombre} es {absolut}");



           
        }
    }
}

// exercici 4

using System;

namespace n_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre;
            Console.WriteLine("Introduiu el nombre");
            nombre = Convert.ToInt32(Console.ReadLine());

            if (nombre%2==0)
                Console.WriteLine("es parell");
            else
                Console.WriteLine("es senar");
        }
    }
}

// exercici 5
using System;

namespace n_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Introdui el primer nombre");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdui el segon nombre");
            b = Convert.ToInt32(Console.ReadLine());

            if (b>a)
                Console.WriteLine("Has introduit els nombres de manera creixent");
            else
                Console.WriteLine("no has introduit el nombres de manera cerixent");

        }
    }
}

// exercici 6

using System;

namespace n_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Introdui el primer nombre");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdui el segon nombre");
            b = Convert.ToInt32(Console.ReadLine());

            if (b > a)
                Console.WriteLine("Has introduit els nombres de manera creixent");
            else if (a >b)
                Console.WriteLine("Has introduit els nombres de manera decreixent");
            else
                Console.WriteLine("Els valors son iguals!");

        }
    }
}

// exercici 7
using System;

namespace n_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double euros, valor;
            const double exchange = 166.386;
            int pesetes;
            string moneda = "";

            Console.WriteLine("Indica el valor");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vols pasar a [euros] o a [pesetes]?");
            moneda = Console.ReadLine();

            if (moneda == "euros") {
                euros = Math.Round(valor / exchange, 2, MidpointRounding.ToNegativeInfinity);
                Console.WriteLine("El valor en euros es " + euros);
            }
            else if (moneda == "pesetes") {
                pesetes = (int)(valor * exchange);
                Console.WriteLine("El valor en pesetes es " +pesetes);

            }
            else
                Console.WriteLine("Escriu bé, home!");

        }
    }
}

// exercici 8
using System;

namespace n_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacio = "";
            int a, b, resultat;

            Console.WriteLine("Escriu valor 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriu operacio");
            operacio = Console.ReadLine(); 
            Console.WriteLine("Escriu valor 2");
            b = Convert.ToInt32(Console.ReadLine());

            if (operacio == "+")
            {
                resultat = a + b;
                Console.WriteLine("El resultat es " + resultat);
            }
            else if (operacio == "-")
            {
                resultat = a - b;
                Console.WriteLine("El resultat es " + resultat);
            }
            else if (operacio == "*")
            {
                resultat = a * b;
                Console.WriteLine("El resultat es " + resultat);
            }
            else if (operacio == "/")
            {
                resultat = a / b;
                Console.WriteLine("El resultat es " + resultat);
            }
            else
                Console.WriteLine("Fes el favor d'escriure bé");
        }
    }
}

// exercici 9


// exercici 10

using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            char caracter;

            //Inicialitzacio de variables
            Console.WriteLine("Escriu un caracter");
            caracter = Convert.ToChar(Console.ReadLine());

            //Algorisme
            if(caracter >= 'a' && caracter <= 'z')
                Console.WriteLine("minuscula");
            else if(caracter >= 'A' && caracter <='Z')
                Console.WriteLine("majuscula");
            else
                Console.WriteLine("no es lletra");
        }
    }
}
// exercici 11


// exercici 12

using System;

namespace n_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;

            Console.WriteLine("Escriu un caracter");
            caracter = Convert.ToChar(Console.ReadLine());

            if (caracter>='a' && caracter<='z')
                Console.WriteLine("Minuscula");
            else if (caracter>='A' && caracter<='Z')
                Console.WriteLine("Majuscula");
            else
                Console.WriteLine("nolletra");


        }
    }
}

// exercici 13

using System;

namespace n_13
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter;

            Console.WriteLine("Escriu un caracter");
            caracter = Convert.ToChar(Console.ReadLine());

            if (caracter>='a' && caracter<='z')
                Console.WriteLine("Minuscula");
            else if (caracter>='A' && caracter<='Z')
                Console.WriteLine("Majuscula");
            else
                Console.WriteLine("nolletra");


        }
    }
}

// exercici 14
using System;

namespace n_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int any;
            Console.WriteLine("Quin any?");
            any = Convert.ToInt32(Console.ReadLine());
            if (((any % 4 == 0) && (any % 100 != 0)) || (yany % 400 == 0)) 
                Console.WriteLine("{0} es un any traspas.", any);
            else 
                Console.WriteLine("{0} no es un any trapas.", any);
        }
    }
}
// exercici 15


// exercici 16

using System;

namespace ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int a, b, c;

            //Variables entrada
            Console.WriteLine("Escriu valor a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriu valor b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriu valor c");
            c = Convert.ToInt32(Console.ReadLine());

            //algorisme
            if((a <= b && b <= c) /*creixent */|| (a >= b && b >= c)/*decreixent*/)
                Console.WriteLine("ordenats");
            else
                Console.WriteLine("No ordenats");

        }
    }
}
// Exercici 17
using System;

namespace n_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Introduiu el primer nombre");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduiu el segon nombre");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduiu el tercer nombre");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1<num2)
                num1=num2;
            if (num1 < num3)
                num1 = num3;
            Console.WriteLine("El nombre més alt es "+num1);




        }
    }
}

// exercici 18

namespace n_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            Console.WriteLine("Escriu la nota");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota <4)
                Console.WriteLine("Suspes");
            else if (nota >5 && nota <8)
                Console.WriteLine("aprovat");
            else if (nota==9)
                Console.WriteLine("Excel.lent");
            else if (nota==10)
                Console.WriteLine("Matrícula d'honor");
            else
                Console.WriteLine("Error");
        }
    }
}

//exercici 19

using System;

namespace n_19
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaPractiques, notaTeoria, notaMitjana;
            Console.WriteLine("Introdui la nota de practiques");
            notaPractiques = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introdui la nota teòrica");
            notaTeoria = Convert.ToDouble(Console.ReadLine());

            if (notaPractiques <= 3 || notaTeoria <= 3)
            {
                Console.WriteLine("Game over");

            }

            else
            {
                notaMitjana = 0.3 * notaPractiques + 0.7 * notaTeoria;

                if (notaMitjana > 0 && notaMitjana < 5)
                {
                    Console.WriteLine(Math.Round(notaMitjana, 2));
                    Console.WriteLine("suspes");
                }
                else if (notaMitjana < 7)
                {
                    Console.WriteLine(Math.Round(notaMitjana, 2));
                    Console.WriteLine("aprovat");
                }
                else if (notaMitjana < 9)
                {
                    Console.WriteLine(Math.Round(notaMitjana, 2));
                    Console.WriteLine("notable");
                }
                else if (notaMitjana < 10)
                {
                    Console.WriteLine(Math.Round(notaMitjana, 2));
                    Console.WriteLine("excelent");
                }
                else if (notaMitjana == 10)
                {
                    Console.WriteLine(Math.Round(notaMitjana, 2));
                    Console.WriteLine("matricula");
                }
                else
                    Console.WriteLine("error");
                        }
        }
    }
}

// exercici 20

using System;

namespace n_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaSetmana; //0-6
            char carnetJove; //s-n
            

            Console.WriteLine("Escriu el dia de la setmana");
            diaSetmana = Convert.ToInt32(Console.ReadLine());

            if (diaSetmana <0 || diaSetmana >6)
                Console.WriteLine("Malament rai");
            else if (diaSetmana>4)
                Console.WriteLine("El preu de l'entrada son 5 euros");
            else if (diaSetmana == 1)
                Console.WriteLine("El preu de l'entrada es de "+(5*0.8));
            else
            {
                Console.WriteLine("Tens carnet jove?(s/n)");
                carnetJove = Convert.ToChar(Console.ReadLine());
                if (carnetJove=='s')
                    Console.WriteLine("El preu de l'entrada es "+(5*0.85));
                else if (carnetJove=='n')
                    Console.WriteLine("El preu de l'entrada son 5 euros");
                else
                    Console.WriteLine("Era [s] o [n] per si o no");
            }
        }
    }
}

// exercici 21

using System;

namespace Ex_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int horesMinutsSegons, hores, minuts, segons;

            Console.WriteLine("introdueix el temps [hhmmss]");
            horesMinutsSegons = Convert.ToInt32(Console.ReadLine());
            hores = horesMinutsSegons / 10000;
            minuts = horesMinutsSegons / 100 % 100;
            //minuts= horesMinutsSegons %10000 /100 
            segons = horesMinutsSegons % 100;

            if (hores > 23 || hores < 0 || minuts > 59 || minuts < 0 || segons > 59 || segons < 0)
            {
                Console.WriteLine("Las dades introduides son incorrectes");
            }
            else{
                segons++;
                    if (segons == 60) {
                    minuts++;
                    segons = 0;
                    }
                    if (minuts == 60) {
                    hores++;
                    minuts = 0;
                     }
                    if (hores == 24)
                    hores = 0;
                Console.WriteLine($"hores= {hores}, minuts= {minuts}, segons={segons}");
            }
            
        }
    }
}

// exercici 21_plus

using System;

namespace Ex_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int horesMinutsSegons, hores, minuts, segons, segonsSumar;

            Console.WriteLine("introdueix el temps [hhmmss]");
            horesMinutsSegons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introdueix els segons a sumar");
            segonsSumar = Convert.ToInt32(Console.ReadLine());

            hores = horesMinutsSegons / 10000;
            minuts = horesMinutsSegons / 100 % 100;
            //minuts= horesMinutsSegons %10000 /100 
            segons = horesMinutsSegons % 100;

            if (hores > 23 || hores < 0 || minuts > 59 || minuts < 0 || segons > 59 || segons < 0)
            {
                Console.WriteLine("Las dades introduides son incorrectes");
            }
            else
            {
                segons+=segonsSumar;
                if (segons > 59)
                {
                    minuts = minuts + segons / 60;
                    segons = segons % 60;
                }
                if (minuts > 59)
                {
                    hores += minuts / 60;
                    minuts %= 60;
                }
                if (hores > 23)
                    
                    hores %= 24;
                Console.WriteLine($"hores= {hores}, minuts= {minuts}, segons={segons}");
            }
        }
    }
}
            
        }
    }
}

// Exercici 22

using System;

namespace Ex_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaEntrada, minutEntrada, horaSortida, minutSortida, preuFinal, hores, minuts;
            Console.WriteLine("Hora d'entrada");
            horaEntrada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minut d'entrada");
            minutEntrada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hora sortida");
            horaSortida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minut sortida");
            minutSortida = Convert.ToInt32(Console.ReadLine());

            hores = horaSortida - horaEntrada;
            minuts = minutSortida - minutEntrada;
            preuFinal = hores;
            if (minuts < 0)
            {
                hores--;
                minuts += 60;
                
            }

            if (minuts > 0)
            {
                preuFinal++;
            }
            Console.WriteLine($"El preu final es {preuFinal} euros");
        }
    }
}


//Exercici 23

using System;

namespace Ex_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, invers=0;

            Console.WriteLine("Escriu el nombre de dos xifres");
            nombre = Convert.ToInt32(Console.ReadLine());

            if (nombre == 0 || nombre > 99)
            {
                Console.WriteLine("Nombre incorrecte");
            }

            else
            {
                //invers = (nombre % 10)*10;
                //invers += nombre / 10;
                invers = nombre % 10 * 10 + nombre / 10;
            }
            if (nombre == invers)
            {
                Console.WriteLine("CAPICUA");
            }
            else
                Console.WriteLine(invers);
        }
    }
}

//Exercici 24

//Exercici 25
namespace Ex_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, aux;

            Console.WriteLine("Primer nombre? (1/3)");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Primer nombre? (2/3)");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Primer nombre? (3/3)");
            n3 = Convert.ToInt32(Console.ReadLine());


            if (n2 < n1) {
                aux = n1;
                n1 = n2;
                n2 = aux;
                    }
            if (n3 < n2)
            {
                aux = n2;
                n2 = n3;
                n3 = aux;
            }
            if (n2 < n1)
            {
                aux = n1;
                n1 = n2;
                n2 = aux;
            }
            Console.WriteLine("El ordre es el seguent: "+n1+" "+n2+" "+n3);


            

            

        }   
    }
}

//Exercici 26

//Exercici 27
namespace Ex_27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demanar variables
            int diaSetmana;

            //Demanar valors entrada
            Console.WriteLine("Quin es el nombre?");
            diaSetmana = Convert.ToInt32(Console.ReadLine());

            //switch
            switch (diaSetmana)
            {
                case 1:
                    Console.WriteLine("Dilluns");
                    break;
                case 2:
                    Console.WriteLine("Dimarts");
                    break;
                case 3:
                    Console.WriteLine("Dimecres");
                    break;
                case 4:
                    Console.WriteLine("Dijous");
                    break;
                case 5:
                    Console.WriteLine("Divendres");
                    break;
                case 6:
                    Console.WriteLine("Dissabte");
                    break;
                case 7:
                    Console.WriteLine("Diumenge");
                    break;
                default:
                    Console.WriteLine("Nombre incorrecte, (1-7)");
                    break;

            }



        }
    }
}

//Exercici 28

using System;

namespace Ex_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int dniNombre, modul;
            string control = "TRWAGMYFPDXBNJZSQVHLCKE";
            
            //Demanar variables entrada
            Console.WriteLine("Quin es el dni?");
            dniNombre = Convert.ToInt32(Console.ReadLine());

            //Algorisme
            modul = dniNombre % 23;

            //Sortida
            Console.WriteLine("La lletra de control es "+control[modul]);
        }
    }
}

// Exercici 29

using System;

namespace Ex_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre, desena, unitats;
           

            Console.WriteLine("Nombre de dos xifres màxim");
            nombre = Convert.ToInt32(Console.ReadLine());
            

            if (nombre <1 ||nombre >99)
                Console.WriteLine("Un poquito de por favor (1-99)");
            else
            {
                desena = nombre / 10;
                unitats = nombre % 10;
                switch (desena)
                {
                    case 1:
                        Console.Write("X");
                        break;
                    case 2:
                        Console.Write("XX");
                        break;
                    case 3:
                        Console.Write("XXX");
                        break;
                    case 4:
                        Console.Write("XL");
                        break;
                    case 5:
                        Console.Write("L");
                        break;
                    case 6:
                        Console.Write("LX");
                        break;
                    case 7:
                        Console.Write("LXX");
                        break;
                    case 8:
                        Console.Write("LXXX");
                        break;
                    case 9:
                        Console.Write("XC");
                        break;
                }
                switch (unitats)
                {
                    case 1: Console.Write("I"); break;
                    case 2: Console.Write("II"); break;
                    case 3: Console.Write("III"); break;
                    case 4: Console.Write("IV"); break;
                    case 5: Console.Write("V"); break;
                    case 6: Console.Write("VI"); break;
                    case 7: Console.Write("VII"); break;
                    case 8: Console.Write("VIII"); break;
                    case 9: Console.Write("IX"); break;
                }
            }
        }
    }
}


//Exercici 30

using System;

namespace Ex_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, mesDia;

            Console.WriteLine("quin es el dia?");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quin es el mes?");
            mes = Convert.ToInt32(Console.ReadLine());

            mesDia = Convert.ToInt32(mes +""+ dia);
            //mesDia = mes *100 + dia;
            Console.WriteLine(mesDia);

        }
    }
}

// Exercici 31

using System;

namespace Ex_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, any, data, days;


            Console.WriteLine("Quina es la data? (ddmmaaaa)");
            data = Convert.ToInt32(Console.ReadLine());
            dia = data / 1000000;
            mes = data / 10000 % 100;
            any = data % 10000;
            

            darrerDia = DateTime.DaysInMonth(any, mes);

            if (dia >darrerDia || dia <1 ||mes >12 || mes<1 || any <1 )
                Console.WriteLine("Error!");
            else
                Console.WriteLine("Correcte!");

        }
    }
}

