using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scholarship
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("                      WELCOME TO THE SCHOLARSHIP INTERVIEWER APPLICATION. PLEASE FOLLOW THE INSTRUCTIONS BELOW\n");
            Console.WriteLine("           CHOOSE FROM THE FOLLOWING OPTIONS TO DETERMINE YOUR ACTIVITY HERE\n");
            Console.WriteLine("1.   ACQUIRING SCHOLARSHIP ONLY");
            Console.WriteLine("2.   GAINING SCHOLARSHIP AND A PROVISION FOR A PART TIME JOB");
            Console.WriteLine("3.   GAINING SCHOLARSHIP WITH A PROVISION OF A FULL TIME JOB AFTER SCHOOL\n\n");

         

            string option = Console.ReadLine();
            Console.WriteLine("==============================================================================");
            Console.WriteLine("==============================================================================");


            //if (option == "1")
            //    {
            //    Console.WriteLine("                                                   ENTER YOUR FULL NAME\n");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("==============================================================================");
            //    Console.WriteLine("==============================================================================");

            //    Console.WriteLine("                                            SELECT YOUR NATIONALITY\n");


            //        string nat = Console.ReadLine();
            //    Console.WriteLine("==============================================================================");
            //    Console.WriteLine("==============================================================================");

            //    Console.WriteLine("                                                DATE OF BIRTH\n");
            //        string date = Console.ReadLine();

            //    Console.WriteLine("==============================================================================");
            //    Console.WriteLine("==============================================================================");
            //    Console.WriteLine("                                                GENDER:\n");
            //        string gen = Console.ReadLine();
            //    Console.WriteLine("==============================================================================");
            //    Console.WriteLine("==============================================================================");
            //    Console.WriteLine("                                           YOUR REGISTRATION NUMBER\n");
            //    string num = Console.ReadLine();
            //    Console.WriteLine("==============================================================================");
            //    Console.WriteLine("==============================================================================");
            //    Console.WriteLine("                                        SELECT YOUR UNIVERSITY OF CHOICE\n");
            //        Console.WriteLine("THE UNIVERSITIES INCLUDE");
            //        Console.WriteLine("A.      UNIVERSITY OF OXFORD");
            //        Console.WriteLine("B.      UNIVERSITY OF MANCHESTER");
            //        Console.WriteLine("C.      UNIVERSITY OF BIRMINGHAM\n");

            //    string uni = Console.ReadLine();
            //    Console.WriteLine("==============================================================================");
            //    Console.WriteLine("==============================================================================");
            //    if (uni == "A")
            //        {
            //            Console.WriteLine("                              THERE IS NO MORE ROOM FOR SCHOLARSHIP OFFER IN THIS SCHOOL \n");
            //        }
            //        else if (uni == "B")
            //        {
            //            Console.WriteLine("                                 WHAT COURSE DO YOU WANT TO STUDY IN THIS UNIVERSITY\n");
            //            Console.WriteLine("                                       1.    MEDICINE");
            //            Console.WriteLine("                                       2.    LAW");
            //            Console.WriteLine("                                       3.    ENGINEERING");
            //            Console.WriteLine("                                       4.    BUSINESS ADMINISTRATION\n");

            //            string course = Console.ReadLine();
            //        Console.WriteLine("==============================================================================");
            //        Console.WriteLine("==============================================================================");
            //        if (course == "1")
            //            {
            //                Console.WriteLine("                                 WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
            //                string score = Console.ReadLine();
            //            Console.WriteLine("==============================================================================");
            //            Console.WriteLine("==============================================================================");
            //            if (int.Parse(score) >= 310)
            //                {
            //                    Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
            //                    Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
            //                    Console.WriteLine("httytlsdkk2038ha75\n\n");
            //                    Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
            //                    Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
            //                    Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
            //                    Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
            //                }
            //            }
            //            if (course == "2")
            //            {
            //                Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
            //                string score = Console.ReadLine();
            //                if (int.Parse(score) >= 270)
            //                {
            //                    Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
            //                    Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
            //                    Console.WriteLine("httytlsdkk2038ha75\n\n");
            //                    Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
            //                    Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
            //                    Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
            //                    Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
            //                }
            //                else
            //                {
            //                        Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
            //                }
            //            }
            //            if (course == "3")
            //            {
            //                    Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
            //                    string score = Console.ReadLine();
            //                    if (int.Parse(score) >= 250)
            //                    {
            //                    Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
            //                    Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
            //                    Console.WriteLine("httytlsdkk2038ha75\n\n");
            //                    Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
            //                    Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
            //                    Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
            //                    Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
            //                    }
            //            }
            //            if (course == "4")
            //            {
            //                    Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
            //                    string score = Console.ReadLine();
            //                    if (int.Parse(score) >= 230)
            //                    {
            //                    Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
            //                    Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
            //                    Console.WriteLine("httytlsdkk2038ha75\n\n");
            //                    Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
            //                    Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
            //                    Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
            //                    Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
            //                    }
            //            }


            //        }
            //        else if (uni == "C")
            //        {
            //            Console.WriteLine("WHAT COURSE DO YOU WANT TO STUDY IN THIS UNIVERSITY");
            //            Console.WriteLine("1.    MEDICINE");
            //            Console.WriteLine("2.    LAW");
            //            Console.WriteLine("3.   ASTRO PHYSICS");
            //            Console.WriteLine("4.    AGRICULTURAL DEVELOPMENT");
            //            Console.WriteLine("5.    COMPUTER ENGINEERING AND DATA PROCESSING");
            //            string course = Console.ReadLine();
            //        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
            //            if (course == "1")
            //            {
            //                    Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
            //                    string score = Console.ReadLine();
            //                    if (int.Parse(score) >= 340)
            //                    {
            //                    Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
            //                    Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
            //                    Console.WriteLine("httytlsdkk2038ha75\n\n");
            //                    Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
            //                    Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
            //                    Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
            //                    Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
            //                    }
            //            }
            //            if (course == "2")
            //            {
            //                    Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
            //                    string score = Console.ReadLine();
            //                    if (int.Parse(score) >= 300)
            //                    {
            //                    Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
            //                    Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
            //                    Console.WriteLine("httytlsdkk2038ha75\n\n");
            //                    Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
            //                    Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
            //                    Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
            //                    Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
            //                    }
            //            }
            //            if (course == "3")
            //            {
            //                    Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
            //                    string score = Console.ReadLine();
            //                    if (int.Parse(score) >= 330)
            //                    {
            //                    Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
            //                    Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
            //                    Console.WriteLine("httytlsdkk2038ha75\n\n");
            //                    Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
            //                    Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
            //                    Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
            //                    Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
            //                    }
            //            }
            //            if (course == "4")
            //            {
            //                    Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
            //                    string score = Console.ReadLine();
            //                    if (int.Parse(score) >= 260)
            //                    {
            //                    Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
            //                    Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
            //                    Console.WriteLine("httytlsdkk2038ha75\n\n");
            //                    Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
            //                    Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
            //                    Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
            //                    Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
            //                    }
            //            }
            //            if (course == "5")
            //            {
            //                    Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
            //                    string score = Console.ReadLine();
            //                    if (int.Parse(score) >= 290)
            //                    {
            //                        Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
            //                    Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
            //                    Console.WriteLine("httytlsdkk2038ha75\n\n");
            //                    Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
            //                    Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
            //                    Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
            //                    Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");

            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
            //                    }
            //            }
            //        }

            //}



            if (option == "2")
            {
                Console.WriteLine("                                                   ENTER YOUR FULL NAME\n");
                string name = Console.ReadLine();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("==============================================================================");

                Console.WriteLine("                                            SELECT YOUR NATIONALITY\n");


                string nat = Console.ReadLine();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("==============================================================================");

                Console.WriteLine("                                                DATE OF BIRTH\n");
                string date = Console.ReadLine();

                Console.WriteLine("==============================================================================");
                Console.WriteLine("==============================================================================");
                Console.WriteLine("                                                GENDER:\n");
                string gen = Console.ReadLine();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("==============================================================================");
                Console.WriteLine("                                           YOUR REGISTRATION NUMBER\n");
                string num = Console.ReadLine();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("==============================================================================");
                Console.WriteLine("                                        SELECT YOUR UNIVERSITY OF CHOICE\n");
                Console.WriteLine("THE UNIVERSITIES INCLUDE");
                Console.WriteLine("A.      UNIVERSITY OF INDIA, DELHI");
                Console.WriteLine("B.      HAVARD UNIVERSITY, CHICAGO");
                Console.WriteLine("C.      UNIVERSITY OF BIRMINGHAM\n");

                string uni = Console.ReadLine();
                Console.WriteLine("==============================================================================");
                Console.WriteLine("==============================================================================");
                if (uni == "A")
                {
                    Console.WriteLine("                                 WHAT COURSE DO YOU WANT TO STUDY IN THIS UNIVERSITY\n");
                    Console.WriteLine("                                       1.    MEDICINE AND SURGERY");
                    Console.WriteLine("                                       2.    PETRO CHEMICAL ENGINEERING");
                    Console.WriteLine("                                       3.    BANKING AND FINANCE");
                    Console.WriteLine("                                       4.    NURSING");
                    Console.WriteLine("                                       5. ENVIRONMENTAL SANITATION AND POLLUTION CONTROL\n");

                    string course = Console.ReadLine();
                    Console.WriteLine("==============================================================================");
                    Console.WriteLine("==============================================================================");
                    if (course == "1")
                    {
                        Console.WriteLine("                                 WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("==============================================================================");
                        if (int.Parse(score) >= 350)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "2")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 290)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "3")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 280)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "4")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 340)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "5")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 240)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                }
                else if (uni == "B")
                {
                    Console.WriteLine("                                 WHAT COURSE DO YOU WANT TO STUDY IN THIS UNIVERSITY\n");
                    Console.WriteLine("                                       1.    ASTRONOMY AND COSMOLOGICAL SCIENCE");
                    Console.WriteLine("                                       2.    MEDICINE AND SURGERY");
                    Console.WriteLine("                                       3.    PROGRAMMING AND COMPUTER DEVELOPMENT");
                    Console.WriteLine("                                       4.    MARKETING AND BUSINESS ADMINISTRATION\n");
                    Console.WriteLine("                                       5.    DISASTER MANAGEMENT");

                    string course = Console.ReadLine();
                    Console.WriteLine("==============================================================================");
                    Console.WriteLine("==============================================================================");
                    if (course == "1")
                    {
                        Console.WriteLine("                                 WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        Console.WriteLine("==============================================================================");
                        Console.WriteLine("==============================================================================");
                        if (int.Parse(score) >= 350)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "2")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 370)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "3")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 330)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "4")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 270)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "5")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 220)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }


                }
                else if (uni == "C")
                {
                    Console.WriteLine("WHAT COURSE DO YOU WANT TO STUDY IN THIS UNIVERSITY");
                    Console.WriteLine("1.    MEDICINE");
                    Console.WriteLine("2.    LAW");
                    Console.WriteLine("3.   ASTRO PHYSICS");
                    Console.WriteLine("4.    AGRICULTURAL DEVELOPMENT");
                    Console.WriteLine("5.    COMPUTER ENGINEERING AND DATA PROCESSING");
                    string course = Console.ReadLine();
                    Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                    if (course == "1")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 340)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "2")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 300)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "3")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 330)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "4")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 260)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");
                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                    if (course == "5")
                    {
                        Console.WriteLine("WHAT WAS YOUR SCORE IN OUR SCHOLARSHIP EXAM");
                        string score = Console.ReadLine();
                        if (int.Parse(score) >= 290)
                        {
                            Console.WriteLine("CONGRATULATION!! YOU HAVE BEEN GRANTED SCHOLARSHIP TO STUDY IN OUR UNIVERSITY\n");
                            Console.WriteLine("KINDLY COPY THE LINK BELOW AND GO TO ANY OF OUR OFFICES ACROSS THE COUNTRY TO PRINT YOUR VISA\n");
                            Console.WriteLine("httytlsdkk2038ha75\n\n");
                            Console.WriteLine("(1). 5 AMUWO ODOFIN, OSHODI APAPA EXPRESSWAY, IJESHA, LAGOS");
                            Console.WriteLine("(2).  17 AHMADU BELLO WAY, PIZZA PALACE, PORT HARCOURT, RIVERS");
                            Console.WriteLine("(3).  25, ABUJA KADUNA ROAD, ABUJA");
                            Console.WriteLine("(4).  25 USMAN DANFODIO ROAD, KANO");

                        }
                        else
                        {
                            Console.WriteLine("YOU ARE NOT QUALIFIED FOR THE SCHOLARSHIP. PLEASE TRY AGAIN NEXT TIME");
                        }
                    }
                }

            }


            Console.ReadLine();
         
        }
    }
}
