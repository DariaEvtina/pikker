using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pikker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPicker : ContentPage
    {
        StackLayout st;
        DatePicker dp;
        Label emoj;
        Label sign;
        Label lbl;
        string[] zodiaks = { "pisces", "tarturus", "gemini", "cancer", "leo", "aries", "libra", "scorpio", "sagittarius", "capricorn", "aquarius", "virgo" };
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
            if (m == 1 && d >= 20 || m == 12 && d <= 22)
            {
                lbl.Text = $"{emoji[10]} - {zodiaks[10]}\nAasta algab erakordselt hästi märgi esindajatele, kes on valmis langetama otsuseid ja võtma vastutust. Parem on mitte jaanuaripühi venitada ja asuda asja kallale niipea kui võimalik. Kui kiirustate, võite konkurentidest ette jõuda, jättes isegi väga tugevad rivaalid kaugele maha. Jaanuar ja veebruar annavad võimaluse hankida väga mõjukate inimeste toetus. Jagage oma ideid, jagage oma plaane. Kindlasti leidub inimesi, kes soovivad teid teie plaani elluviimisel aidata.";
            }
            else if (m == 3 && d >= 21 || m == 4 && d <= 20)
            {
                lbl.Text = $"{emoji[6]} - {zodiaks[6]}\nÄra kiirusta. See universaalne nõuanne muutub eriti aktuaalseks 2022. aasta alguses. Ilmub palju ideid, soove ja plaane, soovid saavutada mitu eesmärki korraga ja sa lihtsalt ei pööra tähelepanu asjaoludele, mis alati soodsalt välja ei tule. Muidugi on see huvitav, kuid peate kulutama palju vaeva asjata. Seetõttu on parem prioriteetide üle otsustada aasta esimestel päevadel, mõelda, mis asjad tuleb kohe ära teha ja millised võivad oodata.";
            }
            else if (m == 4 && d >= 21 || m == 5 && d <= 21)
            {
                lbl.Text = $"{emoji[2]} - {zodiaks[2]}\nIntuitsioon ütleb sulle, et jaanuar pole parim aeg täiesti uute asjade ettevõtmiseks ja elus midagi kardinaalselt muutmiseks. Aasta algus on mõtisklemiseks suurepärane. Märkate palju asju, millele te varem tähelepanu ei pööranud, ja teete õiged järeldused. Võimalikud on edukad kokkusattumused, asjaolude kombinatsioon, mis toob kaasa huvitavaid mõtteid.";
            }
            else if (m == 5 && d >= 22 || m == 5 && d <= 21)
            {
                lbl.Text = $"{emoji[3]} - {zodiaks[3]}\nAasta algab hästi. Tähed on teie poolel ja tänu nende toetusele saite eelmisel aastal üliraskena tundunud asjadega suurepäraselt hakkama. Võimalikud on ebatavalised kohtumised, tutvused, mis avavad palju uusi võimalusi. Võimalik, et just sel ajal tehakse otsuseid, tänu millele läheb teie karjäär lähiajal ülesmäge.";
            }
            else if (m == 5 && d >= 22 || m == 6 && d <= 22)
            {
                lbl.Text = $"{emoji[4]} - {zodiaks[4]}\nAasta algus pole just eriti raske periood, kuid kindlasti nõuab ettevaatlikkust ja ettenägelikkust. Püüdke mitte panna talle liiga suuri lootusi, ärge lootke kergetele võitudele. Võimalik on edu töös, samuti muutused paremuse poole isiklikes suhetes, kuid mõlemad nõuavad sinult pealehakkamist, järjekindlat tegutsemist ja tahtlikku tegutsemist. Usaldusväärsete inimeste abi ei ole üleliigne. Mõelge, kelle poole saate sellega pöörduda.";
            }
            else if (m == 6 && d >= 23 || m == 7 && d <= 23)
            {
                lbl.Text = $"{emoji[5]} - {zodiaks[5]}\nAasta võib alata kiviselt, eriti Lõvide jaoks, kes ootasid pikisilmi oluliste eesmärkide saavutamist vähese või ilma pingutuseta. Paljud asjad osutuvad keerulisemaks, kui varem arvasid ja nendega pead ise hakkama saama, on vähetõenäoline, et keegi sind aitab. Tihti on abiks minevikus omandatud kogemused. Lihtsam on Leodel, kes on valmis oma vigu tunnistama ja neist õppima.";
            }
            else if (m == 8 && d >= 24 || m == 9 && d <= 22)
            {
                lbl.Text = $"{emoji[11]} - {zodiaks[12]}\nAasta esimesed kuud on ebaühtlased ja kiired. Isegi kui sul on mingid konkreetsed plaanid, siis kuni märtsini vaevalt jõuad nende elluviimisele keskenduda. Kas asjaolud ebaõnnestuvad või liitlased ebaõnnestuvad või peate aitama raskesse olukorda sattunud lähedasi.";
            }
            else if (m == 9 && d >= 23 || m == 10 && d <= 23)
            {
                lbl.Text = $"{emoji[7]} - {zodiaks[7]}\nDuring the year, work, financial matters, health, family affairs and relationships with partners and opponents will come to the fore. Previous savings will create opportunities for your earnings. Compensation for past investments will come, but sometimes long-standing successes will turn into losses. The most significant in terms of profits and losses will be the end of April and May, as well as the end of October and November. ";
            }
            else if (m == 10 && d >= 24 || m == 11 && d <= 22)
            {
                lbl.Text = $"{emoji[8]} - {zodiaks[8]}\nThe year will be filled with work and love, creativity and children's affairs, family relationships and sports. Children and people who love you will be your support. Possible addition to the family. The successes of adult children will delight, the talents and successes of younger family members are realized. In summer and in the first half of autumn you will succeed in your work. This period will be marked by the affairs of the service and household chores, personal successes and recognition of colleagues, the help of professionals and the transfer of their own experience.";
            }
            else if (m == 11 && d >= 23 || m == 12 && d <= 21)
            {
                lbl.Text = $"{emoji[9]} - {zodiaks[9]}\nThis year you will deal with issues related to work, the affairs of parents and children, real estate. Possible addition to the family. Love, hobbies, creative and personal successes, as well as interesting trips and successes of children will open an important period that will last for more than one year. New connections and interests will expand your experience and fill your daily schedule.";
            }
            else if (m == 2 && d >= 18 || m == 1 && d <= 21)
            {
                lbl.Text = $"{emoji[11]} - {zodiaks[11]}\n2022 will change your goals and plans. In May and November, career issues will be acute - a change of job and place of residence is possible. Leadership will change, new opportunities will appear, some old cases will be canceled. Extra people will leave the environment, but the best and trusted friends will remain with you. You will be engaged in repairs, affairs and health of parents and households, plan moving.";
            }
            else if (m == 2 && d >= 19 || m == 3 && d <= 20)
            {
                lbl.Text = $"{emoji[1]} - {zodiaks[1]}\nThe year will bring you respect and recognition, success in work, in personal affairs and in spiritual activities. Your abilities will be appreciated if you have previously made efforts to develop them. Music, dancing, singing, art, literature will burst into your life. Feel free to follow your dreams. There will be an opportunity to start new intellectual and creative projects and succeed in them.";
            }
        }

    }
}