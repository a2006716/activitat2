using System;

namespace Activitat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXAMEN SOBRE CULTURA GENERAL

            string pregunta1a, pregunta2a, pregunta3a, pregunta4a, pregunta5a, pregunta1b, pregunta2b, pregunta3b, pregunta4b, 
            pregunta5b, pregunta1c, pregunta2c, pregunta3c, pregunta4c,pregunta5c;
            string resposta;
            int punts = 0;
            int punts2 = 0;
            int punts3 = 0;
            int puntsTotal;

            Console.WriteLine("  ----EXAMEN DE CULTURA GENERAL----");
            Console.WriteLine("RESPON A LES SEGÜENTS 15 PREGUNTES");
            Console.WriteLine(" ");
            Console.WriteLine("¡¡¡VES AMB COMPTE JA QUE SI T'EQUIVOQUES DE CARÀCTER CONTARÀ COM UNA RESPOSA ERRÒNEA!!!");
            Console.WriteLine("  ");
            Console.WriteLine("COMENÇEM AMB PAÍSOS I CAPITALS:");
            Console.WriteLine("");
            
            Console.WriteLine("--PREGUNTA 1--");
            Console.WriteLine("QUINA ÉS LA CAPITAL DE CHIPRE?");
            Console.WriteLine("");
            Console.WriteLine("A-> Sofía");
            Console.WriteLine("B-> Ottawa");
            Console.WriteLine("C-> Nicosia");
            Console.WriteLine("D-> Berlín");
            pregunta1a = Console.ReadLine();


            switch (pregunta1a)
            {
                case "A":
                case "a":
                case "B":
                case "b":
                case "D":
                case "d":
                    resposta = "MALAMENT";
                    break;

                case "C":
                case "c":
                    punts++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }

            Console.WriteLine(resposta + " !! Tens " + punts + " Punts!");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--PREGUNTA 2--");
            Console.WriteLine("");
            Console.WriteLine("QUINA ÉS LA CAPITAL D'IRLANDA?");
            Console.WriteLine("");
            Console.WriteLine("A-> Dublín");
            Console.WriteLine("B-> Madrid");
            Console.WriteLine("C-> Mónaco");
            Console.WriteLine("D-> Oslo");
            pregunta2a = Console.ReadLine();


            switch (pregunta2a)
            {
                case "B":
                case "b":
                case "C":
                case "c":
                case "D":
                case "d":

                    resposta = "MALAMENT";
                    break;

                case "A":
                case "a":
                    punts++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }

            Console.WriteLine(resposta + " !! Tens " + punts + " Punts!");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--PREGUNTA 3--");
            Console.WriteLine("");
            Console.WriteLine("QUINA ÉS LA CAPITAL DE LETONIA?");
            Console.WriteLine("");
            Console.WriteLine("A-> Tarawa");
            Console.WriteLine("B-> Vina");
            Console.WriteLine("C-> Nairobi");
            Console.WriteLine("D-> Riga");
            pregunta3a = Console.ReadLine();


            switch (pregunta3a)
            {
                case "A":
                case "a":
                case "B":
                case "b":
                case "C":
                case "c":

                    resposta = "MALAMENT";
                    break;

                case "D":
                case "d":
                    punts++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }

            Console.WriteLine(resposta + " !! Tens " + punts + " Punts!");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--PREGUNTA 4--");
            Console.WriteLine("");
            Console.WriteLine("QUINA ÉS LA CAPITAL D'ITÀLIA?");
            Console.WriteLine("");
            Console.WriteLine("A-> Georgetown");
            Console.WriteLine("B-> Acra");
            Console.WriteLine("C-> Manila");
            Console.WriteLine("D-> Roma");
            pregunta4a = Console.ReadLine();


            switch (pregunta4a)
            {
                case "A":
                case "a":
                case "B":
                case "b":
                case "C":
                case "c":

                    resposta = "MALAMENT";
                    break;

                case "D":
                case "d":
                    punts++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }
            
            Console.WriteLine(resposta + " !! Tens " + punts + " Punts!");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--PREGUNTA 5--");
            Console.WriteLine("");
            Console.WriteLine("QUINA ÉS LA CAPITAL DE MOZAMBIQUE?");
            Console.WriteLine("");
            Console.WriteLine("A-> Maputo");
            Console.WriteLine("B-> Lilongüe");
            Console.WriteLine("C-> Monrovia");
            Console.WriteLine("D-> Vientián");
            pregunta5a = Console.ReadLine();

            switch (pregunta5a)
            {
                case "B":
                case "b":
                case "C":
                case "c":
                case "D":
                case "d":

                    resposta = "MALAMENT";
                    break;

                case "A":
                case "a":
                    punts++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }

            Console.WriteLine(resposta + " !! Tens " + punts + " Punts!");
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("---HAS ACABAT LES PREGUNTES DE CAPITALS AMB UN " + punts + " SOBRE 5---");

            Console.WriteLine("PREGUNTES SOBRE LES GUERRES MÉS IMPORTANTS:");
            Console.WriteLine("");

            Console.WriteLine("--PREGUNTA 1--");
            Console.WriteLine("QUAN VA COMENÇAR LA PRIMERA GUERRA MUNDIAL?");
            Console.WriteLine("");
            Console.WriteLine("A-> 1923");
            Console.WriteLine("B-> 1914");
            Console.WriteLine("C-> 1899");
            Console.WriteLine("D-> 1910");
            pregunta1b = Console.ReadLine();


            switch (pregunta1b)
            {
                case "A":
                case "a":
                case "C":
                case "c":
                case "D":
                case "d":
                    resposta = "MALAMENT";
                    break;

                case "B":
                case "b":
                    punts2++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }
            Console.WriteLine(resposta + " !! Tens " + punts2 + " Punts!");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--PREGUNTA 2--");
            Console.WriteLine("");
            Console.WriteLine("QUANTS ANYS VA DURAR LA PRIMERA GUERRA MUNDIAL?");
            Console.WriteLine("");
            Console.WriteLine("A-> 3 anys");
            Console.WriteLine("B-> 5 anys");
            Console.WriteLine("C-> 4 anys");
            Console.WriteLine("D-> 6 anys");
            pregunta2b = Console.ReadLine();


            switch (pregunta2b)
            {
                case "A":
                case "a":
                case "B":
                case "b":
                case "D":
                case "d":

                    resposta = "MALAMENT";
                    break;

                case "C":
                case "c":
                    punts2++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }

            Console.WriteLine(resposta + " !! Tens " + punts2 + " Punts!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--PREGUNTA 3--");
            Console.WriteLine("");
            Console.WriteLine("A QUIN ANY VA ACABAR LA SEGONA GUERRA MUNDIAL?");
            Console.WriteLine("");
            Console.WriteLine("A-> 1934");
            Console.WriteLine("B-> 1939");
            Console.WriteLine("C-> 1965");
            Console.WriteLine("D-> 1945");
            pregunta3b = Console.ReadLine();


            switch (pregunta3b)
            {
                case "A":
                case "a":
                case "B":
                case "b":
                case "C":
                case "c":

                    resposta = "MALAMENT";
                    break;

                case "D":
                case "d":
                    punts2++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }
            Console.WriteLine(resposta + " !! Tens " + punts2 + " Punts!");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--PREGUNTA 4--");
            Console.WriteLine("");
            Console.WriteLine("QUINS PAÏSOS EREN ELS ALIATS EN LA SEGONA GUERRA MUNDIAL?");
            Console.WriteLine("");
            Console.WriteLine("A-> Regne Unit");
            Console.WriteLine("B-> Unió Soviètica ");
            Console.WriteLine("C-> Estats Units");
            Console.WriteLine("D-> Totes són correctes");
            pregunta4b = Console.ReadLine();


            switch (pregunta4b)
            {
                case "A":
                case "a":
                case "B":
                case "b":
                case "C":
                case "c":

                    resposta = "MALAMENT";
                    break;

                case "D":
                case "d":
                    punts2++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }
            Console.WriteLine(resposta + " !! Tens " + punts2 + " Punts!");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--PREGUNTA 5--");
            Console.WriteLine("");
            Console.WriteLine("QUAN VA COMENÇAR LA GUERRA CIVIL ESPANYOLA??");
            Console.WriteLine("");
            Console.WriteLine("A-> 1939");
            Console.WriteLine("B-> 1936");
            Console.WriteLine("C-> 1941");
            Console.WriteLine("D-> 1932");
            pregunta5b = Console.ReadLine();


            switch (pregunta5b)
            {
                case "A":
                case "a":
                case "C":
                case "c":
                case "D":
                case "d":

                    resposta = "MALAMENT";
                    break;

                case "B":
                case "b":
                    punts2++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }
            Console.WriteLine(resposta + " !! Tens " + punts2 + " Punts!");



            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("---HAS ACABAT LES PREGUNTES SOBRE LES GUERRES AMB UN " + punts2 + " SOBRE 5---");

            Console.WriteLine("PREGUNTES SOBRE DEUS DE LA MITOLOGIA GREGA:");
            Console.WriteLine("");

            Console.WriteLine("--PREGUNTA 1--");
            Console.WriteLine("QUI ERA EL 'DIOS del Cielo y Soberano del Olimpo'?");
            Console.WriteLine("");
            Console.WriteLine("A-> Zeus");
            Console.WriteLine("B-> Poseidon");
            Console.WriteLine("C-> Hades");
            Console.WriteLine("D-> Hermes");
            pregunta1c = Console.ReadLine();

            switch (pregunta1c)
            {
                case "B":
                case "b":
                case "C":
                case "c":
                case "D":
                case "d":

                    resposta = "MALAMENT";
                    break;

                case "A":
                case "a":
                    punts3++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }
            Console.WriteLine(resposta + " !! Tens " + punts3 + " Punts!");
            Console.WriteLine("");

            Console.WriteLine("--PREGUNTA 2--");
            Console.WriteLine("QUI ERA 'el mensajero de los Dioses'?");
            Console.WriteLine("");
            Console.WriteLine("A-> Zeus");
            Console.WriteLine("B-> Poseidon");
            Console.WriteLine("C-> Hades");
            Console.WriteLine("D-> Hermes");
            pregunta2c = Console.ReadLine();

            switch (pregunta2c)
            {
                case "A":
                case "a":
                case "B":
                case "b":
                case "C":
                case "c":

                    resposta = "MALAMENT";
                    break;

                case "D":
                case "d":
                    punts3++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }
            Console.WriteLine(resposta + " !! Tens " + punts3 + " Punts!");
            Console.WriteLine("");

            Console.WriteLine("--PREGUNTA 3--");
            Console.WriteLine("QUI ERA 'dios del inframundo'?");
            Console.WriteLine("");
            Console.WriteLine("A-> Zeus");
            Console.WriteLine("B-> Poseidon");
            Console.WriteLine("C-> Hades");
            Console.WriteLine("D-> Hermes");
            pregunta3c = Console.ReadLine();

            switch (pregunta3c)
            {
                case "A":
                case "a":
                case "B":
                case "b":
                case "D":
                case "d":

                    resposta = "MALAMENT";
                    break;

                case "C":
                case "c":
                    punts3++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }
            Console.WriteLine(resposta + " !! Tens " + punts3 + " Punts!");
            Console.WriteLine("");

            Console.WriteLine("--PREGUNTA 4--");
            Console.WriteLine("QUI ERA 'dios del inframundo'?");
            Console.WriteLine("");
            Console.WriteLine("A-> Zeus");
            Console.WriteLine("B-> Poseidon");
            Console.WriteLine("C-> Hades");
            Console.WriteLine("D-> Hermes");
            pregunta4c = Console.ReadLine();

            switch (pregunta4c)
            {
                case "A":
                case "a":
                case "B":
                case "b":
                case "D":
                case "d":

                    resposta = "MALAMENT";
                    break;

                case "C":
                case "c":
                    punts3++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }
            Console.WriteLine(resposta + " !! Tens " + punts3 + " Punts!");


            Console.WriteLine("--PREGUNTA 5--");
            Console.WriteLine("QUI ERA L''Héroe de los Dioses'?");
            Console.WriteLine("");
            Console.WriteLine("A-> Dionisio");
            Console.WriteLine("B-> Atenea");
            Console.WriteLine("C-> Hefasto");
            Console.WriteLine("D-> Apolo");
            pregunta3c = Console.ReadLine();

            switch (pregunta3c)
            {
                case "A":
                case "a":
                case "B":
                case "b":
                case "D":
                case "d":

                    resposta = "MALAMENT";
                    break;

                case "C":
                case "c":
                    punts3++;
                    resposta = "MOLT BÉ";
                    break;

                default:
                    resposta = "HAS INTRODUIT UN MAL CARÀCTER!";
                    break;

            }
            Console.WriteLine(resposta + " !! Tens " + punts3 + " Punts!");


            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("---HAS ACABAT LES PREGUNTES SOBRE DEUS DE LA MITOLOGIA GREGA AMB UN " + punts3 + " SOBRE 15---");



            puntsTotal = punts + punts2 + punts3;


            if (puntsTotal > 7)

                Console.WriteLine("-----FELICITATS! HAS ACABAT AMB UN " + puntsTotal + " SOBRE 15-----");


            else
                Console.WriteLine("--HAS ACABAT AMB UN " + puntsTotal + " SOBRE 15, HAS SUSPÉS!");




        }
    }
}
