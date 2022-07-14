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

                questionDisplay.yeniSoru = "Bir yazar þöyle diyor: 'Sözcüklerin dediðini anlýyorum, bütün özelliklerini biliyorum, hepsinin tadýna varýyorum; ama onlarý yan yana getirirken yeni çaðrýþýmlar yaratamýyorum.'Bu cümledeki altý çizili sözle anlatýlmak istenen aþaðýdakilerden hangisidir ?";
                questionDisplay.newA = "A.Çok kullanýlan sözcükleri yeðlememek";
                questionDisplay.newB = "B.Birbirinden kolayca ayýramamak";
                questionDisplay.newC = "C.Yerleþik kullanýmlarýn dýþýna çýkamamak";
                questionDisplay.newD = "D.Yapýtýn içeriðine göre biçimlendirememek";
                questionDisplay.newE = "E.Aralarýnda anlam iliþkisi kuramamak";
                trueAnswer = "C";
            }
            if (questNumber == 2)
            {

                questionDisplay.yeniSoru = "Bir düþünür þöyle der: 'Düþüncenin caný kýsa sözde, onun yoðun anlatýmýndadýr.' Bu cümlede anlatýlmak istenen nedir?";
                questionDisplay.newA = "A.Derinliði olmayan düþünceler daha kolay anlaþýlabilir";
                questionDisplay.newB = "B.Güçlü anlatým, saðlam bir düþünce yapýsý gerektirir";
                questionDisplay.newC = "C.Bir düþünceyi özetlerken ana noktalar üzerinde durmak gerekir";
                questionDisplay.newD = "D.Sözü uzatmak, anlatýmý gereksiz sözlerle doldurmak düþünceyi gölgeler";
                questionDisplay.newE = "E.Kýsaltýlarak anlatýlan bir düþünceyi, hemen her- kes anlayabilir";
                trueAnswer = "D";
            }
            if (questNumber == 3)
            {

                questionDisplay.yeniSoru = "Her ressam, ayný doða parçasýný tuvaline farklý biçimlerde yansýtýr. Bu cümlenin sonuna, düþüncenin akýþýna göre aþaðýdakilerden hangisinin getirilmesi uygun olmaz?";
                questionDisplay.newA = "A.Doða, her sanatçý için deðiþmez bir konu alaný- dýr";
                questionDisplay.newB = "B.Çünkü olaylara, durumlara bakýþ açýsý sanatçýdan sanatçýya deðiþir";
                questionDisplay.newC = "C.Bu, ayný zamanda biçemle ilgili bir durumdur";
                questionDisplay.newD = "D.Bunda sanatçýnýn doðayý algýlama biçiminin etkisi var";
                questionDisplay.newE = "E.Bunu yaratýcýlýðýn bir gereði olarak sayabiliriz";
                trueAnswer = "A";
            }
            if (questNumber == 4)
            {

                questionDisplay.yeniSoru = "Bu kiþi kendisine söylenen:'Eline saðlýk,resimlerin çok güzel olmuþ.' türünden basmakalýp sözlerin kendisine bir þey kazandýrmayacaðýna inanýr. Çünkü...... Bu cümlenin sonuna aþaðýdakilerin hangisi getirilmez? ";
                questionDisplay.newA = "A.Onun için önemli olan, yansýtmak istediklerinin anlaþýlýp anlaþýlmadýðýdýr";
                questionDisplay.newB = "B.O, yöneltilen eleþtiriler ýþýðýnda kendisini geliþtirecektir";
                questionDisplay.newC = "C.Onun için sanat, insanlarý etkileme, belirli duygularla donatma iþidir";
                questionDisplay.newD = "D.O, yapýtýn biçim ve içerik yönünden eleþtirilme- sinden yanadýr";
                questionDisplay.newE = "E.O, eleþtirinin iþlevsel bir nitelik taþýmasýný ister";
                trueAnswer = "C";
            }
            if (questNumber == 5)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde yazým yanlýþý vardýr?";
                questionDisplay.newA = "A.Bu kitap, ilk basýmýnýn üzerinden yirmi yýl geçtikten sonra, yeniden yayýmlandý";
                questionDisplay.newB = "B.Çiçekcinin yeni açtýðý yer çok iyi çalýþýyor";
                questionDisplay.newC = "C.Bir yapýtýn kalýcýlýðýný saðlayan birçok etken vardýr.";
                questionDisplay.newD = "D.Bu romanda yüzyýlýmýzýn temel sorunlarý yansýtýlýyor";
                questionDisplay.newE = "E.Baþarýlý olmak için düzenli ve sürekli çalýþmak gerekir";
                trueAnswer = "B";
            }
            if (questNumber == 6)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde bir yazým yanlýþý vardýr?";
                questionDisplay.newA = "A.Bebeði bütün gün kardeþi oyalýyacak";
                questionDisplay.newB = "B.Konuþmasýnda bu konuya da deðinecek";
                questionDisplay.newC = "C.Bu konudaki kararýmý size bildirmeyeceðim";
                questionDisplay.newD = "D.Onun bu iþi baþaracaðýný söyleyebilirim";
                questionDisplay.newE = "E.Onu kime verdiðimi anýmsayamýyorum";
                trueAnswer = "A";
            }
            if (questNumber == 7)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde virgül (,) kaldýrýldýðýnda cümlenin öðesinde deðiþiklik olur?";
                questionDisplay.newA = "A.Onun gibi, yapýtlarýnda kendini anlatan sanatçýlar da var";
                questionDisplay.newB = "B.O, romanýyla bir ilke imza attýðýný söylüyordu";
                questionDisplay.newC = "C.Kardeþimin, atasözlerini ve deyimleri pek bilmediði ortaya çýktý";
                questionDisplay.newD = "D.Ona, karþý takýmýn oyuncularýndan söz ettik";
                questionDisplay.newE = "E.Yazdýðý makalelerde, alýntý yaptýðý kaynaklarý belirtirdi.";
                trueAnswer = "B";
            }
            if (questNumber == 8)//15.soru
            {

                questionDisplay.yeniSoru = "Yalnýz yapýtlarýnýn içeriðiyle deðil, anlatýmýndaki ustalýk, kullandýðý dil ve hareketli anlatým tekniðiyle de edebiyatýmýzýn büyük ustalarýndan biridir o. Bu cümleyle ilgili olarak aþaðýda verilenlerden hangisi yanlýþtýr?";
                questionDisplay.newA = "A.'Yapýtlarýnýn' sözcüðü, hem yapým hem çekim eki almýþtýr";
                questionDisplay.newB = "B.Ünsüz yumuþamasýna uðramýþ sözcükler var";
                questionDisplay.newC = "C.Baðlaç kullanýldý";
                questionDisplay.newD = "D.Ad tamlamasýnýn arasýna sýfat girmiþtir";
                questionDisplay.newE = "E.'Yalnýz' sözcüðü sýfat olarak kullanýlmýþtýr";
                trueAnswer = "E";
            }
            if (questNumber == 9)
            {

                questionDisplay.yeniSoru = "Aþaðýdakilerin hangisinde iyelik eki aldýðý için belgisiz zamir olan, adlaþmýþ bir sýfat kullanýlmýþtýr?";
                questionDisplay.newA = "A.Kimi insanlar karlý havada araba kullanmýyor";
                questionDisplay.newB = "B.Size baþka bir gömlek verelim, dedi";
                questionDisplay.newC = "C.Sinemalardaki hiçbir filmi kaçýrmazmýþ";
                questionDisplay.newD = "D.Bazýsý iþini ötekilerden erken bitirmiþ";
                questionDisplay.newE = "E.Bugün yine birkaç kitap aldým";
                trueAnswer = "D";
            }
            if (questNumber == 10)
            {

                questionDisplay.yeniSoru = "Hiçbir þiire baþlarken, bunu umuda, umutsuzluða, sevince ya da acýya yönlendireyim, diye baþlamýyorum. Bu cümledeki anlatým bozukluðu aþaðýdakilerin hangisinden kaynaklanmaktadýr?";
                questionDisplay.newA = "A.Gereksiz yere bað-fiil kullanýlmasýndan";
                questionDisplay.newB = "B.Özne-yüklem uyumsuzluðundan";
                questionDisplay.newC = "C.Gereksiz yere dolaçlý tümleç kullanýlmasýndan";
                questionDisplay.newD = "D.Yanlýþ baðlaç kullanýlmasýndan";
                questionDisplay.newE = "E.Nesnenin adýl(zamir) olarak kullanýlmasýndan";
                trueAnswer = "A";
            }
            if (questNumber == 11)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde bir anlatým bozukluðu var?";
                questionDisplay.newA = "A.Bu kazada can kaybý yaþanmadý";
                questionDisplay.newB = "B.Söylenenleri pek de onaylamadý";
                questionDisplay.newC = "C.Yapýtlarý hala unutulmadý";
                questionDisplay.newD = "D.Kimseye bir yararý dokunmadý";
                questionDisplay.newE = "E.Ýstediði baþarýya ulaþamadý";
                trueAnswer = "A";
            }
            if (questNumber == 12)
            {

                questionDisplay.yeniSoru = "Sözünü ettiðiniz binayý ne gördüm ne de yerini bilirim. Bu cümledeki anlatým bozukluðunun sebebi nedir?";
                questionDisplay.newA = "A.Nesne eksikliði";
                questionDisplay.newB = "B.Tümleç eksikliði";
                questionDisplay.newC = "C.Gereksiz yere baðlaç kullanýlmasý";
                questionDisplay.newD = "D.Yüklemin olumlu olmasý";
                questionDisplay.newE = "E.Tamlayan eksikliði";
                trueAnswer = "E";
            }
            if (questNumber == 13)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde bir anlatým bozukluðu vardýr?";
                questionDisplay.newA = "A.Okuduðu romanda olaylar geliþtikçe onun da heyecaný artýyordu";
                questionDisplay.newB = "B.Bir þey okurken ya da dinlerken tüm dikkatimi onun üzerinde yoðunlaþtýrmaya çalýþýrým";
                questionDisplay.newC = "C.Büyük kentlerde insanlar, sürekli bir koþuþturma içindedir";
                questionDisplay.newD = "D.Geliþme çaðýndaki gençler, kendinin ve çevrenin yönlendirmesiyle yanlýþ yapabilirler";
                questionDisplay.newE = "E.Hiç beklemediðim bu davranýþý karþýsýnda ona nasýl bir tepki göstereceðimi bilemedim";
                trueAnswer = "D";
            }
            if (questNumber == 14)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde anlatým bozukluðu vardýr?";
                questionDisplay.newA = "A.Doðanýn güzelliðidir beni burada en çok etkileyen";
                questionDisplay.newB = "B.Tasarýlarý arasýnda ona yer yoktu aslýnda";
                questionDisplay.newC = "C.Aslýnda gerçeðin ta kendisidir anlattýklarý";
                questionDisplay.newD = "D.Þimdiye deðin hiç karþýlaþmamýþtým böyle bir durumla";
                questionDisplay.newE = "E.Bir ailenin verdiði insanüstü bir çabanýn öykü- südür bu";
                trueAnswer = "E";
            }
            if (questNumber == 15)
            {

                questionDisplay.yeniSoru = "Doðuda daðlar kar altýnda yatarken bahar geldi daðlarýna Ege’nin.Yeþille kucaklaþtý toprak; dað taþ yemyeþil. Sanki papatya denizi Datça, göz alabildiðine uzanan.Bahar kokuyor her yer.Kýrlar rengârenk çiçek.... Bu parçanýn anlatýmýyla ilgili hangisi söylenemez?";
                questionDisplay.newA = "A.Doðanýn kiþileþtirildiði";
                questionDisplay.newB = "B.Karþýt anlamlý sözcüklerin bir arada kullanýldýðý";
                questionDisplay.newC = "C.Bahara özgü görüntülerin betimlendiði";
                questionDisplay.newD = "D.Devrik cümlelerle anlatýmýn doðallaþtýrýldýðý";
                questionDisplay.newE = "E.Karþýlaþtýrmaya baþvurulduðu";
                trueAnswer = "B";
            }
            if (questNumber == 16)
            {

                questionDisplay.yeniSoru = "Ünlü eleþtirmenlerimizden biri: Deneme yazýyorsanýz belli bir birikiminiz, söyleyecek sözünüz olmalý. diyor. ---- Çünkü onun hem engin bir bilgi birikimi hem de söyleyecek pek çok sözü var. Boþ býrakýlan yere hangisi getirilebilir?";
                questionDisplay.newA = "A.Kendisi de öyle bir eleþtirmen olmak istiyor";
                questionDisplay.newB = "B.Kimileri onun bu görüþüne katýlmýyor";
                questionDisplay.newC = "C.Bu nitelikleri taþýyan pek çok sanatçýmýz var";
                questionDisplay.newD = "D.Bu niteliklerden yoksunsanýz eleþtirmen sayýlmazsýnýz";
                questionDisplay.newE = "E.Bu söz o yazarýmýza çok uyuyor";
                trueAnswer = "E";
            }
            if (questNumber == 17)
            {

                questionDisplay.yeniSoru = "Konuþurken yeterince düþünüp en uygun sözü ve söyleyiþi bulmaya zaman yoktur.Ama yazdýðýmýz bir yazýyý her okuyuþta,o yazýdaki,dalgýnlýktan,dikkatsizlikten doðan yanlýþlarý görüp düzeltme;düþünme ve araþtýrma eksikliklerini tamamlama,gereksiz bölümleri atma olanaðý vardýr--- Bu parçanýn sonuna akýþa göre hangisi getirilebilir?";
                questionDisplay.newA = "A.Bu nedenle her yazar, yazýsýný gün ýþýðýna çýkarmadan önce döne döne denetlemelidir";
                questionDisplay.newB = "B.Kýsacasý her yazarýn en çok önem verdiði nokta,sözcük seçimi olmalýdýr";
                questionDisplay.newC = "C.Açýkçasý yazar, konuþma dilini deðil, yazý dilini kullanmalýdýr";
                questionDisplay.newD = "D.Sözün kýsasý yazar, tümcelerini ayrýntýlarla dol- durmaktan kaçýnmalýdýr";
                questionDisplay.newE = "E.Bunun için yazar,araþtýrmayý zorunlu kýlan konularý iþlemelidir";
                trueAnswer = "A";
            }
            if (questNumber == 18)
            {

                questionDisplay.yeniSoru = "Bu yazarýmýz,anýlarýný anlatýrken araya baþka yazarlarýn anýlarýný,düþünürlerin anýlar üzerine söylediklerini de katýyor.Böylece yazdýklarý,okurda,anlatýlanlarýn içinde oluþturulmuþ yeni bir metin tadý da býrakýyor. Sözü edilen yazarýn böyle bir yol tutma amacý ne olabilir?";
                questionDisplay.newA = "A.Yazýlanlarýn yaþanmýþlýðýný kanýtlama";
                questionDisplay.newB = "B.Okurlarda, kendi anýlarýný yazma isteði uyandýr- ma";
                questionDisplay.newC = "C.Anlatýlanlara, okurun deðiþik açýlardan bakmasý- ný saðlama";
                questionDisplay.newD = "D.Kendi yaþamýyla baþkalarýnýn yaþamý arasýndaki benzerlikleri ortaya çýkarma";
                questionDisplay.newE = "E.Aný türünün, öteki yazýnsal türlerden üstün oldu- ðunu gösterme";
                trueAnswer = "C";
            }
            if (questNumber == 19)
            {

                questionDisplay.yeniSoru = "Ýlgimi,kültürel konulara,yaþadýðým kentin tarihine yönelttim.Bu da beni bir tür kedere itti.Ne var ki ben bunun altýnda ezilmedim.Çalýþtým,uðraþtým,kitaplarýmý yazdým.Hayatýmdan memnunum. Hiçbir arkadaþým benim için hüzünlü demez.Sinirli,enerjik diyebilir; ama belirgin niteliðim hüzün deðil.Olsa olsa þunu söyleyebilirler benim için: Kâðýdý,kalemi eline alýnca kaleminin ucuna gelenler bunlardýr. Aþaðýdakilerden hangisi, bu sözleri söyleyen yazara özgü bir nitelik deðildir?";
                questionDisplay.newA = "A.Çabuk kýzan, hareketli";
                questionDisplay.newB = "B.Ürünler ortaya koymak için çabalayan";
                questionDisplay.newC = "C.Ýçinde bulunduðu koþullardan þikâyetçi olmayan";
                questionDisplay.newD = "D.Yazdýklarýyla yaþadýklarýný örtüþtüren";
                questionDisplay.newE = "E.Kendi özelliklerini tanýyan";
                trueAnswer = "D";
            }
            if (questNumber == 20)
            {

                questionDisplay.yeniSoru = "2022’nin sonuna doðru gösterime giren bu film,geleneksel sinemanýn kullandýðý tekniklere baðlý kalmadan, bir hayatta kalma savaþýmýný insanda yoðunlaþarak anlatýyor. Bu cümleden filmle ilgili olarak Aþaðýdakilerden hangisi çýkarýlabilir?";
                questionDisplay.newA = "A.Belirli bir izleyici kitlesine seslenmek amaçlanmýþtýr";
                questionDisplay.newB = "B.Yeni çekim yöntemlerine baþvurulmuþtur";
                questionDisplay.newC = "C.Bugüne kadar beyaz perdeye taþýnmamýþ bir sorun iþlenmiþtir";
                questionDisplay.newD = "D.Oyuncularýn gösterdiði baþarýyla, çok boyutlu bir yapý kazanmýþtýr";
                questionDisplay.newE = "E.Yýlýn çok izlenen filmleri arasýnda yerini almýþtýr";
                trueAnswer = "B";
            }
            if (questNumber == 21)
            {

                questionDisplay.yeniSoru = "Klasik eserleri okumaya en çok, kendi yazdýklarýmý tekrar ettiðimi hissettiðim zamanlarda ihtiyaç duyarým. Aþaðýdakilerden hangisi bu cümleye anlamca en yakýndýr?";
                questionDisplay.newA = "A.Kimi eserlerin her dönemde okunurluðunu sürdürdüðü bilinir";
                questionDisplay.newB = "B.Bir yazarýn, okuduklarýndan etkilenmeden yazmasý mümkün deðildir";
                questionDisplay.newC = "C.Her eser, baþka metinlerden alýnan parçalarla renklenen bir resimdir";
                questionDisplay.newD = "D.Yazar farklý ürünler ortaya koymalý";
                questionDisplay.newE = "E.Çaðýný aþmýþ eserleri okuma, yaratýcýlýðý besleyen bir etkinliktir";
                trueAnswer = "E";
            }
            if (questNumber == 22)
            {

                questionDisplay.yeniSoru = "Þiir, yalnýzca acýlarý, yoksunluklarý, mutsuzluklarý dile getirmemelidir. Bu sözler aþaðýdakilerden hangisiyle sürdürülemez?";
                questionDisplay.newA = "A.Gerçekte de sevinçle hüzün, ölümle yaþam yan yana karþýmýza çýkmaz mý";
                questionDisplay.newB = "B.Türk halk müziðinde uzun havalardan sonra oyun havalarýna geçilmez mi";
                questionDisplay.newC = "C.Þiir okuyucusunu karamsarlýða itmenin bir anlamý var mý";
                questionDisplay.newD = "D.Okuyucunun þiirden alacaðý hazzý sýnýrlamaya gerek var mý";
                questionDisplay.newE = "E.Þimdi Ýnsan yaþamýnýn trajik yönlerini yansýtan eserlerde ilgi çekmiyor mu";
                trueAnswer = "E";
            }
            if (questNumber == 23)
            {

                questionDisplay.yeniSoru = "Bir gazeteci, söyleþi yaptýðý kiþinin rahatsýz olabileceði bir soruyu, kendisiyle soru arasýna mesafe koyarak üçüncü kiþilerin aðzýndan sormalýdýr. Aþaðýdakilerden hangisi bu ilkeye dikkat edilerek hazýrlanmýþ bir sorudur?";
                questionDisplay.newA = "A.Çok önemli iki ödül almasýna raðmen son romanýnýzýn çok satýlmamasýnýn nedeni ne olabilir?";
                questionDisplay.newB = "B.Eserlerinizde soyut konularý ele alýþýnýzýn okuyucuyu yorduðunu düþünür müsünüz?";
                questionDisplay.newC = "C.Bazý eleþtirmenler son romanýnýzýn bazý bölümlerinin bir Alman yazarýn romanýndan alýndýðýný iddia ediyor, bu konuda ne düþünüyorsunuz?";
                questionDisplay.newD = "D.'Keþke yayýmlasamaydým' diye düþündüðünüz yazýlarýnýz oldu mu?";
                questionDisplay.newE = "E.Eserlerinizde ayný konuyu iþleyip durmaktan kurtulamamanýzý neye baðlýyorsunuz?";
                trueAnswer = "C";
            }
            if (questNumber == 24)
            {

                questionDisplay.yeniSoru = "Eskiden ülkelerin zenginliðinin ölçütü, sahip olunan toprak ve doðal kaynaklarýn miktarýydý; zenginleþmenin yolu, daha geniþ topraklara hükmetmekten geçiyordu.19-20.yüzyýllarýnda bilimsel araþtýrmalara aðýrlýk verilmesiyle bu anlayýþ deðiþti, bilgi üretimi önem kazandý. Buarada aþaðýdaki ses olaylarýndan hangisi yoktur?";
                questionDisplay.newA = "A.Ünlü türemesi";
                questionDisplay.newB = "B.Ünsüz düþmesi";
                questionDisplay.newC = "C.Ulama";
                questionDisplay.newD = "D.Ünsüz benzeþmesi";
                questionDisplay.newE = "E.Ünsüz yumuþamasý";
                trueAnswer = "A";
            }
            if (questNumber == 25)
            {

                questionDisplay.yeniSoru = "'Rüyalarý gerçekleþtirmenin yolu, uyanývermektir uykulardan.' demiþ bir düþünür. Öyleyse ne duruyoruz, hemen silkinip kalkalým yumuþak yataklarýmýzdan! Bu parçada aþaðýdakilerden hangisi yoktur=";
                questionDisplay.newA = "A.Tezlik fiili";
                questionDisplay.newB = "B.Zarf-Fiil";
                questionDisplay.newC = "C.Sýfat-fiil";
                questionDisplay.newD = "D.istek kipiyle çekimlenmiþ Fiil";
                questionDisplay.newE = "E.Þimdiki zamanla çekimlenmiþ fiil";
                trueAnswer = "C";
            }
            if (questNumber == 26)
            {

                questionDisplay.yeniSoru = "Eserlerinde kullandýðý özgün biçimler ve canlý renklerle, deðiþimin birey üzerindeki etkilerini yansýtýyor. Bu cümle ile ilgili aþaðýdakilerden hangisi yanlýþ?";
                questionDisplay.newA = "A.Çatýsý bakýmýndan etkendir";
                questionDisplay.newB = "B.Bulunma durumu eki almýþ sözcük vardýr.";
                questionDisplay.newC = "C.Ýyelik eki alan sözcük yoktur.";
                questionDisplay.newD = "D.Fiilden isim yapma eki almýþ sözcük vardýr";
                questionDisplay.newE = "E.Nesne, isim tamlamasýndan oluþmaktadýr";
                trueAnswer = "C";
            }
            if (questNumber == 27)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde bir anlatým bozukluðu vardýr?";
                questionDisplay.newA = "A.Bu sözlerinle beni sinirlendirmek için çalýþýyorsun";
                questionDisplay.newB = "B.Yaptýklarýnla herkesi þaþýrtmaya devam ediyorsun.";
                questionDisplay.newC = "C.Bu davranýþýmý tehdit olarak algýladýðýný belirtiyorsun.";
                questionDisplay.newD = "D.Sorduðun sorularla konuyu baþka bir yere çekmeye çalýþýyorsun";
                questionDisplay.newE = "E.Kurallara uymamakta ýsrar ediyorsun";
                trueAnswer = "A";
            }
            if (questNumber == 28)
            {

                questionDisplay.yeniSoru = "Özellikle ilgi duyduðum için sinema konusu üzerine çok düþünürüm. Bana göre, birisi bir ürün ortaya koyuyorsa ilk koþul ürünün teknik açýdan baþarýlý olmasýdýr. Ancak ondan sonra ürünün sanat açýsýndan iyi mi, kötü mü olduðu tartýþýlabilir. Bu parçadaki düþünceye en uygun seçenek hangisidir?";
                questionDisplay.newA = "A.Her kuþak edebiyatý bi miktar çaðdaþlaþtýrýr. Çünkü dünya deðiþiyor edebiyat da deðiþir";
                questionDisplay.newB = "B.Yazmaktan baþka düþüncem olmadýðý gibi kendimi geliþtirmek geri durmadým.Bu kadar ödül almamý buna yorarým";
                questionDisplay.newC = "C.Yazmaya baþlayan birinin yazarlara öykünmesi doðal.Mühim olan yazýklarýnýn iöeriðinin yenilikler içermesidir";
                questionDisplay.newD = "D.Sanatçý güçlüyse ürünlerde daha çok tanýnýr.Eleþtirmenlerin süzgecinden geçip hak ettiði yeri alýrlar";
                questionDisplay.newE = "E.Romanlarý ilk 10 sayfasýna dek okuyor ve dil,anlatým ve zaman açýsýndan deðerlendiriyorum.Olmamýþsa devamýný okumuyorum";
                trueAnswer = "E";
            }
            if (questNumber == 29)
            {

                questionDisplay.yeniSoru = "Okumayý; televizyon izlemek, futbol oynamak gibi boþ zamanlarý dolduran eðlendirici bir iþ olarak deðerlendirenlere söyleyecek sözüm yok. Onlarýnki okuma deðil, oyalanmadýr. Modaya uymak için raflarýna çok satan kitaplarý dizenlerin yaptýðý da ayný þeydir. Oysa her kitap bir okyanustur. Ben okyanusun kýyýsýnda gezinti yapmak yerine küçük teknesiyle dalgalar arasýnda boðuþan gerçek okuyucunun peþindeyim. Böyle diyen bir yazardan ne söylemesi beklenemez?";
                questionDisplay.newA = "A.Okurken yorulmayý göze alan okuyucu olmak gerekir";
                questionDisplay.newB = "B.Yazar, eseriyle okuyucusunu düþüncenin derinliklerine taþýmaya çalýþýr";
                questionDisplay.newC = "C.Birikimli okur, yazarýn söylediklerinden, söylemediklerini çýkarmaya çalýþmalýdýr";
                questionDisplay.newD = "D.Her edebiyat eseri, açýk ve anlaþýlýr olmalý ki okuyucu, yönünü bulabilsin";
                questionDisplay.newE = "E.Edebiyatýn labirentlerinde dolaþmayan okuyucu, sanatçýnýn dünyasýný tanýyamaz";
                trueAnswer = "D";
            }
            if (questNumber == 30)
            {

                questionDisplay.yeniSoru = "Alanýnda uzman, yetiþmiþ birçok çevirmen var. Ancak bu, çeviri alanýndaki yetersizliðimizi gidermez. Giderilmesi; okullarýn yetiþtirmesine, editörlerin sabredebilmesine, yayýncýlarýn da, çevirmenin emeklerinin karþýlýðýný vermesine baðlýdýr.Günümüzde herkes yorulmadan para kazanma derdinde. Yalnýzca iyi bir çeviri yapmýþ olmanýn hazzý peþinde koþanlarýn sayýsý çok deðil. Bu parçaya göre çevirmenden aþaðýdakilerden hangisi beklenmez";
                questionDisplay.newA = "A.Hak ettiði ücreti alabilme";
                questionDisplay.newB = "B.Ýstenilen nitelikte eserler seçme";
                questionDisplay.newC = "C.Çeviriyi zevk alarak yapma";
                questionDisplay.newD = "D.Çalýþmalarýný titizlikle sürdürme";
                questionDisplay.newE = "E.Ýyi bir eðitimden geçmiþ olma";
                trueAnswer = "B";
            }
            if (questNumber == 31)
            {

                questionDisplay.yeniSoru = "Eleþtiri alanýnda önemli eksikliklerimizden biri de es- kiyi, içinde bulunulan dönemin koþullarý içinde araþ- týrmamak. Doðru diye bellediðimiz birtakým kavram- larýn, çýkarýmlarýn kabuðunu kýrmamak. Bunlarý yeni terimlerin baðlamý içinde incelememek.  Burada 'kabuðunu kýrmamak' ile anlatýlmak istenen nedir?";
                questionDisplay.newA = "A.Eskiden yazýlmýþ yapýtlarýn deðerini ortaya çýkar- mak için uðraþmamak";
                questionDisplay.newB = "B.Tartýþýlmýþ konularla ilgili görüþlerini açýklamak- tan kaçýnmamak";
                questionDisplay.newC = "C.Doðruluðu benimsenmiþ yargýlarý tekrar ele alýp deðerlendirmemek";
                questionDisplay.newD = "D.Doðruluðu, yanlýþlýðý kiþiye göre deðiþen düþün- celeri eleþtirmemek";
                questionDisplay.newE = "E.Tabu olarak bilinen düþünceleri tartýþýrken belir- lenmiþ sýnýrlar içinde kalmamak";
                trueAnswer = "C";
            }
            if (questNumber == 32)
            {

                questionDisplay.yeniSoru = "Düþünceye saygý göstermek gerekir; ancak bu, her düþünceyi doðru sayýp kendi düþüncemizden vaz- geçme anlamýna gelmemeli. Çünkü kiþisel düþünce- ler, meyvelerin güneþ altýnda olgunlaþmasý gibi, ----. Bu parçanýn devamýna ne gelmeli?";
                questionDisplay.newA = "A.Zorla benimsetilmeye çalýþýlýrsa etkisini yitirir";
                questionDisplay.newB = "B.Uzun süren zihinsel çabalar sonunda oluþur";
                questionDisplay.newC = "C.En küçük bir kuþkuya yol açarsa bireylere olan güveni azaltýr";
                questionDisplay.newD = "D.Kiþinin, içinde bulunduðu ortama göre deðiþiklik gösterir";
                questionDisplay.newE = "E.Saðlam temellere dayandýðý sürece zarar gör- mez, yýpranmaz";
                trueAnswer = "B";
            }
            if (questNumber == 33)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde diðerlerinden farklý bir düþünce dile getirilmiþtir?";
                questionDisplay.newA = "A.Sanatçý, sözcükleri seçip yan yana getirirken onlara kendi damgasýný vurur";
                questionDisplay.newB = "B.Üslup, sanatçýnýn kiþiliðini yansýtan bir aynadýr";
                questionDisplay.newC = "C.Bir sanatçýnýn üslubu, o sanatçýnýn kendisidir";
                questionDisplay.newD = "D.Bir sanatçý, yarattýðý yapýtýn türüne göre üslup kullanýr";
                questionDisplay.newE = "E.Üslup, insanýn konuþtuklarýný ve yazdýklarýný biçimlendiren kiþisel bir öðedir";
                trueAnswer = "D";
            }
            if (questNumber == 34)
            {

                questionDisplay.yeniSoru = "Yahya Kemal: “Þiir, düþünceyi duygu haline getirin- ceye kadar yoðurmaktýr.” der. O bu sözüyle anlatmak istediði düþünce hangisidir?";
                questionDisplay.newA = "A.Þiirde düþüncenin payý duygudan daha fazladýr";
                questionDisplay.newB = "B.Duygular, þiirle etkili bir biçimde anlatýlýr";
                questionDisplay.newC = "C.Þiir, düþüncenin, duygularýn özsuyunda eritilmesiyle oluþur";
                questionDisplay.newD = "D.Þiir, duygularýn topraðýný besleyip zenginleþtirir";
                questionDisplay.newE = "E.Þiirin etki gücü, içerdiði düþünceye baðlýdýr";
                trueAnswer = "C";
            }
            if (questNumber == 35)
            {

                questionDisplay.yeniSoru = "Aþaðýdakilerin hangisinde yargýnýn nedeni belirtilmemiþtir?";
                questionDisplay.newA = "A.Çevre bilincinin yeterince geliþmemiþ olmasý, hava ve su kirliliðine yol açmaktadýr.";
                questionDisplay.newB = "B.Ülkede tarýmsal üretimi geliþtirmeye yönelik çalýþmalar yýldan yýla azalmaktadýr";
                questionDisplay.newC = "C.Ülkelerde tarýma dayalý üretim bilinçli biçimde yapolmamasý,halk saðlýðýna tehlike oluþuyor";
                questionDisplay.newD = "D.Tarýma yeteri önem verilmemesinden kaynaklý tarýmsal üretimde ülke sýralamasý gerilerdedir";
                questionDisplay.newE = "E.Ülke topraklarý yanlýþ kullaným yüzünden yok olup gitmektedir";
                trueAnswer = "B";
            }
            if (questNumber == 36)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde bir yazým yanlýþý vardýr?";
                questionDisplay.newA = "A.Yapýlan ölçümler, hava koþullarýna baðlý olarak deðiþgenlik gösteriyormuþ.";
                questionDisplay.newB = "B.Yönetmelikte yapýlan deðiþikliklerden çoðumuzun haberi yoktu";
                questionDisplay.newC = "C.Emekli olunca, bu dernekte gönüllü olarak çalýþmaya baþladý";
                questionDisplay.newD = "D.Çocuðu, bu okula kaydettirmek için çok uðraþmýþtý";
                questionDisplay.newE = "E.Geçmiþe baktýðýmýzda buna benzer pek çok durumla karþýlaþýyoruz";
                trueAnswer = "A";
            }
            if (questNumber == 37)
            {

                questionDisplay.yeniSoru = "Atatürk’ün bir sözü vardý Yediveren gül gibi açardý Atatürk’ün bir atý vardý Etiler’den beri yaþardý Atatürk’ün bir resmi vardý Buðday tarlasý gibi aðardý. Bu dizelerde aþaðýdakilerden hangisi yoktur?";
                questionDisplay.newA = "A.Baðlaç";
                questionDisplay.newB = "B.Ad Tamlamasý";
                questionDisplay.newC = "C.Çekimli fiil";
                questionDisplay.newD = "D.Bileþik sözcük";
                questionDisplay.newE = "E.Ekeylemli yüklem";
                trueAnswer = "A";
            }
            if (questNumber == 38)
            {

                questionDisplay.yeniSoru = "Ýþte karþý karþýyasýn. O da senin gibi biri (I) Yüzünde küçük küçük yara izleri (II) Bak, gülüyor. Þimdi de ye- meðini yiyor (III) Ýþte türkü söylüyor, iþte sýkýlýyor (IV) Belki de dertleþecek birini arýyor (V) Numaralý yerlerin hangisine diðerlerinden farklý bi noktalama iþareti gelmeli?";
                questionDisplay.newA = "A.I";
                questionDisplay.newB = "B.II";
                questionDisplay.newC = "C.III";
                questionDisplay.newD = "D.IV";
                questionDisplay.newE = "E.V";
                trueAnswer = "B";
            }
            if (questNumber == 39)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde yer yön belirteci, tamlayan olduðu için adlaþmýþtýr?";
                questionDisplay.newA = "A.Kapýnýn önüne oturmuþ, geleni geçeni izliyor";
                questionDisplay.newB = "B.Çocuðun üstüne kocaman bir battaniye örtmüþler.";
                questionDisplay.newC = "C.Beþ yüz metre ileriden saða döneceksiniz";
                questionDisplay.newD = "D.Yukarýya çýkýp arkadaþýmla da görüþeyim";
                questionDisplay.newE = "E.Dýþarýnýn gürültüsü hepimizi rahatsýz etti";
                trueAnswer = "E";
            }
            if (questNumber == 40)
            {

                questionDisplay.yeniSoru = "Oyunda, 3 arkadaþýn 1984’den bugüne kadar gelen birlikteliði, zaman zaman mizahi, zaman zaman da hüzünlü bir dil kullanýlarak anlatýlýyor.  Bu cümleyle ilgili aþaðýdaki yargýlardan hangisi yanlýþtýr?";
                questionDisplay.newA = "A.Belgisiz sýfat kullanýlmýþtýr";
                questionDisplay.newB = "B.Ýlgeç vardýr";
                questionDisplay.newC = "C.Yüklem, çatýsý bakýmýndan etkendir.";
                questionDisplay.newD = "D.Zarf tümlecinde ikileme yer almýþtýr";
                questionDisplay.newE = "E.Sýfat-fiil vardýr";
                trueAnswer = "C";
            }
            if (questNumber == 41)
            {

                questionDisplay.yeniSoru = "Evin bahçesine dikilecek çamlarýn üzerine konmuþ bir serçe, durmadan cik cik edip þarkýsýný söylüyordu. Evin tekir kedisi eþiðe uzanmýþ, bir yandan örselenmiþ tüylerini düzeltmek için yalarken bir yandan da az ilerdeki çöplükte sallana sallana gezinen kargaya bakýyordu. Bu parçadaki aþaðýdaki sözcüklerden hangisi sözcük türü bakýmýndan diðerlerinden farklýdýr?";
                questionDisplay.newA = "A.Dikilecek";
                questionDisplay.newB = "B.Gezinen";
                questionDisplay.newC = "C.Durmadan";
                questionDisplay.newD = "D.Konmuþ";
                questionDisplay.newE = "E.Örselenmiþ";
                trueAnswer = "C";
            }
            if (questNumber == 42)
            {

                questionDisplay.yeniSoru = "Sözlerinden çok, adýnýn önem kazanmasý, bir eleþtirmenin en büyük korkusudur. Bu cümlenin öðeleri, aþaðýdakilerin hangisinde sýrasýyla, doðru olarak verilmiþtir?";
                questionDisplay.newA = "A.Özne – yüklem";
                questionDisplay.newB = "B.Özne – zarf tümleci – nesne – yüklem";
                questionDisplay.newC = "C.Nesne - yüklem";
                questionDisplay.newD = "D.Nesne – özne – zarf tümleci – yüklem";
                questionDisplay.newE = "E.Özne – zarf tümleci – yüklem";
                trueAnswer = "A";
            }
            if (questNumber == 43)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde bir anlatým bozukluðu vardýr?";
                questionDisplay.newA = "A.Geleceðe umutla bakan ve zorluklar karþýsýnda yýlmayan bir gençti";
                questionDisplay.newB = "B.Maddi durumu yetmediði için eðitimini yarýda býrakmak zorunda kaldý";
                questionDisplay.newC = "C.Ele aldýðý her iþi, baþkalarýndan daha iyi, daha güzel yapmak isterdi";
                questionDisplay.newD = "D.Kültürel varlýklara sahip çýkýp onlarý korumaya çalýþan insanlardan biriyd";
                questionDisplay.newE = "E.Deneyimli bir yönetici, deðerli bir bilim adamýydý";
                trueAnswer = "B";
            }
            if (questNumber == 44)//2003 türkçe 20.soruda kalýndý
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde bir anlatým bozukluðu vardýr?";
                questionDisplay.newA = "A.Ekonomileri daha çok, yetiþtirdikleri hayvancýlýða dayalý";
                questionDisplay.newB = "B.Bu topraklarýn büyük bir bölümü ormanlarla kaplý";
                questionDisplay.newC = "C.Ülkenin kuzeyinde elde edilen ürünlerin yarýdan fazlasýný elma oluþturuyor";
                questionDisplay.newD = "D.Ürettiklerinin çoðunu komþu ülkelere satýyorlar";
                questionDisplay.newE = "E.Dünyada en çok yaðýþ alan bölge burasý.";
                trueAnswer = "A";
            }
            if (questNumber == 45)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde bir anlatým bozukluðu var?";
                questionDisplay.newA = "A.Sorunlarýn, bütün yönleriyle ele alýnmasý iyi olur";
                questionDisplay.newB = "B.Çevremizdeki kiþilerle kuracaðýmýz iliþkilerde özenli olmalýyýz";
                questionDisplay.newC = "C.Bu alanda baþarýya ulaþanlarýn sayýsý oldukça azdýr";
                questionDisplay.newD = "D.Araþtýrmalar, eldeki bilgilerin doðru olmadýðýný kanýtlýyor";
                questionDisplay.newE = "E.Bu konudaki iftiralar tamamen uydurmadýr";
                trueAnswer = "E";
            }
            if (questNumber == 46)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde bir anlatým bozukluðu var?";
                questionDisplay.newA = "A.Kaldýrýmlarýn kýrýk taþlarý, yenileriyle deðiþtiriliyor";
                questionDisplay.newB = "B.Eski yapýlar boyanarak daha güzel bir görünüme kavuþturuluyor";
                questionDisplay.newC = "C.Ýçinde oturulamayacak derecedeki binalarýn yýk-týrýlmasý gerekiyor";
                questionDisplay.newD = "D.Yeni fidanlar dikilerek kent yeþillendiriliyor";
                questionDisplay.newE = "E.Yol kenarýndaki çöp kutularý kaldýrýlarak bunlarýn yerine çiçekler dikiliyor";
                trueAnswer = "C";
            }
            if (questNumber == 47)
            {

                questionDisplay.yeniSoru = "Bu kararlarýn uygulanýp uygulanmayacaðýnýn, yöneticilerin seçeceði tutuma baðlý olduðu bildirildi.Bu cümledeki anlatým bozukluðu aþaðýdaki seçeneklerin hangisiyle giderilebilir?";
                questionDisplay.newA = "A.“seçeceði tutuma” yerine “tutumuna” sözcüðü getirilerek giderilir";
                questionDisplay.newB = "B.“yöneticilerin” yerine “ilgililerin” sözcüðü getirilerek";
                questionDisplay.newC = "C.“bu kararlarýn” yerine “bunlarýn” sözcüðü getirilerek";
                questionDisplay.newD = "D.“baðlý” yerine “yönelik” sözcüðü getirilerek";
                questionDisplay.newE = "E.“bildirildi” yerine “biliniyordu” sözcüðü getirilerek";
                trueAnswer = "A";
            }
            if (questNumber == 48)
            {

                questionDisplay.yeniSoru = "Ýnsanýn kendini deðerlendirebilmesi çok güç; ancak, önceki yapýtlarýmý gözden geçirirken zaman içinde dilimin biraz daha geliþtiðini anladým. Giderek bir üs- lup oluþturmaya baþladýðýmý, dile daha fazla hâkim olabildiðimi gördüm. Bu sözler hangi soruya karþýlýktýr?";
                questionDisplay.newA = "A.Yeni öyküleri ve öykücüleri nasýl deðerlendiriyorsunuz?";
                questionDisplay.newB = "B.Duygu ve düþüncelerinizi yapýtlarýnýza aktarýrken zorluk çekiyor musunuz?";
                questionDisplay.newC = "C.Yaþadýklarýnýzla yazdýklarýnýz arasýnda nasýl bir bað kuruyorsunuz?";
                questionDisplay.newD = "D.Ýlk yapýtlarýnýzla bugünküler arasýnda ne gibi farklar görüyorsunuz?";
                questionDisplay.newE = "E.Öykülerinizi oluþtururken nasýl bir yol izliyorsunuz?";
                trueAnswer = "D";
            }
            if (questNumber == 49)
            {

                questionDisplay.yeniSoru = "Çalýþmalarýmýz sonuç verdi. Neler mi oldu? Ot bitme- yen bozkýrlar, ipek gibi yumuþak topraklý ovalara dö- nüþtü. Tarlalar, arý kovanlarý gibi uðuldamaya baþla- dý. Topraðýn derinliklerinde uyuyan sular yeryüzüne çýkarýldý. Kova kova süt veren inekler, kovan kovan bal veren arýlar yetiþtirildi. Sofralarý, el ele verilerek üretilen yiyecekler süsledi. Bu parçanýn anlatýmýnda ne yoktur?";
                questionDisplay.newA = "A.Betimeleme Yapma";
                questionDisplay.newB = "B.Yinelemelere yer verme";
                questionDisplay.newC = "C.Tanýk gösterme";
                questionDisplay.newD = "D.Öykülemeye baþvurma";
                questionDisplay.newE = "E.Benzetme sanatýndan yararlanma";
                trueAnswer = "C";
            }
            if (questNumber == 50)
            {

                questionDisplay.yeniSoru = "Bu yazarýmýzýn, anlattýðý çevre ve kiþiler hakkýnda geniþ bilgisi vardýr. Ama o, bunu hiçbir zaman açýkça gözler önüne sermez. Anlattýklarý, buzdaðýnýn suyun üstünde kalan kýsmý gibidir. Okur, zamanla buzdaðý- nýn altta kalan kýsmýný fark eder ve yazarýn asýl kimli- ðinin orada saklý olduðunu anlar. Bu parça ile aþaðýdaki yargýlardan hangisinde aralarýnda anlamca yakýnlýk vardýr";
                questionDisplay.newA = "A.Her yazarýn, olaylarý ve kiþileri algýlama biçimi farklýdýr";
                questionDisplay.newB = "B.Kimi yazarlar, yapýtlarýnda kendilerini bütünüyle açýða vurmaktan kaçýnýr";
                questionDisplay.newC = "C.Okur, beðendiði yazarlarýn yapýtlarýndan her okuyuþta deðiþik tatlar alýr";
                questionDisplay.newD = "D.Bir yapýtý, her okur farklý biçimlerde algýlayabilir";
                questionDisplay.newE = "E.Kimi yazarlar, olaylarýn deðerlendirilmesini okura býrakarak ilgi çekmeye çalýþýr";
                trueAnswer = "B";
            }
            if (questNumber == 51)
            {

                questionDisplay.yeniSoru = "Bir gün Nuruosmaniye’de bir yazar arkadaþýmla karþý- laþtým. Ne o beyim, romancýlýða mý baþladýn? dedi. Þaka etmediðini sesinden, bakýþýndan anlamýþtým. De- mek benim takma adla yazmama bir þey demiyordu da kendi adýmý kullanarak yazmamý	sayýyordu. Roman,romancýlarýn alanýydý. Bir ozan buraya burnunu sokamazdý. Bu parçada boþ býrakýlan yere ne gelmeli?";
                questionDisplay.newA = "A.Ýþ çýkarmak";
                questionDisplay.newB = "B.Kendi borusunu çalmak";
                questionDisplay.newC = "C.Çizmeden yukarý çýkmak";
                questionDisplay.newD = "D.Kendi göbeðini kendi kesmek";
                questionDisplay.newE = "E.Baþýna dert açmak";
                trueAnswer = "C";
            }
            if (questNumber == 52)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde klasiklerle ilgili farklý bir düþünce dile getirilmiþtir?";
                questionDisplay.newA = "A.Anlaþýlýp kavranabilmesi özel bir çaba, özel bir okurluk donanýmý gerektirir";
                questionDisplay.newB = "B.Ýnsan, yaþamýnýn her döneminde onlarda kendini bulur";
                questionDisplay.newC = "C.Söyledikleri, hiçbir dönemde tüketilmez";
                questionDisplay.newD = "D.Onlarý okumaktan alýnan haz hiçbir zaman azalmaz";
                questionDisplay.newE = "E.Okurlarýn dünyasýnda özgün ve deðiþmeyen bir yeri vardýr.";
                trueAnswer = "A";
            }
            if (questNumber == 53)
            {

                questionDisplay.yeniSoru = "Barthes’in “Sözcükler herkesin malýdýr ama cümle yalnýzca yazarýn.” sözü aþaðýdakilerden hangisiyle iliþkilendirilemez?";
                questionDisplay.newA = "A.Anlamdaþlýk";
                questionDisplay.newB = "B.Biçem";
                questionDisplay.newC = "C.Öznellik";
                questionDisplay.newD = "D.Özgünlük";
                questionDisplay.newE = "E.Anlatým";
                trueAnswer = "A";
            }
            if (questNumber == 54)
            {

                questionDisplay.yeniSoru = "Yazar; karþýtlýklarýn üst üste yýðýldýðý, ucu açýk, kesin bir yargýya götürmeyen, tam bitmeyen metinleriyle, okuru düþüncelerin eþiðinde býrakýyor. Buna göre yazarýn okura yönelik olarak gerçekleþtirmek istedikleri arasýnda aþaðýdakilerden hangisi yoktur?";
                questionDisplay.newA = "A.Okuduklarýný tamamlatýp onu bütünselliðe kavuþ- turtma";
                questionDisplay.newB = "B.Yorumlamaya yönlendirme";
                questionDisplay.newC = "C.Düþ gücünü geliþtirme";
                questionDisplay.newD = "D.Çok boyutlu düþündürme";
                questionDisplay.newE = "E.Söylenenlerin kanýtlanmasýný isteme";
                trueAnswer = "E";
            }
            if (questNumber == 55)
            {

                questionDisplay.yeniSoru = "Verdiði her uzun aranýn ardýndan yeni albümüyle gönlü- müzü fethetmeyi baþaran pop müziði sanatçýsý, bu kez eski þarkýlarýný yeniden yorumlayarak geçmiþe bugünün penceresinden bakýyor ve dinleyiciyi yine oldukça etkiliyor. Bu paragrafta hangi ses olayý yoktur?";
                questionDisplay.newA = "A.Ünsüz Türemesi";
                questionDisplay.newB = "B.Ünsüz Benzeþmesi";
                questionDisplay.newC = "C.Ünlü Daralmasý";
                questionDisplay.newD = "D.Ünlü Düþmesi";
                questionDisplay.newE = "E.Ünsüz Yumuþamasý";
                trueAnswer = "A";
            }
            if (questNumber == 56)
            {

                questionDisplay.yeniSoru = "Hiçbir söz, hiçbir varsayým, hiçbir kuram yaþanan somut gerçeklerin yerini tutamaz; bin kez söylenen yaðmur sözcüðünün bir damla yaðmurun yerini tutamayacaðý gibi. Burada aþaðýda verilenlerden hangisi yoktur?";
                questionDisplay.newA = "A.Ek fiil almýþ sözcük";
                questionDisplay.newB = "B.Benzetme edat";
                questionDisplay.newC = "C.Sayý sýfatý";
                questionDisplay.newD = "D.Birleþik sözcük";
                questionDisplay.newE = "E.Yeterlik fiili";
                trueAnswer = "A";
            }
            if (questNumber == 57)
            {

                questionDisplay.yeniSoru = "Bilgisayar teknolojisiyle yetiþen kuþaklarda ekrandan kitap okumanýn yaratacaðý hazzý, bilgisayarla ileriki yaþlarda tanýþan insanlar tadamayacaktýr. Bu cümlede aþaðýdakilerden hangisi yoktur?";
                questionDisplay.newA = "A.Ýyelik eki almýþ sözcük";
                questionDisplay.newB = "B.Belirtisiz ad tamlamasý";
                questionDisplay.newC = "C.Ýsim-fiil eki almýþ sözcük";
                questionDisplay.newD = "D.Geçiþsiz çatýlý yüklem";
                questionDisplay.newE = "E.Sýfat tamlamasý";
                trueAnswer = "D";
            }
            if (questNumber == 58)
            {

                questionDisplay.yeniSoru = "Doðu Karadeniz’in yaylalarýný mutlaka görün. Kýyýlarda hiç oyalanmadan kartpostallardaki kadar güzel orman- larýn üzerindeki muhteþem yaylalara çýkýn. Her biri öte- kinden farklý olan yaylalarýn birinden ötekine yürüyün. Ahþap yayla evlerinde konaklayýp yöresel yemeklerin tadýna bakýn. Bu parçanýn anlatýmýyla aþaðýdakilerden hangisi söylenemez?";
                questionDisplay.newA = "A.Karþýlaþtýrma yapýlmýþtýr";
                questionDisplay.newB = "B.Öneri nitelikli cümleler kullanýlmýþtýr";
                questionDisplay.newC = "C.Kiþileþtirmeye baþvurulmuþtur";
                questionDisplay.newD = "D.Benzetmeden yararlanýlmýþtýr";
                questionDisplay.newE = "E.Betimleyici ögelere yer verilmiþtir";
                trueAnswer = "C";
            }
            if (questNumber == 59)
            {

                questionDisplay.yeniSoru = "Sanatçý, yaþama iliþkin bilgi edinme yükümlülüðü altýn- dadýr. Bu demektir ki yaþadýðý zaman diliminde olup bitenlere kaç numaralý camlar gerekiyorsa o camlarýn takýlý olduðu gözlüklerle bakmalýdýr. Bu zorunluluðun bilincine varamayan bir sanatçý, gerçek dünyayý doðru biçimde göremeyecektir. Aþaðýdakilerden hangisi bu parçadabelirtilenleri destekler.";
                questionDisplay.newA = "A.Natüralizm öncesi Avrupa tiyatrosunda yenileþmeler yapýlsada dünya eski ölçütlere göre algýlandýðýndan bunalýma düþüldü.";
                questionDisplay.newB = "B.Pek çok yazar okunmak için deðil,ünlü olmak ve incelenmek için yazýyor";
                questionDisplay.newC = "C.Bir yazar, anlatacaklarýný deðiþtirmeden olduðu gibi dile getirirse yazar deðil, gazeteci ya da politikacý olue";
                questionDisplay.newD = "D.Franz kafkayý anlamak için onun yaþadýðý zamanýn þartlarýný gözönünde bulundurmak gereksiz";
                questionDisplay.newE = "E.Sanatýn tarihi geleneðe baðlý kalýp yeni bir þey ortaya koyan sanatçýlarla doludur";
                trueAnswer = "A";
            }
            if (questNumber == 60)
            {

                questionDisplay.yeniSoru = "Yaþamdan esinlenmeyen, sýð, yaratma cesaretinden yoksun ve ders veren anlatýlar, romansal düþüncenin askýya alýndýðý ucuz bir bildiricilik olur. Bu anlatýlar; insaný, onun acýlarýný, çeliþkilerini derinlik ve incelikle yansýtýp dile getirmeyi baþaramaz. Bu yüzden her nitelikli gerçek yazýnsal yapýt, özellikle kiþinin varoluþsal hâllerini anlatmalý. Böyle bir anlatýmdan yoksunsa o, gerçek bir yapýt sayýlamaz. Buna göre aþaðýdakilerden hangisine varýlamaz?";
                questionDisplay.newA = "A.Öðreticilikten uzak olmalýdýr";
                questionDisplay.newB = "B.Okuyaný düþündüren, etkileyici bir söylemle biçimlendirilmelidir";
                questionDisplay.newC = "C.Yaþananlara yeni biçimler kazandýran sanatsal bir doku taþýmalýdýr";
                questionDisplay.newD = "D.Ýnsan yaþamýný deðiþik boyutlarýyla kuþatmalýdýr";
                questionDisplay.newE = "E.Anlatýcý kendini gizlemelidir";
                trueAnswer = "E";
            }
            if (questNumber == 61)
            {

                questionDisplay.yeniSoru = "Neden þiir yazar ki insan? Havasýzlýktan boðulmak üzere olan evrende nefes alabilmek, var olabilmek, elinde iyi-kötü ne varsa dökebilmek için mi eteklerine? Ýç dünyasýnýn dýþarýyla olan kavgasýnda anlaþýlabilir olma derdi midir kendini kanýtlamak ya da kanatmak? Þairler, görünenin ardýndaki gizemleri ortaya çýkararak bize rehberlik mi ederler? Buna göre aþaðýdakilerden hangisi þairlerin yazma nedeni deðildir?";
                questionDisplay.newA = "A.Yaþamýn bunaltýcýlýðýndan sýyrýlma";
                questionDisplay.newB = "B.Yalnýzlaþmaktan kurtulma";
                questionDisplay.newC = "C.Kendini, anlatarak ortaya koyma";
                questionDisplay.newD = "D.Yaþamýn, ayrýmýna varýlmayan yönlerini duyumsatma";
                questionDisplay.newE = "E.Ruhsal durumuyla yaþam arasýndaki çatýþmayý yansýtma";
                trueAnswer = "B";
            }
            if (questNumber == 62)
            {

                questionDisplay.yeniSoru = "Yüksek maliyetlerle inþa edilen ve þehir mimarisinde hacimli bir yer kaplayan yapýlarýn, yapýlmasýnýn en çözümsüz yaný; yapýldýktan sonra çok büyük bir gayret olmazsa eðer, ayný çirkinlikle onlarca hatta yüzlerce yýl orada kalmasý ve genel manada manzarayý bozmasýdýr. Bu cümlede boþ býrakýlan yere ne getirilebilir?";
                questionDisplay.newA = "A.Batý mimarisine özenilerek";
                questionDisplay.newB = "B.Rengârenk boyalarýn oluþturduðu farklý desenlerle";
                questionDisplay.newC = "C.Geleneksel mimariyle yoðrulmamýþ olarak";
                questionDisplay.newD = "D.Þehirden ve þehrin geleceðinden kopuk bir tasarýmla";
                questionDisplay.newE = "E.Çevre düzenlemesi iyi tasarlanmadan";
                trueAnswer = "D";
            }
            if (questNumber == 63)
            {

                questionDisplay.yeniSoru = "Ýçtenlikle yaþama sevinci içinde olan, güler yüzlü Anadolu insaný günlük hayatýný, sevincini, hasretini türkü yapar kendisine. Kimsenin bilmesini istemediði inancý, sevdasý; gönlünde buram buram tüten umudu... (Hepsi türkülerin görünmez heybesinde taþýnýr.) Bu parçada parantez içindeki sözle anlatýlmak istenen nedir?";
                questionDisplay.newA = "A.Halkýn sýrlarýný ve yaþadýklarýný saklamasý";
                questionDisplay.newB = "B.Güncel sosyal olaylara tanýklýk etmesi";
                questionDisplay.newC = "C.Halkýn duygu ve düþüncelerinden beslenmesi";
                questionDisplay.newD = "D.Dilden dile gönülden gönüle dolaþmasý";
                questionDisplay.newE = "E.Gelenek ve görenekleri günümüze aktarýp korumasý";
                trueAnswer = "A";
            }
            if (questNumber == 64)
            {

                questionDisplay.yeniSoru = "Þair, geleneðin sürüp giden hazýr düþünme kalýplarýný parçaladýðý zaman gerçek parýltýyý, yani iyi þiiri elde edebilir. Bu cümleyle anlatýlmak istenen aþaðýdakilerden hangisidir?";
                questionDisplay.newA = "A.Ýyi þair olmanýn yolu, baþkalarýný besleyecek kaynaklar ortaya koymaktýr";
                questionDisplay.newB = "B.Þiirde sesini duyurmak isteyen bir genç sanatçý, kendinden öncekileri aþmalýdýr";
                questionDisplay.newC = "C.Þiirde yerleþik olan anlayýþlarý yýkmak, genç sanatçýlar için zordur";
                questionDisplay.newD = "D.Þiir alanýnda saðlam bir yer edinebilmenin ön þartý, kendini geliþtirmektir";
                questionDisplay.newE = "E.Bir þair için nitelikli ürünler ortaya koymanýn yolu, alýþýlmýþýn dýþýna çýkmaktýr";
                trueAnswer = "E";
            }
            if (questNumber == 65)
            {

                questionDisplay.yeniSoru = "Osmanlýlarýn yetiþtirdiði büyük sanatkârlar, icra ettikleri sanatý Hakk’a ulaþabilmenin bir aracý olarak görmüþtür. Ýslam ahlaký ile yoðrulmuþ ve (nice gün doðumlarýný arkasýnda býrakmýþ) olan bu derin ve yüksek sanat algýsýnýn, günümüzde anlayaný ve talep edeni ne yazýk ki bir elin parmaklarý kadar az kalmýþtýr. Burada parantezdeki sözle sanat algýsýna yönelik ne anlatýlmak isteniyor?";
                questionDisplay.newA = "A.Büyük bir emek sonucu meydana gelmesi";
                questionDisplay.newB = "B.Geniþ bir boþluðu doldurmasý";
                questionDisplay.newC = "C.Geniþ kitlelerde merak uyandýrmasý";
                questionDisplay.newD = "D.Uzun süre devam etmiþ olmasý";
                questionDisplay.newE = "E.Farklý anlarý bir bütün hâline getirmesi";
                trueAnswer = "D";
            }
            if (questNumber == 66)
            {

                questionDisplay.yeniSoru = "Kavaklarýn alerjik polen üreterek insan saðlýðýný olumsuz etkilediði yönündeki yaygýn inanýþ, son bilimsel çalýþmalarla yerini farklý görüþlere terk etmiþtir. Buradan kesin olarak çýkarýlabilecek yargý aþaðýdakilerden hangisidir?";
                questionDisplay.newA = "A.Alerji bilimi araþtýrmalarý, kesin sonuçlar verebilecek kadar ileri deðildir";
                questionDisplay.newB = "B.Hangi bitkilerin alerjiye neden olduðu konusunda bilgi kirliliði söz konusudur";
                questionDisplay.newC = "C.Alerji araþtýrmalarý sonucunda, benimsenmiþ bazý bilgiler deðiþmektedir";
                questionDisplay.newD = "D.Bilimsel gerçeklerle halk inanýþlarý arasýnda ciddi bir çeliþki vardýr";
                questionDisplay.newE = "E.Kavaklarýn alerjik polen üretmediði, son bilimsel çalýþmalarla kanýtlanmýþtýr";
                trueAnswer = "C";
            }
            if (questNumber == 67)
            {

                questionDisplay.yeniSoru = "Tarihi XVIII. yüzyýla kadar uzanan ve UNESCO tarafýndan Dünya Kültür Mirasý Listesi’ne alýnan Safranbolu Evleri, Türk mimarisinin önemli örneklerindendir. Bucümleden kesin olarak çýkarýlabilecek yargý aþaðýdakilerden hangisidir?";
                questionDisplay.newA = "A.Safranbolu, Türk mimarisinin en önemli örneklerine ev sahipliði yapmaktadýr.";
                questionDisplay.newB = "B.Safranbolu Evleri’nin geçmiþi birkaç yüzyýl öncesine kadar uzanmaktadýr";
                questionDisplay.newC = "C.UNESCO, geleneksel Türk mimarisini araþtýrmak için önemli projeleri desteklemektedir";
                questionDisplay.newD = "D.Safranbolu Evleri, Dünya Kültür Mirasý Listesi’ne yeni dâhil edilen mimari yapýlar arasýnda yer almaktadýr";
                questionDisplay.newE = "E.Safranbolu Evleri’nin geçmiþi birkaç yüzyýl öncesine kadar uzanmaktadýr";
                trueAnswer = "B";
            }
            if (questNumber == 68)
            {

                questionDisplay.yeniSoru = "Bana kalýrsa “Edebiyat eserleri ne zamandýr okurlarýn arzusuna göre biçimlendirilir oldu (I)” diye sormanýn zamaný geldi (II) Ortada aslýnda ayný noktada buluþan iki cevap var (III) Birincisi, popüler edebiyat ürünleri ulaþtýklarý okur sayýsýný gerekçe gösterip nitelikli edebiyat ürünleri arasýnda (IV) yer almayý beklemeye baþladýðýndan beri (V) ikincisi, edebiyat gerçek deðerini kaybedip pazarlama ürünü olduðundan beri. Numaralandýrýlmýþ yerlerden hangisine noktalama iþareti konmaz?";
                questionDisplay.newA = "A.I";
                questionDisplay.newB = "B.II";
                questionDisplay.newC = "C.III";
                questionDisplay.newD = "D.IV";
                questionDisplay.newE = "E.V";
                trueAnswer = "D";
            }
            if (questNumber == 69)
            {

                questionDisplay.yeniSoru = "Bir sanatçýnýn doðal çevresi, elbette içinde yaþadýðý ülkedir. Onun bu çevreyle içten baðlantýlý olmamasý düþünülemez kuþkusuz. Ancak konu, tek baþýna estetik bir deðer taþýmadýðýndan, nereden alýnýrsa alýnsýn sanatçýnýn yaratýcý kiþiliðiyle kaynaþarak sanat eserine dönüþür. ----. Bu parçanýn sonuna akýþa göre ne getirilmelidir?";
                questionDisplay.newA = "A.Dolayýsýyla yabancý bir konuyla yerli bir eser vermek her zaman mümkündür";
                questionDisplay.newB = "B.Yani estetik yaratýmý besleyen güç, sanatçýnýn baðlý olduðu gelenektir";
                questionDisplay.newC = "C.Baþka bir deyiþle, eserin belirleyeni yazarýn yaþadýðý çevredir";
                questionDisplay.newD = "D.Kaliteyi elde etmek ancak bu yolla mümkündür";
                questionDisplay.newE = "E.Bu bakýmdan sanatçýnýn baþarýlý olmasý iþlediði konuya baðlýdýr";
                trueAnswer = "A";
            }
            if (questNumber == 70)
            {

                questionDisplay.yeniSoru = "Artýk çoðu þeyin arasýnda fark kalmadýðýndan mý yoksa farklarý göreceðimizden emin olmadýklarýndan mý nedir, çoktandýr dergilerde, benzer iki resim arasýndaki yedi farký bulmamýzý istemiyor kimse bizden. Oysa biz, birbirinin ayný görünen iki resme baktýðýmýzda, “Aralarýnda bir fark yok!” deyip geçmez, farklarý bulup çýkarýr, neþeyle çýktýðýmýz basamaklarýn bizi götürdüðü yerde bir cümlenin altýný çizerdik: Benzerlikler yanýltýr. Bu parçanýn anlatýmýnda aþaðýdakilerden hangisi vardýr?";
                questionDisplay.newA = "A.Alýntýdan yararlanma";
                questionDisplay.newB = "B.Koþul öne sürme";
                questionDisplay.newC = "C.Soyut kavramlarý somutlaþtýrma";
                questionDisplay.newD = "D.Açýklamaya baþvurma";
                questionDisplay.newE = "E.Örneklere yer verme";
                trueAnswer = "D";
            }
            if (questNumber == 71)
            {

                questionDisplay.yeniSoru = "Günlük küçük dertlerimizi önemsemez görünüp kendimizi “büyük sorunlarýn” adamý olarak göstermek çoðumuzun zaaflarýndandýr. Kendi “küçük sorunlarýný” halledememiþ olmamýzýn hýncýný, kendimizi büyük sorunlara adamýþ gibi gösterip böbürlenerek çýkartmaya çalýþýrýz sanki. Gündelik, küçük sýkýntýlarýmýzdan söz açmak bizi küçük düþürür, öyle mi? Bu parçada asýl anlatýlmak istenen nedir?";
                questionDisplay.newA = "A.Büyük sorunlarý çözme çabalarýmýzýn önündeki en büyük engel küçümsediðimiz gündelik sorunlardýr";
                questionDisplay.newB = "B.Kendimizi büyük sorunlarýn çözümüne adarken küçük sorunlarýmýzý görmezlikten gelmemeliyiz";
                questionDisplay.newC = "C.Büyük sorunlar, çözmekten kaçýndýðýmýz küçük sorunlarýn bir kar topu gibi büyümesinden oluþur";
                questionDisplay.newD = "D.Sorun çözme becerisi olmayan bazý insanlar, kendilerini kabul ettirmek için sorunsuzmuþ gibi görünürler";
                questionDisplay.newE = "E.Küçük sorunlarla uðraþarak sorun çözme becerisini geliþtirmek, insanlarý olduðundan büyük gösterir";
                trueAnswer = "B";
            }
            if (questNumber == 72)
            {

                questionDisplay.yeniSoru = "“Bu metin dilsel olarak kapandý mý artýk bir eserdir.” sözüyle asýl anlatýlmak istenen aþaðýdakilerden hangisidir?";
                questionDisplay.newA = "A.Edebî eserler, kendi içlerinde anlam derinliðine sahiptir";
                questionDisplay.newB = "B.Bir metin, dil ve üslup bakýmýndan üst düzeye eriþmedikçe sonlandýrýlmamalýdýr";
                questionDisplay.newC = "C.Bir edebî eser, yazarýnýn kullandýðý dille var olabilmektedir";
                questionDisplay.newD = "D.Metinlerin eser olabilmesi için mutlaka sonuç bölümlerinin olmasý gerekir";
                questionDisplay.newE = "E.Bir metnin yazarý son sözünü söylemeden, yazdýklarý eser hâline gelmiþ olmaz";
                trueAnswer = "E";
            }
            if (questNumber == 73)
            {

                questionDisplay.yeniSoru = "Yazarýn bir toplumsal benliði, bir de meydana getirdiði metin vardýr. Onun oluþturduðu bu metin dilsel olarak kapandý mý artýk bir eserdir, sonuçlanmýþ bir nesnedir. Ama ayný zamanda bu metin bir üretim kaynaðýdýr. Sözüyle edebi eserlerle ilgili neye deðiniliyor?";
                questionDisplay.newA = "A.Her okunuþta yeni anlamlar çýkarýldýðýna";
                questionDisplay.newB = "B.Kendi dýþýndaki yapýtlara da ilham kaynaðý olduðuna";
                questionDisplay.newC = "C.Okurlarýnýn duygu dünyasýna nüfuz ettiðine";
                questionDisplay.newD = "D.Okurlarýný farklý düzeyde etkilediðine";
                questionDisplay.newE = "E.Yazarýný yeni eserler yazmaya sevk ettiðine";
                trueAnswer = "A";
            }
            if (questNumber == 74)
            {

                questionDisplay.yeniSoru = "Çevresi acýlar içinde kývranýrken sanatçýnýn, mutluluk þarkýlarý söylemeye dili varmaz. Bütün acýlarý kendi acýsý bilmeyen kiþiye sanatçý denemez. Romantizmin “En iyi yazar, kuþ gibi öten yazardýr.” görüþünü Sartre, elinin tersiyle iterek þöyle der: “Yazar kuþ deðildir.” Evet, yazar kuþ deðildir. Yazar niçin yazdýðýný bilmek zorundadýr. Buradan sanatçýlarla ilgili hangi yargýya varýlamaz?";
                questionDisplay.newA = "A.Toplumun bütün acýlarýný kendi yüreðinde duymalýdýr";
                questionDisplay.newB = "B.Toplumun sýkýntýlarýný unutturmak için umut dolu þeyler söyleyebilmelidir";
                questionDisplay.newC = "C.Her zaman gerçekçi olmalý ve neyi, hangi nedenle söylediðini bilmelidir";
                questionDisplay.newD = "D.Toplumdaki geliþmelere ve deðiþmelere kayýtsýz kalmamalýdýr.";
                questionDisplay.newE = "E.Öncelikle içinde yaþadýðý toplumun bir üyesi olduðunu unutmamalýdýr";
                trueAnswer = "B";
            }
            if (questNumber == 75)
            {

                questionDisplay.yeniSoru = "Son yirmi yýlda akýllý teknolojik cihazlarýn----tasarýmlarile ilgi çekici------ stratejileri, bu cihazlarýn bir öncekisürümlerinin deðerini kaybetmesine ve çöp -----için potansiyel atýk hâline gelmesine neden olmaktadýr. Boþ býrakýlan yerlere,sýrasýyla ne gelmeli?";
                questionDisplay.newA = "A.Resmi-Tanýtým-Kutularý";
                questionDisplay.newB = "B.Sevimli-Satýþ-Merkezleri";
                questionDisplay.newC = "C.Güzel-Piyasa-Bölgeleri";
                questionDisplay.newD = "D.Gösteriþli-Pazarlama-Alanlarý";
                questionDisplay.newE = "E.Uygun-Reklam-Tesisleri";
                trueAnswer = "D";
            }
            if (questNumber == 76)
            {

                questionDisplay.yeniSoru = "“Kullanmak” sözcüðü, aþaðýdaki cümlelerin hangisinde “sarf etmek” anlamýnda kullanýlmýþtýr?";
                questionDisplay.newA = "A.Eymen, elindeki þemsiyeyi on yýldýr kullandýðýna kimseyi inandýramadý";
                questionDisplay.newB = "B.Ali, otomobildeki yedek lastiði þu ana kadar hiç kullanmadý";
                questionDisplay.newC = "C.Hatice, kendisine gönderilen parayý idareli kullanmasý gerektiðini biliyordu";
                questionDisplay.newD = "D.Yasin, uzun süre bilgisayar kullanmanýn olumsuz etkilerini araþtýracak";
                questionDisplay.newE = "E.Sema, sabahlarý evinden iþine giderken toplu taþýma araçlarýný kullanýyordu";
                trueAnswer = "C";
            }
            if (questNumber == 77)
            {

                questionDisplay.yeniSoru = "Doðaya týpatýp uygun! -amma da yalan: Sýðdýrýlabilir mi doða küçücük bir resme? Doðanýn en ufak parçasý bile sonsuzdur! Öyleyse ressam neyi çizer? Doðada görüp sevdiðini.Peki ya neyi sever? Resmedebildiðini! Bu mýsralarýn içeriði aþaðýdakilerden hangisiyle ifade edilmez?";
                questionDisplay.newA = "A.Ressamlarýn görsel dünyayý birebir tuvale aktardýklarý tartýþma götürmez";
                questionDisplay.newB = "B.Ressamlar gördükleri yeri kendi tarz ve ruh hâllerinin süzgecinden geçirerek kâðýda aktarýrlar";
                questionDisplay.newC = "C.Ressamýn kendi yaptýðý resmi beðenme nedeni, resim için seçtiði ögeleri sevmesidir";
                questionDisplay.newD = "D.Ressamlar aslýnda eserlerinde kendi seçtikleri ögeleri resmederler";
                questionDisplay.newE = "E.Ýki ayrý ressamýn ayný yere odaklanýp ayný resimleri üretmeleri beklenemez";
                trueAnswer = "A";
            }
            if (questNumber == 78)
            {

                questionDisplay.yeniSoru = "Türk edebiyatýnýn önemli sanatçýlarýndan Yaþar Kemal’in, düþlerine sýðýnarak hayata tutunmaya çalýþan sokak çocuklarýnýn unutulmamaya mühürlenen hayat hikâyelerini anlattýðý Neredesin Arkadaþým, büyük ustanýn çocuklarla yaptýðý söyleþilerden oluþmaktadýr. Bu cümleden kesin þekilde çýkarýlabilecek yargý seçeneklerden hangisidir?";
                questionDisplay.newA = "A.Yaþar Kemal’in sokak çocuklarý üzerine yaptýðý araþtýrmalar okurlarca beðenildiði için bir araya getirilmiþtir";
                questionDisplay.newB = "B.Neredesin Arkadaþým adlý eseriyle Yaþar Kemal, ilk defa sokak çocuklarýnýn sorunlarýný bir öykü kitabýnda iþlemiþtir";
                questionDisplay.newC = "C.Neredesin Arkadaþým adlý eser, Yaþar Kemal’in sokak çocuklarýyla yaptýðý röportajlarýn bir seçkisi olarak yayýmlanmýþtýr";
                questionDisplay.newD = "D.Sokak çocuklarýnýn hayat hikayelerini konu edinen Neredesin Arkadaþým adlý öykü kitabý üzerine Yaþar Kemal’le yapýlan röportajlar bir kitap hâline getirilmiþtir";
                questionDisplay.newE = "E.Sokak çocuklarýndan edindiði izlenimlerle Yaþar Kemal, Neredesin Arkadaþým adlý öyküyü sokak çocuklarýna ithaf etmiþtir";
                trueAnswer = "C";
            }
            if (questNumber == 79)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde týrnak içindeki söz, eylemin nasýl gerçekleþtiðini bildirmektedir?";
                questionDisplay.newA = "A.'Biraz sonra', yaklaþýk iki saat sürecek maceralý bir yolculuða çýkacaðýz";
                questionDisplay.newB = "B.Ýþinin 'akþama kadar' biteceðini umuyordu ama düþündüðü gibi olmadý";
                questionDisplay.newC = "C.Güvercinler yiyecek bulmak için 'her zaman' buraya gelirlerdi";
                questionDisplay.newD = "D.Genleriyle oynanmýþ tohumlarýn kullanýmý 'hýzla' yaygýnlaþýyor";
                questionDisplay.newE = "E.Zaman hýzla akarken 'çoðu kez', çevremizdeki güzelliklerin farkýna varamýyoruz";
                trueAnswer = "D";
            }
            if (questNumber == 80)
            {

                questionDisplay.yeniSoru = "Çevresi(I) büyük bir piknik alaný olarak düzenlenip halka açýlan Mogan Gölü’nün kuþlarýn kuluçka ve yavrulamasýna ayrýlan(II) doðal park kýsmýnda(III) kývrýmlý(IV) ahþap yayla yollarý(V) ve kuþ gözlemevleri yapýlmýþ. Bu cümlede numaralandýrýlmýþ sözcüklerden hangisinde ünlü düþmesi yoktur?";
                questionDisplay.newA = "A.I";
                questionDisplay.newB = "B.II";
                questionDisplay.newC = "C.III";
                questionDisplay.newD = "D.IV";
                questionDisplay.newE = "E.V";
                trueAnswer = "E";
            }
            if (questNumber == 81)
            {

                questionDisplay.yeniSoru = "Yapýlandýrýcý dil yaklaþýmýna göre dinleme, geliþimsel ve etkileþimsel bir süreçtir. Aþaðýdaki cümlelerden hangisi ögelerin diziliþi bakýmýndan bu cümleyle aynýdýr?";
                questionDisplay.newA = "A.Dinleme eðitiminin bir diðer amacý zihinsel becerilerin geliþtirilmesidir";
                questionDisplay.newB = "B.Dinleme, sadece iletiþim kurmak için yapýlan bir etkinlik deðildir";
                questionDisplay.newC = "C.Dinleme becerisinin geliþtirilmesi için etkinlik önemli bir unsurdur.";
                questionDisplay.newD = "D.Dil öðrenme süreci dinleme yoluyla anne karnýnda baþlar";
                questionDisplay.newE = "E.Etkili bir dinleme için dinleyici ön bilgilerini harekete geçirmelidir";
                trueAnswer = "C";
            }
            if (questNumber == 82)
            {

                questionDisplay.yeniSoru = "Mutluluðun en önemli sýrlarýndan bazýlarý bence þunlardýr ( ) ömrümüzün sonuna dek çalýþmak ( ) yeteneðimiz elverdiði ölçüde yararlý yapýtlar ortaya koymak ( ) gücümüz yettiðince ailemize ve çevremize destek olmak ( ) Ayraçlarla belirtilen yerlere aþaðýdakilerden hangi noktalama iþaretleri sýrasýyla getirilebilir?";
                questionDisplay.newA = "A.(;) (,) (;) (.)"; 
                questionDisplay.newB = "B.(:) (;) (,) (.)";
                questionDisplay.newC = "C.(:) (,) (,) (...)";
                questionDisplay.newD = "D.(;) (,) (.) (...)";
                questionDisplay.newE = "E.(:) (;) (,) (...)";
                trueAnswer = "C";
            }
            if (questNumber == 83)
            {

                questionDisplay.yeniSoru = "(I)	“Yazdýklarým boyumu aþtý!” diyenlerden deðilim.(II)Ben de elimden geldiðince iyi eserler vermeye çalýþtým.(III)Ama bu eserlerdeki kaliteyi ve yeterli olup olmadýðýný ben deðil, toplum söyleyecek.(IV)Ben de sorumluluk sahibi her insan gibi toplumsal birikime katkýda bulunmaya devam edeceðim.(V)Saðlýðým el verirse çok yakýn bir zamanda yeni bir romanda okurlarýmla buluþmayý düþünüyorum. Bu parçadaki numaralanmýþ cümlelerden hangisinde anlatým bozukluðu var?";
                questionDisplay.newA = "A.I";
                questionDisplay.newB = "B.II";
                questionDisplay.newC = "C.III";
                questionDisplay.newD = "D.IV";
                questionDisplay.newE = "E.V";
                trueAnswer = "C";
            }
            if (questNumber == 84)
            {

                questionDisplay.yeniSoru = "Genelde mistik Doðu’nun, özelde Türk edebiyatýnýn en büyük mutasavvýflarýndan biridir Mevlana. Halk ve Hak âþýðý olan Mevlana, kiþisel geliþim serüvenini “Hamdým, piþtim, yandým.” ifadesiyle özetler. Mevlana bu sözleriyle ne anlatmak istemiþtir?";
                questionDisplay.newA = "A.Olgunluðun aþamalar sonucu gerçekleþtiðini";
                questionDisplay.newB = "B.Bu dünyanýn geçici olduðunu";
                questionDisplay.newC = "C.Hiçbir geliþmenin sebepsiz olmayacaðýný";
                questionDisplay.newD = "D.Her insanýn kendine özgü bir serüveninin olduðunu";
                questionDisplay.newE = "E.Ýnsan ruhunun mükemmelleþmek zorunda olduðunu";
                trueAnswer = "A";
            }
            if (questNumber == 85)
            {

                questionDisplay.yeniSoru = "Çok defa bir romancý, romanýna girerken hatta bir þair, þiirine baþlarken kelimeler onu takar peþine ve götürür götüreceði yere. Ne konu kalýr ne plan. Yazarlar ve þairler her zaman konularýna tam hâkim olamaz. Ben bir saniye sonra kullanacaðým cümlenin bir kelimesini þimdiden size söyleyebilir miyim? Bu parçada asýl anlatýlmak istenen nedir?";
                questionDisplay.newA = "A.Yazýda plan yapmak, yazarýn düþ dünyasýný sýnýrlandýrýr";
                questionDisplay.newB = "B.Plan, kurgunun saðlamlýðý açýsýndan yazarýn vazgeçilmez rehberidir";
                questionDisplay.newC = "C.Sanatçý temel yapýyý kurduktan sonra yazma iþi kolaylaþýr";
                questionDisplay.newD = "D.Kelimeler, sanatçýnýn varacaðý noktayý belirleyen esas unsurlardýr";
                questionDisplay.newE = "E.Üslup kaygýsý edebî metnin temel dinamiðidir";
                trueAnswer = "D";
            }
            if (questNumber == 86)
            {

                questionDisplay.yeniSoru = "Türkiyenin modernleþmesi ile türk romaný ortaya çýktý.Batý Avrupa’nýn doðusundaki kimi ülkelere ait romancýlar gibi Türk romancýlarý da çoðu zaman aþaðýlýk duygusuna varan bu gecikmiþlik duygusunu, yakýn zamanlarda roman küresel bir yönelime girinceye kadar üstlerinden atamadýlar. ----. Bu parçada boþ býrakýlan yere,düþüncenin akýþýna göre ne getirilmeli?";
                questionDisplay.newA = "A.Aradan uzun bir zaman geçmesine raðmen Türk romaný beklenen atýlýmý henüz gerçekleþtirememiþtir";
                questionDisplay.newB = "B.Türk romaný çaðdaþlarýna yetiþip batý romanýndan daha parlak bir vaziyettedir.";
                questionDisplay.newC = "C.Türk romancýlarý dünyaca benimsenen tema ve üslublarla çaðdaþlarýna yol göstermektedir.";
                questionDisplay.newD = "D.Böylece Türkiye'de romanýn ilk evresindeki bocalama,bir uygarlýðýn dönüþüm geçirmeçabasýn sorunudur.";
                questionDisplay.newE = "E.Çaðdaþ Türk romanýnýn sorunlarýný ve içinde bulunduðu durumu daha iyi anlayabilmek için Tanzimat yýllarýna gitmek gerektir";
                trueAnswer = "B";
            }
            if (questNumber == 87)
            {

                questionDisplay.yeniSoru = "Durmadan artýyor edebiyata iliþkin tutarsýzlýklar. ----. Bir yandan da belgesiz savlar, yanlýþ anlamalar, aldatýcý ön yargýlar kaplýyor ortalýðý";
                questionDisplay.newA = "A.Masum umutlarla yola çýkmýþ yeni kalemler yaþatýyor dergileri";
                questionDisplay.newB = "B.Kitap satýþlarý ve dergi abonelikleri gün geçtikçe düþüyor";
                questionDisplay.newC = "C.Þiir, hikâye ve roman okuyanlarýn sayýsý büyük bir hýzla artýyor";
                questionDisplay.newD = "D.Yazarlarýn magazin programlarýna nesne olacaðý günler geliyor";
                questionDisplay.newE = "E.Yazarýn kimlik arayýþýný doðal olarak bu arayýþýn bunalýmý izliyor";
                trueAnswer = "D";
            }
            if (questNumber == 88)
            {

                questionDisplay.yeniSoru = "Dünyada arasanýz da benden daha küreselini bulamazsýnýz. Hangi memlekete gitsem yalnýz orada oturduðumu sanýyorlar. Küreselim ve bütün insanlarýn dostluk, kardeþlik, barýþ içinde sevgi ve saygýyla yaþamasýný, yardýmlaþmasýný istiyorum Bu parçada yazar neyi vurgulamaktadýr?";
                questionDisplay.newA = "A.Farklýlýklara saygý duyulmasý gerektiðini";
                questionDisplay.newB = "B.Her memlekette bir evi olduðunu";
                questionDisplay.newC = "C.Bütün dünyayý kendi evi gibi hissettiðini";
                questionDisplay.newD = "D.Farklý ülkeleri gezmeyi çok sevdiðini";
                questionDisplay.newE = "E.Her insanýn bir bütünün parçasý olduðunu";
                trueAnswer = "E";
            }
            if (questNumber == 89)
            {

                questionDisplay.yeniSoru = "Reþat Nuri Güntekin: “Niye kitap okumuyor demek, niye piyano çalmýyor demek gibi bir þeydir. Kafayý kitap okumaya alýþtýrmak, parmaklarý piyanoya alýþtýrmaktan daha kolay deðildir.” *Kitap okuma ile ilgili olarak anlatýlmak istenen nedir?*";
                questionDisplay.newA = "A.Ýnsanýn sonradan geliþtirdiði bir eylem olmasý";
                questionDisplay.newB = "B.Okuma becerisinin zaman ve çaba gerektirmesi";
                questionDisplay.newC = "C.Küçük yaþta kazanýlabilecek bir davranýþ olmasý";
                questionDisplay.newD = "D.Uzun zamanda edinilecek bir alýþkanlýk olmasý";
                questionDisplay.newE = "E.Zihinsel yönüyle öne çýkan bir edinim olmasý";
                trueAnswer = "B";
            }
            if (questNumber == 90)
            {

                questionDisplay.yeniSoru = "Gerçekler ne kadar çalkantýlý ne kadar bulanýk ne kadar çýkarcý olursa olsun, insanoðlu gene de düþten vazgeçmiyor.Baudelaire der ki: 'eylemle düþü kardeþ saymak” burada vurgulanmak istenen aþaðýdakilerden hangisidir?";
                questionDisplay.newA = "A.Sanatýn barýþ için en güçlü araç olmasý";
                questionDisplay.newB = "B.Sanatçýnýn gerçeklerden uzak durmasý";
                questionDisplay.newC = "C.Edebî eserin kendi kurallarýna göre þekillenmesi";
                questionDisplay.newD = "D.Çýkar amaçlý sanat faaliyetlerinden arýnýlmasý";
                questionDisplay.newE = "E.Sanat eserlerinin hayale dayanmasý";
                trueAnswer = "E";
            }
            if (questNumber == 91)
            {

                questionDisplay.yeniSoru = "Bu dönem yazarlarý roman, tiyatro ve aný gibi türlerin ilk örneklerini verirken nasýl “bakir” bir alanda ilerliyor idiyseler eleþtiri alanýnda da önlerinde örnek olabilecek çalýþmalardan yoksun olarak iþe baþladýlar. Fransýz edebiyatýnýn çoðu zaman geliþigüzel olarak seçtikleri ürünlerini model aldýlar. Onlar için sanat,toplumsal düþüncelerini yaymaya yarayan bir araçtý. *Buna göre Tanzimat Dönemi yazarlarýnýn özelliði aþaðýdakilerden hangisi deðildir?*";
                questionDisplay.newA = "A.Çok yönlü bir eleþtiri kültürüne sahip olmalarý";
                questionDisplay.newB = "B.Mesaja odaklý bir sanat anlayýþý geliþtirmeleri";
                questionDisplay.newC = "C.Genellikle Fransýz edebiyatýndan esinlenmeleri";
                questionDisplay.newD = "D.Edebiyat anlayýþlarýnda geçmiþin izlerinin de olmasý";
                questionDisplay.newE = "E.Pek çok edebî türün ilk örneklerini vermeleri";
                trueAnswer = "A";
            }
            if (questNumber == 92)
            {

                questionDisplay.yeniSoru = "Bir grup araþtýrmacýnýn yaptýðý çalýþmaya göre uzun süre oturanlarýn saatte bir beþ dakika yürümesi, bacak atardamarlarýnýn zarar görmesini önlüyor.Otururken kalbe kan pompalayan gevþek kaslar yeterince kasýlmýyor.Kan, bacaklarda birikebiliyor ve bu artan kan akýþýndan dolayý damarlarýn geniþlemesini önlüyor. *Bu parçada aþaðýdakilerden hangisine deðinilmemiþtir?*";
                questionDisplay.newA = "A.Duruþ pozisyonunun insan saðlýðýna olan etkisine";
                questionDisplay.newB = "B.Kalp ve damar hastaklýklarýný tetikleyen bazý nedenlere";
                questionDisplay.newC = "C.Bacaklarda meydana gelen kan birikiminin sebeplerine";
                questionDisplay.newD = "D.Yürüyüþün damar saðlýðý açýsýndan önemine";
                questionDisplay.newE = "E.Bacaklarda meydana gelen kas erimesinin nedenlerine";
                trueAnswer = "E";
            }
            if (questNumber == 93)
            {

                questionDisplay.yeniSoru = "Erkek diliyle yazan kadýnlara rastladýðým da oluyor, eserlerini okuduðumda kadýn olduklarýný sandýðým erkekler de tanýyorum. Erkeklerin erkeklikleriyle, kadýnlarýn kadýnlýklarýyla nasýl hesaplaþtýðýný izlemek, cinsel kodlarýn nasýl da kolayca sýzýp yazýda kendine yer açtýðýný görmek hem can sýkýcý hem öðretici. Bunun farkýnda olabilmek ve ötesine geçerek yazabilmek benim için çok önemli. ";
                questionDisplay.newA = "A.Yazarýn cinsel kimliðiyle dilsel seçimleri arasýndaki iliþkiyi çözümlemek, okur için ilginç olabilir";
                questionDisplay.newB = "B.Eserlerinde karþý cinsin hassasiyetlerini dikkate alan bir yazar, ustalýða ulaþmýþ sayýlmalýdýr";
                questionDisplay.newC = "C.Yazarýn eserini yaratýrken kendi cinsel kimliðinin dýþýna çýkabilmeyi baþarmasý, pek kolay deðildir";
                questionDisplay.newD = "D.Bir metinde, cinsiyete ait kodlar bilinçli ya da bilinçsiz bir þekilde kendine yer bulabilmektedir";
                questionDisplay.newE = "E.Yazarlar dil ve söylemleriyle kendi cinsel kimliklerini eserlerine yansýttýklarýný fark etmeyebilirler";
                trueAnswer = "D";
            }
            if (questNumber == 94)
            {

                questionDisplay.yeniSoru = "Yolunu belirlemiþ, çizgisini çizmiþ bir yazar olmak kolay iþ deðildir. Bir yazar, (gözü ikide bir okuyucuya kaymadan) ortaya bir eser koyabilmiþse ona saygý duymak gerekir. Çünkü yazar kendisini ancak bu yolla istediði gibi ifade edebilir, özgün ürünler ortaya koyabilir. Burada ayraçtaki sözle anlatýlmak istenen nedir?";
                questionDisplay.newA = "A.Beðenilme kaygýsý taþýmamak";
                questionDisplay.newB = "B.Baþkalarýnýn görüþlerini almamak";
                questionDisplay.newC = "C.Okuyucuya deðer vermemek";
                questionDisplay.newD = "D.Baþkalarýna benzemekten kaçýnmak";
                questionDisplay.newE = "E.Kendi düþüncelerini benimsetmeye çalýþmak";
                trueAnswer = "A";
            }
            if (questNumber == 95)
            {

                questionDisplay.yeniSoru = "1779’da Nicholas Cugnot adýnda bir Fransýz askeri tarafýndan karada yol alan ilk mekanik taþýt yapýlýncaya kadar kara taþýmacýlýðý; katýr, at gibi hayvanlar tarafýndan çekilen arabalarla saðlanýyordu. *Buradan kesinlikle çýkarýlabilecek yargý hangisidir?*";
                questionDisplay.newA = "A.Profesyonel taþýmacýlýk faaliyetleri, XVIII. yüzyýlda Fransa’da baþlamýþtýr";
                questionDisplay.newB = "B.Mekanik taþýtlar, XVIII. yüzyýlda yalnýzca Fransa’da kullanýlmýþtýr";
                questionDisplay.newC = "C.Hayvan gücüyle çekilen kara araçlarý çok uzun süre kullanýlmýþtýr";
                questionDisplay.newD = "D.Mekanik taþýtlar, hayvan taþýmacýlýðýný sona erdirmiþtir.";
                questionDisplay.newE = "E.Karada yol alan ilk mekanik taþýt askerî amaçlarla üretilmiþtir";
                trueAnswer = "C";
            }
            if (questNumber == 96)
            {

                questionDisplay.yeniSoru = "Eleþtiride güvenirlik, (edebiyat kuyusunun karanlýklarýna) ýþýk tutabilmek amacýyla, bilimsel bilgilerden yararlanýlarak saðlanýr. Edebiyata iliþkin olgularý yüzeysel olarak kavrayýp bilimsel bilgilerle denetlemeye kalkmak da bilimsel bir eleþtiri niteliði taþýmaz. *Ayraçtaki sözle anlatýlmak istenen nedir?";
                questionDisplay.newA = "A.Geçerliliðini yitirmiþ sanatsal ögeleri belirlemek";
                questionDisplay.newB = "B.Edebiyat eserlerinde, söylenenin ardýndaki söylenmeyeni ortaya çýkarmak";
                questionDisplay.newC = "C.Sanatsal deðeri önemsemeyen sanatçýlarý eleþtirmek";
                questionDisplay.newD = "D.Metinde anlamý bilinmeyen sözcükleri açýklamak";
                questionDisplay.newE = "E.Edebiyat eserlerini günün koþullarýna göre yorumlamak";
                trueAnswer = "B";
            }
            if (questNumber == 97)
            {

                questionDisplay.yeniSoru = "Avrupa Birliði tarafýndan desteklenen ve Balkanlarýn en kapsamlý festivallerinden biri olan Saraybosna Çocuk Festivali; palyaçolar, sihirbazlar ve renkli kostümlerle bol eðlence sunarken eðitici film gösterileri ve sanat atölyeleriyle de çocuklarýn ufkunu geniþletiyor. *Bu cümleden kesin olarak çýkarýlabilecek yargý aþaðýdakilerden hangisidir?";
                questionDisplay.newA = "A.Festivalin öncelikli amacý çocuklardaki sanat eðilimini ortaya çýkarmaktýr";
                questionDisplay.newB = "B.Saraybosna Çocuk Festivali, her yýl baþka bir Balkan ülkesinde düzenlenmektedir";
                questionDisplay.newC = "C.Saraybosna Çocuk Festivali sadece Avrupa Birliði tarafýndan desteklenmektedir";
                questionDisplay.newD = "D.Festivalde çocuklarýn geliþimini destekleyecek etkinlikler de düzenlenmiþtir";
                questionDisplay.newE = "E.Bu yýlki Saraybosna Çocuk Festivali UNICEF’in destekleriyle gerçekleþtirilmiþtir";
                trueAnswer = "D";
            }
            if (questNumber == 98)
            {

                questionDisplay.yeniSoru = "Keþanlý Ali Destaný adlý dizinin senaristi, eserin yazarý olan Haldun Taner’in kurduðu hikâyeyi bozmadan senaryoyu yeni bir baðlam içinde deðerlendirmiþ. *Bu cümleden kesin olarak çýkarýlabilecek yargý aþaðýdakilerden hangisidir?";
                questionDisplay.newA = "A.Eser, asýl hikâyeden yola çýkýlarak yeni bir kurguyla diziye uyarlanmýþtýr";
                questionDisplay.newB = "B.Haldun Taner’in eseri, günümüze baþarýlý bir þekilde uyarlanmýþtýr";
                questionDisplay.newC = "C.Haldun Taner’in eseri, yeni ve farklý teknikler kullanýlarak uyarlanmýþtýr";
                questionDisplay.newD = "D.Senarist, eseri diziye uyarlarken yazarýn da görüþlerini almýþtýr.";
                questionDisplay.newE = "E.Senarist, romanýn yazarýndan daha baþarýlý bulunmuþtur";
                trueAnswer = "A";
            }
            if (questNumber == 99)
            {

                questionDisplay.yeniSoru = "Gerçekten þaþýrtýcý, etkileyici ve garip bir ustalýk barýndýran bu öyküler, edebiyat tarihimiz açýsýndan incelenmeye deðer olduðu kadar, bugün yazýlmýþ gibi taze ve aþýnmamýþ konularýyla, akýcý üslubuyla da bize okuma zevki yaþatacak bir nitelik taþýyor. *Buna göre öyküler aþaðýdakilerden hangisiyle nitelendirilemez?*";
                questionDisplay.newA = "A.Alýþýlmýþtan farklý olan";
                questionDisplay.newB = "B.Yenilikler içeren";
                questionDisplay.newC = "C.Okuyanda iz býrakan";
                questionDisplay.newD = "D.Sanat deðeri taþýyan";
                questionDisplay.newE = "E.Belli bir mesaj içeren";
                trueAnswer = "E";
            }
            if (questNumber == 100)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde “bu” sözcüðü, sözcük türü bakýmýndan ötekilerden farklýdýr?";
                questionDisplay.newA = "A.Bu sonuçlara ulaþmak hepimiz için oldukça zor oldu";
                questionDisplay.newB = "B.Herkesin yaþama hakký vardýr ve bu kutsaldýr";
                questionDisplay.newC = "C.Ne kadar açýklamaya çalýþsa da bunun bir yararý olmayacaktý";
                questionDisplay.newD = "D.Bu onun tek baþýna üstesinden gelebileceði bir sorun deðildi";
                questionDisplay.newE = "E.Görsel veriler yardýmýyla bunlarýn öðretilmesi daha etkili";
                trueAnswer = "A";
            }
            if (questNumber == 101)
            {

                questionDisplay.yeniSoru = "Alnýma düþtükçe damlalar sýkça Kalbimi karanlýk þeylerle yordum, Etrafý acý bir gölge sardýkça Siz gülüyordunuz, ben aðlýyordum. *Bu dizelerde aþaðýdaki ses olaylarýndan hangisi yoktur?*";
                questionDisplay.newA = "A.Ünsüz yumuþamasý";
                questionDisplay.newB = "B.Ünsüz benzeþmesi";
                questionDisplay.newC = "C.Ünsüz düþmesi";
                questionDisplay.newD = "D.Ünlü daralmasý";
                questionDisplay.newE = "E.Ünlü düþmesi";
                trueAnswer = "C";
            }
            if (questNumber == 102)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde “-yor” eki, diðerlerinden farklý bir zaman anlamý katmýþtýr?";
                questionDisplay.newA = "A.Bataklýk yakýnlarýnda yaþayan sülün boyutundaki hoatzin kuþu, yiyeceklerini fermente ederek sindiriyor";
                questionDisplay.newB = "B.Genetik ve çevresel faktörler etkileþerek otizmin ortaya çýkmasýnda rol oynuyor";
                questionDisplay.newC = "C.Astronomlar, evrenimizi giderek artan bir hýzla geniþleten gizemli hýzlandýrýcýyý “karanlýk enerji” olarak adlandýrýyor";
                questionDisplay.newD = "D.Ünlü erken dönem kartografya tarihi uzmaný, bir derginin konuðu olarak Ýstanbul’a geliyor";
                questionDisplay.newE = "E.Hep ne bulacaðýmý hiç bilmeden suya dalýyor ve hepte gördüklerim karþýsýnda büyülenmiþ olarak sudan çýkýyorum";
                trueAnswer = "D";
            }
            if (questNumber == 103)
            {

                questionDisplay.yeniSoru = "Duvara bir titiz örümcek gibi, Ýnce dertlerimle iþledim bir að. Ruhum, gün doðunca sönecek gibi, Þimdiden hayata ediyor veda. *Bu dizelerde aþaðýdakilerden hangisi yoktur?";
                questionDisplay.newA = "A.Zaman zarfý";
                questionDisplay.newB = "B.Edat";
                questionDisplay.newC = "C.Ýsim-fiil";
                questionDisplay.newD = "D.Birleþik eylem";
                questionDisplay.newE = "E.Belgisiz sýfat";
                trueAnswer = "C";
            }
            if (questNumber == 104)
            {

                questionDisplay.yeniSoru = "Ýspanyol edebiyatýnýn altýn kalemi Cervantes, Don Kiþot adlý ölümsüz eserinde, onuru için savaþan ve ölen, parasý ölçüsünde deðil, ahlaki erdemleri ölçüsünde saygý gören insan tipini ortaya koyarken ayný zamanda karmaþýk bir çaðý da özetliyordu. *Bu cümlede aþaðýdakilerden hangisi yoktur?*";
                questionDisplay.newA = "A.Sayý sýfatý";
                questionDisplay.newB = "B.Ünlü uyumuna uymayan ek";
                questionDisplay.newC = "C.Ýsim tamlamasý";
                questionDisplay.newD = "D.III.tekil iyelik ekiyle çekimlenmiþ sözcük";
                questionDisplay.newE = "E.Birden fazla yapým eki almýþ sözcük";
                trueAnswer = "A";
            }
            if (questNumber == 105)
            {

                questionDisplay.yeniSoru = "Ünlü psikolog þöyle diyor: “Eylem, duyguyu izler gibi görünür ama aslýnda duygu ve eylem birlikte gider. Bu yüzden, iradenin denetiminde olan eylemi düzenleyerek duygularý da düzenleyebilirsiniz.” *Psikolog bu sözleriyle aþaðýdakilerden hangisini vurgulamýþtýr?*";
                questionDisplay.newA = "A.Duygularla uyuþmasada yanlýþ davranýþlardan vazgeçmelidir";
                questionDisplay.newB = "B.Ýnsan, duygularýný kolaylýkla denetim altýna alabilir";
                questionDisplay.newC = "C.Davranýþlarý kontrol edebilmek, duygularý da kontrol edebilmeyi saðlar";
                questionDisplay.newD = "D.Genellikle duygular, bütün davranýþlarý biçimlendirir";
                questionDisplay.newE = "E.Her davranýþ, aslýnda farkýnda olunmayan bazý duygulardan kaynaklanýr";
                trueAnswer = "C";
            }
            if (questNumber == 106)
            {

                questionDisplay.yeniSoru = "Hem roman hem de öykü yazan Truman Capote da öyküye farklý bir rol biçenlerdendir. Capote özellikle kýsa öykünün yazar için bir tür parmak jimnastiði olarak deðerlendirilmesine itiraz eder. *Capote'nun kýsa öykü ile ilgili itirazý aþaðýdakilerden hangisidir?";
                questionDisplay.newA = "A.Roman ile eþ deðer tutulmasý";
                questionDisplay.newB = "B.Kolayca yazýldýðýnýn düþünülmesi";
                questionDisplay.newC = "C.Hacimsiz olarak kabul edilmesi";
                questionDisplay.newD = "D.Okur kitlesinin farklý gösterilmesi";
                questionDisplay.newE = "E.Anlatýmýn yavan olarak görülmesi";
                trueAnswer = "B";
            }
            if (questNumber == 107)
            {

                questionDisplay.yeniSoru = "Bir sanatçýmýz  þöyle diyor: “Dergiler,  edebiyatýn  yeraltý haritasýdýr.” Nitekim bu dergilerde ilk ürünleri yayýmlanan genç þairlerin çoðu, bir süre sonra çalýþmalarýný kitaplaþtýrarak þairliklerinin ilk kilometre taþlarýný koyarlar. *'Edebiyatýn yeraltý haritasý' sözüyle,dergilerin hangi özelliði belirtilmek istenmiþ?";
                questionDisplay.newA = "A.Þiiri öteki türlerin önüne geçirme";
                questionDisplay.newB = "B.Sanatçýlarýn birbirlerinden yararlanmasýna ortam hazýrlama";
                questionDisplay.newC = "C.Sanatçýlarý, farklý algýlama kalýplarý içinde düþün- dürme";
                questionDisplay.newD = "D.Gizli yeteneklerin gün ýþýðýna çýkmasýna olanak saðlama";
                questionDisplay.newE = "E.Yazarlarý, yeni yazýnsal türlere yönlendirme";
                trueAnswer = "D";
            }
            if (questNumber == 108)
            {

                questionDisplay.yeniSoru = "2.	Kim bilir kaç kere karar verip  de  baþlayamadýðým  bir  iþi bu yýl da ertelemek zorunda kaldým. Türkçe  Söz- lük’ü alýp baþtan sona okuma düþüncem  yine  hayal oldu. Oysa 'sözcüklerin kuytulara yatmýþ, öteki yüzleriyle karþýlaþmak' tadýna  doyulmaz bir eðlence  olacaktý benim için. *Týrnak içindeki sözle,sözcüklere yönelik olarak anlatýlmak istenen nedir?*";
                questionDisplay.newA = "A.Yapýsal özelliklerini tanýmak";
                questionDisplay.newB = "B.Ýlk anda akla gelmeyen anlamlarýný öðrenmek";
                questionDisplay.newC = "C.Gündelik dilde kullanýlanlarý araþtýrmak";
                questionDisplay.newD = "D.Yenilerini eskilerinden ayýrabilmek";
                questionDisplay.newE = "E.Yeni bir sözlük oluþturmak";
                trueAnswer = "B";
            }
            if (questNumber == 109)
            {

                questionDisplay.yeniSoru = "Aþaðýdakilerin hangisinde verilen cümle, ayraç içindeki sözün anlamýný içermemektedir?";
                questionDisplay.newA = "A.Öykülerinizde  ayrýntýlardan  kaçýnmanýzý,  yalýnlýða baðlý kalmanýzý çok beðendim; bu, sizin yoðunluða verdiðiniz önemi gösterir. (çýðýr açýcý  olmak)";
                questionDisplay.newB = "B.Öykünüzü, yaþamýn akýþýný düþündüren bir doðallýkla yazýn, bunu yapabilecek güçlü  bir kaleminiz var. (yazarlýk yeteneði olmak)";
                questionDisplay.newC = "C.Öykünüzdeki bilinmeyenlerden kurtulmak için öyküdeki kadýnýn kim olduðunu, nasýl bir yaþam sürdüðünü, ne iþ yaptýðýný görünür kýlýn.  (belirginlik kazandýrmak)";
                questionDisplay.newD = "D.Sizin yaptýðýnýz gibi, bir dönemi küçük bir öyküye sýðdýrmak herkesin üstesinden gelebileceði bir iþ deðildir. (zorluðu yenmek)";
                questionDisplay.newE = "E.Öykünüzün kahramaný olan kadýný, içimizden  biri gibi gösterebilmiþsiniz. (inandýrýcý olmak)";
                trueAnswer = "A";
            }
            if (questNumber == 110)
            {

                questionDisplay.yeniSoru = "Þair  olarak  baþarýmý  ----  borçluyum  çünkü  ne  kadar çok sözcükten kurtulursam þiire o kadar çok yaklaþtýðýmý düþünürüm hep. Bu cümlede boþ býrakýlan yere düþüncenin akýþýna göre aþaðýdakilerden hangisi getirilmelidir?";
                questionDisplay.newA = "A.Ayný metni eklemelerle zenginleþtirmeme";
                questionDisplay.newB = "B.Aldýðým notlardan yararlanmama";
                questionDisplay.newC = "C.Hayal gücümün zenginliðine";
                questionDisplay.newD = "D.Ýþlediðim duygularýn çeþitliliðine";
                questionDisplay.newE = "E.Sahip olduklarýma deðil, vazgeçtiklerime";
                trueAnswer = "E";
            }
            if (questNumber == 111)
            {

                questionDisplay.yeniSoru = "Modayý sevmem. Herkesin ayný anda, ayný þeyleri giymesi, bana  nedense ters  gelir. Benim puslu, gözlerden uzak ve reklamý çok yapýlmamýþ olan hoþuma gider her zaman. Çünkü  yönlendirilmeyi  deðil, özgürce keþfetmeyi severim. Bilinçaltýma baský yapýlmasýný istemem. *Bu sözler aþaðýdaki sorulardan hangisine karþýlýk olarak söylenmiþ olabilir?*";
                questionDisplay.newA = "A.Popülist edebiyat ürünleri arasýnda romanýn yeri nedir?";
                questionDisplay.newB = "B.Anlattýklarýnýzý niçin kendi çocukluðunuzla sýnýrlandýrýyorsunuz?";
                questionDisplay.newC = "C.Yayýmlandýðýnda uzun süre gündemden düþmeyen bu romaný neden bu kadar geç okudunuz?";
                questionDisplay.newD = "D.Okurlarýnýz,romanlarýnýzdaki fantastik dokuyu nasýl karþýlýyor?";
                questionDisplay.newE = "E.Bir romanýn üst üste baský yapmasý, deðerli oldu- ðunu gösterir mi?";
                trueAnswer = "C";
            }
            if (questNumber == 112)
            {

                questionDisplay.yeniSoru = "Usta þairlerin þiir hakkýndaki yazýlarýný okumak, sadece onlarýn þiire iliþkin  görüþlerini  öðrenmemizi,  kendi þiirlerini anlamamýzý deðil, bir devrin þiir anlayýþýný sorgulamamýzý ve yapýlan tartýþmalarý deðerlendirebilmemizi de saðlar. *Bu cümlede aþaðýdakilerden hangisi yoktur?*";
                questionDisplay.newA = "A.Sýfatlaþtýran -ki";
                questionDisplay.newB = "B.Sürerlik fiil";
                questionDisplay.newC = "C.Ünlü düþmesi";
                questionDisplay.newD = "D.Dönüþlülük zamiri";
                questionDisplay.newE = "E.Baðlaç görevinde kullanýlmýþ “de”";
                trueAnswer = "B";
            }
            if (questNumber == 113)
            {

                questionDisplay.yeniSoru = "Doða, bitki örtüsünü ve tüm canlýlarý nasýl biçimlendiriyorsa benim þiirlerimi de etkilemiþ; bir ses, bir renk, bir koku, bir titreþim olarak þiirlerime girmiþtir. *Bu cümleyle ilgili olarak aþaðýda verilenlerden hangisi yanlýþtýr?*";
                questionDisplay.newA = "A.Ýyelik eki almýþ sözcükler yoktur";
                questionDisplay.newB = "B.Belgisiz sýfat kullanýlmýþtýr.";
                questionDisplay.newC = "C.Ek almamýþ sözcükler vardýr.";
                questionDisplay.newD = "D.Baðýmlý, sýralý bir cümledir.";
                questionDisplay.newE = "E.Yüklem, çatýsý bakýmýndan etkendir";
                trueAnswer = "A";
            }
            if (questNumber == 114)
            {

                questionDisplay.yeniSoru = "Bir  uðultu	baþlýyor söz daðarcýðýmda, sözcükler üþüþüyor  zihnime;  acýlý(I),  ezik,  buruk(II), yorgun(III),  çekingen, kýrgýn(IV), suçlayýcý, küskün…(V) *Numaralandýrýlmýþ sözcüklerin hangisinde ünsüz benzeþmesi vardýr?* ";
                questionDisplay.newA = "A.V";
                questionDisplay.newB = "B.IV";
                questionDisplay.newC = "C.I";
                questionDisplay.newD = "D.II";
                questionDisplay.newE = "E.III";
                trueAnswer = "A";
            }
            if (questNumber == 115)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde bir anlatým bozukluðu vardýr?";
                questionDisplay.newA = "A.Yarýyýl tatilinde yapýlacak olan Amasra gezisi ertelendi.";
                questionDisplay.newB = "B.Müjdeyi vermek için mutfaða, annesinin yanýna heyecanla koþtu.";
                questionDisplay.newC = "C.Diplomalarýný alacak  öðrenciler salona sýrayla giriþ yaptýlar";
                questionDisplay.newD = "D.Eski öðrencilerin de katýldýðý büyük bir toplantý düzenlediler";
                questionDisplay.newE = "E.Konuþmasýna baþlamadan önce dinleyicilere þöyle bir baktý";
                trueAnswer = "C";
            }
            if (questNumber == 116)
            {

                questionDisplay.yeniSoru = "Arkeogenetik, insanlýða dair geçmiþi moleküler genetik teknikler------araþtýran bir bilim dalý olarak tanýmlanabilir.Bazý temel konular üzerindeki çalýþmalar henüz sürmekteyse de hýzla bir------- bilim dalý hâline gelmiþtir. *Burada boþ býrakýlan yerlere aþaðýdakilerden hangileri sýrayla getirilmelidir?*";
                questionDisplay.newA = "A.Geliþtirerek-Sevilen";
                questionDisplay.newB = "B.Kullanarak-Geliþen";
                questionDisplay.newC = "C.Sayesinde-Benimsenen";
                questionDisplay.newD = "D.Yoluyla-Deðiþken";
                questionDisplay.newE = "E.Deneyerek-Bilinen";
                trueAnswer = "B";
            }
            if (questNumber == 117)
            {

                questionDisplay.yeniSoru = "Sýrf kendi için okuyan, gezen, eðlenen bir aydýn kendini yaþarken öldürmüyor mu? *Bu cümledeki ögelerin doðru sýralanýþý aþaðýdakilerden hangisinde verilmiþtir?*";
                questionDisplay.newA = "A.Özne - zarf tümleci - yüklem";
                questionDisplay.newB = "B.Zarf tümleci - belirtili nesne - yüklem";
                questionDisplay.newC = "C.Belirtisiz nesne - özne - zarf tümleci - yüklem";
                questionDisplay.newD = "D.Belirtisiz nesne - zarf tümleci - yüklem";
                questionDisplay.newE = "E.Özne - belirtili nesne - zarf tümleci - yüklem";
                trueAnswer = "E";
            }
            if (questNumber == 118)
            {

                questionDisplay.yeniSoru = "12.	Toprakla uðraþanlarý maddi açýdan desteklemek ülkemizin kalkýnmasýna önemli ölçüde katký saðlayacaktýr. *Bu cümlenin öznesi,aþaðýdaki sözcük gruplarýndan hangisinden oluþmuþtur?*";
                questionDisplay.newA = "A.Zarf-fiil grubu";
                questionDisplay.newB = "B.Ýsim-fiil grubu";
                questionDisplay.newC = "C.Sýfat tamlamasý";
                questionDisplay.newD = "D.Sýfat-fiil grubu";
                questionDisplay.newE = "E.Ýsim tamlamasý";
                trueAnswer = "B";
            }
            if (questNumber == 119)
            {

                questionDisplay.yeniSoru = "Aþaðýdakilerin hangisinde nesne, sadece isim tamlamasýndan oluþmuþtur?";
                questionDisplay.newA = "A.Dedem, ailenin en küçüðüne en güzel odayý vermiþti.";
                questionDisplay.newB = "B.Geçmiþ günlerin özlemi içimde her gün biraz daha büyüyordu";
                questionDisplay.newC = "C.Emekliye ayrýlýnca evinin bahçesi âdeta sýðýnaðý olmuþtu.";
                questionDisplay.newD = "D.Bunca yýlýn ardýndan sokak satýcýlarýnýn seslerini hâlâ";
                questionDisplay.newE = "E.Uzunca bir süre trenin penceresinden aðaçlarla kaplý köyleri seyretti";
                trueAnswer = "D";
            }
            if (questNumber == 120)
            {

                questionDisplay.yeniSoru = "Aþaðýdaki cümlelerin hangisinde kesme iþaretinin kullanýmýyla ilgili bir yanlýþlýk yapýlmýþtýr?";
                questionDisplay.newA = "A.Üniversitemizde tek ders sýnavlarýnýn 30 Haziran’da yapýlacaðý açýklandý.";
                questionDisplay.newB = "B.Ayþe Haným’dan gelen son mektubu ailecek sevinç içinde okuduk";
                questionDisplay.newC = "C.TDK'nin bir görevi de geçmiþte yazýlmýþ eserleri günümüze kazandýrmaktýr";
                questionDisplay.newD = "D.Pamukkale travertenleri, Denizli’mizin önde gelen turistik deðerlerindendir";
                questionDisplay.newE = "E.Bu yasa tasarýsý Bakanlar Kurulu’nda uzun uzun tartýþýldý.";
                trueAnswer = "E";
            }
            questionDisplay.updatePirs = false;
        }
    }
}
