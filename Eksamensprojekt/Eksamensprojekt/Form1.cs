using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;
using System.Windows.Forms;


namespace Eksamensprojekt
{
    public partial class frm_Main : Form
    {
        //Jeg laver en private static readonly Random Number Generator. Et random number generator (RNG)
        //er noget, så man kan skaffe et eller andet tal som er tilfældigt. I det her, så laver jeg en ny
        //Random og navngiver den for "scam".
        //Random kommer fra: http://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number-in-c
        private static readonly Random scam = new Random();

        //Følgende SoundPlayer kommer fra: https://www.dotnetperls.com/soundplayer
        //Følgende Lyd kommer kommer fra: https://www.youtube.com/watch?v=ECQ-HuArv3s
        //NoPoints lyd kommer fra: https://www.youtube.com/watch?v=560kW1TmyFc
        SoundPlayer WinSound = new SoundPlayer(Sounds.WinSound);
        SoundPlayer SpinSound = new SoundPlayer(Sounds.SpinSound);
        SoundPlayer NoPoints = new SoundPlayer(Sounds.NoPoints);

        //Ressource kommer fra: https://www.youtube.com/watch?v=LQMDsJgMXhE
        public frm_Main()
        {
            InitializeComponent();

            //Følgende grafik kommer fra: https://www.reddit.com/r/GlobalOffensive/comments/27xilh/m4a4_howl_is_now_a_contraband_rarity_rifle/
            //og https://www.reddit.com/r/GlobalOffensive/comments/45kni3/change_the_service_medals_rarities_to_correspond/
            ptb_GrayPrize.Image = Pictures.Gray;
            ptb_LightBluePrize.Image = Pictures.Blue;
            ptb_DarkBluePrize.Image = Pictures.Darkblue;
            ptb_PurplePrize.Image = Pictures.Purple;
            ptb_PinkPrize.Image = Pictures.Pink;
            ptb_RedPrize.Image = Pictures.Red;
            ptb_OrangePrize.Image = Pictures.Orange;
        }
        
        //Ubrugt kode
        //Bruges til at checke om frm_Præmier er lukket
        //Kommer fra tidligere programmerings timer
        //public static bool checkfrm_Præmer = true;

        //frm_Præmier Præmier = new frm_Præmier();

        //Min "Storage" så jeg kan checke om der er 3 ens.
        string Boks4Checker = "";
        string Boks5Checker = "";
        string Boks6Checker = "";

        //Point
        int Point = 500;

        private void frm_Main_Load(object sender, EventArgs e)
        {
            lbl_Point.Text = "Point = " + Point.ToString();
        }

        private void btn_Push_Click(object sender, EventArgs e)
        {
            if (Point <= 0)
            {
                NoPoints.Play();
                MessageBox.Show("Skaf nogle flere point");
            }
            else
             {
                //Afspiller SpinSound og bruger Play-sync istedet for play så programmet står alene. Kommer fra: https://www.dotnetperls.com/soundplayer
                //Tilkald metoderne som hedder method_Boks(Tal).
                //Trækker Point fra med 25.
                //Checker om der er 3 ens.
                //Vis Point på lbl_Point
                SpinSound.PlaySync();
                Point = Point - 25;
                method_Boks1();
                method_Boks2();
                method_Boks3();
                method_Boks4();
                method_Boks5();
                method_Boks6();
                method_Boks7();
                method_Boks8();
                method_Boks9();
                method_Check3InMiddle();
                lbl_Point.Text = "Point = " + Point.ToString();
            }
        }

        void method_Check3InMiddle()
        {
            //Gray
            if (Boks4Checker == "Gray" && Boks5Checker == "Gray" && Boks6Checker == "Gray")
            {
                Point = Point + 25;
                Point = Point + 50;
                WinSound.Play();
            }
            //Light Blue
            if (Boks4Checker == "Light Blue" && Boks5Checker == "Light Blue" && Boks6Checker == "Light Blue")
            {
                Point = Point + 25;
                Point = Point + 100;
                WinSound.Play();
            }
            //Dark Blue
            if (Boks4Checker == "Dark Blue" && Boks5Checker == "Dark Blue" && Boks6Checker == "Dark Blue")
            {
                Point = Point + 25;
                Point = Point + 250;
                WinSound.Play();
            }
            //Purple
            if (Boks4Checker == "Purple" && Boks5Checker == "Purple" && Boks6Checker == "Purple")
            {
                Point = Point + 25;
                Point = Point + 500;
                WinSound.Play();
            }
            //Pink
            if (Boks4Checker == "Pink" && Boks5Checker == "Pink" && Boks6Checker == "Pink")
            {
                Point = Point + 25;
                Point = Point + 1000;
                WinSound.Play();
            }
            //Red
            if (Boks4Checker == "Red" && Boks5Checker == "Red" && Boks6Checker == "Red")
            {
                Point = Point + 25;
                Point = Point + 2000;
                WinSound.Play();
            }
            //Orange
            if (Boks4Checker == "Orange" && Boks5Checker == "Orange" && Boks6Checker == "Orange")
            {
                Point = Point + 25;
                Point = Point + 5000;
                WinSound.Play();
            }
            else
            {
                Point = Point + 0;
            }
            
        }

