using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace AntiFlame
{
    internal class Program
    {
        private static string[] rageText = {
            "wop",
            "ezenemy",
            "ahole",
            "ash0le",
            "ash0les",
            "asholes",
            "Ass Monkey",
            "assh0le",
            "assh0lez",
            "assholes",
            "assholz",
            "azzhole",
            "w0p",
            "wh00r",
            "wh0re",
            "xrated",
            "xxx",
            "b!+ch",
            "arschloch",
            "b!tch",
            "b17ch",
            "b1tch",
            "bi+ch",
            "boiolas",
            "unclefucker",
            "va-j-j",
            "vag",
            "vagina",
            "vajayjay",
            "vjayjay",
            "wank",
            "wankjob",
            "wetback",
            "whore",
            "hore",
            "whorebag",
            "whoreface",
            "suckass",
            "tard",
            "testicle",
            "thundercunt",
            "tit",
            "titfuck",
            "tits",
            "tittyfuck",
            "twat",
            "twatlips",
            "twats",
            "twatwaffle",
            "smut",
            "teets",
            "boobs",
            "b00bs",
            "teez",
            "testical",
            "titt",
            "w00se",
            "whoar",
            "@$$",
            "amcik",
            "sluts",
            "Slutty",
            "slutz",
            "son-of-a-bitch",
            "turd",
            "va1jina",
            "vag1na",
            "vagiina",
            "vaj1na",
            "vajina",
            "vullva",
            "vulva",
            "shiznit",
            "skank",
            "skeet",
            "skullfuck",
            "slut",
            "slutbag",
            "smeg",
            "snatch",
            "spic",
            "spick",
            "splooge",
            "spook",
            "shits",
            "Shity",
            "shitz",
            "Shyt",
            "Shyte",
            "Shytty",
            "Shyty",
            "skanck",
            "skankee",
            "skankey",
            "skanks",
            "Skanky",
            "shitface",
            "shitfaced",
            "shithead",
            "shithole",
            "shithouse",
            "shitspitter",
            "shitstain",
            "shitter",
            "shittiest",
            "shitting",
            "shitty",
            "shiz",
            "sharmute",
            "shipal",
            "skribz",
            "skurwysyn",
            "sphencter",
            "spierdalaj",
            "suka",
            "b00b",
            "vittu",
            "wichser",
            "zabourah",
            "sandnigger",
            "schlong",
            "scrote",
            "shit",
            "shitass",
            "shitbag",
            "shitbagger",
            "shitbrains",
            "shitbreath",
            "shitcanned",
            "shitcunt",
            "shitdick",
            "sadist",
            "scank",
            "screwing",
            "semen",
            "sex",
            "sexy",
            "Sh!t",
            "sh1t",
            "sh1ter",
            "sh1ts",
            "sh1tter",
            "sh1tz",
            "pussies",
            "pussy",
            "pussylicking",
            "puto",
            "queef",
            "queer",
            "queerbait",
            "queerhole",
            "renob",
            "rimjob",
            "ruski",
            "sand",
            "pusse",
            "pussee",
            "puuke",
            "puuker",
            "queers",
            "queerz",
            "qweers",
            "qweerz",
            "qweir",
            "recktum",
            "rectum",
            "retard",
            "preteen",
            "pula",
            "pule",
            "puta",
            "qahbeh",
            "rautenberg",
            "schaffer",
            "scheiss",
            "schlampe",
            "schmuck",
            "screw",
            "sharmuta",
            "pissflaps",
            "polesmoker",
            "pollock",
            "poon",
            "poonani",
            "poonany",
            "poontang",
            "porch",
            "porchmonkey",
            "prick",
            "punanny",
            "punta",
            "penuus",
            "Phuc",
            "Phuck",
            "Phuk",
            "Phuker",
            "Phukker",
            "polac",
            "polack",
            "polak",
            "pr1c",
            "pr1ck",
            "pr1k",
            "paska",
            "perse",
            "picka",
            "pierdol",
            "pillu",
            "pimmel",
            "pizda",
            "poontsee",
            "poop",
            "porn",
            "p0rn",
            "pr0n",
            "packie",
            "packy",
            "pakie",
            "paky",
            "peeenus",
            "peeenusss",
            "peenus",
            "peinus",
            "pen1s",
            "penas",
            "penis-breath",
            "penus",
            "nut",
            "nutsack",
            "paki",
            "panooch",
            "pecker",
            "peckerhead",
            "penis",
            "penisbanger",
            "penisfucker",
            "penispuffer",
            "piss",
            "pissed",
            "nigger;",
            "nigur;",
            "niiger;",
            "niigr;",
            "orafis",
            "orgasim;",
            "orgasm",
            "orgasum",
            "oriface",
            "orifice",
            "orifiss",
            "packi",
            "Mother Fukah",
            "Mother Fuker",
            "Mother Fukkah",
            "Mother Fukker",
            "mother-fucker",
            "Mutha Fucker",
            "Mutha Fukah",
            "Mutha Fuker",
            "Mutha Fukkah",
            "Mutha Fukker",
            "n1gr",
            "nastt",
            "mothafuckin",
            "motherfucker",
            "motherfucking",
            "muff",
            "muffdiver",
            "munging",
            "negro",
            "nigaboo",
            "nigga",
            "nigger",
            "niggers",
            "niglet",
            "masokist",
            "massterbait",
            "masstrbait",
            "masstrbate",
            "masterbaiter",
            "masterbate",
            "masterbates",
            "Motha Fucker",
            "Motha Fuker",
            "Motha Fukkah",
            "Motha Fukker",
            "mother fucker",
            "mamhoon",
            "masturbat",
            "merd",
            "mibun",
            "monkleigh",
            "mouliewop",
            "muie",
            "mulkku",
            "muschi",
            "nazis",
            "nepesaurio",
            "orospu",
            "l3i+ch",
            "masturbate",
            "masterbat",
            "masterbat3",
            "s.o.b.",
            "mofo",
            "nazi",
            "pimpis",
            "scrotum",
            "shemale",
            "shi+",
            "sh!+",
            "kraut",
            "kunt",
            "kyke",
            "lameass",
            "lardass",
            "lesbian",
            "lesbo",
            "lezzie",
            "mcfagget",
            "mick",
            "minge",
            "mothafucka",
            "jisim",
            "jiss",
            "jizm",
            "knob",
            "knobs",
            "knobz",
            "kunts",
            "kuntz",
            "Lezzian",
            "Lipshits",
            "Lipshitz",
            "masochist",
            "jew",
            "koon",
            "fukt",
            "fukd",
            "rekt",
            "Degrec",
            "spaz",
            "horsecum",
            "horseshit",
            "horshit",
            "humping",
            "jackass",
            "jagoff",
            "jap",
            "jerk",
            "jerkass",
            "jigaboo",
            "jizz",
            "junglebunny",
            "kike",
            "kooch",
            "kootch",
            "Huevon",
            "hui",
            "injun",
            "kanker",
            "klootzak",
            "knulle",
            "kuk",
            "kuksuger",
            "Kurac",
            "kurwa",
            "kusi",
            "kyrpa",
            "gook",
            "gringo",
            "guido",
            "handjob",
            "hard",
            "heeb",
            "hell",
            "ho",
            "hoe",
            "homo",
            "homodumbshit",
            "honkey",
            "gayz",
            "God-damned",
            "h00r",
            "h0ar",
            "h0re",
            "hells",
            "hoar",
            "hoor",
            "hoore",
            "jackoff",
            "japs",
            "jerk-off",
            "gay",
            "gayass",
            "gaybob",
            "gaydo",
            "gayfuck",
            "gayfuckist",
            "gaylord",
            "gaytard",
            "gaywad",
            "goddamn",
            "goddamnit",
            "gooch",
            "Fuken",
            "fuker",
            "Fukin",
            "Fukk",
            "Fukkah",
            "Fukken",
            "Fukker",
            "Fukkin",
            "g00k",
            "gayboy",
            "gaygirl",
            "gays",
            "fucknut",
            "fucknutt",
            "fuckoff",
            "fucks",
            "fuckstick",
            "fucktard",
            "fucktart",
            "fuckup",
            "fuckwad",
            "fuckwit",
            "fuckwitt",
            "fudgepacker",
            "fuckboy",
            "fuckbrain",
            "fuckbutt",
            "fuckbutter",
            "fucked",
            "fucker",
            "fuckersucker",
            "fuckface",
            "fuckhead",
            "fuckhole",
            "fuckin",
            "fucking",
            "Felcher",
            "ficken",
            "fitt",
            "Flikker",
            "foreskin",
            "Fotze",
            "Fu(",
            "futkretzn",
            "guiena",
            "h0r",
            "h4x0r",
            "helvete",
            "fagfucker",
            "faggit",
            "faggot",
            "faggotcock",
            "fagtard",
            "fatass",
            "fellatio",
            "feltch",
            "flamer",
            "fuck",
            "fuckass",
            "fuckbag",
            "faget",
            "fagg1t",
            "fagit",
            "fags",
            "fagz",
            "faig",
            "faigs",
            "fart",
            "flipping the bird",
            "Fudge Packer",
            "fuk",
            "Fukah",
            "douche-fag",
            "douchebag",
            "douchewaffle",
            "dumass",
            "dumb",
            "dumbass",
            "dumbfuck",
            "dumbshit",
            "dumshit",
            "dyke",
            "fag",
            "fagbag",
            "dild0",
            "dild0s",
            "dildos",
            "dilld0",
            "dilld0s",
            "dominatricks",
            "dominatrics",
            "dominatrix",
            "enema",
            "f u c k",
            "f u c k e r",
            "fag1t",
            "dicksucking",
            "dicktickler",
            "dickwad",
            "dickweasel",
            "dickweed",
            "dickwod",
            "dike",
            "dildo",
            "dipshit",
            "doochbag",
            "dookie",
            "douche",
            "dickbeaters",
            "dickface",
            "dickfuck",
            "dickfucker",
            "dickhead",
            "dickhole",
            "dickjuice",
            "dickmilk",
            "dickmonger",
            "dicks",
            "dickslap",
            "dicksucker",
            "dego",
            "dupa",
            "dziwka",
            "ejackulate",
            "Ekrem",
            "Ekto",
            "enculer",
            "faen",
            "fanculo",
            "fanny",
            "feces",
            "feg",
            "cuntass",
            "cuntface",
            "cunthole",
            "cuntlicker",
            "cuntrag",
            "cuntslut",
            "dago",
            "damn",
            "deggo",
            "dick",
            "dick-sneeze",
            "dickbag",
            "cooter",
            "cracker",
            "cum",
            "cumbubble",
            "cumdumpster",
            "cumguzzler",
            "cumjockey",
            "cumslut",
            "cumtart",
            "cunnie",
            "cunnilingus",
            "cunt",
            "cocknose",
            "cocknugget",
            "cockshit",
            "cocksmith",
            "cocksmoke",
            "cocksmoker",
            "cocksniffer",
            "cocksucker",
            "cockwaffle",
            "coochie",
            "coochy",
            "coon",
            "cockbite",
            "cockburger",
            "cockface",
            "cockfucker",
            "cockhead",
            "cockjockey",
            "cockknoker",
            "cockmaster",
            "cockmongler",
            "cockmongruel",
            "cockmonkey",
            "cockmuncher",
            "carpetmuncher",
            "chesticle",
            "chinc",
            "chink",
            "choad",
            "chode",
            "clit",
            "clitface",
            "clitfuck",
            "clusterfuck",
            "cock",
            "cockass",
            "c0k",
            "Carpet Muncher",
            "cawk",
            "cawks",
            "cnts",
            "cntz",
            "cock-head",
            "cocks",
            "cock-sucker",
            "crap",
            "cunts",
            "cuntz",
            "buceta",
            "cipa",
            "clits",
            "dirsa",
            "ejakulate",
            "fcuk",
            "fux0r",
            "hoer",
            "jism",
            "kawk",
            "l3itch",
            "blowjob",
            "bollocks",
            "bollox",
            "boner",
            "brotherfucker",
            "bullshit",
            "bumblefuck",
            "butt",
            "butt-pirate",
            "buttfucka",
            "buttfucker",
            "camel",
            "bassterds",
            "bastards",
            "bastardz",
            "basterds",
            "basterdz",
            "Biatch",
            "Blow Job",
            "boffing",
            "butthole",
            "buttwipe",
            "c0ck",
            "c0cks",
            "asswad",
            "asswipe",
            "axwound",
            "bampot",
            "bastard",
            "beaner",
            "bitch",
            "bitchass",
            "bitches",
            "bitchtits",
            "bitchy",
            "blow",
            "asshopper",
            "assjacker",
            "asslick",
            "asslicker",
            "assmonkey",
            "assmunch",
            "assmuncher",
            "assnigger",
            "asspirate",
            "assshit",
            "assshole",
            "asssucker",
            "assbite",
            "assclown",
            "asscock",
            "asscracker",
            "asses",
            "assface",
            "assfuck",
            "assfucker",
            "assgoblin",
            "asshat",
            "asshead",
            "asshole",
            "anus",
            "arse",
            "arsehole",
            "ass",
            "ass-hat",
            "ass-jabber",
            "ass-pirate",
            "assbag",
            "assbandit",
            "assbanger",
            "andskota",
            "assrammer",
            "ayir",
            "bi7ch",
            "bollock",
            "breasts",
            "cabron",
            "cazzo",
            "chraa",
            "chuj",
            "d4mn",
            "daygo",
            "morons",
            "moron",
            "spas",
            "analfabeta",
            "bobo",
            "boba",
            "cacorro",
            "culo",
            "gorsovia",
            "malparido",
            "gonorrea",
            "hijueputa",
            "guevon",
            "maricon",
            "marica",
            "maricona",
            "guache",
            "huevon",
            "pichurria",
            "pirobo",
            "gasofia",
            "manco",
            "roscon",
            "percanta",
            "culero",
            "puta",
            "puto",
            "gilipolla",
            "fgt",
            "polla",
            "pollon",
            "tarugo",
            "guaricha",
            "perra",
            "sucia",
            "vagabunda",
            "culiao",
            "reculeado",
            "violado",
            "violada",
            "conchesumadre",
            "poto",
            "gil",
            "asopao",
            "agilao",
            "zorra",
            "verga",
            "vergon",
            "vergota",
            "chandoso",
            "chandosa",
            "monda",
            "nojoda",
            "joda",
            "pedorro",
            "pedorra",
            "cacorro",
            "cacorra",
            "imbecil",
            "pendejo",
            "pendeja",
            "garulla",
            "zunga",
            "fufa",
            "chimba",
            "garbinba",
            "cagon",
            "cagado",
            "cagona",
            "petardo",
            "petarda",
            "coscorria",
            "triplehijueputa",
            "catrehijueputa",
            "sifilico",
            "aberracion",
            "mongol",
            "moco",
            "mongolico",
            "tumbalocas",
            "golfa",
            "rata",
            "ramera",
            "lambebolas",
            "lamebolas",
            "cachifa",
            "estupido",
            "estupida",
            "gafo",
            "sapo",
            "bocon",
            "cachondo",
            "perruncha",
            "baboso",
            "mamalo",
            "mamelo",
            "maldito",
            "maldita",
            "escoria",
            "prostituta",
            "pajero",
            "pajuelo",
            "assembly",
            "script",
            "bol",
            "leaguesharp",
            "L#",
            "gg ez",
            "ggez",
            "ezpz",
            "ez pz"
        };

        private static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += onGameLoad;
        }

        private static void onGameLoad(EventArgs args)
        {
            Game.PrintChat("AntiFlame by iJabba Loaded - Credits to Pain for word list :^)");
            Game.OnInput += onInput;
        }

        private static void onInput(GameInputEventArgs args)
        {
            if (rageText.Any(word => args.Input.Contains(word)))
            {
                args.Process = false;
            }
        }
    }
}
