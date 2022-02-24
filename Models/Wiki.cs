using Pokedex.Models.Pokemons;
using System.Collections.Generic;

namespace Pokedex.Models
{
    internal class Wiki
    {
        #nullable enable
        private static Dictionary<int, Pokemon?>
        #nullable restore
         _pokemons;
        #nullable enable
        private static Wiki? _instance = null;
        public static Wiki Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Wiki();
                }
                return _instance;
            }
        }

        public Dictionary<int, Pokemon?> Pokemons
        { get { return _pokemons; } } 

        public Wiki()
        {

            _pokemons = new Dictionary<int, Pokemon?>()
            {
				{ 1,		new Bulbasaur() },
{ 2,		new Ivysaur() },
{ 3,		new Venusaur() },
{ 4,		new Charmander() },
{ 5,		new Charmeleon() },
{ 6,		new Charizard() },
{ 7,		new Squirtle() },
{ 8,		new Wartortle() },
{ 9,		new Blastoise() },
{ 10,		new Caterpie() },
{ 11,		new Metapod() },
{ 12,		new Butterfree() },
{ 13,		new Weedle() },
{ 14,		new Kakuna() },
{ 15,		new Beedrill() },
{ 16,		new Pidgey() },
{ 17,		new Pidgeotto() },
{ 18,		new Pidgeot() },
{ 19,		new Rattata() },
{ 20,		new Raticate() },
{ 21,		new Spearow() },
{ 22,		new Fearow() },
{ 23,		new Ekans() },
{ 24,		new Arbok() },
{ 25,		new Pikachu() },
{ 26,		new Raichu() },
{ 27,		new Sandshrew() },
{ 28,		new Sandslash() },
{ 29,		new NidoranF() },
{ 30,		new Nidorina() },
{ 31,		new Nidoqueen() },
{ 32,		new NidoranM() },
{ 33,		new Nidorino() },
{ 34,		new Nidoking() },
{ 35,		new Clefairy() },
{ 36,		new Clefable() },
{ 37,		new Vulpix() },
{ 38,		new Ninetales() },
{ 39,		new Jigglypuff() },
{ 40,		new Wigglytuff() },
{ 41,		new Zubat() },
{ 42,		new Golbat() },
{ 43,		new Oddish() },
{ 44,		new Gloom() },
{ 45,		new Vileplume() },
{ 46,		new Paras() },
{ 47,		new Parasect() },
{ 48,		new Venonat() },
{ 49,		new Venomoth() },
{ 50,		new Diglett() },
{ 51,		new Dugtrio() },
{ 52,		new Meowth() },
{ 53,		new Persian() },
{ 54,		new Psyduck() },
{ 55,		new Golduck() },
{ 56,		new Mankey() },
{ 57,		new Primeape() },
{ 58,		new Growlithe() },
{ 59,		new Arcanine() },
{ 60,		new Poliwag() },
{ 61,		new Poliwhirl() },
{ 62,		new Poliwrath() },
{ 63,		new Abra() },
{ 64,		new Kadabra() },
{ 65,		new Alakazam() },
{ 66,		new Machop() },
{ 67,		new Machoke() },
{ 68,		new Machamp() },
{ 69,		new Bellsprout() },
{ 70,		new Weepinbell() },
{ 71,		new Victreebel() },
{ 72,		new Tentacool() },
{ 73,		new Tentacruel() },
{ 74,		new Geodude() },
{ 75,		new Graveler() },
{ 76,		new Golem() },
{ 77,		new Ponyta() },
{ 78,		new Rapidash() },
{ 79,		new Slowpoke() },
{ 80,		new Slowbro() },
{ 81,		new Magnemite() },
{ 82,		new Magneton() },
{ 83,		new Farfetchd() },
{ 84,		new Doduo() },
{ 85,		new Dodrio() },
{ 86,		new Seel() },
{ 87,		new Dewgong() },
{ 88,		new Grimer() },
{ 89,		new Muk() },
{ 90,		new Shellder() },
{ 91,		new Cloyster() },
{ 92,		new Gastly() },
{ 93,		new Haunter() },
{ 94,		new Gengar() },
{ 95,		new Onix() },
{ 96,		new Drowzee() },
{ 97,		new Hypno() },
{ 98,		new Krabby() },
{ 99,		new Kingler() },
{ 100,		new Voltorb() },
{ 101,		new Electrode() },
{ 102,		new Exeggcute() },
{ 103,		new Exeggutor() },
{ 104,		new Cubone() },
{ 105,		new Marowak() },
{ 106,		new Hitmonlee() },
{ 107,		new Hitmonchan() },
{ 108,		new Lickitung() },
{ 109,		new Koffing() },
{ 110,		new Weezing() },
{ 111,		new Rhyhorn() },
{ 112,		new Rhydon() },
{ 113,		new Chansey() },
{ 114,		new Tangela() },
{ 115,		new Kangaskhan() },
{ 116,		new Horsea() },
{ 117,		new Seadra() },
{ 118,		new Goldeen() },
{ 119,		new Seaking() },
{ 120,		new Staryu() },
{ 121,		new Starmie() },
{ 122,		new MrMime() },
{ 123,		new Scyther() },
{ 124,		new Jynx() },
{ 125,		new Electabuzz() },
{ 126,		new Magmar() },
{ 127,		new Pinsir() },
{ 128,		new Tauros() },
{ 129,		new Magikarp() },
{ 130,		new Gyarados() },
{ 131,		new Lapras() },
{ 132,		new Ditto() },
{ 133,		new Eevee() },
{ 134,		new Vaporeon() },
{ 135,		new Jolteon() },
{ 136,		new Flareon() },
{ 137,		new Porygon() },
{ 138,		new Omanyte() },
{ 139,		new Omastar() },
{ 140,		new Kabuto() },
{ 141,		new Kabutops() },
{ 142,		new Aerodactyl() },
{ 143,		new Snorlax() },
{ 144,		new Articuno() },
{ 145,		new Zapdos() },
{ 146,		new Moltres() },
{ 147,		new Dratini() },
{ 148,		new Dragonair() },
{ 149,		new Dragonite() },
{ 150,		new Mewtwo() },
{ 151,		new Mew() },
{ 152,		new Chikorita() },
{ 153,		new Bayleef() },
{ 154,		new Meganium() },
{ 155,		new Cyndaquil() },
{ 156,		new Quilava() },
{ 157,		new Typhlosion() },
{ 158,		new Totodile() },
{ 159,		new Croconaw() },
{ 160,		new Feraligatr() },
{ 161,		new Sentret() },
{ 162,		new Furret() },
{ 163,		new Hoothoot() },
{ 164,		new Noctowl() },
{ 165,		new Ledyba() },
{ 166,		new Ledian() },
{ 167,		new Spinarak() },
{ 168,		new Ariados() },
{ 169,		new Crobat() },
{ 170,		new Chinchou() },
{ 171,		new Lanturn() },
{ 172,		new Pichu() },
{ 173,		new Cleffa() },
{ 174,		new Igglybuff() },
{ 175,		new Togepi() },
{ 176,		new Togetic() },
{ 177,		new Natu() },
{ 178,		new Xatu() },
{ 179,		new Mareep() },
{ 180,		new Flaaffy() },
{ 181,		new Ampharos() },
{ 182,		new Bellossom() },
{ 183,		new Marill() },
{ 184,		new Azumarill() },
{ 185,		new Sudowoodo() },
{ 186,		new Politoed() },
{ 187,		new Hoppip() },
{ 188,		new Skiploom() },
{ 189,		new Jumpluff() },
{ 190,		new Aipom() },
{ 191,		new Sunkern() },
{ 192,		new Sunflora() },
{ 193,		new Yanma() },
{ 194,		new Wooper() },
{ 195,		new Quagsire() },
{ 196,		new Espeon() },
{ 197,		new Umbreon() },
{ 198,		new Murkrow() },
{ 199,		new Slowking() },
{ 200,		new Misdreavus() },
{ 201,		new Unown() },
{ 202,		new Wobbuffet() },
{ 203,		new Girafarig() },
{ 204,		new Pineco() },
{ 205,		new Forretress() },
{ 206,		new Dunsparce() },
{ 207,		new Gligar() },
{ 208,		new Steelix() },
{ 209,		new Snubbull() },
{ 210,		new Granbull() },
{ 211,		new Qwilfish() },
{ 212,		new Scizor() },
{ 213,		new Shuckle() },
{ 214,		new Heracross() },
{ 215,		new Sneasel() },
{ 216,		new Teddiursa() },
{ 217,		new Ursaring() },
{ 218,		new Slugma() },
{ 219,		new Magcargo() },
{ 220,		new Swinub() },
{ 221,		new Piloswine() },
{ 222,		new Corsola() },
{ 223,		new Remoraid() },
{ 224,		new Octillery() },
{ 225,		new Delibird() },
{ 226,		new Mantine() },
{ 227,		new Skarmory() },
{ 228,		new Houndour() },
{ 229,		new Houndoom() },
{ 230,		new Kingdra() },
{ 231,		new Phanpy() },
{ 232,		new Donphan() },
{ 233,		new Porygon2() },
{ 234,		new Stantler() },
{ 235,		new Smeargle() },
{ 236,		new Tyrogue() },
{ 237,		new Hitmontop() },
{ 238,		new Smoochum() },
{ 239,		new Elekid() },
{ 240,		new Magby() },
{ 241,		new Miltank() },
{ 242,		new Blissey() },
{ 243,		new Raikou() },
{ 244,		new Entei() },
{ 245,		new Suicune() },
{ 246,		new Larvitar() },
{ 247,		new Pupitar() },
{ 248,		new Tyranitar() },
{ 249,		new Lugia() },
{ 250,		new HoOh() },
{ 251,		new Celebi() },
{ 252,		new Treecko() },
{ 253,		new Grovyle() },
{ 254,		new Sceptile() },
{ 255,		new Torchic() },
{ 256,		new Combusken() },
{ 257,		new Blaziken() },
{ 258,		new Mudkip() },
{ 259,		new Marshtomp() },
{ 260,		new Swampert() },
{ 261,		new Poochyena() },
{ 262,		new Mightyena() },
{ 263,		new Zigzagoon() },
{ 264,		new Linoone() },
{ 265,		new Wurmple() },
{ 266,		new Silcoon() },
{ 267,		new Beautifly() },
{ 268,		new Cascoon() },
{ 269,		new Dustox() },
{ 270,		new Lotad() },
{ 271,		new Lombre() },
{ 272,		new Ludicolo() },
{ 273,		new Seedot() },
{ 274,		new Nuzleaf() },
{ 275,		new Shiftry() },
{ 276,		new Taillow() },
{ 277,		new Swellow() },
{ 278,		new Wingull() },
{ 279,		new Pelipper() },
{ 280,		new Ralts() },
{ 281,		new Kirlia() },
{ 282,		new Gardevoir() },
{ 283,		new Surskit() },
{ 284,		new Masquerain() },
{ 285,		new Shroomish() },
{ 286,		new Breloom() },
{ 287,		new Slakoth() },
{ 288,		new Vigoroth() },
{ 289,		new Slaking() },
{ 290,		new Nincada() },
{ 291,		new Ninjask() },
{ 292,		new Shedinja() },
{ 293,		new Whismur() },
{ 294,		new Loudred() },
{ 295,		new Exploud() },
{ 296,		new Makuhita() },
{ 297,		new Hariyama() },
{ 298,		new Azurill() },
{ 299,		new Nosepass() },
{ 300,		new Skitty() },
{ 301,		new Delcatty() },
{ 302,		new Sableye() },
{ 303,		new Mawile() },
{ 304,		new Aron() },
{ 305,		new Lairon() },
{ 306,		new Aggron() },
{ 307,		new Meditite() },
{ 308,		new Medicham() },
{ 309,		new Electrike() },
{ 310,		new Manectric() },
{ 311,		new Plusle() },
{ 312,		new Minun() },
{ 313,		new Volbeat() },
{ 314,		new Illumise() },
{ 315,		new Roselia() },
{ 316,		new Gulpin() },
{ 317,		new Swalot() },
{ 318,		new Carvanha() },
{ 319,		new Sharpedo() },
{ 320,		new Wailmer() },
{ 321,		new Wailord() },
{ 322,		new Numel() },
{ 323,		new Camerupt() },
{ 324,		new Torkoal() },
{ 325,		new Spoink() },
{ 326,		new Grumpig() },
{ 327,		new Spinda() },
{ 328,		new Trapinch() },
{ 329,		new Vibrava() },
{ 330,		new Flygon() },
{ 331,		new Cacnea() },
{ 332,		new Cacturne() },
{ 333,		new Swablu() },
{ 334,		new Altaria() },
{ 335,		new Zangoose() },
{ 336,		new Seviper() },
{ 337,		new Lunatone() },
{ 338,		new Solrock() },
{ 339,		new Barboach() },
{ 340,		new Whiscash() },
{ 341,		new Corphish() },
{ 342,		new Crawdaunt() },
{ 343,		new Baltoy() },
{ 344,		new Claydol() },
{ 345,		new Lileep() },
{ 346,		new Cradily() },
{ 347,		new Anorith() },
{ 348,		new Armaldo() },
{ 349,		new Feebas() },
{ 350,		new Milotic() },
{ 351,		new Castform() },
{ 352,		new Kecleon() },
{ 353,		new Shuppet() },
{ 354,		new Banette() },
{ 355,		new Duskull() },
{ 356,		new Dusclops() },
{ 357,		new Tropius() },
{ 358,		new Chimecho() },
{ 359,		new Absol() },
{ 360,		new Wynaut() },
{ 361,		new Snorunt() },
{ 362,		new Glalie() },
{ 363,		new Spheal() },
{ 364,		new Sealeo() },
{ 365,		new Walrein() },
{ 366,		new Clamperl() },
{ 367,		new Huntail() },
{ 368,		new Gorebyss() },
{ 369,		new Relicanth() },
{ 370,		new Luvdisc() },
{ 371,		new Bagon() },
{ 372,		new Shelgon() },
{ 373,		new Salamence() },
{ 374,		new Beldum() },
{ 375,		new Metang() },
{ 376,		new Metagross() },
{ 377,		new Regirock() },
{ 378,		new Regice() },
{ 379,		new Registeel() },
{ 380,		new Latias() },
{ 381,		new Latios() },
{ 382,		new Kyogre() },
{ 383,		new Groudon() },
{ 384,		new Rayquaza() },
{ 385,		new Jirachi() },
{ 386,		new DeoxysNormal() },
{ 387,		new Turtwig() },
{ 388,		new Grotle() },
{ 389,		new Torterra() },
{ 390,		new Chimchar() },
{ 391,		new Monferno() },
{ 392,		new Infernape() },
{ 393,		new Piplup() },
{ 394,		new Prinplup() },
{ 395,		new Empoleon() },
{ 396,		new Starly() },
{ 397,		new Staravia() },
{ 398,		new Staraptor() },
{ 399,		new Bidoof() },
{ 400,		new Bibarel() },
{ 401,		new Kricketot() },
{ 402,		new Kricketune() },
{ 403,		new Shinx() },
{ 404,		new Luxio() },
{ 405,		new Luxray() },
{ 406,		new Budew() },
{ 407,		new Roserade() },
{ 408,		new Cranidos() },
{ 409,		new Rampardos() },
{ 410,		new Shieldon() },
{ 411,		new Bastiodon() },
{ 412,		new Burmy() },
{ 413,		new WormadamPlant() },
{ 414,		new Mothim() },
{ 415,		new Combee() },
{ 416,		new Vespiquen() },
{ 417,		new Pachirisu() },
{ 418,		new Buizel() },
{ 419,		new Floatzel() },
{ 420,		new Cherubi() },
{ 421,		new Cherrim() },
{ 422,		new Shellos() },
{ 423,		new Gastrodon() },
{ 424,		new Ambipom() },
{ 425,		new Drifloon() },
{ 426,		new Drifblim() },
{ 427,		new Buneary() },
{ 428,		new Lopunny() },
{ 429,		new Mismagius() },
{ 430,		new Honchkrow() },
{ 431,		new Glameow() },
{ 432,		new Purugly() },
{ 433,		new Chingling() },
{ 434,		new Stunky() },
{ 435,		new Skuntank() },
{ 436,		new Bronzor() },
{ 437,		new Bronzong() },
{ 438,		new Bonsly() },
{ 439,		new MimeJr() },
{ 440,		new Happiny() },
{ 441,		new Chatot() },
{ 442,		new Spiritomb() },
{ 443,		new Gible() },
{ 444,		new Gabite() },
{ 445,		new Garchomp() },
{ 446,		new Munchlax() },
{ 447,		new Riolu() },
{ 448,		new Lucario() },
{ 449,		new Hippopotas() },
{ 450,		new Hippowdon() },
{ 451,		new Skorupi() },
{ 452,		new Drapion() },
{ 453,		new Croagunk() },
{ 454,		new Toxicroak() },
{ 455,		new Carnivine() },
{ 456,		new Finneon() },
{ 457,		new Lumineon() },
{ 458,		new Mantyke() },
{ 459,		new Snover() },
{ 460,		new Abomasnow() },
{ 461,		new Weavile() },
{ 462,		new Magnezone() },
{ 463,		new Lickilicky() },
{ 464,		new Rhyperior() },
{ 465,		new Tangrowth() },
{ 466,		new Electivire() },
{ 467,		new Magmortar() },
{ 468,		new Togekiss() },
{ 469,		new Yanmega() },
{ 470,		new Leafeon() },
{ 471,		new Glaceon() },
{ 472,		new Gliscor() },
{ 473,		new Mamoswine() },
{ 474,		new PorygonZ() },
{ 475,		new Gallade() },
{ 476,		new Probopass() },
{ 477,		new Dusknoir() },
{ 478,		new Froslass() },
{ 479,		new Rotom() },
{ 480,		new Uxie() },
{ 481,		new Mesprit() },
{ 482,		new Azelf() },
{ 483,		new Dialga() },
{ 484,		new Palkia() },
{ 485,		new Heatran() },
{ 486,		new Regigigas() },
{ 487,		new GiratinaAltered() },
{ 488,		new Cresselia() },
{ 489,		new Phione() },
{ 490,		new Manaphy() },
{ 491,		new Darkrai() },
{ 492,		new ShayminLand() },
{ 493,		new Arceus() },
{ 494,		new Victini() },
{ 495,		new Snivy() },
{ 496,		new Servine() },
{ 497,		new Serperior() },
{ 498,		new Tepig() },
{ 499,		new Pignite() },
{ 500,		new Emboar() },
{ 501,		new Oshawott() },
{ 502,		new Dewott() },
{ 503,		new Samurott() },
{ 504,		new Patrat() },
{ 505,		new Watchog() },
{ 506,		new Lillipup() },
{ 507,		new Herdier() },
{ 508,		new Stoutland() },
{ 509,		new Purrloin() },
{ 510,		new Liepard() },
{ 511,		new Pansage() },
{ 512,		new Simisage() },
{ 513,		new Pansear() },
{ 514,		new Simisear() },
{ 515,		new Panpour() },
{ 516,		new Simipour() },
{ 517,		new Munna() },
{ 518,		new Musharna() },
{ 519,		new Pidove() },
{ 520,		new Tranquill() },
{ 521,		new Unfezant() },
{ 522,		new Blitzle() },
{ 523,		new Zebstrika() },
{ 524,		new Roggenrola() },
{ 525,		new Boldore() },
{ 526,		new Gigalith() },
{ 527,		new Woobat() },
{ 528,		new Swoobat() },
{ 529,		new Drilbur() },
{ 530,		new Excadrill() },
{ 531,		new Audino() },
{ 532,		new Timburr() },
{ 533,		new Gurdurr() },
{ 534,		new Conkeldurr() },
{ 535,		new Tympole() },
{ 536,		new Palpitoad() },
{ 537,		new Seismitoad() },
{ 538,		new Throh() },
{ 539,		new Sawk() },
{ 540,		new Sewaddle() },
{ 541,		new Swadloon() },
{ 542,		new Leavanny() },
{ 543,		new Venipede() },
{ 544,		new Whirlipede() },
{ 545,		new Scolipede() },
{ 546,		new Cottonee() },
{ 547,		new Whimsicott() },
{ 548,		new Petilil() },
{ 549,		new Lilligant() },
{ 550,		new BasculinRedStriped() },
{ 551,		new Sandile() },
{ 552,		new Krokorok() },
{ 553,		new Krookodile() },
{ 554,		new Darumaka() },
{ 555,		new DarmanitanStandard() },
{ 556,		new Maractus() },
{ 557,		new Dwebble() },
{ 558,		new Crustle() },
{ 559,		new Scraggy() },
{ 560,		new Scrafty() },
{ 561,		new Sigilyph() },
{ 562,		new Yamask() },
{ 563,		new Cofagrigus() },
{ 564,		new Tirtouga() },
{ 565,		new Carracosta() },
{ 566,		new Archen() },
{ 567,		new Archeops() },
{ 568,		new Trubbish() },
{ 569,		new Garbodor() },
{ 570,		new Zorua() },
{ 571,		new Zoroark() },
{ 572,		new Minccino() },
{ 573,		new Cinccino() },
{ 574,		new Gothita() },
{ 575,		new Gothorita() },
{ 576,		new Gothitelle() },
{ 577,		new Solosis() },
{ 578,		new Duosion() },
{ 579,		new Reuniclus() },
{ 580,		new Ducklett() },
{ 581,		new Swanna() },
{ 582,		new Vanillite() },
{ 583,		new Vanillish() },
{ 584,		new Vanilluxe() },
{ 585,		new Deerling() },
{ 586,		new Sawsbuck() },
{ 587,		new Emolga() },
{ 588,		new Karrablast() },
{ 589,		new Escavalier() },
{ 590,		new Foongus() },
{ 591,		new Amoonguss() },
{ 592,		new Frillish() },
{ 593,		new Jellicent() },
{ 594,		new Alomomola() },
{ 595,		new Joltik() },
{ 596,		new Galvantula() },
{ 597,		new Ferroseed() },
{ 598,		new Ferrothorn() },
{ 599,		new Klink() },
{ 600,		new Klang() },
{ 601,		new Klinklang() },
{ 602,		new Tynamo() },
{ 603,		new Eelektrik() },
{ 604,		new Eelektross() },
{ 605,		new Elgyem() },
{ 606,		new Beheeyem() },
{ 607,		new Litwick() },
{ 608,		new Lampent() },
{ 609,		new Chandelure() },
{ 610,		new Axew() },
{ 611,		new Fraxure() },
{ 612,		new Haxorus() },
{ 613,		new Cubchoo() },
{ 614,		new Beartic() },
{ 615,		new Cryogonal() },
{ 616,		new Shelmet() },
{ 617,		new Accelgor() },
{ 618,		new Stunfisk() },
{ 619,		new Mienfoo() },
{ 620,		new Mienshao() },
{ 621,		new Druddigon() },
{ 622,		new Golett() },
{ 623,		new Golurk() },
{ 624,		new Pawniard() },
{ 625,		new Bisharp() },
{ 626,		new Bouffalant() },
{ 627,		new Rufflet() },
{ 628,		new Braviary() },
{ 629,		new Vullaby() },
{ 630,		new Mandibuzz() },
{ 631,		new Heatmor() },
{ 632,		new Durant() },
{ 633,		new Deino() },
{ 634,		new Zweilous() },
{ 635,		new Hydreigon() },
{ 636,		new Larvesta() },
{ 637,		new Volcarona() },
{ 638,		new Cobalion() },
{ 639,		new Terrakion() },
{ 640,		new Virizion() },
{ 641,		new TornadusIncarnate() },
{ 642,		new ThundurusIncarnate() },
{ 643,		new Reshiram() },
{ 644,		new Zekrom() },
{ 645,		new LandorusIncarnate() },
{ 646,		new Kyurem() },
{ 647,		new KeldeoOrdinary() },
{ 648,		new MeloettaAria() },
{ 649,		new Genesect() },
{ 650,		new Chespin() },
{ 651,		new Quilladin() },
{ 652,		new Chesnaught() },
{ 653,		new Fennekin() },
{ 654,		new Braixen() },
{ 655,		new Delphox() },
{ 656,		new Froakie() },
{ 657,		new Frogadier() },
{ 658,		new Greninja() },
{ 659,		new Bunnelby() },
{ 660,		new Diggersby() },
{ 661,		new Fletchling() },
{ 662,		new Fletchinder() },
{ 663,		new Talonflame() },
{ 664,		new Scatterbug() },
{ 665,		new Spewpa() },
{ 666,		new Vivillon() },
{ 667,		new Litleo() },
{ 668,		new Pyroar() },
{ 669,		new Flabebe() },
{ 670,		new Floette() },
{ 671,		new Florges() },
{ 672,		new Skiddo() },
{ 673,		new Gogoat() },
{ 674,		new Pancham() },
{ 675,		new Pangoro() },
{ 676,		new Furfrou() },
{ 677,		new Espurr() },
{ 678,		new MeowsticMale() },
{ 679,		new Honedge() },
{ 680,		new Doublade() },
{ 681,		new AegislashShield() },
{ 682,		new Spritzee() },
{ 683,		new Aromatisse() },
{ 684,		new Swirlix() },
{ 685,		new Slurpuff() },
{ 686,		new Inkay() },
{ 687,		new Malamar() },
{ 688,		new Binacle() },
{ 689,		new Barbaracle() },
{ 690,		new Skrelp() },
{ 691,		new Dragalge() },
{ 692,		new Clauncher() },
{ 693,		new Clawitzer() },
{ 694,		new Helioptile() },
{ 695,		new Heliolisk() },
{ 696,		new Tyrunt() },
{ 697,		new Tyrantrum() },
{ 698,		new Amaura() },
{ 699,		new Aurorus() },
{ 700,		new Sylveon() },
{ 701,		new Hawlucha() },
{ 702,		new Dedenne() },
{ 703,		new Carbink() },
{ 704,		new Goomy() },
{ 705,		new Sliggoo() },
{ 706,		new Goodra() },
{ 707,		new Klefki() },
{ 708,		new Phantump() },
{ 709,		new Trevenant() },
{ 710,		new PumpkabooAverage() },
{ 711,		new GourgeistAverage() },
{ 712,		new Bergmite() },
{ 713,		new Avalugg() },
{ 714,		new Noibat() },
{ 715,		new Noivern() },
{ 716,		new Xerneas() },
{ 717,		new Yveltal() },
{ 718,		new Zygarde() },
{ 719,		new Diancie() },
{ 720,		new Hoopa() },
{ 721,		new Volcanion() },
{ 722,		new Rowlet() },
{ 723,		new Dartrix() },
{ 724,		new Decidueye() },
{ 725,		new Litten() },
{ 726,		new Torracat() },
{ 727,		new Incineroar() },
{ 728,		new Popplio() },
{ 729,		new Brionne() },
{ 730,		new Primarina() },
{ 731,		new Pikipek() },
{ 732,		new Trumbeak() },
{ 733,		new Toucannon() },
{ 734,		new Yungoos() },
{ 735,		new Gumshoos() },
{ 736,		new Grubbin() },
{ 737,		new Charjabug() },
{ 738,		new Vikavolt() },
{ 739,		new Crabrawler() },
{ 740,		new Crabominable() },
{ 741,		new OricorioBaile() },
{ 742,		new Cutiefly() },
{ 743,		new Ribombee() },
{ 744,		new Rockruff() },
{ 745,		new LycanrocMidday() },
{ 746,		new WishiwashiSolo() },
{ 747,		new Mareanie() },
{ 748,		new Toxapex() },
{ 749,		new Mudbray() },
{ 750,		new Mudsdale() },
{ 751,		new Dewpider() },
{ 752,		new Araquanid() },
{ 753,		new Fomantis() },
{ 754,		new Lurantis() },
{ 755,		new Morelull() },
{ 756,		new Shiinotic() },
{ 757,		new Salandit() },
{ 758,		new Salazzle() },
{ 759,		new Stufful() },
{ 760,		new Bewear() },
{ 761,		new Bounsweet() },
{ 762,		new Steenee() },
{ 763,		new Tsareena() },
{ 764,		new Comfey() },
{ 765,		new Oranguru() },
{ 766,		new Passimian() },
{ 767,		new Wimpod() },
{ 768,		new Golisopod() },
{ 769,		new Sandygast() },
{ 770,		new Palossand() },
{ 771,		new Pyukumuku() },
{ 772,		new TypeNull() },
{ 773,		new Silvally() },
{ 774,		new MiniorRedMeteor() },
{ 775,		new Komala() },
{ 776,		new Turtonator() },
{ 777,		new Togedemaru() },
{ 778,		new MimikyuDisguised() },
{ 779,		new Bruxish() },
{ 780,		new Drampa() },
{ 781,		new Dhelmise() },
{ 782,		new JangmoO() },
{ 783,		new HakamoO() },
{ 784,		new KommoO() },
{ 785,		new TapuKoko() },
{ 786,		new TapuLele() },
{ 787,		new TapuBulu() },
{ 788,		new TapuFini() },
{ 789,		new Cosmog() },
{ 790,		new Cosmoem() },
{ 791,		new Solgaleo() },
{ 792,		new Lunala() },
{ 793,		new Nihilego() },
{ 794,		new Buzzwole() },
{ 795,		new Pheromosa() },
{ 796,		new Xurkitree() },
{ 797,		new Celesteela() },
{ 798,		new Kartana() },
{ 799,		new Guzzlord() },
{ 800,		new Necrozma() },
{ 801,		new Magearna() },
{ 802,		new Marshadow() },
{ 803,		new Poipole() },
{ 804,		new Naganadel() },
{ 805,		new Stakataka() },
{ 806,		new Blacephalon() },
{ 807,		new Zeraora() },
{ 808,		new Meltan() },
{ 809,		new Melmetal() },
{ 810,		new Grookey() },
{ 811,		new Thwackey() },
{ 812,		new Rillaboom() },
{ 813,		new Scorbunny() },
{ 814,		new Raboot() },
{ 815,		new Cinderace() },
{ 816,		new Sobble() },
{ 817,		new Drizzile() },
{ 818,		new Inteleon() },
{ 819,		new Skwovet() },
{ 820,		new Greedent() },
{ 821,		new Rookidee() },
{ 822,		new Corvisquire() },
{ 823,		new Corviknight() },
{ 824,		new Blipbug() },
{ 825,		new Dottler() },
{ 826,		new Orbeetle() },
{ 827,		new Nickit() },
{ 828,		new Thievul() },
{ 829,		new Gossifleur() },
{ 830,		new Eldegoss() },
{ 831,		new Wooloo() },
{ 832,		new Dubwool() },
{ 833,		new Chewtle() },
{ 834,		new Drednaw() },
{ 835,		new Yamper() },
{ 836,		new Boltund() },
{ 837,		new Rolycoly() },
{ 838,		new Carkol() },
{ 839,		new Coalossal() },
{ 840,		new Applin() },
{ 841,		new Flapple() },
{ 842,		new Appletun() },
{ 843,		new Silicobra() },
{ 844,		new Sandaconda() },
{ 845,		new Cramorant() },
{ 846,		new Arrokuda() },
{ 847,		new Barraskewda() },
{ 848,		new Toxel() },
{ 849,		new ToxtricityAmped() },
{ 850,		new Sizzlipede() },
{ 851,		new Centiskorch() },
{ 852,		new Clobbopus() },
{ 853,		new Grapploct() },
{ 854,		new Sinistea() },
{ 855,		new Polteageist() },
{ 856,		new Hatenna() },
{ 857,		new Hattrem() },
{ 858,		new Hatterene() },
{ 859,		new Impidimp() },
{ 860,		new Morgrem() },
{ 861,		new Grimmsnarl() },
{ 862,		new Obstagoon() },
{ 863,		new Perrserker() },
{ 864,		new Cursola() },
{ 865,		new Sirfetchd() },
{ 866,		new MrRime() },
{ 867,		new Runerigus() },
{ 868,		new Milcery() },
{ 869,		new Alcremie() },
{ 870,		new Falinks() },
{ 871,		new Pincurchin() },
{ 872,		new Snom() },
{ 873,		new Frosmoth() },
{ 874,		new Stonjourner() },
{ 875,		new EiscueIce() },
{ 876,		new IndeedeeMale() },
{ 877,		new Morpeko() },
{ 878,		new Cufant() },
{ 879,		new Copperajah() },
{ 880,		new Dracozolt() },
{ 881,		new Arctozolt() },
{ 882,		new Dracovish() },
{ 883,		new Arctovish() },
{ 884,		new Duraludon() },
{ 885,		new Dreepy() },
{ 886,		new Drakloak() },
{ 887,		new Dragapult() },
{ 888,		new ZacianHero() },
{ 889,		new ZamazentaHero() },
{ 890,		new Eternatus() },
{ 891,		new Kubfu() },
{ 892,		new UrshifuSingleStrike() },
{ 893,		new Zarude() },
{ 894,		new Regieleki() },
{ 895,		new Regidrago() },
{ 896,		new Glastrier() },
{ 897,		new Spectrier() },
{ 898,		new Calyrex() }
			};

        }

        public string Display()
        {
            string res = "";
            foreach (KeyValuePair<int, Pokemon?> entry in this.Pokemons) 
            {
                if (entry.Value != null)
                {
                    res += string.Format("id " + entry.Key + "\n" +
                    entry.Value.Specie.Name + "\n" +
                    "Type" + entry.Value.TypesString + "\n\n");
                }
            }
            return res;
        }
    }
}
#nullable restore