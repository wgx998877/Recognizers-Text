﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\Spanish\Spanish-NumbersWithUnit.yaml
//     - Language: Spanish
//     - ClassName: NumbersWithUnitDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.Spanish
{
	using System;
	using System.Collections.Generic;

	public static class NumbersWithUnitDefinitions
	{
		public static readonly Dictionary<string, string> AgeSuffixList = new Dictionary<string, string>
		{
			{ "Año", "años|año" },
			{ "Mes", "meses|mes" },
			{ "Semana", "semanas|semana" },
			{ "Día", "dias|días|día|dia" }
		};
		public static readonly Dictionary<string, string> AreaSuffixList = new Dictionary<string, string>
		{
			{ "Kilómetro cuadrado", "kilómetro cuadrado|kilómetros cuadrados|km2|km^2|km²" },
			{ "Hectómetro cuadrado", "hectómetro cuadrado|hectómetros cuadrados|hm2|hm^2|hm²|hectárea|hectáreas" },
			{ "Decámetro cuadrado", "decámetro cuadrado|decámetros cuadrados|dam2|dam^2|dam²|área|áreas" },
			{ "Metro cuadrado", "metro cuadrado|metros cuadrados|m2|m^2|m²" },
			{ "Decímetro cuadrado", "decímetro cuadrado|decímetros cuadrados|dm2|dm^2|dm²" },
			{ "Centímetro cuadrado", "centímetro cuadrado|centímetros cuadrados|cm2|cm^2|cm²" },
			{ "Milímetro cuadrado", "milímetro cuadrado|milímetros cuadrados|mm2|mm^2|mm²" },
			{ "Pulgada cuadrado", "pulgada cuadrada|pulgadas cuadradas" },
			{ "Pie cuadrado", "pie cuadrado|pies cuadrados|pie2|pie^2|pie²|ft2|ft^2|ft²" },
			{ "Yarda cuadrado", "yarda cuadrada|yardas cuadradas|yd2|yd^2|yd²" },
			{ "Acre", "acre|acres" }
		};
		public static readonly IList<string> AreaAmbiguousValues = new List<string>
		{
			"área",
			"áreas"
		};
		public static readonly Dictionary<string, string> CurrencySuffixList = new Dictionary<string, string>
		{
			{ "Dólar", "dólar|dólares" },
			{ "Peso", "peso|pesos" },
			{ "Rublo", "rublo|rublos" },
			{ "Libra", "libra|libras" },
			{ "Florín", "florín|florines" },
			{ "Dinar", "dinar|dinares" },
			{ "Franco", "franco|francos" },
			{ "Rupia", "rupia|rupias" },
			{ "Escudo", "escudo|escudos" },
			{ "Chelín", "chelín|chelines" },
			{ "Lira", "lira|liras" },
			{ "Centavo", "centavo|centavos" },
			{ "Céntimo", "céntimo|céntimos" },
			{ "Centésimo", "centésimo|centésimos" },
			{ "Penique", "penique|peniques" },
			{ "Euro", "euro|euros|€|eur" },
			{ "Céntimo de Euro", "céntimo de euro|céntimos de euros" },
			{ "Dólar del Caribe Oriental", "dólar del Caribe Oriental|dólares del Caribe Oriental|ec$|xcd" },
			{ "Centavo del Caribe Oriental", "centavo del Caribe Oriental|centavos del Caribe Oriental" },
			{ "Franco CFA de África Occidental", "franco CFA de África Occidental|francos CFA de África Occidental|fcfa|xof" },
			{ "Céntimo de CFA de África Occidental", "céntimo de CFA de África Occidental|céntimos de CFA de África Occidental" },
			{ "Franco CFA de África Central", "franco CFA de África Central|francos CFA de África Central|xaf" },
			{ "Céntimo de CFA de África Central", "céntimo de CFA de África Central|céntimos de CFA de África Central" },
			{ "Apsar", "apsar|apsares" },
			{ "Afgani afgano", "afgani afgano|؋|afn|afganis|afgani" },
			{ "Pul", "pul|puls" },
			{ "Lek albanés", "lek|lekë|lekes|lek albanés" },
			{ "Qindarka", "qindarka|qindarkë|qindarkas" },
			{ "Kwanza angoleño", "kwanza angoleño|kwanzas angoleños|kwanza angoleños|kwanzas angoleño|kwanzas|aoa|kz" },
			{ "Cêntimo angoleño", "cêntimo angoleño|cêntimo|cêntimos" },
			{ "Florín antillano neerlandés", "florín antillano neerlandés|florínes antillano neerlandés|ƒ antillano neerlandés|ang|naƒ" },
			{ "Cent antillano neerlandés", "cent|centen" },
			{ "Riyal saudí", "riyal saudí|riyales saudí|sar" },
			{ "Halalá saudí", "halalá saudí|hallalah" },
			{ "Dinar argelino", "dinar argelino|dinares argelinos|dzd" },
			{ "Céntimo argelino", "centimo argelino|centimos argelinos|" },
			{ "Peso argentino", "peso argentino|pesos argentinos|peso|pesos|ar$|ars" },
			{ "Centavo argentino", "centavo argentino|centavos argentinos|centavo|ctvo.|ctvos." },
			{ "Dram armenio", "dram armenio|dram armenios|dram|դր." },
			{ "Luma armenio", "luma armenio|luma armenios" },
			{ "Florín arubeño", "florín arubeño|florines arubeños|ƒ arubeños|aƒ|awg" },
			{ "Yotin arubeño", "yotin arubeño|yotines arubeños" },
			{ "Dólar australiano", "dólar australiano|dólares australianos|a$|aud" },
			{ "Centavo australiano", "centavo australiano|centavos australianos" },
			{ "Manat azerí", "manat azerí|man|azn" },
			{ "Qəpik azerí", "qəpik azerí|qəpik" },
			{ "Dólar bahameño", "dólar bahameño|dólares bahameños|b$|bsd" },
			{ "Centavo bahameño", "centavo bahameño|centavos bahameños" },
			{ "Dinar bahreiní", "dinar bahreiní|dinares bahreinies|bhd" },
			{ "Fil bahreiní", "fil bahreiní|fils bahreinies" },
			{ "Taka bangladeshí", "taka bangladeshí|takas bangladeshí|bdt" },
			{ "Poisha bangladeshí", "poisha bangladeshí|poishas bangladeshí" },
			{ "Dólar de Barbados", "dólar de barbados|dólares de barbados|bbd" },
			{ "Centavo de Barbados", "centavo de barbados|centavos de barbados" },
			{ "Dólar beliceño", "dólar beliceño|dólares beliceños|bz$|bzd" },
			{ "Centavo beliceño", "centavo beliceño|centavos beliceños" },
			{ "Dólar bermudeño", "dólar bermudeño|dólares bermudeños|bd$|bmd" },
			{ "Centavo bermudeño", "centavo bermudeño|centavos bermudeños" },
			{ "Rublo bielorruso", "rublo bielorruso|rublos bielorrusos|br|byr" },
			{ "Kópek bielorruso", "kópek bielorruso|kópeks bielorrusos|kap" },
			{ "Kyat birmano", "kyat birmano|kyats birmanos|mmk" },
			{ "Pya birmano", "pya birmano|pyas birmanos" },
			{ "Boliviano", "boliviano|bolivianos|bob|bs" },
			{ "Centésimo Boliviano", "centésimo boliviano|centésimos bolivianos" },
			{ "Marco bosnioherzegovino", "marco convertible|marco bosnioherzegovino|marcos convertibles|marcos bosnioherzegovinos|bam" },
			{ "Feningas bosnioherzegovino", "feninga convertible|feninga bosnioherzegovina|feningas convertibles" },
			{ "Pula", "pula|bwp" },
			{ "Thebe", "thebe" },
			{ "Real brasileño", "real brasileño|reales brasileños|r$|brl" },
			{ "Centavo brasileño", "centavo brasileño|centavos brasileños" },
			{ "Dólar de Brunéi", "dólar de brunei|dólares de brunéi|bnd" },
			{ "Sen de Brunéi", "sen|sen de brunéi" },
			{ "Lev búlgaro", "lev búlgaro|leva búlgaros|lv|bgn" },
			{ "Stotinki búlgaro", "stotinka búlgaro|stotinki búlgaros" },
			{ "Franco de Burundi", "franco de burundi|francos de burundi|fbu|fib" },
			{ "Céntimo Burundi", "céntimo burundi|céntimos burundies" },
			{ "Ngultrum butanés", "ngultrum butanés|ngultrum butaneses|btn" },
			{ "Chetrum  butanés", "chetrum butanés|chetrum butaneses" },
			{ "Escudo caboverdiano", "escudo caboverdiano|escudos caboverdianos|cve" },
			{ "Riel camboyano", "riel camboyano|rieles camboyanos|khr" },
			{ "Dólar canadiense", "dólar canadiense|dólares canadienses|c$|cad" },
			{ "Centavo canadiense", "centavo canadiense|centavos canadienses" },
			{ "Peso chileno", "peso chileno|pesos chilenos|cpl" },
			{ "Yuan chino", "yuan chino|yuanes chinos|yuan|yuanes|renminbi|rmb|cny|¥" },
			{ "Peso colombiano", "peso colombiano|pesos colombianos|cop|col$" },
			{ "Centavo colombiano", "centavo colombiano|centavos colombianos" },
			{ "Franco comorano", "franco comorano|francos comoranos|kmf|₣" },
			{ "Franco congoleño", "franco congoleño|francos congoleños|cdf" },
			{ "Céntimo congoleño", "céntimo congoleño|céntimos congoleños" },
			{ "Won norcoreano", "won norcoreano|wŏn norcoreano|wŏn norcoreanos|kpw" },
			{ "Chon norcoreano", "chon norcoreano|chŏn norcoreano|chŏn norcoreanos|chon norcoreanos" },
			{ "Won surcoreano", "wŏn surcoreano|won surcoreano|wŏnes surcoreanos|wones surcoreanos|krw" },
			{ "Chon surcoreano", "chon surcoreano|chŏn surcoreano|chŏn surcoreanos|chon surcoreanos" },
			{ "Colón costarricense", "colón costarricense|colones costarricenses|crc" },
			{ "Kuna croata", "kuna croata|kuna croatas|hrk" },
			{ "Lipa croata", "lipa croata|lipa croatas" },
			{ "Peso cubano", "peso cubano|pesos cubanos|cup" },
			{ "Peso cubano convertible", "peso cubano convertible|pesos cubanos convertible|cuc" },
			{ "Corona danesa", "corona danesa|coronas danesas|dkk" },
			{ "Libra egipcia", "libra egipcia|libras egipcias|egp|le" },
			{ "Piastra egipcia", "piastra egipcia|piastras egipcias" },
			{ "Colón salvadoreño", "colón salvadoreño|colones salvadoreños|svc" },
			{ "Dirham de los Emiratos Árabes Unidos", "dirham|dirhams|dirham de los Emiratos Árabes Unidos|aed|dhs" },
			{ "Nakfa", "nakfa|nfk|ern" },
			{ "Céntimo de Nakfa", "céntimo de nakfa|céntimos de nakfa" },
			{ "Peseta", "peseta|pesetas|pts.|ptas.|esp" },
			{ "Dólar estadounidense", "dólar estadounidense|dólares estadounidenses|usd|u$d|us$" },
			{ "Corona estonia", "corona estonia|coronas estonias|eek" },
			{ "Senti estonia", "senti estonia|senti estonias" },
			{ "Birr etíope", "birr etíope|birr etíopes|br|etb" },
			{ "Santim etíope", "santim etíope|santim etíopes" },
			{ "Peso filipino", "peso filipino|pesos filipinos|php" },
			{ "Marco finlandés", "marco finlandés|marcos finlandeses" },
			{ "Dólar fiyiano", "dólar fiyiano|dólares fiyianos|fj$|fjd" },
			{ "Centavo fiyiano", "centavo fiyiano|centavos fiyianos" },
			{ "Dalasi", "dalasi|gmd" },
			{ "Bututs", "butut|bututs" },
			{ "Lari georgiano", "lari georgiano|lari georgianos|gel" },
			{ "Tetri georgiano", "tetri georgiano|tetri georgianos" },
			{ "Cedi", "cedi|ghs|gh₵" },
			{ "Pesewa", "pesewa" },
			{ "Libra gibraltareña", "libra gibraltareña|libras gibraltareñas|gip" },
			{ "Penique gibraltareña", "penique gibraltareña|peniques gibraltareñas" },
			{ "Quetzal guatemalteco", "quetzal guatemalteco|quetzales guatemaltecos|quetzal|quetzales|gtq" },
			{ "Centavo guatemalteco", "centavo guatemalteco|centavos guatemaltecos" },
			{ "Libra de Guernsey", "libra de Guernsey|libras de Guernsey|ggp" },
			{ "Penique de Guernsey", "penique de Guernsey|peniques de Guernsey" },
			{ "Franco guineano", "franco guineano|francos guineanos|gnf|fg" },
			{ "Céntimo guineano", "céntimo guineano|céntimos guineanos" },
			{ "Dólar guyanés", "dólar guyanés|dólares guyaneses|gyd|gy" },
			{ "Gourde haitiano", "gourde haitiano|gourde haitianos|htg" },
			{ "Céntimo haitiano", "céntimo haitiano|céntimos haitianos" },
			{ "Lempira hondureño", "lempira hondureño|lempira hondureños|hnl" },
			{ "Centavo hondureño", "centavo hondureño|centavos hondureño" },
			{ "Dólar de Hong Kong", "dólar de hong kong|dólares de hong kong|hk$|hkd" },
			{ "Forinto húngaro", "forinto húngaro|forinto húngaros|huf" },
			{ "Rupia india", "rupia india|rupias indias|inr" },
			{ "Paisa india", "paisa india|paise indias" },
			{ "Rupia indonesia", "rupia indonesia|rupias indonesias|idr" },
			{ "Sen indonesia", "sen indonesia|sen indonesias" },
			{ "Rial iraní", "rial iraní|rial iranies|irr" },
			{ "Dinar iraquí", "dinar iraquí|dinares iraquies|iqd" },
			{ "Fil iraquí", "fil iraquí|fils iraquies" },
			{ "Libra manesa", "libra manesa|libras manesas|imp" },
			{ "Penique manes", "penique manes|peniques maneses" },
			{ "Corona islandesa", "corona islandesa|coronas islandesas|isk|íkr" },
			{ "Aurar islandes", "aurar islandes|aurar islandeses" },
			{ "Dólar de las Islas Caimán", "dólar de las Islas Caimán|dólares de las Islas Caimán|ci$|kyd" },
			{ "Dólar de las Islas Cook", "dólar de las Islas Cook|dólares de las Islas Cook" },
			{ "Corona feroesa", "corona feroesa|coronas feroesas|fkr" },
			{ "Libra malvinense", "libra malvinense|libras malvinenses|fk£|fkp" },
			{ "Dólar de las Islas Salomón", "dólar de las Islas Salomón|dólares de las Islas Salomón|sbd" },
			{ "Nuevo shéquel", "nuevo shéquel|nuevos shéquel|ils" },
			{ "Agorot", "agorot" },
			{ "Dólar jamaiquino", "dólar jamaiquino|dólares jamaiquinos|j$|ja$|jmd" },
			{ "Yen", "yen|yenes|jpy" },
			{ "Libra de Jersey", "libra de Jersey|libras de Jersey|jep" },
			{ "Dinar jordano", "dinar jordano|dinares jordanos|jd|jod" },
			{ "Piastra jordano", "piastra jordano|piastras jordanos" },
			{ "Tenge kazajo", "tenge|tenge kazajo|kzt" },
			{ "Chelín keniano", "chelín keniano|chelines kenianos|ksh|kes" },
			{ "Som kirguís", "som kirguís|kgs" },
			{ "Tyiyn", "tyiyn" },
			{ "Dólar de Kiribati", "dólar de Kiribati|dólares de Kiribati" },
			{ "Dinar kuwaití", "dinar kuwaití|dinares kuwaití" },
			{ "Kip laosiano", "kip|kip laosiano|kip laosianos|lak" },
			{ "Att laosiano", "att|att laosiano|att laosianos" },
			{ "Loti", "loti|maloti|lsl" },
			{ "Sente", "sente|lisente" },
			{ "Libra libanesa", "libra libanesa|libras libanesas|lbp" },
			{ "Dólar liberiano", "dólar liberiano|dólares liberianos|l$|lrd" },
			{ "Dinar libio", "dinar libio|dinares libios|ld|lyd" },
			{ "Dirham libio", "dirham libio|dirhams libios" },
			{ "Litas lituana", "litas lituana|litai lituanas|ltl" },
			{ "Pataca macaense", "pataca macaense|patacas macaenses|mop$|mop" },
			{ "Avo macaense", "avo macaense|avos macaenses" },
			{ "Ho macaense", "ho macaense|ho macaenses" },
			{ "Denar macedonio", "denar macedonio|denare macedonios|den|mkd" },
			{ "Deni macedonio", "deni macedonio|deni macedonios" },
			{ "Ariary malgache", "ariary malgache|ariary malgaches|mga" },
			{ "Iraimbilanja malgache", "iraimbilanja malgache|iraimbilanja malgaches" },
			{ "Ringgit malayo", "ringgit malayo|ringgit malayos|rm|myr" },
			{ "Sen malayo", "sen malayo|sen malayos" },
			{ "Kwacha malauí", "kwacha malauí|mk|mwk" },
			{ "Támbala malauí", "támbala malauí" },
			{ "Rupia de Maldivas", "rupia de Maldivas|rupias de Maldivas|mvr" },
			{ "Dirham marroquí", "dirham marroquí|dirhams marroquies|mad" },
			{ "Rupia de Mauricio", "rupia de Mauricio|rupias de Mauricio|mur" },
			{ "Uguiya", "uguiya|uguiyas|mro" },
			{ "Jum", "jum|jums" },
			{ "Peso mexicano", "peso mexicano|pesos mexicanos|mxn" },
			{ "Centavo mexicano", "centavo mexicano|centavos mexicanos" },
			{ "Leu moldavo", "leu moldavo|lei moldavos|mdl" },
			{ "Ban moldavo", "ban moldavo|bani moldavos" },
			{ "Tugrik mongol", "tugrik mongol|tugrik|tugrik mongoles|tug|mnt" },
			{ "Metical mozambiqueño", "metical|metical mozambiqueño|meticales|meticales mozambiqueños|mtn|mzn" },
			{ "Dram de Nagorno Karabaj", "dram de Nagorno Karabaj|drams de Nagorno Karabaj|" },
			{ "Luma de Nagorno Karabaj", "luma de Nagorno Karabaj" },
			{ "Dólar namibio", "dólar namibio|dólares namibios|n$|nad" },
			{ "Centavo namibio", "centavo namibio|centavos namibios" },
			{ "Rupia nepalí", "rupia nepalí|rupias nepalies|npr" },
			{ "Paisa nepalí", "paisa nepalí|paisas nepalies" },
			{ "Córdoba nicaragüense", "córdoba nicaragüense|córdobas nicaragüenses|c$|nio" },
			{ "Centavo nicaragüense", "centavo nicaragüense|centavos nicaragüenses" },
			{ "Naira", "naira|ngn" },
			{ "Kobo", "kobo" },
			{ "Corona noruega", "corona noruega|coronas noruegas|nok" },
			{ "Franco CFP", "franco cfp|francos cfp|xpf" },
			{ "Dólar neozelandés", "dólar neozelandés|dólares neozelandeses|dólar de Nueva Zelanda|dólares de Nueva Zelanda|nz$|nzd" },
			{ "Centavo neozelandés", "centavo neozelandés|centavo de Nueva Zelanda|centavos de Nueva Zelanda|centavos neozelandeses" },
			{ "Rial omaní", "rial omaní|riales omanies|omr" },
			{ "Baisa omaní", "baisa omaní|baisa omanies" },
			{ "Florín neerlandés", "florín neerlandés|florines neerlandeses|nlg" },
			{ "Rupia pakistaní", "rupia pakistaní|rupias pakistanies|pkr" },
			{ "Paisa pakistaní", "paisa pakistaní|paisas pakistanies" },
			{ "Balboa panameño", "balboa panameño|balboa panameños|pab" },
			{ "Centésimo panameño", "centésimo panameño|centésimos panameños" },
			{ "Kina", "kina|pkg|pgk" },
			{ "Toea", "toea" },
			{ "Guaraní", "guaraní|guaranies|gs|pyg" },
			{ "Sol", "sol|soles|nuevo sol|pen|s#." },
			{ "Céntimo de sol", "céntimo de sol|céntimos de sol" },
			{ "Złoty", "złoty|esloti|eslotis|zł|pln" },
			{ "Groszy", "groszy" },
			{ "Riyal qatarí", "riyal qatarí|riyal qataries|qr|qar" },
			{ "Dirham qatarí", "dirham qatarí|dirhams qataries" },
			{ "Libra esterlina", "libra esterlina|libras esterlinas|gbp" },
			{ "Corona checa", "corona checa|coronas checas|kc|czk" },
			{ "Peso dominicano", "peso dominicano|pesos dominicanos|rd$|dop" },
			{ "Centavo dominicano", "centavo dominicano|centavos dominicanos" },
			{ "Franco ruandés", "franco ruandés|francos ruandeses|rf|rwf" },
			{ "Céntimo ruandés", "céntimo ruandés|céntimos ruandeses" },
			{ "Leu rumano", "leu rumano|lei rumanos|ron" },
			{ "Ban rumano", "ban rumano|bani rumanos" },
			{ "Rublo ruso", "rublo ruso|rublos rusos|rub" },
			{ "Kopek ruso", "kopek ruso|kopeks rusos" },
			{ "Tala", "tala|tālā|ws$|sat|wst" },
			{ "Sene", "sene" },
			{ "Libra de Santa Helena", "libra de Santa Helena|libras de Santa Helena|shp" },
			{ "Penique de Santa Helena", "penique de Santa Helena|peniques de Santa Helena" },
			{ "Dobra", "dobra|db|std" },
			{ "Dinar serbio", "dinar serbio|dinares serbios|rsd" },
			{ "Para serbio", "para serbio|para serbios" },
			{ "Rupia de Seychelles", "rupia de Seychelles|rupias de Seychelles|scr" },
			{ "Centavo de Seychelles", "centavo de Seychelles|centavos de Seychelles" },
			{ "Leone", "leone|le|sll" },
			{ "Dólar de Singapur", "dólar de singapur|dólares de singapur|sgb" },
			{ "Centavo de Singapur", "centavo de Singapur|centavos de Singapur" },
			{ "Libra siria", "libra siria|libras sirias|s£|syp" },
			{ "Piastra siria", "piastra siria|piastras sirias" },
			{ "Chelín somalí", "chelín somalí|chelines somalies|sos" },
			{ "Centavo somalí", "centavo somalí|centavos somalies" },
			{ "Chelín somalilandés", "chelín somalilandés|chelines somalilandeses" },
			{ "Centavo somalilandés", "centavo somalilandés|centavos somalilandeses" },
			{ "Rupia de Sri Lanka", "rupia de Sri Lanka|rupias de Sri Lanka|lkr" },
			{ "Céntimo de Sri Lanka", "céntimo de Sri Lanka|céntimos de Sri Lanka" },
			{ "Lilangeni", "lilangeni|emalangeni|szl" },
			{ "Rand sudafricano", "rand|rand sudafricano|zar" },
			{ "Libra sudanesa", "libra sudanesa|libras sudanesas|sdg" },
			{ "Piastra sudanesa", "piastra sudanesa|piastras sudanesas" },
			{ "Libra sursudanesa", "libra sursudanesa|libras sursudanesa|ssp" },
			{ "Piastra sursudanesa", "piastra sursudanesa|piastras sursudanesas" },
			{ "Corona sueca", "corona sueca|coronas suecas|sek" },
			{ "Franco suizo", "franco suizo|francos suizos|sfr|chf" },
			{ "Rappen suizo", "rappen suizo|rappens suizos" },
			{ "Dólar surinamés", "óolar surinamés|dólares surinameses|srd" },
			{ "Centavo surinamés", "centavo surinamés|centavos surinamés" },
			{ "Baht tailandés", "baht tailandés|baht tailandeses|thb" },
			{ "Satang tailandés", "satang tailandés|satang tailandeses" },
			{ "Nuevo dólar taiwanés", "nuevo dólar taiwanés|dólar taiwanés|dólares taiwaneses|twd" },
			{ "Centavo taiwanés", "centavo taiwanés|centavos taiwaneses" },
			{ "Chelín tanzano", "chelín tanzano|chelines tanzanos|tzs" },
			{ "Centavo tanzano", "centavo tanzano|centavos tanzanos" },
			{ "Somoni tayiko", "somoni tayiko|somoni|tjs" },
			{ "Diram", "diram|dirams" },
			{ "Paʻanga", "dólar tongano|dólares tonganos|paʻanga|pa'anga|top" },
			{ "Seniti", "seniti" },
			{ "Rublo de Transnistria", "rublo de Transnistria|rublos de Transnistria" },
			{ "Kopek de Transnistria", "kopek de Transnistria|kopeks de Transnistria" },
			{ "Dólar trinitense", "dólar trinitense|dólares trinitenses|ttd" },
			{ "Centavo trinitense", "centavo trinitense|centavos trinitenses" },
			{ "Dinar tunecino", "dinar tunecino|dinares tunecinos|tnd" },
			{ "Millime tunecino", "millime tunecino|millimes tunecinos" },
			{ "Lira turca", "lira turca|liras turcas|try" },
			{ "Kuruş turca", "kuruş turca|kuruş turcas" },
			{ "Manat turkmeno", "manat turkmeno|manat turkmenos|tmt" },
			{ "Tennesi turkmeno", "tennesi turkmeno|tenge turkmeno" },
			{ "Dólar tuvaluano", "dólar tuvaluano|dólares tuvaluanos" },
			{ "Centavo tuvaluano", "centavo tuvaluano|centavos tuvaluanos" },
			{ "Grivna", "grivna|grivnas|uah" },
			{ "Kopiyka", "kopiyka|kópeks" },
			{ "Chelín ugandés", "chelín ugandés|chelines ugandeses|ugx" },
			{ "Centavo ugandés", "centavo ugandés|centavos ugandeses" },
			{ "Peso uruguayo", "peso uruguayo|pesos uruguayos|uyu" },
			{ "Centésimo uruguayo", "centésimo uruguayo|centésimos uruguayos" },
			{ "Som uzbeko", "som uzbeko|som uzbekos|uzs" },
			{ "Tiyin uzbeko", "tiyin uzbeko|tiyin uzbekos" },
			{ "Vatu", "vatu|vuv" },
			{ "Bolívar fuerte", "bolívar fuerte|bolívar|bolívares|vef" },
			{ "Céntimo de bolívar", "céntimo de bolívar|céntimos de bolívar" },
			{ "Đồng vietnamita", "Đồng vietnamita|dong vietnamita|dong vietnamitas|vnd" },
			{ "Hào vietnamita", "Hào vietnamita|hao vietnamita|hao vietnamitas" },
			{ "Rial yemení", "rial yemení|riales yemenies|yer" },
			{ "Fils yemení", "fils yemení|fils yemenies" },
			{ "Franco yibutiano", "franco yibutiano|francos yibutianos|djf" },
			{ "Dinar yugoslavo", "dinar yugoslavo|dinares yugoslavos|yud" },
			{ "Kwacha zambiano", "kwacha zambiano|kwacha zambianos|zmw" },
			{ "Ngwee zambiano", "ngwee zambiano|ngwee zambianos" }
		};
		public static readonly Dictionary<string, string> CurrencyPrefixList = new Dictionary<string, string>
		{
			{ "Dólar", "$" },
			{ "Dólar estadounidense", "us$|u$d|usd" },
			{ "Dólar del Caribe Oriental", "ec$|xcd" },
			{ "Dólar australiano", "a$|aud" },
			{ "Dólar bahameño", "b$|bsd" },
			{ "Dólar de Barbados", "bds$|bbd" },
			{ "Dólar beliceño", "bz$|bzd" },
			{ "Dólar bermudeño", "bd$|bmd" },
			{ "Dólar de Brunéi", "brunéi $|bnd" },
			{ "Dólar de Singapur", "s$|sgd" },
			{ "Dólar canadiense", "c$|can$|cad" },
			{ "Dólar de las Islas Caimán", "ci$|kyd" },
			{ "Dólar neozelandés", "nz$|nzd" },
			{ "Dólar fiyiano", "fj$|fjd" },
			{ "Dólar guyanés", "gy$|gyd" },
			{ "Dólar de Hong Kong", "hk$|hkd" },
			{ "Dólar jamaiquino", "j$|ja$|jmd" },
			{ "Dólar liberiano", "l$|lrd" },
			{ "Dólar namibio", "n$|nad" },
			{ "Dólar de las Islas Salomón", "si$|sbd" },
			{ "Nuevo dólar taiwanés", "nt$|twd" },
			{ "Real brasileño", "r$|brl" },
			{ "Guaraní", "₲|gs.|pyg" },
			{ "Dólar trinitense", "tt$|ttd" },
			{ "Yuan chino", "￥|cny|rmb" },
			{ "Yen", "¥|jpy" },
			{ "Euro", "€|eur" },
			{ "Florín", "ƒ" },
			{ "Libra", "£|gbp" },
			{ "Colón costarricense", "₡" },
			{ "Lira turca", "₺" }
		};
		public static readonly IList<string> AmbiguousCurrencyUnitList = new List<string>
		{
			"le"
		};
		public static readonly Dictionary<string, string> DimensionSuffixList = new Dictionary<string, string>
		{
			{ "Kilómetro", "km|kilometro|kilómetro|kilometros|kilómetros" },
			{ "Hectómetro", "hm|hectometro|hectómetro|hectometros|hectómetros" },
			{ "Decámetro", "decametro|decámetro|decametros|decámetros|dam" },
			{ "Metro", "m|m.|metro|metros" },
			{ "Decímetro", "dm|decimetro|decímetro|decimetros|decímetros" },
			{ "Centímetro", "cm|centimetro|centímetro|centimetros|centimetros" },
			{ "Milímetro", "mm|milimetro|milímetro|milimetros|milímetros" },
			{ "Micrómetro", "µm|um|micrometro|micrómetro|micrometros|micrómetros|micrón|micrónes" },
			{ "Nanómetro", "nm|nanometro|nanómetro|nanometros|nanómetros" },
			{ "Picómetro", "pm|picometro|picómetro|picometros|picometros" },
			{ "Milla", "mi|milla|millas" },
			{ "Yarda", "yd|yarda|yardas" },
			{ "Pulgada", "pulgada|pulgadas|\"" },
			{ "Pie", "pie|pies|ft" },
			{ "Año luz", "año luz|años luz|al" },
			{ "Metro por segundo", "metro/segundo|m/s|metro por segundo|metros por segundo|metros por segundos" },
			{ "Kilómetro por hora", "km/h|kilómetro por hora|kilometro por hora|kilómetros por hora|kilometros por hora|kilómetro/hora|kilometro/hora|kilómetros/hora|kilometros/hora" },
			{ "Kilómetro por minuto", "km/min|kilómetro por minuto|kilometro por minuto|kilómetros por minuto|kilometros por minuto|kilómetro/minuto|kilometro/minuto|kilómetros/minuto|kilometros/minuto" },
			{ "Kilómetro por segundo", "km/seg|kilómetro por segundo|kilometro por segundo|kilómetros por segundo|kilometros por segundo|kilómetro/segundo|kilometro/segundo|kilómetros/segundo|kilometros/segundo" },
			{ "Milla por hora", "mph|milla por hora|mi/h|milla/hora|millas/hora|millas por hora" },
			{ "Nudo", "kt|nudo|nudos|kn" },
			{ "Pie por segundo", "ft/s|pie/s|ft/seg|pie/seg|pie por segundo|pies por segundo" },
			{ "Pie por minuto", "ft/min|pie/min|pie por minuto|pies por minuto" },
			{ "Yarda por minuto", "yardas por minuto|yardas/minuto|yardas/min" },
			{ "Yarda por segundo", "yardas por segundo|yardas/segundo|yardas/seg" },
			{ "Kilómetro cuadrado", "kilómetro cuadrado|kilómetros cuadrados|km2|km^2|km²" },
			{ "Hectómetro cuadrado", "hectómetro cuadrado|hectómetros cuadrados|hm2|hm^2|hm²|hectárea|hectáreas" },
			{ "Decámetro cuadrado", "decámetro cuadrado|decámetros cuadrados|dam2|dam^2|dam²|área|áreas" },
			{ "Metro cuadrado", "metro cuadrado|metros cuadrados|m2|m^2|m²" },
			{ "Decímetro cuadrado", "decímetro cuadrado|decímetros cuadrados|dm2|dm^2|dm²" },
			{ "Centímetro cuadrado", "centímetro cuadrado|centímetros cuadrados|cm2|cm^2|cm²" },
			{ "Milímetro cuadrado", "milímetro cuadrado|milímetros cuadrados|mm2|mm^2|mm²" },
			{ "Pulgada cuadrado", "pulgada cuadrada|pulgadas cuadradas" },
			{ "Pie cuadrado", "pie cuadrado|pies cuadrados|pie2|pie^2|pie²|ft2|ft^2|ft²" },
			{ "Yarda cuadrado", "yarda cuadrada|yardas cuadradas|yd2|yd^2|yd²" },
			{ "Acre", "acre|acres" },
			{ "Kilómetro cúbico", "kilómetro cúbico|kilómetros cúbico|km3|km^3|km³" },
			{ "Hectómetro cúbico", "hectómetro cúbico|hectómetros cúbico|hm3|hm^3|hm³" },
			{ "Decámetro cúbico", "decámetro cúbico|decámetros cúbico|dam3|dam^3|dam³" },
			{ "Metro cúbico", "metro cúbico|metros cúbico|m3|m^3|m³" },
			{ "Decímetro cúbico", "decímetro cúbico|decímetros cúbico|dm3|dm^3|dm³" },
			{ "Centímetro cúbico", "centímetro cúbico|centímetros cúbico|cc|cm3|cm^3|cm³" },
			{ "Milímetro cúbico", "milímetro cúbico|milímetros cúbico|mm3|mm^3|mm³" },
			{ "Pulgada cúbica", "pulgada cúbics|pulgadas cúbicas" },
			{ "Pie cúbico", "pie cúbico|pies cúbicos|pie3|pie^3|pie³|ft3|ft^3|ft³" },
			{ "Yarda cúbica", "yarda cúbica|yardas cúbicas|yd3|yd^3|yd³" },
			{ "Hectolitro", "hectolitro|hectolitros|hl" },
			{ "Litro", "litro|litros|lts|l" },
			{ "Mililitro", "mililitro|mililitros|ml" },
			{ "Galón", "galón|galones" },
			{ "Pinta", "pinta|pintas" },
			{ "Barril", "barril|barriles" },
			{ "Onza líquida", "onza líquida|onzas líquidas" },
			{ "Tonelada métrica", "tonelada métrica|toneladas métricas" },
			{ "Tonelada", "ton|tonelada|toneladas" },
			{ "Kilogramo", "kg|kilogramo|kilogramos" },
			{ "Hectogramo", "hg|hectogramo|hectogramos" },
			{ "Decagramo", "dag|decagramo|decagramos" },
			{ "Gramo", "g|gr|gramo|gramos" },
			{ "Decigramo", "dg|decigramo|decigramos" },
			{ "Centigramo", "cg|centigramo|centigramos" },
			{ "Miligramo", "mg|miligramo|miligramos" },
			{ "Microgramo", "µg|ug|microgramo|microgramos" },
			{ "Nanogramo", "ng|nanogramo|nanogramos" },
			{ "Picogramo", "pg|picogramo|picogramos" },
			{ "Libra", "lb|libra|libras" },
			{ "Onza", "oz|onza|onzas" },
			{ "Grano", "grano|granos" },
			{ "Quilate", "ct|kt|quilate|quilates" },
			{ "bit", "bit|bits" },
			{ "kilobit", "kilobit|kilobits|kb|kbit" },
			{ "megabit", "megabit|megabits|Mb|Mbit" },
			{ "gigabit", "gigabit|gigabits|Gb|Gbit" },
			{ "terabit", "terabit|terabits|Tb|Tbit" },
			{ "petabit", "petabit|petabits|Pb|Pbit" },
			{ "kibibit", "kibibit|kibibits|kib|kibit" },
			{ "mebibit", "mebibit|mebibits|Mib|Mibit" },
			{ "gibibit", "gibibit|gibibits|Gib|Gibit" },
			{ "tebibit", "tebibit|tebibits|Tib|Tibit" },
			{ "pebibit", "pebibit|pebibits|Pib|Pibit" },
			{ "byte", "byte|bytes" },
			{ "kilobyte", "kilobyte|kilobytes|kB|kByte" },
			{ "megabyte", "megabyte|megabytes|MB|MByte" },
			{ "gigabyte", "gigabyte|gigabytes|GB|GByte" },
			{ "terabyte", "terabyte|terabytes|TB|TByte" },
			{ "petabyte", "petabyte|petabytes|PB|PByte" },
			{ "kibibyte", "kibibyte|kibibytes|kiB|kiByte" },
			{ "mebibyte", "mebibyte|mebibytes|MiB|MiByte" },
			{ "gibibyte", "gibibyte|gibibytes|GiB|GiByte" },
			{ "tebibyte", "tebibyte|tebibytes|TiB|TiByte" },
			{ "pebibyte", "pebibyte|pebibytes|PiB|PiByte" }
		};
		public static readonly IList<string> AmbiguousDimensionUnitList = new List<string>
		{
			"al",
			"mi",
			"área",
			"áreas",
			"pie",
			"pies"
		};
		public static readonly Dictionary<string, string> LengthSuffixList = new Dictionary<string, string>
		{
			{ "Kilómetro", "km|kilometro|kilómetro|kilometros|kilómetros" },
			{ "Hectómetro", "hm|hectometro|hectómetro|hectometros|hectómetros" },
			{ "Decámetro", "decametro|decámetro|decametros|decámetros|dam" },
			{ "Metro", "m|m.|metro|metros" },
			{ "Decímetro", "dm|decimetro|decímetro|decimetros|decímetros" },
			{ "Centímetro", "cm|centimetro|centímetro|centimetros|centimetros" },
			{ "Milímetro", "mm|milimetro|milímetro|milimetros|milímetros" },
			{ "Micrómetro", "µm|um|micrometro|micrómetro|micrometros|micrómetros|micrón|micrónes" },
			{ "Nanómetro", "nm|nanometro|nanómetro|nanometros|nanómetros" },
			{ "Picómetro", "pm|picometro|picómetro|picometros|picómetros" },
			{ "Milla", "mi|milla|millas" },
			{ "Yarda", "yd|yarda|yardas" },
			{ "Pulgada", "pulgada|pulgadas|\"" },
			{ "Pie", "pie|pies|ft" },
			{ "Año luz", "año luz|años luz|al" }
		};
		public static readonly IList<string> AmbiguousLengthUnitList = new List<string>
		{
			"mi",
			"área",
			"áreas"
		};
		public const string BuildPrefix = @"(?<=(\s|^|\W))";
		public const string BuildSuffix = @"(?=(\s|\W|$))";
		public const string ConnectorToken = "de";
		public static readonly Dictionary<string, string> SpeedSuffixList = new Dictionary<string, string>
		{
			{ "Metro por segundo", "metro/segundo|m/s|metro por segundo|metros por segundo|metros por segundos" },
			{ "Kilómetro por hora", "km/h|kilómetro por hora|kilometro por hora|kilómetros por hora|kilometros por hora|kilómetro/hora|kilometro/hora|kilómetros/hora|kilometros/hora" },
			{ "Kilómetro por minuto", "km/min|kilómetro por minuto|kilometro por minuto|kilómetros por minuto|kilometros por minuto|kilómetro/minuto|kilometro/minuto|kilómetros/minuto|kilometros/minuto" },
			{ "Kilómetro por segundo", "km/seg|kilómetro por segundo|kilometro por segundo|kilómetros por segundo|kilometros por segundo|kilómetro/segundo|kilometro/segundo|kilómetros/segundo|kilometros/segundo" },
			{ "Milla por hora", "mph|milla por hora|mi/h|milla/hora|millas/hora|millas por hora" },
			{ "Nudo", "kt|nudo|nudos|kn" },
			{ "Pie por segundo", "ft/s|pie/s|ft/seg|pie/seg|pie por segundo|pies por segundo" },
			{ "Pie por minuto", "ft/min|pie/min|pie por minuto|pies por minuto" },
			{ "Yarda por minuto", "yardas por minuto|yardas/minuto|yardas/min" },
			{ "Yarda por segundo", "yardas por segundo|yardas/segundo|yardas/seg" }
		};
		public static readonly IList<string> AmbiguousSpeedUnitList = new List<string>
		{
			"nudo",
			"nudos"
		};
		public static readonly Dictionary<string, string> TemperatureSuffixList = new Dictionary<string, string>
		{
			{ "Kelvin", "k|kelvin" },
			{ "Rankine", "r|rankine" },
			{ "Grado Celsius", "°c|grados c|grado celsius|grados celsius|celsius|grado centígrado|grados centígrados|centígrado|centígrados" },
			{ "Grado Fahrenheit", "°f|grados f|grado fahrenheit|grados fahrenheit|fahrenheit" },
			{ "Grado Réaumur", "°r|°re|grados r|grado réaumur|grados réaumur|réaumur" },
			{ "Grado Delisle", "°d|grados d|grado delisle|grados delisle|delisle" },
			{ "Grado", "°|grados|grado" }
		};
		public static readonly Dictionary<string, string> VolumeSuffixList = new Dictionary<string, string>
		{
			{ "Kilómetro cúbico", "kilómetro cúbico|kilómetros cúbico|km3|km^3|km³" },
			{ "Hectómetro cúbico", "hectómetro cúbico|hectómetros cúbico|hm3|hm^3|hm³" },
			{ "Decámetro cúbico", "decámetro cúbico|decámetros cúbico|dam3|dam^3|dam³" },
			{ "Metro cúbico", "metro cúbico|metros cúbico|m3|m^3|m³" },
			{ "Decímetro cúbico", "decímetro cúbico|decímetros cúbico|dm3|dm^3|dm³" },
			{ "Centímetro cúbico", "centímetro cúbico|centímetros cúbico|cc|cm3|cm^3|cm³" },
			{ "Milímetro cúbico", "milímetro cúbico|milímetros cúbico|mm3|mm^3|mm³" },
			{ "Pulgada cúbica", "pulgada cúbica|pulgadas cúbicas" },
			{ "Pie cúbico", "pie cúbico|pies cúbicos|pie3|pie^3|pie³|ft3|ft^3|ft³" },
			{ "Yarda cúbica", "yarda cúbica|yardas cúbicas|yd3|yd^3|yd³" },
			{ "Hectolitro", "hectolitro|hectolitros|hl" },
			{ "Litro", "litro|litros|lts|l" },
			{ "Mililitro", "mililitro|mililitros|ml" },
			{ "Galón", "galón|galones" },
			{ "Pinta", "pinta|pintas" },
			{ "Barril", "barril|barriles|bbl" },
			{ "Onza líquida", "onza líquida|onzas líquidas" }
		};
		public static readonly Dictionary<string, string> WeightSuffixList = new Dictionary<string, string>
		{
			{ "Tonelada métrica", "tonelada métrica|toneladas métricas" },
			{ "Tonelada", "ton|tonelada|toneladas" },
			{ "Kilogramo", "kg|kilogramo|kilogramos" },
			{ "Hectogramo", "hg|hectogramo|hectogramos" },
			{ "Decagramo", "dag|decagramo|decagramos" },
			{ "Gramo", "g|gr|gramo|gramos" },
			{ "Decigramo", "dg|decigramo|decigramos" },
			{ "Centigramo", "cg|centigramo|centigramos" },
			{ "Miligramo", "mg|miligramo|miligramos" },
			{ "Microgramo", "µg|ug|microgramo|microgramos" },
			{ "Nanogramo", "ng|nanogramo|nanogramos" },
			{ "Picogramo", "pg|picogramo|picogramos" },
			{ "Libra", "lb|libra|libras" },
			{ "Onza", "oz|onza|onzas" },
			{ "Grano", "grano|granos|gr" },
			{ "Quilate", "ct|kt|quilate|quilates" }
		};
	}
}