        /*Følgende grafik kommer fra: https://www.reddit.com/r/GlobalOffensive/comments/27xilh/m4a4_howl_is_now_a_contraband_rarity_rifle/
        og https://www.reddit.com/r/GlobalOffensive/comments/45kni3/change_the_service_medals_rarities_to_correspond/
        int rand_Boks(tal) = scam.Next(1, 50); kommer fra: http://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number-in-c */
        void method_Boks1()
        {
            //her laver jeg en int som er navngivet rand_Boks1.
            //Den skaffer så informationen fra rng som vi havde navngivet højere oppe
            //på programmet og det som står inde i parenteser er intervallet
            //I det her tilfælde, så er det fra 1 til 50.
            //Intervallerne har jeg fået hjælp fra Michael Bach Kristensen
            int rand_Boks1 = scam.Next(1, 50);

            //Gray
            if (rand_Boks1 < 20)
            {
                ptb_Boks1.Image = Pictures.Gray;
            }
            //Light Blue
            if (rand_Boks1 >= 20 && rand_Boks1 < 30)
            {
                ptb_Boks1.Image = Pictures.Blue;
            }
            //Dark Blue
            if (rand_Boks1 >= 30 && rand_Boks1 < 35)
            {
                ptb_Boks1.Image = Pictures.Darkblue;
            }
            //Purple
            if (rand_Boks1 >= 35 && rand_Boks1 < 40)
            {
                ptb_Boks1.Image = Pictures.Purple;
            }
            //Pink
            if (rand_Boks1 >= 40 && rand_Boks1 < 45)
            {
                ptb_Boks1.Image = Pictures.Pink;
            }
            //Red
            if (rand_Boks1 >= 45 && rand_Boks1 < 49)
            {
                ptb_Boks1.Image = Pictures.Red;
            }
            //Orange
            if (rand_Boks1 >= 49)
            {
                ptb_Boks1.Image = Pictures.Orange;
            }
        }

        void method_Boks2()
        {
            int rand_Boks2 = scam.Next(1, 50);

            //Gray
            if (rand_Boks2 < 20)
            {
                ptb_Boks2.Image = Pictures.Gray;
            }
            //Light Blue
            if (rand_Boks2 >= 20 && rand_Boks2 < 30)
            {
                ptb_Boks2.Image = Pictures.Blue;
            }
            //Dark Blue
            if (rand_Boks2 >= 30 && rand_Boks2 < 35)
            {
                ptb_Boks2.Image = Pictures.Darkblue;
            }
            //Purple
            if (rand_Boks2 >= 35 && rand_Boks2 < 40)
            {
                ptb_Boks2.Image = Pictures.Purple;
            }
            //Pink
            if (rand_Boks2 >= 40 && rand_Boks2 < 45)
            {
                ptb_Boks2.Image = Pictures.Pink;
            }
            //Red
            if (rand_Boks2 >= 45 && rand_Boks2 < 49)
            {
                ptb_Boks2.Image = Pictures.Red;
            }
            //Orange
            if (rand_Boks2 >= 49)
            {
                ptb_Boks2.Image = Pictures.Orange;
            }
        }

        void method_Boks3()
        {
            int rand_Boks3 = scam.Next(1, 50);

            //Gray
            if (rand_Boks3 < 20)
            {
                ptb_Boks3.Image = Pictures.Gray;
            }
            //Light Blue
            if (rand_Boks3 >= 20 && rand_Boks3 < 30)
            {
                ptb_Boks3.Image = Pictures.Blue;
            }
            //Dark Blue
            if (rand_Boks3 >= 30 && rand_Boks3 < 35)
            {
                ptb_Boks3.Image = Pictures.Darkblue;
            }
            //Purple
            if (rand_Boks3 >= 35 && rand_Boks3 < 40)
            {
                ptb_Boks3.Image = Pictures.Purple;
            }
            //Pink
            if (rand_Boks3 >= 40 && rand_Boks3 < 45)
            {
                ptb_Boks3.Image = Pictures.Pink;
            }
            //Red
            if (rand_Boks3 >= 45 && rand_Boks3 < 49)
            {
                ptb_Boks3.Image = Pictures.Red;
            }
            //Orange
            if (rand_Boks3 >= 49)
            {
                ptb_Boks3.Image = Pictures.Orange;
            }
        }

