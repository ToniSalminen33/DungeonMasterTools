using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMTools
{
    public class NPCModel
    {

		public NPCModel()
		{
            ClassesList = new List<string>() { "Actor", "Advocate(Lawyer)", "Alchemist", "AnimalHandler", "Apothecary", "Architect", "Archer", "Archivist", "Aristocrat", "Armorer", "Artisan", "Artist", "Astrologer", "Baker", "Banker", "Barbarian", "Barber", "Bard", "Barkeep", "Barmaid", "Beekeeper", "BeerSeller", "Beggar", "Blacksmith", "Boatman", "Bookbinder", "Bookseller", "Brewer", "Bricklayer", "BrickMaker", "Brigand", "BrothelKeeper", "BuckleMaker", "Builder", "Butcher", "CaravanLeader", "Carpenter", "Cartographer", "Chandler", "Charioteer", "Chatelaine", "Chef", "Chieftain", "Chirurgeon", "Clergyman", "Clerk", "ClockMaker", "Clothworker", "Cobbler", "Commander", "Concubine", "Cook", "Cooper", "Copyist", "Costermonger", "Counselor", "Courtesan", "Courtier", "Cowherd", "Crossbowman", "Cutler", "Daimyo", "Dairymaid", "Dancer", "Dictator", "Diplomat", "Distiller", "Diver", "Diviner", "Doctor", "DomesticServant", "Emperor/Empress", "Eunuch", "Explorer", "Farmer", "Fighter", "Fisherman", "Fishmonger", "Footman", "Furrier", "GalleySlave", "Gardener", "Geisha", "General", "Gladiator", "Glovemaker", "Goldsmith", "Grocer", "Groom", "Guardsman", "Guildmaster", "Harnessmaker", "Hatmaker", "Haymerchant", "Healer", "Hearthwitch", "Herald", "Herbalist", "Herder", "Hermit", "Highwayman", "Historian", "Housemaid", "Hunter", "Illuminator", "Infantryman", "Innkeeper", "Interpreter", "Inventor", "Jailer", "Jester", "Jeweler", "Jongleur", "Judge", "King", "Kitchendrudge", "Knight", "Laborer", "Lady", "LadyinWaiting", "Leatherworker", "Librarian", "Linguist", "Locksmith", "Longbowman", "Longshoreman", "Lord", "Maidservant", "Majordomo", "ManatArms", "Mason", "Masseur", "Mayor", "Mercer", "Merchant", "Messenger", "Midwife", "Miller", "Miner", "Minister", "Minstrel", "Monk", "Mortician", "Mourner", "Musician", "Necromancer", "Noble", "Nun", "Nurse", "Oldclothesseller", "Page", "Painter", "Pariah", "Pastrycook", "Peasant", "Perfumer", "Philosopher", "Physician", "Pigkeeper", "Pilgrim", "Pirate", "Plasterer", "Potter", "Priest/ess", "Princess", "Privateer", "Professor", "Prostitute", "Pursemaker", "Queen", "Ranger", "Ratcatcher", "Reeve", "Ronin", "Roofer", "Ropemaker", "RoyalAdviser", "Rugmaker", "Ruler", "Saddler", "Sailor", "Samurai", "Scabbardmaker", "Sculptor", "Scavenger", "Scholar", "Scrivener", "Seamstress", "Servant", "Shaman", "Shepherd", "Ship'scaptain", "Shoemaker", "Silversmith", "Slave", "Slaver", "Smith", "Soldier", "Sorcerer/Sorceress", "SpiceMerchant", "Squire", "Stablehand", "Stevedore", "Stonemason", "Storyteller", "Steward", "Streetkid", "Streetseller", "Streetsweeper", "Student", "Surgeon", "Surveyor", "Swordsman", "Sycophant", "Tailor", "Tanner", "Tavernkeeper", "Taxcollector", "Teacher", "Teamster", "Thatcher", "Thief", "Tinker", "Torturer", "Towncrier", "Toymaker", "Trapper", "Vendor", "Vermincatcher", "Veterinarian", "Villagechief", "Vintner", "Viking", "Warlock", "Warrior", "Watercarrier", "Weaver", "Wetnurse", "Wineseller", "Witch", "Wizard", "Woodcarver", "Woodcutter", "Woodseller", "Wrestler", "Writer" };
            RaceList = new List<string>() { "Dragonborn", "Dwarf", "Elf", "Gnome", "Half-Elf", "Halfling", "Half-Orc", "Human", "Tiefling", "Leonin", "Owlin", "Aarakocra", "Aasimar", "Air Genasi", "Bugbear", "Centaur", "Changeling", "Deep", "Gnome", "Duergar", "Earth Genasi", "Eladrin", "Fairy", "Firbolg", "Fire Genasi", "Githyanki", "Githzerai", "Goblin", "Goliath", "Harengon", "Hobgoblin", "Kenku", "Kobold", "Lizardfolk", "Minotaur", "Orc", "Satyr", "Sea", "Elf", "Shadar-kai", "Shifter", "Tabaxi", "Tortle", "Triton", "Water Genasi", "Yuan-ti", "Feral Tiefling", "Kalashtar", "Warforged", "Astral Elf", "Autognome", "Giff", "Hadozee", "Plasmoid", "Thri-kreen", "Loxodon", "Simic Hybrid", "Vedalken", "Grung", "Locathah" };
            GenderList = new List<string>() { "Male", "Female", "Other" };
            AdjectiveList = new List<string>()
            {
                "adorable", "adventurous", "aggressive", "agreeable", "alert", "alive", "amused", "angry", "annoyed", "annoying", "anxious", "arrogant", "ashamed", "attractive", "average", "awful", "bad", "beautiful", "better", "bewildered", "black", "bloody", "blue", "blue", "eyed", "blushing", "bored", "brainy", "brave", "breakable", "bright", "busy", "calm", "careful", "cautious", "charming", "cheerful", "clean", "clear", "clever", "cloudy", "clumsy", "colorful", "combative", "comfortable", "concerned", "condemned", "confused", "cooperative", "courageous", "crazy", "creepy", "crowded", "cruel", "curious", "cute", "dangerous", "dark", "dead", "defeated", "defiant", "delightful", "depressed", "determined", "different", "difficult", "disgusted", "distinct", "disturbed", "dizzy", "doubtful", "drab", "dull",
                "eager", "easy", "elated", "elegant", "embarrassed", "enchanting", "encouraging", "energetic", "enthusiastic", "envious", "evil", "excited", "expensive", "exuberant", "fair", "faithful", "famous", "fancy", "fantastic", "fierce", "filthy", "fine", "foolish", "fragile", "frail", "frantic", "friendly", "frightened", "funny", "gentle", "gifted", "glamorous", "gleaming", "glorious", "good", "gorgeous", "graceful", "grieving", "grotesque", "grumpy", "handsome", "happy", "healthy", "helpful", "helpless", "hilarious", "homeless", "homely", "horrible", "hungry", "hurt", "ill", "important", "impossible", "inexpensive", "innocent", "inquisitive", "itchy", "jealous", "jittery", "jolly", "joyous", "kind",
                "lazy", "light", "lively", "lonely", "long", "lovely", "lucky", "magnificent", "misty", "modern", "motionless", "muddy", "mushy", "mysterious", "nasty", "naughty", "nervous", "nice", "nutty", "obedient", "obnoxious", "odd", "old", "fashioned", "open", "outrageous", "outstanding", "panicky", "perfect", "plain", "pleasant", "poised", "poor", "powerful", "precious", "prickly", "proud", "putrid", "puzzled", "quaint", "real", "relieved", "repulsive", "rich", "scary", "selfish", "shiny", "shy", "silly", "sleepy", "smiling", "smoggy", "sore", "sparkling", "splendid", "spotless", "stormy", "strange", "stupid", "successful", "super",
                "talented", "tame", "tasty", "tender", "tense", "terrible", "thankful", "thoughtful", "thoughtless", "tired", "tough", "troubled", "ugliest", "ugly", "uninterested", "unsightly", "unusual", "upset", "uptight", "vast", "victorious", "vivacious", "wandering", "weary", "wicked", "wide", "eyed", "wild", "witty", "worried", "worrisome", "wrong", "zany", "zealous"
            };
            VerbList = new List<string>()
            {
                "accelerated", "accomplished", "Achieved", "Acquired", "activated", "adapted", "Adjusted", "administered", "advised", "Allocated", "analyzed", "annotated", "anticipated", "applied", "appraised", "Arranged", "articulated", "assembled", "Assessed", "assigned", "attained", "Authored", "balanced", "briefed", "Budgeted", "calculated", "catalogued", "categorized", "chaired", "changed", "Channeled", "charted", "clarified", "Coached", "coded", "collaborated", "Collected", "communicated", "compared", "Competed", "compiled", "completed", "Composed", "computed", "conceived", "Conducted", "confronted", "consolidated", "constructed", "contacted", "continued", "Contracted", "convened", "coordinated", "corresponded", "counseled", "created", "Critiqued", "defined", "delegated", "Delivered", "demonstrated", "derived", "Designed", "detected", "determined", "Developed", "devised", "diagnosed", "Directed", "discovered", "dispensed", "Displayed", "distributed", "drafted", "dramatized", "earned", "edited", "Educated", "effected", "elicited", "Employed", "encouraged", "endured", "Enlisted", "entertained", "established", "Estimated", "evaluated", "examined", "Exchanged", "executed", "exercised", "Exhibited", "expanded", "expedited", "experimented", "explained", "explored", "Facilitated", "financed", "focused", "Forecasted", "formulated", "fostered", "Grouped", "guided", "identified", "Illustrated", "implemented", "imposed", "Improved", "increased", "influenced", "Informed", "initiated", "inquired", "Inspected", "installed", "instilled", "Instituted", "instructed", "insured", "interpreted", "intervened", "interviewed", "introduced", "invented", "inventoried", "investigated", "judged", "lectured", "Listened", "located", "maintained", "Managed", "marketed", "mastered", "Measured", "mediated", "modeled", "Modified", "molded", "monitored", "Motivated", "negotiated", "observed", "Obtained", "operated", "organized", "Outlined", "oversaw", "participated", "Perceived", "performed", "persuaded", "Planned", "predicted", "prepared", "Prescribed", "presented", "presided", "Processed", "produced", "programmed", "Promoted", "protected", "provided", "Publicized", "published", "purchased", "questioned", "recommended", "recorded", "Recruited", "reduced", "regulated", "Reinforced", "rendered", "repaired", "Reported", "represented", "reproduced", "Researched", "resolved", "responded", "Restored", "retained", "retrieved", "Reviewed", "revised", "rewrote", "Routed", "scheduled", "searched", "Selected", "served", "serviced", "Shaped", "shared", "simplified", "Solicited", "solved", "sought", "Specified", "stimulated", "studied", "Succeeded", "suggested", "summarized", "supervised", "supported", "surveyed", "synthesized", "systematized", "targeted", "Taught", "tested", "trained", "Translated", "tutored", "updated", "Utilized", "verified", "visualized", "Wrote"
            };
        }
		private List<string> _classesList;

		public List<string> ClassesList
		{
			get { return _classesList; }
			set { _classesList = value; }
		}

		private List<string> _raceList;

		public List<string> RaceList
		{
			get { return _raceList; }
			set { _raceList = value; }
		}
		private List<string> _genderList;

		public List<string> GenderList
		{
			get { return _genderList; }
			set { _genderList = value; }
		}

		private List<string> _adjectiveList;

		public List<string> AdjectiveList
		{
			get { return _adjectiveList; }
			set { _adjectiveList = value; }
		}

		private List<string> _verbList;

		public List<string> VerbList
		{
			get { return _verbList; }
			set { _verbList = value; }
		}


		private string _class;

		public string Class
		{
			get { return _class; }
			set { _class = value; }
		}
		private string _race;

		public string Race
		{
			get { return _race; }
			set { _race = value; }
		}
		private string _gender;

		public string Gender
		{
			get { return _gender; }
			set { _gender = value; }
		}
		private string _adjective;

		public string Adjective
		{
			get { return _adjective; }
			set { _adjective = value; }
		}
		private string _verb;

		public string Verb
		{
			get { return _verb; }
			set { _verb = value; }
		}
		private int _teamNr;

		public int TeamNr
		{
			get { return _teamNr; }
			set { _teamNr = value; }
		}

	}
}
