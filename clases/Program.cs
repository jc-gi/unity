/* using System;

namespace clases
{
   internal class Program
    {


    public class Nave
    {
        int m_Grafico;
            float m_Posicion = 0.0f;
            float m_Posicionactual = 0.0f;
            int m_Puntuacion = 0;

            public void MoverseIzquierda(){

            }
            public void MoverseDerecha(){

            }

            public void Avanzar(){

            }

            public void Disparar(){

            }

    }

    class Enemigo:Nave{
          
        }

    class Prota:Nave{
            
        }
        
    class Marcador{

        }
    class Defensa{

        }

    
        class Disparo{

        }
        static void Main(string[] args){
            
            Enemigo enemigo = new Enemigo();
            enemigo.Disparar();

       }
   }
} */

/* 
Example 1 for programming in C#
Class Message
Author: Juan Carlos Gonzalez
Subject: Videogames
Date:  31/01/2022
 */

using System; //Statement directive for commands

//Class Statement with a method that has a parameter.
//Definition of class
public class Message {


    //Statement of a variable with the message
    string message;
    //Statement of constructor without parameters called predetermined
    public Message(){
        message = "Hello world"; //Assign the first string
    } 
    //Statement of constructor with String type parameter
    public Message(string l_message){
        message = l_message;
    }   

    //// shows a Hello World message for the user
    public void Print(){
        Console.WriteLine(message);
    } //end of method Print
} //end of class Message



// creates object Message and passes a string to Print method.
class Program
 {
        // The Main Method begins the execution of the program
        static void Main(string[] args) {

            Message rainMessage;

        // Ask for the name of the course and receive it as an entry    
       // Console.WriteLine("Write the name of the course: \n");
        //string m_message = Console.ReadLine(); //Read a string line in console
        Console.WriteLine(); // Print a enter line
        
        //Use a default constructor
        // Create a Message object and assigns it to hiMessage
        Message hiMessage = new Message(); //Create an object
        // call the method Print and pass the message (m_message) as argument
        hiMessage.Print();

        //Use constructor that takes a string parameter
        // Create a Message object and assigns it to hiMessage
        Message hiMessage2 = new Message("Hello world 2"); //Create an object
        // call the method Print and pass the message (m_message) as argument
        hiMessage2.Print();

        /* Message rainMessage = new Message("Hello, world\n" +
                                            "students of\n" +
                                            "Videogames");

        rainMessage.Print(); */

        rainMessage = new Message(  "Hello, world\n" +
                                    "student of\n" +
                                    "Videogames");
        rainMessage.Print(); 

        int i = 123;
        object o = i;
        int j = (int)o;

        Console.WriteLine(i);
        Console.WriteLine(o);
        Console.WriteLine(j);


    }//End of main
} //End of principal class
