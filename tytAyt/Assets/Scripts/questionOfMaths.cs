using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questionOfMaths : MonoBehaviour
{
    public static string trueAnswer;
    public static bool displayQue = false;
    public int questioNumber;

   
    void Update()
    {
        if (displayQue == false)
        {
            displayQue = true;
            questioNumber = Random.Range(1, 120);
            if (questioNumber == 1)
            {
                questionDisplay.yeniSoru = "Özellikle Orhan Veli Kanık ve arkadaşlarının şiirlerinde iç uyum, müzikalite ortadan kalkmış; kuru bir görselliğe dayanan bir şiir, hatta resim-şiir denilebilecek bir tür ortaya çıkmıştır. Oysa şiirde------müzikte olduğu kadar önemlidir. *Bu parçada boş bırakılan yere düşüncenin akışına göre ne getirilmelidir?*";
                questionDisplay.newA = "A.Tema ve imge";
                questionDisplay.newB = "B.Sözcük ve yoğunluk";
                questionDisplay.newC = "C.Duygu ve akıl";
                questionDisplay.newD = "D.Ses ve ahenk";
                questionDisplay.newE = "E.Sezgi ve anlam";
                trueAnswer = "D";
            }
            if (questioNumber == 2)
            {
                questionDisplay.yeniSoru = "Aşağıdaki cümlelerin hangisinde '-ıntı,-untu/-üntü' ekinin kullanıldığı sözcük, kökü bakımından diğerlerinden farklıdır?";
                questionDisplay.newA = "A.Kişi yersiz kuruntularından kurtulmak için dostlarına, arkadaşlarına daha fazla güvenmeli ve inanmalıdır";
                questionDisplay.newB = "B.İçi süprüntü dolu küreği merdivenlerin dibindeki çöp kutusuna boşaltmak için dışarı çıktı";
                questionDisplay.newC = "C.Bozuntuya vermeden yanına gittim ve olanları bütün çıplaklığıyla kendisine anlattım";
                questionDisplay.newD = "D.Kelimeyle kavram, dille düşünce arasındaki bağıntı üstüne yapılan tartışmalar eski çağlara kadar gider.";
                questionDisplay.newE = "E.Bu bölgede yapılan kazılarda arkeologlar, eski uygarlıklara ait yeni buluntulara rastladılar";
                trueAnswer = "D";
            }
            if (questioNumber == 3)
            {
                questionDisplay.yeniSoru = "Akşamlardan, gecelerden, senden uzağım / Şiirlerim rüzgârdır uzak dağlardan esen/ Durgun sular gibi azalacağım/Bir gün birdenbire çıkıp gelmesen       ****Bu dizelerde aşağıdakilerden hangisi yoktur?*";
                questionDisplay.newA = "A.Benzetme edatı";
                questionDisplay.newB = "B.Kişi eki";
                questionDisplay.newC = "C.İlgi eki";
                questionDisplay.newD = "D.İyelik eki";
                questionDisplay.newE = "E.Ek eylem";
                trueAnswer = "C";
            }
            if (questioNumber == 4)
            {
                questionDisplay.yeniSoru = "Göreve yeni başlayan Uğur; Mehmet, Engin ve Hatice gibi üniversite mezunuydu.    ***Aşağıdakilerden hangisinde noktalı virgül(;),bu cümledeki işleviyle kullanılmıştır?*";
                questionDisplay.newA = "A.Genç şairimiz; özgün, samimi ve doğal bir üslupla yazdığı şiirlerinden oluşan ilk kitabını yayımladı";
                questionDisplay.newB = "B.Aylar geçti, yıllar geçti; çocuklar büyüdü, insanlar değişti";
                questionDisplay.newC = "C.Geçen hafta şirket yetkilileriyle uzun uzun görüştük, tartıştık; bu hafta onlarla sözleşme, ödeme, nakliye gibi işlemleri gerçekleştireceğiz.";
                questionDisplay.newD = "D.İzlediğim filmler, tiyatrolar, gösteriler; okuduğum romanlar, hikâyeler, denemeler bende bir iz bırakır";
                questionDisplay.newE = "E.Bugün gelecek misafirleri 1, 2 ve 3. kattaki odalara; yarın gelecek misafirleri 4, 5 ve 6. kattaki odalara yerleştirelim";
                trueAnswer = "A";
            }
            if (questioNumber == 5)
            {
                questionDisplay.yeniSoru = " Servetifünun Dönemi bağımsız yazarlarındandır.  Roman ve öykülerinde ince bir mizah vardır.  Eserlerinde eski yeni çatışması, yüzeysel Batılılaşma ve aile geçimsizliklerini işlemiştir.        ***Aşağıdakilerden hangisi, bazı özellikleri verilen yazara ait eserlerden biridir?";
                questionDisplay.newA = "A.İstanbul'un İç Yüzü";
                questionDisplay.newB = "B.Çalıkuşu";
                questionDisplay.newC = "C.Şık";
                questionDisplay.newD = "D.Kırık Hayatlar";
                questionDisplay.newE = "E.Sözde Kızlar";
                trueAnswer = "C";
            }
            if (questioNumber == 6)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerden hangisi Haldun Taner’e ait tiyatro yapıtlarından biri değildir?";
                questionDisplay.newA = "A.Fazilet Eczanesi";
                questionDisplay.newB = "B.Toros Canavarı";
                questionDisplay.newC = "C.Zilli Zarife";
                questionDisplay.newD = "D.Eşşeğin Gölgesi";
                questionDisplay.newE = "E.Keşanlı Ali Destanı";
                trueAnswer = "B";
            }
            if (questioNumber == 7)
            {
                questionDisplay.yeniSoru = "Benim bu gidişe aklım ermiyor Fukara hâlini kimse sormuyor Padişah sikkesi selam vermiyor Kefensiz kalacak ölümüz bizim.       *Bu dörtlükle ilgili aşağıdakilerden hangisi yanlıştır?*";
                questionDisplay.newA = "A.Soyutlamaya yer verilmiştir";
                questionDisplay.newB = "B.Satirik nitelikler taşır";
                questionDisplay.newC = "C.Kafiye şeması “aaab” biçimindedir";
                questionDisplay.newD = "D.Duraklı 11’li hece ölçüsüyle yazılmıştır";
                questionDisplay.newE = "E.Yarım kafiye kullanılmıştır";
                trueAnswer = "A";
            }
            if (questioNumber == 8)
            {
                questionDisplay.yeniSoru = "Hasret çekerek uğruna ölmek de kolaydı, / Görmek seni eğer ukbâdan mümkün olaydı. / Hâlâ yaşıyor gizlenerek rûhuma “Kâbil”, / İmkânı bulunsaydı bütün ömre mukâbil / Sırretmeye elden seni bir perde olurdum.   **Bu dizelerde,aşağıdaki şiir türlerinden hangisine özgü nitelikler ağır basmaktadır?*";
                questionDisplay.newA = "A.Didaktik";
                questionDisplay.newB = "B.Lirik";
                questionDisplay.newC = "C.Epik";
                questionDisplay.newD = "D.Dramatik";
                questionDisplay.newE = "E.Pastoral";
                trueAnswer = "B";
            }
            if (questioNumber == 9)
            {
                questionDisplay.yeniSoru = "Şiirin en önemli unsurlarından biri de söz sanatlarıdır. Edebî sanatlar, dizelere çağrışım zenginliği ve çok boyutluluk katar.       ***Bu cümleye göre aşağıdakilerden hangisinin,çağrışım yönünden zengin olduğu söylenemez?*";
                questionDisplay.newA = "A.Güneşle beraber söndüğüm akşam / Ağlayacak hangi rüzgâr kim bilir";
                questionDisplay.newB = "B.Bir bahar sabahının karanlığında ıssız / Gökte diz çökmüş iki titrek ışıklı yıldız";
                questionDisplay.newC = "C.Kanı çekiliyor evlerin / Eriyip dökülüyor damlar";
                questionDisplay.newD = "D.Sonsuzlaşan yollara dalmış / Tasalı gözler olur camlar";
                questionDisplay.newE = "E.Mesut olmuş görmek isterdim hepinizi/Her bahar gününde dertliyi, ümitsizi";
                trueAnswer = "E";
            }
            if (questioNumber == 10)
            {
                questionDisplay.yeniSoru = "Her sanatçı önceleri başkalarını taklit eder. Fakat sonra gerek dünya görüşü gerekse sanat gücüyle kendine özgü bir üsluba kavuşur ve taklitten kurtulur.   ***Bu parçayı divan şairi açısından düşündüğümüzde aşağıdaki kavramlardan hangisi,divan şairinin 'taklit' dönemi için kullanılabilecek bir kavramdır?*";
                questionDisplay.newA = "A.Tercüme";
                questionDisplay.newB = "B.Nazire";
                questionDisplay.newC = "C.Haşiye";
                questionDisplay.newD = "D.Caize";
                questionDisplay.newE = "E.Şerh";
                trueAnswer = "B";
            }
            if (questioNumber == 11)
            {
                questionDisplay.yeniSoru = "Aşağıda ayraç içinde verilen terimlerden hangisi, birlikte verildiği açıklamaya uygun değildir?";
                questionDisplay.newA = "A.Özlü ve güzel anlamlı beyit (Taç beyit)";
                questionDisplay.newB = "B.Bir gazelin en güzel beyti (Şah beyit)";
                questionDisplay.newC = "C.Gazellerde şairin adının geçtiği beyit (Mahlas beyti)";
                questionDisplay.newD = "D.Uyaklı beyit (Musarra)";
                questionDisplay.newE = "E.Gazel ve kasidelerde ilk beyit (Matla)";
                trueAnswer = "A";
            }
            if (questioNumber == 12)
            {
                questionDisplay.yeniSoru = "I.Tez ve antitez şeklinde savunulabilecek bir konu belirlenir. II. En az üçer kişiden oluşan iki grup vardır.III. İkna edici bir üslup ve çarpıcı örnekler kullanılır. IV. Grup başkanları, konuşmacıların ardından söylenenleri özetler.    *Yukarıda özellikleri verilen sözlü anlatım türü aşağıdakilerden hangisidir?";
                questionDisplay.newA = "A.Forum";
                questionDisplay.newB = "B.Panel";
                questionDisplay.newC = "C.Münazara";
                questionDisplay.newD = "D.Açık Oturum";
                questionDisplay.newE = "E.Konferans";
                trueAnswer = "C";
            }
            if (questioNumber == 13)
            {
                questionDisplay.yeniSoru = "Aşağıdaki dizelerin hangisinde, ayraç içinde verilen sanat yoktur?";
                questionDisplay.newA = "A.Gerçek, hayali aştı, ufuklar uzak değil En olmaz isteklere uzanmak yasak değil (Tezat)";
                questionDisplay.newB = "B.Kuşlar küsmüş yuvaya, ağaçlar yaprak vermez Bu kavgalar bitecek, zulüm ebedî değil (Teşhis)";
                questionDisplay.newC = "C.Gül yaprağına döndü tekmesi düşmanların Sunulan zehir değil, saplanan bıçak değil (Teşbih)";
                questionDisplay.newD = "D.Dolu rüzgârla çıkıp ufka giden yelkenli Gidişin seçtiğin akşam saatinden belli (Hüsnütalil)";
                questionDisplay.newE = "E.Uçuyor rüzgâr gibi altımdaki küheylan Ne kadar dizginlesem yavaşlayacak değil(Mübalağa)";
                trueAnswer = "D";
            }
            if (questioNumber == 14)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerden hangisi, divan şiiriyle halk şiirinin birbirine yaklaştığının göstergelerinden biri değildir?";
                questionDisplay.newA = "A.Bazı halk şairlerinin divan tertip etmesi";
                questionDisplay.newB = "B.Benzer mazmunların kullanılması";
                questionDisplay.newC = "C.Gevherî’nin aruz vezniyle şiirler kaleme alması";
                questionDisplay.newD = "D.Nedim ve Şeyh Galip’in hece vezni ile şiir yazması";
                questionDisplay.newE = "E.Halk ve divan şairlerinin mahlas kullanması";
                trueAnswer = "E";
            }
            if (questioNumber == 15)
            {
                questionDisplay.yeniSoru = "I)Beng ü Bade    II)Leylâ vü Mecnun     III)Şikâyetname    IV)Rind ü Zahid    V)Şah u Geda     VI)Hadikatü’s - süeda        *Burada verilen eserlerden hangileri türü bakımından diğerlerinden farklıdır?*";
                questionDisplay.newA = "A.I ve II";
                questionDisplay.newB = "B.I ve VI";
                questionDisplay.newC = "C.III ve VI";
                questionDisplay.newD = "D.IV ve V";
                questionDisplay.newE = "E.V ve VI";
                trueAnswer = "C";
            }
            if (questioNumber == 16)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerin hangisinde bir bilgi yanlışı vardır?";
                questionDisplay.newA = "A.Divan sahibi olan Ahmedî’nin en iyi bilinen eserlerinden biri de İskender-name’dir";
                questionDisplay.newB = "B.Gülşehrî’nin Çeng-name adlı eseri, hem dil hem de üslup yönünden devrinin önemli eserlerinden biridir";
                questionDisplay.newC = "C.Şeyhî’nin başlıca edebî eserleri; Hüsrev ü Şirin, Divan ve Har-name’dir";
                questionDisplay.newD = "D.Garib-name adlı büyük mesnevisiyle tanınan Âşık Paşa, devrinin önemli düşünürlerinden biridir";
                questionDisplay.newE = "E.Türk edebiyatındaki ilk şairler tezkiresi, Ali Şir Nevayi’nin XV. yüzyılın sonlarına doğru Çağatay Türkçesiyle yazdığı Mecalisü’n-Nefais’tir";
                trueAnswer = "B";
            }
            if (questioNumber == 17)
            {
                questionDisplay.yeniSoru = "Aşağıdaki yargılardan hangisi, Tanzimat Dönemi öykü ve romanlarının özelliklerinden biri değildir?";
                questionDisplay.newA = "A.Genellikle saray ve çevresindeki insanların kural tanımaz tutum ve uygulamaları dile getirilmiştir";
                questionDisplay.newB = "B.Yüzyılın sonuna doğru köy, köylü sorunlarının konu olarak yer almaya başladığı görülür";
                questionDisplay.newC = "C.Karakterler; doğal bireyler olmaktan çok, yazarın çizdiği, genellikle insana özgü karşıtlıkları simgeleyen kişilerdir.";
                questionDisplay.newD = "D.Ahmet Mithat’ın Felâtun Bey ile Rakım Efendi adlı eseri ile Recaizade Mahmut Ekrem’in Araba Sevdası adlı eserlerinde benzer konular işlenmiştir";
                questionDisplay.newE = "E.Edebî değer taşıyan ilk roman Namık Kemal’in İntibah adlı eseridir";
                trueAnswer = "A";
            }
            if (questioNumber == 18)
            {
                questionDisplay.yeniSoru = "Şiirlerinde aşk ve tabiat öne çıkan önemli iki temadır. Türk şiirinin en dikkate değer empresyonist şairi olarak kabul edilir. 'Köylü vezni' dediği hece veznini kullanmamış, şiirlerini aruz vezniyle yazmıştır.Serbest müstezat, en çok tercih ettiği nazım biçimidir.      ***Aşağıdaki şiirlerden hangisi bu parçadasözü edilen şaire aittir?***";
                questionDisplay.newA = "A.Hürriyet Kasidesi";
                questionDisplay.newB = "B.Sis";
                questionDisplay.newC = "C.Kar Musikileri";
                questionDisplay.newD = "D.Makber";
                questionDisplay.newE = "E.O Belde";
                trueAnswer = "E";
            }
            if (questioNumber == 19)
            {
                questionDisplay.yeniSoru = "Âşık Veysel ile ilgili aşağıdaki bilgilerden hangisi yanlıştır?";
                questionDisplay.newA = "A.7 yaşında gözlerini yitirmesine rağmen şiirlerinde çiçekler; allı yeşilli, sarılı morlu renkler kol kola vermiştir";
                questionDisplay.newB = "B.Âşıklık geleneğinin son dönemde yetişen büyük ustalarındandır";
                questionDisplay.newC = "C.Şiirlerinde aşk, yurt ve toprak sevgisi, alışılagelen bir söyleyişten uzak bir duyarlılıkla dile gelir";
                questionDisplay.newD = "D.Kendisinden önceki şairler gibi zaman zaman aruzla da şiirler kaleme almıştır";
                questionDisplay.newE = "E.İç dünyasına çekilen şairin şiirlerinde insan önemli bir malzeme olarak yer alır";
                trueAnswer = "D";
            }
            if (questioNumber == 20)
            {
                questionDisplay.yeniSoru = "1961’li yıllardan sonra İslami söylem, taklit düzeyindeki Batılılaşma ile geleneksel hayatın ve bu hayata özgü değerler manzumesinin karşı karşıya getirilmesi şeklinde dikkati çeker. Çok Sesli Bir Ölüm, Çözülme adlı öykü kitapları olan----, bu hareketin öncü adlarından biridir.   ***Burada boş bırakılan yere aşağıdakilerden hangisi getirilir?*";
                questionDisplay.newA = "A.Adalet Ağaoğlu";
                questionDisplay.newB = "B.Samiha Ayverdi";
                questionDisplay.newC = "C.Yaşar Kemal";
                questionDisplay.newD = "D.Rasim Özdenören";
                questionDisplay.newE = "E.Mustafa Kutlu";
                trueAnswer = "D";
            }
            if (questioNumber == 21)
            {
                questionDisplay.yeniSoru = "Aşağıdaki eserlerden hangisi, türü yönüyle ötekilerden farklıdır?";
                questionDisplay.newA = "A.Kara Kitap";
                questionDisplay.newB = "B.Unutma Bahçesi";
                questionDisplay.newC = "C.Yağmur Kaçağı";
                questionDisplay.newD = "D.Kılavuz";
                questionDisplay.newE = "E.Ruh Üşümesi";
                trueAnswer = "C";
            }
            if (questioNumber == 22)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerin hangisinde bir bilgi yanlışı vardır?";
                questionDisplay.newA = "A.Haldun Taner, bütün öykü ve oyunlarında bazen aşırıya kaçarak şive, lehçe taklitleri yapar.";
                questionDisplay.newB = "B.Selim İleri, deneme ve hatıralarında bir düşünce adamı tavrını benimsemiştir.";
                questionDisplay.newC = "C.Bu Ülke, Cemil Meriç’in, aydın ve halkı birbirinden ayıran duvarları yıkmak amacıyla yazdığı denemelerinin yer aldığı bir kitaptır";
                questionDisplay.newD = "D.Özellikle roman ve öyküleriyle bilinen Fakir Baykurt’un en tanınan eserleri arasında Yılanların Öcü, Tırpan sayılabilir.";
                questionDisplay.newE = "E.Şiirleriyle tanınan Sevinç Çokum; Batı kültürüyle yetişmiş, denemeleri ve Fransızcadan çevirdiği kitaplarıyla da öne çıkmıştır";
                trueAnswer = "E";
            }
            if (questioNumber == 23)
            {
                questionDisplay.yeniSoru = "Zor zaman herkesi sınar, en çok da aydınları. Aydın insan toplumun öncüsüdür, yol göstericisidir. Öyle bilinir ve bu yüzden aydın sanatçılar, sorumluluğunun bilincinde olarak yazıp çizmeye, sorunlara çözüm yolları üretmeye çalışırlar.   ***Bu parçadaki görüşe göre aşağıdaki sanatçılardan hangisi bu yönde eser vermemiştir?*";
                questionDisplay.newA = "A.Nazım Hikmet";
                questionDisplay.newB = "B.Sabahattin Ali";
                questionDisplay.newC = "C.Orhan Veli Kanık";
                questionDisplay.newD = "D.Namık Kemal";
                questionDisplay.newE = "E.Mehmet Akif Ersoy";
                trueAnswer = "C";
            }
            if (questioNumber == 24)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerden hangisi, Batılılaşma sorununu belirli tipler çevresinde ele alan eserlerden biri değildir?";
                questionDisplay.newA = "A.Ömer Seyfettin-Efruz Bey";
                questionDisplay.newB = "B.Yaşar Kemal-Ağrıdağı Efsanesi";
                questionDisplay.newC = "C.Halid Ziya Uşaklıgil-Aşk-ı Memnu";
                questionDisplay.newD = "D.Hüseyin Rahmi Gürpınar-Şık";
                questionDisplay.newE = "E.Reşad Nuri Güntekin-Yaprak Dökümü";
                trueAnswer = "B";
            }
            if (questioNumber == 25)
            {
                questionDisplay.yeniSoru = "Yakup Kadri Karaosmanoğlu ile ilgili olarak aşağıda verilen bilgilerden hangisi yanlıştır?";
                questionDisplay.newA = "A.Sodom ve Gomore’de, Cumhuriyet’in kuruluşundan Demokrat Partinin iktidara geldiği zamana kadar geçen süreci anlatmıştır";
                questionDisplay.newB = "B.Yaban’da Kurtuluş Savaşı öncesi Türk aydını ile Türk köylüsü arasındaki derin uçurumu, romana has kurgu ile gözler önüne sermeye çalışmıştır";
                questionDisplay.newC = "C.Nur Baba’da gerçek kimliğinden uzaklaştırılan tekke hayatını, tekke şeyhinin (Nuri) yaşadıkları ile anlatmıştır.";
                questionDisplay.newD = "D.Hüküm Gecesi’nde İttihat ve Terakki yıllarını, gazeteci Ahmet Kerim’in yaşadıkları çevresinde anlatmıştır.";
                questionDisplay.newE = "E.Kiralık Konak’ta modernleşme sürecinde apartman ile konak hayatını, dede-torun arasındaki hayat tarzı ve zevk farklılığı çevresinde işlemiştir.";
                trueAnswer = "A";
            }
            if (questioNumber == 26)
            {
                questionDisplay.yeniSoru = "''Yaptığım tablolar, kişiye özeldir; belki aylarca askıda sessizce durur, ta ki sahibine kavuşana dek.” diyen bir ressam, sanat eserleriyle ilgili olarak aşağıdakilerden hangisine dikkat çekmektedir?";
                questionDisplay.newA = "A.Sanatçının yaşamından izler taşıdığına";
                questionDisplay.newB = "B.Belli bir birikim sonucunda oluştuğuna";
                questionDisplay.newC = "C.Öğretici bir yönünün bulunmadığına";
                questionDisplay.newD = "D.Herkesin dünyasına hitap etmediğine";
                questionDisplay.newE = "E.Hayal dünyamızı genişleten ürünler olduğuna";
                trueAnswer = "D";
            }
            if (questioNumber == 27)
            {
                questionDisplay.yeniSoru = "Aşağıda verilen dizelerin hangisindeki tire içindeki sözcük, türü bakımından diğerlerinden farklıdır?";
                questionDisplay.newA = "A.-Sarı- çiçek sallanıyor naz ile / Karışmış güllere çimenin dağlar";
                questionDisplay.newB = "B.-Ak- elleri elvan elvan kınalı / Karadır gözleri sürmeli değil";
                questionDisplay.newC = "C.-Yeşil- olur bizim ilin dağları / Dağlara çıkmanın zamanı şimdi";
                questionDisplay.newD = "D.Kıvrım kıvrım olmuş zülfünün teli / -Mor- menekşe boynun eğdiği gibi";
                questionDisplay.newE = "E.Çıktım seyreyledim Niğde’yi, Bor’u / Acep gezsem -ela- gözlüm var m’ola";
                trueAnswer = "C";
            }
            if (questioNumber == 28)
            {
                questionDisplay.yeniSoru = "Koca şehrin üstünde ipi kopmuş bir uçurtmayım; Rüzgârlara kayıyor göğsüm sarsıla sarsıla.  Koca şehrin üstünde ipi kopmuş bir uçurtmayım; Ki uçurtmuştu beni çocukluğum, hülyalarıyla.    **Bu dizelerde aşağıdaki ses olaylarından hangisi yoktur?*";
                questionDisplay.newA = "A.Ünlü daralması";
                questionDisplay.newB = "B.Ünsüz benzeşmesi";
                questionDisplay.newC = "C.Ünlü düşmesi";
                questionDisplay.newD = "D.Ünsüz yumuşaması";
                questionDisplay.newE = "E.Ulama";
                trueAnswer = "A";
            }
            if (questioNumber == 29)
            {
                questionDisplay.yeniSoru = "O gece, en derin gönül macerasına dalmış akranlarının bile gözlerine uğrayan uyku, onun gözlerine uğramamış; gözleri, karanlık odanın tavanında bir satranç tahtasına takılıp kalmış, kendi kendine bir hayal âlemine dalıp gitmişti.   **Bu cümlede aşağıda verilenlerden hangisi yoktur?*";
                questionDisplay.newA = "A.İşaret sıfatı";
                questionDisplay.newB = "B.Kişi zamiri";
                questionDisplay.newC = "C.Belgisiz zamir";
                questionDisplay.newD = "D.Sayı sıfatı";
                questionDisplay.newE = "E.Dönüşlülük zamiri";
                trueAnswer = "C";
            }
            if (questioNumber == 30)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerden hangisi, ögelerinin sıralanışı yönünden “Gözlerimi açtığımda saatim ve bozuk paralarım, baş ucumdaki komodinin üzerinde garip bir ölü doğa resmi gibi duruyordu.” cümlesiyle aynıdır?";
                questionDisplay.newA = "A.Geçen yıl yağan şiddetli yağmurda dizlerime kadar suya batmıştım";
                questionDisplay.newB = "B.Öğlen, arkadaşım bize gelince çocuklar gibi sevinmiştim";
                questionDisplay.newC = "C.Geçenlerde burada da ulaşımı engelleyecek derecede yoğun bir kar yağışı olmuştu";
                questionDisplay.newD = "D.Eve gelirken babam uzun zamandır görmediği bir arkadaşına rastlamıştı";
                questionDisplay.newE = "E.Sabah annemle ben evin yanındaki parkta bir iki saat yürümüştük";
                trueAnswer = "E";
            }
            if (questioNumber == 31)
            {
                questionDisplay.yeniSoru = "Hayır, hayâl ile yoktur benim alışverişim  İnan ki ne demiş isem görüp de söylemişim Şudur benim cihânda en beğendiğim meslek Sözüm odun gibi olsun hakikat olsun tek    ****Bu dizelerde dile getirilen düşünce, aşağıdaki edebi akımlardan hangisi ile ilişkilendirilebilir?*";
                questionDisplay.newA = "A.Romantizm";
                questionDisplay.newB = "B.Realizm";
                questionDisplay.newC = "C.Sembolizm";
                questionDisplay.newD = "D.Sürrealizm";
                questionDisplay.newE = "E.Klasisizm";
                trueAnswer = "B";
            }
            if (questioNumber == 32)
            {
                questionDisplay.yeniSoru = "I)İntibah – Ali Bey   II)Araba Sevdası – Bihruz Bey III)Mai ve Siyah – Ahmet Celâl   IV)Şıpsevdi-Aliye  V)Eylül-Necip               ***Numaralandırılmış roman-kahraman eşleştirmelerinden hangileri yanlıştır?";
                questionDisplay.newA = "A.I VE III";
                questionDisplay.newB = "B.II VE III";
                questionDisplay.newC = "C.II VE V";
                questionDisplay.newD = "D.III VE IV";
                questionDisplay.newE = "E.IV VE V";
                trueAnswer = "D";
            }
            if (questioNumber == 33)
            {
                questionDisplay.yeniSoru = "Edebiyatımızda bazı sanatçılar eserlerinde işledikleri konulara göre takma isimlerle anılır olmuştur. Masalcı Baba, Bayrak Şairi, Halikarnas Balıkçısı, Destan Şairi, Evler Şairi... bunlardan bazılarıdır.   ****Aşağıdakilerden hangisi,bu parçada takma isimleri geçen sanatçılardan biri değildir?*";
                questionDisplay.newA = "A.Arif Nihat Asya";
                questionDisplay.newB = "B.Eflatun Cem Güney";
                questionDisplay.newC = "C.Faruk Nafiz Çamlıbel";
                questionDisplay.newD = "D.Behçet Necatigil";
                questionDisplay.newE = "E.Cevat Şakir Kabaağaçlı";
                trueAnswer = "C";
            }
            if (questioNumber == 34)
            {
                questionDisplay.yeniSoru = "Artık ne rübâî ne semaî kaldı! / San’atta bir âvâre tedâî kaldı! / Her cephesi ma’mûr şiirden bugüne / Mazbût iki üç kalem, fedâi kaldı.   ***Bu şiirde,türk şiiriyle ilgili olarak aşağıdakilerden hangisinden yakınmaktadır?*";
                questionDisplay.newA = "A.Çağrışım unsurlarına yeteri kadar yer verilmemesinden";
                questionDisplay.newB = "B.Şair sayısındaki artışın şiir kalitesini düşürmesinden";
                questionDisplay.newC = "C.Yenilikçi yönünün ilgilenenleri yetkinliğe yönlendirememesinden";
                questionDisplay.newD = "D.Geleneksel Türk şiirine ilginin yeterli olmamasından";
                questionDisplay.newE = "E.Şiirin sadece belli mekanlarda gelişmesinden";
                trueAnswer = "D";
            }
            if (questioNumber == 35)
            {
                questionDisplay.yeniSoru = "(I) Gençlik gelip geçti bir günlük süstü Ömrüm doymamaktan dünyaya küstü Eser darmadağın emek yüzüstü Gidiyorum işim acele (II) İşim gücüm budur benim Gökyüzünü boyarım her sabah Uyanır bakarsınız ki mavi  ***Aşağıdakilerin hangisinde,numaralandırılmış bu şiirlerin temsil ettiği şiir anlayışları sırasıyla verilmiştir?*";
                questionDisplay.newA = "A.Mistik şiir – Garipçiler";
                questionDisplay.newB = "B.Yedi Meşaleciler – İkinci Yeni";
                questionDisplay.newC = "C.Mistik şiir – İkinci Yeni";
                questionDisplay.newD = "D.Yedi Meşaleciler – Toplumcu şiir";
                questionDisplay.newE = "E.İkinci Yeni – Garipçiler";
                trueAnswer = "A";
            }
            if (questioNumber == 36)
            {
                questionDisplay.yeniSoru = "----; gazellerinde gerçek aşkı, zevki ve eğlenceyi gerçekçi bir üslupla dile getirmiştir. O,------gibi üzüntü ve acılarını tasavvufi kavramlardan hareketle sembolik bir dille yansıtan yanık bir âşık değil neşeli bir kişiliktir.    ***Burada boş bırakılan yerlere sırasıyla aşağıdakilerden hangisi getirilmelidir?*";
                questionDisplay.newA = "A.Hoca Dehhani-Mevlana";
                questionDisplay.newB = "B.Nedim-Fuzuli";
                questionDisplay.newC = "C.Bâki-Hayalî";
                questionDisplay.newD = "D.Bağdadlı Ruhî-Şeyh Galip";
                questionDisplay.newE = "E.Zâtî-Şeyhülislam Yahya";
                trueAnswer = "B";
            }
            if (questioNumber == 37)
            {
                questionDisplay.yeniSoru = "Seni sevmek bana verse de çile Yılmadan çekerim yeter ki he de Senin gibi biten ender bir güle Gözyaşı dökerim yeter ki he de   ***Bu dörtlüğün nazım türü aşağıdakilerden hangisidir?**";
                questionDisplay.newA = "A.Taşlama";
                questionDisplay.newB = "B.Güzelleme";
                questionDisplay.newC = "C.Koçaklama";
                questionDisplay.newD = "D.Ağıt";
                questionDisplay.newE = "E.Destan";
                trueAnswer = "B";
            }
            if (questioNumber == 38)
            {
                questionDisplay.yeniSoru = "Türk edebiyatındaki en önemli temsilcisi Yunus Emre olan ilahi; Allah aşkını konu edinen, onu övmek için özel bir ezgiyle yazılıp söylenen, herhangi bir tarikat izi taşımayan şiirlerdir. Bu şiirler; söylendiği yere, kesime veya tarikata göre farklı isimler alır. ***Aşağıdakilerden hangisi bu isimlerden biri değildir?*";
                questionDisplay.newA = "A.Âyin";
                questionDisplay.newB = "B.Tapuğ";
                questionDisplay.newC = "C.Deme";
                questionDisplay.newD = "D.Nefes";
                questionDisplay.newE = "E.Devriye";
                trueAnswer = "E";
            }
            if (questioNumber == 39)
            {
                questionDisplay.yeniSoru = "Geleneksel Türk tiyatrosu ile ilgili olarak aşağıdaki yargılardan hangisi yanlıştır?";
                questionDisplay.newA = "A.Karagöz ve orta oyunundaki tüm tipler, tek bir kişi tarafından taklit yoluyla canlandırılır";
                questionDisplay.newB = "B.Türk seyircisi, Tanzimat’tan sonra dramatik türün Avrupai şekillerini tanımaya başlar.";
                questionDisplay.newC = "C.Karagöz ve orta oyununda Osmanlı Devleti sınırları içinde yaşayan farklı etnik zümrelerin şiveleri önemli rol oynar";
                questionDisplay.newD = "D.Karagöz ve orta oyununda, olayların akışı başlıca iki kişinin üzerindedir.";
                questionDisplay.newE = "E.Karagöz ve orta oyununda diyaloglar belli bir çerçeve doğrultusunda doğaçlama olarak gerçekleştirilir.";
                trueAnswer = "A";
            }
            if (questioNumber == 40)
            {
                questionDisplay.yeniSoru = "Bu şehirde sokaklar seni düşünür / Bu sokaklarda evler seninle dolu / Bu evlerde huzur bir şarkıdır söylediğin / Sen yürürken bir kilim dokunur kilometreler boyunca / Düşer kaldırımlara nakış nakış güzelliğin.    ***Bu dizelerle ilgili olarak aşağıdakilerden hangisi söylenemez?*";
                questionDisplay.newA = "A.Birinci dizede, insana ait bir özellik cansız bir varlığa nispet edilerek etkileyicilik sağlanmıştır";
                questionDisplay.newB = "B.İkinci dizede, “seninle” sözcüğündeki mecazımürselle sevgiliye ait kimi özellikler çağrıştırılmıştır";
                questionDisplay.newC = "C.Üçüncü dizede, “huzur” ile “şarkı” sözcükleri arasında bir tezatlık söz konusudur.";
                questionDisplay.newD = "D.Dördüncü dizede, sevgilinin güzelliği mübalağa yoluyla dile getirilmiştir.";
                questionDisplay.newE = "E.Beşinci dizede, güzellik istiare yoluyla somut bir nesne gibi düşünülmüştür.";
                trueAnswer = "C";
            }
            if (questioNumber == 41)
            {
                questionDisplay.yeniSoru = "Ya sen ey karınca taciri gazeteci / Ağzının içinde bir sap ebegümeci / Kaşlarında macera gözlerinde oyun / Şeytan gibi kaçan yollu bisikletinle / Yırtık çizmelerin kadife kasketinle / Getir o eski sevincini çocukluğun   ***Bu dizelerle ilgili olarak aşağıdakilerden hangisi yanlıştır?*";
                questionDisplay.newA = "A.13’lü hece ölçüsü ile yazılmıştır";
                questionDisplay.newB = "B.Benzetmeye başvurulmuştur";
                questionDisplay.newC = "C.Didaktik bir üslup kullanılmıştır";
                questionDisplay.newD = "D.Geçmişe özlem dile getirilmiştir";
                questionDisplay.newE = "E.Tasvirden yararlanılmıştır";
                trueAnswer = "C";
            }
            if (questioNumber == 42)
            {
                questionDisplay.yeniSoru = "Çukurova bayramlığın giyerken Çıplaklığın üzerinden soyarken Şubat ayı kış yelini kovarken Cennet dense sana yakışır dağlar (II)Tut atalar sözün kalbi selim ol Gönülden gönüle yol var demişler Gider yavuzluğu tab’ı halim ol Sarp sirke kabına zarar demişler. ***Aşağıdakilerden hangisi,numaralanmış dörtlüklerin ortak özelliklerinden biri değildir?* ";
                questionDisplay.newA = "A.Yarım kafiyenin kullanılması";
                questionDisplay.newB = "B.Redife yer verilmesi";
                questionDisplay.newC = "C.Hece vezniyle yazılması";
                questionDisplay.newD = "D.Söz sanatlarından faydalanılması";
                questionDisplay.newE = "E.Yalın bir söyleyiş tercih edilmesi";
                trueAnswer = "A";
            }
            if (questioNumber == 43)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerin hangisinde bir bilgi yanlışı vardır?";
                questionDisplay.newA = "A.Vüs’at O. Bener, ilk hikâye kitabı Dost’ta, küçük kentlerdeki sıradan insanların iç ve dış dünyasını anlatan yapıtlar ortaya koymuştur.";
                questionDisplay.newB = "B.Rasim Özdenören, kimi öykülerinde aile içi çatışmalara, çözülme ve dağılmalara yol açan etkenleri, onların dokusuna sindirerek anlatmıştır";
                questionDisplay.newC = "C.Ferit Edgü, Çığlık adlı hikâyesinde iç ses yöntemini kullanarak okurun kafasında birbirini çağrıştıran kimi sorular uyandırmaya çalışmıştır";
                questionDisplay.newD = "D.Füruzan, 1972’de Parasız Yatılı adlı hikâyesiyle Sait Faik Hikâye Ödülü’nü almıştır";
                questionDisplay.newE = "E.Nezihe Meriç, Bir Deli Ağaç’ta topladığı hikâyelerini aşk ve ölüm teması etrafında geliştirmeyi, hayatın güzelliklerini anlatmayı amaçlamıştır";
                trueAnswer = "E";
            }
            if (questioNumber == 44)
            {
                questionDisplay.yeniSoru = "Dikkat edilirse mutluluk tanımlanırken hazzın, haz tanımlanırken mutluluğun anlam alanından yararlanılır ama mutluluk hazzın bir gömlek üstüne konur. Zira gönlün hissedişi, zihinden önce gelir. Belki bu yüzden haz o anda gözler yumularak; mutluluk ise gözler açılarak -katmerlenir-. ****Paragrafta belirtilen sözcükle,mutluluk ve haz hakkında anlatılmak istenen durum aşağıdakilerden hangisidir?";
                questionDisplay.newA = "A.Ayrışma";
                questionDisplay.newB = "B.Dönüşme";
                questionDisplay.newC = "C.Donuklaşma";
                questionDisplay.newD = "D.Çoğalma";
                questionDisplay.newE = "E.Karışma";
                trueAnswer = "D";
            }
            if (questioNumber == 45)
            {
                questionDisplay.yeniSoru = "Aşağıdaki cümlelerden hangisi ayraç içinde verilen ifadeyle uyuşmaktadır?";
                questionDisplay.newA = "A.Ürgüp yakınlarında yöre halkının 'Üç Güzeller' adını verdiği peribacaları, gün boyu fotoğrafçıların akınına uğruyor. (Tanım)";
                questionDisplay.newB = "B.Bu topraklarda çok lezzetli ve çeşitli üzümler yetiştiğinden olsa gerek, yörenin her yerinde bağlara rastlıyoruz. (Tahmin)";
                questionDisplay.newC = "C.Bu yörede uzun yıllar varlığını sürdürmüş mağara evleri günümüzde güzel ve konforlu birer butik otele dönüştürülmüştür. (Nesnellik)";
                questionDisplay.newD = "D.Tarihî bir kalenin çevresine kurulan Uçhisar, ilkbahar aylarında mis kokulu, rengârenk çiçeklerle bezenir. (Karşılaştırma)";
                questionDisplay.newE = "E.Nevşehir'in yaşayan el sanatlarından biri geleneksel tezgâhlardaki dokuma halı ve kilim üretimidir. (Çıkarım)";
                trueAnswer = "B";
            }
            if (questioNumber == 46)
            {
                questionDisplay.yeniSoru = "Aşağıdaki yargılardan hangisi kişisel düşünce içermemektedir?";
                questionDisplay.newA = "A.Görevlinin sesini duyanlar yerinden ayrılıyor ve işaret edilen yere ilerliyor.";
                questionDisplay.newB = "B.Bu ülkede gördüğüm her kıyafet ve her hareket birbirine benziyor";
                questionDisplay.newC = "C.Meydandaki hareketlilik, hiç bitmeyecekmiş gibi hız kesmeden devam ediyor";
                questionDisplay.newD = "D.Şikâyetler de tıpkı eşyalar gibi, tekrarlandıkça eskimeye devam ediyor";
                questionDisplay.newE = "E.İnsanların elindeki bavullar, kendi yaşantılarına dair garip izler taşıyor.";
                trueAnswer = "A";
            }
            if (questioNumber == 47)
            {
                questionDisplay.yeniSoru = "Türkiye'nin ulu dağlarını, ıssız koylarını, göç dışında kimsenin ayak basmadığı sarp geçitlerini anlatan renkler; en az kendileri kadar etkileyici motif ve desenlerde yer yer boy gösteriyor.     ***Bu cümlede aşağıdaki ögelerden hangisi bulunmamaktadır?*";
                questionDisplay.newA = "A.Belirtili nesne";
                questionDisplay.newB = "B.Yüklem";
                questionDisplay.newC = "C.Zarf tümleci";
                questionDisplay.newD = "D.Özne";
                questionDisplay.newE = "E.Dolaylı tümleç";
                trueAnswer = "A";
            }
            if (questioNumber == 48)
            {
                questionDisplay.yeniSoru = "O büyük yazarları, onların yarattıkları kişiler yaşatıyor. Nitekim, ----yaşatan----.        ***Bu parçada boş bırakılan yerlere aşağıdakilerin hangisi getirilmez*";
                questionDisplay.newA = "A.Charles Dickens’ı – David Copperfield’dır";
                questionDisplay.newB = "B.Shakespeare’i – Hamlet’tir";
                questionDisplay.newC = "C.Cervantes’i – Don Kişot’tur";
                questionDisplay.newD = "D.Geothe’yi – Faust’tur";
                questionDisplay.newE = "E.Stendhal’ı – Anna Karenina’dır";
                trueAnswer = "E";
            }
            if (questioNumber == 49)
            {
                questionDisplay.yeniSoru = "Gözlerin gözlerime değince / Felaketim olurdu ağlardım / Beni sevmiyordun bilirdim Bir sevdiğin vardı duyardım / Çöp gibi bir oğlan, ipince / Hayırsızın biriydi fikrimce     **Bu dizelerde aşağıdaki ses olaylarından hangisi yoktur?**";
                questionDisplay.newA = "A.Ünsüz türemesi";
                questionDisplay.newB = "B.Ünlü daralması";
                questionDisplay.newC = "C.Ünsüz benzeşmesi";
                questionDisplay.newD = "D.Ünsüz yumuşaması";
                questionDisplay.newE = "E.Ünlü düşmesi";
                trueAnswer = "C";
            }
            if (questioNumber == 50)
            {
                questionDisplay.yeniSoru = "Aşağıdaki cümlelerin hangisinde büyük harflerin kullanımıyla ilgili bir yanlışlık yapılmıştır?";
                questionDisplay.newA = "A.Reşat Nuri'nin Gamsız'ın Ölümü adlı öyküsü, Bakanlığın ders kitaplarına girdi.";
                questionDisplay.newB = "B.Hicaz, Türk müziğinde en sevdiğim makamlardan biridir";
                questionDisplay.newC = "C.Çocukken gittiğim Uzungöl Beldesi, unutamadığım yerlerdendir.";
                questionDisplay.newD = "D.Homeros'un eşsiz eserlerinde Eski Yunan tanrıları ana kahramanlardır";
                questionDisplay.newE = "E.Osmanlı Devleti'nde Batılılaşma hamlesi Tanzimat Fermanı ile başlamıştır";
                trueAnswer = "C";
            }
            if (questioNumber == 51)
            {
                questionDisplay.yeniSoru = "Gelse celâlinden cefâ / Yahud cemâlinden vefâ / İkisi de cana safâ / Senden hem ol hoş bu hoş    ****Bu dörtlüğün nazım türü aşağıdakilerden hangisidir?*";
                questionDisplay.newA = "A.Nutuk";
                questionDisplay.newB = "B.Nefes";
                questionDisplay.newC = "C.Devriye";
                questionDisplay.newD = "D.Şathiye";
                questionDisplay.newE = "E.İlahi";
                trueAnswer = "E";
            }
            if (questioNumber == 52)
            {
                questionDisplay.yeniSoru = "Kutadgu Bilig ile ilgili olarak aşağıdakilerden hangisi söylenemez?";
                questionDisplay.newA = "A.Hem dörtlük hem de beyitlerden oluşmaktadır";
                questionDisplay.newB = "B.Yoğun Arapça ve Farsça kelimelerden dolayı dili ağırdır";
                questionDisplay.newC = "C.İçeriği bakımından nasihatname türüne girer";
                questionDisplay.newD = "D.Alegorik söyleyişe sahip didaktik bir metindir";
                questionDisplay.newE = "E.Geçiş Dönemi ürünleri arasında yer almaktadır";
                trueAnswer = "B";
            }
            if (questioNumber == 53)
            {
                questionDisplay.yeniSoru = "Kulak verdim dört bir yanı dinledim / Arkam sıra gıybet eden çoğimiş / Çok yaşayıp mihnet ile ölmeden / Az yaşayıp devran sürmek yeğ imiş   ****Bu dörtlükle ilgili aşağıdakilerden hangisi söylenemez?**";
                questionDisplay.newA = "A.Kişisel deneyimler anlatılmıştır";
                questionDisplay.newB = "B.Didaktik bir anlatıma yer verilmiştir";
                questionDisplay.newC = "C.'xaxa' şeklinde uyaklanmıştır";
                questionDisplay.newD = "D.Güzelleme türünde yazılmıştır";
                questionDisplay.newE = "E.11'li hece ölçüsüyle yazılmıştır";
                trueAnswer = "D";
            }
            if (questioNumber == 54)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerden hangisi Karagöz tipinin özelliklerinden biri değildir?";
                questionDisplay.newA = "A.Hacivat'ın söylediği bazı sözleri yanlış anlar";
                questionDisplay.newB = "B.Düşündüğünü söylemekten çekinmez";
                questionDisplay.newC = "C.Orta Oyunu'ndaki Kavuklu tipini hatırlatır";
                questionDisplay.newD = "D.Konuşmalarında özentili ve süslü bir dil kullanır";
                questionDisplay.newE = "E.Hacivat ile hemen her konuda zıt fikirlere sahiptir";
                trueAnswer = "D";
            }
            if (questioNumber == 55)
            {
                questionDisplay.yeniSoru = "Pencereden bakan dilber Güzelliğin bildirirsin Ak göğsünde lale sünbül Ağlayanı güldürürsün    Gerdan açık benlerin çok  Güzellikte menendin yok  Kaşların yay, kirpiğin ok  Vurduğunu öldürürsün   ***Bu dizelerle ilgili olarak aşağıdakilerden hangisi söylenemez?**";
                questionDisplay.newA = "A.Söz sanatına başvurulmuştur";
                questionDisplay.newB = "B.Anlatımda karşıtlıktan yararlanılmıştır";
                questionDisplay.newC = "C.8'li hece ölçüsüyle yazılmıştır";
                questionDisplay.newD = "D.Bir semaiden alınmıştır";
                questionDisplay.newE = "E.Şiirde, sevgiliye duyulan özlem işlenmiştir";
                trueAnswer = "E";
            }
            if (questioNumber == 56)
            {
                questionDisplay.yeniSoru = "-----gibi mesneviler, Divan edebiyatının manzum romanları gibi değerlendirilebilir.Divan şiirinin estetiği içinde, o şiirin sanat ve dünya görüşü ile yazılan bu aşk hikâyeleri, biçim bakımından bir şiir - hikâye değil, olsa olsa birer manzum roman niteliği gösterir.   ***Bu parçada boş bırakılan yere aşağıdakilerden hangisi getirilemez?*";
                questionDisplay.newA = "A.Şem u Pervane";
                questionDisplay.newB = "B.Ferhad u Şîrîn";
                questionDisplay.newC = "C.Sabr u Sebat";
                questionDisplay.newD = "D.Leyla u Mecnun";
                questionDisplay.newE = "E.Hüsn u Aşk";
                trueAnswer = "C";
            }
            if (questioNumber == 57)
            {
                questionDisplay.yeniSoru = "Divan şairleriyle ilgili aşağıda verilen bilgilerden hangisi yanlıştır?";
                questionDisplay.newA = "A.Bâkî, özellikle mesnevilerindeki imgesel anlatımla ön plana çıkmıştır";
                questionDisplay.newB = "B.Şeyh Galip, divan şiirinin son büyük temsilcisi olarak kabul edilir";
                questionDisplay.newC = "C.Taşlıcalı Yahya, 'Şehzâde Mustafa Mersiyesi' ile şöhret kazanmıştır";
                questionDisplay.newD = "D.XVII. yüzyıl şairlerinden Nâbî, hikemî tarzın öncüleri arasındadır";
                questionDisplay.newE = "E.Nefî, övgü ve yergide Türk edebiyatının en büyük şairlerinden biri sayılır";
                trueAnswer = "A";
            }
            if (questioNumber == 58)
            {
                questionDisplay.yeniSoru = "Aşağıdaki dizelerin hangisinde, ayraç içinde verilen edebî sanat yoktur?";
                questionDisplay.newA = "A.Nihayetsiz bir ova ağarttı benzimizi /Yollar bir şerit gibi ufka bağladı bizi. (Teşbih)";
                questionDisplay.newB = "B.Ölümü hatırlatan ne var bu resimde? / Hâlbuki hayattayız hepimiz. (Tezat)";
                questionDisplay.newC = "C.Zeybek, sendeliyorsun! O ne? / Soluyor benzin Yere, eskisi gibi, hızlı vurmuyor dizin. (Telmih)";
                questionDisplay.newD = "D.Dal bir gün dedi ki tomurcuğuna: Tenimde bir yara işler gibisin. (İntak)";
                questionDisplay.newE = "E.Ellerim takılırken rüzgârların saçına / Asıldı arabamız bir dağın yamacına. (Teşhis)";
                trueAnswer = "C";
            }
            if (questioNumber == 59)
            {
                questionDisplay.yeniSoru = "Halka halka kâkülünden dağ dağ oldu gönül Hoş gelip divanelik dağ üstü bağ oldu gönül     ***Bu beyitteki uyak türü,aşağıdakilerden hangisiyle aynıdır?**";
                questionDisplay.newA = "A.Rüzgârla titrerken karanlık çamlar / Yâdında canlanır eski akşamlar";
                questionDisplay.newB = "B.Gün olur sürüyüp beni derbeder / Bu ses rüzgârlara karışır gider";
                questionDisplay.newC = "C.Ne hoştur kırlarda yazın uyumak / Bulutlar ufukta beyaz bir yumak";
                questionDisplay.newD = "D.D)	Çok sürse ayrılık aradan geçse çok sene / Biz sende olmasak bile, sen bizdesin gene";
                questionDisplay.newE = "E.Bu ıslıkla uzayan, dönen kıvrılan yollar / Uykuya varmış gibi görünen yılan yollar";
                trueAnswer = "A";
            }
            if (questioNumber == 60)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerin hangisinde bir bilgi yanlışı vardır?";
                questionDisplay.newA = "A.Fazıl Hüsnü Dağlarca, çok kolay ve rahat yazabilen, Cumhuriyet Dönemi Türk şiirinin en uzun soluklu şairidir";
                questionDisplay.newB = "B.Orhan Kemal, Çukurova yöresinin ve o yöredeki çaresiz insanların sorunlarını Ortadirek, Yer Demir Gök Bakır gibi romanlarında ele almıştır.";
                questionDisplay.newC = "C.Behçet Necatigil’in Bile/Yazdı, Evler ve Eski Toprak kitaplarındaki şiirlerinde, eski ve yeniyle biçim ve tema arasındaki uyum kendisini açıkça gösterir.";
                questionDisplay.newD = "D.Cahit Külebi’nin şiir kitapları arasında Adamın Biri’ ni, Türk Mavisi’ni, Sıkıntı’yı ve Umut’u sayabiliriz.";
                questionDisplay.newE = "E.Necati Cumalı’nın ilk romanı Tütün Zamanı; Yağ- murlar ve Topraklar, Acı Tütün ile devam eden Ege üçlemesinin ilk halkasıdır.";
                trueAnswer = "B";
            }
            if (questioNumber == 61)
            {
                questionDisplay.yeniSoru = "'Her akşam güneşin battığı yerden / Gözlerin doğuyor gecelerime' dizelerinde 'gözler' ay gibi düşünülmüş fakat 'ay' söylenmeden onu çağrıştıran 'doğmak' sözcüğü kullanılmıştır. Dolayısıyla bu dizelerde ---- sanatı yapılmıştır.    ***Bu parçada boş bırakılan yere aşağıdakilerden hangisi getirilmelidir?**";
                questionDisplay.newA = "A.İstiare";
                questionDisplay.newB = "B.Tevriye";
                questionDisplay.newC = "C.Teşbih";
                questionDisplay.newD = "D.Mecazımürsel";
                questionDisplay.newE = "E.Tezat";
                trueAnswer = "A";
            }
            if (questioNumber == 62)
            {
                questionDisplay.yeniSoru = "'Altındağ','Galata Köprüsü', 'Pireli Şiir','Delikli Şiir' ve 'İstanbul Türküsü' gibi şiirlerinde egemen olan yaklaşım, toplumsal duyarlıktır. Şair, bu şiirlerinde halk şiirimizin imkânlarından da yararlanmıştır. Ayrıca bu şiirlerin bazılarında ince eleştiri ve taşlama ögeleri de dikkat çekmektedir.    ***Bu parçada sözü edilen şair aşağıdakilerden hangisidir?*";
                questionDisplay.newA = "A.Orhan Veli Kanık";
                questionDisplay.newB = "B.Cahit Sıtkı Tarancı";
                questionDisplay.newC = "C.Oktay Rıfat Horozcu";
                questionDisplay.newD = "D.Bedri Rahmi Eyüboğlu";
                questionDisplay.newE = "E.Ziya Osman Saba";
                trueAnswer = "A";
            }
            if (questioNumber == 63)
            {
                questionDisplay.yeniSoru = "Kapı çalınıyor. Kim geldi acaba? Kimi istersem, kimin ismini yazarsam o gelir. Yazmanın bu yararı var işte, küçük bir işaretle, canımın istediğini getiririm. İstersem fikrimi değiştiririm. Kim ne yapabilir? Hadi bakalım, kapının zili çalmadı, gelen giden yok    ***Bu parçada postmodern romanın aşağıdaki hangi özelliği vurgulanmaktadır?**";
                questionDisplay.newA = "A.Okuru, kurmacanın merkezine yerleştirme";
                questionDisplay.newB = "B.Tarihî gerçekliği yeniden oluşturma";
                questionDisplay.newC = "C.Anlatıcıyı kurmacanın parçası kılma";
                questionDisplay.newD = "D.Çok katmanlı bir anlatı yapısı kurma";
                questionDisplay.newE = "E.Metinlerarası ilişkilere yer verme";
                trueAnswer = "C";
            }
            if (questioNumber == 64)
            {
                questionDisplay.yeniSoru = "Tam bir kaside çeşitli bölümlerden oluşur. Bunlardan biri, ----.             ***Burda verilen bilgiye göre boş bırakılan yere aşağıdakilerden hangisi getirilemez?**";
                questionDisplay.newA = "A.doğa güzelliklerinden söz eden nesib ya da teşbib bölümüdür";
                questionDisplay.newB = "B.şairin kendisini övdüğü dizelerden oluşan fahriye bölümüdür";
                questionDisplay.newC = "C.kasidenin sunulduğu kişinin özelliklerinin abartılı bir övgüyle anlatıldığı methiye bölümüdür";
                questionDisplay.newD = "D.asıl konuya girişi sağlamak için yazılan girizgâh bölümüdür";
                questionDisplay.newE = "E.şairin adının da geçtiği tegazzül bölümüdür";
                trueAnswer = "E";
            }
            if (questioNumber == 65)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerin hangisinde verilen dizelerde uyak(kafiye) kullanılmamıştır?";
                questionDisplay.newA = "A.Öpe öpe uyandırdım, şiir yaptım sözcükleri / Savaşta kalemime kurşun yaptım sözcükleri";
                questionDisplay.newB = "B.Selam olsun karanfilin alına / Selam, tomurcuklu defne dalına";
                questionDisplay.newC = "C.Değirmen değirmen, beni de öğüt / Ben meyvesiz ağaç, yürüyen söğüt";
                questionDisplay.newD = "D.Bu bohça, duygunun coşkun selidir / İçimi coşturan bahar yelidir";
                questionDisplay.newE = "E.O gün gelsin şöyle bir yarış olsun da gör / Dünyayı hele sen bir barış olsun da gör";
                trueAnswer = "A";
            }
            if (questioNumber == 66)
            {
                questionDisplay.yeniSoru = "Günümüzde yapılan yeni araştırmalar, gözlemler sonunda eğitim anlayışı da değişmiştir.   ***Değişimin anlatıldığı bir parçadan alınan aşağıdaki cümlelerin hangisiyle,ayraç içinde verilenler arasında anlamca ilişki yoktur?*";
                questionDisplay.newA = "A.“Yaşam boyu öğrenmenin gerekliliği”ni öğretir. (Bilgi edinme sürecini sınırlamama)";
                questionDisplay.newB = "B.Bilgiyi ve deneyimleri somut, gerçek örneklere bağlayarak aktarır. (Bilinenleri hayatla ilişki kurarak gösterme)";
                questionDisplay.newC = "C.“Ne biliyorsun?” yerine “Daha neleri bilmek istersin?” diye sorar. (Yeni bilgiler kazandırma)";
                questionDisplay.newD = "D.Kalıplaşmış programlardan farklı olarak öğrencilerin gereksinimlerini, ilgi alanlarını olabildiğince öne çıkaran bir yol izler. (Bireysel özellikleri önemseme)";
                questionDisplay.newE = "E.Çağın gereklerine uygun bir donanım ister. (Söylenenleri düşünmeden, olduğu gibi benimseme)";
                trueAnswer = "E";
            }
            if (questioNumber == 67)
            {
                questionDisplay.yeniSoru = "Şinasi’nin, edebiyatımızda gerçekleştirdikleri arasında aşağıdakilerden hangisi yoktur?";
                questionDisplay.newA = "A.Halk için roman yazma hareketini başlatmıştır";
                questionDisplay.newB = "B.İlk tiyatro yapıtını yazmıştır";
                questionDisplay.newC = "C.Dilde sadeleşme hareketine öncülük etmiştir";
                questionDisplay.newD = "D.La Fontaine’den çeviriler yapmıştır.";
                questionDisplay.newE = "E.İlk özel gazeteyi çıkarmıştır";
                trueAnswer = "A";
            }
            if (questioNumber == 68)
            {
                questionDisplay.yeniSoru = "Gülün Adı yayımlandıktan sonra, romanı sinemaya uyarlamak isteyen yönetmen, “Kitabınızı, film senaryosu olmaya uygun biçimde yazmışsınız çünkü diyalogları tam istenen uzunlukta tutmuşsunuz.” dedi.  ***Bu cümleyle ilgili olarak aşağıda verilenlerden hangisi yanlıştır?*";
                questionDisplay.newA = "A.Olumlu ve kurallı bir cümledir";
                questionDisplay.newB = "B.Yalnızca çekim eki almış birden fazla sözcüğe yer verilmiştir.";
                questionDisplay.newC = "C.Özne, bir tamlama öbeğinden oluşmaktadır";
                questionDisplay.newD = "D.Geniş zamanla çekimlenmiş fiil vardır.";
                questionDisplay.newE = "E.Yüklemi, çatısı bakımından etkendir";
                trueAnswer = "D";
            }
            if (questioNumber == 69)
            {
                questionDisplay.yeniSoru = "Fielding’in, Tom Jones’u yazmadaki amacı, kahramanların iç dünyalarının derinliklerine inmek ya da çelişkilerini yansıtmak değil, geleneklerin koşullandırdığı kalıplaşmış davranışları ele alarak tüm toplumu anlatan, güldürü ögelerinin ağır bastığı bir roman ortaya koymaktır.   ***Bu cümlede aşağıdakilerden hangisi yoktur?**";
                questionDisplay.newA = "A.Sıfatlaştıran -ki";
                questionDisplay.newB = "B.Bağlaç";
                questionDisplay.newC = "C.İlgi zamiri";
                questionDisplay.newD = "D.Belgisiz sıfat";
                questionDisplay.newE = "E.Zarf-fiil";
                trueAnswer = "C";
            }
            if (questioNumber == 70)
            {
                questionDisplay.yeniSoru = "Mudurnu, Abant’ın merkezine(I) 18 km(II) mesafede ve Arnavut kaldırımlı(III) sokakları, eski evleri, köprüleriyle çok çekici. Çarşısında Ahilik geleneği yaşatılıyor ve her Cuma(IV) tören yapılıyor. Ayrıca buradaki tarihî  yapıları da(V) seyretmeye doyum olmuyor. ***Burda numaralanmış sözlerden hangisinin yazımı yanlıştır?**";
                questionDisplay.newA = "A.I";
                questionDisplay.newB = "B.II";
                questionDisplay.newC = "C.III";
                questionDisplay.newD = "D.IV";
                questionDisplay.newE = "E.V";
                trueAnswer = "D";
            }
            if (questioNumber == 71)
            {
                questionDisplay.yeniSoru = "Evin, binbir çeşit meyve ağacı ve sebze yetiştiren bir bahçesi var.   ***Bu cümledeki anlatım bozukluğu aşağıdakilerin hangisinden kaynaklanmaktadır?**";
                questionDisplay.newA = "A.Dolaylı tümleç eksikliğinden";
                questionDisplay.newB = "B.Özne eksikliğinden";
                questionDisplay.newC = "C.Ek fiil kullanılmamasından";
                questionDisplay.newD = "D.Bağlaç kullanılmasından";
                questionDisplay.newE = "E.Fiilimsinin edilgen olmamasından";
                trueAnswer = "E";
            }
            if (questioNumber == 72)
            {
                questionDisplay.yeniSoru = "Masmavi suları, dipdiri palamudu, lüferi ve levreği olan bir ülkede, elbet deniz de Orhan Veli gibi bir şair de çıkacak karşına; sakın şaşırma! Üç yanı denizle çevrili bu ülkede, şaşıracaksan sandalla denize açılıp da oltayla balık tutma zevkini tatmamış birini görünce şaşır.    ***Bu parçanın anlatımıyla ilgili olarak aşağıdakilerden hangisi söylenemez?**";
                questionDisplay.newA = "A.Eksiltili cümle kullanılmıştır.";
                questionDisplay.newB = "B.Senli benli bir havası vardır";
                questionDisplay.newC = "C.Sayıp dökmelerden yararlanılmıştır";
                questionDisplay.newD = "D.Pekiştirmeli sözcüklere yer verilmiştir";
                questionDisplay.newE = "E.Öznellik söz konusudur";
                trueAnswer = "A";
            }
            if (questioNumber == 73)
            {
                questionDisplay.yeniSoru = "Aşağıdaki açıklamalardan hangisi ayraç içinde belirtilen kişiyle ilgili değildir?";
                questionDisplay.newA = "A.Risaletü’n-Nushiye adlı mesneviyi aruz ölçüsüyle yazmıştır. (Yunus Emre)";
                questionDisplay.newB = "B.Türkçenin başarılı örneklerinden olan Mantıku’t-Tayr ile Feleknâme onun tarafından oluşturulmuştur. (Ali Şir Nevaî)";
                questionDisplay.newC = "C.Sade bir dille, ölçülü ve uyaklı, halk şiiri geleneğine uygun nefesler yazmıştır. (Pir Sultan Abdal)";
                questionDisplay.newD = "D.Yapıtlarında aşk ve kahramanlık temalarının yanında tasavvufa da yer vermiştir. (Kadı Burhaneddin)";
                questionDisplay.newE = "E.Makalât adlı yapıtında tasavvuf konularını bölümler hâlinde ele almıştır. (Hacı Bektaş Veli)";
                trueAnswer = "B";
            }
            if (questioNumber == 74)
            {
                questionDisplay.yeniSoru = "Aşağıdaki açıklamalardan hangisi ayraç içinde verilen kavramla uyuşmamaktadır?";
                questionDisplay.newA = "A.Yazarların; olayları açıklamak, kahramanın kimliğine açıklık getirmek veya bir problemi çözmek için, anlattıklarının şimdiki zamanından ayrılarak geçmişe gitmesi. (Geriye Dönüş)";
                questionDisplay.newB = "B.Yazarın, kahramanların akıllarından geçeni, içlerinden geçirdiklerini, onların kendi kendileriyle konuşması biçiminde yansıtması. (Diyalog)";
                questionDisplay.newC = "C.Gerçekliğin farklı alanlarından alınan çeşitli parçaların, doğrudan doğruya, “biçimci” görüşlere uygun olarak birleştirilmesi. (Kurgu)";
                questionDisplay.newD = "D.İç konuşmadaki düzenli mantık silsilesinden çıkılarak kahramanın düşüncelerinin art arda ve düzensiz bir biçimde verildiği teknik. (Bilinç Akışı)";
                questionDisplay.newE = "E.Bir yazarın, başka bir yazarın metninden aldığı parçaları kendi metninin içinde eriterek yeniden yazması. (Metinler Arasılık)";
                trueAnswer = "B";
            }
            if (questioNumber == 75)
            {
                questionDisplay.yeniSoru = "I)DEMİR       II)Altın Yay        III)IŞIK      IV)AĞAÇ      **Burdaki mitolojik ögelerden Türk destanlarında yer alanlar aşağıdakilerin hangisinde birlikte verilmiştir?*";
                questionDisplay.newA = "A.I ve II";
                questionDisplay.newB = "B.I ve IV";
                questionDisplay.newC = "C.I ve II";
                questionDisplay.newD = "D.I,II ve IV";
                questionDisplay.newE = "E.I,II,III ve IV";
                trueAnswer = "E";
            }
            if (questioNumber == 76)
            {
                questionDisplay.yeniSoru = "Aşağıdaki dizelerden hangisinin ötekilerden farklı bir gelenek içinde yazıldığı düşünülebilir?";
                questionDisplay.newA = "A.Şimdi çocukluğun çatısı kalktı ya üstümüzden / Yağmurun da eski tadı yok bu yüzden";
                questionDisplay.newB = "B.Sen benim üstüne titrediğim güzel ve yeni / Saatim kadar saadetimin göz bebeği zamansın";
                questionDisplay.newC = "C.Bir uykuyu cananla beraber uyuyanlar / Ömrün bütün ikbalini vuslatta duyanlar";
                questionDisplay.newD = "D.O gün gelsin neşemiz tazelensin de gör / Dünyayı hele sen bir barış olsun da gör";
                questionDisplay.newE = "E.Ellerin var beyaz güller gibi küçücük / Mutlak kalbin tomurcuklardan pembe";
                trueAnswer = "C";
            }
            if (questioNumber == 77)
            {
                questionDisplay.yeniSoru = "Kendi hüsnünden utanmış da kızarmış yanağı / Yüzün örtüp kapamış saçları baştan aşağı    ****Bu dizelerde yer verilen sanat aşağıdakilerden hangisidir?*";
                questionDisplay.newA = "A.Hüsnütalil";
                questionDisplay.newB = "B.Mecazımürsel";
                questionDisplay.newC = "C.Cinas";
                questionDisplay.newD = "D.Tevriye";
                questionDisplay.newE = "E.Tezat";
                trueAnswer = "A";
            }
            if (questioNumber == 78)
            {
                questionDisplay.yeniSoru = "Her şey yerli yerinde; masa, sürahi, bardak / Serpilen aydınlıkta dalların arasından / Büyülenmiş bir ceylan gibi bakıyor zaman / Sessizlik dökülüyor bir yerde yaprak yaprak       ***Dörtlükle ilgili olarak aşağıdakilerden hangisi söylenemez?*";
                questionDisplay.newA = "A.Sözcüklerin çağrışım gücünden yararlanılmıştır";
                questionDisplay.newB = "B.Sarma uyak kullanılmıştır";
                questionDisplay.newC = "C.Somutlamaya başvurulmuştur";
                questionDisplay.newD = "D.Redif vardır";
                questionDisplay.newE = "E.Hece ölçüsüyle yazılmıştır";
                trueAnswer = "D";
            }
            if (questioNumber == 79)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerden hangisi, Kutadgu Bilig’de yer alan kişi ve onun temsil ettiği kavramlar arasında değildir?";
                questionDisplay.newA = "A.Kün Togdı ─ Kanun";
                questionDisplay.newB = "B.Ay Toldı ─ Saadet";
                questionDisplay.newC = "C.Alp Er Tunga ─ Doğruluk";
                questionDisplay.newD = "D.Odgurmış ─ Akıbet";
                questionDisplay.newE = "E.Ögdülmiş ─ Akıl";
                trueAnswer = "C";
            }
            if (questioNumber == 80)
            {
                questionDisplay.yeniSoru = "Gazete, aşağıdaki türlerin hangisinin gelişiminde etkili olmamıştır?";
                questionDisplay.newA = "A.Makale";
                questionDisplay.newB = "B.Röportaj";
                questionDisplay.newC = "C.Günlük";
                questionDisplay.newD = "D.Fıkra";
                questionDisplay.newE = "E.Deneme";
                trueAnswer = "C";
            }
            if (questioNumber == 81)
            {
                questionDisplay.yeniSoru = "Günümüzün şiiri ve bu arada benim şiirim, sözcüğün sınırlarını genişleten bir şiir… Genç kuşakla yeni bir anlatım dönemine girdik. Yeni şairler şiirin araçlarını yalnızca kullanmıyorlar, aynı zamanda o araçlarla özellikle de sözcüklerle oynuyorlar.     ***Aşağıdakilerin hangisi,bu cümleleri kuran şaire ait olamaz?**";
                questionDisplay.newA = "A.Bir beyaz gemiydi ayıran onları Kadın güvertedeydi adam rıhtımda";
                questionDisplay.newB = "B.Bilinir ne usta olduğum içlenmek zanaatında Canımla besliyorum şu hüznün kuşlarını";
                questionDisplay.newC = "C.Şimdi bir güvercinin uçuşunu bölüşüyoruz Gökyüzünün o meşhur maviliğinde";
                questionDisplay.newD = "D.Gülün tam ortasında ağlıyorum Her akşam sokak ortasında öldükçe";
                questionDisplay.newE = "E.Şu senin bulutsu sesin var ya Uçtan uca ters yüz ediyor geceyi";
                trueAnswer = "A";
            }
            if (questioNumber == 82)
            {
                questionDisplay.yeniSoru = "(I)Orta oyunu    (II)Meddah      (III)Trajedi        (IV)Destan          (V)Komedi        ***Bunlardan hangileri geleneksel türk anlatıları arasında yer alan türlerden değildir?*";
                questionDisplay.newA = "A.I ve II";
                questionDisplay.newB = "B.I ve III";
                questionDisplay.newC = "C.II ve III";
                questionDisplay.newD = "D.III ve V";
                questionDisplay.newE = "E.IV ve V";
                trueAnswer = "D";
            }
            if (questioNumber == 83)
            {
                questionDisplay.yeniSoru = "Karagöz oyunuyla ilgili olarak aşağıda verilenlerden hangisi yanlıştır?";
                questionDisplay.newA = "A.Tuzsuz Deli Bekir; zengin, mirasyedi, çıtkırıldım bir tiptir ve İstanbul ağzıyla konuşur.";
                questionDisplay.newB = "B.Yardak, Karagözcünün isteği doğrultusunda, perde gazelleri, şarkılar, türküler okur, tef çalar";
                questionDisplay.newC = "C.Çelebi, Frenk ve Zenne önemli tipler arasında yer alır.";
                questionDisplay.newD = "D.Giriş, muhavere, fasıl ve bitiş olmak üzere dört bölümü vardır.";
                questionDisplay.newE = "E.Kastamonulu, Rumelili, Bolulu gibi İstanbul’a iş aramaya gelmiş veya meslek edinmiş, yerleşmiş taşralı Türk tipleri vardır.";
                trueAnswer = "A";
            }
            if (questioNumber == 84)
            {
                questionDisplay.yeniSoru = "Divan edebiyatı sanatçıları ve yaşadığı yüzyıllarla ilgili olarak aşağıdakilerden hangisi yanlıştır?";
                questionDisplay.newA = "A.Sultan Veled-13.yüzyıl";
                questionDisplay.newB = "B.Fuzulî-16.yüzyıl";
                questionDisplay.newC = "C.Âşık Paşa-14.yüzyıl";
                questionDisplay.newD = "D.Şeyhî-15.yüzyıl";
                questionDisplay.newE = "E.Nedîm-17.yüzyıl";
                trueAnswer = "E";
            }
            if (questioNumber == 85)
            {
                questionDisplay.yeniSoru = "Bir kişiyi, bir durumu veya olayı yermeye, toplumun aksayan yönlerini göstermeye yönelik şiirler yazan Nef’i, aşağıdaki şiir türlerinin hangisiyle ilişkilendirilebilir?";
                questionDisplay.newA = "A.Lirik";
                questionDisplay.newB = "B.Satirik";
                questionDisplay.newC = "C.Pastoral";
                questionDisplay.newD = "D.Didaktik";
                questionDisplay.newE = "E.Epik";
                trueAnswer = "B";
            }
            if (questioNumber == 86)
            {
                questionDisplay.yeniSoru = "İslamiyet’in kabulünden önceki Türk edebiyatıyla ilgili aşağıdaki yargıların hangisinde bilgi yanlışı vardır?";
                questionDisplay.newA = "A.İlk ürünleri arasında koşuk ve sagu ile atasözü özelliği taşıyan savlar yer alıyordu";
                questionDisplay.newB = "B.Şiirler hece ölçüsüyle yazılır, nazım birimi beyittir; uyak düzeni bakımından ise halk edebiyatındaki koşmaya benzer";
                questionDisplay.newC = "C.Sürgün avlarına sığır, kurban törenlerine şölen, yas törenlerine yuğ denirdi";
                questionDisplay.newD = "D.Koşuklarda doğa güzellikleri, günlük yaşam, av eğlenceleri anlatılır; ölen bir kişinin arkasından söylenen yas şiirlerine ise sagu denirdi";
                questionDisplay.newE = "E.Ozanlar şiirlerinde, içinde yaşadıkları toplumun çeşitli gerçeklerini, inançlarını, görüşlerini değişik biçimlerde dile getirirlerdi";
                trueAnswer = "B";
            }
            if (questioNumber == 87)
            {
                questionDisplay.yeniSoru = "Nesir sözcüğü, “yaymak, saçmak, dağıtmak” demektir. Bugün “düzyazı” terimiyle karşılanmaya çalışılmaktadır, nesir yazarlarına eskiden “nâsir” denirdi.     ***Aşağıdakilerin hangisi divan edebiyatı nâsirlerinden değildir?**";
                questionDisplay.newA = "A.Naima";
                questionDisplay.newB = "B.Nergisî";
                questionDisplay.newC = "C.Gülşehrî";
                questionDisplay.newD = "D.Lâtifî";
                questionDisplay.newE = "E.Sinan Paşa";
                trueAnswer = "C";
            }
            if (questioNumber == 88)
            {
                questionDisplay.yeniSoru = "Konusu bir paşanın oğlu ile bir cariyenin aşk macerası olan---- , o zamanlar artık kapanmak üzere olan bir devrin cariyeli, köleli büyük konak hayatının Türk romanındaki en başarılı örneğidir.Sırf cariye olduğu için konak sahibinin oğlu ile evlenemeyen Dilber’in hayatı anlatılır bu romanda.   ****Bu parçada boş bırakılan yere aşağıdaki eserlerden hangisi getirilmelidir?**";
                questionDisplay.newA = "A.İclâl";
                questionDisplay.newB = "B.Sergüzeşt";
                questionDisplay.newC = "C.Zavallı Kız";
                questionDisplay.newD = "D.Zehra";
                questionDisplay.newE = "E.Bir Hatıra";
                trueAnswer = "B";
            }
            if (questioNumber == 89)
            {
                questionDisplay.yeniSoru = "Bir eleştirmenin, Abdülhak Hamit Tarhan’ın edebiyatımızdaki yerini ve kişiliğini değerlendirirken verdiği aşağıdaki bilgilerden hangisi yanlıştır?";
                questionDisplay.newA = "A.Batı şiirine özgü doğa betimlemelerinin bizde ilk örneklerine onun Sahra adlı yapıtında rastlanır";
                questionDisplay.newB = "B.Nağme-i Seher adlı kitapta topladığı ilk şiirlerinde divan şiirinden etkilendiği açıkça görülür.";
                questionDisplay.newC = "C.Hayal gücünün enginliği, duygularının zenginliği yönünden o, Tanzimat sonrası edebiyatımızın lirik şairleri arasında yer alır.";
                questionDisplay.newD = "D.Türk şiirini Batılılaştırma konusunda kurallar öne sürmekten çok, bunları yazdığı şiirlerle örneklendirme yolunu seçmiştir.";
                questionDisplay.newE = "E.Klasik bir edebiyat kültürü ile yetişmiş; Tahran’dan döndükten sonra Şinasi, Namık Kemal ve Recaizade Mahmut Ekrem’i okumaya başlamış ve ilk yapıtlarını tiyatro türünde yazmıştır.";
                trueAnswer = "B";
            }
            if (questioNumber == 90)
            {
                questionDisplay.yeniSoru = "Edebiyatımızın kimi dönemleriyle ilgili olarak aşağıda verilenlerden hangisi yanlıştır?";
                questionDisplay.newA = "A.Fecr-i atinin şiir alanındaki temsilcileri Tahsin Nahit, Mehmet Fuat, Faik Ali, Mehmet Behçet, Emin Bülent ve Ahmet Haşim’dir.";
                questionDisplay.newB = "B.Millî Mücadele Dönemi’ndeki Türk edebiyatı gerçekte Millî Edebiyat Dönemi’ndeki yönelimlerin bir uzantısı sayılabilir";
                questionDisplay.newC = "C.1940’lı yıllardan itibaren Cumhuriyet Dönemi Türk romanında, gerçekçiliğin bir uzantısı olarak köye ve köy insanına yöneliş başlar.";
                questionDisplay.newD = "D.Tanzimat Dönemi’nde sanatçıların yalın bir dile yönelmelerinin nedeni; sanatı, toplumu eğiten, bilgilendiren ve aydınlatan bir araç olarak görmeleridir.";
                questionDisplay.newE = "E.Servetifünun Dönemi’nde sanatçılar biçim ve üslup kaygılarını bir yana bırakıp halka yönelme ve halkın sorunlarını anlatmaya yönelik bir edebiyat anlayışını benimsediler";
                trueAnswer = "E";
            }
            if (questioNumber == 91)
            {
                questionDisplay.yeniSoru = "1923’ten 1940’a değin şiir ortamımız sürekli bir devinim içindedir. Bu süre içerisinde şiir yazanlar belirli topluluklar oluşturmuştur. Bu topluluklar arasında----- sayabiliriz.    ***Bu parçada boş bırakılan yere aşağıdakilerden hangisi getirilemez**";
                questionDisplay.newA = "A.Halka Yönelenler";
                questionDisplay.newB = "B.Hececiler";
                questionDisplay.newC = "C.Serbest Şiircileri";
                questionDisplay.newD = "D.Garipçileri";
                questionDisplay.newE = "E.Öz Şiircileri";
                trueAnswer = "D";
            }
            if (questioNumber == 92)
            {
                questionDisplay.yeniSoru = "Aşağıdaki yazarlardan hangisinin yapıtlarında fantastik gerçekçiliğe ait ögeler ağır basmaktadır?";
                questionDisplay.newA = "A.Rasim Özdenören";
                questionDisplay.newB = "B.İnci Aral";
                questionDisplay.newC = "C.Nezihe Meriç";
                questionDisplay.newD = "D.Nazlı Eray";
                questionDisplay.newE = "E.Oktay Akbal";
                trueAnswer = "D";
            }
            if (questioNumber == 93)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerin hangisinde bir bilgi yanlışı vardır?";
                questionDisplay.newA = "A.Sezai Karakoç’un şiirlerinin sağlam bir metafizik zemini vardır; Leyla ile Mecnun, Mağara ve Işık yayımlanan şiir kitaplarından bazılarıdır";
                questionDisplay.newB = "B.Kemal Özer’in 1965’te yayımlanan Bir Gün Mutlaka adlı şiiri, onun toplumcu gerçekçi yönünü yansıtan bir bildiri niteliği taşır.";
                questionDisplay.newC = "C.Şiir kültürü bakımından donanımlı bir şair olan Enis Batur, yalnızca şiir yazmakla kalmamış, aynı zamanda şiir üzerine yazılar da yayımlamıştır";
                questionDisplay.newD = "D.İsmet Özel’in şiirlerinin ana izleğini; yabancılaşma, başkaldırı, bunaltı ve özgürlük gibi çağımız insanının en temel sorunları oluşturur";
                questionDisplay.newE = "E.Hilmi Yavuz’un şiirlerini topladığı kitaplar arasında Hüzün ki En Çok Yakışandır Bize, Yolculuk Şiirleri, Akşam Şiirleri’ni sayabiliriz.";
                trueAnswer = "B";
            }
            if (questioNumber == 94)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerin hangisinde, belirtilen özellik birlikte verildiği akımla ilgili değildir?";
                questionDisplay.newA = "A.Gözlem ve belgelere önem verme (Realizm)";
                questionDisplay.newB = "B.Güzelliğin, anlam açıklığında değil, kapalılıkta olduğuna inanma (Sembolizm)";
                questionDisplay.newC = "C.Sanat, doğanın kopyası olmalıdır, ilkesini benimseme (Natüralizm)";
                questionDisplay.newD = "D.Bilinçaltını akıl ve mantıktan üstün tutma (Sürrealizm)";
                questionDisplay.newE = "E.Konuya değil, onun işleniş biçimine önem verme (Romantizm)";
                trueAnswer = "E";
            }
            if (questioNumber == 95)
            {
                questionDisplay.yeniSoru = "Aşağıdaki yapıtlardan hangisi türü bakımından ötekilerden farklıdır?";
                questionDisplay.newA = "A.Bir Adam Yaratmak";
                questionDisplay.newB = "B.Biz İnsanlar";
                questionDisplay.newC = "C.Günün Adamı";
                questionDisplay.newD = "D.Fadik Kız";
                questionDisplay.newE = "E.Duvarların Ötesi";
                trueAnswer = "B";
            }
            if (questioNumber == 96)
            {
                questionDisplay.yeniSoru = "Orhan Kemal’in Baba Evi adlı yapıtıyla aşağıdaki yapıtların hangisi arasında konusal yönden kimi açılardan bir benzerlik kurulamaz?";
                questionDisplay.newA = "A.Kayıp Aranıyor";
                questionDisplay.newB = "B.Sokaktaki Adam";
                questionDisplay.newC = "C.Kurt Kanunu";
                questionDisplay.newD = "D.Kopuk Takımı";
                questionDisplay.newE = "E.Arkadaş Islıkları";
                trueAnswer = "C";
            }
            if (questioNumber == 97)
            {
                questionDisplay.yeniSoru = "Cumhuriyet Dönemi’nin kimi romancıları, özellikle halkın sorunlarını yansıtma, bu sorunlar doğrultusunda okurları bilinçlendirme amacını gütmüşlerdir. Bunun için de insanları ezen koşulları, bu koşulları ortaya çıkaran etkenleri romanlarında ele alıp işlemişlerdir.     ***Aşağıdaki romanlardan hangisi bu parçada belirtilen tutumla oluşturulmamıştır?*";
                questionDisplay.newA = "A.Sonuncu";
                questionDisplay.newB = "B.Tütün Zamanı";
                questionDisplay.newC = "C.Rahmet Yolları Kesti";
                questionDisplay.newD = "D.Kaplmbağalar";
                questionDisplay.newE = "E.Kuyucaklı Yusuf";
                trueAnswer = "A";
            }
            if (questioNumber == 98)
            {
                questionDisplay.yeniSoru = "Cumhuriyet Dönemi romanı, Cumhuriyet öncesi anlatı temelleri üzerine kurulmuş bir romandır----gibi, aslında Cumhuriyet öncesinde yazmaya başlayıp bu dönemde de devam eden pek çok romancıyla karşılaşırız. ****Bu parçada boş bırakılan yere aşağıdaki yazarlardan hangisi getirilemez**";
                questionDisplay.newA = "A.Hüseyin Rahmi Gürpınar";
                questionDisplay.newB = "B.Aka Gündüz";
                questionDisplay.newC = "C.Reşat Nuri Güntekin";
                questionDisplay.newD = "D.Sabahattin Ali";
                questionDisplay.newE = "E.Refik Halit Karay";
                trueAnswer = "D";
            }
            if (questioNumber == 99)
            {
                questionDisplay.yeniSoru = "----, Türk edebiyatında ---- tarzda yazılmış ---- tiyatrodur. Yapıtın----(1859) ve----(1860) yıllarda Türkiye’de Türkçe oyunlar oynanan tiyatro yoktu.         ***Boş bırakılan yerlere sırasıyla aşağıdakilerden hangisi getirililebilir?*";
                questionDisplay.newA = "A.Hasan Mellah – bilinen – gerçek – övüldüğü – yerildiği";
                questionDisplay.newB = "B.Şair Evlenmesi – batılı – ilk – yazıldığı – basıldığı";
                questionDisplay.newC = "C.Zavallı Çocuk – özgün – bir – beğenildiği – yayıldığı";
                questionDisplay.newD = "D.Aşk-ı Memnu – modern – klasik – okunduğu – sevildiği";
                questionDisplay.newE = "E.Afife Anjelik – yeni – son – bilinmediği – tanınmadığı";
                trueAnswer = "B";
            }
            if (questioNumber == 100)
            {
                questionDisplay.yeniSoru = "Sen olasan diyü yir yir asılup âyineler / Gelene gidene eyler nazarı döne döne.   ****Bu beyit için aşağıdakilerin hangisi söylenemez?*";
                questionDisplay.newA = "A.Aynalar sevgiliye âşık kişiler olarak düşünülmüştür";
                questionDisplay.newB = "B.Âşığın ızdırabının aynalara yansıması tasvir edilmiştir";
                questionDisplay.newC = "C.Aynaların dizi dizi asılması güzel bir nedene bağlanmıştır.";
                questionDisplay.newD = "D.Sen zamiriyle sevgili kastedilmiştir";
                questionDisplay.newE = "E.Aynalar sevgiliye âşık kişiler olarak düşünülmüştür";
                trueAnswer = "B";
            }
            if (questioNumber == 101)
            {
                questionDisplay.yeniSoru = "Bu dünyaya sanki vefa gelmemiş / Gelmişse de bir kimsede kalmamış / Kim var ki dostundan cefa görmemiş / Cihanda bir söze duran mı kaldı      ***Bu dörtlükle ilgili aşağıdakilerin hangisi söylenemez?*";
                questionDisplay.newA = "A.Redife yer verildiği";
                questionDisplay.newB = "B.Düz kafiye düzeninde olduğu";
                questionDisplay.newC = "C.Teşbih sanatından yaralanıldığı";
                questionDisplay.newD = "D.Satirik şiireörnek olduğu";
                questionDisplay.newE = "E.11'li hece ölçüsüyle yazıldığı";
                trueAnswer = "C";
            }
            if (questioNumber == 102)
            {
                questionDisplay.yeniSoru = "Aşağıdaki beyitlerin hangisi ayraç içinde verilen ifadeyi örneklemez?";
                questionDisplay.newA = "A.Yazık sana kim eyleyesin hırs u tama'dan Bir habbe için kendini âlemlere bed-nâm(küçük duruma düşme)";
                questionDisplay.newB = "B.Hâlin kime açsan sana der hikmeti vardır Öldürdü bizi âh bilinmez mi bu hikmet(bilgisiyle övünme)";
                questionDisplay.newC = "C.Bir nâ-halefi cübbe vü destâr ile görsen Eylersin anın cübbe vü destârına ikrâm(dış görünüşe önem verme)";
                questionDisplay.newD = "D.Yok sende kanâat gözün aç olduğu oldur Rızkın erişir yoksa eğer subh eğer şâm(var olanla yetinmeme)";
                questionDisplay.newE = "E.Gör zahidi kim sâhib-i irşâd olayın der Dün mektebe vardı bugün üstâd olayın der(haddini bilmeme)";
                trueAnswer = "B";
            }
            if (questioNumber == 103)
            {
                questionDisplay.yeniSoru = "I)Ayrılır dosta gider      II)Sağ gelen hasta gider        III)Su gelir deste gider     IV)Gurbet yansın yıkılsın      ***Mâni nazım şeklinin biçim ve içerik özellikleri dikkate alınarak bir mâni oluşturulmak istense bu dizelerin sıralaması aşağıdakilerin hangisi olur?*";
                questionDisplay.newA = "A.I - II - IV - III";
                questionDisplay.newB = "B.I- III- II - IV";
                questionDisplay.newC = "C.III - I - IV - II";
                questionDisplay.newD = "D.III - II - I - IV";
                questionDisplay.newE = "E.IV - II - I - III";
                trueAnswer = "C";
            }
            if (questioNumber == 104)
            {
                questionDisplay.yeniSoru = "(I) Siz “Lim derdiniz” bana, “bir gülümsememe ne verirsin?” “Canımı” derdim. “Hayır” diye itiraz ederdiniz, “o zaten benim!”     (II)Âşık oldur kim kılur cânnı fedâ cânânına / Meyl - i cânân itmesün her kim ki kıymaz cânına     ****Aşağıdakilerin hangisi farklı edebî dönemlerden alınmış bu şiir parçalarının ortak özelliğidir?*";
                questionDisplay.newA = "A.Tema";
                questionDisplay.newB = "B.Ölçü";
                questionDisplay.newC = "C.Dil ve üslup";
                questionDisplay.newD = "D.Kafiye Düzeni";
                questionDisplay.newE = "E.Nazım birimi";
                trueAnswer = "A";
            }
            if (questioNumber == 105)
            {
                questionDisplay.yeniSoru = "Aşağıdaki beyitlerin hangisi bir kasidenin “fahriye” bölümünden alınmış olabilir?";
                questionDisplay.newA = "A.Görüp bu hâli gül-istanda dondu cedvel-i âb / Bahâra dek duramaz korkarım kenâr çizer";
                questionDisplay.newB = "B.Ayagı yer mi basar zülfüne ber-dâr olanun / Zevk ü şevk ile virür cân u seri döne döne";
                questionDisplay.newC = "C.Arab u Rûm’da üstâd-ı sühandır Vehbî / Acemî oldu yanında şuârası Acem’in";
                questionDisplay.newD = "D.Lâle-hadler yine gülşende neler itmediler / Servi yürütmediler gonceyi söyletmediler";
                questionDisplay.newE = "E.Yok bu şehr içre senin vasf ettiğin dil-ber Nedîm / Bir perî-sûret görünmüş bir hayâl olmuş sana";
                trueAnswer = "C";
            }
            if (questioNumber == 106)
            {
                questionDisplay.yeniSoru = "Ey serv-i sehi sen geleli seyr ile bağa/  Baş çekmedi ar’ar      Çok ali - nesebler özünü saldı ayağa / Kul böldü sanavber     ****Biçim ve içerik özellikleri dikkate alındığında bu şiirin nazım şeklinin aşağıdakilerden hangisi olduğu söylenebilir?*";
                questionDisplay.newA = "A.Kıt'a";
                questionDisplay.newB = "B.Şarkı";
                questionDisplay.newC = "C.Terkibibent";
                questionDisplay.newD = "D.Rubai";
                questionDisplay.newE = "E.Müstezat";
                trueAnswer = "E";
            }
            if (questioNumber == 107)
            {
                questionDisplay.yeniSoru = "Bizde hâlâ halk şiiri geleneğine gereğinden fazla bağlı kalan şairler var. Bu, duyguları devindirici bir tutum değildir. Çünkü o ürünler çağdaş duyarlığı besleyecek zenginlikler taşımaz, -sözü kanatlandıracak olanaklar içermez.-    ****Bu parçadaki belirtilen sözle anlatılmak istenen aşağıdakilerden hangisi olamaz*";
                questionDisplay.newA = "A.Bireysel yaratıcılığı önleme";
                questionDisplay.newB = "B.Belirli biçimler içinde sıkışıp kalma";
                questionDisplay.newC = "C.Temaları günlük yaşamla sınırlı tutma";
                questionDisplay.newD = "D.Yeni imgeler çağrıştırmama";
                questionDisplay.newE = "E.Alışılmış söyleyişlerin dışına çıkamama";
                trueAnswer = "C";
            }
            if (questioNumber == 108)
            {
                questionDisplay.yeniSoru = "İnsanı etkileyen birçok şiirin gizleri, dünyanın her yerinde dilin ses, biçim, söz dizimi yönünden ustaca kullanılmasında aranmalıdır.        ***Buna göre aşağıda verilenlerden hangisi yanlıştır?*";
                questionDisplay.newA = "A.Birleşik yapılı, kurallı bir cümledir";
                questionDisplay.newB = "B.İlgi eki almış sözcük kullanılmıştır.";
                questionDisplay.newC = "C.Birden fazla belgisiz sıfat vardır";
                questionDisplay.newD = "D.Edilgenlik eki almış sözcükler vardır";
                questionDisplay.newE = "E.Fiilden isim yapma eki almış sözcük vardır";
                trueAnswer = "B";
            }
            if (questioNumber == 109)
            {
                questionDisplay.yeniSoru = "Aşağıdaki dizelerin hangisinde şiirsellik daha sınırlıdır?";
                questionDisplay.newA = "A.Ellerim takılırken rüzgârların saçına Asıldı arabamız bir dağın yamacına";
                questionDisplay.newB = "B.Bir göz gibi süzüyor beni camdan gece, Dönüyor etrafımda bir sürü kambur cüce";
                questionDisplay.newC = "C.Şakaklarıma kar mı yağdı ne var? Benim mi Allahım bu çizgili yüz?";
                questionDisplay.newD = "D.Deniz engin bir sudur, tuzlu, yeşil, dalgalı Kenarlarını süsler bazen küçük bir yalı";
                questionDisplay.newE = "E.Bir cümbüştür kopsa da gece yakamozlarda Münzevi balıklarız aynı kavanozlarda";
                trueAnswer = "D";
            }
            if (questioNumber == 110)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerden hangisi yazınsal değer taşıyan bir yapıtın popüler yapıtlardan farkları arasında sayılamaz?";
                questionDisplay.newA = "A.Değişik yorumlara açık olma niteliği taşıyabilir";
                questionDisplay.newB = "B.Her düzeyden okura seslenme yönsemesinden ka- çınılır";
                questionDisplay.newC = "C.Biçim ve içerik yönünden kolay anlaşılır olma amacı güdülmez.";
                questionDisplay.newD = "D.Tek boyutlu bakış açısı yerini çok boyutluluğa bırakır";
                questionDisplay.newE = "E.Anlatılanların büyük ölçüde günlük yaşamdan kesitler ve esintiler taşıması düşünülür";
                trueAnswer = "E";
            }
            if (questioNumber == 111)
            {
                questionDisplay.yeniSoru = "Bir kâsedir alev dolu gönlüm yana yana / Men tâ senin yanında dahi hasretem sana / Yaşlar dökende söndüremez âteşimi su / Sunsan elinle kanımı içsem kana kana      ****Bu dörtlükle ilgili olarak aşağıdakilerden hangisi yanlıştır?*";
                questionDisplay.newA = "A.Abartmaya başvurulmuştur.";
                questionDisplay.newB = "B.Yinelemelere yer verilmiştir.";
                questionDisplay.newC = "C.Tezat sanatına başvurulmuştur";
                questionDisplay.newD = "D.Didaktik bir boyut taşımaktadır";
                questionDisplay.newE = "E.Divan şiirine özgü benzetmelerden yararlanılmıştır";
                trueAnswer = "D";
            }
            if (questioNumber == 112)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerin hangisinde konuşmacı, dinleyicileri etkilemek amacıyla yeri geldikçe özellikle duygusal ve coşkusal bir söyleme başvurur?";
                questionDisplay.newA = "A.Sempozyum";
                questionDisplay.newB = "B.Panel";
                questionDisplay.newC = "C.Münazara";
                questionDisplay.newD = "D.Söylev";
                questionDisplay.newE = "E.Forum";
                trueAnswer = "D";
            }
            if (questioNumber == 113)
            {
                questionDisplay.yeniSoru = "Gül gülse dâim ağlasa bülbül aceb degül / Zîrâ kimine ağla demişler kimine gül       ***Aşağıdakilerden hangisinde kullanılan uyak türü yukarıda verilen beyittekiyle aynıdır?*";
                questionDisplay.newA = "A.Derdim var beller gibi Söylemem eller gibi";
                questionDisplay.newB = "B.Zannetme ki şöyle böyle bir söz Gel sen dahi söyle böyle bir söz";
                questionDisplay.newC = "C.Göz seni görmeli ağız seni söylemeli Bütün deniz kıyılarında seni beklemeli";
                questionDisplay.newD = "D.Yalnız atlar yıkılır düzlerde suya özlemlerinden / Bir ben miyim yalnızlığa yenilen sen, sen, sen";
                questionDisplay.newE = "E.Onlar, o hiçbir şeyden yapılmamış adamlar / Üşümüş, yorgun ve bütün gün adres soranlar";
                trueAnswer = "A";
            }
            if (questioNumber == 114)
            {
                questionDisplay.yeniSoru = "(I)Gülşehrî    (II)Nefî     (III)Şeyh Galip      (IV)Fuzuli     ***Aşağıdaki yapıtlardan hangisi burada verilen sanatçılardan birine ait değildir*";
                questionDisplay.newA = "A.Hayriyye";
                questionDisplay.newB = "B.Şikâyetname";
                questionDisplay.newC = "C.Hüsn ü Aşk";
                questionDisplay.newD = "D.Siham-ı Kaza";
                questionDisplay.newE = "E.Mantıku’t-Tayr";
                trueAnswer = "A";
            }
            if (questioNumber == 115)
            {
                questionDisplay.yeniSoru = "Aşağıdaki yapıtlardan hangisinde “Tağ tağka kavuşmas, kişi kişige kavuşur.” sözü ve açıklaması bulunabilir?";
                questionDisplay.newA = "A.Atebetü’l-Hakayık";
                questionDisplay.newB = "B.Divan-ı Hikmet";
                questionDisplay.newC = "C.Risaletü’n-Nushiyye";
                questionDisplay.newD = "D.Divanü Lügâti’t-Türk";
                questionDisplay.newE = "E.Kutadgu Bilig";
                trueAnswer = "D";
            }
            if (questioNumber == 116)
            {
                questionDisplay.yeniSoru = "I.Heşt Behişt    II.Sefaretname-i Fransa      III.Mecalisü’n-Nefais      IV.Tezkiretü’ş-Şuara         V.Makalat           ***Yukarıda verilenlerden hangileri aynı yazınsal türe ait yapıtlardır?*";
                questionDisplay.newA = "A.I, II , III";
                questionDisplay.newB = "B.I, III , IV";
                questionDisplay.newC = "C.II, III , V";
                questionDisplay.newD = "D.II, IV , V";
                questionDisplay.newE = "E.III, IV , V";
                trueAnswer = "B";
            }
            if (questioNumber == 117)
            {
                questionDisplay.yeniSoru = "I.Sebk-i Hindî            II.Mahallîleşme Akımı           III.Süslü Nesir            ***Aşağıda verilen divan edebiyatı sanatçılarından hangisi yukarıdakilerden biriyle ilişkilendirilemez?*";
                questionDisplay.newA = "A.Necat";
                questionDisplay.newB = "B.Nedim";
                questionDisplay.newC = "C.Nergisî";
                questionDisplay.newD = "D.Neşatî";
                questionDisplay.newE = "E.Enderunlu Vasıf";
                trueAnswer = "A";
            }
            if (questioNumber == 118)
            {
                questionDisplay.yeniSoru = "Ahmet Haşim’in şiirleriyle ilgili olarak aşağıda verilen bilgilerden hangisi yanlıştır?";
                questionDisplay.newA = "A.Vezin olarak yalnızca “aruz”u kullanmıştır";
                questionDisplay.newB = "B.Türk şiirini Batılılaştırma konusunda “düşünen”den çok, “uygulayan” kişidir.";
                questionDisplay.newC = "C.Yaşanılan hayattan uzak, tamamen hayalî bir âleme sığınma isteği, birçok şiirinde görülür";
                questionDisplay.newD = "D.Şiirlerinde dış dünyaya ait gözlemlerinin, iç dünyasında yarattığı izlenimleri yansıtmıştır";
                questionDisplay.newE = "E.Şiirlerinde kullandığı tabiat manzaraları genellikle akşam, gurup, şafak, gece, göller ve ormanlar gibi duygulanmaya, hayal kurmaya elverişli olanlardır";
                trueAnswer = "B";
            }
            if (questioNumber == 119)
            {
                questionDisplay.yeniSoru = "Aşağıdakilerin hangisindeki yapıt, birlikte verildiği şaire ait değildir?";
                questionDisplay.newA = "A.Faruk Nafiz Çamlıbel – Gönülden Gönüle";
                questionDisplay.newB = "B.Halit Fahri Ozansoy – Cenk Duyguları";
                questionDisplay.newC = "C.Enis Behiç Koryürek – Güneşin Ölümü";
                questionDisplay.newD = "D.Yusuf Ziya Ortaç – Akından Akına";
                questionDisplay.newE = "E.Orhan Seyfi Orhon – Çobanıl Şiirler";
                trueAnswer = "E";
            }
            if (questioNumber == 120)
            {
                questionDisplay.yeniSoru = "1929’la 1945 arasında öz şiir hareketini sürdüren şairler arasında----sayabiliriz.         ***Bu cümlede boş bırakılan yere aşağıdakilerden hangisi getirilemez?*";
                questionDisplay.newA = "A.Cahit Sıtkı Tarancı’yı";
                questionDisplay.newB = "B.Ahmet Hamdi Tanpınar’ı";
                questionDisplay.newC = "C.Necip Fazıl Kısakürek’i";
                questionDisplay.newD = "D.Oktay Rifat Horozcu’yu";
                questionDisplay.newE = "E.Ahmet Muhip Dıranas’ı";
                trueAnswer = "D";
            }

            questionDisplay.updatePirs = false;
        }
    }
}
