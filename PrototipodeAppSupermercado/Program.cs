using System;
using System.Collections.Generic;
using System.Linq;

namespace Parcial2Eje2
{
    class Program
    {
            static void Main(string[] args)
            {
                //declaramos las listas 
                List<String> productos=new List<String>{"vodka","fideos","chocolate","aceite"};
                List<double> precios= new List<double>{200,80,150,120};
                List<int> cantidades= new List<int>{5,8,9,10};
                List<int> Tipos= new List<int>{1,0,0,0};
                int opc =0;

                do{

                    opc=menu();

                    switch(opc)
                    {
                    case 1:
                            //realizar  incremeto de estock
                            Console.WriteLine("1-Incrementar stock");
                            incrementarStock(ref cantidades,productos);
                    break;

                    case 2:
                        // realizar venta 
                        Console.WriteLine("2-Realizar venta "); 
                        vender(precios, cantidades);
                    break;
                    case 3:

                        // Ingresar producto
                        IngresarProducto(ref productos,precios,cantidades,Tipos);
                        

                            
                    break;
                    case 4:

                        // Mostrar productos
                        MostrarProducto(ref productos,precios,cantidades,Tipos);
                    

                            
                    break;
                    case 5:

                        // salir
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;   
                        Console.WriteLine("Usted ha elegido salir de la aplicacion");
                        Console.WriteLine("Muchas gracias por su compra. ");
                        Console.ForegroundColor = ConsoleColor.White; 

                            
                    break;

                    }


                }while(opc!=5);


            }


            static int menu()
            {
                 Console.Clear();
                 int opcion=0;
                 Console.ForegroundColor = ConsoleColor.Blue; 
                 Console.WriteLine("Bienvenido a supermecados ISTEA ");
                 Console.ForegroundColor = ConsoleColor.White; 
                 Console.WriteLine("");
                 
                 try{   
                        // se pide al usuario la opcion elegida. 
                 Console.ForegroundColor = ConsoleColor.Red; 
                 Console.WriteLine("1-Incrementar stock");
                 Console.WriteLine("2-Realizar venta "); 
                 Console.WriteLine("3-Ingresar producto ");
                 Console.WriteLine("4-Mostrar productos "); 
                 Console.WriteLine("5-Salir de la aplicacion ");  
                 Console.ForegroundColor = ConsoleColor.White; 
                 Console.WriteLine("Ingrese la Opcion");  
                 opcion=Convert.ToInt32(Console.ReadLine());

                 if(opcion<1||opcion>5)
                 {
                     Console.ForegroundColor=ConsoleColor.DarkRed;
                     Console.WriteLine("Debe ingrresar un numero del 1 al 3 , 3 para salir ");
                     Console.ForegroundColor=ConsoleColor.White;
                     opcion=Convert.ToInt32(Console.ReadLine());

                     return opcion;


                 }
                    return opcion;

                 }catch{
                  
                     return 0;
                 }
            }


            public static int incrementarStock(ref List<int> stock, List<string> productos)
            {
                // se pide al usuario la opcion elegida. 
                Console.Clear();
                Console.ForegroundColor=ConsoleColor.DarkYellow;
                Console.WriteLine("Ingrese el producto que desea incrementar ");
                Console.ForegroundColor=ConsoleColor.DarkRed;
                Console.WriteLine("Ingrese 1 para vodka");
                Console.WriteLine("Ingrese 2 fideos");
                Console.WriteLine("Ingrese 3 chocolates");
                Console.WriteLine("Ingrese 4 aceite ");
                Console.ForegroundColor=ConsoleColor.White;
                // se crean variables para uso de fucion.
                int opc =0;
                int cant =0;
                int produc1=0;
                int produc2=0;
                int produc3=0;
                int produc4=0;


                try{
                        opc=Convert.ToInt32(Console.ReadLine());// usuario ingresa opcion

                        // se incrementa stock segun producto elegido
                        switch(opc)
                        {
                            case 1:
                                produc1+=stock[0];
                                stock.RemoveAt(0);
                                Console.Write("Ingrese la cantidad que desea aumentar: ");
                                cant = Convert.ToInt32(Console.ReadLine());
                                stock.Insert(0,cant+produc1);
                                Console.ForegroundColor=ConsoleColor.Green;
                                Console.WriteLine("El producto {0} tiene stock {1}",productos[0],stock[0] );
                                Console.ForegroundColor=ConsoleColor.White;

                            break;
                            case 2:
                                produc2+=stock[1];
                                stock.RemoveAt(1);
                                Console.Write("Ingrese la cantidad que desea aumentar: ");
                                cant = Convert.ToInt32(Console.ReadLine());
                                stock.Insert(1,cant+produc2);
                                Console.ForegroundColor=ConsoleColor.Green;
                                Console.WriteLine("El producto {0} tiene stock {1}",productos[1],stock[1] );
                                Console.ForegroundColor=ConsoleColor.White;


                            break;
                            case 3:
                                produc3+=stock[2];
                                stock.RemoveAt(2);
                                Console.Write("Ingrese la cantidad que desea aumentar: ");
                                cant = Convert.ToInt32(Console.ReadLine());
                                stock.Insert(2,cant+produc3);
                                Console.ForegroundColor=ConsoleColor.Green;
                                Console.WriteLine("El producto {0} tiene stock {1}",productos[2],stock[2] );
                                Console.ForegroundColor=ConsoleColor.White;


                            break;
                            case 4:
                                produc4+=stock[3];
                                stock.RemoveAt(3);
                                Console.Write("Ingrese la cantidad que desea aumentar: ");
                                cant = Convert.ToInt32(Console.ReadLine());
                                stock.Insert(3,cant+produc4);
                                Console.ForegroundColor=ConsoleColor.Green;
                                Console.WriteLine("El producto {0} tiene stock {1}",productos[3],stock[3] );
                                Console.ForegroundColor=ConsoleColor.White;


                            break;



                        }
                        Console.ReadKey();

                
                }catch
                {
                    // si la opcion es erronea crea una aviso 
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Aviso!");
                    Console.ForegroundColor=ConsoleColor.White;

                }




                    return 0;
            }

