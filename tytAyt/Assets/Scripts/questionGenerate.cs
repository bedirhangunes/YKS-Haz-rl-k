using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionGenerate : MonoBehaviour
{
    public static string trueAnswer;
    public static bool displayingQuest = false;
    public int questNumber;
   
    void Update()
    {
        if (displayingQuest == false)
        {
            displayingQuest = true;
            questNumber = Random.Range(1, 120);
            
            if (questNumber == 1)
            {

                questionDisplay.yeniSoru = "Bir yazar ��yle diyor: 'S�zc�klerin dedi�ini anl�yorum, b�t�n �zelliklerini biliyorum, hepsinin tad�na var�yorum; ama onlar� yan yana getirirken yeni �a�r���mlar yaratam�yorum.'Bu c�mledeki alt� �izili s�zle anlat�lmak istenen a�a��dakilerden hangisidir ?";
                questionDisplay.newA = "A.�ok kullan�lan s�zc�kleri ye�lememek";
                questionDisplay.newB = "B.Birbirinden kolayca ay�ramamak";
                questionDisplay.newC = "C.Yerle�ik kullan�mlar�n d���na ��kamamak";
                questionDisplay.newD = "D.Yap�t�n i�eri�ine g�re bi�imlendirememek";
                questionDisplay.newE = "E.Aralar�nda anlam ili�kisi kuramamak";
                trueAnswer = "C";
            }
            if (questNumber == 2)
            {

                questionDisplay.yeniSoru = "Bir d���n�r ��yle der: 'D���ncenin can� k�sa s�zde, onun yo�un anlat�m�ndad�r.' Bu c�mlede anlat�lmak istenen nedir?";
                questionDisplay.newA = "A.Derinli�i olmayan d���nceler daha kolay anla��labilir";
                questionDisplay.newB = "B.G��l� anlat�m, sa�lam bir d���nce yap�s� gerektirir";
                questionDisplay.newC = "C.Bir d���nceyi �zetlerken ana noktalar �zerinde durmak gerekir";
                questionDisplay.newD = "D.S�z� uzatmak, anlat�m� gereksiz s�zlerle doldurmak d���nceyi g�lgeler";
                questionDisplay.newE = "E.K�salt�larak anlat�lan bir d���nceyi, hemen her- kes anlayabilir";
                trueAnswer = "D";
            }
            if (questNumber == 3)
            {

                questionDisplay.yeniSoru = "Her ressam, ayn� do�a par�as�n� tuvaline farkl� bi�imlerde yans�t�r. Bu c�mlenin sonuna, d���ncenin ak���na g�re a�a��dakilerden hangisinin getirilmesi uygun olmaz?";
                questionDisplay.newA = "A.Do�a, her sanat�� i�in de�i�mez bir konu alan�- d�r";
                questionDisplay.newB = "B.��nk� olaylara, durumlara bak�� a��s� sanat��dan sanat��ya de�i�ir";
                questionDisplay.newC = "C.Bu, ayn� zamanda bi�emle ilgili bir durumdur";
                questionDisplay.newD = "D.Bunda sanat��n�n do�ay� alg�lama bi�iminin etkisi var";
                questionDisplay.newE = "E.Bunu yarat�c�l���n bir gere�i olarak sayabiliriz";
                trueAnswer = "A";
            }
            if (questNumber == 4)
            {

                questionDisplay.yeniSoru = "Bu ki�i kendisine s�ylenen:'Eline sa�l�k,resimlerin �ok g�zel olmu�.' t�r�nden basmakal�p s�zlerin kendisine bir �ey kazand�rmayaca��na inan�r. ��nk�...... Bu c�mlenin sonuna a�a��dakilerin hangisi getirilmez? ";
                questionDisplay.newA = "A.Onun i�in �nemli olan, yans�tmak istediklerinin anla��l�p anla��lmad���d�r";
                questionDisplay.newB = "B.O, y�neltilen ele�tiriler �����nda kendisini geli�tirecektir";
                questionDisplay.newC = "C.Onun i�in sanat, insanlar� etkileme, belirli duygularla donatma i�idir";
                questionDisplay.newD = "D.O, yap�t�n bi�im ve i�erik y�n�nden ele�tirilme- sinden yanad�r";
                questionDisplay.newE = "E.O, ele�tirinin i�levsel bir nitelik ta��mas�n� ister";
                trueAnswer = "C";
            }
            if (questNumber == 5)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde yaz�m yanl��� vard�r?";
                questionDisplay.newA = "A.Bu kitap, ilk bas�m�n�n �zerinden yirmi y�l ge�tikten sonra, yeniden yay�mland�";
                questionDisplay.newB = "B.�i�ekcinin yeni a�t��� yer �ok iyi �al���yor";
                questionDisplay.newC = "C.Bir yap�t�n kal�c�l���n� sa�layan bir�ok etken vard�r.";
                questionDisplay.newD = "D.Bu romanda y�zy�l�m�z�n temel sorunlar� yans�t�l�yor";
                questionDisplay.newE = "E.Ba�ar�l� olmak i�in d�zenli ve s�rekli �al��mak gerekir";
                trueAnswer = "B";
            }
            if (questNumber == 6)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde bir yaz�m yanl��� vard�r?";
                questionDisplay.newA = "A.Bebe�i b�t�n g�n karde�i oyal�yacak";
                questionDisplay.newB = "B.Konu�mas�nda bu konuya da de�inecek";
                questionDisplay.newC = "C.Bu konudaki karar�m� size bildirmeyece�im";
                questionDisplay.newD = "D.Onun bu i�i ba�araca��n� s�yleyebilirim";
                questionDisplay.newE = "E.Onu kime verdi�imi an�msayam�yorum";
                trueAnswer = "A";
            }
            if (questNumber == 7)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde virg�l (,) kald�r�ld���nda c�mlenin ��esinde de�i�iklik olur?";
                questionDisplay.newA = "A.Onun gibi, yap�tlar�nda kendini anlatan sanat��lar da var";
                questionDisplay.newB = "B.O, roman�yla bir ilke imza att���n� s�yl�yordu";
                questionDisplay.newC = "C.Karde�imin, atas�zlerini ve deyimleri pek bilmedi�i ortaya ��kt�";
                questionDisplay.newD = "D.Ona, kar�� tak�m�n oyuncular�ndan s�z ettik";
                questionDisplay.newE = "E.Yazd��� makalelerde, al�nt� yapt��� kaynaklar� belirtirdi.";
                trueAnswer = "B";
            }
            if (questNumber == 8)//15.soru
            {

                questionDisplay.yeniSoru = "Yaln�z yap�tlar�n�n i�eri�iyle de�il, anlat�m�ndaki ustal�k, kulland��� dil ve hareketli anlat�m tekni�iyle de edebiyat�m�z�n b�y�k ustalar�ndan biridir o. Bu c�mleyle ilgili olarak a�a��da verilenlerden hangisi yanl��t�r?";
                questionDisplay.newA = "A.'Yap�tlar�n�n' s�zc���, hem yap�m hem �ekim eki alm��t�r";
                questionDisplay.newB = "B.�ns�z yumu�amas�na u�ram�� s�zc�kler var";
                questionDisplay.newC = "C.Ba�la� kullan�ld�";
                questionDisplay.newD = "D.Ad tamlamas�n�n aras�na s�fat girmi�tir";
                questionDisplay.newE = "E.'Yaln�z' s�zc��� s�fat olarak kullan�lm��t�r";
                trueAnswer = "E";
            }
            if (questNumber == 9)
            {

                questionDisplay.yeniSoru = "A�a��dakilerin hangisinde iyelik eki ald��� i�in belgisiz zamir olan, adla�m�� bir s�fat kullan�lm��t�r?";
                questionDisplay.newA = "A.Kimi insanlar karl� havada araba kullanm�yor";
                questionDisplay.newB = "B.Size ba�ka bir g�mlek verelim, dedi";
                questionDisplay.newC = "C.Sinemalardaki hi�bir filmi ka��rmazm��";
                questionDisplay.newD = "D.Baz�s� i�ini �tekilerden erken bitirmi�";
                questionDisplay.newE = "E.Bug�n yine birka� kitap ald�m";
                trueAnswer = "D";
            }
            if (questNumber == 10)
            {

                questionDisplay.yeniSoru = "Hi�bir �iire ba�larken, bunu umuda, umutsuzlu�a, sevince ya da ac�ya y�nlendireyim, diye ba�lam�yorum. Bu c�mledeki anlat�m bozuklu�u a�a��dakilerin hangisinden kaynaklanmaktad�r?";
                questionDisplay.newA = "A.Gereksiz yere ba�-fiil kullan�lmas�ndan";
                questionDisplay.newB = "B.�zne-y�klem uyumsuzlu�undan";
                questionDisplay.newC = "C.Gereksiz yere dola�l� t�mle� kullan�lmas�ndan";
                questionDisplay.newD = "D.Yanl�� ba�la� kullan�lmas�ndan";
                questionDisplay.newE = "E.Nesnenin ad�l(zamir) olarak kullan�lmas�ndan";
                trueAnswer = "A";
            }
            if (questNumber == 11)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde bir anlat�m bozuklu�u var?";
                questionDisplay.newA = "A.Bu kazada can kayb� ya�anmad�";
                questionDisplay.newB = "B.S�ylenenleri pek de onaylamad�";
                questionDisplay.newC = "C.Yap�tlar� hala unutulmad�";
                questionDisplay.newD = "D.Kimseye bir yarar� dokunmad�";
                questionDisplay.newE = "E.�stedi�i ba�ar�ya ula�amad�";
                trueAnswer = "A";
            }
            if (questNumber == 12)
            {

                questionDisplay.yeniSoru = "S�z�n� etti�iniz binay� ne g�rd�m ne de yerini bilirim. Bu c�mledeki anlat�m bozuklu�unun sebebi nedir?";
                questionDisplay.newA = "A.Nesne eksikli�i";
                questionDisplay.newB = "B.T�mle� eksikli�i";
                questionDisplay.newC = "C.Gereksiz yere ba�la� kullan�lmas�";
                questionDisplay.newD = "D.Y�klemin olumlu olmas�";
                questionDisplay.newE = "E.Tamlayan eksikli�i";
                trueAnswer = "E";
            }
            if (questNumber == 13)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde bir anlat�m bozuklu�u vard�r?";
                questionDisplay.newA = "A.Okudu�u romanda olaylar geli�tik�e onun da heyecan� art�yordu";
                questionDisplay.newB = "B.Bir �ey okurken ya da dinlerken t�m dikkatimi onun �zerinde yo�unla�t�rmaya �al���r�m";
                questionDisplay.newC = "C.B�y�k kentlerde insanlar, s�rekli bir ko�u�turma i�indedir";
                questionDisplay.newD = "D.Geli�me �a��ndaki gen�ler, kendinin ve �evrenin y�nlendirmesiyle yanl�� yapabilirler";
                questionDisplay.newE = "E.Hi� beklemedi�im bu davran��� kar��s�nda ona nas�l bir tepki g�sterece�imi bilemedim";
                trueAnswer = "D";
            }
            if (questNumber == 14)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde anlat�m bozuklu�u vard�r?";
                questionDisplay.newA = "A.Do�an�n g�zelli�idir beni burada en �ok etkileyen";
                questionDisplay.newB = "B.Tasar�lar� aras�nda ona yer yoktu asl�nda";
                questionDisplay.newC = "C.Asl�nda ger�e�in ta kendisidir anlatt�klar�";
                questionDisplay.newD = "D.�imdiye de�in hi� kar��la�mam��t�m b�yle bir durumla";
                questionDisplay.newE = "E.Bir ailenin verdi�i insan�st� bir �aban�n �yk�- s�d�r bu";
                trueAnswer = "E";
            }
            if (questNumber == 15)
            {

                questionDisplay.yeniSoru = "Do�uda da�lar kar alt�nda yatarken bahar geldi da�lar�na Ege�nin.Ye�ille kucakla�t� toprak; da� ta� yemye�il. Sanki papatya denizi Dat�a, g�z alabildi�ine uzanan.Bahar kokuyor her yer.K�rlar reng�renk �i�ek.... Bu par�an�n anlat�m�yla ilgili hangisi s�ylenemez?";
                questionDisplay.newA = "A.Do�an�n ki�ile�tirildi�i";
                questionDisplay.newB = "B.Kar��t anlaml� s�zc�klerin bir arada kullan�ld���";
                questionDisplay.newC = "C.Bahara �zg� g�r�nt�lerin betimlendi�i";
                questionDisplay.newD = "D.Devrik c�mlelerle anlat�m�n do�alla�t�r�ld���";
                questionDisplay.newE = "E.Kar��la�t�rmaya ba�vuruldu�u";
                trueAnswer = "B";
            }
            if (questNumber == 16)
            {

                questionDisplay.yeniSoru = "�nl� ele�tirmenlerimizden biri: Deneme yaz�yorsan�z belli bir birikiminiz, s�yleyecek s�z�n�z olmal�. diyor. ---- ��nk� onun hem engin bir bilgi birikimi hem de s�yleyecek pek �ok s�z� var. Bo� b�rak�lan yere hangisi getirilebilir?";
                questionDisplay.newA = "A.Kendisi de �yle bir ele�tirmen olmak istiyor";
                questionDisplay.newB = "B.Kimileri onun bu g�r���ne kat�lm�yor";
                questionDisplay.newC = "C.Bu nitelikleri ta��yan pek �ok sanat��m�z var";
                questionDisplay.newD = "D.Bu niteliklerden yoksunsan�z ele�tirmen say�lmazs�n�z";
                questionDisplay.newE = "E.Bu s�z o yazar�m�za �ok uyuyor";
                trueAnswer = "E";
            }
            if (questNumber == 17)
            {

                questionDisplay.yeniSoru = "Konu�urken yeterince d���n�p en uygun s�z� ve s�yleyi�i bulmaya zaman yoktur.Ama yazd���m�z bir yaz�y� her okuyu�ta,o yaz�daki,dalg�nl�ktan,dikkatsizlikten do�an yanl��lar� g�r�p d�zeltme;d���nme ve ara�t�rma eksikliklerini tamamlama,gereksiz b�l�mleri atma olana�� vard�r--- Bu par�an�n sonuna ak��a g�re hangisi getirilebilir?";
                questionDisplay.newA = "A.Bu nedenle her yazar, yaz�s�n� g�n �����na ��karmadan �nce d�ne d�ne denetlemelidir";
                questionDisplay.newB = "B.K�sacas� her yazar�n en �ok �nem verdi�i nokta,s�zc�k se�imi olmal�d�r";
                questionDisplay.newC = "C.A��k�as� yazar, konu�ma dilini de�il, yaz� dilini kullanmal�d�r";
                questionDisplay.newD = "D.S�z�n k�sas� yazar, t�mcelerini ayr�nt�larla dol- durmaktan ka��nmal�d�r";
                questionDisplay.newE = "E.Bunun i�in yazar,ara�t�rmay� zorunlu k�lan konular� i�lemelidir";
                trueAnswer = "A";
            }
            if (questNumber == 18)
            {

                questionDisplay.yeniSoru = "Bu yazar�m�z,an�lar�n� anlat�rken araya ba�ka yazarlar�n an�lar�n�,d���n�rlerin an�lar �zerine s�ylediklerini de kat�yor.B�ylece yazd�klar�,okurda,anlat�lanlar�n i�inde olu�turulmu� yeni bir metin tad� da b�rak�yor. S�z� edilen yazar�n b�yle bir yol tutma amac� ne olabilir?";
                questionDisplay.newA = "A.Yaz�lanlar�n ya�anm��l���n� kan�tlama";
                questionDisplay.newB = "B.Okurlarda, kendi an�lar�n� yazma iste�i uyand�r- ma";
                questionDisplay.newC = "C.Anlat�lanlara, okurun de�i�ik a��lardan bakmas�- n� sa�lama";
                questionDisplay.newD = "D.Kendi ya�am�yla ba�kalar�n�n ya�am� aras�ndaki benzerlikleri ortaya ��karma";
                questionDisplay.newE = "E.An� t�r�n�n, �teki yaz�nsal t�rlerden �st�n oldu- �unu g�sterme";
                trueAnswer = "C";
            }
            if (questNumber == 19)
            {

                questionDisplay.yeniSoru = "�lgimi,k�lt�rel konulara,ya�ad���m kentin tarihine y�nelttim.Bu da beni bir t�r kedere itti.Ne var ki ben bunun alt�nda ezilmedim.�al��t�m,u�ra�t�m,kitaplar�m� yazd�m.Hayat�mdan memnunum. Hi�bir arkada��m benim i�in h�z�nl� demez.Sinirli,enerjik diyebilir; ama belirgin niteli�im h�z�n de�il.Olsa olsa �unu s�yleyebilirler benim i�in: K���d�,kalemi eline al�nca kaleminin ucuna gelenler bunlard�r. A�a��dakilerden hangisi, bu s�zleri s�yleyen yazara �zg� bir nitelik de�ildir?";
                questionDisplay.newA = "A.�abuk k�zan, hareketli";
                questionDisplay.newB = "B.�r�nler ortaya koymak i�in �abalayan";
                questionDisplay.newC = "C.��inde bulundu�u ko�ullardan �ik�yet�i olmayan";
                questionDisplay.newD = "D.Yazd�klar�yla ya�ad�klar�n� �rt��t�ren";
                questionDisplay.newE = "E.Kendi �zelliklerini tan�yan";
                trueAnswer = "D";
            }
            if (questNumber == 20)
            {

                questionDisplay.yeniSoru = "2022�nin sonuna do�ru g�sterime giren bu film,geleneksel sineman�n kulland��� tekniklere ba�l� kalmadan, bir hayatta kalma sava��m�n� insanda yo�unla�arak anlat�yor. Bu c�mleden filmle ilgili olarak A�a��dakilerden hangisi ��kar�labilir?";
                questionDisplay.newA = "A.Belirli bir izleyici kitlesine seslenmek ama�lanm��t�r";
                questionDisplay.newB = "B.Yeni �ekim y�ntemlerine ba�vurulmu�tur";
                questionDisplay.newC = "C.Bug�ne kadar beyaz perdeye ta��nmam�� bir sorun i�lenmi�tir";
                questionDisplay.newD = "D.Oyuncular�n g�sterdi�i ba�ar�yla, �ok boyutlu bir yap� kazanm��t�r";
                questionDisplay.newE = "E.Y�l�n �ok izlenen filmleri aras�nda yerini alm��t�r";
                trueAnswer = "B";
            }
            if (questNumber == 21)
            {

                questionDisplay.yeniSoru = "Klasik eserleri okumaya en �ok, kendi yazd�klar�m� tekrar etti�imi hissetti�im zamanlarda ihtiya� duyar�m. A�a��dakilerden hangisi bu c�mleye anlamca en yak�nd�r?";
                questionDisplay.newA = "A.Kimi eserlerin her d�nemde okunurlu�unu s�rd�rd��� bilinir";
                questionDisplay.newB = "B.Bir yazar�n, okuduklar�ndan etkilenmeden yazmas� m�mk�n de�ildir";
                questionDisplay.newC = "C.Her eser, ba�ka metinlerden al�nan par�alarla renklenen bir resimdir";
                questionDisplay.newD = "D.Yazar farkl� �r�nler ortaya koymal�";
                questionDisplay.newE = "E.�a��n� a�m�� eserleri okuma, yarat�c�l��� besleyen bir etkinliktir";
                trueAnswer = "E";
            }
            if (questNumber == 22)
            {

                questionDisplay.yeniSoru = "�iir, yaln�zca ac�lar�, yoksunluklar�, mutsuzluklar� dile getirmemelidir. Bu s�zler a�a��dakilerden hangisiyle s�rd�r�lemez?";
                questionDisplay.newA = "A.Ger�ekte de sevin�le h�z�n, �l�mle ya�am yan yana kar��m�za ��kmaz m�";
                questionDisplay.newB = "B.T�rk halk m�zi�inde uzun havalardan sonra oyun havalar�na ge�ilmez mi";
                questionDisplay.newC = "C.�iir okuyucusunu karamsarl��a itmenin bir anlam� var m�";
                questionDisplay.newD = "D.Okuyucunun �iirden alaca�� hazz� s�n�rlamaya gerek var m�";
                questionDisplay.newE = "E.�imdi �nsan ya�am�n�n trajik y�nlerini yans�tan eserlerde ilgi �ekmiyor mu";
                trueAnswer = "E";
            }
            if (questNumber == 23)
            {

                questionDisplay.yeniSoru = "Bir gazeteci, s�yle�i yapt��� ki�inin rahats�z olabilece�i bir soruyu, kendisiyle soru aras�na mesafe koyarak ���nc� ki�ilerin a�z�ndan sormal�d�r. A�a��dakilerden hangisi bu ilkeye dikkat edilerek haz�rlanm�� bir sorudur?";
                questionDisplay.newA = "A.�ok �nemli iki �d�l almas�na ra�men son roman�n�z�n �ok sat�lmamas�n�n nedeni ne olabilir?";
                questionDisplay.newB = "B.Eserlerinizde soyut konular� ele al���n�z�n okuyucuyu yordu�unu d���n�r m�s�n�z?";
                questionDisplay.newC = "C.Baz� ele�tirmenler son roman�n�z�n baz� b�l�mlerinin bir Alman yazar�n roman�ndan al�nd���n� iddia ediyor, bu konuda ne d���n�yorsunuz?";
                questionDisplay.newD = "D.'Ke�ke yay�mlasamayd�m' diye d���nd���n�z yaz�lar�n�z oldu mu?";
                questionDisplay.newE = "E.Eserlerinizde ayn� konuyu i�leyip durmaktan kurtulamaman�z� neye ba�l�yorsunuz?";
                trueAnswer = "C";
            }
            if (questNumber == 24)
            {

                questionDisplay.yeniSoru = "Eskiden �lkelerin zenginli�inin �l��t�, sahip olunan toprak ve do�al kaynaklar�n miktar�yd�; zenginle�menin yolu, daha geni� topraklara h�kmetmekten ge�iyordu.19-20.y�zy�llar�nda bilimsel ara�t�rmalara a��rl�k verilmesiyle bu anlay�� de�i�ti, bilgi �retimi �nem kazand�. Buarada a�a��daki ses olaylar�ndan hangisi yoktur?";
                questionDisplay.newA = "A.�nl� t�remesi";
                questionDisplay.newB = "B.�ns�z d��mesi";
                questionDisplay.newC = "C.Ulama";
                questionDisplay.newD = "D.�ns�z benze�mesi";
                questionDisplay.newE = "E.�ns�z yumu�amas�";
                trueAnswer = "A";
            }
            if (questNumber == 25)
            {

                questionDisplay.yeniSoru = "'R�yalar� ger�ekle�tirmenin yolu, uyan�vermektir uykulardan.' demi� bir d���n�r. �yleyse ne duruyoruz, hemen silkinip kalkal�m yumu�ak yataklar�m�zdan! Bu par�ada a�a��dakilerden hangisi yoktur=";
                questionDisplay.newA = "A.Tezlik fiili";
                questionDisplay.newB = "B.Zarf-Fiil";
                questionDisplay.newC = "C.S�fat-fiil";
                questionDisplay.newD = "D.istek kipiyle �ekimlenmi� Fiil";
                questionDisplay.newE = "E.�imdiki zamanla �ekimlenmi� fiil";
                trueAnswer = "C";
            }
            if (questNumber == 26)
            {

                questionDisplay.yeniSoru = "Eserlerinde kulland��� �zg�n bi�imler ve canl� renklerle, de�i�imin birey �zerindeki etkilerini yans�t�yor. Bu c�mle ile ilgili a�a��dakilerden hangisi yanl��?";
                questionDisplay.newA = "A.�at�s� bak�m�ndan etkendir";
                questionDisplay.newB = "B.Bulunma durumu eki alm�� s�zc�k vard�r.";
                questionDisplay.newC = "C.�yelik eki alan s�zc�k yoktur.";
                questionDisplay.newD = "D.Fiilden isim yapma eki alm�� s�zc�k vard�r";
                questionDisplay.newE = "E.Nesne, isim tamlamas�ndan olu�maktad�r";
                trueAnswer = "C";
            }
            if (questNumber == 27)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde bir anlat�m bozuklu�u vard�r?";
                questionDisplay.newA = "A.Bu s�zlerinle beni sinirlendirmek i�in �al���yorsun";
                questionDisplay.newB = "B.Yapt�klar�nla herkesi �a��rtmaya devam ediyorsun.";
                questionDisplay.newC = "C.Bu davran���m� tehdit olarak alg�lad���n� belirtiyorsun.";
                questionDisplay.newD = "D.Sordu�un sorularla konuyu ba�ka bir yere �ekmeye �al���yorsun";
                questionDisplay.newE = "E.Kurallara uymamakta �srar ediyorsun";
                trueAnswer = "A";
            }
            if (questNumber == 28)
            {

                questionDisplay.yeniSoru = "�zellikle ilgi duydu�um i�in sinema konusu �zerine �ok d���n�r�m. Bana g�re, birisi bir �r�n ortaya koyuyorsa ilk ko�ul �r�n�n teknik a��dan ba�ar�l� olmas�d�r. Ancak ondan sonra �r�n�n sanat a��s�ndan iyi mi, k�t� m� oldu�u tart���labilir. Bu par�adaki d���nceye en uygun se�enek hangisidir?";
                questionDisplay.newA = "A.Her ku�ak edebiyat� bi miktar �a�da�la�t�r�r. ��nk� d�nya de�i�iyor edebiyat da de�i�ir";
                questionDisplay.newB = "B.Yazmaktan ba�ka d���ncem olmad��� gibi kendimi geli�tirmek geri durmad�m.Bu kadar �d�l almam� buna yorar�m";
                questionDisplay.newC = "C.Yazmaya ba�layan birinin yazarlara �yk�nmesi do�al.M�him olan yaz�klar�n�n i�eri�inin yenilikler i�ermesidir";
                questionDisplay.newD = "D.Sanat�� g��l�yse �r�nlerde daha �ok tan�n�r.Ele�tirmenlerin s�zgecinden ge�ip hak etti�i yeri al�rlar";
                questionDisplay.newE = "E.Romanlar� ilk 10 sayfas�na dek okuyor ve dil,anlat�m ve zaman a��s�ndan de�erlendiriyorum.Olmam��sa devam�n� okumuyorum";
                trueAnswer = "E";
            }
            if (questNumber == 29)
            {

                questionDisplay.yeniSoru = "Okumay�; televizyon izlemek, futbol oynamak gibi bo� zamanlar� dolduran e�lendirici bir i� olarak de�erlendirenlere s�yleyecek s�z�m yok. Onlar�nki okuma de�il, oyalanmad�r. Modaya uymak i�in raflar�na �ok satan kitaplar� dizenlerin yapt��� da ayn� �eydir. Oysa her kitap bir okyanustur. Ben okyanusun k�y�s�nda gezinti yapmak yerine k���k teknesiyle dalgalar aras�nda bo�u�an ger�ek okuyucunun pe�indeyim. B�yle diyen bir yazardan ne s�ylemesi beklenemez?";
                questionDisplay.newA = "A.Okurken yorulmay� g�ze alan okuyucu olmak gerekir";
                questionDisplay.newB = "B.Yazar, eseriyle okuyucusunu d���ncenin derinliklerine ta��maya �al���r";
                questionDisplay.newC = "C.Birikimli okur, yazar�n s�ylediklerinden, s�ylemediklerini ��karmaya �al��mal�d�r";
                questionDisplay.newD = "D.Her edebiyat eseri, a��k ve anla��l�r olmal� ki okuyucu, y�n�n� bulabilsin";
                questionDisplay.newE = "E.Edebiyat�n labirentlerinde dola�mayan okuyucu, sanat��n�n d�nyas�n� tan�yamaz";
                trueAnswer = "D";
            }
            if (questNumber == 30)
            {

                questionDisplay.yeniSoru = "Alan�nda uzman, yeti�mi� bir�ok �evirmen var. Ancak bu, �eviri alan�ndaki yetersizli�imizi gidermez. Giderilmesi; okullar�n yeti�tirmesine, edit�rlerin sabredebilmesine, yay�nc�lar�n da, �evirmenin emeklerinin kar��l���n� vermesine ba�l�d�r.G�n�m�zde herkes yorulmadan para kazanma derdinde. Yaln�zca iyi bir �eviri yapm�� olman�n hazz� pe�inde ko�anlar�n say�s� �ok de�il. Bu par�aya g�re �evirmenden a�a��dakilerden hangisi beklenmez";
                questionDisplay.newA = "A.Hak etti�i �creti alabilme";
                questionDisplay.newB = "B.�stenilen nitelikte eserler se�me";
                questionDisplay.newC = "C.�eviriyi zevk alarak yapma";
                questionDisplay.newD = "D.�al��malar�n� titizlikle s�rd�rme";
                questionDisplay.newE = "E.�yi bir e�itimden ge�mi� olma";
                trueAnswer = "B";
            }
            if (questNumber == 31)
            {

                questionDisplay.yeniSoru = "Ele�tiri alan�nda �nemli eksikliklerimizden biri de es- kiyi, i�inde bulunulan d�nemin ko�ullar� i�inde ara�- t�rmamak. Do�ru diye belledi�imiz birtak�m kavram- lar�n, ��kar�mlar�n kabu�unu k�rmamak. Bunlar� yeni terimlerin ba�lam� i�inde incelememek.  Burada 'kabu�unu k�rmamak' ile anlat�lmak istenen nedir?";
                questionDisplay.newA = "A.Eskiden yaz�lm�� yap�tlar�n de�erini ortaya ��kar- mak i�in u�ra�mamak";
                questionDisplay.newB = "B.Tart���lm�� konularla ilgili g�r��lerini a��klamak- tan ka��nmamak";
                questionDisplay.newC = "C.Do�rulu�u benimsenmi� yarg�lar� tekrar ele al�p de�erlendirmemek";
                questionDisplay.newD = "D.Do�rulu�u, yanl��l��� ki�iye g�re de�i�en d���n- celeri ele�tirmemek";
                questionDisplay.newE = "E.Tabu olarak bilinen d���nceleri tart���rken belir- lenmi� s�n�rlar i�inde kalmamak";
                trueAnswer = "C";
            }
            if (questNumber == 32)
            {

                questionDisplay.yeniSoru = "D���nceye sayg� g�stermek gerekir; ancak bu, her d���nceyi do�ru say�p kendi d���ncemizden vaz- ge�me anlam�na gelmemeli. ��nk� ki�isel d���nce- ler, meyvelerin g�ne� alt�nda olgunla�mas� gibi, ----. Bu par�an�n devam�na ne gelmeli?";
                questionDisplay.newA = "A.Zorla benimsetilmeye �al���l�rsa etkisini yitirir";
                questionDisplay.newB = "B.Uzun s�ren zihinsel �abalar sonunda olu�ur";
                questionDisplay.newC = "C.En k���k bir ku�kuya yol a�arsa bireylere olan g�veni azalt�r";
                questionDisplay.newD = "D.Ki�inin, i�inde bulundu�u ortama g�re de�i�iklik g�sterir";
                questionDisplay.newE = "E.Sa�lam temellere dayand��� s�rece zarar g�r- mez, y�pranmaz";
                trueAnswer = "B";
            }
            if (questNumber == 33)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde di�erlerinden farkl� bir d���nce dile getirilmi�tir?";
                questionDisplay.newA = "A.Sanat��, s�zc�kleri se�ip yan yana getirirken onlara kendi damgas�n� vurur";
                questionDisplay.newB = "B.�slup, sanat��n�n ki�ili�ini yans�tan bir aynad�r";
                questionDisplay.newC = "C.Bir sanat��n�n �slubu, o sanat��n�n kendisidir";
                questionDisplay.newD = "D.Bir sanat��, yaratt��� yap�t�n t�r�ne g�re �slup kullan�r";
                questionDisplay.newE = "E.�slup, insan�n konu�tuklar�n� ve yazd�klar�n� bi�imlendiren ki�isel bir ��edir";
                trueAnswer = "D";
            }
            if (questNumber == 34)
            {

                questionDisplay.yeniSoru = "Yahya Kemal: ��iir, d���nceyi duygu haline getirin- ceye kadar yo�urmakt�r.� der. O bu s�z�yle anlatmak istedi�i d���nce hangisidir?";
                questionDisplay.newA = "A.�iirde d���ncenin pay� duygudan daha fazlad�r";
                questionDisplay.newB = "B.Duygular, �iirle etkili bir bi�imde anlat�l�r";
                questionDisplay.newC = "C.�iir, d���ncenin, duygular�n �zsuyunda eritilmesiyle olu�ur";
                questionDisplay.newD = "D.�iir, duygular�n topra��n� besleyip zenginle�tirir";
                questionDisplay.newE = "E.�iirin etki g�c�, i�erdi�i d���nceye ba�l�d�r";
                trueAnswer = "C";
            }
            if (questNumber == 35)
            {

                questionDisplay.yeniSoru = "A�a��dakilerin hangisinde yarg�n�n nedeni belirtilmemi�tir?";
                questionDisplay.newA = "A.�evre bilincinin yeterince geli�memi� olmas�, hava ve su kirlili�ine yol a�maktad�r.";
                questionDisplay.newB = "B.�lkede tar�msal �retimi geli�tirmeye y�nelik �al��malar y�ldan y�la azalmaktad�r";
                questionDisplay.newC = "C.�lkelerde tar�ma dayal� �retim bilin�li bi�imde yapolmamas�,halk sa�l���na tehlike olu�uyor";
                questionDisplay.newD = "D.Tar�ma yeteri �nem verilmemesinden kaynakl� tar�msal �retimde �lke s�ralamas� gerilerdedir";
                questionDisplay.newE = "E.�lke topraklar� yanl�� kullan�m y�z�nden yok olup gitmektedir";
                trueAnswer = "B";
            }
            if (questNumber == 36)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde bir yaz�m yanl��� vard�r?";
                questionDisplay.newA = "A.Yap�lan �l��mler, hava ko�ullar�na ba�l� olarak de�i�genlik g�steriyormu�.";
                questionDisplay.newB = "B.Y�netmelikte yap�lan de�i�ikliklerden �o�umuzun haberi yoktu";
                questionDisplay.newC = "C.Emekli olunca, bu dernekte g�n�ll� olarak �al��maya ba�lad�";
                questionDisplay.newD = "D.�ocu�u, bu okula kaydettirmek i�in �ok u�ra�m��t�";
                questionDisplay.newE = "E.Ge�mi�e bakt���m�zda buna benzer pek �ok durumla kar��la��yoruz";
                trueAnswer = "A";
            }
            if (questNumber == 37)
            {

                questionDisplay.yeniSoru = "Atat�rk��n bir s�z� vard� Yediveren g�l gibi a�ard� Atat�rk��n bir at� vard� Etiler�den beri ya�ard� Atat�rk��n bir resmi vard� Bu�day tarlas� gibi a�ard�. Bu dizelerde a�a��dakilerden hangisi yoktur?";
                questionDisplay.newA = "A.Ba�la�";
                questionDisplay.newB = "B.Ad Tamlamas�";
                questionDisplay.newC = "C.�ekimli fiil";
                questionDisplay.newD = "D.Bile�ik s�zc�k";
                questionDisplay.newE = "E.Ekeylemli y�klem";
                trueAnswer = "A";
            }
            if (questNumber == 38)
            {

                questionDisplay.yeniSoru = "��te kar�� kar��yas�n. O da senin gibi biri (I) Y�z�nde k���k k���k yara izleri (II) Bak, g�l�yor. �imdi de ye- me�ini yiyor (III) ��te t�rk� s�yl�yor, i�te s�k�l�yor (IV) Belki de dertle�ecek birini ar�yor (V) Numaral� yerlerin hangisine di�erlerinden farkl� bi noktalama i�areti gelmeli?";
                questionDisplay.newA = "A.I";
                questionDisplay.newB = "B.II";
                questionDisplay.newC = "C.III";
                questionDisplay.newD = "D.IV";
                questionDisplay.newE = "E.V";
                trueAnswer = "B";
            }
            if (questNumber == 39)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde yer y�n belirteci, tamlayan oldu�u i�in adla�m��t�r?";
                questionDisplay.newA = "A.Kap�n�n �n�ne oturmu�, geleni ge�eni izliyor";
                questionDisplay.newB = "B.�ocu�un �st�ne kocaman bir battaniye �rtm��ler.";
                questionDisplay.newC = "C.Be� y�z metre ileriden sa�a d�neceksiniz";
                questionDisplay.newD = "D.Yukar�ya ��k�p arkada��mla da g�r��eyim";
                questionDisplay.newE = "E.D��ar�n�n g�r�lt�s� hepimizi rahats�z etti";
                trueAnswer = "E";
            }
            if (questNumber == 40)
            {

                questionDisplay.yeniSoru = "Oyunda, 3 arkada��n 1984�den bug�ne kadar gelen birlikteli�i, zaman zaman mizahi, zaman zaman da h�z�nl� bir dil kullan�larak anlat�l�yor.  Bu c�mleyle ilgili a�a��daki yarg�lardan hangisi yanl��t�r?";
                questionDisplay.newA = "A.Belgisiz s�fat kullan�lm��t�r";
                questionDisplay.newB = "B.�lge� vard�r";
                questionDisplay.newC = "C.Y�klem, �at�s� bak�m�ndan etkendir.";
                questionDisplay.newD = "D.Zarf t�mlecinde ikileme yer alm��t�r";
                questionDisplay.newE = "E.S�fat-fiil vard�r";
                trueAnswer = "C";
            }
            if (questNumber == 41)
            {

                questionDisplay.yeniSoru = "Evin bah�esine dikilecek �amlar�n �zerine konmu� bir ser�e, durmadan cik cik edip �ark�s�n� s�yl�yordu. Evin tekir kedisi e�i�e uzanm��, bir yandan �rselenmi� t�ylerini d�zeltmek i�in yalarken bir yandan da az ilerdeki ��pl�kte sallana sallana gezinen kargaya bak�yordu. Bu par�adaki a�a��daki s�zc�klerden hangisi s�zc�k t�r� bak�m�ndan di�erlerinden farkl�d�r?";
                questionDisplay.newA = "A.Dikilecek";
                questionDisplay.newB = "B.Gezinen";
                questionDisplay.newC = "C.Durmadan";
                questionDisplay.newD = "D.Konmu�";
                questionDisplay.newE = "E.�rselenmi�";
                trueAnswer = "C";
            }
            if (questNumber == 42)
            {

                questionDisplay.yeniSoru = "S�zlerinden �ok, ad�n�n �nem kazanmas�, bir ele�tirmenin en b�y�k korkusudur. Bu c�mlenin ��eleri, a�a��dakilerin hangisinde s�ras�yla, do�ru olarak verilmi�tir?";
                questionDisplay.newA = "A.�zne � y�klem";
                questionDisplay.newB = "B.�zne � zarf t�mleci � nesne � y�klem";
                questionDisplay.newC = "C.Nesne - y�klem";
                questionDisplay.newD = "D.Nesne � �zne � zarf t�mleci � y�klem";
                questionDisplay.newE = "E.�zne � zarf t�mleci � y�klem";
                trueAnswer = "A";
            }
            if (questNumber == 43)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde bir anlat�m bozuklu�u vard�r?";
                questionDisplay.newA = "A.Gelece�e umutla bakan ve zorluklar kar��s�nda y�lmayan bir gen�ti";
                questionDisplay.newB = "B.Maddi durumu yetmedi�i i�in e�itimini yar�da b�rakmak zorunda kald�";
                questionDisplay.newC = "C.Ele ald��� her i�i, ba�kalar�ndan daha iyi, daha g�zel yapmak isterdi";
                questionDisplay.newD = "D.K�lt�rel varl�klara sahip ��k�p onlar� korumaya �al��an insanlardan biriyd";
                questionDisplay.newE = "E.Deneyimli bir y�netici, de�erli bir bilim adam�yd�";
                trueAnswer = "B";
            }
            if (questNumber == 44)//2003 t�rk�e 20.soruda kal�nd�
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde bir anlat�m bozuklu�u vard�r?";
                questionDisplay.newA = "A.Ekonomileri daha �ok, yeti�tirdikleri hayvanc�l��a dayal�";
                questionDisplay.newB = "B.Bu topraklar�n b�y�k bir b�l�m� ormanlarla kapl�";
                questionDisplay.newC = "C.�lkenin kuzeyinde elde edilen �r�nlerin yar�dan fazlas�n� elma olu�turuyor";
                questionDisplay.newD = "D.�rettiklerinin �o�unu kom�u �lkelere sat�yorlar";
                questionDisplay.newE = "E.D�nyada en �ok ya��� alan b�lge buras�.";
                trueAnswer = "A";
            }
            if (questNumber == 45)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde bir anlat�m bozuklu�u var?";
                questionDisplay.newA = "A.Sorunlar�n, b�t�n y�nleriyle ele al�nmas� iyi olur";
                questionDisplay.newB = "B.�evremizdeki ki�ilerle kuraca��m�z ili�kilerde �zenli olmal�y�z";
                questionDisplay.newC = "C.Bu alanda ba�ar�ya ula�anlar�n say�s� olduk�a azd�r";
                questionDisplay.newD = "D.Ara�t�rmalar, eldeki bilgilerin do�ru olmad���n� kan�tl�yor";
                questionDisplay.newE = "E.Bu konudaki iftiralar tamamen uydurmad�r";
                trueAnswer = "E";
            }
            if (questNumber == 46)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde bir anlat�m bozuklu�u var?";
                questionDisplay.newA = "A.Kald�r�mlar�n k�r�k ta�lar�, yenileriyle de�i�tiriliyor";
                questionDisplay.newB = "B.Eski yap�lar boyanarak daha g�zel bir g�r�n�me kavu�turuluyor";
                questionDisplay.newC = "C.��inde oturulamayacak derecedeki binalar�n y�k-t�r�lmas� gerekiyor";
                questionDisplay.newD = "D.Yeni fidanlar dikilerek kent ye�illendiriliyor";
                questionDisplay.newE = "E.Yol kenar�ndaki ��p kutular� kald�r�larak bunlar�n yerine �i�ekler dikiliyor";
                trueAnswer = "C";
            }
            if (questNumber == 47)
            {

                questionDisplay.yeniSoru = "Bu kararlar�n uygulan�p uygulanmayaca��n�n, y�neticilerin se�ece�i tutuma ba�l� oldu�u bildirildi.Bu c�mledeki anlat�m bozuklu�u a�a��daki se�eneklerin hangisiyle giderilebilir?";
                questionDisplay.newA = "A.�se�ece�i tutuma� yerine �tutumuna� s�zc��� getirilerek giderilir";
                questionDisplay.newB = "B.�y�neticilerin� yerine �ilgililerin� s�zc��� getirilerek";
                questionDisplay.newC = "C.�bu kararlar�n� yerine �bunlar�n� s�zc��� getirilerek";
                questionDisplay.newD = "D.�ba�l�� yerine �y�nelik� s�zc��� getirilerek";
                questionDisplay.newE = "E.�bildirildi� yerine �biliniyordu� s�zc��� getirilerek";
                trueAnswer = "A";
            }
            if (questNumber == 48)
            {

                questionDisplay.yeniSoru = "�nsan�n kendini de�erlendirebilmesi �ok g��; ancak, �nceki yap�tlar�m� g�zden ge�irirken zaman i�inde dilimin biraz daha geli�ti�ini anlad�m. Giderek bir �s- lup olu�turmaya ba�lad���m�, dile daha fazla h�kim olabildi�imi g�rd�m. Bu s�zler hangi soruya kar��l�kt�r?";
                questionDisplay.newA = "A.Yeni �yk�leri ve �yk�c�leri nas�l de�erlendiriyorsunuz?";
                questionDisplay.newB = "B.Duygu ve d���ncelerinizi yap�tlar�n�za aktar�rken zorluk �ekiyor musunuz?";
                questionDisplay.newC = "C.Ya�ad�klar�n�zla yazd�klar�n�z aras�nda nas�l bir ba� kuruyorsunuz?";
                questionDisplay.newD = "D.�lk yap�tlar�n�zla bug�nk�ler aras�nda ne gibi farklar g�r�yorsunuz?";
                questionDisplay.newE = "E.�yk�lerinizi olu�tururken nas�l bir yol izliyorsunuz?";
                trueAnswer = "D";
            }
            if (questNumber == 49)
            {

                questionDisplay.yeniSoru = "�al��malar�m�z sonu� verdi. Neler mi oldu? Ot bitme- yen bozk�rlar, ipek gibi yumu�ak toprakl� ovalara d�- n��t�. Tarlalar, ar� kovanlar� gibi u�uldamaya ba�la- d�. Topra��n derinliklerinde uyuyan sular yery�z�ne ��kar�ld�. Kova kova s�t veren inekler, kovan kovan bal veren ar�lar yeti�tirildi. Sofralar�, el ele verilerek �retilen yiyecekler s�sledi. Bu par�an�n anlat�m�nda ne yoktur?";
                questionDisplay.newA = "A.Betimeleme Yapma";
                questionDisplay.newB = "B.Yinelemelere yer verme";
                questionDisplay.newC = "C.Tan�k g�sterme";
                questionDisplay.newD = "D.�yk�lemeye ba�vurma";
                questionDisplay.newE = "E.Benzetme sanat�ndan yararlanma";
                trueAnswer = "C";
            }
            if (questNumber == 50)
            {

                questionDisplay.yeniSoru = "Bu yazar�m�z�n, anlatt��� �evre ve ki�iler hakk�nda geni� bilgisi vard�r. Ama o, bunu hi�bir zaman a��k�a g�zler �n�ne sermez. Anlatt�klar�, buzda��n�n suyun �st�nde kalan k�sm� gibidir. Okur, zamanla buzda��- n�n altta kalan k�sm�n� fark eder ve yazar�n as�l kimli- �inin orada sakl� oldu�unu anlar. Bu par�a ile a�a��daki yarg�lardan hangisinde aralar�nda anlamca yak�nl�k vard�r";
                questionDisplay.newA = "A.Her yazar�n, olaylar� ve ki�ileri alg�lama bi�imi farkl�d�r";
                questionDisplay.newB = "B.Kimi yazarlar, yap�tlar�nda kendilerini b�t�n�yle a���a vurmaktan ka��n�r";
                questionDisplay.newC = "C.Okur, be�endi�i yazarlar�n yap�tlar�ndan her okuyu�ta de�i�ik tatlar al�r";
                questionDisplay.newD = "D.Bir yap�t�, her okur farkl� bi�imlerde alg�layabilir";
                questionDisplay.newE = "E.Kimi yazarlar, olaylar�n de�erlendirilmesini okura b�rakarak ilgi �ekmeye �al���r";
                trueAnswer = "B";
            }
            if (questNumber == 51)
            {

                questionDisplay.yeniSoru = "Bir g�n Nuruosmaniye�de bir yazar arkada��mla kar��- la�t�m. Ne o beyim, romanc�l��a m� ba�lad�n? dedi. �aka etmedi�ini sesinden, bak���ndan anlam��t�m. De- mek benim takma adla yazmama bir �ey demiyordu da kendi ad�m� kullanarak yazmam�	say�yordu. Roman,romanc�lar�n alan�yd�. Bir ozan buraya burnunu sokamazd�. Bu par�ada bo� b�rak�lan yere ne gelmeli?";
                questionDisplay.newA = "A.�� ��karmak";
                questionDisplay.newB = "B.Kendi borusunu �almak";
                questionDisplay.newC = "C.�izmeden yukar� ��kmak";
                questionDisplay.newD = "D.Kendi g�be�ini kendi kesmek";
                questionDisplay.newE = "E.Ba��na dert a�mak";
                trueAnswer = "C";
            }
            if (questNumber == 52)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde klasiklerle ilgili farkl� bir d���nce dile getirilmi�tir?";
                questionDisplay.newA = "A.Anla��l�p kavranabilmesi �zel bir �aba, �zel bir okurluk donan�m� gerektirir";
                questionDisplay.newB = "B.�nsan, ya�am�n�n her d�neminde onlarda kendini bulur";
                questionDisplay.newC = "C.S�yledikleri, hi�bir d�nemde t�ketilmez";
                questionDisplay.newD = "D.Onlar� okumaktan al�nan haz hi�bir zaman azalmaz";
                questionDisplay.newE = "E.Okurlar�n d�nyas�nda �zg�n ve de�i�meyen bir yeri vard�r.";
                trueAnswer = "A";
            }
            if (questNumber == 53)
            {

                questionDisplay.yeniSoru = "Barthes�in �S�zc�kler herkesin mal�d�r ama c�mle yaln�zca yazar�n.� s�z� a�a��dakilerden hangisiyle ili�kilendirilemez?";
                questionDisplay.newA = "A.Anlamda�l�k";
                questionDisplay.newB = "B.Bi�em";
                questionDisplay.newC = "C.�znellik";
                questionDisplay.newD = "D.�zg�nl�k";
                questionDisplay.newE = "E.Anlat�m";
                trueAnswer = "A";
            }
            if (questNumber == 54)
            {

                questionDisplay.yeniSoru = "Yazar; kar��tl�klar�n �st �ste y���ld���, ucu a��k, kesin bir yarg�ya g�t�rmeyen, tam bitmeyen metinleriyle, okuru d���ncelerin e�i�inde b�rak�yor. Buna g�re yazar�n okura y�nelik olarak ger�ekle�tirmek istedikleri aras�nda a�a��dakilerden hangisi yoktur?";
                questionDisplay.newA = "A.Okuduklar�n� tamamlat�p onu b�t�nselli�e kavu�- turtma";
                questionDisplay.newB = "B.Yorumlamaya y�nlendirme";
                questionDisplay.newC = "C.D�� g�c�n� geli�tirme";
                questionDisplay.newD = "D.�ok boyutlu d���nd�rme";
                questionDisplay.newE = "E.S�ylenenlerin kan�tlanmas�n� isteme";
                trueAnswer = "E";
            }
            if (questNumber == 55)
            {

                questionDisplay.yeniSoru = "Verdi�i her uzun aran�n ard�ndan yeni alb�m�yle g�nl�- m�z� fethetmeyi ba�aran pop m�zi�i sanat��s�, bu kez eski �ark�lar�n� yeniden yorumlayarak ge�mi�e bug�n�n penceresinden bak�yor ve dinleyiciyi yine olduk�a etkiliyor. Bu paragrafta hangi ses olay� yoktur?";
                questionDisplay.newA = "A.�ns�z T�remesi";
                questionDisplay.newB = "B.�ns�z Benze�mesi";
                questionDisplay.newC = "C.�nl� Daralmas�";
                questionDisplay.newD = "D.�nl� D��mesi";
                questionDisplay.newE = "E.�ns�z Yumu�amas�";
                trueAnswer = "A";
            }
            if (questNumber == 56)
            {

                questionDisplay.yeniSoru = "Hi�bir s�z, hi�bir varsay�m, hi�bir kuram ya�anan somut ger�eklerin yerini tutamaz; bin kez s�ylenen ya�mur s�zc���n�n bir damla ya�murun yerini tutamayaca�� gibi. Burada a�a��da verilenlerden hangisi yoktur?";
                questionDisplay.newA = "A.Ek fiil alm�� s�zc�k";
                questionDisplay.newB = "B.Benzetme edat";
                questionDisplay.newC = "C.Say� s�fat�";
                questionDisplay.newD = "D.Birle�ik s�zc�k";
                questionDisplay.newE = "E.Yeterlik fiili";
                trueAnswer = "A";
            }
            if (questNumber == 57)
            {

                questionDisplay.yeniSoru = "Bilgisayar teknolojisiyle yeti�en ku�aklarda ekrandan kitap okuman�n yarataca�� hazz�, bilgisayarla ileriki ya�larda tan��an insanlar tadamayacakt�r. Bu c�mlede a�a��dakilerden hangisi yoktur?";
                questionDisplay.newA = "A.�yelik eki alm�� s�zc�k";
                questionDisplay.newB = "B.Belirtisiz ad tamlamas�";
                questionDisplay.newC = "C.�sim-fiil eki alm�� s�zc�k";
                questionDisplay.newD = "D.Ge�i�siz �at�l� y�klem";
                questionDisplay.newE = "E.S�fat tamlamas�";
                trueAnswer = "D";
            }
            if (questNumber == 58)
            {

                questionDisplay.yeniSoru = "Do�u Karadeniz�in yaylalar�n� mutlaka g�r�n. K�y�larda hi� oyalanmadan kartpostallardaki kadar g�zel orman- lar�n �zerindeki muhte�em yaylalara ��k�n. Her biri �te- kinden farkl� olan yaylalar�n birinden �tekine y�r�y�n. Ah�ap yayla evlerinde konaklay�p y�resel yemeklerin tad�na bak�n. Bu par�an�n anlat�m�yla a�a��dakilerden hangisi s�ylenemez?";
                questionDisplay.newA = "A.Kar��la�t�rma yap�lm��t�r";
                questionDisplay.newB = "B.�neri nitelikli c�mleler kullan�lm��t�r";
                questionDisplay.newC = "C.Ki�ile�tirmeye ba�vurulmu�tur";
                questionDisplay.newD = "D.Benzetmeden yararlan�lm��t�r";
                questionDisplay.newE = "E.Betimleyici �gelere yer verilmi�tir";
                trueAnswer = "C";
            }
            if (questNumber == 59)
            {

                questionDisplay.yeniSoru = "Sanat��, ya�ama ili�kin bilgi edinme y�k�ml�l��� alt�n- dad�r. Bu demektir ki ya�ad��� zaman diliminde olup bitenlere ka� numaral� camlar gerekiyorsa o camlar�n tak�l� oldu�u g�zl�klerle bakmal�d�r. Bu zorunlulu�un bilincine varamayan bir sanat��, ger�ek d�nyay� do�ru bi�imde g�remeyecektir. A�a��dakilerden hangisi bu par�adabelirtilenleri destekler.";
                questionDisplay.newA = "A.Nat�ralizm �ncesi Avrupa tiyatrosunda yenile�meler yap�lsada d�nya eski �l��tlere g�re alg�land���ndan bunal�ma d���ld�.";
                questionDisplay.newB = "B.Pek �ok yazar okunmak i�in de�il,�nl� olmak ve incelenmek i�in yaz�yor";
                questionDisplay.newC = "C.Bir yazar, anlatacaklar�n� de�i�tirmeden oldu�u gibi dile getirirse yazar de�il, gazeteci ya da politikac� olue";
                questionDisplay.newD = "D.Franz kafkay� anlamak i�in onun ya�ad��� zaman�n �artlar�n� g�z�n�nde bulundurmak gereksiz";
                questionDisplay.newE = "E.Sanat�n tarihi gelene�e ba�l� kal�p yeni bir �ey ortaya koyan sanat��larla doludur";
                trueAnswer = "A";
            }
            if (questNumber == 60)
            {

                questionDisplay.yeniSoru = "Ya�amdan esinlenmeyen, s��, yaratma cesaretinden yoksun ve ders veren anlat�lar, romansal d���ncenin ask�ya al�nd��� ucuz bir bildiricilik olur. Bu anlat�lar; insan�, onun ac�lar�n�, �eli�kilerini derinlik ve incelikle yans�t�p dile getirmeyi ba�aramaz. Bu y�zden her nitelikli ger�ek yaz�nsal yap�t, �zellikle ki�inin varolu�sal h�llerini anlatmal�. B�yle bir anlat�mdan yoksunsa o, ger�ek bir yap�t say�lamaz. Buna g�re a�a��dakilerden hangisine var�lamaz?";
                questionDisplay.newA = "A.��reticilikten uzak olmal�d�r";
                questionDisplay.newB = "B.Okuyan� d���nd�ren, etkileyici bir s�ylemle bi�imlendirilmelidir";
                questionDisplay.newC = "C.Ya�ananlara yeni bi�imler kazand�ran sanatsal bir doku ta��mal�d�r";
                questionDisplay.newD = "D.�nsan ya�am�n� de�i�ik boyutlar�yla ku�atmal�d�r";
                questionDisplay.newE = "E.Anlat�c� kendini gizlemelidir";
                trueAnswer = "E";
            }
            if (questNumber == 61)
            {

                questionDisplay.yeniSoru = "Neden �iir yazar ki insan? Havas�zl�ktan bo�ulmak �zere olan evrende nefes alabilmek, var olabilmek, elinde iyi-k�t� ne varsa d�kebilmek i�in mi eteklerine? �� d�nyas�n�n d��ar�yla olan kavgas�nda anla��labilir olma derdi midir kendini kan�tlamak ya da kanatmak? �airler, g�r�nenin ard�ndaki gizemleri ortaya ��kararak bize rehberlik mi ederler? Buna g�re a�a��dakilerden hangisi �airlerin yazma nedeni de�ildir?";
                questionDisplay.newA = "A.Ya�am�n bunalt�c�l���ndan s�yr�lma";
                questionDisplay.newB = "B.Yaln�zla�maktan kurtulma";
                questionDisplay.newC = "C.Kendini, anlatarak ortaya koyma";
                questionDisplay.newD = "D.Ya�am�n, ayr�m�na var�lmayan y�nlerini duyumsatma";
                questionDisplay.newE = "E.Ruhsal durumuyla ya�am aras�ndaki �at��may� yans�tma";
                trueAnswer = "B";
            }
            if (questNumber == 62)
            {

                questionDisplay.yeniSoru = "Y�ksek maliyetlerle in�a edilen ve �ehir mimarisinde hacimli bir yer kaplayan yap�lar�n, yap�lmas�n�n en ��z�ms�z yan�; yap�ld�ktan sonra �ok b�y�k bir gayret olmazsa e�er, ayn� �irkinlikle onlarca hatta y�zlerce y�l orada kalmas� ve genel manada manzaray� bozmas�d�r. Bu c�mlede bo� b�rak�lan yere ne getirilebilir?";
                questionDisplay.newA = "A.Bat� mimarisine �zenilerek";
                questionDisplay.newB = "B.Reng�renk boyalar�n olu�turdu�u farkl� desenlerle";
                questionDisplay.newC = "C.Geleneksel mimariyle yo�rulmam�� olarak";
                questionDisplay.newD = "D.�ehirden ve �ehrin gelece�inden kopuk bir tasar�mla";
                questionDisplay.newE = "E.�evre d�zenlemesi iyi tasarlanmadan";
                trueAnswer = "D";
            }
            if (questNumber == 63)
            {

                questionDisplay.yeniSoru = "��tenlikle ya�ama sevinci i�inde olan, g�ler y�zl� Anadolu insan� g�nl�k hayat�n�, sevincini, hasretini t�rk� yapar kendisine. Kimsenin bilmesini istemedi�i inanc�, sevdas�; g�nl�nde buram buram t�ten umudu... (Hepsi t�rk�lerin g�r�nmez heybesinde ta��n�r.) Bu par�ada parantez i�indeki s�zle anlat�lmak istenen nedir?";
                questionDisplay.newA = "A.Halk�n s�rlar�n� ve ya�ad�klar�n� saklamas�";
                questionDisplay.newB = "B.G�ncel sosyal olaylara tan�kl�k etmesi";
                questionDisplay.newC = "C.Halk�n duygu ve d���ncelerinden beslenmesi";
                questionDisplay.newD = "D.Dilden dile g�n�lden g�n�le dola�mas�";
                questionDisplay.newE = "E.Gelenek ve g�renekleri g�n�m�ze aktar�p korumas�";
                trueAnswer = "A";
            }
            if (questNumber == 64)
            {

                questionDisplay.yeniSoru = "�air, gelene�in s�r�p giden haz�r d���nme kal�plar�n� par�alad��� zaman ger�ek par�lt�y�, yani iyi �iiri elde edebilir. Bu c�mleyle anlat�lmak istenen a�a��dakilerden hangisidir?";
                questionDisplay.newA = "A.�yi �air olman�n yolu, ba�kalar�n� besleyecek kaynaklar ortaya koymakt�r";
                questionDisplay.newB = "B.�iirde sesini duyurmak isteyen bir gen� sanat��, kendinden �ncekileri a�mal�d�r";
                questionDisplay.newC = "C.�iirde yerle�ik olan anlay��lar� y�kmak, gen� sanat��lar i�in zordur";
                questionDisplay.newD = "D.�iir alan�nda sa�lam bir yer edinebilmenin �n �art�, kendini geli�tirmektir";
                questionDisplay.newE = "E.Bir �air i�in nitelikli �r�nler ortaya koyman�n yolu, al���lm���n d���na ��kmakt�r";
                trueAnswer = "E";
            }
            if (questNumber == 65)
            {

                questionDisplay.yeniSoru = "Osmanl�lar�n yeti�tirdi�i b�y�k sanatk�rlar, icra ettikleri sanat� Hakk�a ula�abilmenin bir arac� olarak g�rm��t�r. �slam ahlak� ile yo�rulmu� ve (nice g�n do�umlar�n� arkas�nda b�rakm��) olan bu derin ve y�ksek sanat alg�s�n�n, g�n�m�zde anlayan� ve talep edeni ne yaz�k ki bir elin parmaklar� kadar az kalm��t�r. Burada parantezdeki s�zle sanat alg�s�na y�nelik ne anlat�lmak isteniyor?";
                questionDisplay.newA = "A.B�y�k bir emek sonucu meydana gelmesi";
                questionDisplay.newB = "B.Geni� bir bo�lu�u doldurmas�";
                questionDisplay.newC = "C.Geni� kitlelerde merak uyand�rmas�";
                questionDisplay.newD = "D.Uzun s�re devam etmi� olmas�";
                questionDisplay.newE = "E.Farkl� anlar� bir b�t�n h�line getirmesi";
                trueAnswer = "D";
            }
            if (questNumber == 66)
            {

                questionDisplay.yeniSoru = "Kavaklar�n alerjik polen �reterek insan sa�l���n� olumsuz etkiledi�i y�n�ndeki yayg�n inan��, son bilimsel �al��malarla yerini farkl� g�r��lere terk etmi�tir. Buradan kesin olarak ��kar�labilecek yarg� a�a��dakilerden hangisidir?";
                questionDisplay.newA = "A.Alerji bilimi ara�t�rmalar�, kesin sonu�lar verebilecek kadar ileri de�ildir";
                questionDisplay.newB = "B.Hangi bitkilerin alerjiye neden oldu�u konusunda bilgi kirlili�i s�z konusudur";
                questionDisplay.newC = "C.Alerji ara�t�rmalar� sonucunda, benimsenmi� baz� bilgiler de�i�mektedir";
                questionDisplay.newD = "D.Bilimsel ger�eklerle halk inan��lar� aras�nda ciddi bir �eli�ki vard�r";
                questionDisplay.newE = "E.Kavaklar�n alerjik polen �retmedi�i, son bilimsel �al��malarla kan�tlanm��t�r";
                trueAnswer = "C";
            }
            if (questNumber == 67)
            {

                questionDisplay.yeniSoru = "Tarihi XVIII. y�zy�la kadar uzanan ve UNESCO taraf�ndan D�nya K�lt�r Miras� Listesi�ne al�nan Safranbolu Evleri, T�rk mimarisinin �nemli �rneklerindendir. Buc�mleden kesin olarak ��kar�labilecek yarg� a�a��dakilerden hangisidir?";
                questionDisplay.newA = "A.Safranbolu, T�rk mimarisinin en �nemli �rneklerine ev sahipli�i yapmaktad�r.";
                questionDisplay.newB = "B.Safranbolu Evleri�nin ge�mi�i birka� y�zy�l �ncesine kadar uzanmaktad�r";
                questionDisplay.newC = "C.UNESCO, geleneksel T�rk mimarisini ara�t�rmak i�in �nemli projeleri desteklemektedir";
                questionDisplay.newD = "D.Safranbolu Evleri, D�nya K�lt�r Miras� Listesi�ne yeni d�hil edilen mimari yap�lar aras�nda yer almaktad�r";
                questionDisplay.newE = "E.Safranbolu Evleri�nin ge�mi�i birka� y�zy�l �ncesine kadar uzanmaktad�r";
                trueAnswer = "B";
            }
            if (questNumber == 68)
            {

                questionDisplay.yeniSoru = "Bana kal�rsa �Edebiyat eserleri ne zamand�r okurlar�n arzusuna g�re bi�imlendirilir oldu (I)� diye sorman�n zaman� geldi (II) Ortada asl�nda ayn� noktada bulu�an iki cevap var (III) Birincisi, pop�ler edebiyat �r�nleri ula�t�klar� okur say�s�n� gerek�e g�sterip nitelikli edebiyat �r�nleri aras�nda (IV) yer almay� beklemeye ba�lad���ndan beri (V) ikincisi, edebiyat ger�ek de�erini kaybedip pazarlama �r�n� oldu�undan beri. Numaraland�r�lm�� yerlerden hangisine noktalama i�areti konmaz?";
                questionDisplay.newA = "A.I";
                questionDisplay.newB = "B.II";
                questionDisplay.newC = "C.III";
                questionDisplay.newD = "D.IV";
                questionDisplay.newE = "E.V";
                trueAnswer = "D";
            }
            if (questNumber == 69)
            {

                questionDisplay.yeniSoru = "Bir sanat��n�n do�al �evresi, elbette i�inde ya�ad��� �lkedir. Onun bu �evreyle i�ten ba�lant�l� olmamas� d���n�lemez ku�kusuz. Ancak konu, tek ba��na estetik bir de�er ta��mad���ndan, nereden al�n�rsa al�ns�n sanat��n�n yarat�c� ki�ili�iyle kayna�arak sanat eserine d�n���r. ----. Bu par�an�n sonuna ak��a g�re ne getirilmelidir?";
                questionDisplay.newA = "A.Dolay�s�yla yabanc� bir konuyla yerli bir eser vermek her zaman m�mk�nd�r";
                questionDisplay.newB = "B.Yani estetik yarat�m� besleyen g��, sanat��n�n ba�l� oldu�u gelenektir";
                questionDisplay.newC = "C.Ba�ka bir deyi�le, eserin belirleyeni yazar�n ya�ad��� �evredir";
                questionDisplay.newD = "D.Kaliteyi elde etmek ancak bu yolla m�mk�nd�r";
                questionDisplay.newE = "E.Bu bak�mdan sanat��n�n ba�ar�l� olmas� i�ledi�i konuya ba�l�d�r";
                trueAnswer = "A";
            }
            if (questNumber == 70)
            {

                questionDisplay.yeniSoru = "Art�k �o�u �eyin aras�nda fark kalmad���ndan m� yoksa farklar� g�rece�imizden emin olmad�klar�ndan m� nedir, �oktand�r dergilerde, benzer iki resim aras�ndaki yedi fark� bulmam�z� istemiyor kimse bizden. Oysa biz, birbirinin ayn� g�r�nen iki resme bakt���m�zda, �Aralar�nda bir fark yok!� deyip ge�mez, farklar� bulup ��kar�r, ne�eyle ��kt���m�z basamaklar�n bizi g�t�rd��� yerde bir c�mlenin alt�n� �izerdik: Benzerlikler yan�lt�r. Bu par�an�n anlat�m�nda a�a��dakilerden hangisi vard�r?";
                questionDisplay.newA = "A.Al�nt�dan yararlanma";
                questionDisplay.newB = "B.Ko�ul �ne s�rme";
                questionDisplay.newC = "C.Soyut kavramlar� somutla�t�rma";
                questionDisplay.newD = "D.A��klamaya ba�vurma";
                questionDisplay.newE = "E.�rneklere yer verme";
                trueAnswer = "D";
            }
            if (questNumber == 71)
            {

                questionDisplay.yeniSoru = "G�nl�k k���k dertlerimizi �nemsemez g�r�n�p kendimizi �b�y�k sorunlar�n� adam� olarak g�stermek �o�umuzun zaaflar�ndand�r. Kendi �k���k sorunlar�n�� halledememi� olmam�z�n h�nc�n�, kendimizi b�y�k sorunlara adam�� gibi g�sterip b�b�rlenerek ��kartmaya �al���r�z sanki. G�ndelik, k���k s�k�nt�lar�m�zdan s�z a�mak bizi k���k d���r�r, �yle mi? Bu par�ada as�l anlat�lmak istenen nedir?";
                questionDisplay.newA = "A.B�y�k sorunlar� ��zme �abalar�m�z�n �n�ndeki en b�y�k engel k���msedi�imiz g�ndelik sorunlard�r";
                questionDisplay.newB = "B.Kendimizi b�y�k sorunlar�n ��z�m�ne adarken k���k sorunlar�m�z� g�rmezlikten gelmemeliyiz";
                questionDisplay.newC = "C.B�y�k sorunlar, ��zmekten ka��nd���m�z k���k sorunlar�n bir kar topu gibi b�y�mesinden olu�ur";
                questionDisplay.newD = "D.Sorun ��zme becerisi olmayan baz� insanlar, kendilerini kabul ettirmek i�in sorunsuzmu� gibi g�r�n�rler";
                questionDisplay.newE = "E.K���k sorunlarla u�ra�arak sorun ��zme becerisini geli�tirmek, insanlar� oldu�undan b�y�k g�sterir";
                trueAnswer = "B";
            }
            if (questNumber == 72)
            {

                questionDisplay.yeniSoru = "�Bu metin dilsel olarak kapand� m� art�k bir eserdir.� s�z�yle as�l anlat�lmak istenen a�a��dakilerden hangisidir?";
                questionDisplay.newA = "A.Edeb� eserler, kendi i�lerinde anlam derinli�ine sahiptir";
                questionDisplay.newB = "B.Bir metin, dil ve �slup bak�m�ndan �st d�zeye eri�medik�e sonland�r�lmamal�d�r";
                questionDisplay.newC = "C.Bir edeb� eser, yazar�n�n kulland��� dille var olabilmektedir";
                questionDisplay.newD = "D.Metinlerin eser olabilmesi i�in mutlaka sonu� b�l�mlerinin olmas� gerekir";
                questionDisplay.newE = "E.Bir metnin yazar� son s�z�n� s�ylemeden, yazd�klar� eser h�line gelmi� olmaz";
                trueAnswer = "E";
            }
            if (questNumber == 73)
            {

                questionDisplay.yeniSoru = "Yazar�n bir toplumsal benli�i, bir de meydana getirdi�i metin vard�r. Onun olu�turdu�u bu metin dilsel olarak kapand� m� art�k bir eserdir, sonu�lanm�� bir nesnedir. Ama ayn� zamanda bu metin bir �retim kayna��d�r. S�z�yle edebi eserlerle ilgili neye de�iniliyor?";
                questionDisplay.newA = "A.Her okunu�ta yeni anlamlar ��kar�ld���na";
                questionDisplay.newB = "B.Kendi d���ndaki yap�tlara da ilham kayna�� oldu�una";
                questionDisplay.newC = "C.Okurlar�n�n duygu d�nyas�na n�fuz etti�ine";
                questionDisplay.newD = "D.Okurlar�n� farkl� d�zeyde etkiledi�ine";
                questionDisplay.newE = "E.Yazar�n� yeni eserler yazmaya sevk etti�ine";
                trueAnswer = "A";
            }
            if (questNumber == 74)
            {

                questionDisplay.yeniSoru = "�evresi ac�lar i�inde k�vran�rken sanat��n�n, mutluluk �ark�lar� s�ylemeye dili varmaz. B�t�n ac�lar� kendi ac�s� bilmeyen ki�iye sanat�� denemez. Romantizmin �En iyi yazar, ku� gibi �ten yazard�r.� g�r���n� Sartre, elinin tersiyle iterek ��yle der: �Yazar ku� de�ildir.� Evet, yazar ku� de�ildir. Yazar ni�in yazd���n� bilmek zorundad�r. Buradan sanat��larla ilgili hangi yarg�ya var�lamaz?";
                questionDisplay.newA = "A.Toplumun b�t�n ac�lar�n� kendi y�re�inde duymal�d�r";
                questionDisplay.newB = "B.Toplumun s�k�nt�lar�n� unutturmak i�in umut dolu �eyler s�yleyebilmelidir";
                questionDisplay.newC = "C.Her zaman ger�ek�i olmal� ve neyi, hangi nedenle s�yledi�ini bilmelidir";
                questionDisplay.newD = "D.Toplumdaki geli�melere ve de�i�melere kay�ts�z kalmamal�d�r.";
                questionDisplay.newE = "E.�ncelikle i�inde ya�ad��� toplumun bir �yesi oldu�unu unutmamal�d�r";
                trueAnswer = "B";
            }
            if (questNumber == 75)
            {

                questionDisplay.yeniSoru = "Son yirmi y�lda ak�ll� teknolojik cihazlar�n----tasar�mlarile ilgi �ekici------ stratejileri, bu cihazlar�n bir �ncekis�r�mlerinin de�erini kaybetmesine ve ��p -----i�in potansiyel at�k h�line gelmesine neden olmaktad�r. Bo� b�rak�lan yerlere,s�ras�yla ne gelmeli?";
                questionDisplay.newA = "A.Resmi-Tan�t�m-Kutular�";
                questionDisplay.newB = "B.Sevimli-Sat��-Merkezleri";
                questionDisplay.newC = "C.G�zel-Piyasa-B�lgeleri";
                questionDisplay.newD = "D.G�steri�li-Pazarlama-Alanlar�";
                questionDisplay.newE = "E.Uygun-Reklam-Tesisleri";
                trueAnswer = "D";
            }
            if (questNumber == 76)
            {

                questionDisplay.yeniSoru = "�Kullanmak� s�zc���, a�a��daki c�mlelerin hangisinde �sarf etmek� anlam�nda kullan�lm��t�r?";
                questionDisplay.newA = "A.Eymen, elindeki �emsiyeyi on y�ld�r kulland���na kimseyi inand�ramad�";
                questionDisplay.newB = "B.Ali, otomobildeki yedek lasti�i �u ana kadar hi� kullanmad�";
                questionDisplay.newC = "C.Hatice, kendisine g�nderilen paray� idareli kullanmas� gerekti�ini biliyordu";
                questionDisplay.newD = "D.Yasin, uzun s�re bilgisayar kullanman�n olumsuz etkilerini ara�t�racak";
                questionDisplay.newE = "E.Sema, sabahlar� evinden i�ine giderken toplu ta��ma ara�lar�n� kullan�yordu";
                trueAnswer = "C";
            }
            if (questNumber == 77)
            {

                questionDisplay.yeniSoru = "Do�aya t�pat�p uygun! -amma da yalan: S��d�r�labilir mi do�a k���c�k bir resme? Do�an�n en ufak par�as� bile sonsuzdur! �yleyse ressam neyi �izer? Do�ada g�r�p sevdi�ini.Peki ya neyi sever? Resmedebildi�ini! Bu m�sralar�n i�eri�i a�a��dakilerden hangisiyle ifade edilmez?";
                questionDisplay.newA = "A.Ressamlar�n g�rsel d�nyay� birebir tuvale aktard�klar� tart��ma g�t�rmez";
                questionDisplay.newB = "B.Ressamlar g�rd�kleri yeri kendi tarz ve ruh h�llerinin s�zgecinden ge�irerek k���da aktar�rlar";
                questionDisplay.newC = "C.Ressam�n kendi yapt��� resmi be�enme nedeni, resim i�in se�ti�i �geleri sevmesidir";
                questionDisplay.newD = "D.Ressamlar asl�nda eserlerinde kendi se�tikleri �geleri resmederler";
                questionDisplay.newE = "E.�ki ayr� ressam�n ayn� yere odaklan�p ayn� resimleri �retmeleri beklenemez";
                trueAnswer = "A";
            }
            if (questNumber == 78)
            {

                questionDisplay.yeniSoru = "T�rk edebiyat�n�n �nemli sanat��lar�ndan Ya�ar Kemal�in, d��lerine s���narak hayata tutunmaya �al��an sokak �ocuklar�n�n unutulmamaya m�h�rlenen hayat hik�yelerini anlatt��� Neredesin Arkada��m, b�y�k ustan�n �ocuklarla yapt��� s�yle�ilerden olu�maktad�r. Bu c�mleden kesin �ekilde ��kar�labilecek yarg� se�eneklerden hangisidir?";
                questionDisplay.newA = "A.Ya�ar Kemal�in sokak �ocuklar� �zerine yapt��� ara�t�rmalar okurlarca be�enildi�i i�in bir araya getirilmi�tir";
                questionDisplay.newB = "B.Neredesin Arkada��m adl� eseriyle Ya�ar Kemal, ilk defa sokak �ocuklar�n�n sorunlar�n� bir �yk� kitab�nda i�lemi�tir";
                questionDisplay.newC = "C.Neredesin Arkada��m adl� eser, Ya�ar Kemal�in sokak �ocuklar�yla yapt��� r�portajlar�n bir se�kisi olarak yay�mlanm��t�r";
                questionDisplay.newD = "D.Sokak �ocuklar�n�n hayat hikayelerini konu edinen Neredesin Arkada��m adl� �yk� kitab� �zerine Ya�ar Kemal�le yap�lan r�portajlar bir kitap h�line getirilmi�tir";
                questionDisplay.newE = "E.Sokak �ocuklar�ndan edindi�i izlenimlerle Ya�ar Kemal, Neredesin Arkada��m adl� �yk�y� sokak �ocuklar�na ithaf etmi�tir";
                trueAnswer = "C";
            }
            if (questNumber == 79)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde t�rnak i�indeki s�z, eylemin nas�l ger�ekle�ti�ini bildirmektedir?";
                questionDisplay.newA = "A.'Biraz sonra', yakla��k iki saat s�recek maceral� bir yolculu�a ��kaca��z";
                questionDisplay.newB = "B.��inin 'ak�ama kadar' bitece�ini umuyordu ama d���nd��� gibi olmad�";
                questionDisplay.newC = "C.G�vercinler yiyecek bulmak i�in 'her zaman' buraya gelirlerdi";
                questionDisplay.newD = "D.Genleriyle oynanm�� tohumlar�n kullan�m� 'h�zla' yayg�nla��yor";
                questionDisplay.newE = "E.Zaman h�zla akarken '�o�u kez', �evremizdeki g�zelliklerin fark�na varam�yoruz";
                trueAnswer = "D";
            }
            if (questNumber == 80)
            {

                questionDisplay.yeniSoru = "�evresi(I) b�y�k bir piknik alan� olarak d�zenlenip halka a��lan Mogan G�l��n�n ku�lar�n kulu�ka ve yavrulamas�na ayr�lan(II) do�al park k�sm�nda(III) k�vr�ml�(IV) ah�ap yayla yollar�(V) ve ku� g�zlemevleri yap�lm��. Bu c�mlede numaraland�r�lm�� s�zc�klerden hangisinde �nl� d��mesi yoktur?";
                questionDisplay.newA = "A.I";
                questionDisplay.newB = "B.II";
                questionDisplay.newC = "C.III";
                questionDisplay.newD = "D.IV";
                questionDisplay.newE = "E.V";
                trueAnswer = "E";
            }
            if (questNumber == 81)
            {

                questionDisplay.yeniSoru = "Yap�land�r�c� dil yakla��m�na g�re dinleme, geli�imsel ve etkile�imsel bir s�re�tir. A�a��daki c�mlelerden hangisi �gelerin dizili�i bak�m�ndan bu c�mleyle ayn�d�r?";
                questionDisplay.newA = "A.Dinleme e�itiminin bir di�er amac� zihinsel becerilerin geli�tirilmesidir";
                questionDisplay.newB = "B.Dinleme, sadece ileti�im kurmak i�in yap�lan bir etkinlik de�ildir";
                questionDisplay.newC = "C.Dinleme becerisinin geli�tirilmesi i�in etkinlik �nemli bir unsurdur.";
                questionDisplay.newD = "D.Dil ��renme s�reci dinleme yoluyla anne karn�nda ba�lar";
                questionDisplay.newE = "E.Etkili bir dinleme i�in dinleyici �n bilgilerini harekete ge�irmelidir";
                trueAnswer = "C";
            }
            if (questNumber == 82)
            {

                questionDisplay.yeniSoru = "Mutlulu�un en �nemli s�rlar�ndan baz�lar� bence �unlard�r ( ) �mr�m�z�n sonuna dek �al��mak ( ) yetene�imiz elverdi�i �l��de yararl� yap�tlar ortaya koymak ( ) g�c�m�z yetti�ince ailemize ve �evremize destek olmak ( ) Ayra�larla belirtilen yerlere a�a��dakilerden hangi noktalama i�aretleri s�ras�yla getirilebilir?";
                questionDisplay.newA = "A.(;) (,) (;) (.)"; 
                questionDisplay.newB = "B.(:) (;) (,) (.)";
                questionDisplay.newC = "C.(:) (,) (,) (...)";
                questionDisplay.newD = "D.(;) (,) (.) (...)";
                questionDisplay.newE = "E.(:) (;) (,) (...)";
                trueAnswer = "C";
            }
            if (questNumber == 83)
            {

                questionDisplay.yeniSoru = "(I)	�Yazd�klar�m boyumu a�t�!� diyenlerden de�ilim.(II)Ben de elimden geldi�ince iyi eserler vermeye �al��t�m.(III)Ama bu eserlerdeki kaliteyi ve yeterli olup olmad���n� ben de�il, toplum s�yleyecek.(IV)Ben de sorumluluk sahibi her insan gibi toplumsal birikime katk�da bulunmaya devam edece�im.(V)Sa�l���m el verirse �ok yak�n bir zamanda yeni bir romanda okurlar�mla bulu�may� d���n�yorum. Bu par�adaki numaralanm�� c�mlelerden hangisinde anlat�m bozuklu�u var?";
                questionDisplay.newA = "A.I";
                questionDisplay.newB = "B.II";
                questionDisplay.newC = "C.III";
                questionDisplay.newD = "D.IV";
                questionDisplay.newE = "E.V";
                trueAnswer = "C";
            }
            if (questNumber == 84)
            {

                questionDisplay.yeniSoru = "Genelde mistik Do�u�nun, �zelde T�rk edebiyat�n�n en b�y�k mutasavv�flar�ndan biridir Mevlana. Halk ve Hak ����� olan Mevlana, ki�isel geli�im ser�venini �Hamd�m, pi�tim, yand�m.� ifadesiyle �zetler. Mevlana bu s�zleriyle ne anlatmak istemi�tir?";
                questionDisplay.newA = "A.Olgunlu�un a�amalar sonucu ger�ekle�ti�ini";
                questionDisplay.newB = "B.Bu d�nyan�n ge�ici oldu�unu";
                questionDisplay.newC = "C.Hi�bir geli�menin sebepsiz olmayaca��n�";
                questionDisplay.newD = "D.Her insan�n kendine �zg� bir ser�veninin oldu�unu";
                questionDisplay.newE = "E.�nsan ruhunun m�kemmelle�mek zorunda oldu�unu";
                trueAnswer = "A";
            }
            if (questNumber == 85)
            {

                questionDisplay.yeniSoru = "�ok defa bir romanc�, roman�na girerken hatta bir �air, �iirine ba�larken kelimeler onu takar pe�ine ve g�t�r�r g�t�rece�i yere. Ne konu kal�r ne plan. Yazarlar ve �airler her zaman konular�na tam h�kim olamaz. Ben bir saniye sonra kullanaca��m c�mlenin bir kelimesini �imdiden size s�yleyebilir miyim? Bu par�ada as�l anlat�lmak istenen nedir?";
                questionDisplay.newA = "A.Yaz�da plan yapmak, yazar�n d�� d�nyas�n� s�n�rland�r�r";
                questionDisplay.newB = "B.Plan, kurgunun sa�laml��� a��s�ndan yazar�n vazge�ilmez rehberidir";
                questionDisplay.newC = "C.Sanat�� temel yap�y� kurduktan sonra yazma i�i kolayla��r";
                questionDisplay.newD = "D.Kelimeler, sanat��n�n varaca�� noktay� belirleyen esas unsurlard�r";
                questionDisplay.newE = "E.�slup kayg�s� edeb� metnin temel dinami�idir";
                trueAnswer = "D";
            }
            if (questNumber == 86)
            {

                questionDisplay.yeniSoru = "T�rkiyenin modernle�mesi ile t�rk roman� ortaya ��kt�.Bat� Avrupa�n�n do�usundaki kimi �lkelere ait romanc�lar gibi T�rk romanc�lar� da �o�u zaman a�a��l�k duygusuna varan bu gecikmi�lik duygusunu, yak�n zamanlarda roman k�resel bir y�nelime girinceye kadar �stlerinden atamad�lar. ----. Bu par�ada bo� b�rak�lan yere,d���ncenin ak���na g�re ne getirilmeli?";
                questionDisplay.newA = "A.Aradan uzun bir zaman ge�mesine ra�men T�rk roman� beklenen at�l�m� hen�z ger�ekle�tirememi�tir";
                questionDisplay.newB = "B.T�rk roman� �a�da�lar�na yeti�ip bat� roman�ndan daha parlak bir vaziyettedir.";
                questionDisplay.newC = "C.T�rk romanc�lar� d�nyaca benimsenen tema ve �slublarla �a�da�lar�na yol g�stermektedir.";
                questionDisplay.newD = "D.B�ylece T�rkiye'de roman�n ilk evresindeki bocalama,bir uygarl���n d�n���m ge�irme�abas�n sorunudur.";
                questionDisplay.newE = "E.�a�da� T�rk roman�n�n sorunlar�n� ve i�inde bulundu�u durumu daha iyi anlayabilmek i�in Tanzimat y�llar�na gitmek gerektir";
                trueAnswer = "B";
            }
            if (questNumber == 87)
            {

                questionDisplay.yeniSoru = "Durmadan art�yor edebiyata ili�kin tutars�zl�klar. ----. Bir yandan da belgesiz savlar, yanl�� anlamalar, aldat�c� �n yarg�lar kapl�yor ortal���";
                questionDisplay.newA = "A.Masum umutlarla yola ��km�� yeni kalemler ya�at�yor dergileri";
                questionDisplay.newB = "B.Kitap sat��lar� ve dergi abonelikleri g�n ge�tik�e d���yor";
                questionDisplay.newC = "C.�iir, hik�ye ve roman okuyanlar�n say�s� b�y�k bir h�zla art�yor";
                questionDisplay.newD = "D.Yazarlar�n magazin programlar�na nesne olaca�� g�nler geliyor";
                questionDisplay.newE = "E.Yazar�n kimlik aray���n� do�al olarak bu aray���n bunal�m� izliyor";
                trueAnswer = "D";
            }
            if (questNumber == 88)
            {

                questionDisplay.yeniSoru = "D�nyada arasan�z da benden daha k�reselini bulamazs�n�z. Hangi memlekete gitsem yaln�z orada oturdu�umu san�yorlar. K�reselim ve b�t�n insanlar�n dostluk, karde�lik, bar�� i�inde sevgi ve sayg�yla ya�amas�n�, yard�mla�mas�n� istiyorum Bu par�ada yazar neyi vurgulamaktad�r?";
                questionDisplay.newA = "A.Farkl�l�klara sayg� duyulmas� gerekti�ini";
                questionDisplay.newB = "B.Her memlekette bir evi oldu�unu";
                questionDisplay.newC = "C.B�t�n d�nyay� kendi evi gibi hissetti�ini";
                questionDisplay.newD = "D.Farkl� �lkeleri gezmeyi �ok sevdi�ini";
                questionDisplay.newE = "E.Her insan�n bir b�t�n�n par�as� oldu�unu";
                trueAnswer = "E";
            }
            if (questNumber == 89)
            {

                questionDisplay.yeniSoru = "Re�at Nuri G�ntekin: �Niye kitap okumuyor demek, niye piyano �alm�yor demek gibi bir �eydir. Kafay� kitap okumaya al��t�rmak, parmaklar� piyanoya al��t�rmaktan daha kolay de�ildir.� *Kitap okuma ile ilgili olarak anlat�lmak istenen nedir?*";
                questionDisplay.newA = "A.�nsan�n sonradan geli�tirdi�i bir eylem olmas�";
                questionDisplay.newB = "B.Okuma becerisinin zaman ve �aba gerektirmesi";
                questionDisplay.newC = "C.K���k ya�ta kazan�labilecek bir davran�� olmas�";
                questionDisplay.newD = "D.Uzun zamanda edinilecek bir al��kanl�k olmas�";
                questionDisplay.newE = "E.Zihinsel y�n�yle �ne ��kan bir edinim olmas�";
                trueAnswer = "B";
            }
            if (questNumber == 90)
            {

                questionDisplay.yeniSoru = "Ger�ekler ne kadar �alkant�l� ne kadar bulan�k ne kadar ��karc� olursa olsun, insano�lu gene de d��ten vazge�miyor.Baudelaire der ki: 'eylemle d��� karde� saymak� burada vurgulanmak istenen a�a��dakilerden hangisidir?";
                questionDisplay.newA = "A.Sanat�n bar�� i�in en g��l� ara� olmas�";
                questionDisplay.newB = "B.Sanat��n�n ger�eklerden uzak durmas�";
                questionDisplay.newC = "C.Edeb� eserin kendi kurallar�na g�re �ekillenmesi";
                questionDisplay.newD = "D.��kar ama�l� sanat faaliyetlerinden ar�n�lmas�";
                questionDisplay.newE = "E.Sanat eserlerinin hayale dayanmas�";
                trueAnswer = "E";
            }
            if (questNumber == 91)
            {

                questionDisplay.yeniSoru = "Bu d�nem yazarlar� roman, tiyatro ve an� gibi t�rlerin ilk �rneklerini verirken nas�l �bakir� bir alanda ilerliyor idiyseler ele�tiri alan�nda da �nlerinde �rnek olabilecek �al��malardan yoksun olarak i�e ba�lad�lar. Frans�z edebiyat�n�n �o�u zaman geli�ig�zel olarak se�tikleri �r�nlerini model ald�lar. Onlar i�in sanat,toplumsal d���ncelerini yaymaya yarayan bir ara�t�. *Buna g�re Tanzimat D�nemi yazarlar�n�n �zelli�i a�a��dakilerden hangisi de�ildir?*";
                questionDisplay.newA = "A.�ok y�nl� bir ele�tiri k�lt�r�ne sahip olmalar�";
                questionDisplay.newB = "B.Mesaja odakl� bir sanat anlay��� geli�tirmeleri";
                questionDisplay.newC = "C.Genellikle Frans�z edebiyat�ndan esinlenmeleri";
                questionDisplay.newD = "D.Edebiyat anlay��lar�nda ge�mi�in izlerinin de olmas�";
                questionDisplay.newE = "E.Pek �ok edeb� t�r�n ilk �rneklerini vermeleri";
                trueAnswer = "A";
            }
            if (questNumber == 92)
            {

                questionDisplay.yeniSoru = "Bir grup ara�t�rmac�n�n yapt��� �al��maya g�re uzun s�re oturanlar�n saatte bir be� dakika y�r�mesi, bacak atardamarlar�n�n zarar g�rmesini �nl�yor.Otururken kalbe kan pompalayan gev�ek kaslar yeterince kas�lm�yor.Kan, bacaklarda birikebiliyor ve bu artan kan ak���ndan dolay� damarlar�n geni�lemesini �nl�yor. *Bu par�ada a�a��dakilerden hangisine de�inilmemi�tir?*";
                questionDisplay.newA = "A.Duru� pozisyonunun insan sa�l���na olan etkisine";
                questionDisplay.newB = "B.Kalp ve damar hastakl�klar�n� tetikleyen baz� nedenlere";
                questionDisplay.newC = "C.Bacaklarda meydana gelen kan birikiminin sebeplerine";
                questionDisplay.newD = "D.Y�r�y���n damar sa�l��� a��s�ndan �nemine";
                questionDisplay.newE = "E.Bacaklarda meydana gelen kas erimesinin nedenlerine";
                trueAnswer = "E";
            }
            if (questNumber == 93)
            {

                questionDisplay.yeniSoru = "Erkek diliyle yazan kad�nlara rastlad���m da oluyor, eserlerini okudu�umda kad�n olduklar�n� sand���m erkekler de tan�yorum. Erkeklerin erkeklikleriyle, kad�nlar�n kad�nl�klar�yla nas�l hesapla�t���n� izlemek, cinsel kodlar�n nas�l da kolayca s�z�p yaz�da kendine yer a�t���n� g�rmek hem can s�k�c� hem ��retici. Bunun fark�nda olabilmek ve �tesine ge�erek yazabilmek benim i�in �ok �nemli. ";
                questionDisplay.newA = "A.Yazar�n cinsel kimli�iyle dilsel se�imleri aras�ndaki ili�kiyi ��z�mlemek, okur i�in ilgin� olabilir";
                questionDisplay.newB = "B.Eserlerinde kar�� cinsin hassasiyetlerini dikkate alan bir yazar, ustal��a ula�m�� say�lmal�d�r";
                questionDisplay.newC = "C.Yazar�n eserini yarat�rken kendi cinsel kimli�inin d���na ��kabilmeyi ba�armas�, pek kolay de�ildir";
                questionDisplay.newD = "D.Bir metinde, cinsiyete ait kodlar bilin�li ya da bilin�siz bir �ekilde kendine yer bulabilmektedir";
                questionDisplay.newE = "E.Yazarlar dil ve s�ylemleriyle kendi cinsel kimliklerini eserlerine yans�tt�klar�n� fark etmeyebilirler";
                trueAnswer = "D";
            }
            if (questNumber == 94)
            {

                questionDisplay.yeniSoru = "Yolunu belirlemi�, �izgisini �izmi� bir yazar olmak kolay i� de�ildir. Bir yazar, (g�z� ikide bir okuyucuya kaymadan) ortaya bir eser koyabilmi�se ona sayg� duymak gerekir. ��nk� yazar kendisini ancak bu yolla istedi�i gibi ifade edebilir, �zg�n �r�nler ortaya koyabilir. Burada ayra�taki s�zle anlat�lmak istenen nedir?";
                questionDisplay.newA = "A.Be�enilme kayg�s� ta��mamak";
                questionDisplay.newB = "B.Ba�kalar�n�n g�r��lerini almamak";
                questionDisplay.newC = "C.Okuyucuya de�er vermemek";
                questionDisplay.newD = "D.Ba�kalar�na benzemekten ka��nmak";
                questionDisplay.newE = "E.Kendi d���ncelerini benimsetmeye �al��mak";
                trueAnswer = "A";
            }
            if (questNumber == 95)
            {

                questionDisplay.yeniSoru = "1779�da Nicholas Cugnot ad�nda bir Frans�z askeri taraf�ndan karada yol alan ilk mekanik ta��t yap�l�ncaya kadar kara ta��mac�l���; kat�r, at gibi hayvanlar taraf�ndan �ekilen arabalarla sa�lan�yordu. *Buradan kesinlikle ��kar�labilecek yarg� hangisidir?*";
                questionDisplay.newA = "A.Profesyonel ta��mac�l�k faaliyetleri, XVIII. y�zy�lda Fransa�da ba�lam��t�r";
                questionDisplay.newB = "B.Mekanik ta��tlar, XVIII. y�zy�lda yaln�zca Fransa�da kullan�lm��t�r";
                questionDisplay.newC = "C.Hayvan g�c�yle �ekilen kara ara�lar� �ok uzun s�re kullan�lm��t�r";
                questionDisplay.newD = "D.Mekanik ta��tlar, hayvan ta��mac�l���n� sona erdirmi�tir.";
                questionDisplay.newE = "E.Karada yol alan ilk mekanik ta��t asker� ama�larla �retilmi�tir";
                trueAnswer = "C";
            }
            if (questNumber == 96)
            {

                questionDisplay.yeniSoru = "Ele�tiride g�venirlik, (edebiyat kuyusunun karanl�klar�na) ���k tutabilmek amac�yla, bilimsel bilgilerden yararlan�larak sa�lan�r. Edebiyata ili�kin olgular� y�zeysel olarak kavray�p bilimsel bilgilerle denetlemeye kalkmak da bilimsel bir ele�tiri niteli�i ta��maz. *Ayra�taki s�zle anlat�lmak istenen nedir?";
                questionDisplay.newA = "A.Ge�erlili�ini yitirmi� sanatsal �geleri belirlemek";
                questionDisplay.newB = "B.Edebiyat eserlerinde, s�ylenenin ard�ndaki s�ylenmeyeni ortaya ��karmak";
                questionDisplay.newC = "C.Sanatsal de�eri �nemsemeyen sanat��lar� ele�tirmek";
                questionDisplay.newD = "D.Metinde anlam� bilinmeyen s�zc�kleri a��klamak";
                questionDisplay.newE = "E.Edebiyat eserlerini g�n�n ko�ullar�na g�re yorumlamak";
                trueAnswer = "B";
            }
            if (questNumber == 97)
            {

                questionDisplay.yeniSoru = "Avrupa Birli�i taraf�ndan desteklenen ve Balkanlar�n en kapsaml� festivallerinden biri olan Saraybosna �ocuk Festivali; palya�olar, sihirbazlar ve renkli kost�mlerle bol e�lence sunarken e�itici film g�sterileri ve sanat at�lyeleriyle de �ocuklar�n ufkunu geni�letiyor. *Bu c�mleden kesin olarak ��kar�labilecek yarg� a�a��dakilerden hangisidir?";
                questionDisplay.newA = "A.Festivalin �ncelikli amac� �ocuklardaki sanat e�ilimini ortaya ��karmakt�r";
                questionDisplay.newB = "B.Saraybosna �ocuk Festivali, her y�l ba�ka bir Balkan �lkesinde d�zenlenmektedir";
                questionDisplay.newC = "C.Saraybosna �ocuk Festivali sadece Avrupa Birli�i taraf�ndan desteklenmektedir";
                questionDisplay.newD = "D.Festivalde �ocuklar�n geli�imini destekleyecek etkinlikler de d�zenlenmi�tir";
                questionDisplay.newE = "E.Bu y�lki Saraybosna �ocuk Festivali UNICEF�in destekleriyle ger�ekle�tirilmi�tir";
                trueAnswer = "D";
            }
            if (questNumber == 98)
            {

                questionDisplay.yeniSoru = "Ke�anl� Ali Destan� adl� dizinin senaristi, eserin yazar� olan Haldun Taner�in kurdu�u hik�yeyi bozmadan senaryoyu yeni bir ba�lam i�inde de�erlendirmi�. *Bu c�mleden kesin olarak ��kar�labilecek yarg� a�a��dakilerden hangisidir?";
                questionDisplay.newA = "A.Eser, as�l hik�yeden yola ��k�larak yeni bir kurguyla diziye uyarlanm��t�r";
                questionDisplay.newB = "B.Haldun Taner�in eseri, g�n�m�ze ba�ar�l� bir �ekilde uyarlanm��t�r";
                questionDisplay.newC = "C.Haldun Taner�in eseri, yeni ve farkl� teknikler kullan�larak uyarlanm��t�r";
                questionDisplay.newD = "D.Senarist, eseri diziye uyarlarken yazar�n da g�r��lerini alm��t�r.";
                questionDisplay.newE = "E.Senarist, roman�n yazar�ndan daha ba�ar�l� bulunmu�tur";
                trueAnswer = "A";
            }
            if (questNumber == 99)
            {

                questionDisplay.yeniSoru = "Ger�ekten �a��rt�c�, etkileyici ve garip bir ustal�k bar�nd�ran bu �yk�ler, edebiyat tarihimiz a��s�ndan incelenmeye de�er oldu�u kadar, bug�n yaz�lm�� gibi taze ve a��nmam�� konular�yla, ak�c� �slubuyla da bize okuma zevki ya�atacak bir nitelik ta��yor. *Buna g�re �yk�ler a�a��dakilerden hangisiyle nitelendirilemez?*";
                questionDisplay.newA = "A.Al���lm��tan farkl� olan";
                questionDisplay.newB = "B.Yenilikler i�eren";
                questionDisplay.newC = "C.Okuyanda iz b�rakan";
                questionDisplay.newD = "D.Sanat de�eri ta��yan";
                questionDisplay.newE = "E.Belli bir mesaj i�eren";
                trueAnswer = "E";
            }
            if (questNumber == 100)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde �bu� s�zc���, s�zc�k t�r� bak�m�ndan �tekilerden farkl�d�r?";
                questionDisplay.newA = "A.Bu sonu�lara ula�mak hepimiz i�in olduk�a zor oldu";
                questionDisplay.newB = "B.Herkesin ya�ama hakk� vard�r ve bu kutsald�r";
                questionDisplay.newC = "C.Ne kadar a��klamaya �al��sa da bunun bir yarar� olmayacakt�";
                questionDisplay.newD = "D.Bu onun tek ba��na �stesinden gelebilece�i bir sorun de�ildi";
                questionDisplay.newE = "E.G�rsel veriler yard�m�yla bunlar�n ��retilmesi daha etkili";
                trueAnswer = "A";
            }
            if (questNumber == 101)
            {

                questionDisplay.yeniSoru = "Aln�ma d��t�k�e damlalar s�k�a Kalbimi karanl�k �eylerle yordum, Etraf� ac� bir g�lge sard�k�a Siz g�l�yordunuz, ben a�l�yordum. *Bu dizelerde a�a��daki ses olaylar�ndan hangisi yoktur?*";
                questionDisplay.newA = "A.�ns�z yumu�amas�";
                questionDisplay.newB = "B.�ns�z benze�mesi";
                questionDisplay.newC = "C.�ns�z d��mesi";
                questionDisplay.newD = "D.�nl� daralmas�";
                questionDisplay.newE = "E.�nl� d��mesi";
                trueAnswer = "C";
            }
            if (questNumber == 102)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde �-yor� eki, di�erlerinden farkl� bir zaman anlam� katm��t�r?";
                questionDisplay.newA = "A.Batakl�k yak�nlar�nda ya�ayan s�l�n boyutundaki hoatzin ku�u, yiyeceklerini fermente ederek sindiriyor";
                questionDisplay.newB = "B.Genetik ve �evresel fakt�rler etkile�erek otizmin ortaya ��kmas�nda rol oynuyor";
                questionDisplay.newC = "C.Astronomlar, evrenimizi giderek artan bir h�zla geni�leten gizemli h�zland�r�c�y� �karanl�k enerji� olarak adland�r�yor";
                questionDisplay.newD = "D.�nl� erken d�nem kartografya tarihi uzman�, bir derginin konu�u olarak �stanbul�a geliyor";
                questionDisplay.newE = "E.Hep ne bulaca��m� hi� bilmeden suya dal�yor ve hepte g�rd�klerim kar��s�nda b�y�lenmi� olarak sudan ��k�yorum";
                trueAnswer = "D";
            }
            if (questNumber == 103)
            {

                questionDisplay.yeniSoru = "Duvara bir titiz �r�mcek gibi, �nce dertlerimle i�ledim bir a�. Ruhum, g�n do�unca s�necek gibi, �imdiden hayata ediyor veda. *Bu dizelerde a�a��dakilerden hangisi yoktur?";
                questionDisplay.newA = "A.Zaman zarf�";
                questionDisplay.newB = "B.Edat";
                questionDisplay.newC = "C.�sim-fiil";
                questionDisplay.newD = "D.Birle�ik eylem";
                questionDisplay.newE = "E.Belgisiz s�fat";
                trueAnswer = "C";
            }
            if (questNumber == 104)
            {

                questionDisplay.yeniSoru = "�spanyol edebiyat�n�n alt�n kalemi Cervantes, Don Ki�ot adl� �l�ms�z eserinde, onuru i�in sava�an ve �len, paras� �l��s�nde de�il, ahlaki erdemleri �l��s�nde sayg� g�ren insan tipini ortaya koyarken ayn� zamanda karma��k bir �a�� da �zetliyordu. *Bu c�mlede a�a��dakilerden hangisi yoktur?*";
                questionDisplay.newA = "A.Say� s�fat�";
                questionDisplay.newB = "B.�nl� uyumuna uymayan ek";
                questionDisplay.newC = "C.�sim tamlamas�";
                questionDisplay.newD = "D.III.tekil iyelik ekiyle �ekimlenmi� s�zc�k";
                questionDisplay.newE = "E.Birden fazla yap�m eki alm�� s�zc�k";
                trueAnswer = "A";
            }
            if (questNumber == 105)
            {

                questionDisplay.yeniSoru = "�nl� psikolog ��yle diyor: �Eylem, duyguyu izler gibi g�r�n�r ama asl�nda duygu ve eylem birlikte gider. Bu y�zden, iradenin denetiminde olan eylemi d�zenleyerek duygular� da d�zenleyebilirsiniz.� *Psikolog bu s�zleriyle a�a��dakilerden hangisini vurgulam��t�r?*";
                questionDisplay.newA = "A.Duygularla uyu�masada yanl�� davran��lardan vazge�melidir";
                questionDisplay.newB = "B.�nsan, duygular�n� kolayl�kla denetim alt�na alabilir";
                questionDisplay.newC = "C.Davran��lar� kontrol edebilmek, duygular� da kontrol edebilmeyi sa�lar";
                questionDisplay.newD = "D.Genellikle duygular, b�t�n davran��lar� bi�imlendirir";
                questionDisplay.newE = "E.Her davran��, asl�nda fark�nda olunmayan baz� duygulardan kaynaklan�r";
                trueAnswer = "C";
            }
            if (questNumber == 106)
            {

                questionDisplay.yeniSoru = "Hem roman hem de �yk� yazan Truman Capote da �yk�ye farkl� bir rol bi�enlerdendir. Capote �zellikle k�sa �yk�n�n yazar i�in bir t�r parmak jimnasti�i olarak de�erlendirilmesine itiraz eder. *Capote'nun k�sa �yk� ile ilgili itiraz� a�a��dakilerden hangisidir?";
                questionDisplay.newA = "A.Roman ile e� de�er tutulmas�";
                questionDisplay.newB = "B.Kolayca yaz�ld���n�n d���n�lmesi";
                questionDisplay.newC = "C.Hacimsiz olarak kabul edilmesi";
                questionDisplay.newD = "D.Okur kitlesinin farkl� g�sterilmesi";
                questionDisplay.newE = "E.Anlat�m�n yavan olarak g�r�lmesi";
                trueAnswer = "B";
            }
            if (questNumber == 107)
            {

                questionDisplay.yeniSoru = "Bir sanat��m�z  ��yle diyor: �Dergiler,  edebiyat�n  yeralt� haritas�d�r.� Nitekim bu dergilerde ilk �r�nleri yay�mlanan gen� �airlerin �o�u, bir s�re sonra �al��malar�n� kitapla�t�rarak �airliklerinin ilk kilometre ta�lar�n� koyarlar. *'Edebiyat�n yeralt� haritas�' s�z�yle,dergilerin hangi �zelli�i belirtilmek istenmi�?";
                questionDisplay.newA = "A.�iiri �teki t�rlerin �n�ne ge�irme";
                questionDisplay.newB = "B.Sanat��lar�n birbirlerinden yararlanmas�na ortam haz�rlama";
                questionDisplay.newC = "C.Sanat��lar�, farkl� alg�lama kal�plar� i�inde d���n- d�rme";
                questionDisplay.newD = "D.Gizli yeteneklerin g�n �����na ��kmas�na olanak sa�lama";
                questionDisplay.newE = "E.Yazarlar�, yeni yaz�nsal t�rlere y�nlendirme";
                trueAnswer = "D";
            }
            if (questNumber == 108)
            {

                questionDisplay.yeniSoru = "2.	Kim bilir ka� kere karar verip  de  ba�layamad���m  bir  i�i bu y�l da ertelemek zorunda kald�m. T�rk�e  S�z- l�k�� al�p ba�tan sona okuma d���ncem  yine  hayal oldu. Oysa 's�zc�klerin kuytulara yatm��, �teki y�zleriyle kar��la�mak' tad�na  doyulmaz bir e�lence  olacakt� benim i�in. *T�rnak i�indeki s�zle,s�zc�klere y�nelik olarak anlat�lmak istenen nedir?*";
                questionDisplay.newA = "A.Yap�sal �zelliklerini tan�mak";
                questionDisplay.newB = "B.�lk anda akla gelmeyen anlamlar�n� ��renmek";
                questionDisplay.newC = "C.G�ndelik dilde kullan�lanlar� ara�t�rmak";
                questionDisplay.newD = "D.Yenilerini eskilerinden ay�rabilmek";
                questionDisplay.newE = "E.Yeni bir s�zl�k olu�turmak";
                trueAnswer = "B";
            }
            if (questNumber == 109)
            {

                questionDisplay.yeniSoru = "A�a��dakilerin hangisinde verilen c�mle, ayra� i�indeki s�z�n anlam�n� i�ermemektedir?";
                questionDisplay.newA = "A.�yk�lerinizde  ayr�nt�lardan  ka��nman�z�,  yal�nl��a ba�l� kalman�z� �ok be�endim; bu, sizin yo�unlu�a verdi�iniz �nemi g�sterir. (����r a��c�  olmak)";
                questionDisplay.newB = "B.�yk�n�z�, ya�am�n ak���n� d���nd�ren bir do�all�kla yaz�n, bunu yapabilecek g��l�  bir kaleminiz var. (yazarl�k yetene�i olmak)";
                questionDisplay.newC = "C.�yk�n�zdeki bilinmeyenlerden kurtulmak i�in �yk�deki kad�n�n kim oldu�unu, nas�l bir ya�am s�rd���n�, ne i� yapt���n� g�r�n�r k�l�n.  (belirginlik kazand�rmak)";
                questionDisplay.newD = "D.Sizin yapt���n�z gibi, bir d�nemi k���k bir �yk�ye s��d�rmak herkesin �stesinden gelebilece�i bir i� de�ildir. (zorlu�u yenmek)";
                questionDisplay.newE = "E.�yk�n�z�n kahraman� olan kad�n�, i�imizden  biri gibi g�sterebilmi�siniz. (inand�r�c� olmak)";
                trueAnswer = "A";
            }
            if (questNumber == 110)
            {

                questionDisplay.yeniSoru = "�air  olarak  ba�ar�m�  ----  bor�luyum  ��nk�  ne  kadar �ok s�zc�kten kurtulursam �iire o kadar �ok yakla�t���m� d���n�r�m hep. Bu c�mlede bo� b�rak�lan yere d���ncenin ak���na g�re a�a��dakilerden hangisi getirilmelidir?";
                questionDisplay.newA = "A.Ayn� metni eklemelerle zenginle�tirmeme";
                questionDisplay.newB = "B.Ald���m notlardan yararlanmama";
                questionDisplay.newC = "C.Hayal g�c�m�n zenginli�ine";
                questionDisplay.newD = "D.��ledi�im duygular�n �e�itlili�ine";
                questionDisplay.newE = "E.Sahip olduklar�ma de�il, vazge�tiklerime";
                trueAnswer = "E";
            }
            if (questNumber == 111)
            {

                questionDisplay.yeniSoru = "Moday� sevmem. Herkesin ayn� anda, ayn� �eyleri giymesi, bana  nedense ters  gelir. Benim puslu, g�zlerden uzak ve reklam� �ok yap�lmam�� olan ho�uma gider her zaman. ��nk�  y�nlendirilmeyi  de�il, �zg�rce ke�fetmeyi severim. Bilin�alt�ma bask� yap�lmas�n� istemem. *Bu s�zler a�a��daki sorulardan hangisine kar��l�k olarak s�ylenmi� olabilir?*";
                questionDisplay.newA = "A.Pop�list edebiyat �r�nleri aras�nda roman�n yeri nedir?";
                questionDisplay.newB = "B.Anlatt�klar�n�z� ni�in kendi �ocuklu�unuzla s�n�rland�r�yorsunuz?";
                questionDisplay.newC = "C.Yay�mland���nda uzun s�re g�ndemden d��meyen bu roman� neden bu kadar ge� okudunuz?";
                questionDisplay.newD = "D.Okurlar�n�z,romanlar�n�zdaki fantastik dokuyu nas�l kar��l�yor?";
                questionDisplay.newE = "E.Bir roman�n �st �ste bask� yapmas�, de�erli oldu- �unu g�sterir mi?";
                trueAnswer = "C";
            }
            if (questNumber == 112)
            {

                questionDisplay.yeniSoru = "Usta �airlerin �iir hakk�ndaki yaz�lar�n� okumak, sadece onlar�n �iire ili�kin  g�r��lerini  ��renmemizi,  kendi �iirlerini anlamam�z� de�il, bir devrin �iir anlay���n� sorgulamam�z� ve yap�lan tart��malar� de�erlendirebilmemizi de sa�lar. *Bu c�mlede a�a��dakilerden hangisi yoktur?*";
                questionDisplay.newA = "A.S�fatla�t�ran -ki";
                questionDisplay.newB = "B.S�rerlik fiil";
                questionDisplay.newC = "C.�nl� d��mesi";
                questionDisplay.newD = "D.D�n��l�l�k zamiri";
                questionDisplay.newE = "E.Ba�la� g�revinde kullan�lm�� �de�";
                trueAnswer = "B";
            }
            if (questNumber == 113)
            {

                questionDisplay.yeniSoru = "Do�a, bitki �rt�s�n� ve t�m canl�lar� nas�l bi�imlendiriyorsa benim �iirlerimi de etkilemi�; bir ses, bir renk, bir koku, bir titre�im olarak �iirlerime girmi�tir. *Bu c�mleyle ilgili olarak a�a��da verilenlerden hangisi yanl��t�r?*";
                questionDisplay.newA = "A.�yelik eki alm�� s�zc�kler yoktur";
                questionDisplay.newB = "B.Belgisiz s�fat kullan�lm��t�r.";
                questionDisplay.newC = "C.Ek almam�� s�zc�kler vard�r.";
                questionDisplay.newD = "D.Ba��ml�, s�ral� bir c�mledir.";
                questionDisplay.newE = "E.Y�klem, �at�s� bak�m�ndan etkendir";
                trueAnswer = "A";
            }
            if (questNumber == 114)
            {

                questionDisplay.yeniSoru = "Bir  u�ultu	ba�l�yor s�z da�arc���mda, s�zc�kler �����yor  zihnime;  ac�l�(I),  ezik,  buruk(II), yorgun(III),  �ekingen, k�rg�n(IV), su�lay�c�, k�sk�n�(V) *Numaraland�r�lm�� s�zc�klerin hangisinde �ns�z benze�mesi vard�r?* ";
                questionDisplay.newA = "A.V";
                questionDisplay.newB = "B.IV";
                questionDisplay.newC = "C.I";
                questionDisplay.newD = "D.II";
                questionDisplay.newE = "E.III";
                trueAnswer = "A";
            }
            if (questNumber == 115)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde bir anlat�m bozuklu�u vard�r?";
                questionDisplay.newA = "A.Yar�y�l tatilinde yap�lacak olan Amasra gezisi ertelendi.";
                questionDisplay.newB = "B.M�jdeyi vermek i�in mutfa�a, annesinin yan�na heyecanla ko�tu.";
                questionDisplay.newC = "C.Diplomalar�n� alacak  ��renciler salona s�rayla giri� yapt�lar";
                questionDisplay.newD = "D.Eski ��rencilerin de kat�ld��� b�y�k bir toplant� d�zenlediler";
                questionDisplay.newE = "E.Konu�mas�na ba�lamadan �nce dinleyicilere ��yle bir bakt�";
                trueAnswer = "C";
            }
            if (questNumber == 116)
            {

                questionDisplay.yeniSoru = "Arkeogenetik, insanl��a dair ge�mi�i molek�ler genetik teknikler------ara�t�ran bir bilim dal� olarak tan�mlanabilir.Baz� temel konular �zerindeki �al��malar hen�z s�rmekteyse de h�zla bir------- bilim dal� h�line gelmi�tir. *Burada bo� b�rak�lan yerlere a�a��dakilerden hangileri s�rayla getirilmelidir?*";
                questionDisplay.newA = "A.Geli�tirerek-Sevilen";
                questionDisplay.newB = "B.Kullanarak-Geli�en";
                questionDisplay.newC = "C.Sayesinde-Benimsenen";
                questionDisplay.newD = "D.Yoluyla-De�i�ken";
                questionDisplay.newE = "E.Deneyerek-Bilinen";
                trueAnswer = "B";
            }
            if (questNumber == 117)
            {

                questionDisplay.yeniSoru = "S�rf kendi i�in okuyan, gezen, e�lenen bir ayd�n kendini ya�arken �ld�rm�yor mu? *Bu c�mledeki �gelerin do�ru s�ralan��� a�a��dakilerden hangisinde verilmi�tir?*";
                questionDisplay.newA = "A.�zne - zarf t�mleci - y�klem";
                questionDisplay.newB = "B.Zarf t�mleci - belirtili nesne - y�klem";
                questionDisplay.newC = "C.Belirtisiz nesne - �zne - zarf t�mleci - y�klem";
                questionDisplay.newD = "D.Belirtisiz nesne - zarf t�mleci - y�klem";
                questionDisplay.newE = "E.�zne - belirtili nesne - zarf t�mleci - y�klem";
                trueAnswer = "E";
            }
            if (questNumber == 118)
            {

                questionDisplay.yeniSoru = "12.	Toprakla u�ra�anlar� maddi a��dan desteklemek �lkemizin kalk�nmas�na �nemli �l��de katk� sa�layacakt�r. *Bu c�mlenin �znesi,a�a��daki s�zc�k gruplar�ndan hangisinden olu�mu�tur?*";
                questionDisplay.newA = "A.Zarf-fiil grubu";
                questionDisplay.newB = "B.�sim-fiil grubu";
                questionDisplay.newC = "C.S�fat tamlamas�";
                questionDisplay.newD = "D.S�fat-fiil grubu";
                questionDisplay.newE = "E.�sim tamlamas�";
                trueAnswer = "B";
            }
            if (questNumber == 119)
            {

                questionDisplay.yeniSoru = "A�a��dakilerin hangisinde nesne, sadece isim tamlamas�ndan olu�mu�tur?";
                questionDisplay.newA = "A.Dedem, ailenin en k�����ne en g�zel oday� vermi�ti.";
                questionDisplay.newB = "B.Ge�mi� g�nlerin �zlemi i�imde her g�n biraz daha b�y�yordu";
                questionDisplay.newC = "C.Emekliye ayr�l�nca evinin bah�esi �deta s���na�� olmu�tu.";
                questionDisplay.newD = "D.Bunca y�l�n ard�ndan sokak sat�c�lar�n�n seslerini h�l�";
                questionDisplay.newE = "E.Uzunca bir s�re trenin penceresinden a�a�larla kapl� k�yleri seyretti";
                trueAnswer = "D";
            }
            if (questNumber == 120)
            {

                questionDisplay.yeniSoru = "A�a��daki c�mlelerin hangisinde kesme i�aretinin kullan�m�yla ilgili bir yanl��l�k yap�lm��t�r?";
                questionDisplay.newA = "A.�niversitemizde tek ders s�navlar�n�n 30 Haziran�da yap�laca�� a��kland�.";
                questionDisplay.newB = "B.Ay�e Han�m�dan gelen son mektubu ailecek sevin� i�inde okuduk";
                questionDisplay.newC = "C.TDK'nin bir g�revi de ge�mi�te yaz�lm�� eserleri g�n�m�ze kazand�rmakt�r";
                questionDisplay.newD = "D.Pamukkale travertenleri, Denizli�mizin �nde gelen turistik de�erlerindendir";
                questionDisplay.newE = "E.Bu yasa tasar�s� Bakanlar Kurulu�nda uzun uzun tart���ld�.";
                trueAnswer = "E";
            }
            questionDisplay.updatePirs = false;
        }
    }
}
