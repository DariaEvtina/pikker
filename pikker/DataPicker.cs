using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace pikker
{
    public class DataPicker : ContentPage
    {
        StackLayout st;
        DatePicker dp;
        Label emoj;
        Label sign;
        Label lbl;
        string[] zodiaks = { "pisces", "tarturus", "gemini", "cancer", "leo", "aries", "libra", "scorpio", "sagittarius", "capricorn", "aquarius","virgo" };
        string[] emoji = { "♓️", "♉️", "♋️", "♌️", "♈️", "♎️", "♏️", "♐️", "♑️", "⛎️", "♏️" };

        //(dp.Date).ToString()

        public DataPicker()
        {
            dp = new DatePicker
            {
                Format = "mm/dd/yyyy",
                MinimumDate = DateTime.Now.AddDays(-111),
                MaximumDate = DateTime.Now.AddDays(253)
            };
            lbl = new Label
            {
                Text = ""
            };
            emoj = new Label { };
            sign = new Label { };
            st = new StackLayout
            {
                Children = { dp, lbl }
            };
            dp.DateSelected += Dp_DateSelected;
            Content = st;
        }

        private void Dp_DateSelected(object sender, DateChangedEventArgs e)
        {
            var m = e.NewDate.Month;
            var d = e.NewDate.Day;
            if (m == 1 && d >= 1 || m == 12 && d <= 22)
            {
                lbl.Text = $"{emoji[9]} - {zodiaks[9]}\nAasta algab erakordselt hästi märgi esindajatele, kes on valmis langetama otsuseid ja võtma vastutust. Parem on mitte jaanuaripühi venitada ja asuda asja kallale niipea kui võimalik. Kui kiirustate, võite konkurentidest ette jõuda, jättes isegi väga tugevad rivaalid kaugele maha. Jaanuar ja veebruar annavad võimaluse hankida väga mõjukate inimeste toetus. Jagage oma ideid, jagage oma plaane. Kindlasti leidub inimesi, kes soovivad teid teie plaani elluviimisel aidata.";
            }
            else if (m == 3 && d >= 21 || m == 4 && d <= 20)
            {
                lbl.Text = $"{emoji[5]} - {zodiaks[5]}\nÄra kiirusta. See universaalne nõuanne muutub eriti aktuaalseks 2022. aasta alguses. Ilmub palju ideid, soove ja plaane, soovid saavutada mitu eesmärki korraga ja sa lihtsalt ei pööra tähelepanu asjaoludele, mis alati soodsalt välja ei tule. Muidugi on see huvitav, kuid peate kulutama palju vaeva asjata. Seetõttu on parem prioriteetide üle otsustada aasta esimestel päevadel, mõelda, mis asjad tuleb kohe ära teha ja millised võivad oodata.";
            }
            else if (m == 4 && d >= 21 || m == 5 && d <= 21)
            {
                lbl.Text = $"{emoji[1]} - {zodiaks[1]}\nIntuitsioon ütleb sulle, et jaanuar pole parim aeg täiesti uute asjade ettevõtmiseks ja elus midagi kardinaalselt muutmiseks. Aasta algus on mõtisklemiseks suurepärane. Märkate palju asju, millele te varem tähelepanu ei pööranud, ja teete õiged järeldused. Võimalikud on edukad kokkusattumused, asjaolude kombinatsioon, mis toob kaasa huvitavaid mõtteid.";
            }
            else if (m == 5 && d >= 22 || m == 5 && d <= 22)
            {
                lbl.Text = $"{emoji[3]} - {zodiaks[3]}\nAasta algab hästi. Tähed on teie poolel ja tänu nende toetusele saite eelmisel aastal üliraskena tundunud asjadega suurepäraselt hakkama. Võimalikud on ebatavalised kohtumised, tutvused, mis avavad palju uusi võimalusi. Võimalik, et just sel ajal tehakse otsuseid, tänu millele läheb teie karjäär lähiajal ülesmäge.";
            }
            else if (m == 6 && d >= 22 || m == 7 && d <= 22)
            {
                lbl.Text = $"{emoji[3]} - {zodiaks[3]}\nAasta algus pole just eriti raske periood, kuid kindlasti nõuab ettevaatlikkust ja ettenägelikkust. Püüdke mitte panna talle liiga suuri lootusi, ärge lootke kergetele võitudele. Võimalik on edu töös, samuti muutused paremuse poole isiklikes suhetes, kuid mõlemad nõuavad sinult pealehakkamist, järjekindlat tegutsemist ja tahtlikku tegutsemist. Usaldusväärsete inimeste abi ei ole üleliigne. Mõelge, kelle poole saate sellega pöörduda.";
            }
            else if (m == 7 && d >= 23 || m == 8 && d <= 23)
            {
                lbl.Text = $"{emoji[4]} - {zodiaks[4]}\nAasta võib alata kiviselt, eriti Lõvide jaoks, kes ootasid pikisilmi oluliste eesmärkide saavutamist vähese või ilma pingutuseta. Paljud asjad osutuvad keerulisemaks, kui varem arvasid ja nendega pead ise hakkama saama, on vähetõenäoline, et keegi sind aitab. Tihti on abiks minevikus omandatud kogemused. Lihtsam on Leodel, kes on valmis oma vigu tunnistama ja neist õppima.";
            }
            else if (m == 8 && d >= 24 || m == 9 && d <= 22)
            {
                lbl.Text = $"{emoji[11]} - {zodiaks[11]}\nAasta esimesed kuud on ebaühtlased ja kiired. Isegi kui sul on mingid konkreetsed plaanid, siis kuni märtsini vaevalt jõuad nende elluviimisele keskenduda. Kas asjaolud ebaõnnestuvad või liitlased ebaõnnestuvad või peate aitama raskesse olukorda sattunud lähedasi.";
            }
            else if (m == 9 && d >= 23 || m == 10 && d <= 23)
            {
                lbl.Text = $"{emoji[11]} - {zodiaks[11]}\n
            }
        }
    
    }
}