            // se crea funcion vender 
            public static void vender( List<double> precios, List <int>  stock )
            {
                // se crean variables para usar en funcion 
                Console.Clear();
                int opc=0;
                double cant=0;
                double total = 0;
                double subtotal=0;
                double subtotal1=0;
                int produc1=0;
                int produc2=0;
                int produc3=0;
                int produc4=0;

                try{
                    
                    do{
                        // se pide al usuario el ingreso de opcion
                        Console.Clear();
                        Console.ForegroundColor=ConsoleColor.DarkYellow;
                        Console.WriteLine("Ingrese una Opcion de venta:  ");
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.WriteLine("Ingrese 1 para vodka");
                        Console.WriteLine("Ingrese 2 fideos");
                        Console.WriteLine("Ingrese 3 chocolates");
                        Console.WriteLine("Ingrese 4 aceite ");
                        Console.WriteLine("Ingrese 5 para dejar de comprar ");
                        Console.ForegroundColor=ConsoleColor.White;

                         opc=Convert.ToInt32(Console.ReadLine()); // usuario ingresa opcion

                        switch(opc)
                        {
                            case 1 :
                            
                            Console.WriteLine("Ingrese la cantidad a vender:  ");
                            cant= int.Parse(Console.ReadLine());// usuario ingresa cantidad a vender 

                            if(cant <= stock[0]) //si es menor o igual se realiza venta
                            {
                            total= cant * precios[0];
                            Console.ForegroundColor=ConsoleColor.Green;
                            Console.WriteLine("El subtotal de los productos es $" + total);
                            Console.ForegroundColor=ConsoleColor.White;
                                produc1+=stock[0]; // se crea variable para restar productos a la lista. 
                                stock.RemoveAt(0);
                                stock.Insert(0,produc1-(int)cant);
                            }else
                            {
                                // si es mayor al stock no deja vender 
                                Console.ForegroundColor=ConsoleColor.Red;
                                Console.WriteLine("La cantidad ingresada es superior al stock");
                                Console.ForegroundColor=ConsoleColor.White;
                             

                            }
                             
                            

                            break;
                            case 2 :
                            Console.WriteLine("Ingrese la cantidad a vender ");
                            cant= int.Parse(Console.ReadLine());
                            if(cant <= stock[1])
                            {
                            total= cant * precios[1];
                            Console.ForegroundColor=ConsoleColor.Green;
                            Console.WriteLine("El subtotal de los productos es $" + total);
                            Console.ForegroundColor=ConsoleColor.White;
                                    produc2+=stock[1];
                                    stock.RemoveAt(1);
                                    stock.Insert(0,produc2-(int)cant);
                            }else
                            {
                                Console.ForegroundColor=ConsoleColor.Red;
                                Console.WriteLine("La cantidad ingresada es superior al stock");
                                Console.ForegroundColor=ConsoleColor.White;
                             

                            }
                          
                            break;
                            case 3 :
                            Console.WriteLine("Ingrese la cantidad a vender ");
                            cant= int.Parse(Console.ReadLine());
                            if(cant <= stock[2])
                            {
                            total= cant * precios[2];
                            Console.ForegroundColor=ConsoleColor.Green;
                            Console.WriteLine("El subtotal de los productos es $" + total);
                            Console.ForegroundColor=ConsoleColor.White;
                                produc3+=stock[2];
                                stock.RemoveAt(2);
                                stock.Insert(0,produc3-(int)cant);
                            }else
                            {
                                Console.ForegroundColor=ConsoleColor.Red;                                
                                Console.WriteLine("La cantidad ingresada es superior al stock");
                                Console.ForegroundColor=ConsoleColor.White;
                             

                            }
                                

                            break;
                            case 4 :
                            Console.WriteLine("Ingrese la cantidad a vender ");
                            cant= int.Parse(Console.ReadLine());
                           if(cant <= stock[3])
                            {
                            total= cant * precios[3];
                            Console.ForegroundColor=ConsoleColor.Green;
                            Console.WriteLine("El subtotal de los productos es $" + total);
                            Console.ForegroundColor=ConsoleColor.White;
                                produc4+=stock[3];
                                stock.RemoveAt(3);
                                stock.Insert(0,produc4-(int)cant);
                            }else
                            {
                                Console.ForegroundColor=ConsoleColor.Red; 
                                Console.WriteLine("La cantidad ingresada es superior al stock");
                                Console.ForegroundColor=ConsoleColor.White;
                             

                            }
                               

                            break;
                            case 5 :
                            Console.ForegroundColor=ConsoleColor.DarkYellow;
                            Console.WriteLine(" Usted finalizo el pedido  ");
                            Console.ForegroundColor=ConsoleColor.White;
                            

                            break;

                        }

                    subtotal1 += total;
                    Console.ForegroundColor=ConsoleColor.Green;
                    Console.WriteLine("Este es el Subtotal de la compra:"+ subtotal1);
                    Console.ForegroundColor=ConsoleColor.White;
                    total = 0;
                    Console.ReadKey();   
                        

                    }while(opc !=5);

                    subtotal = subtotal1;
                    double totalCompra;
                    double iva;
                    iva = subtotal * 0.21; //  se calcula iva 

                    totalCompra = subtotal + iva;
                    int opcion1= 0;
                    // se pregunta si corresponde iva 
                    Console.WriteLine("Es IVA excento ?, Marque 1 para si o 2 para no");

                    opcion1 = int.Parse(Console.ReadLine());
                    if (opcion1==1)
                    {
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine("El precio sin IVA para esta compra es : $" + subtotal);
                        Console.ForegroundColor=ConsoleColor.White;
                    }
                    else if (opcion1 == 2)
                    {
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.WriteLine("El precio con IVA para esta compra es: $" + totalCompra);
                        Console.ForegroundColor=ConsoleColor.White;
                    }

                    Console.ReadKey();

                }catch{

                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("Se registo un error en el sistema"); // si la opcion es erronea muestra mensaje
                    Console.ForegroundColor=ConsoleColor.White;


                }



            }