        void method_Boks4()
        {
            int rand_Boks4 = scam.Next(1, 50);

            //Gray
            if (rand_Boks4 < 20)
            {
                ptb_Boks4.Image = Pictures.Gray;
                Boks4Checker = "Gray";
            }
            //Light Blue
            if (rand_Boks4 >= 20 && rand_Boks4 < 30)
            {
                ptb_Boks4.Image = Pictures.Blue;
                Boks4Checker = "Light Blue";
            }
            //Dark Blue
            if (rand_Boks4 >= 30 && rand_Boks4 < 35)
            {
                ptb_Boks4.Image = Pictures.Darkblue;
                Boks4Checker = "Dark Blue";
            }
            //Purple
            if (rand_Boks4 >= 35 && rand_Boks4 < 40)
            {
                ptb_Boks4.Image = Pictures.Purple;
                Boks4Checker = "Purple";
            }
            //Pink
            if (rand_Boks4 >= 40 && rand_Boks4 < 45)
            {
                ptb_Boks4.Image = Pictures.Pink;
                Boks4Checker = "Pink";
            }
            //Red
            if (rand_Boks4 >= 45 && rand_Boks4 < 49)
            {
                ptb_Boks4.Image = Pictures.Red;
                Boks4Checker = "Red";
            }
            //Orange
            if (rand_Boks4 >= 49)
            {
                ptb_Boks4.Image = Pictures.Orange;
                Boks4Checker = "Orange";
            }
        }

        void method_Boks5()
        {
            int rand_Boks5 = scam.Next(1, 50);

            //Gray
            if (rand_Boks5 < 20)
            {
                ptb_Boks5.Image = Pictures.Gray;
                Boks5Checker = "Gray";
            }
            //Light Blue
            if (rand_Boks5 >= 20 && rand_Boks5 < 30)
            {
                ptb_Boks5.Image = Pictures.Blue;
                Boks5Checker = "Light Blue";
            }
            //Dark Blue
            if (rand_Boks5 >= 30 && rand_Boks5 < 35)
            {
                ptb_Boks5.Image = Pictures.Darkblue;
                Boks5Checker = "Dark Blue";
            }
            //Purple
            if (rand_Boks5 >= 35 && rand_Boks5 < 40)
            {
                ptb_Boks5.Image = Pictures.Purple; 
                Boks5Checker = "Purple";
            }
            //Pink
            if (rand_Boks5 >= 40 && rand_Boks5 < 45)
            {
                ptb_Boks5.Image = Pictures.Pink;
                Boks5Checker = "Pink";
            }
            //Red
            if (rand_Boks5 >= 45 && rand_Boks5 < 49)
            {
                ptb_Boks5.Image = Pictures.Red;
                Boks5Checker = "Red";
            }
            //Orange
            if (rand_Boks5 >= 49)
            {
                ptb_Boks5.Image = Pictures.Orange;
                Boks5Checker = "Orange";
            }
        }

        void method_Boks6()
        {
            int rand_Boks6 = scam.Next(1, 50);

            //Gray
            if (rand_Boks6 < 20)
            {
                ptb_Boks6.Image = Pictures.Gray;
                Boks6Checker = "Gray";
            }
            //Light Blue
            if (rand_Boks6 >= 20 && rand_Boks6 < 30)
            {
                ptb_Boks6.Image = Pictures.Blue;
                Boks6Checker = "Light Blue";
            }
            //Dark Blue
            if (rand_Boks6 >= 30 && rand_Boks6 < 35)
            {
                ptb_Boks6.Image = Pictures.Darkblue;
                Boks6Checker = "Dark Blue";
            }
            //Purple
            if (rand_Boks6 >= 35 && rand_Boks6 < 40)
            {
                ptb_Boks6.Image = Pictures.Purple;
                Boks6Checker = "Purple";
            }
            //Pink
            if (rand_Boks6 >= 40 && rand_Boks6 < 45)
            {
                ptb_Boks6.Image = Pictures.Pink;
                Boks6Checker = "Pink";
            }
            //Red
            if (rand_Boks6 >= 45 && rand_Boks6 < 49)
            {
                ptb_Boks6.Image = Pictures.Red;
                Boks6Checker = "Red";
            }
            //Orange
            if (rand_Boks6 >= 49)
            {
                ptb_Boks6.Image = Pictures.Orange;
                Boks6Checker = "Orange";
            }
        }

