using System.IO;

namespace vaja6 {

  
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
		
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1;
//nastavi neke vrednosti
        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

        public int Id {
            get
            {
                return id;
            }
        }
// vrne id
        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }
// trima ima, in ga vrne
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }
// trima geslo in ga vrne
        public static int StIg
        {
            get { return stIg; }
        }
		// vrne trenutno stevilo ustvarjenih igralcev
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