       public static void IngresarProducto( ref List<String> productos,List<double> precios,List<int> cantidades, List<int> Tipos)
        {   // se crean variables
            string aux="";
            double aux1=0;
            int aux2=0;
            int aux3=0;

            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("Ingrese el nombre del producto: ");
            Console.ForegroundColor=ConsoleColor.White;
             aux=Console.ReadLine();// se pide producto a usuario
             productos.Add(aux); //se agrega producto a la lista

             Console.ForegroundColor=ConsoleColor.Red;
             Console.WriteLine("Ingrese el  precio del producto:  ");
             Console.ForegroundColor=ConsoleColor.White;
             aux1=Convert.ToDouble(Console.ReadLine());
             precios.Add(aux1);

             Console.ForegroundColor=ConsoleColor.Red;
             Console.WriteLine("Ingrese la cantidad del producto: ");
             Console.ForegroundColor=ConsoleColor.White;
             aux2=Convert.ToInt32(Console.ReadLine());
             cantidades.Add(aux2);

             Console.ForegroundColor=ConsoleColor.Red;
             Console.WriteLine("Ingrese el tipo");
             Console.ForegroundColor=ConsoleColor.White;
             aux3=Convert.ToInt32(Console.ReadLine());
             Tipos.Add(aux3);

             Console.ForegroundColor=ConsoleColor.Yellow;
             Console.WriteLine("El procto ha sido ingresado ....");

             Console.ReadKey();

                
        }

        static void MostrarProducto(ref List<String> productos,List<double> precios,List<int> cantidades, List<int> Tipos)
        {

            short contador = 0;

              foreach (var item in productos )// se muetra producto por lista
                        {
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.Write("Producto : "+ item + " |-| ") ;
                        Console.ForegroundColor=ConsoleColor.White;
                        contador++;
                        }
                        if(contador==productos.Count)
                        {
                            Console.WriteLine(" ");

                        }
                        contador=0;   
               foreach (var item in precios )
                        {
                        Console.ForegroundColor=ConsoleColor.Blue;
                        Console.Write("Precio   : "+ item + "  |-| ") ;
                        Console.ForegroundColor=ConsoleColor.White;
                        contador++;
                        }
                         if(contador==precios.Count)
                        {
                            Console.WriteLine(" ");

                        }
                        contador=0;  
                foreach (var item in cantidades )
                        {
                        Console.ForegroundColor=ConsoleColor.DarkGreen;
                        Console.Write("Cantidad : "+ item + "    |-| ") ;
                        Console.ForegroundColor=ConsoleColor.White;
                        contador++;
                        }
                         if(contador==cantidades.Count)
                        {
                            Console.WriteLine(" ");

                        }
                        contador=0; 
                foreach (var item in Tipos )
                        {
                        Console.ForegroundColor=ConsoleColor.Blue;
                        Console.Write("Tipo     : "+ item + "    |-| ") ;
                        Console.ForegroundColor=ConsoleColor.White;
                        contador++;
                        }
                         if(contador==productos.Count)
                        {
                            Console.WriteLine(" ");

                        }
                        contador=0;                             


            Console.ReadKey();

        }     
        
    }

}
