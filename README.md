# ProCalc
ProCalcBajo
Najjaca Firmetinaa Bajoooooo

NISAM ZNAO DA RACUNAM PA SAM NAPRAVIO KALKULATOR DA BIH RACUNAO POSTIGNUCA SVOH REZIMA ODVIKAVANJA OD KOKA KOLE

Ova aplikacija je ProKalulator, napisan u C# i koristi Windows Forms. Korišćene su sledeće klase i metode iz .NET biblioteke:

System
System.Collections.Generic
System.ComponentModel
System.Data
System.Drawing
System.Linq
System.Text
System.Threading.Tasks
System.Windows.Forms
Korišćeni su sledeći algoritmi:

logika operatora (switch)
provera da li je tekst "0" ili je operator izvršen (if else)
provera da li tekst sadrži "." (if else)
Takođe, postoje funkcije za obračunavanje matematičkih operacija (+, -, *, /), funkcija za brisanje teksta i funkcije za prebacivanje između jedinica valute.
Pored toga, postoje funkcije za proveru da li je dugme kliknuto (bool buttonclicked), što omogućava da se dugme jednom klikne.


METODE

button15_Click: Ova metoda se poziva kada korisnik klikne na neko brojacko dugme. Ako je tekst u textBox_Result "0" ili ako je operator izvršen, tekst će se očistiti. Zatim će se proveriti da li se u tekstu nalazi decimalna tačka, i ako ne postoji, dodaje se decimalna tačka. Ukoliko ne postoji decimalna tačka, dodaje se broj iz dugmeta koje je kliknuto.

Operator_click_Event: Ova metoda se poziva kada korisnik klikne na neki od operatora (+, -, *, /). Ako je rezultat neki broj, operator će se izvršiti na trenutnom rezultatu i trenutnom tekstu u textBox_Result. Ukoliko rezultat nije neki broj, operator će se izvršiti na trenutnom tekstu u textBox_Result.

button5_Click: Ova metoda se poziva kada se klikne na dugme "C". Tekst u textBox_Result će biti postavljen na "0", a neka dugmad će biti omogućena za upotrebu.

button6_Click: Ova metoda se poziva kada se klikne na dugme "CE". Tekst u textBox_Result će biti postavljen na "0", rezultat će biti resetovan na nulu, a neka dugmad će biti omogućena za upotrebu.

button16_Click: Ova metoda se poziva kada se klikne na dugme "=". Na osnovu operatora koji je ranije izvršen, vrši se određena matematička operacija i rezultat se prikazuje u textBox_Result.

button22_Click: Ova metoda se poziva kada se klikne na dugme "DIN -> EUR". Trenutni tekst u textBox_Result će biti podeljen sa 117 kako bi se dobio iznos u evrima. Dugme će biti onemogućeno kada se jednom klikne.

button21_Click: Ova metoda se poziva kada se klikne na dugme "EUR -> DIN". Trenutni tekst u textBox_Result će biti pomnožen sa 117 kako bi se dobio iznos u dinarima. Dugme će biti onemogućeno kada se jednom klikne.

/// binarni u decimalni i obrnuto

Metoda button19_Click je događaj klikom na dugme sa oznakom button19. Ovaj događaj ima dva argumenta: "sender" i "EventArgs e". "Sender" označava objekat koji je pokrenuo ovaj događaj, u ovom slučaju button19. "EventArgs e" predstavlja argument događaja koji se koristi za prosljeđivanje informacija o događaju.

Metoda konvertuje binarni broj koji se nalazi u tekstualnom polju "textBox_Result" u decimalni broj i ispisuje rezultat u istom tekstualnom polju.

Metoda button11_Click funkcioniše na sličan način kao i button19_Click, razlika je u tome što ova metoda konvertuje decimalni broj u binarni broj.

Oba događaja su isključiva jedan prema drugom, što znači da se jedno dugme može koristiti samo u jednom trenutku, dok je drugo onemogućeno. Pored toga, oba događaja također onemogućavaju druge dugmice (button21 i button22) dok jedno od njih nije aktivno.