        void method_Boks7()
        {
            int rand_Boks7 = scam.Next(1, 50);

            //Gray
            if (rand_Boks7 < 20)
            {
                ptb_Boks7.Image = Pictures.Gray;
            }
            //Light Blue
            if (rand_Boks7 >= 20 && rand_Boks7 < 30)
            {
                ptb_Boks7.Image = Pictures.Blue;
            }
            //Dark Blue
            if (rand_Boks7 >= 30 && rand_Boks7 < 35)
            {
                ptb_Boks7.Image = Pictures.Darkblue;
            }
            //Purple
            if (rand_Boks7 >= 35 && rand_Boks7 < 40)
            {
                ptb_Boks7.Image = Pictures.Purple;
            }
            //Pink
            if (rand_Boks7 >= 40 && rand_Boks7 < 45)
            {
                ptb_Boks7.Image = Pictures.Pink;
            }
            //Red
            if (rand_Boks7 >= 45 && rand_Boks7 < 49)
            {
                ptb_Boks7.Image = Pictures.Red;
            }
            //Orange
            if (rand_Boks7 >= 49)
            {
                ptb_Boks7.Image = Pictures.Orange;
            }
        }

        void method_Boks8()
        {
            int rand_Boks8 = scam.Next(1, 50);

            //Gray
            if (rand_Boks8 < 20)
            {
                ptb_Boks8.Image = Pictures.Gray;
            }
            //Light Blue
            if (rand_Boks8 >= 20 && rand_Boks8 < 30)
            {
                ptb_Boks8.Image = Pictures.Blue;
            }
            //Dark Blue
            if (rand_Boks8 >= 30 && rand_Boks8 < 35)
            {
                ptb_Boks8.Image = Pictures.Darkblue;
            }
            //Purple
            if (rand_Boks8 >= 35 && rand_Boks8 < 40)
            {
                ptb_Boks8.Image = Pictures.Purple;
            }
            //Pink
            if (rand_Boks8 >= 40 && rand_Boks8 < 45)
            {
                ptb_Boks8.Image = Pictures.Pink;
            }
            //Red
            if (rand_Boks8 >= 45 && rand_Boks8 < 49)
            {
                ptb_Boks8.Image = Pictures.Red;
            }
            //Orange
            if (rand_Boks8 >= 49)
            {
                ptb_Boks8.Image = Pictures.Orange;
            }
        }

        void method_Boks9()
        {
            int rand_Boks9 = scam.Next(1, 50);

            //Gray
            if (rand_Boks9 < 20)
            {
                ptb_Boks9.Image = Pictures.Gray;
            }
            //Light Blue
            if (rand_Boks9 >= 20 && rand_Boks9 < 30)
            {
                ptb_Boks9.Image = Pictures.Blue;
            }
            //Dark Blue
            if (rand_Boks9 >= 30 && rand_Boks9 < 35)
            {
                ptb_Boks9.Image = Pictures.Darkblue;
            }
            //Purple
            if (rand_Boks9 >= 35 && rand_Boks9 < 40)
            {
                ptb_Boks9.Image = Pictures.Purple;
            }
            //Pink
            if (rand_Boks9 >= 40 && rand_Boks9 < 45)
            {
                ptb_Boks9.Image = Pictures.Pink;
            }
            //Red
            if (rand_Boks9 >= 45 && rand_Boks9 < 49)
            {
                ptb_Boks4.Image = Pictures.Red;
            }
            //Orange
            if (rand_Boks9 >= 49)
            {
                ptb_Boks4.Image = Pictures.Orange;
            }
        }

        private void ptb_Boks9_Click(object sender, EventArgs e)
        {

        }

        private void btn_Vis_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Præmier.Show();
            //}
            //catch
            //{
            //    if (checkfrm_Præmer == false)
            //    {
            //        frm_Præmier Præmier = new frm_Præmier();
            //        Præmier.Show();
            //        checkfrm_Præmer = true;
            //    }
            //}
        }

        private void btn_GetPoints_Click(object sender, EventArgs e)
        {
            Point = Point + 9001;
            lbl_Point.Text = "Point = " + Point.ToString();
        }
    }
}
