﻿using System.Drawing;

namespace ntrbase
{
    class LookupTable
    {
        #region Empty poke

        public byte[] EmptyPoke6
        {
            get
            {
                byte[] data = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x83, 0x07, 0x00, 0x00, 0x7E, 0xE9, 0x71, 0x52, 0xB0, 0x31, 0x42, 0x8E, 0xCC, 0xE2, 0xC5, 0xAF, 0xDB, 0x67, 0x33, 0xFC, 0x2C, 0xEF, 0x5E, 0xFC, 0xC5, 0xCA, 0xD6, 0xEB, 0x3D, 0x99, 0xBC, 0x7A, 0xA7, 0xCB, 0xD6, 0x5D, 0x78, 0x91, 0xA6, 0x27, 0x8D, 0x61, 0x92, 0x16, 0xB8, 0xCF, 0x5D, 0x37, 0x80, 0x30, 0x7C, 0x40, 0xFB, 0x48, 0x13, 0x32, 0xE7, 0xFE, 0xE6, 0xDF, 0x0E, 0x3D, 0xF9, 0x63, 0x29, 0x1D, 0x8D, 0xEA, 0x96, 0x62, 0x68, 0x92, 0x97, 0xA3, 0x49, 0x1C, 0x03, 0x6E, 0xAA, 0x31, 0x89, 0xAA, 0xC5, 0xD3, 0xEA, 0xC3, 0xD9, 0x82, 0xC6, 0xE0, 0x5C, 0x94, 0x3B, 0x4E, 0x5F, 0x5A, 0x28, 0x24, 0xB3, 0xFB, 0xE1, 0xBF, 0x8E, 0x7B, 0x7F, 0x00, 0xC4, 0x40, 0x48, 0xC8, 0xD1, 0xBF, 0xB6, 0x38, 0x3B, 0x90, 0x23, 0xFB, 0x23, 0x7D, 0x34, 0xBE, 0x00, 0xDA, 0x6A, 0x70, 0xC5, 0xDF, 0x84, 0xBA, 0x14, 0xE4, 0xA1, 0x60, 0x2B, 0x2B, 0x38, 0x8F, 0xA0, 0xB6, 0x60, 0x41, 0x36, 0x16, 0x09, 0xF0, 0x4B, 0xB5, 0x0E, 0x26, 0xA8, 0xB6, 0x43, 0x7B, 0xCB, 0xF9, 0xEF, 0x68, 0xD4, 0xAF, 0x5F, 0x74, 0xBE, 0xC3, 0x61, 0xE0, 0x95, 0x98, 0xF1, 0x84, 0xBA, 0x11, 0x62, 0x24, 0x80, 0xCC, 0xC4, 0xA7, 0xA2, 0xB7, 0x55, 0xA8, 0x5C, 0x1C, 0x42, 0xA2, 0x3A, 0x86, 0x05, 0xAD, 0xD2, 0x11, 0x19, 0xB0, 0xFD, 0x57, 0xE9, 0x4E, 0x60, 0xBA, 0x1B, 0x45, 0x2E, 0x17, 0xA9, 0x34, 0x93, 0x2D, 0x66, 0x09, 0x2D, 0x11, 0xE0, 0xA1, 0x74, 0x42, 0xC4, 0x73, 0x65, 0x2F, 0x21, 0xF0, 0x43, 0x28, 0x54, 0xA6 };
                return data;
            }
        }

        public byte[] EmptyPoke7
        {
            get
            {
                byte[] data = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x26, 0x06, 0x00, 0x00, 0x7E, 0xE9, 0x71, 0x52, 0xB0, 0x31, 0x42, 0x8E, 0xCC, 0xE2, 0xC5, 0xAF, 0xDB, 0x67, 0x33, 0xFC, 0x2C, 0xEF, 0x5E, 0xFC, 0xC5, 0xCA, 0xD6, 0xEB, 0x3D, 0x99, 0xBC, 0x7A, 0xA7, 0xCB, 0xD6, 0x5D, 0x78, 0x91, 0xA6, 0x27, 0x8D, 0x61, 0x92, 0x16, 0xB8, 0xCF, 0x5D, 0x37, 0x80, 0x30, 0x7C, 0x40, 0xFB, 0x48, 0x13, 0x32, 0xE7, 0xFE, 0xE6, 0xDF, 0x0E, 0x3D, 0xF9, 0x63, 0x29, 0x1D, 0x8D, 0xEA, 0x96, 0x62, 0x68, 0x92, 0x97, 0xA3, 0x49, 0x1C, 0x03, 0x6E, 0xAA, 0x31, 0x89, 0xAA, 0xC5, 0xD3, 0xEA, 0xC3, 0xD9, 0x82, 0xC6, 0xE0, 0x5C, 0x94, 0x3B, 0x4E, 0x5F, 0x5A, 0x28, 0x24, 0xB3, 0xFB, 0xE1, 0xBF, 0x8E, 0x7B, 0x7F, 0x00, 0xC4, 0x40, 0x48, 0xC8, 0xD1, 0xBF, 0xB6, 0x38, 0x3B, 0x90, 0x23, 0xFB, 0x23, 0x7D, 0x34, 0xBE, 0x00, 0xDA, 0x6A, 0x70, 0xC5, 0xDF, 0x84, 0xBA, 0x14, 0xE4, 0xA1, 0x60, 0x2B, 0x2B, 0x38, 0x8F, 0xA0, 0xB6, 0x60, 0x41, 0x36, 0x16, 0x09, 0xF0, 0x4B, 0xB5, 0x0E, 0x26, 0xA8, 0xB6, 0x43, 0x7B, 0xCB, 0xF9, 0xEF, 0x68, 0xD4, 0xAF, 0x5F, 0x74, 0xBE, 0xC3, 0x61, 0xE0, 0x95, 0x98, 0xF1, 0x84, 0xBA, 0x11, 0x62, 0x24, 0x80, 0xCC, 0xC4, 0xA7, 0xA2, 0xB7, 0x55, 0xA8, 0x5C, 0x1C, 0x42, 0xA2, 0x3A, 0x86, 0x05, 0xAD, 0xD2, 0x11, 0x19, 0xB0, 0xFD, 0x57, 0xE9, 0x4E, 0x60, 0xBA, 0x1B, 0x45, 0x2E, 0x17, 0xA9, 0x34, 0x93, 0x2D, 0x66, 0x09, 0x2D, 0x11, 0xE0, 0xA1, 0x74, 0x42, 0xC4, 0x73, 0x19, 0x28, 0x22, 0xF0, 0x43, 0x28, 0x54, 0xA6 };
                return data;
            }
        }

        #endregion Empty poke

        #region Items

        public string[] Item6
        {
            get
            {
                string[] data = { "[None]", "Master Ball", "Ultra Ball", "Great Ball", "Poké Ball", "Safari Ball", "Net Ball", "Dive Ball", "Nest Ball", "Repeat Ball", "Timer Ball", "Luxury Ball", "Premier Ball", "Dusk Ball", "Heal Ball", "Quick Ball", "Cherish Ball", "Potion", "Antidote", "Burn Heal", "Ice Heal", "Awakening", "Paralyze Heal", "Full Restore", "Max Potion", "Hyper Potion", "Super Potion", "Full Heal", "Revive", "Max Revive", "Fresh Water", "Soda Pop", "Lemonade", "Moomoo Milk", "Energy Powder", "Energy Root", "Heal Powder", "Revival Herb", "Ether", "Max Ether", "Elixir", "Max Elixir", "Lava Cookie", "Berry Juice", "Sacred Ash", "HP Up", "Protein", "Iron", "Carbos", "Calcium", "Rare Candy", "PP Up", "Zinc", "PP Max", "Old Gateau", "Guard Spec.", "Dire Hit", "X Attack", "X Defense", "X Speed", "X Accuracy", "X Sp. Atk", "X Sp. Def", "Poké Doll", "Fluffy Tail", "Blue Flute", "Yellow Flute", "Red Flute", "Black Flute", "White Flute", "Shoal Salt", "Shoal Shell", "Red Shard", "Blue Shard", "Yellow Shard", "Green Shard", "Super Repel", "Max Repel", "Escape Rope", "Repel", "Sun Stone", "Moon Stone", "Fire Stone", "Thunder Stone", "Water Stone", "Leaf Stone", "Tiny Mushroom", "Big Mushroom", "Pearl", "Big Pearl", "Stardust", "Star Piece", "Nugget", "Heart Scale", "Honey", "Growth Mulch", "Damp Mulch", "Stable Mulch", "Gooey Mulch", "Root Fossil", "Claw Fossil", "Helix Fossil", "Dome Fossil", "Old Amber", "Armor Fossil", "Skull Fossil", "Rare Bone", "Shiny Stone", "Dusk Stone", "Dawn Stone", "Oval Stone", "Odd Keystone", "Griseous Orb", "???", "???", "???", "Douse Drive", "Shock Drive", "Burn Drive", "Chill Drive", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Sweet Heart", "Adamant Orb", "Lustrous Orb", "Greet Mail", "Favored Mail", "RSVP Mail", "Thanks Mail", "Inquiry Mail", "Like Mail", "Reply Mail", "Bridge Mail S", "Bridge Mail D", "Bridge Mail T", "Bridge Mail V", "Bridge Mail M", "Cheri Berry", "Chesto Berry", "Pecha Berry", "Rawst Berry", "Aspear Berry", "Leppa Berry", "Oran Berry", "Persim Berry", "Lum Berry", "Sitrus Berry", "Figy Berry", "Wiki Berry", "Mago Berry", "Aguav Berry", "Iapapa Berry", "Razz Berry", "Bluk Berry", "Nanab Berry", "Wepear Berry", "Pinap Berry", "Pomeg Berry", "Kelpsy Berry", "Qualot Berry", "Hondew Berry", "Grepa Berry", "Tamato Berry", "Cornn Berry", "Magost Berry", "Rabuta Berry", "Nomel Berry", "Spelon Berry", "Pamtre Berry", "Watmel Berry", "Durin Berry", "Belue Berry", "Occa Berry", "Passho Berry", "Wacan Berry", "Rindo Berry", "Yache Berry", "Chople Berry", "Kebia Berry", "Shuca Berry", "Coba Berry", "Payapa Berry", "Tanga Berry", "Charti Berry", "Kasib Berry", "Haban Berry", "Colbur Berry", "Babiri Berry", "Chilan Berry", "Liechi Berry", "Ganlon Berry", "Salac Berry", "Petaya Berry", "Apicot Berry", "Lansat Berry", "Starf Berry", "Enigma Berry", "Micle Berry", "Custap Berry", "Jaboca Berry", "Rowap Berry", "Bright Powder", "White Herb", "Macho Brace", "Exp. Share", "Quick Claw", "Soothe Bell", "Mental Herb", "Choice Band", "King’s Rock", "Silver Powder", "Amulet Coin", "Cleanse Tag", "Soul Dew", "Deep Sea Tooth", "Deep Sea Scale", "Smoke Ball", "Everstone", "Focus Band", "Lucky Egg", "Scope Lens", "Metal Coat", "Leftovers", "Dragon Scale", "Light Ball", "Soft Sand", "Hard Stone", "Miracle Seed", "Black Glasses", "Black Belt", "Magnet", "Mystic Water", "Sharp Beak", "Poison Barb", "Never-Melt Ice", "Spell Tag", "Twisted Spoon", "Charcoal", "Dragon Fang", "Silk Scarf", "Up-Grade", "Shell Bell", "Sea Incense", "Lax Incense", "Lucky Punch", "Metal Powder", "Thick Club", "Stick", "Red Scarf", "Blue Scarf", "Pink Scarf", "Green Scarf", "Yellow Scarf", "Wide Lens", "Muscle Band", "Wise Glasses", "Expert Belt", "Light Clay", "Life Orb", "Power Herb", "Toxic Orb", "Flame Orb", "Quick Powder", "Focus Sash", "Zoom Lens", "Metronome", "Iron Ball", "Lagging Tail", "Destiny Knot", "Black Sludge", "Icy Rock", "Smooth Rock", "Heat Rock", "Damp Rock", "Grip Claw", "Choice Scarf", "Sticky Barb", "Power Bracer", "Power Belt", "Power Lens", "Power Band", "Power Anklet", "Power Weight", "Shed Shell", "Big Root", "Choice Specs", "Flame Plate", "Splash Plate", "Zap Plate", "Meadow Plate", "Icicle Plate", "Fist Plate", "Toxic Plate", "Earth Plate", "Sky Plate", "Mind Plate", "Insect Plate", "Stone Plate", "Spooky Plate", "Draco Plate", "Dread Plate", "Iron Plate", "Odd Incense", "Rock Incense", "Full Incense", "Wave Incense", "Rose Incense", "Luck Incense", "Pure Incense", "Protector", "Electirizer", "Magmarizer", "Dubious Disc", "Reaper Cloth", "Razor Claw", "Razor Fang", "TM01", "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11", "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21", "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31", "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41", "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "TM51", "TM52", "TM53", "TM54", "TM55", "TM56", "TM57", "TM58", "TM59", "TM60", "TM61", "TM62", "TM63", "TM64", "TM65", "TM66", "TM67", "TM68", "TM69", "TM70", "TM71", "TM72", "TM73", "TM74", "TM75", "TM76", "TM77", "TM78", "TM79", "TM80", "TM81", "TM82", "TM83", "TM84", "TM85", "TM86", "TM87", "TM88", "TM89", "TM90", "TM91", "TM92", "HM01", "HM02", "HM03", "HM04", "HM05", "HM06", "???", "???", "Explorer Kit", "Loot Sack", "Rule Book", "Poké Radar", "Point Card", "Journal", "Seal Case", "Fashion Case", "Seal Bag", "Pal Pad", "Works Key", "Old Charm", "Galactic Key", "Red Chain", "Town Map", "Vs. Seeker", "Coin Case", "Old Rod", "Good Rod", "Super Rod", "Sprayduck", "Poffin Case", "Bike", "Suite Key", "Oak’s Letter", "Lunar Wing", "Member Card", "Azure Flute", "S.S. Ticket", "Contest Pass", "Magma Stone", "Parcel", "Coupon 1", "Coupon 2", "Coupon 3", "Storage Key", "Secret Potion", "Vs. Recorder", "Gracidea", "Secret Key", "Apricorn Box", "Unown Report", "Berry Pots", "Dowsing Machine", "Blue Card", "Slowpoke Tail", "Clear Bell", "Card Key", "Basement Key", "Squirt Bottle", "Red Scale", "Lost Item", "Pass", "Machine Part", "Silver Wing", "Rainbow Wing", "Mystery Egg", "Red Apricorn", "Blue Apricorn", "Yellow Apricorn", "Green Apricorn", "Pink Apricorn", "White Apricorn", "Black Apricorn", "Fast Ball", "Level Ball", "Lure Ball", "Heavy Ball", "Love Ball", "Friend Ball", "Moon Ball", "Sport Ball", "Park Ball", "Photo Album", "GB Sounds", "Tidal Bell", "Rage Candy Bar", "Data Card 01", "Data Card 02", "Data Card 03", "Data Card 04", "Data Card 05", "Data Card 06", "Data Card 07", "Data Card 08", "Data Card 09", "Data Card 10", "Data Card 11", "Data Card 12", "Data Card 13", "Data Card 14", "Data Card 15", "Data Card 16", "Data Card 17", "Data Card 18", "Data Card 19", "Data Card 20", "Data Card 21", "Data Card 22", "Data Card 23", "Data Card 24", "Data Card 25", "Data Card 26", "Data Card 27", "Jade Orb", "Lock Capsule", "Red Orb", "Blue Orb", "Enigma Stone", "Prism Scale", "Eviolite", "Float Stone", "Rocky Helmet", "Air Balloon", "Red Card", "Ring Target", "Binding Band", "Absorb Bulb", "Cell Battery", "Eject Button", "Fire Gem", "Water Gem", "Electric Gem", "Grass Gem", "Ice Gem", "Fighting Gem", "Poison Gem", "Ground Gem", "Flying Gem", "Psychic Gem", "Bug Gem", "Rock Gem", "Ghost Gem", "Dragon Gem", "Dark Gem", "Steel Gem", "Normal Gem", "Health Wing", "Muscle Wing", "Resist Wing", "Genius Wing", "Clever Wing", "Swift Wing", "Pretty Wing", "Cover Fossil", "Plume Fossil", "Liberty Pass", "Pass Orb", "Dream Ball", "Poké Toy", "Prop Case", "Dragon Skull", "Balm Mushroom", "Big Nugget", "Pearl String", "Comet Shard", "Relic Copper", "Relic Silver", "Relic Gold", "Relic Vase", "Relic Band", "Relic Statue", "Relic Crown", "Casteliacone", "Dire Hit 2", "X Speed 2", "X Sp. Atk 2", "X Sp. Def 2", "X Defense 2", "X Attack 2", "X Accuracy 2", "X Speed 3", "X Sp. Atk 3", "X Sp. Def 3", "X Defense 3", "X Attack 3", "X Accuracy 3", "X Speed 6", "X Sp. Atk 6", "X Sp. Def 6", "X Defense 6", "X Attack 6", "X Accuracy 6", "Ability Urge", "Item Drop", "Item Urge", "Reset Urge", "Dire Hit 3", "Light Stone", "Dark Stone", "TM93", "TM94", "TM95", "Xtransceiver", "???", "Gram 1", "Gram 2", "Gram 3", "Xtransceiver", "Medal Box", "DNA Splicers", "DNA Splicers", "Permit", "Oval Charm", "Shiny Charm", "Plasma Card", "Grubby Hanky", "Colress Machine", "Dropped Item", "Dropped Item", "Reveal Glass", "Weakness Policy", "Assault Vest", "Holo Caster", "Prof’s Letter", "Roller Skates", "Pixie Plate", "Ability Capsule", "Whipped Dream", "Sachet", "Luminous Moss", "Snowball", "Safety Goggles", "Poké Flute", "Rich Mulch", "Surprise Mulch", "Boost Mulch", "Amaze Mulch", "Gengarite", "Gardevoirite", "Ampharosite", "Venusaurite", "Charizardite X", "Blastoisinite", "Mewtwonite X", "Mewtwonite Y", "Blazikenite", "Medichamite", "Houndoominite", "Aggronite", "Banettite", "Tyranitarite", "Scizorite", "Pinsirite", "Aerodactylite", "Lucarionite", "Abomasite", "Kangaskhanite", "Gyaradosite", "Absolite", "Charizardite Y", "Alakazite", "Heracronite", "Mawilite", "Manectite", "Garchompite", "Latiasite", "Latiosite", "Roseli Berry", "Kee Berry", "Maranga Berry", "Sprinklotad", "TM96", "TM97", "TM98", "TM99", "TM100", "Power Plant Pass", "Mega Ring", "Intriguing Stone", "Common Stone", "Discount Coupon", "Elevator Key", "TMV Pass", "Honor of Kalos", "Adventure Rules", "Strange Souvenir", "Lens Case", "Makeup Bag", "Travel Trunk", "Lumiose Galette", "Shalour Sable", "Jaw Fossil", "Sail Fossil", "Looker Ticket", "Bike", "Holo Caster", "Fairy Gem", "Mega Charm", "Mega Glove", "Mach Bike", "Acro Bike", "Wailmer Pail", "Devon Parts", "Soot Sack", "Basement Key", "Pokéblock Kit", "Letter", "Eon Ticket", "Scanner", "Go-Goggles", "Meteorite", "Key to Room 1", "Key to Room 2", "Key to Room 4", "Key to Room 6", "Storage Key", "Devon Scope", "S.S. Ticket", "HM07", "Devon Scuba Gear", "Contest Costume", "Contest Costume", "Magma Suit", "Aqua Suit", "Pair of Tickets", "Mega Bracelet", "Mega Pendant", "Mega Glasses", "Mega Anchor", "Mega Stickpin", "Mega Tiara", "Mega Anklet", "Meteorite", "Swampertite", "Sceptilite", "Sablenite", "Altarianite", "Galladite", "Audinite", "Metagrossite", "Sharpedonite", "Slowbronite", "Steelixite", "Pidgeotite", "Glalitite", "Diancite", "Prison Bottle", "Mega Cuff", "Cameruptite", "Lopunnite", "Salamencite", "Beedrillite", "Meteorite", "Meteorite", "Key Stone", "Meteorite Shard", "Eon Flute" };
                return data;
            }
        }

        public string[] Item7
        {
            get
            {
                string[] data = { "None", "Master Ball", "Ultra Ball", "Great Ball", "Poké Ball", "Safari Ball", "Net Ball", "Dive Ball", "Nest Ball", "Repeat Ball", "Timer Ball", "Luxury Ball", "Premier Ball", "Dusk Ball", "Heal Ball", "Quick Ball", "Cherish Ball", "Potion", "Antidote", "Burn Heal", "Ice Heal", "Awakening", "Paralyze Heal", "Full Restore", "Max Potion", "Hyper Potion", "Super Potion", "Full Heal", "Revive", "Max Revive", "Fresh Water", "Soda Pop", "Lemonade", "Moomoo Milk", "Energy Powder", "Energy Root", "Heal Powder", "Revival Herb", "Ether", "Max Ether", "Elixir", "Max Elixir", "Lava Cookie", "Berry Juice", "Sacred Ash", "HP Up", "Protein", "Iron", "Carbos", "Calcium", "Rare Candy", "PP Up", "Zinc", "PP Max", "Old Gateau", "Guard Spec.", "Dire Hit", "X Attack", "X Defense", "X Speed", "X Accuracy", "X Sp. Atk", "X Sp. Def", "Poké Doll", "Fluffy Tail", "Blue Flute", "Yellow Flute", "Red Flute", "Black Flute", "White Flute", "Shoal Salt", "Shoal Shell", "Red Shard", "Blue Shard", "Yellow Shard", "Green Shard", "Super Repel", "Max Repel", "Escape Rope", "Repel", "Sun Stone", "Moon Stone", "Fire Stone", "Thunder Stone", "Water Stone", "Leaf Stone", "Tiny Mushroom", "Big Mushroom", "Pearl", "Big Pearl", "Stardust", "Star Piece", "Nugget", "Heart Scale", "Honey", "Growth Mulch", "Damp Mulch", "Stable Mulch", "Gooey Mulch", "Root Fossil", "Claw Fossil", "Helix Fossil", "Dome Fossil", "Old Amber", "Armor Fossil", "Skull Fossil", "Rare Bone", "Shiny Stone", "Dusk Stone", "Dawn Stone", "Oval Stone", "Odd Keystone", "Griseous Orb", "???", "???", "???", "Douse Drive", "Shock Drive", "Burn Drive", "Chill Drive", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Sweet Heart", "Adamant Orb", "Lustrous Orb", "Greet Mail", "Favored Mail", "RSVP Mail", "Thanks Mail", "Inquiry Mail", "Like Mail", "Reply Mail", "Bridge Mail S", "Bridge Mail D", "Bridge Mail T", "Bridge Mail V", "Bridge Mail M", "Cheri Berry", "Chesto Berry", "Pecha Berry", "Rawst Berry", "Aspear Berry", "Leppa Berry", "Oran Berry", "Persim Berry", "Lum Berry", "Sitrus Berry", "Figy Berry", "Wiki Berry", "Mago Berry", "Aguav Berry", "Iapapa Berry", "Razz Berry", "Bluk Berry", "Nanab Berry", "Wepear Berry", "Pinap Berry", "Pomeg Berry", "Kelpsy Berry", "Qualot Berry", "Hondew Berry", "Grepa Berry", "Tamato Berry", "Cornn Berry", "Magost Berry", "Rabuta Berry", "Nomel Berry", "Spelon Berry", "Pamtre Berry", "Watmel Berry", "Durin Berry", "Belue Berry", "Occa Berry", "Passho Berry", "Wacan Berry", "Rindo Berry", "Yache Berry", "Chople Berry", "Kebia Berry", "Shuca Berry", "Coba Berry", "Payapa Berry", "Tanga Berry", "Charti Berry", "Kasib Berry", "Haban Berry", "Colbur Berry", "Babiri Berry", "Chilan Berry", "Liechi Berry", "Ganlon Berry", "Salac Berry", "Petaya Berry", "Apicot Berry", "Lansat Berry", "Starf Berry", "Enigma Berry", "Micle Berry", "Custap Berry", "Jaboca Berry", "Rowap Berry", "Bright Powder", "White Herb", "Macho Brace", "Exp. Share", "Quick Claw", "Soothe Bell", "Mental Herb", "Choice Band", "King’s Rock", "Silver Powder", "Amulet Coin", "Cleanse Tag", "Soul Dew", "Deep Sea Tooth", "Deep Sea Scale", "Smoke Ball", "Everstone", "Focus Band", "Lucky Egg", "Scope Lens", "Metal Coat", "Leftovers", "Dragon Scale", "Light Ball", "Soft Sand", "Hard Stone", "Miracle Seed", "Black Glasses", "Black Belt", "Magnet", "Mystic Water", "Sharp Beak", "Poison Barb", "Never-Melt Ice", "Spell Tag", "Twisted Spoon", "Charcoal", "Dragon Fang", "Silk Scarf", "Up-Grade", "Shell Bell", "Sea Incense", "Lax Incense", "Lucky Punch", "Metal Powder", "Thick Club", "Stick", "Red Scarf", "Blue Scarf", "Pink Scarf", "Green Scarf", "Yellow Scarf", "Wide Lens", "Muscle Band", "Wise Glasses", "Expert Belt", "Light Clay", "Life Orb", "Power Herb", "Toxic Orb", "Flame Orb", "Quick Powder", "Focus Sash", "Zoom Lens", "Metronome", "Iron Ball", "Lagging Tail", "Destiny Knot", "Black Sludge", "Icy Rock", "Smooth Rock", "Heat Rock", "Damp Rock", "Grip Claw", "Choice Scarf", "Sticky Barb", "Power Bracer", "Power Belt", "Power Lens", "Power Band", "Power Anklet", "Power Weight", "Shed Shell", "Big Root", "Choice Specs", "Flame Plate", "Splash Plate", "Zap Plate", "Meadow Plate", "Icicle Plate", "Fist Plate", "Toxic Plate", "Earth Plate", "Sky Plate", "Mind Plate", "Insect Plate", "Stone Plate", "Spooky Plate", "Draco Plate", "Dread Plate", "Iron Plate", "Odd Incense", "Rock Incense", "Full Incense", "Wave Incense", "Rose Incense", "Luck Incense", "Pure Incense", "Protector", "Electirizer", "Magmarizer", "Dubious Disc", "Reaper Cloth", "Razor Claw", "Razor Fang", "TM01", "TM02", "TM03", "TM04", "TM05", "TM06", "TM07", "TM08", "TM09", "TM10", "TM11", "TM12", "TM13", "TM14", "TM15", "TM16", "TM17", "TM18", "TM19", "TM20", "TM21", "TM22", "TM23", "TM24", "TM25", "TM26", "TM27", "TM28", "TM29", "TM30", "TM31", "TM32", "TM33", "TM34", "TM35", "TM36", "TM37", "TM38", "TM39", "TM40", "TM41", "TM42", "TM43", "TM44", "TM45", "TM46", "TM47", "TM48", "TM49", "TM50", "TM51", "TM52", "TM53", "TM54", "TM55", "TM56", "TM57", "TM58", "TM59", "TM60", "TM61", "TM62", "TM63", "TM64", "TM65", "TM66", "TM67", "TM68", "TM69", "TM70", "TM71", "TM72", "TM73", "TM74", "TM75", "TM76", "TM77", "TM78", "TM79", "TM80", "TM81", "TM82", "TM83", "TM84", "TM85", "TM86", "TM87", "TM88", "TM89", "TM90", "TM91", "TM92", "HM01", "HM02", "HM03", "HM04", "HM05", "HM06", "???", "???", "Explorer Kit", "Loot Sack", "Rule Book", "Poké Radar", "Point Card", "Journal", "Seal Case", "Fashion Case", "Seal Bag", "Pal Pad", "Works Key", "Old Charm", "Galactic Key", "Red Chain", "Town Map", "Vs. Seeker", "Coin Case", "Old Rod", "Good Rod", "Super Rod", "Sprayduck", "Poffin Case", "Bike", "Suite Key", "Oak’s Letter", "Lunar Wing", "Member Card", "Azure Flute", "S.S. Ticket", "Contest Pass", "Magma Stone", "Parcel", "Coupon 1", "Coupon 2", "Coupon 3", "Storage Key", "Secret Potion", "Vs. Recorder", "Gracidea", "Secret Key", "Apricorn Box", "Unown Report", "Berry Pots", "Dowsing Machine", "Blue Card", "Slowpoke Tail", "Clear Bell", "Card Key", "Basement Key", "Squirt Bottle", "Red Scale", "Lost Item", "Pass", "Machine Part", "Silver Wing", "Rainbow Wing", "Mystery Egg", "Red Apricorn", "Blue Apricorn", "Yellow Apricorn", "Green Apricorn", "Pink Apricorn", "White Apricorn", "Black Apricorn", "Fast Ball", "Level Ball", "Lure Ball", "Heavy Ball", "Love Ball", "Friend Ball", "Moon Ball", "Sport Ball", "Park Ball", "Photo Album", "GB Sounds", "Tidal Bell", "Rage Candy Bar", "Data Card 01", "Data Card 02", "Data Card 03", "Data Card 04", "Data Card 05", "Data Card 06", "Data Card 07", "Data Card 08", "Data Card 09", "Data Card 10", "Data Card 11", "Data Card 12", "Data Card 13", "Data Card 14", "Data Card 15", "Data Card 16", "Data Card 17", "Data Card 18", "Data Card 19", "Data Card 20", "Data Card 21", "Data Card 22", "Data Card 23", "Data Card 24", "Data Card 25", "Data Card 26", "Data Card 27", "Jade Orb", "Lock Capsule", "Red Orb", "Blue Orb", "Enigma Stone", "Prism Scale", "Eviolite", "Float Stone", "Rocky Helmet", "Air Balloon", "Red Card", "Ring Target", "Binding Band", "Absorb Bulb", "Cell Battery", "Eject Button", "Fire Gem", "Water Gem", "Electric Gem", "Grass Gem", "Ice Gem", "Fighting Gem", "Poison Gem", "Ground Gem", "Flying Gem", "Psychic Gem", "Bug Gem", "Rock Gem", "Ghost Gem", "Dragon Gem", "Dark Gem", "Steel Gem", "Normal Gem", "Health Wing", "Muscle Wing", "Resist Wing", "Genius Wing", "Clever Wing", "Swift Wing", "Pretty Wing", "Cover Fossil", "Plume Fossil", "Liberty Pass", "Pass Orb", "Dream Ball", "Poké Toy", "Prop Case", "Dragon Skull", "Balm Mushroom", "Big Nugget", "Pearl String", "Comet Shard", "Relic Copper", "Relic Silver", "Relic Gold", "Relic Vase", "Relic Band", "Relic Statue", "Relic Crown", "Casteliacone", "Dire Hit 2", "X Speed 2", "X Sp. Atk 2", "X Sp. Def 2", "X Defense 2", "X Attack 2", "X Accuracy 2", "X Speed 3", "X Sp. Atk 3", "X Sp. Def 3", "X Defense 3", "X Attack 3", "X Accuracy 3", "X Speed 6", "X Sp. Atk 6", "X Sp. Def 6", "X Defense 6", "X Attack 6", "X Accuracy 6", "Ability Urge", "Item Drop", "Item Urge", "Reset Urge", "Dire Hit 3", "Light Stone", "Dark Stone", "TM93", "TM94", "TM95", "Xtransceiver", "???", "Gram 1", "Gram 2", "Gram 3", "Xtransceiver", "Medal Box", "DNA Splicers", "DNA Splicers", "Permit", "Oval Charm", "Shiny Charm", "Plasma Card", "Grubby Hanky", "Colress Machine", "Dropped Item", "Dropped Item", "Reveal Glass", "Weakness Policy", "Assault Vest", "Holo Caster", "Prof’s Letter", "Roller Skates", "Pixie Plate", "Ability Capsule", "Whipped Dream", "Sachet", "Luminous Moss", "Snowball", "Safety Goggles", "Poké Flute", "Rich Mulch", "Surprise Mulch", "Boost Mulch", "Amaze Mulch", "Gengarite", "Gardevoirite", "Ampharosite", "Venusaurite", "Charizardite X", "Blastoisinite", "Mewtwonite X", "Mewtwonite Y", "Blazikenite", "Medichamite", "Houndoominite", "Aggronite", "Banettite", "Tyranitarite", "Scizorite", "Pinsirite", "Aerodactylite", "Lucarionite", "Abomasite", "Kangaskhanite", "Gyaradosite", "Absolite", "Charizardite Y", "Alakazite", "Heracronite", "Mawilite", "Manectite", "Garchompite", "Latiasite", "Latiosite", "Roseli Berry", "Kee Berry", "Maranga Berry", "Sprinklotad", "TM96", "TM97", "TM98", "TM99", "TM100", "Power Plant Pass", "Mega Ring", "Intriguing Stone", "Common Stone", "Discount Coupon", "Elevator Key", "TMV Pass", "Honor of Kalos", "Adventure Rules", "Strange Souvenir", "Lens Case", "Makeup Bag", "Travel Trunk", "Lumiose Galette", "Shalour Sable", "Jaw Fossil", "Sail Fossil", "Looker Ticket", "Bike", "Holo Caster", "Fairy Gem", "Mega Charm", "Mega Glove", "Mach Bike", "Acro Bike", "Wailmer Pail", "Devon Parts", "Soot Sack", "Basement Key", "Pokéblock Kit", "Letter", "Eon Ticket", "Scanner", "Go-Goggles", "Meteorite", "Key to Room 1", "Key to Room 2", "Key to Room 4", "Key to Room 6", "Storage Key", "Devon Scope", "S.S. Ticket", "HM07", "Devon Scuba Gear", "Contest Costume", "Contest Costume", "Magma Suit", "Aqua Suit", "Pair of Tickets", "Mega Bracelet", "Mega Pendant", "Mega Glasses", "Mega Anchor", "Mega Stickpin", "Mega Tiara", "Mega Anklet", "Meteorite", "Swampertite", "Sceptilite", "Sablenite", "Altarianite", "Galladite", "Audinite", "Metagrossite", "Sharpedonite", "Slowbronite", "Steelixite", "Pidgeotite", "Glalitite", "Diancite", "Prison Bottle", "Mega Cuff", "Cameruptite", "Lopunnite", "Salamencite", "Beedrillite", "Meteorite", "Meteorite", "Key Stone", "Meteorite Shard", "Eon Flute", "Normalium Z", "Firium Z", "Waterium Z", "Electrium Z", "Grassium Z", "Icium Z", "Fightinium Z", "Poisonium Z", "Groundium Z", "Flyinium Z", "Psychium Z", "Buginium Z", "Rockium Z", "Ghostium Z", "Dragonium Z", "Darkinium Z", "Steelium Z", "Fairium Z", "Pikanium Z", "Bottle Cap", "Gold Bottle Cap", "Z-Ring", "Decidium Z", "Incinium Z", "Primarium Z", "Tapunium Z", "Marshadium Z", "Aloraichium Z", "Snorlium Z", "Eevium Z", "Mewnium Z", "Normalium Z", "Firium Z", "Waterium Z", "Electrium Z", "Grassium Z", "Icium Z", "Fightinium Z", "Poisonium Z", "Groundium Z", "Flyinium Z", "Psychium Z", "Buginium Z", "Rockium Z", "Ghostium Z", "Dragonium Z", "Darkinium Z", "Steelium Z", "Fairium Z", "Pikanium Z", "Decidium Z", "Incinium Z", "Primarium Z", "Tapunium Z", "Marshadium Z", "Aloraichium Z", "Snorlium Z", "Eevium Z", "Mewnium Z", "Pikashunium Z", "Pikashunium Z", "???", "???", "???", "???", "Forage Bag", "Fishing Rod", "Professor’s Mask", "Festival Ticket", "Sparkling Stone", "Adrenaline Orb", "Zygarde Cube", "???", "Ice Stone", "Ride Pager", "Beast Ball", "Big Malasada", "Red Nectar", "Yellow Nectar", "Pink Nectar", "Purple Nectar", "Sun Flute", "Moon Flute", "???", "Enigmatic Card", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Terrain Extender", "Protective Pads", "Electric Seed", "Psychic Seed", "Misty Seed", "Grassy Seed", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "???", "Fighting Memory", "Flying Memory", "Poison Memory", "Ground Memory", "Rock Memory", "Bug Memory", "Ghost Memory", "Steel Memory", "Fire Memory", "Water Memory", "Grass Memory", "Electric Memory", "Psychic Memory", "Ice Memory", "Dragon Memory", "Dark Memory", "Fairy Memory" };
                return data;
            }
        }

        #endregion Items

        #region Ability

        public string[] Ability6
        {
            get
            {
                string[] data = { "Stench", "Drizzle", "Speed Boost", "Battle Armor", "Sturdy", "Damp", "Limber", "Sand Veil", "Static", "Volt Absorb", "Water Absorb", "Oblivious", "Cloud Nine", "Compound Eyes", "Insomnia", "Color Change", "Immunity", "Flash Fire", "Shield Dust", "Own Tempo", "Suction Cups", "Intimidate", "Shadow Tag", "Rough Skin", "Wonder Guard", "Levitate", "Effect Spore", "Synchronize", "Clear Body", "Natural Cure", "Lightning Rod", "Serene Grace", "Swift Swim", "Chlorophyll", "Illuminate", "Trace", "Huge Power", "Poison Point", "Inner Focus", "Magma Armor", "Water Veil", "Magnet Pull", "Soundproof", "Rain Dish", "Sand Stream", "Pressure", "Thick Fat", "Early Bird", "Flame Body", "Run Away", "Keen Eye", "Hyper Cutter", "Pickup", "Truant", "Hustle", "Cute Charm", "Plus", "Minus", "Forecast", "Sticky Hold", "Shed Skin", "Guts", "Marvel Scale", "Liquid Ooze", "Overgrow", "Blaze", "Torrent", "Swarm", "Rock Head", "Drought", "Arena Trap", "Vital Spirit", "White Smoke", "Pure Power", "Shell Armor", "Air Lock", "Tangled Feet", "Motor Drive", "Rivalry", "Steadfast", "Snow Cloak", "Gluttony", "Anger Point", "Unburden", "Heatproof", "Simple", "Dry Skin", "Download", "Iron Fist", "Poison Heal", "Adaptability", "Skill Link", "Hydration", "Solar Power", "Quick Feet", "Normalize", "Sniper", "Magic Guard", "No Guard", "Stall", "Technician", "Leaf Guard", "Klutz", "Mold Breaker", "Super Luck", "Aftermath", "Anticipation", "Forewarn", "Unaware", "Tinted Lens", "Filter", "Slow Start", "Scrappy", "Storm Drain", "Ice Body", "Solid Rock", "Snow Warning", "Honey Gather", "Frisk", "Reckless", "Multitype", "Flower Gift", "Bad Dreams", "Pickpocket", "Sheer Force", "Contrary", "Unnerve", "Defiant", "Defeatist", "Cursed Body", "Healer", "Friend Guard", "Weak Armor", "Heavy Metal", "Light Metal", "Multiscale", "Toxic Boost", "Flare Boost", "Harvest", "Telepathy", "Moody", "Overcoat", "Poison Touch", "Regenerator", "Big Pecks", "Sand Rush", "Wonder Skin", "Analytic", "Illusion", "Imposter", "Infiltrator", "Mummy", "Moxie", "Justified", "Rattled", "Magic Bounce", "Sap Sipper", "Prankster", "Sand Force", "Iron Barbs", "Zen Mode", "Victory Star", "Turboblaze", "Teravolt", "Aroma Veil", "Flower Veil", "Cheek Pouch", "Protean", "Fur Coat", "Magician", "Bulletproof", "Competitive", "Strong Jaw", "Refrigerate", "Sweet Veil", "Stance Change", "Gale Wings", "Mega Launcher", "Grass Pelt", "Symbiosis", "Tough Claws", "Pixilate", "Gooey", "Aerilate", "Parental Bond", "Dark Aura", "Fairy Aura", "Aura Break", "Primordial Sea", "Desolate Land", "Delta Stream" };
                return data;
            }
        }

        public string[] Ability7
        {
            get
            {
                string[] data = { "Stench", "Drizzle", "Speed Boost", "Battle Armor", "Sturdy", "Damp", "Limber", "Sand Veil", "Static", "Volt Absorb", "Water Absorb", "Oblivious", "Cloud Nine", "Compound Eyes", "Insomnia", "Color Change", "Immunity", "Flash Fire", "Shield Dust", "Own Tempo", "Suction Cups", "Intimidate", "Shadow Tag", "Rough Skin", "Wonder Guard", "Levitate", "Effect Spore", "Synchronize", "Clear Body", "Natural Cure", "Lightning Rod", "Serene Grace", "Swift Swim", "Chlorophyll", "Illuminate", "Trace", "Huge Power", "Poison Point", "Inner Focus", "Magma Armor", "Water Veil", "Magnet Pull", "Soundproof", "Rain Dish", "Sand Stream", "Pressure", "Thick Fat", "Early Bird", "Flame Body", "Run Away", "Keen Eye", "Hyper Cutter", "Pickup", "Truant", "Hustle", "Cute Charm", "Plus", "Minus", "Forecast", "Sticky Hold", "Shed Skin", "Guts", "Marvel Scale", "Liquid Ooze", "Overgrow", "Blaze", "Torrent", "Swarm", "Rock Head", "Drought", "Arena Trap", "Vital Spirit", "White Smoke", "Pure Power", "Shell Armor", "Air Lock", "Tangled Feet", "Motor Drive", "Rivalry", "Steadfast", "Snow Cloak", "Gluttony", "Anger Point", "Unburden", "Heatproof", "Simple", "Dry Skin", "Download", "Iron Fist", "Poison Heal", "Adaptability", "Skill Link", "Hydration", "Solar Power", "Quick Feet", "Normalize", "Sniper", "Magic Guard", "No Guard", "Stall", "Technician", "Leaf Guard", "Klutz", "Mold Breaker", "Super Luck", "Aftermath", "Anticipation", "Forewarn", "Unaware", "Tinted Lens", "Filter", "Slow Start", "Scrappy", "Storm Drain", "Ice Body", "Solid Rock", "Snow Warning", "Honey Gather", "Frisk", "Reckless", "Multitype", "Flower Gift", "Bad Dreams", "Pickpocket", "Sheer Force", "Contrary", "Unnerve", "Defiant", "Defeatist", "Cursed Body", "Healer", "Friend Guard", "Weak Armor", "Heavy Metal", "Light Metal", "Multiscale", "Toxic Boost", "Flare Boost", "Harvest", "Telepathy", "Moody", "Overcoat", "Poison Touch", "Regenerator", "Big Pecks", "Sand Rush", "Wonder Skin", "Analytic", "Illusion", "Imposter", "Infiltrator", "Mummy", "Moxie", "Justified", "Rattled", "Magic Bounce", "Sap Sipper", "Prankster", "Sand Force", "Iron Barbs", "Zen Mode", "Victory Star", "Turboblaze", "Teravolt", "Aroma Veil", "Flower Veil", "Cheek Pouch", "Protean", "Fur Coat", "Magician", "Bulletproof", "Competitive", "Strong Jaw", "Refrigerate", "Sweet Veil", "Stance Change", "Gale Wings", "Mega Launcher", "Grass Pelt", "Symbiosis", "Tough Claws", "Pixilate", "Gooey", "Aerilate", "Parental Bond", "Dark Aura", "Fairy Aura", "Aura Break", "Primordial Sea", "Desolate Land", "Delta Stream", "Stamina", "Wimp Out", "Emergency Exit", "Water Compaction", "Merciless", "Shields Down", "Stakeout", "Water Bubble", "Steelworker", "Berserk", "Slush Rush", "Long Reach", "Liquid Voice", "Triage", "Galvanize", "Surge Surfer", "Schooling", "Disguise", "Battle Bond", "Power Construct", "Corrosion", "Comatose", "Queenly Majesty", "Innards Out", "Dancer", "Battery", "Fluffy", "Dazzling", "Soul-Heart", "Tangling Hair", "Receiver", "Power of Alchemy", "Beast Boost", "RKS System", "Electric Surge", "Psychic Surge", "Misty Surge", "Grassy Surge", "Full Metal Body", "Shadow Shield", "Prism Armor" };
                return data;
            }
        }

        public int[] getAbilities(int species, int forme)
        {
            switch (species)
            {
                case 1: return new int[] { 65, 65, 34 }; // Bulbasaur
                case 2: return new int[] { 65, 65, 34 }; // Ivysaur
                case 3: return new int[] { 65, 65, 34 }; // Venusaur
                //case 3: return new int[] { 47, 47, 47 }; // Mega Venusaur
                case 4: return new int[] { 66, 66, 94 }; // Charmander
                case 5: return new int[] { 66, 66, 94 }; // Charmeleon
                case 6: return new int[] { 66, 66, 94 }; // Charizard
                //case 6: return new int[] { 181, 181, 181 }; // Mega Charizard X
                //case 6: return new int[] { 70, 70, 70 }; // Mega Charizard Y
                case 7: return new int[] { 67, 67, 44 }; // Squirtle
                case 8: return new int[] { 67, 67, 44 }; // Wartortle
                case 9: return new int[] { 67, 67, 44 }; // Blastoise
                //case 9: return new int[] { 178, 178, 178 }; // Mega Blastoise
                case 10: return new int[] { 19, 19, 50 }; // Caterpie
                case 11: return new int[] { 61, 61, 61 }; // Metapod
                case 12: return new int[] { 14, 14, 110 }; // Butterfree
                case 13: return new int[] { 19, 19, 50 }; // Weedle
                case 14: return new int[] { 61, 61, 61 }; // Kakuna
                case 15: return new int[] { 68, 68, 97 }; // Beedrill
                //case 15: return new int[] { 91, 91, 91 }; // Mega Beedrill
                case 16: return new int[] { 51, 77, 145 }; // Pidgey
                case 17: return new int[] { 51, 77, 145 }; // Pidgeotto
                case 18: return new int[] { 51, 77, 145 }; // Pidgeot
                //case 18: return new int[] { 99, 99, 99 }; // Mega Pidgeot
                case 19: return new int[] { 50, 62, 55 }; // Rattata
                case 20: return new int[] { 50, 62, 55 }; // Raticate
                case 21: return new int[] { 51, 51, 97 }; // Spearow
                case 22: return new int[] { 51, 51, 97 }; // Fearow
                case 23: return new int[] { 22, 61, 127 }; // Ekans
                case 24: return new int[] { 22, 61, 127 }; // Arbok
                case 25: return new int[] { 9, 9, 31 }; // Pikachu
                //case 25: return new int[] { 31, 31, 31 }; // Cosplay Pikachu
                case 26: return new int[] { 9, 9, 31 }; // Raichu
                case 27: return new int[] { 8, 8, 146 }; // Sandshrew
                case 28: return new int[] { 8, 8, 146 }; // Sandslash
                case 29: return new int[] { 38, 79, 55 }; // Nidoran♀
                case 30: return new int[] { 38, 79, 55 }; // Nidorina
                case 31: return new int[] { 38, 79, 125 }; // Nidoqueen
                case 32: return new int[] { 38, 79, 55 }; // Nidoran♂
                case 33: return new int[] { 38, 79, 55 }; // Nidorino
                case 34: return new int[] { 38, 79, 125 }; // Nidoking
                case 35: return new int[] { 56, 98, 132 }; // Clefairy
                case 36: return new int[] { 56, 98, 109 }; // Clefable
                case 37: return new int[] { 18, 18, 70 }; // Vulpix
                case 38: return new int[] { 18, 18, 70 }; // Ninetales
                case 39: return new int[] { 56, 172, 132 }; // Jigglypuff
                case 40: return new int[] { 56, 172, 119 }; // Wigglytuff
                case 41: return new int[] { 39, 39, 151 }; // Zubat
                case 42: return new int[] { 39, 39, 151 }; // Golbat
                case 43: return new int[] { 34, 34, 50 }; // Oddish
                case 44: return new int[] { 34, 34, 1 }; // Gloom
                case 45: return new int[] { 34, 34, 27 }; // Vileplume
                case 46: return new int[] { 27, 87, 6 }; // Paras
                case 47: return new int[] { 27, 87, 6 }; // Parasect
                case 48: return new int[] { 14, 110, 50 }; // Venonat
                case 49: return new int[] { 19, 110, 147 }; // Venomoth
                case 50: return new int[] { 8, 71, 159 }; // Diglett
                case 51: return new int[] { 8, 71, 159 }; // Dugtrio
                case 52: return new int[] { 53, 101, 127 }; // Meowth
                case 53: return new int[] { 7, 101, 127 }; // Persian
                case 54: return new int[] { 6, 13, 33 }; // Psyduck
                case 55: return new int[] { 6, 13, 33 }; // Golduck
                case 56: return new int[] { 72, 83, 128 }; // Mankey
                case 57: return new int[] { 72, 83, 128 }; // Primeape
                case 58: return new int[] { 22, 18, 154 }; // Growlithe
                case 59: return new int[] { 22, 18, 154 }; // Arcanine
                case 60: return new int[] { 11, 6, 33 }; // Poliwag
                case 61: return new int[] { 11, 6, 33 }; // Poliwhirl
                case 62: return new int[] { 11, 6, 33 }; // Poliwrath
                case 63: return new int[] { 28, 39, 98 }; // Abra
                case 64: return new int[] { 28, 39, 98 }; // Kadabra
                case 65: return new int[] { 28, 39, 98 }; // Alakazam
                //case 65: return new int[] { 36, 36, 36 }; // Mega Alakazam
                case 66: return new int[] { 62, 99, 80 }; // Machop
                case 67: return new int[] { 62, 99, 80 }; // Machoke
                case 68: return new int[] { 62, 99, 80 }; // Machamp
                case 69: return new int[] { 34, 34, 82 }; // Bellsprout
                case 70: return new int[] { 34, 34, 82 }; // Weepinbell
                case 71: return new int[] { 34, 34, 82 }; // Victreebel
                case 72: return new int[] { 29, 64, 44 }; // Tentacool
                case 73: return new int[] { 29, 64, 44 }; // Tentacruel
                case 74: return new int[] { 69, 5, 8 }; // Geodude
                case 75: return new int[] { 69, 5, 8 }; // Graveler
                case 76: return new int[] { 69, 5, 8 }; // Golem
                case 77: return new int[] { 50, 18, 49 }; // Ponyta
                case 78: return new int[] { 50, 18, 49 }; // Rapidash
                case 79: return new int[] { 12, 20, 144 }; // Slowpoke
                case 80: return new int[] { 12, 20, 144 }; // Slowbro
                //case 80: return new int[] { 75, 75, 75 }; // Mega Slowbro
                case 81: return new int[] { 42, 5, 148 }; // Magnemite
                case 82: return new int[] { 42, 5, 148 }; // Magneton
                case 83: return new int[] { 51, 39, 128 }; // Farfetch'd
                case 84: return new int[] { 50, 48, 77 }; // Doduo
                case 85: return new int[] { 50, 48, 77 }; // Dodrio
                case 86: return new int[] { 47, 93, 115 }; // Seel
                case 87: return new int[] { 47, 93, 115 }; // Dewgong
                case 88: return new int[] { 1, 60, 143 }; // Grimer
                case 89: return new int[] { 1, 60, 143 }; // Muk
                case 90: return new int[] { 75, 92, 142 }; // Shellder
                case 91: return new int[] { 75, 92, 142 }; // Cloyster
                case 92: return new int[] { 26, 26, 26 }; // Gastly
                case 93: return new int[] { 26, 26, 26 }; // Haunter
                case 94: return new int[] { 26, 26, 26 }; // Gengar
                //case 94: return new int[] { 23, 23, 23 }; // Mega Gengar
                case 95: return new int[] { 69, 5, 133 }; // Onix
                case 96: return new int[] { 15, 108, 39 }; // Drowzee
                case 97: return new int[] { 15, 108, 39 }; // Hypno
                case 98: return new int[] { 52, 75, 125 }; // Krabby
                case 99: return new int[] { 52, 75, 125 }; // Kingler
                case 100: return new int[] { 43, 9, 106 }; // Voltorb
                case 101: return new int[] { 43, 9, 106 }; // Electrode
                case 102: return new int[] { 34, 34, 139 }; // Exeggcute
                case 103: return new int[] { 34, 34, 139 }; // Exeggutor
                case 104: return new int[] { 69, 31, 4 }; // Cubone
                case 105: return new int[] { 69, 31, 4 }; // Marowak
                case 106: return new int[] { 7, 120, 84 }; // Hitmonlee
                case 107: return new int[] { 51, 89, 39 }; // Hitmonchan
                case 108: return new int[] { 20, 12, 13 }; // Lickitung
                case 109: return new int[] { 26, 26, 26 }; // Koffing
                case 110: return new int[] { 26, 26, 26 }; // Weezing
                case 111: return new int[] { 31, 69, 120 }; // Rhyhorn
                case 112: return new int[] { 31, 69, 120 }; // Rhydon
                case 113: return new int[] { 30, 32, 131 }; // Chansey
                case 114: return new int[] { 34, 102, 144 }; // Tangela
                case 115: return new int[] { 48, 113, 39 }; // Kangaskhan
                //case 115: return new int[] { 185, 185, 185 }; // Mega Kangaskhan
                case 116: return new int[] { 33, 97, 6 }; // Horsea
                case 117: return new int[] { 38, 97, 6 }; // Seadra
                case 118: return new int[] { 33, 41, 31 }; // Goldeen
                case 119: return new int[] { 33, 41, 31 }; // Seaking
                case 120: return new int[] { 35, 30, 148 }; // Staryu
                case 121: return new int[] { 35, 30, 148 }; // Starmie
                case 122: return new int[] { 43, 111, 101 }; // Mr. Mime
                case 123: return new int[] { 68, 101, 80 }; // Scyther
                case 124: return new int[] { 12, 108, 87 }; // Jynx
                case 125: return new int[] { 9, 9, 72 }; // Electabuzz
                case 126: return new int[] { 49, 49, 72 }; // Magmar
                case 127: return new int[] { 52, 104, 153 }; // Pinsir
                //case 127: return new int[] { 184, 184, 184 }; // Mega Pinsir
                case 128: return new int[] { 22, 83, 125 }; // Tauros
                case 129: return new int[] { 33, 33, 155 }; // Magikarp
                case 130: return new int[] { 22, 22, 153 }; // Gyarados
                //case 130: return new int[] { 104, 104, 104 }; // Mega Gyarados
                case 131: return new int[] { 11, 75, 93 }; // Lapras
                case 132: return new int[] { 7, 7, 150 }; // Ditto
                case 133: return new int[] { 50, 91, 107 }; // Eevee
                case 134: return new int[] { 11, 11, 93 }; // Vaporeon
                case 135: return new int[] { 10, 10, 95 }; // Jolteon
                case 136: return new int[] { 18, 18, 62 }; // Flareon
                case 137: return new int[] { 36, 88, 148 }; // Porygon
                case 138: return new int[] { 33, 75, 133 }; // Omanyte
                case 139: return new int[] { 33, 75, 133 }; // Omastar
                case 140: return new int[] { 33, 4, 133 }; // Kabuto
                case 141: return new int[] { 33, 4, 133 }; // Kabutops
                case 142: return new int[] { 69, 46, 127 }; // Aerodactyl
                //case 142: return new int[] { 181, 181, 181 }; // Mega Aerodactyl
                case 143: return new int[] { 17, 47, 82 }; // Snorlax
                case 144: return new int[] { 46, 46, 81 }; // Articuno
                case 145: return new int[] { 46, 46, 9 }; // Zapdos*
                case 146: return new int[] { 46, 46, 49 }; // Moltres
                case 147: return new int[] { 61, 61, 63 }; // Dratini
                case 148: return new int[] { 61, 61, 63 }; // Dragonair
                case 149: return new int[] { 39, 39, 136 }; // Dragonite
                case 150: return new int[] { 46, 46, 127 }; // Mewtwo
                //case 150: return new int[] { 80, 80, 80 }; // Mega Mewtwo X
                //case 150: return new int[] { 15, 15, 15 }; // Mega Mewtwo Y
                case 151: return new int[] { 28, 28, 28 }; // Mew
                case 152: return new int[] { 65, 65, 102 }; // Chikorita
                case 153: return new int[] { 65, 65, 102 }; // Bayleef
                case 154: return new int[] { 65, 65, 102 }; // Meganium
                case 155: return new int[] { 66, 66, 18 }; // Cyndaquil
                case 156: return new int[] { 66, 66, 18 }; // Quilava
                case 157: return new int[] { 66, 66, 18 }; // Typhlosion
                case 158: return new int[] { 67, 67, 125 }; // Totodile
                case 159: return new int[] { 67, 67, 125 }; // Croconaw
                case 160: return new int[] { 67, 67, 125 }; // Feraligatr
                case 161: return new int[] { 50, 51, 119 }; // Sentret
                case 162: return new int[] { 50, 51, 119 }; // Furret
                case 163: return new int[] { 15, 51, 110 }; // Hoothoot
                case 164: return new int[] { 15, 51, 110 }; // Noctowl
                case 165: return new int[] { 68, 48, 155 }; // Ledyba
                case 166: return new int[] { 68, 48, 89 }; // Ledian
                case 167: return new int[] { 68, 15, 97 }; // Spinarak
                case 168: return new int[] { 68, 15, 97 }; // Ariados
                case 169: return new int[] { 39, 39, 151 }; // Crobat
                case 170: return new int[] { 10, 35, 11 }; // Chinchou
                case 171: return new int[] { 10, 35, 11 }; // Lanturn
                case 172: return new int[] { 9, 9, 31 }; // Pichu
                case 173: return new int[] { 56, 98, 132 }; // Cleffa
                case 174: return new int[] { 56, 172, 132 }; // Igglybuff
                case 175: return new int[] { 55, 32, 105 }; // Togepi
                case 176: return new int[] { 55, 32, 105 }; // Togetic
                case 177: return new int[] { 28, 48, 156 }; // Natu
                case 178: return new int[] { 28, 48, 156 }; // Xatu
                case 179: return new int[] { 9, 9, 57 }; // Mareep
                case 180: return new int[] { 9, 9, 57 }; // Flaaffy
                case 181: return new int[] { 9, 9, 57 }; // Ampharos
                //case 181: return new int[] { 104, 104, 104 }; // Mega Ampharos
                case 182: return new int[] { 34, 34, 131 }; // Bellossom
                case 183: return new int[] { 47, 37, 157 }; // Marill
                case 184: return new int[] { 47, 37, 157 }; // Azumarill
                case 185: return new int[] { 5, 69, 155 }; // Sudowoodo
                case 186: return new int[] { 11, 6, 2 }; // Politoed
                case 187: return new int[] { 34, 102, 151 }; // Hoppip
                case 188: return new int[] { 34, 102, 151 }; // Skiploom
                case 189: return new int[] { 34, 102, 151 }; // Jumpluff
                case 190: return new int[] { 50, 53, 92 }; // Aipom
                case 191: return new int[] { 34, 94, 48 }; // Sunkern
                case 192: return new int[] { 34, 94, 48 }; // Sunflora
                case 193: return new int[] { 3, 14, 119 }; // Yanma
                case 194: return new int[] { 6, 11, 109 }; // Wooper
                case 195: return new int[] { 6, 11, 109 }; // Quagsire
                case 196: return new int[] { 28, 28, 156 }; // Espeon
                case 197: return new int[] { 28, 28, 39 }; // Umbreon
                case 198: return new int[] { 15, 105, 158 }; // Murkrow
                case 199: return new int[] { 12, 20, 144 }; // Slowking
                case 200: return new int[] { 26, 26, 26 }; // Misdreavus
                case 201: return new int[] { 26, 26, 26 }; // Unown
                case 202: return new int[] { 23, 23, 140 }; // Wobbuffet
                case 203: return new int[] { 39, 48, 157 }; // Girafarig
                case 204: return new int[] { 5, 5, 142 }; // Pineco
                case 205: return new int[] { 5, 5, 142 }; // Forretress
                case 206: return new int[] { 32, 50, 155 }; // Dunsparce
                case 207: return new int[] { 52, 8, 17 }; // Gligar
                case 208: return new int[] { 69, 5, 125 }; // Steelix
                //case 208: return new int[] { 159, 159, 159 }; // Mega Steelix
                case 209: return new int[] { 22, 50, 155 }; // Snubbull
                case 210: return new int[] { 22, 95, 155 }; // Granbull
                case 211: return new int[] { 38, 33, 22 }; // Qwilfish
                case 212: return new int[] { 68, 101, 135 }; // Scizor
                //case 212: return new int[] { 101, 101, 101 }; // Mega Scizor
                case 213: return new int[] { 5, 82, 126 }; // Shuckle
                case 214: return new int[] { 68, 62, 153 }; // Heracross
                //case 214: return new int[] { 92, 92, 92 }; // Mega Heracross
                case 215: return new int[] { 39, 51, 124 }; // Sneasel
                case 216: return new int[] { 53, 95, 118 }; // Teddiursa
                case 217: return new int[] { 62, 95, 127 }; // Ursaring
                case 218: return new int[] { 40, 49, 133 }; // Slugma
                case 219: return new int[] { 40, 49, 133 }; // Magcargo
                case 220: return new int[] { 12, 81, 47 }; // Swinub
                case 221: return new int[] { 12, 81, 47 }; // Piloswine
                case 222: return new int[] { 55, 30, 144 }; // Corsola
                case 223: return new int[] { 55, 97, 141 }; // Remoraid
                case 224: return new int[] { 21, 97, 141 }; // Octillery
                case 225: return new int[] { 72, 55, 15 }; // Delibird
                case 226: return new int[] { 33, 11, 41 }; // Mantine
                case 227: return new int[] { 51, 5, 133 }; // Skarmory
                case 228: return new int[] { 48, 18, 127 }; // Houndour
                case 229: return new int[] { 48, 18, 127 }; // Houndoom
                //case 229: return new int[] { 94, 94, 94 }; // Mega Houndoom
                case 230: return new int[] { 33, 97, 6 }; // Kingdra
                case 231: return new int[] { 53, 53, 8 }; // Phanpy
                case 232: return new int[] { 5, 5, 8 }; // Donphan
                case 233: return new int[] { 36, 88, 148 }; // Porygon2
                case 234: return new int[] { 22, 119, 157 }; // Stantler
                case 235: return new int[] { 20, 101, 141 }; // Smeargle
                case 236: return new int[] { 62, 80, 72 }; // Tyrogue
                case 237: return new int[] { 22, 101, 80 }; // Hitmontop
                case 238: return new int[] { 12, 108, 93 }; // Smoochum
                case 239: return new int[] { 9, 9, 72 }; // Elekid
                case 240: return new int[] { 49, 49, 72 }; // Magby
                case 241: return new int[] { 47, 113, 157 }; // Miltank
                case 242: return new int[] { 30, 32, 131 }; // Blissey
                case 243: return new int[] { 46, 46, 10 }; // Raikou
                case 244: return new int[] { 46, 46, 18 }; // Entei
                case 245: return new int[] { 46, 46, 11 }; // Suicune
                case 246: return new int[] { 62, 62, 8 }; // Larvitar
                case 247: return new int[] { 61, 61, 61 }; // Pupitar
                case 248: return new int[] { 45, 45, 127 }; // Tyranitar
                //case 248: return new int[] { 45, 45, 45 }; // Mega Tyranitar
                case 249: return new int[] { 46, 46, 136 }; // Lugia
                case 250: return new int[] { 46, 46, 144 }; // Ho-Oh
                case 251: return new int[] { 30, 30, 30 }; // Celebi
                case 252: return new int[] { 65, 65, 84 }; // Treecko
                case 253: return new int[] { 65, 65, 84 }; // Grovyle
                case 254: return new int[] { 65, 65, 84 }; // Sceptile
                //case 254: return new int[] { 31, 31, 31 }; // Mega Sceptile
                case 255: return new int[] { 66, 66, 3 }; // Torchic
                case 256: return new int[] { 66, 66, 3 }; // Combusken
                case 257: return new int[] { 66, 66, 3 }; // Blaziken
                //case 257: return new int[] { 3, 3, 3 }; // Mega Blaziken
                case 258: return new int[] { 67, 67, 6 }; // Mudkip
                case 259: return new int[] { 67, 67, 6 }; // Marshtomp
                case 260: return new int[] { 67, 67, 6 }; // Swampert
                //case 260: return new int[] { 33, 33, 33 }; // Mega Swampert
                case 261: return new int[] { 50, 95, 155 }; // Poochyena
                case 262: return new int[] { 22, 95, 153 }; // Mightyena
                case 263: return new int[] { 53, 82, 95 }; // Zigzagoon
                case 264: return new int[] { 53, 82, 95 }; // Linoone
                case 265: return new int[] { 19, 19, 50 }; // Wurmple
                case 266: return new int[] { 61, 61, 61 }; // Silcoon
                case 267: return new int[] { 68, 68, 79 }; // Beautifly
                case 268: return new int[] { 61, 61, 61 }; // Cascoon
                case 269: return new int[] { 19, 19, 14 }; // Dustox
                case 270: return new int[] { 33, 44, 20 }; // Lotad
                case 271: return new int[] { 33, 44, 20 }; // Lombre
                case 272: return new int[] { 33, 44, 20 }; // Ludicolo
                case 273: return new int[] { 34, 48, 124 }; // Seedot
                case 274: return new int[] { 34, 48, 124 }; // Nuzleaf
                case 275: return new int[] { 34, 48, 124 }; // Shiftry
                case 276: return new int[] { 62, 62, 113 }; // Taillow
                case 277: return new int[] { 62, 62, 113 }; // Swellow
                case 278: return new int[] { 51, 51, 44 }; // Wingull
                case 279: return new int[] { 51, 51, 44 }; // Pelipper
                case 280: return new int[] { 28, 36, 140 }; // Ralts
                case 281: return new int[] { 28, 36, 140 }; // Kirlia
                case 282: return new int[] { 28, 36, 140 }; // Gardevoir
                //case 282: return new int[] { 182, 182, 182 }; // Mega Gardevoir
                case 283: return new int[] { 33, 33, 44 }; // Surskit
                case 284: return new int[] { 22, 22, 127 }; // Masquerain
                case 285: return new int[] { 27, 90, 95 }; // Shroomish
                case 286: return new int[] { 27, 90, 101 }; // Breloom
                case 287: return new int[] { 54, 54, 54 }; // Slakoth
                case 288: return new int[] { 72, 72, 72 }; // Vigoroth
                case 289: return new int[] { 54, 54, 54 }; // Slaking
                case 290: return new int[] { 14, 14, 50 }; // Nincada
                case 291: return new int[] { 3, 3, 151 }; // Ninjask
                case 292: return new int[] { 25, 25, 25 }; // Shedinja
                case 293: return new int[] { 43, 43, 155 }; // Whismur
                case 294: return new int[] { 43, 43, 113 }; // Loudred
                case 295: return new int[] { 43, 43, 113 }; // Exploud
                case 296: return new int[] { 47, 62, 125 }; // Makuhita
                case 297: return new int[] { 47, 62, 125 }; // Hariyama
                case 298: return new int[] { 47, 37, 157 }; // Azurill
                case 299: return new int[] { 5, 42, 159 }; // Nosepass
                case 300: return new int[] { 56, 96, 147 }; // Skitty
                case 301: return new int[] { 56, 96, 147 }; // Delcatty
                case 302: return new int[] { 51, 100, 158 }; // Sableye
                //case 302: return new int[] { 156, 156, 156 }; // Mega Sableye
                case 303: return new int[] { 52, 22, 125 }; // Mawile
                //case 303: return new int[] { 37, 37, 37 }; // Mega Mawile
                case 304: return new int[] { 5, 69, 134 }; // Aron
                case 305: return new int[] { 5, 69, 134 }; // Lairon
                case 306: return new int[] { 5, 69, 134 }; // Aggron
                //case 306: return new int[] { 111, 111, 111 }; // Mega Aggron
                case 307: return new int[] { 74, 74, 140 }; // Meditite
                case 308: return new int[] { 74, 74, 140 }; // Medicham
                //case 308: return new int[] { 74, 74, 74 }; // Mega Medicham
                case 309: return new int[] { 9, 31, 58 }; // Electrike
                case 310: return new int[] { 9, 31, 58 }; // Manectric
                //case 310: return new int[] { 22, 22, 22 }; // Mega Manectric
                case 311: return new int[] { 57, 57, 31 }; // Plusle
                case 312: return new int[] { 58, 58, 10 }; // Minun
                case 313: return new int[] { 35, 68, 158 }; // Volbeat
                case 314: return new int[] { 12, 110, 158 }; // Illumise
                case 315: return new int[] { 30, 38, 102 }; // Roselia
                case 316: return new int[] { 64, 60, 82 }; // Gulpin
                case 317: return new int[] { 64, 60, 82 }; // Swalot
                case 318: return new int[] { 24, 24, 3 }; // Carvanha
                case 319: return new int[] { 24, 24, 3 }; // Sharpedo
                //case 319: return new int[] { 173, 173, 173 }; // Mega Sharpedo
                case 320: return new int[] { 41, 12, 46 }; // Wailmer
                case 321: return new int[] { 41, 12, 46 }; // Wailord
                case 322: return new int[] { 12, 86, 20 }; // Numel
                case 323: return new int[] { 40, 116, 83 }; // Camerupt
                //case 323: return new int[] { 125, 125, 125 }; // Mega Camerupt
                case 324: return new int[] { 73, 73, 75 }; // Torkoal
                case 325: return new int[] { 47, 20, 82 }; // Spoink
                case 326: return new int[] { 47, 20, 82 }; // Grumpig
                case 327: return new int[] { 20, 77, 126 }; // Spinda
                case 328: return new int[] { 52, 71, 125 }; // Trapinch
                case 329: return new int[] { 26, 26, 26 }; // Vibrava
                case 330: return new int[] { 26, 26, 26 }; // Flygon
                case 331: return new int[] { 8, 8, 11 }; // Cacnea
                case 332: return new int[] { 8, 8, 11 }; // Cacturne
                case 333: return new int[] { 30, 30, 13 }; // Swablu
                case 334: return new int[] { 30, 30, 13 }; // Altaria
                //case 334: return new int[] { 182, 182, 182 }; // Mega Altaria
                case 335: return new int[] { 17, 17, 137 }; // Zangoose
                case 336: return new int[] { 61, 61, 151 }; // Seviper
                case 337: return new int[] { 26, 26, 26 }; // Lunatone
                case 338: return new int[] { 26, 26, 26 }; // Solrock
                case 339: return new int[] { 12, 107, 93 }; // Barboach
                case 340: return new int[] { 12, 107, 93 }; // Whiscash
                case 341: return new int[] { 52, 75, 91 }; // Corphish
                case 342: return new int[] { 52, 75, 91 }; // Crawdaunt
                case 343: return new int[] { 26, 26, 26 }; // Baltoy
                case 344: return new int[] { 26, 26, 26 }; // Claydol
                case 345: return new int[] { 21, 21, 114 }; // Lileep
                case 346: return new int[] { 21, 21, 114 }; // Cradily
                case 347: return new int[] { 4, 4, 33 }; // Anorith
                case 348: return new int[] { 4, 4, 33 }; // Armaldo
                case 349: return new int[] { 33, 12, 91 }; // Feebas
                case 350: return new int[] { 63, 172, 56 }; // Milotic
                case 351: return new int[] { 59, 59, 59 }; // Castform - All formes
                case 352: return new int[] { 16, 16, 168 }; // Kecleon
                case 353: return new int[] { 15, 119, 130 }; // Shuppet
                case 354: return new int[] { 15, 119, 130 }; // Banette
                //case 354: return new int[] { 158, 158, 158 }; // Mega Banette
                case 355: return new int[] { 26, 26, 119 }; // Duskull
                case 356: return new int[] { 46, 46, 119 }; // Dusclops
                case 357: return new int[] { 34, 94, 139 }; // Tropius
                case 358: return new int[] { 26, 26, 26 }; // Chimecho
                case 359: return new int[] { 46, 105, 154 }; // Absol
                //case 359: return new int[] { 156, 156, 156 }; // Mega Absol
                case 360: return new int[] { 23, 23, 140 }; // Wynaut
                case 361: return new int[] { 39, 115, 141 }; // Snorunt
                case 362: return new int[] { 39, 115, 141 }; // Glalie
                //case 362: return new int[] { 174, 174, 174 }; // Mega Glalie
                case 363: return new int[] { 47, 115, 12 }; // Spheal
                case 364: return new int[] { 47, 115, 12 }; // Sealeo
                case 365: return new int[] { 47, 115, 12 }; // Walrein
                case 366: return new int[] { 75, 75, 155 }; // Clamperl
                case 367: return new int[] { 33, 33, 41 }; // Huntail
                case 368: return new int[] { 33, 33, 93 }; // Gorebyss
                case 369: return new int[] { 33, 69, 5 }; // Relicanth
                case 370: return new int[] { 33, 33, 93 }; // Luvdisc
                case 371: return new int[] { 69, 69, 125 }; // Bagon
                case 372: return new int[] { 69, 69, 142 }; // Shelgon
                case 373: return new int[] { 22, 22, 153 }; // Salamence
                //case 373: return new int[] { 184, 184, 184 }; // Mega Salamence
                case 374: return new int[] { 29, 29, 135 }; // Beldum
                case 375: return new int[] { 29, 29, 135 }; // Metang
                case 376: return new int[] { 29, 29, 135 }; // Metagross
                //case 376: return new int[] { 181, 181, 181 }; // Mega Metagross
                case 377: return new int[] { 29, 29, 5 }; // Regirock
                case 378: return new int[] { 29, 29, 115 }; // Regice
                case 379: return new int[] { 29, 29, 135 }; // Registeel
                case 380: return new int[] { 26, 26, 26 }; // Latias
                //case 380: return new int[] { 26, 26, 26 }; // Mega Latias
                case 381: return new int[] { 26, 26, 26 }; // Latios
                //case 381: return new int[] { 26, 26, 26 }; // Mega Latios
                case 382: return new int[] { 2, 2, 2 }; // Kyogre
                //case 382: return new int[] { 189, 189, 189 }; // Primal Kyogre
                case 383: return new int[] { 70, 70, 70 }; // Groudon
                //case 383: return new int[] { 190, 190, 190 }; // Primal Groudon
                case 384: return new int[] { 76, 76, 76 }; // Rayquaza
                //case 384: return new int[] { 191, 191, 191 }; // Mega Rayquaza
                case 385: return new int[] { 32, 32, 32 }; // Jirachi
                case 386: return new int[] { 46, 46, 46 }; // Deoxys - All formes
                case 387: return new int[] { 65, 65, 75 }; // Turtwig
                case 388: return new int[] { 65, 65, 75 }; // Grotle
                case 389: return new int[] { 65, 65, 75 }; // Torterra
                case 390: return new int[] { 66, 66, 89 }; // Chimchar
                case 391: return new int[] { 66, 66, 89 }; // Monferno
                case 392: return new int[] { 66, 66, 89 }; // Infernape
                case 393: return new int[] { 67, 67, 128 }; // Piplup
                case 394: return new int[] { 67, 67, 128 }; // Prinplup
                case 395: return new int[] { 67, 67, 128 }; // Empoleon
                case 396: return new int[] { 51, 51, 120 }; // Starly
                case 397: return new int[] { 22, 22, 120 }; // Staravia
                case 398: return new int[] { 22, 22, 120 }; // Staraptor
                case 399: return new int[] { 86, 109, 141 }; // Bidoof
                case 400: return new int[] { 86, 109, 141 }; // Bibarel
                case 401: return new int[] { 61, 61, 50 }; // Kricketot
                case 402: return new int[] { 68, 68, 101 }; // Kricketune
                case 403: return new int[] { 79, 22, 62 }; // Shinx
                case 404: return new int[] { 79, 22, 62 }; // Luxio
                case 405: return new int[] { 79, 22, 62 }; // Luxray
                case 406: return new int[] { 30, 38, 102 }; // Budew
                case 407: return new int[] { 30, 38, 101 }; // Roserade
                case 408: return new int[] { 104, 104, 125 }; // Cranidos
                case 409: return new int[] { 104, 104, 125 }; // Rampardos
                case 410: return new int[] { 5, 5, 43 }; // Shieldon
                case 411: return new int[] { 5, 5, 43 }; // Bastiodon
                case 412: return new int[] { 61, 61, 142 }; // Burmy - All formes
                case 413: return new int[] { 107, 107, 142 }; // Wormadam - All formes
                case 414: return new int[] { 68, 68, 110 }; // Mothim
                case 415: return new int[] { 118, 118, 55 }; // Combee
                case 416: return new int[] { 46, 46, 127 }; // Vespiquen
                case 417: return new int[] { 50, 53, 10 }; // Pachirisu
                case 418: return new int[] { 33, 33, 41 }; // Buizel
                case 419: return new int[] { 33, 33, 41 }; // Floatzel
                case 420: return new int[] { 34, 34, 34 }; // Cherubi
                case 421: return new int[] { 122, 122, 122 }; // Cherrim
                case 422: return new int[] { 60, 114, 159 }; // Shellos
                case 423: return new int[] { 60, 114, 159 }; // Gastrodon
                case 424: return new int[] { 101, 53, 92 }; // Ambipom
                case 425: return new int[] { 106, 84, 138 }; // Drifloon
                case 426: return new int[] { 106, 84, 138 }; // Drifblim
                case 427: return new int[] { 50, 103, 7 }; // Buneary
                case 428: return new int[] { 56, 103, 7 }; // Lopunny
                //case 428: return new int[] { 113, 113, 113 }; // Mega Lopunny
                case 429: return new int[] { 26, 26, 26 }; // Mismagius
                case 430: return new int[] { 15, 105, 153 }; // Honchkrow
                case 431: return new int[] { 7, 20, 51 }; // Glameow
                case 432: return new int[] { 47, 20, 128 }; // Purugly
                case 433: return new int[] { 26, 26, 26 }; // Chingling
                case 434: return new int[] { 1, 106, 51 }; // Stunky
                case 435: return new int[] { 1, 106, 51 }; // Skuntank
                case 436: return new int[] { 26, 85, 134 }; // Bronzor
                case 437: return new int[] { 26, 85, 134 }; // Bronzong
                case 438: return new int[] { 5, 69, 155 }; // Bonsly
                case 439: return new int[] { 43, 111, 101 }; // Mime Jr.
                case 440: return new int[] { 30, 32, 132 }; // Happiny
                case 441: return new int[] { 51, 77, 145 }; // Chatot
                case 442: return new int[] { 46, 46, 151 }; // Spiritomb
                case 443: return new int[] { 8, 8, 24 }; // Gible
                case 444: return new int[] { 8, 8, 24 }; // Gabite
                case 445: return new int[] { 8, 8, 24 }; // Garchomp
                //case 445: return new int[] { 159, 159, 159 }; // Mega Garchomp
                case 446: return new int[] { 53, 47, 82 }; // Munchlax
                case 447: return new int[] { 80, 39, 158 }; // Riolu
                case 448: return new int[] { 80, 39, 154 }; // Lucario
                //case 448: return new int[] { 91, 91, 91 }; // Mega Lucario
                case 449: return new int[] { 45, 45, 159 }; // Hippopotas
                case 450: return new int[] { 45, 45, 159 }; // Hippowdon
                case 451: return new int[] { 4, 97, 51 }; // Skorupi
                case 452: return new int[] { 4, 97, 51 }; // Drapion
                case 453: return new int[] { 107, 87, 143 }; // Croagunk
                case 454: return new int[] { 107, 87, 143 }; // Toxicroak
                case 455: return new int[] { 26, 26, 26 }; // Carnivine
                case 456: return new int[] { 33, 114, 41 }; // Finneon
                case 457: return new int[] { 33, 114, 41 }; // Lumineon
                case 458: return new int[] { 33, 11, 41 }; // Mantyke
                case 459: return new int[] { 117, 117, 43 }; // Snover
                case 460: return new int[] { 117, 117, 43 }; // Abomasnow
                //case 460: return new int[] { 117, 117, 117 }; // Mega Abomasnow
                case 461: return new int[] { 46, 46, 124 }; // Weavile
                case 462: return new int[] { 42, 5, 148 }; // Magnezone
                case 463: return new int[] { 20, 12, 13 }; // Lickilicky
                case 464: return new int[] { 31, 116, 120 }; // Rhyperior
                case 465: return new int[] { 34, 102, 144 }; // Tangrowth
                case 466: return new int[] { 78, 78, 72 }; // Electivire
                case 467: return new int[] { 49, 49, 72 }; // Magmortar
                case 468: return new int[] { 55, 32, 105 }; // Togekiss
                case 469: return new int[] { 3, 110, 119 }; // Yanmega
                case 470: return new int[] { 102, 102, 34 }; // Leafeon
                case 471: return new int[] { 81, 81, 115 }; // Glaceon
                case 472: return new int[] { 52, 8, 90 }; // Gliscor
                case 473: return new int[] { 12, 81, 47 }; // Mamoswine
                case 474: return new int[] { 91, 88, 148 }; // Porygon-Z
                case 475: return new int[] { 80, 80, 154 }; // Gallade
                //case 475: return new int[] { 39, 39, 39 }; // Mega Gallade
                case 476: return new int[] { 5, 42, 159 }; // Probopass
                case 477: return new int[] { 46, 46, 119 }; // Dusknoir
                case 478: return new int[] { 81, 81, 130 }; // Froslass
                case 479: return new int[] { 26, 26, 26 }; // Rotom - All formes
                case 480: return new int[] { 26, 26, 26 }; // Uxie
                case 481: return new int[] { 26, 26, 26 }; // Mesprit
                case 482: return new int[] { 26, 26, 26 }; // Azelf
                case 483: return new int[] { 46, 46, 140 }; // Dialga
                case 484: return new int[] { 46, 46, 140 }; // Palkia
                case 485: return new int[] { 18, 18, 49 }; // Heatran
                case 486: return new int[] { 112, 112, 112 }; // Regigigas
                case 487:
                    switch (forme)
                    {
                        case 1: return new int[] { 26, 26, 26 }; // Giratina - Origin
                        default: return new int[] { 46, 46, 140 }; // Giratina - Altered
                    }
                case 488: return new int[] { 26, 26, 26 }; // Cresselia
                case 489: return new int[] { 93, 93, 93 }; // Phione
                case 490: return new int[] { 93, 93, 93 }; // Manaphy
                case 491: return new int[] { 123, 123, 123 }; // Darkrai
                case 492:
                    switch (forme)
                    {
                        case 1: return new int[] { 32, 32, 32 }; // Shaymin - Sky
                        default: return new int[] { 30, 30, 30 }; // Shaymin - Land
                    }
                case 493: return new int[] { 121, 121, 121 }; // Arceus
                case 494: return new int[] { 162, 162, 162 }; // Victini
                case 495: return new int[] { 65, 65, 126 }; // Snivy
                case 496: return new int[] { 65, 65, 126 }; // Servine
                case 497: return new int[] { 65, 65, 126 }; // Serperior
                case 498: return new int[] { 66, 66, 47 }; // Tepig
                case 499: return new int[] { 66, 66, 47 }; // Pignite
                case 500: return new int[] { 66, 66, 120 }; // Emboar
                case 501: return new int[] { 67, 67, 75 }; // Oshawott
                case 502: return new int[] { 67, 67, 75 }; // Dewott
                case 503: return new int[] { 67, 67, 75 }; // Samurott
                case 504: return new int[] { 50, 51, 148 }; // Patrat
                case 505: return new int[] { 35, 51, 148 }; // Watchog
                case 506: return new int[] { 72, 53, 50 }; // Lillipup
                case 507: return new int[] { 22, 146, 113 }; // Herdier
                case 508: return new int[] { 22, 146, 113 }; // Stoutland
                case 509: return new int[] { 7, 84, 158 }; // Purrloin
                case 510: return new int[] { 7, 84, 158 }; // Liepard
                case 511: return new int[] { 82, 82, 65 }; // Pansage
                case 512: return new int[] { 82, 82, 65 }; // Simisage
                case 513: return new int[] { 82, 82, 66 }; // Pansear
                case 514: return new int[] { 82, 82, 66 }; // Simisear
                case 515: return new int[] { 82, 82, 67 }; // Panpour
                case 516: return new int[] { 82, 82, 67 }; // Simipour
                case 517: return new int[] { 108, 28, 140 }; // Munna
                case 518: return new int[] { 108, 28, 140 }; // Musharna
                case 519: return new int[] { 145, 105, 79 }; // Pidove
                case 520: return new int[] { 145, 105, 79 }; // Tranquill
                case 521: return new int[] { 145, 105, 79 }; // Unfezant
                case 522: return new int[] { 31, 78, 157 }; // Blitzle
                case 523: return new int[] { 31, 78, 157 }; // Zebstrika
                case 524: return new int[] { 5, 5, 159 }; // Roggenrola
                case 525: return new int[] { 5, 5, 159 }; // Boldore
                case 526: return new int[] { 5, 5, 159 }; // Gigalith
                case 527: return new int[] { 109, 103, 86 }; // Woobat
                case 528: return new int[] { 109, 103, 86 }; // Swoobat
                case 529: return new int[] { 146, 159, 104 }; // Drilbur
                case 530: return new int[] { 146, 159, 104 }; // Excadrill
                case 531: return new int[] { 131, 144, 103 }; // Audino
                //case 531: return new int[] { 131, 131, 131 }; // Mega Audino
                case 532: return new int[] { 62, 125, 89 }; // Timburr
                case 533: return new int[] { 62, 125, 89 }; // Gurdurr
                case 534: return new int[] { 62, 125, 89 }; // Conkeldurr
                case 535: return new int[] { 33, 93, 11 }; // Tympole
                case 536: return new int[] { 33, 93, 11 }; // Palpitoad
                case 537: return new int[] { 33, 143, 11 }; // Seismitoad
                case 538: return new int[] { 62, 39, 104 }; // Throh
                case 539: return new int[] { 5, 39, 104 }; // Sawk
                case 540: return new int[] { 68, 34, 142 }; // Sewaddle
                case 541: return new int[] { 102, 34, 142 }; // Swadloon
                case 542: return new int[] { 68, 34, 142 }; // Leavanny
                case 543: return new int[] { 38, 68, 3 }; // Venipede*
                case 544: return new int[] { 38, 68, 3 }; // Whirlipede*
                case 545: return new int[] { 38, 68, 3 }; // Scolipede*
                case 546: return new int[] { 158, 151, 34 }; // Cottonee
                case 547: return new int[] { 158, 151, 34 }; // Whimsicott
                case 548: return new int[] { 34, 20, 102 }; // Petilil
                case 549: return new int[] { 34, 20, 102 }; // Lilligant
                case 550:
                    switch (forme)
                    {
                        case 1: return new int[] { 69, 91, 104 }; // Basculin - Blue
                        default: return new int[] { 120, 91, 104 }; // Basculin - Red
                    } 
                case 551: return new int[] { 22, 153, 83 }; // Sandile
                case 552: return new int[] { 22, 153, 83 }; // Krokorok
                case 553: return new int[] { 22, 153, 83 }; // Krookodile
                case 554: return new int[] { 55, 55, 39 }; // Darumaka
                case 555: return new int[] { 125, 125, 161 }; // Darmanitan
                case 556: return new int[] { 11, 34, 114 }; // Maractus
                case 557: return new int[] { 5, 75, 133 }; // Dwebble
                case 558: return new int[] { 5, 75, 133 }; // Crustle
                case 559: return new int[] { 61, 153, 22 }; // Scraggy
                case 560: return new int[] { 61, 153, 22 }; // Scrafty
                case 561: return new int[] { 147, 98, 110 }; // Sigilyph
                case 562: return new int[] { 152, 152, 152 }; // Yamask
                case 563: return new int[] { 152, 152, 152 }; // Cofagrigus
                case 564: return new int[] { 116, 5, 33 }; // Tirtouga
                case 565: return new int[] { 116, 5, 33 }; // Carracosta
                case 566: return new int[] { 129, 129, 129 }; // Archen
                case 567: return new int[] { 129, 129, 129 }; // Archeops
                case 568: return new int[] { 1, 60, 106 }; // Trubbish
                case 569: return new int[] { 1, 133, 106 }; // Garbodor
                case 570: return new int[] { 149, 149, 149 }; // Zorua
                case 571: return new int[] { 149, 149, 149 }; // Zoroark
                case 572: return new int[] { 56, 101, 92 }; // Minccino
                case 573: return new int[] { 56, 101, 92 }; // Cinccino
                case 574: return new int[] { 119, 172, 23 }; // Gothita
                case 575: return new int[] { 119, 172, 23 }; // Gothorita
                case 576: return new int[] { 119, 172, 23 }; // Gothitelle
                case 577: return new int[] { 142, 98, 144 }; // Solosis
                case 578: return new int[] { 142, 98, 144 }; // Duosion
                case 579: return new int[] { 142, 98, 144 }; // Reuniclus
                case 580: return new int[] { 51, 145, 93 }; // Ducklett
                case 581: return new int[] { 51, 145, 93 }; // Swanna
                case 582: return new int[] { 115, 115, 133 }; // Vanillite
                case 583: return new int[] { 115, 115, 133 }; // Vanillish
                case 584: return new int[] { 115, 115, 133 }; // Vanilluxe
                case 585: return new int[] { 34, 157, 32 }; // Deerling - All formes
                case 586: return new int[] { 34, 157, 32 }; // Sawsbuck - All formes
                case 587: return new int[] { 9, 9, 78 }; // Emolga
                case 588: return new int[] { 68, 61, 99 }; // Karrablast
                case 589: return new int[] { 68, 75, 142 }; // Escavalier
                case 590: return new int[] { 27, 27, 144 }; // Foongus
                case 591: return new int[] { 27, 27, 144 }; // Amoonguss
                case 592: return new int[] { 11, 130, 6 }; // Frillish
                case 593: return new int[] { 11, 130, 6 }; // Jellicent
                case 594: return new int[] { 131, 93, 144 }; // Alomomola
                case 595: return new int[] { 14, 127, 68 }; // Joltik
                case 596: return new int[] { 14, 127, 68 }; // Galvantula
                case 597: return new int[] { 160, 160, 160 }; // Ferroseed
                case 598: return new int[] { 160, 160, 107 }; // Ferrothorn
                case 599: return new int[] { 57, 58, 29 }; // Klink
                case 600: return new int[] { 57, 58, 29 }; // Klang
                case 601: return new int[] { 57, 58, 29 }; // Klinklang
                case 602: return new int[] { 26, 26, 26 }; // Tynamo
                case 603: return new int[] { 26, 26, 26 }; // Eelektrik
                case 604: return new int[] { 26, 26, 26 }; // Eelektross
                case 605: return new int[] { 140, 28, 148 }; // Elgyem
                case 606: return new int[] { 140, 28, 148 }; // Beheeyem
                case 607: return new int[] { 18, 49, 151 }; // Litwick
                case 608: return new int[] { 18, 49, 151 }; // Lampent
                case 609: return new int[] { 18, 49, 151 }; // Chandelure
                case 610: return new int[] { 79, 104, 127 }; // Axew
                case 611: return new int[] { 79, 104, 127 }; // Fraxure
                case 612: return new int[] { 79, 104, 127 }; // Haxorus
                case 613: return new int[] { 81, 81, 155 }; // Cubchoo
                case 614: return new int[] { 81, 81, 33 }; // Beartic
                case 615: return new int[] { 26, 26, 26 }; // Cryogonal
                case 616: return new int[] { 93, 75, 142 }; // Shelmet
                case 617: return new int[] { 93, 60, 84 }; // Accelgor
                case 618: return new int[] { 9, 7, 8 }; // Stunfisk
                case 619: return new int[] { 39, 144, 120 }; // Mienfoo
                case 620: return new int[] { 39, 144, 120 }; // Mienshao
                case 621: return new int[] { 24, 125, 104 }; // Druddigon
                case 622: return new int[] { 89, 103, 99 }; // Golett
                case 623: return new int[] { 89, 103, 99 }; // Golurk
                case 624: return new int[] { 128, 39, 46 }; // Pawniard
                case 625: return new int[] { 128, 39, 46 }; // Bisharp
                case 626: return new int[] { 120, 157, 43 }; // Bouffalant
                case 627: return new int[] { 51, 125, 55 }; // Rufflet
                case 628: return new int[] { 51, 125, 128 }; // Braviary
                case 629: return new int[] { 145, 142, 133 }; // Vullaby
                case 630: return new int[] { 145, 142, 133 }; // Mandibuzz
                case 631: return new int[] { 82, 18, 73 }; // Heatmor
                case 632: return new int[] { 68, 55, 54 }; // Durant
                case 633: return new int[] { 55, 55, 55 }; // Deino
                case 634: return new int[] { 55, 55, 55 }; // Zweilous
                case 635: return new int[] { 26, 26, 26 }; // Hydreigon
                case 636: return new int[] { 49, 49, 68 }; // Larvesta
                case 637: return new int[] { 49, 49, 68 }; // Volcarona
                case 638: return new int[] { 154, 154, 154 }; // Cobalion
                case 639: return new int[] { 154, 154, 154 }; // Terrakion
                case 640: return new int[] { 154, 154, 154 }; // Virizion
                case 641:
                    switch (forme)
                    {
                        case 1: return new int[] { 144, 144, 144 }; // Tornadus - Therian
                        default: return new int[] { 158, 158, 128 }; // Tornadus - Incarnate
                    }
                case 642:
                    switch (forme)
                    {
                        case 1: return new int[] { 10, 10, 10 }; // Thundurus - Therian
                        default: return new int[] { 158, 158, 128 }; // Thundurus - Incarnate
                    }
                case 643: return new int[] { 163, 163, 163 }; // Reshiram
                case 644: return new int[] { 164, 164, 164 }; // Zekrom
                case 645:
                    switch (forme)
                    {
                        case 1: return new int[] { 22, 22, 22 }; // Landorus - Therian
                        default: return new int[] { 159, 159, 125 }; // Landorus - Incarnate
                    }
                case 646:
                    switch (forme)
                    {
                        case 1: return new int[] { 163, 163, 163 }; // White Kyurem
                        case 2: return new int[] { 164, 164, 164 }; // Black Kyurem
                        default: return new int[] { 46, 46, 46 }; // Kyurem
                    }
                case 647: return new int[] { 154, 154, 154 }; // Keldeo
                case 648: return new int[] { 32, 32, 32 }; // Meloetta
                case 649: return new int[] { 88, 88, 88 }; // Genesect
                case 650: return new int[] { 65, 65, 171 }; // Chespin
                case 651: return new int[] { 65, 65, 171 }; // Quilladin
                case 652: return new int[] { 65, 65, 171 }; // Chesnaught
                case 653: return new int[] { 66, 66, 170 }; // Fennekin
                case 654: return new int[] { 66, 66, 170 }; // Braixen
                case 655: return new int[] { 66, 66, 170 }; // Delphox
                case 656: return new int[] { 67, 67, 168 }; // Froakie
                case 657: return new int[] { 67, 67, 168 }; // Frogadier
                case 658: return new int[] { 67, 67, 168 }; // Greninja
                case 659: return new int[] { 53, 167, 37 }; // Bunnelby
                case 660: return new int[] { 53, 167, 37 }; // Diggersby
                case 661: return new int[] { 145, 145, 177 }; // Fletchling
                case 662: return new int[] { 49, 49, 177 }; // Fletchinder
                case 663: return new int[] { 49, 49, 177 }; // Talonflame
                case 664: return new int[] { 19, 14, 132 }; // Scatterbug
                case 665: return new int[] { 61, 61, 132 }; // Spewpa
                case 666: return new int[] { 19, 14, 132 }; // Vivillon
                case 667: return new int[] { 79, 127, 153 }; // Litleo
                case 668: return new int[] { 79, 127, 153 }; // Pyroar
                case 669: return new int[] { 166, 166, 180 }; // Flabébé
                case 670: return new int[] { 166, 166, 180 }; // Floette
                case 671: return new int[] { 166, 166, 180 }; // Florges
                case 672: return new int[] { 157, 157, 179 }; // Skiddo
                case 673: return new int[] { 157, 157, 179 }; // Gogoat
                case 674: return new int[] { 89, 104, 113 }; // Pancham
                case 675: return new int[] { 89, 104, 113 }; // Pangoro
                case 676: return new int[] { 169, 169, 169 }; // Furfrou
                case 677: return new int[] { 51, 151, 20 }; // Espurr
                case 678:
                    switch (forme)
                    {
                        case 1: return new int[] { 51, 151, 172 }; // Meowstic♀
                        default: return new int[] { 51, 151, 158 }; // Meowstic♂
                    }
                case 679: return new int[] { 99, 99, 99 }; // Honedge
                case 680: return new int[] { 99, 99, 99 }; // Doublade
                case 681: return new int[] { 176, 176, 176 }; // Aegislash
                case 682: return new int[] { 131, 131, 165 }; // Spritzee
                case 683: return new int[] { 131, 131, 165 }; // Aromatisse
                case 684: return new int[] { 175, 175, 84 }; // Swirlix
                case 685: return new int[] { 175, 175, 84 }; // Slurpuff
                case 686: return new int[] { 126, 21, 151 }; // Inkay
                case 687: return new int[] { 126, 21, 151 }; // Malamar
                case 688: return new int[] { 97, 181, 124 }; // Binacle
                case 689: return new int[] { 97, 181, 124 }; // Barbaracle
                case 690: return new int[] { 38, 143, 91 }; // Skrelp
                case 691: return new int[] { 38, 143, 91 }; // Dragalge
                case 692: return new int[] { 178, 178, 178 }; // Clauncher
                case 693: return new int[] { 178, 178, 178 }; // Clawitzer
                case 694: return new int[] { 87, 8, 94 }; // Helioptile
                case 695: return new int[] { 87, 8, 94 }; // Heliolisk
                case 696: return new int[] { 173, 173, 5 }; // Tyrunt
                case 697: return new int[] { 173, 173, 69 }; // Tyrantrum
                case 698: return new int[] { 174, 174, 117 }; // Amaura
                case 699: return new int[] { 174, 174, 117 }; // Aurorus
                case 700: return new int[] { 56, 56, 182 }; // Sylveon
                case 701: return new int[] { 7, 84, 104 }; // Hawlucha
                case 702: return new int[] { 167, 53, 57 }; // Dedenne
                case 703: return new int[] { 29, 29, 5 }; // Carbink
                case 704: return new int[] { 157, 93, 183 }; // Goomy
                case 705: return new int[] { 157, 93, 183 }; // Sliggoo
                case 706: return new int[] { 157, 93, 183 }; // Goodra
                case 707: return new int[] { 158, 158, 170 }; // Klefki
                case 708: return new int[] { 30, 119, 139 }; // Phantump
                case 709: return new int[] { 30, 119, 139 }; // Trevenant
                case 710: return new int[] { 53, 119, 15 }; // Pumpkaboo
                case 711: return new int[] { 53, 119, 15 }; // Gourgeist
                case 712: return new int[] { 20, 115, 5 }; // Bergmite
                case 713: return new int[] { 20, 115, 5 }; // Avalugg
                case 714: return new int[] { 119, 151, 140 }; // Noibat
                case 715: return new int[] { 119, 151, 140 }; // Noivern
                case 716: return new int[] { 187, 187, 187 }; // Xerneas
                case 717: return new int[] { 186, 186, 186 }; // Yveltal
                case 718: return new int[] { 188, 211, 188 }; // Zygarde
                case 719: return new int[] { 29, 29, 29 }; // Diancie
                //case 719: return new int[] { 156, 156, 156 }; // Mega Diancie
                case 720: return new int[] { 170, 170, 170 }; // Hoopa Confined
                case 721: return new int[] { 11, 11, 11 }; // Volcanion
                default: return new int[] { 0, 0, 0 }; // No pokémon
            }
        }

        public int[] getAbilities7(int species, int forme)
        {
            switch (species)
            {
                case 1: return new int[] { 65, 65, 34 }; // Bulbasaur
                case 2: return new int[] { 65, 65, 34 }; // Ivysaur
                case 3: return new int[] { 65, 65, 34 }; // Venusaur
                //case 3: return new int[] { 47, 47, 47 }; // Mega Venusaur
                case 4: return new int[] { 66, 66, 94 }; // Charmander
                case 5: return new int[] { 66, 66, 94 }; // Charmeleon
                case 6: return new int[] { 66, 66, 94 }; // Charizard
                //case 6: return new int[] { 181, 181, 181 }; // Mega Charizard X
                //case 6: return new int[] { 70, 70, 70 }; // Mega Charizard Y
                case 7: return new int[] { 67, 67, 44 }; // Squirtle
                case 8: return new int[] { 67, 67, 44 }; // Wartortle
                case 9: return new int[] { 67, 67, 44 }; // Blastoise
                //case 9: return new int[] { 178, 178, 178 }; // Mega Blastoise
                case 10: return new int[] { 19, 19, 50 }; // Caterpie
                case 11: return new int[] { 61, 61, 61 }; // Metapod
                case 12: return new int[] { 14, 14, 110 }; // Butterfree
                case 13: return new int[] { 19, 19, 50 }; // Weedle
                case 14: return new int[] { 61, 61, 61 }; // Kakuna
                case 15: return new int[] { 68, 68, 97 }; // Beedrill
                //case 15: return new int[] { 91, 91, 91 }; // Mega Beedrill
                case 16: return new int[] { 51, 77, 145 }; // Pidgey
                case 17: return new int[] { 51, 77, 145 }; // Pidgeotto
                case 18: return new int[] { 51, 77, 145 }; // Pidgeot
                //case 18: return new int[] { 99, 99, 99 }; // Mega Pidgeot
                case 19:
                    switch (forme)
                    {
                        case 1: return new int[] { 82, 55, 47 }; // Alolan Rattata
                        default: return new int[] { 50, 62, 55 }; // Rattata
                    }
                case 20:
                    switch (forme)
                    {
                        case 1: return new int[] { 82, 55, 47 }; // Alolan Raticate
                        default: return new int[] { 50, 62, 55 }; // Raticate
                    }
                case 21: return new int[] { 51, 51, 97 }; // Spearow
                case 22: return new int[] { 51, 51, 97 }; // Fearow
                case 23: return new int[] { 22, 61, 127 }; // Ekans
                case 24: return new int[] { 22, 61, 127 }; // Arbok
                case 25: return new int[] { 9, 9, 31 }; // Pikachu
                //case 25: return new int[] { 31, 31, 31 }; // Cosplay Pikachu
                case 26:
                    switch (forme)
                    {
                        case 1: return new int[] { 207, 207, 207 }; // Alolan Raichu
                        default: return new int[] { 9, 9, 31 }; // Raichu
                    }
                case 27:
                    switch (forme)
                    {
                        case 1: return new int[] { 81, 81, 202 }; // Alolan Sandshrew
                        default: return new int[] { 8, 8, 146 }; // Sandshrew
                    }
                case 28:
                    switch (forme)
                    {
                        case 1: return new int[] { 81, 81, 202 }; // Alolan Sandslash
                        default: return new int[] { 8, 8, 146 }; // Sandslash
                    }
                case 29: return new int[] { 38, 79, 55 }; // Nidoran♀
                case 30: return new int[] { 38, 79, 55 }; // Nidorina
                case 31: return new int[] { 38, 79, 125 }; // Nidoqueen
                case 32: return new int[] { 38, 79, 55 }; // Nidoran♂
                case 33: return new int[] { 38, 79, 55 }; // Nidorino
                case 34: return new int[] { 38, 79, 125 }; // Nidoking
                case 35: return new int[] { 56, 98, 132 }; // Clefairy
                case 36: return new int[] { 56, 98, 109 }; // Clefable
                case 37:
                    switch (forme)
                    {
                        case 1: return new int[] { 81, 81, 117 }; // Alolan Vulpix
                        default: return new int[] { 18, 18, 70 }; // Vulpix
                    }
                case 38:
                    switch (forme)
                    {
                        case 1: return new int[] { 81, 81, 117 }; // Alolan Ninetales
                        default: return new int[] { 18, 18, 70 }; // Ninetales
                    }
                case 39: return new int[] { 56, 172, 132 }; // Jigglypuff
                case 40: return new int[] { 56, 172, 119 }; // Wigglytuff
                case 41: return new int[] { 39, 39, 151 }; // Zubat
                case 42: return new int[] { 39, 39, 151 }; // Golbat
                case 43: return new int[] { 34, 34, 50 }; // Oddish
                case 44: return new int[] { 34, 34, 1 }; // Gloom
                case 45: return new int[] { 34, 34, 27 }; // Vileplume
                case 46: return new int[] { 27, 87, 6 }; // Paras
                case 47: return new int[] { 27, 87, 6 }; // Parasect
                case 48: return new int[] { 14, 110, 50 }; // Venonat
                case 49: return new int[] { 19, 110, 147 }; // Venomoth
                case 50:
                    switch (forme)
                    {
                        case 1: return new int[] { 8, 221, 159 }; // Alolan Diglett
                        default: return new int[] { 8, 71, 159 }; // Diglett
                    }
                case 51:
                    switch (forme)
                    {
                        case 1: return new int[] { 8, 221, 159 }; // Alolan Dugtrio
                        default: return new int[] { 8, 71, 159 }; // Dugtrio
                    }
                case 52:
                    switch (forme)
                    {
                        case 1: return new int[] { 53, 101, 155 }; // Alolan Meowth
                        default: return new int[] { 53, 101, 127 }; // Meowth
                    }
                case 53:
                    switch (forme)
                    {
                        case 1: return new int[] { 169, 101, 155 }; // Alolan Persian
                        default: return new int[] { 7, 101, 127 }; // Persian
                    }
                case 54: return new int[] { 6, 13, 33 }; // Psyduck
                case 55: return new int[] { 6, 13, 33 }; // Golduck
                case 56: return new int[] { 72, 83, 128 }; // Mankey
                case 57: return new int[] { 72, 83, 128 }; // Primeape
                case 58: return new int[] { 22, 18, 154 }; // Growlithe
                case 59: return new int[] { 22, 18, 154 }; // Arcanine
                case 60: return new int[] { 11, 6, 33 }; // Poliwag
                case 61: return new int[] { 11, 6, 33 }; // Poliwhirl
                case 62: return new int[] { 11, 6, 33 }; // Poliwrath
                case 63: return new int[] { 28, 39, 98 }; // Abra
                case 64: return new int[] { 28, 39, 98 }; // Kadabra
                case 65: return new int[] { 28, 39, 98 }; // Alakazam
                //case 65: return new int[] { 36, 36, 36 }; // Mega Alakazam
                case 66: return new int[] { 62, 99, 80 }; // Machop
                case 67: return new int[] { 62, 99, 80 }; // Machoke
                case 68: return new int[] { 62, 99, 80 }; // Machamp
                case 69: return new int[] { 34, 34, 82 }; // Bellsprout
                case 70: return new int[] { 34, 34, 82 }; // Weepinbell
                case 71: return new int[] { 34, 34, 82 }; // Victreebel
                case 72: return new int[] { 29, 64, 44 }; // Tentacool
                case 73: return new int[] { 29, 64, 44 }; // Tentacruel
                case 74:
                    switch (forme)
                    {
                        case 1: return new int[] { 42, 5, 206 }; // Alolan Geodude
                        default: return new int[] { 69, 5, 8 }; // Geodude
                    }
                case 75:
                    switch (forme)
                    {
                        case 1: return new int[] { 42, 5, 206 }; // Alolan Graveler
                        default: return new int[] { 69, 5, 8 }; // Graveler
                    }
                case 76:
                    switch (forme)
                    {
                        case 1: return new int[] { 42, 5, 206 }; // Alolan Golem
                        default: return new int[] { 69, 5, 8 }; // Golem
                    }
                case 77: return new int[] { 50, 18, 49 }; // Ponyta
                case 78: return new int[] { 50, 18, 49 }; // Rapidash
                case 79: return new int[] { 12, 20, 144 }; // Slowpoke
                case 80: return new int[] { 12, 20, 144 }; // Slowbro
                //case 80: return new int[] { 75, 75, 75 }; // Mega Slowbro
                case 81: return new int[] { 42, 5, 148 }; // Magnemite
                case 82: return new int[] { 42, 5, 148 }; // Magneton
                case 83: return new int[] { 51, 39, 128 }; // Farfetch'd
                case 84: return new int[] { 50, 48, 77 }; // Doduo
                case 85: return new int[] { 50, 48, 77 }; // Dodrio
                case 86: return new int[] { 47, 93, 115 }; // Seel
                case 87: return new int[] { 47, 93, 115 }; // Dewgong
                case 88:
                    switch (forme)
                    {
                        case 1: return new int[] { 143, 82, 223 }; // Alolan Grimer
                        default: return new int[] { 1, 60, 143 }; // Grimer
                    }
                case 89:
                    switch (forme)
                    {
                        case 1: return new int[] { 143, 82, 223 }; // Alolan Muk
                        default: return new int[] { 1, 60, 143 }; // Muk
                    }
                case 90: return new int[] { 75, 92, 142 }; // Shellder
                case 91: return new int[] { 75, 92, 142 }; // Cloyster
                case 92: return new int[] { 26, 26, 26 }; // Gastly
                case 93: return new int[] { 26, 26, 26 }; // Haunter
                case 94: return new int[] { 130, 130, 130 }; // Gengar
                //case 94: return new int[] { 23, 23, 23 }; // Mega Gengar
                case 95: return new int[] { 69, 5, 133 }; // Onix
                case 96: return new int[] { 15, 108, 39 }; // Drowzee
                case 97: return new int[] { 15, 108, 39 }; // Hypno
                case 98: return new int[] { 52, 75, 125 }; // Krabby
                case 99: return new int[] { 52, 75, 125 }; // Kingler
                case 100: return new int[] { 43, 9, 106 }; // Voltorb
                case 101: return new int[] { 43, 9, 106 }; // Electrode
                case 102: return new int[] { 34, 34, 139 }; // Exeggcute
                case 103:
                    switch (forme)
                    {
                        case 1: return new int[] { 119, 119, 139 }; // Alolan Exeggutor
                        default: return new int[] { 34, 34, 139 }; // Exeggutor
                    }
                case 104: return new int[] { 69, 31, 4 }; // Cubone
                case 105:
                    switch (forme)
                    {
                        case 1: return new int[] { 130, 31, 69 }; // Alolan Marowak
                        default: return new int[] { 69, 31, 4 }; // Marowak
                    }
                case 106: return new int[] { 7, 120, 84 }; // Hitmonlee
                case 107: return new int[] { 51, 89, 39 }; // Hitmonchan
                case 108: return new int[] { 20, 12, 13 }; // Lickitung
                case 109: return new int[] { 26, 26, 26 }; // Koffing
                case 110: return new int[] { 26, 26, 26 }; // Weezing
                case 111: return new int[] { 31, 69, 120 }; // Rhyhorn
                case 112: return new int[] { 31, 69, 120 }; // Rhydon
                case 113: return new int[] { 30, 32, 131 }; // Chansey
                case 114: return new int[] { 34, 102, 144 }; // Tangela
                case 115: return new int[] { 48, 113, 39 }; // Kangaskhan
                //case 115: return new int[] { 185, 185, 185 }; // Mega Kangaskhan
                case 116: return new int[] { 33, 97, 6 }; // Horsea
                case 117: return new int[] { 38, 97, 6 }; // Seadra
                case 118: return new int[] { 33, 41, 31 }; // Goldeen
                case 119: return new int[] { 33, 41, 31 }; // Seaking
                case 120: return new int[] { 35, 30, 148 }; // Staryu
                case 121: return new int[] { 35, 30, 148 }; // Starmie
                case 122: return new int[] { 43, 111, 101 }; // Mr. Mime
                case 123: return new int[] { 68, 101, 80 }; // Scyther
                case 124: return new int[] { 12, 108, 87 }; // Jynx
                case 125: return new int[] { 9, 9, 72 }; // Electabuzz
                case 126: return new int[] { 49, 49, 72 }; // Magmar
                case 127: return new int[] { 52, 104, 153 }; // Pinsir
                //case 127: return new int[] { 184, 184, 184 }; // Mega Pinsir
                case 128: return new int[] { 22, 83, 125 }; // Tauros
                case 129: return new int[] { 33, 33, 155 }; // Magikarp
                case 130: return new int[] { 22, 22, 153 }; // Gyarados
                //case 130: return new int[] { 104, 104, 104 }; // Mega Gyarados
                case 131: return new int[] { 11, 75, 93 }; // Lapras
                case 132: return new int[] { 7, 7, 150 }; // Ditto
                case 133: return new int[] { 50, 91, 107 }; // Eevee
                case 134: return new int[] { 11, 11, 93 }; // Vaporeon
                case 135: return new int[] { 10, 10, 95 }; // Jolteon
                case 136: return new int[] { 18, 18, 62 }; // Flareon
                case 137: return new int[] { 36, 88, 148 }; // Porygon
                case 138: return new int[] { 33, 75, 133 }; // Omanyte
                case 139: return new int[] { 33, 75, 133 }; // Omastar
                case 140: return new int[] { 33, 4, 133 }; // Kabuto
                case 141: return new int[] { 33, 4, 133 }; // Kabutops
                case 142: return new int[] { 69, 46, 127 }; // Aerodactyl
                //case 142: return new int[] { 181, 181, 181 }; // Mega Aerodactyl
                case 143: return new int[] { 17, 47, 82 }; // Snorlax
                case 144: return new int[] { 46, 46, 81 }; // Articuno
                case 145: return new int[] { 46, 46, 9 }; // Zapdos
                case 146: return new int[] { 46, 46, 49 }; // Moltres
                case 147: return new int[] { 61, 61, 63 }; // Dratini
                case 148: return new int[] { 61, 61, 63 }; // Dragonair
                case 149: return new int[] { 39, 39, 136 }; // Dragonite
                case 150: return new int[] { 46, 46, 127 }; // Mewtwo
                //case 150: return new int[] { 80, 80, 80 }; // Mega Mewtwo X
                //case 150: return new int[] { 15, 15, 15 }; // Mega Mewtwo Y
                case 151: return new int[] { 28, 28, 28 }; // Mew
                case 152: return new int[] { 65, 65, 102 }; // Chikorita
                case 153: return new int[] { 65, 65, 102 }; // Bayleef
                case 154: return new int[] { 65, 65, 102 }; // Meganium
                case 155: return new int[] { 66, 66, 18 }; // Cyndaquil
                case 156: return new int[] { 66, 66, 18 }; // Quilava
                case 157: return new int[] { 66, 66, 18 }; // Typhlosion
                case 158: return new int[] { 67, 67, 125 }; // Totodile
                case 159: return new int[] { 67, 67, 125 }; // Croconaw
                case 160: return new int[] { 67, 67, 125 }; // Feraligatr
                case 161: return new int[] { 50, 51, 119 }; // Sentret
                case 162: return new int[] { 50, 51, 119 }; // Furret
                case 163: return new int[] { 15, 51, 110 }; // Hoothoot
                case 164: return new int[] { 15, 51, 110 }; // Noctowl
                case 165: return new int[] { 68, 48, 155 }; // Ledyba
                case 166: return new int[] { 68, 48, 89 }; // Ledian
                case 167: return new int[] { 68, 15, 97 }; // Spinarak
                case 168: return new int[] { 68, 15, 97 }; // Ariados
                case 169: return new int[] { 39, 39, 151 }; // Crobat
                case 170: return new int[] { 10, 35, 11 }; // Chinchou
                case 171: return new int[] { 10, 35, 11 }; // Lanturn
                case 172: return new int[] { 9, 9, 31 }; // Pichu
                //case 172: return new int[] { 9, 9, 9 }; // Spiky-eared Pichu
                case 173: return new int[] { 56, 98, 132 }; // Cleffa
                case 174: return new int[] { 56, 172, 132 }; // Igglybuff
                case 175: return new int[] { 55, 32, 105 }; // Togepi
                case 176: return new int[] { 55, 32, 105 }; // Togetic
                case 177: return new int[] { 28, 48, 156 }; // Natu
                case 178: return new int[] { 28, 48, 156 }; // Xatu
                case 179: return new int[] { 9, 9, 57 }; // Mareep
                case 180: return new int[] { 9, 9, 57 }; // Flaaffy
                case 181: return new int[] { 9, 9, 57 }; // Ampharos
                //case 181: return new int[] { 104, 104, 104 }; // Mega Ampharos
                case 182: return new int[] { 34, 34, 131 }; // Bellossom
                case 183: return new int[] { 47, 37, 157 }; // Marill
                case 184: return new int[] { 47, 37, 157 }; // Azumarill
                case 185: return new int[] { 5, 69, 155 }; // Sudowoodo
                case 186: return new int[] { 11, 6, 2 }; // Politoed
                case 187: return new int[] { 34, 102, 151 }; // Hoppip
                case 188: return new int[] { 34, 102, 151 }; // Skiploom
                case 189: return new int[] { 34, 102, 151 }; // Jumpluff
                case 190: return new int[] { 50, 53, 92 }; // Aipom
                case 191: return new int[] { 34, 94, 48 }; // Sunkern
                case 192: return new int[] { 34, 94, 48 }; // Sunflora
                case 193: return new int[] { 3, 14, 119 }; // Yanma
                case 194: return new int[] { 6, 11, 109 }; // Wooper
                case 195: return new int[] { 6, 11, 109 }; // Quagsire
                case 196: return new int[] { 28, 28, 156 }; // Espeon
                case 197: return new int[] { 28, 28, 39 }; // Umbreon
                case 198: return new int[] { 15, 105, 158 }; // Murkrow
                case 199: return new int[] { 12, 20, 144 }; // Slowking
                case 200: return new int[] { 26, 26, 26 }; // Misdreavus
                case 201: return new int[] { 26, 26, 26 }; // Unown
                case 202: return new int[] { 23, 23, 140 }; // Wobbuffet
                case 203: return new int[] { 39, 48, 157 }; // Girafarig
                case 204: return new int[] { 5, 5, 142 }; // Pineco
                case 205: return new int[] { 5, 5, 142 }; // Forretress
                case 206: return new int[] { 32, 50, 155 }; // Dunsparce
                case 207: return new int[] { 52, 8, 17 }; // Gligar
                case 208: return new int[] { 69, 5, 125 }; // Steelix
                //case 208: return new int[] { 159, 159, 159 }; // Mega Steelix
                case 209: return new int[] { 22, 50, 155 }; // Snubbull
                case 210: return new int[] { 22, 95, 155 }; // Granbull
                case 211: return new int[] { 38, 33, 22 }; // Qwilfish
                case 212: return new int[] { 68, 101, 135 }; // Scizor
                //case 212: return new int[] { 101, 101, 101 }; // Mega Scizor
                case 213: return new int[] { 5, 82, 126 }; // Shuckle
                case 214: return new int[] { 68, 62, 153 }; // Heracross
                //case 214: return new int[] { 92, 92, 92 }; // Mega Heracross
                case 215: return new int[] { 39, 51, 124 }; // Sneasel
                case 216: return new int[] { 53, 95, 118 }; // Teddiursa
                case 217: return new int[] { 62, 95, 127 }; // Ursaring
                case 218: return new int[] { 40, 49, 133 }; // Slugma
                case 219: return new int[] { 40, 49, 133 }; // Magcargo
                case 220: return new int[] { 12, 81, 47 }; // Swinub
                case 221: return new int[] { 12, 81, 47 }; // Piloswine
                case 222: return new int[] { 55, 30, 144 }; // Corsola
                case 223: return new int[] { 55, 97, 141 }; // Remoraid
                case 224: return new int[] { 21, 97, 141 }; // Octillery
                case 225: return new int[] { 72, 55, 15 }; // Delibird
                case 226: return new int[] { 33, 11, 41 }; // Mantine
                case 227: return new int[] { 51, 5, 133 }; // Skarmory
                case 228: return new int[] { 48, 18, 127 }; // Houndour
                case 229: return new int[] { 48, 18, 127 }; // Houndoom
                //case 229: return new int[] { 94, 94, 94 }; // Mega Houndoom
                case 230: return new int[] { 33, 97, 6 }; // Kingdra
                case 231: return new int[] { 53, 53, 8 }; // Phanpy
                case 232: return new int[] { 5, 5, 8 }; // Donphan
                case 233: return new int[] { 36, 88, 148 }; // Porygon2
                case 234: return new int[] { 22, 119, 157 }; // Stantler
                case 235: return new int[] { 20, 101, 141 }; // Smeargle
                case 236: return new int[] { 62, 80, 72 }; // Tyrogue
                case 237: return new int[] { 22, 101, 80 }; // Hitmontop
                case 238: return new int[] { 12, 108, 93 }; // Smoochum
                case 239: return new int[] { 9, 9, 72 }; // Elekid
                case 240: return new int[] { 49, 49, 72 }; // Magby
                case 241: return new int[] { 47, 113, 157 }; // Miltank
                case 242: return new int[] { 30, 32, 131 }; // Blissey
                case 243: return new int[] { 46, 46, 39 }; // Raikou
                case 244: return new int[] { 46, 46, 39 }; // Entei
                case 245: return new int[] { 46, 46, 39 }; // Suicune
                case 246: return new int[] { 62, 62, 8 }; // Larvitar
                case 247: return new int[] { 61, 61, 61 }; // Pupitar
                case 248: return new int[] { 45, 45, 127 }; // Tyranitar
                //case 248: return new int[] { 45, 45, 45 }; // Mega Tyranitar
                case 249: return new int[] { 46, 46, 136 }; // Lugia
                case 250: return new int[] { 46, 46, 144 }; // Ho-Oh
                case 251: return new int[] { 30, 30, 30 }; // Celebi
                case 252: return new int[] { 65, 65, 84 }; // Treecko
                case 253: return new int[] { 65, 65, 84 }; // Grovyle
                case 254: return new int[] { 65, 65, 84 }; // Sceptile
                //case 254: return new int[] { 31, 31, 31 }; // Mega Sceptile
                case 255: return new int[] { 66, 66, 3 }; // Torchic
                case 256: return new int[] { 66, 66, 3 }; // Combusken
                case 257: return new int[] { 66, 66, 3 }; // Blaziken
                //case 257: return new int[] { 3, 3, 3 }; // Mega Blaziken
                case 258: return new int[] { 67, 67, 6 }; // Mudkip
                case 259: return new int[] { 67, 67, 6 }; // Marshtomp
                case 260: return new int[] { 67, 67, 6 }; // Swampert
                //case 260: return new int[] { 33, 33, 33 }; // Mega Swampert
                case 261: return new int[] { 50, 95, 155 }; // Poochyena
                case 262: return new int[] { 22, 95, 153 }; // Mightyena
                case 263: return new int[] { 53, 82, 95 }; // Zigzagoon
                case 264: return new int[] { 53, 82, 95 }; // Linoone
                case 265: return new int[] { 19, 19, 50 }; // Wurmple
                case 266: return new int[] { 61, 61, 61 }; // Silcoon
                case 267: return new int[] { 68, 68, 79 }; // Beautifly
                case 268: return new int[] { 61, 61, 61 }; // Cascoon
                case 269: return new int[] { 19, 19, 14 }; // Dustox
                case 270: return new int[] { 33, 44, 20 }; // Lotad
                case 271: return new int[] { 33, 44, 20 }; // Lombre
                case 272: return new int[] { 33, 44, 20 }; // Ludicolo
                case 273: return new int[] { 34, 48, 124 }; // Seedot
                case 274: return new int[] { 34, 48, 124 }; // Nuzleaf
                case 275: return new int[] { 34, 48, 124 }; // Shiftry
                case 276: return new int[] { 62, 62, 113 }; // Taillow
                case 277: return new int[] { 62, 62, 113 }; // Swellow
                case 278: return new int[] { 51, 93, 44 }; // Wingull
                case 279: return new int[] { 51, 2, 44 }; // Pelipper
                case 280: return new int[] { 28, 36, 140 }; // Ralts
                case 281: return new int[] { 28, 36, 140 }; // Kirlia
                case 282: return new int[] { 28, 36, 140 }; // Gardevoir
                //case 282: return new int[] { 182, 182, 182 }; // Mega Gardevoir
                case 283: return new int[] { 33, 33, 44 }; // Surskit
                case 284: return new int[] { 22, 22, 127 }; // Masquerain
                case 285: return new int[] { 27, 90, 95 }; // Shroomish
                case 286: return new int[] { 27, 90, 101 }; // Breloom
                case 287: return new int[] { 54, 54, 54 }; // Slakoth
                case 288: return new int[] { 72, 72, 72 }; // Vigoroth
                case 289: return new int[] { 54, 54, 54 }; // Slaking
                case 290: return new int[] { 14, 14, 50 }; // Nincada
                case 291: return new int[] { 3, 3, 151 }; // Ninjask
                case 292: return new int[] { 25, 25, 25 }; // Shedinja
                case 293: return new int[] { 43, 43, 155 }; // Whismur
                case 294: return new int[] { 43, 43, 113 }; // Loudred
                case 295: return new int[] { 43, 43, 113 }; // Exploud
                case 296: return new int[] { 47, 62, 125 }; // Makuhita
                case 297: return new int[] { 47, 62, 125 }; // Hariyama
                case 298: return new int[] { 47, 37, 157 }; // Azurill
                case 299: return new int[] { 5, 42, 159 }; // Nosepass
                case 300: return new int[] { 56, 96, 147 }; // Skitty
                case 301: return new int[] { 56, 96, 147 }; // Delcatty
                case 302: return new int[] { 51, 100, 158 }; // Sableye
                //case 302: return new int[] { 156, 156, 156 }; // Mega Sableye
                case 303: return new int[] { 52, 22, 125 }; // Mawile
                //case 303: return new int[] { 37, 37, 37 }; // Mega Mawile
                case 304: return new int[] { 5, 69, 134 }; // Aron
                case 305: return new int[] { 5, 69, 134 }; // Lairon
                case 306: return new int[] { 5, 69, 134 }; // Aggron
                //case 306: return new int[] { 111, 111, 111 }; // Mega Aggron
                case 307: return new int[] { 74, 74, 140 }; // Meditite
                case 308: return new int[] { 74, 74, 140 }; // Medicham
                //case 308: return new int[] { 74, 74, 74 }; // Mega Medicham
                case 309: return new int[] { 9, 31, 58 }; // Electrike
                case 310: return new int[] { 9, 31, 58 }; // Manectric
                //case 310: return new int[] { 22, 22, 22 }; // Mega Manectric
                case 311: return new int[] { 57, 57, 31 }; // Plusle
                case 312: return new int[] { 58, 58, 10 }; // Minun
                case 313: return new int[] { 35, 68, 158 }; // Volbeat
                case 314: return new int[] { 12, 110, 158 }; // Illumise
                case 315: return new int[] { 30, 38, 102 }; // Roselia
                case 316: return new int[] { 64, 60, 82 }; // Gulpin
                case 317: return new int[] { 64, 60, 82 }; // Swalot
                case 318: return new int[] { 24, 24, 3 }; // Carvanha
                case 319: return new int[] { 24, 24, 3 }; // Sharpedo
                //case 319: return new int[] { 173, 173, 173 }; // Mega Sharpedo
                case 320: return new int[] { 41, 12, 46 }; // Wailmer
                case 321: return new int[] { 41, 12, 46 }; // Wailord
                case 322: return new int[] { 12, 86, 20 }; // Numel
                case 323: return new int[] { 40, 116, 83 }; // Camerupt
                //case 323: return new int[] { 125, 125, 125 }; // Mega Camerupt
                case 324: return new int[] { 73, 70, 75 }; // Torkoal
                case 325: return new int[] { 47, 20, 82 }; // Spoink
                case 326: return new int[] { 47, 20, 82 }; // Grumpig
                case 327: return new int[] { 20, 77, 126 }; // Spinda
                case 328: return new int[] { 52, 71, 125 }; // Trapinch
                case 329: return new int[] { 26, 26, 26 }; // Vibrava
                case 330: return new int[] { 26, 26, 26 }; // Flygon
                case 331: return new int[] { 8, 8, 11 }; // Cacnea
                case 332: return new int[] { 8, 8, 11 }; // Cacturne
                case 333: return new int[] { 30, 30, 13 }; // Swablu
                case 334: return new int[] { 30, 30, 13 }; // Altaria
                //case 334: return new int[] { 182, 182, 182 }; // Mega Altaria
                case 335: return new int[] { 17, 17, 137 }; // Zangoose
                case 336: return new int[] { 61, 61, 151 }; // Seviper
                case 337: return new int[] { 26, 26, 26 }; // Lunatone
                case 338: return new int[] { 26, 26, 26 }; // Solrock
                case 339: return new int[] { 12, 107, 93 }; // Barboach
                case 340: return new int[] { 12, 107, 93 }; // Whiscash
                case 341: return new int[] { 52, 75, 91 }; // Corphish
                case 342: return new int[] { 52, 75, 91 }; // Crawdaunt
                case 343: return new int[] { 26, 26, 26 }; // Baltoy
                case 344: return new int[] { 26, 26, 26 }; // Claydol
                case 345: return new int[] { 21, 21, 114 }; // Lileep
                case 346: return new int[] { 21, 21, 114 }; // Cradily
                case 347: return new int[] { 4, 4, 33 }; // Anorith
                case 348: return new int[] { 4, 4, 33 }; // Armaldo
                case 349: return new int[] { 33, 12, 91 }; // Feebas
                case 350: return new int[] { 63, 172, 56 }; // Milotic
                case 351: return new int[] { 59, 59, 59 }; // Castform - All formes
                case 352: return new int[] { 16, 16, 168 }; // Kecleon
                case 353: return new int[] { 15, 119, 130 }; // Shuppet
                case 354: return new int[] { 15, 119, 130 }; // Banette
                //case 354: return new int[] { 158, 158, 158 }; // Mega Banette
                case 355: return new int[] { 26, 26, 119 }; // Duskull
                case 356: return new int[] { 46, 46, 119 }; // Dusclops
                case 357: return new int[] { 34, 94, 139 }; // Tropius
                case 358: return new int[] { 26, 26, 26 }; // Chimecho
                case 359: return new int[] { 46, 105, 154 }; // Absol
                //case 359: return new int[] { 156, 156, 156 }; // Mega Absol
                case 360: return new int[] { 23, 23, 140 }; // Wynaut
                case 361: return new int[] { 39, 115, 141 }; // Snorunt
                case 362: return new int[] { 39, 115, 141 }; // Glalie
                //case 362: return new int[] { 174, 174, 174 }; // Mega Glalie
                case 363: return new int[] { 47, 115, 12 }; // Spheal
                case 364: return new int[] { 47, 115, 12 }; // Sealeo
                case 365: return new int[] { 47, 115, 12 }; // Walrein
                case 366: return new int[] { 75, 75, 155 }; // Clamperl
                case 367: return new int[] { 33, 33, 41 }; // Huntail
                case 368: return new int[] { 33, 33, 93 }; // Gorebyss
                case 369: return new int[] { 33, 69, 5 }; // Relicanth
                case 370: return new int[] { 33, 33, 93 }; // Luvdisc
                case 371: return new int[] { 69, 69, 125 }; // Bagon
                case 372: return new int[] { 69, 69, 142 }; // Shelgon
                case 373: return new int[] { 22, 22, 153 }; // Salamence
                //case 373: return new int[] { 184, 184, 184 }; // Mega Salamence
                case 374: return new int[] { 29, 29, 135 }; // Beldum
                case 375: return new int[] { 29, 29, 135 }; // Metang
                case 376: return new int[] { 29, 29, 135 }; // Metagross
                //case 376: return new int[] { 181, 181, 181 }; // Mega Metagross
                case 377: return new int[] { 29, 29, 5 }; // Regirock
                case 378: return new int[] { 29, 29, 115 }; // Regice
                case 379: return new int[] { 29, 29, 135 }; // Registeel
                case 380: return new int[] { 26, 26, 26 }; // Latias
                //case 380: return new int[] { 26, 26, 26 }; // Mega Latias
                case 381: return new int[] { 26, 26, 26 }; // Latios
                //case 381: return new int[] { 26, 26, 26 }; // Mega Latios
                case 382: return new int[] { 2, 2, 2 }; // Kyogre
                //case 382: return new int[] { 189, 189, 189 }; // Primal Kyogre
                case 383: return new int[] { 70, 70, 70 }; // Groudon
                //case 383: return new int[] { 190, 190, 190 }; // Primal Groudon
                case 384: return new int[] { 76, 76, 76 }; // Rayquaza
                //case 384: return new int[] { 191, 191, 191 }; // Mega Rayquaza
                case 385: return new int[] { 32, 32, 32 }; // Jirachi
                case 386: return new int[] { 46, 46, 46 }; // Deoxys - All formes
                case 387: return new int[] { 65, 65, 75 }; // Turtwig
                case 388: return new int[] { 65, 65, 75 }; // Grotle
                case 389: return new int[] { 65, 65, 75 }; // Torterra
                case 390: return new int[] { 66, 66, 89 }; // Chimchar
                case 391: return new int[] { 66, 66, 89 }; // Monferno
                case 392: return new int[] { 66, 66, 89 }; // Infernape
                case 393: return new int[] { 67, 67, 128 }; // Piplup
                case 394: return new int[] { 67, 67, 128 }; // Prinplup
                case 395: return new int[] { 67, 67, 128 }; // Empoleon
                case 396: return new int[] { 51, 51, 120 }; // Starly
                case 397: return new int[] { 22, 22, 120 }; // Staravia
                case 398: return new int[] { 22, 22, 120 }; // Staraptor
                case 399: return new int[] { 86, 109, 141 }; // Bidoof
                case 400: return new int[] { 86, 109, 141 }; // Bibarel
                case 401: return new int[] { 61, 61, 50 }; // Kricketot
                case 402: return new int[] { 68, 68, 101 }; // Kricketune
                case 403: return new int[] { 79, 22, 62 }; // Shinx
                case 404: return new int[] { 79, 22, 62 }; // Luxio
                case 405: return new int[] { 79, 22, 62 }; // Luxray
                case 406: return new int[] { 30, 38, 102 }; // Budew
                case 407: return new int[] { 30, 38, 101 }; // Roserade
                case 408: return new int[] { 104, 104, 125 }; // Cranidos
                case 409: return new int[] { 104, 104, 125 }; // Rampardos
                case 410: return new int[] { 5, 5, 43 }; // Shieldon
                case 411: return new int[] { 5, 5, 43 }; // Bastiodon
                case 412: return new int[] { 61, 61, 142 }; // Burmy - All formes
                case 413: return new int[] { 107, 107, 142 }; // Wormadam - All formes
                case 414: return new int[] { 68, 68, 110 }; // Mothim
                case 415: return new int[] { 118, 118, 55 }; // Combee
                case 416: return new int[] { 46, 46, 127 }; // Vespiquen
                case 417: return new int[] { 50, 53, 10 }; // Pachirisu
                case 418: return new int[] { 33, 33, 41 }; // Buizel
                case 419: return new int[] { 33, 33, 41 }; // Floatzel
                case 420: return new int[] { 34, 34, 34 }; // Cherubi
                case 421: return new int[] { 122, 122, 122 }; // Cherrim
                case 422: return new int[] { 60, 114, 159 }; // Shellos
                case 423: return new int[] { 60, 114, 159 }; // Gastrodon
                case 424: return new int[] { 101, 53, 92 }; // Ambipom
                case 425: return new int[] { 106, 84, 138 }; // Drifloon
                case 426: return new int[] { 106, 84, 138 }; // Drifblim
                case 427: return new int[] { 50, 103, 7 }; // Buneary
                case 428: return new int[] { 56, 103, 7 }; // Lopunny
                //case 428: return new int[] { 113, 113, 113 }; // Mega Lopunny
                case 429: return new int[] { 26, 26, 26 }; // Mismagius
                case 430: return new int[] { 15, 105, 153 }; // Honchkrow
                case 431: return new int[] { 7, 20, 51 }; // Glameow
                case 432: return new int[] { 47, 20, 128 }; // Purugly
                case 433: return new int[] { 26, 26, 26 }; // Chingling
                case 434: return new int[] { 1, 106, 51 }; // Stunky
                case 435: return new int[] { 1, 106, 51 }; // Skuntank
                case 436: return new int[] { 26, 85, 134 }; // Bronzor
                case 437: return new int[] { 26, 85, 134 }; // Bronzong
                case 438: return new int[] { 5, 69, 155 }; // Bonsly
                case 439: return new int[] { 43, 111, 101 }; // Mime Jr.
                case 440: return new int[] { 30, 32, 132 }; // Happiny
                case 441: return new int[] { 51, 77, 145 }; // Chatot
                case 442: return new int[] { 46, 46, 151 }; // Spiritomb
                case 443: return new int[] { 8, 8, 24 }; // Gible
                case 444: return new int[] { 8, 8, 24 }; // Gabite
                case 445: return new int[] { 8, 8, 24 }; // Garchomp
                //case 445: return new int[] { 159, 159, 159 }; // Mega Garchomp
                case 446: return new int[] { 53, 47, 82 }; // Munchlax
                case 447: return new int[] { 80, 39, 158 }; // Riolu
                case 448: return new int[] { 80, 39, 154 }; // Lucario
                //case 448: return new int[] { 91, 91, 91 }; // Mega Lucario
                case 449: return new int[] { 45, 45, 159 }; // Hippopotas
                case 450: return new int[] { 45, 45, 159 }; // Hippowdon
                case 451: return new int[] { 4, 97, 51 }; // Skorupi
                case 452: return new int[] { 4, 97, 51 }; // Drapion
                case 453: return new int[] { 107, 87, 143 }; // Croagunk
                case 454: return new int[] { 107, 87, 143 }; // Toxicroak
                case 455: return new int[] { 26, 26, 26 }; // Carnivine
                case 456: return new int[] { 33, 114, 41 }; // Finneon
                case 457: return new int[] { 33, 114, 41 }; // Lumineon
                case 458: return new int[] { 33, 11, 41 }; // Mantyke
                case 459: return new int[] { 117, 117, 43 }; // Snover
                case 460: return new int[] { 117, 117, 43 }; // Abomasnow
                //case 460: return new int[] { 117, 117, 117 }; // Mega Abomasnow
                case 461: return new int[] { 46, 46, 124 }; // Weavile
                case 462: return new int[] { 42, 5, 148 }; // Magnezone
                case 463: return new int[] { 20, 12, 13 }; // Lickilicky
                case 464: return new int[] { 31, 116, 120 }; // Rhyperior
                case 465: return new int[] { 34, 102, 144 }; // Tangrowth
                case 466: return new int[] { 78, 78, 72 }; // Electivire
                case 467: return new int[] { 49, 49, 72 }; // Magmortar
                case 468: return new int[] { 55, 32, 105 }; // Togekiss
                case 469: return new int[] { 3, 110, 119 }; // Yanmega
                case 470: return new int[] { 102, 102, 34 }; // Leafeon
                case 471: return new int[] { 81, 81, 115 }; // Glaceon
                case 472: return new int[] { 52, 8, 90 }; // Gliscor
                case 473: return new int[] { 12, 81, 47 }; // Mamoswine
                case 474: return new int[] { 91, 88, 148 }; // Porygon-Z
                case 475: return new int[] { 80, 80, 154 }; // Gallade
                //case 475: return new int[] { 39, 39, 39 }; // Mega Gallade
                case 476: return new int[] { 5, 42, 159 }; // Probopass
                case 477: return new int[] { 46, 46, 119 }; // Dusknoir
                case 478: return new int[] { 81, 81, 130 }; // Froslass
                case 479: return new int[] { 26, 26, 26 }; // Rotom - All formes
                case 480: return new int[] { 26, 26, 26 }; // Uxie
                case 481: return new int[] { 26, 26, 26 }; // Mesprit
                case 482: return new int[] { 26, 26, 26 }; // Azelf
                case 483: return new int[] { 46, 46, 140 }; // Dialga
                case 484: return new int[] { 46, 46, 140 }; // Palkia
                case 485: return new int[] { 18, 18, 49 }; // Heatran
                case 486: return new int[] { 112, 112, 112 }; // Regigigas
                case 487:
                    switch (forme)
                    {
                        case 1: return new int[] { 26, 26, 26 }; // Giratina - Origin
                        default: return new int[] { 46, 46, 140 }; // Giratina - Altered
                    }
                case 488: return new int[] { 26, 26, 26 }; // Cresselia
                case 489: return new int[] { 93, 93, 93 }; // Phione
                case 490: return new int[] { 93, 93, 93 }; // Manaphy
                case 491: return new int[] { 123, 123, 123 }; // Darkrai
                case 492:
                    switch (forme)
                    {
                        case 1: return new int[] { 32, 32, 32 }; // Shaymin - Sky
                        default: return new int[] { 30, 30, 30 }; // Shaymin - Land
                    }
                case 493: return new int[] { 121, 121, 121 }; // Arceus
                case 494: return new int[] { 162, 162, 162 }; // Victini
                case 495: return new int[] { 65, 65, 126 }; // Snivy
                case 496: return new int[] { 65, 65, 126 }; // Servine
                case 497: return new int[] { 65, 65, 126 }; // Serperior
                case 498: return new int[] { 66, 66, 47 }; // Tepig
                case 499: return new int[] { 66, 66, 47 }; // Pignite
                case 500: return new int[] { 66, 66, 120 }; // Emboar
                case 501: return new int[] { 67, 67, 75 }; // Oshawott
                case 502: return new int[] { 67, 67, 75 }; // Dewott
                case 503: return new int[] { 67, 67, 75 }; // Samurott
                case 504: return new int[] { 50, 51, 148 }; // Patrat
                case 505: return new int[] { 35, 51, 148 }; // Watchog
                case 506: return new int[] { 72, 53, 50 }; // Lillipup
                case 507: return new int[] { 22, 146, 113 }; // Herdier
                case 508: return new int[] { 22, 146, 113 }; // Stoutland
                case 509: return new int[] { 7, 84, 158 }; // Purrloin
                case 510: return new int[] { 7, 84, 158 }; // Liepard
                case 511: return new int[] { 82, 82, 65 }; // Pansage
                case 512: return new int[] { 82, 82, 65 }; // Simisage
                case 513: return new int[] { 82, 82, 66 }; // Pansear
                case 514: return new int[] { 82, 82, 66 }; // Simisear
                case 515: return new int[] { 82, 82, 67 }; // Panpour
                case 516: return new int[] { 82, 82, 67 }; // Simipour
                case 517: return new int[] { 108, 28, 140 }; // Munna
                case 518: return new int[] { 108, 28, 140 }; // Musharna
                case 519: return new int[] { 145, 105, 79 }; // Pidove
                case 520: return new int[] { 145, 105, 79 }; // Tranquill
                case 521: return new int[] { 145, 105, 79 }; // Unfezant
                case 522: return new int[] { 31, 78, 157 }; // Blitzle
                case 523: return new int[] { 31, 78, 157 }; // Zebstrika
                case 524: return new int[] { 5, 133, 159 }; // Roggenrola
                case 525: return new int[] { 5, 133, 159 }; // Boldore
                case 526: return new int[] { 5, 45, 159 }; // Gigalith
                case 527: return new int[] { 109, 103, 86 }; // Woobat
                case 528: return new int[] { 109, 103, 86 }; // Swoobat
                case 529: return new int[] { 146, 159, 104 }; // Drilbur
                case 530: return new int[] { 146, 159, 104 }; // Excadrill
                case 531: return new int[] { 131, 144, 103 }; // Audino
                //case 531: return new int[] { 131, 131, 131 }; // Mega Audino
                case 532: return new int[] { 62, 125, 89 }; // Timburr
                case 533: return new int[] { 62, 125, 89 }; // Gurdurr
                case 534: return new int[] { 62, 125, 89 }; // Conkeldurr
                case 535: return new int[] { 33, 93, 11 }; // Tympole
                case 536: return new int[] { 33, 93, 11 }; // Palpitoad
                case 537: return new int[] { 33, 143, 11 }; // Seismitoad
                case 538: return new int[] { 62, 39, 104 }; // Throh
                case 539: return new int[] { 5, 39, 104 }; // Sawk
                case 540: return new int[] { 68, 34, 142 }; // Sewaddle
                case 541: return new int[] { 102, 34, 142 }; // Swadloon
                case 542: return new int[] { 68, 34, 142 }; // Leavanny
                case 543: return new int[] { 38, 68, 3 }; // Venipede*
                case 544: return new int[] { 38, 68, 3 }; // Whirlipede*
                case 545: return new int[] { 38, 68, 3 }; // Scolipede*
                case 546: return new int[] { 158, 151, 34 }; // Cottonee
                case 547: return new int[] { 158, 151, 34 }; // Whimsicott
                case 548: return new int[] { 34, 20, 102 }; // Petilil
                case 549: return new int[] { 34, 20, 102 }; // Lilligant
                case 550:
                    switch (forme)
                    {
                        case 1: return new int[] { 69, 91, 104 }; // Basculin - Blue
                        default: return new int[] { 120, 91, 104 }; // Basculin - Red
                    }
                case 551: return new int[] { 22, 153, 83 }; // Sandile
                case 552: return new int[] { 22, 153, 83 }; // Krokorok
                case 553: return new int[] { 22, 153, 83 }; // Krookodile
                case 554: return new int[] { 55, 55, 39 }; // Darumaka
                case 555: return new int[] { 125, 125, 161 }; // Darmanitan
                case 556: return new int[] { 11, 34, 114 }; // Maractus
                case 557: return new int[] { 5, 75, 133 }; // Dwebble
                case 558: return new int[] { 5, 75, 133 }; // Crustle
                case 559: return new int[] { 61, 153, 22 }; // Scraggy
                case 560: return new int[] { 61, 153, 22 }; // Scrafty
                case 561: return new int[] { 147, 98, 110 }; // Sigilyph
                case 562: return new int[] { 152, 152, 152 }; // Yamask
                case 563: return new int[] { 152, 152, 152 }; // Cofagrigus
                case 564: return new int[] { 116, 5, 33 }; // Tirtouga
                case 565: return new int[] { 116, 5, 33 }; // Carracosta
                case 566: return new int[] { 129, 129, 129 }; // Archen
                case 567: return new int[] { 129, 129, 129 }; // Archeops
                case 568: return new int[] { 1, 60, 106 }; // Trubbish
                case 569: return new int[] { 1, 133, 106 }; // Garbodor
                case 570: return new int[] { 149, 149, 149 }; // Zorua
                case 571: return new int[] { 149, 149, 149 }; // Zoroark
                case 572: return new int[] { 56, 101, 92 }; // Minccino
                case 573: return new int[] { 56, 101, 92 }; // Cinccino
                case 574: return new int[] { 119, 172, 23 }; // Gothita
                case 575: return new int[] { 119, 172, 23 }; // Gothorita
                case 576: return new int[] { 119, 172, 23 }; // Gothitelle
                case 577: return new int[] { 142, 98, 144 }; // Solosis
                case 578: return new int[] { 142, 98, 144 }; // Duosion
                case 579: return new int[] { 142, 98, 144 }; // Reuniclus
                case 580: return new int[] { 51, 145, 93 }; // Ducklett
                case 581: return new int[] { 51, 145, 93 }; // Swanna
                case 582: return new int[] { 115, 81, 133 }; // Vanillite
                case 583: return new int[] { 115, 81, 133 }; // Vanillish
                case 584: return new int[] { 115, 117, 133 }; // Vanilluxe
                case 585: return new int[] { 34, 157, 32 }; // Deerling - All formes
                case 586: return new int[] { 34, 157, 32 }; // Sawsbuck - All formes
                case 587: return new int[] { 9, 9, 78 }; // Emolga
                case 588: return new int[] { 68, 61, 99 }; // Karrablast
                case 589: return new int[] { 68, 75, 142 }; // Escavalier
                case 590: return new int[] { 27, 27, 144 }; // Foongus
                case 591: return new int[] { 27, 27, 144 }; // Amoonguss
                case 592: return new int[] { 11, 130, 6 }; // Frillish
                case 593: return new int[] { 11, 130, 6 }; // Jellicent
                case 594: return new int[] { 131, 93, 144 }; // Alomomola
                case 595: return new int[] { 14, 127, 68 }; // Joltik
                case 596: return new int[] { 14, 127, 68 }; // Galvantula
                case 597: return new int[] { 160, 160, 160 }; // Ferroseed
                case 598: return new int[] { 160, 160, 107 }; // Ferrothorn
                case 599: return new int[] { 57, 58, 29 }; // Klink
                case 600: return new int[] { 57, 58, 29 }; // Klang
                case 601: return new int[] { 57, 58, 29 }; // Klinklang
                case 602: return new int[] { 26, 26, 26 }; // Tynamo
                case 603: return new int[] { 26, 26, 26 }; // Eelektrik
                case 604: return new int[] { 26, 26, 26 }; // Eelektross
                case 605: return new int[] { 140, 28, 148 }; // Elgyem
                case 606: return new int[] { 140, 28, 148 }; // Beheeyem
                case 607: return new int[] { 18, 49, 151 }; // Litwick
                case 608: return new int[] { 18, 49, 151 }; // Lampent
                case 609: return new int[] { 18, 49, 151 }; // Chandelure
                case 610: return new int[] { 79, 104, 127 }; // Axew
                case 611: return new int[] { 79, 104, 127 }; // Fraxure
                case 612: return new int[] { 79, 104, 127 }; // Haxorus
                case 613: return new int[] { 81, 202, 155 }; // Cubchoo
                case 614: return new int[] { 81, 202, 33 }; // Cubchoo
                case 615: return new int[] { 26, 26, 26 }; // Cryogonal
                case 616: return new int[] { 93, 75, 142 }; // Shelmet
                case 617: return new int[] { 93, 60, 84 }; // Accelgor
                case 618: return new int[] { 9, 7, 8 }; // Stunfisk
                case 619: return new int[] { 39, 144, 120 }; // Mienfoo
                case 620: return new int[] { 39, 144, 120 }; // Mienshao
                case 621: return new int[] { 24, 125, 104 }; // Druddigon
                case 622: return new int[] { 89, 103, 99 }; // Golett
                case 623: return new int[] { 89, 103, 99 }; // Golurk
                case 624: return new int[] { 128, 39, 46 }; // Pawniard
                case 625: return new int[] { 128, 39, 46 }; // Bisharp
                case 626: return new int[] { 120, 157, 43 }; // Bouffalant
                case 627: return new int[] { 51, 125, 55 }; // Rufflet
                case 628: return new int[] { 51, 125, 128 }; // Braviary
                case 629: return new int[] { 145, 142, 133 }; // Vullaby
                case 630: return new int[] { 145, 142, 133 }; // Mandibuzz
                case 631: return new int[] { 82, 18, 73 }; // Heatmor
                case 632: return new int[] { 68, 55, 54 }; // Durant
                case 633: return new int[] { 55, 55, 55 }; // Deino
                case 634: return new int[] { 55, 55, 55 }; // Zweilous
                case 635: return new int[] { 26, 26, 26 }; // Hydreigon
                case 636: return new int[] { 49, 49, 68 }; // Larvesta
                case 637: return new int[] { 49, 49, 68 }; // Volcarona
                case 638: return new int[] { 154, 154, 154 }; // Cobalion
                case 639: return new int[] { 154, 154, 154 }; // Terrakion
                case 640: return new int[] { 154, 154, 154 }; // Virizion
                case 641:
                    switch (forme)
                    {
                        case 1: return new int[] { 144, 144, 144 }; // Tornadus - Therian
                        default: return new int[] { 158, 158, 128 }; // Tornadus - Incarnate
                    }
                case 642:
                    switch (forme)
                    {
                        case 1: return new int[] { 10, 10, 10 }; // Thundurus - Therian
                        default: return new int[] { 158, 158, 128 }; // Thundurus - Incarnate
                    }
                case 643: return new int[] { 163, 163, 163 }; // Reshiram
                case 644: return new int[] { 164, 164, 164 }; // Zekrom
                case 645:
                    switch (forme)
                    {
                        case 1: return new int[] { 22, 22, 22 }; // Landorus - Therian
                        default: return new int[] { 159, 159, 125 }; // Landorus - Incarnate
                    }
                case 646:
                    switch (forme)
                    {
                        case 1: return new int[] { 163, 163, 163 }; // White Kyurem
                        case 2: return new int[] { 164, 164, 164 }; // Black Kyurem
                        default: return new int[] { 46, 46, 46 }; // Kyurem
                    }
                case 647: return new int[] { 154, 154, 154 }; // Keldeo
                case 648: return new int[] { 32, 32, 32 }; // Meloetta
                case 649: return new int[] { 88, 88, 88 }; // Genesect
                case 650: return new int[] { 65, 65, 171 }; // Chespin
                case 651: return new int[] { 65, 65, 171 }; // Quilladin
                case 652: return new int[] { 65, 65, 171 }; // Chesnaught
                case 653: return new int[] { 66, 66, 170 }; // Fennekin
                case 654: return new int[] { 66, 66, 170 }; // Braixen
                case 655: return new int[] { 66, 66, 170 }; // Delphox
                case 656: return new int[] { 67, 67, 168 }; // Froakie
                case 657: return new int[] { 67, 67, 168 }; // Frogadier
                case 658:
                    switch (forme)
                    {
                        case 1: return new int[] { 210, 210, 210 }; // Ash-Greninja
                        default: return new int[] { 67, 67, 168 }; // Greninja
                    }
                case 659: return new int[] { 53, 167, 37 }; // Bunnelby
                case 660: return new int[] { 53, 167, 37 }; // Diggersby
                case 661: return new int[] { 145, 145, 177 }; // Fletchling
                case 662: return new int[] { 49, 49, 177 }; // Fletchinder
                case 663: return new int[] { 49, 49, 177 }; // Talonflame
                case 664: return new int[] { 19, 14, 132 }; // Scatterbug
                case 665: return new int[] { 61, 61, 132 }; // Spewpa
                case 666: return new int[] { 19, 14, 132 }; // Vivillon
                case 667: return new int[] { 79, 127, 153 }; // Litleo
                case 668: return new int[] { 79, 127, 153 }; // Pyroar
                case 669: return new int[] { 166, 166, 180 }; // Flabébé
                case 670: return new int[] { 166, 166, 180 }; // Floette
                case 671: return new int[] { 166, 166, 180 }; // Florges
                case 672: return new int[] { 157, 157, 179 }; // Skiddo
                case 673: return new int[] { 157, 157, 179 }; // Gogoat
                case 674: return new int[] { 89, 104, 113 }; // Pancham
                case 675: return new int[] { 89, 104, 113 }; // Pangoro
                case 676: return new int[] { 169, 169, 169 }; // Furfrou
                case 677: return new int[] { 51, 151, 20 }; // Espurr
                case 678:
                    switch (forme)
                    {
                        case 1: return new int[] { 51, 151, 172 }; // Meowstic♀
                        default: return new int[] { 51, 151, 158 }; // Meowstic♂
                    }
                case 679: return new int[] { 99, 99, 99 }; // Honedge
                case 680: return new int[] { 99, 99, 99 }; // Doublade
                case 681: return new int[] { 176, 176, 176 }; // Aegislash
                case 682: return new int[] { 131, 131, 165 }; // Spritzee
                case 683: return new int[] { 131, 131, 165 }; // Aromatisse
                case 684: return new int[] { 175, 175, 84 }; // Swirlix
                case 685: return new int[] { 175, 175, 84 }; // Slurpuff
                case 686: return new int[] { 126, 21, 151 }; // Inkay
                case 687: return new int[] { 126, 21, 151 }; // Malamar
                case 688: return new int[] { 97, 181, 124 }; // Binacle
                case 689: return new int[] { 97, 181, 124 }; // Barbaracle
                case 690: return new int[] { 38, 143, 91 }; // Skrelp
                case 691: return new int[] { 38, 143, 91 }; // Dragalge
                case 692: return new int[] { 178, 178, 178 }; // Clauncher
                case 693: return new int[] { 178, 178, 178 }; // Clawitzer
                case 694: return new int[] { 87, 8, 94 }; // Helioptile
                case 695: return new int[] { 87, 8, 94 }; // Heliolisk
                case 696: return new int[] { 173, 173, 5 }; // Tyrunt
                case 697: return new int[] { 173, 173, 69 }; // Tyrantrum
                case 698: return new int[] { 174, 174, 117 }; // Amaura
                case 699: return new int[] { 174, 174, 117 }; // Aurorus
                case 700: return new int[] { 56, 56, 182 }; // Sylveon
                case 701: return new int[] { 7, 84, 104 }; // Hawlucha
                case 702: return new int[] { 167, 53, 57 }; // Dedenne
                case 703: return new int[] { 29, 29, 5 }; // Carbink
                case 704: return new int[] { 157, 93, 183 }; // Goomy
                case 705: return new int[] { 157, 93, 183 }; // Sliggoo
                case 706: return new int[] { 157, 93, 183 }; // Goodra
                case 707: return new int[] { 158, 158, 170 }; // Klefki
                case 708: return new int[] { 30, 119, 139 }; // Phantump
                case 709: return new int[] { 30, 119, 139 }; // Trevenant
                case 710: return new int[] { 53, 119, 15 }; // Pumpkaboo
                case 711: return new int[] { 53, 119, 15 }; // Gourgeist
                case 712: return new int[] { 20, 115, 5 }; // Bergmite
                case 713: return new int[] { 20, 115, 5 }; // Avalugg
                case 714: return new int[] { 119, 151, 140 }; // Noibat
                case 715: return new int[] { 119, 151, 140 }; // Noivern
                case 716: return new int[] { 187, 187, 187 }; // Xerneas
                case 717: return new int[] { 186, 186, 186 }; // Yveltal
                case 718:
                    switch (forme)
                    {
                        case 1: return new int[] { 188, 188, 188 }; // Zygarde 10% - Aura Break
                        case 2: return new int[] { 211, 211, 211 }; // Zygarde 10% - Power Construct
                        case 3: return new int[] { 211, 211, 211 }; // Zygarde 50% - Power Construct
                        case 4: return new int[] { 211, 211, 211 }; // Zygarde 100% - Power Construct
                        default: return new int[] { 188, 188, 188 }; // Zygarde 50% - Aura Break
                    }
                case 719: return new int[] { 29, 29, 29 }; // Diancie
                //case 719: return new int[] { 156, 156, 156 }; // Mega Diancie
                case 720: return new int[] { 170, 170, 170 }; // Hoopa Confined
                case 721: return new int[] { 11, 11, 11 }; // Volcanion
                case 722: return new int[] { 65, 65, 203 }; // Rowlet
                case 723: return new int[] { 65, 65, 203 }; // Dartrix
                case 724: return new int[] { 65, 65, 203 }; // Decidueye
                case 725: return new int[] { 66, 66, 22 }; // Litten
                case 726: return new int[] { 66, 66, 22 }; // Torracat
                case 727: return new int[] { 66, 66, 22 }; // Incineroar
                case 728: return new int[] { 67, 67, 204 }; // Popplio
                case 729: return new int[] { 67, 67, 204 }; // Brionne
                case 730: return new int[] { 67, 67, 204 }; // Primarina
                case 731: return new int[] { 51, 92, 51 }; // Pikipek
                case 732: return new int[] { 51, 92, 51 }; // Trumbeak
                case 733: return new int[] { 51, 92, 51 }; // Toucannon
                case 734: return new int[] { 198, 173, 91 }; // Yungoos
                case 735: return new int[] { 198, 173, 91 }; // Gumshoos
                case 736: return new int[] { 68, 68, 68 }; // Grubbin
                case 737: return new int[] { 217, 217, 217 }; // Charjabug
                case 738: return new int[] { 26, 26, 26 }; // Vikavolt
                case 739: return new int[] { 52, 89, 83 }; // Crabrawler
                case 740: return new int[] { 52, 89, 83 }; // Crabominable
                case 741: return new int[] { 216, 216, 216 }; // Oricorio
                case 742: return new int[] { 118, 19, 175 }; // Cutiefly
                case 743: return new int[] { 118, 19, 175 }; // Ribombee
                case 744: return new int[] { 51, 72, 80 }; // Rockruff
                case 745:
                    switch (forme)
                    {
                        case 1: return new int[] { 51, 72, 99 }; // Midnight Form Lycanroc
                        default: return new int[] { 51, 146, 80 }; // Midday Form Lycanroc
                    }
                case 746: return new int[] { 208, 208, 208 }; // Wishiwashi
                case 747: return new int[] { 196, 7, 144 }; // Mareanie
                case 748: return new int[] { 196, 7, 144 }; // Toxapex
                case 749: return new int[] { 20, 192, 39 }; // Mudbray
                case 750: return new int[] { 20, 192, 39 }; // Mudsdale
                case 751: return new int[] { 199, 199, 11 }; // Dewpider
                case 752: return new int[] { 199, 199, 11 }; // Araquanid
                case 753: return new int[] { 102, 102, 126 }; // Fomantis
                case 754: return new int[] { 102, 102, 126 }; // Lurantis
                case 755: return new int[] { 35, 27, 44 }; // Morelull
                case 756: return new int[] { 35, 27, 44 }; // Shiinotic
                case 757: return new int[] { 212, 212, 12 }; // Salandit
                case 758: return new int[] { 212, 212, 12 }; // Salazzle
                case 759: return new int[] { 218, 103, 56 }; // Stufful
                case 760: return new int[] { 218, 103, 127 }; // Bewear
                case 761: return new int[] { 102, 12, 175 }; // Bounsweet
                case 762: return new int[] { 102, 12, 175 }; // Steenee
                case 763: return new int[] { 102, 214, 175 }; // Tsareena
                case 764: return new int[] { 166, 205, 30 }; // Comfey
                case 765: return new int[] { 39, 140, 180 }; // Oranguru
                case 766: return new int[] { 222, 222, 128 }; // Passimian
                case 767: return new int[] { 193, 193, 193 }; // Wimpod
                case 768: return new int[] { 194, 194, 194 }; // Golisopod
                case 769: return new int[] { 195, 195, 8 }; // Sandygast
                case 770: return new int[] { 195, 195, 8 }; // Palossand
                case 771: return new int[] { 215, 215, 109 }; // Pyukumuku
                case 772: return new int[] { 4, 4, 4 }; // Type: Null
                case 773: return new int[] { 225, 225, 225 }; // Silvally
                case 774: return new int[] { 197, 197, 197 }; // Minior
                case 775: return new int[] { 213, 213, 213 }; // Komala
                case 776: return new int[] { 75, 75, 75 }; // Turtonator
                case 777: return new int[] { 160, 31, 5 }; // Togedemaru
                case 778: return new int[] { 209, 209, 209 }; // Mimikyu
                case 779: return new int[] { 219, 173, 147 }; // Bruxish
                case 780: return new int[] { 201, 157, 13 }; // Drampa
                case 781: return new int[] { 200, 200, 200 }; // Dhelmise
                case 782: return new int[] { 171, 43, 142 }; // Jangmo-o
                case 783: return new int[] { 171, 43, 142 }; // Hakamo-o
                case 784: return new int[] { 171, 43, 142 }; // Kommo-o
                case 785: return new int[] { 226, 226, 140 }; // Tapu Koko
                case 786: return new int[] { 227, 227, 140 }; // Tapu Lele
                case 787: return new int[] { 229, 229, 140 }; // Tapu Bulu
                case 788: return new int[] { 228, 228, 140 }; // Tapu Fini
                case 789: return new int[] { 109, 109, 109 }; // Cosmog
                case 790: return new int[] { 5, 5, 5 }; // Cosmoem
                case 791: return new int[] { 230, 230, 230 }; // Solgaleo
                case 792: return new int[] { 231, 231, 231 }; // Lunala
                case 793: return new int[] { 224, 224, 224 }; // Nihilego
                case 794: return new int[] { 224, 224, 224 }; // Buzzwole
                case 795: return new int[] { 224, 224, 224 }; // Pheromosa
                case 796: return new int[] { 224, 224, 224 }; // Xurkitree
                case 797: return new int[] { 224, 224, 224 }; // Celesteela
                case 798: return new int[] { 224, 224, 224 }; // Kartana
                case 799: return new int[] { 224, 224, 224 }; // Guzzlord
                case 800: return new int[] { 232, 232, 232 }; // Necrozma
                case 801: return new int[] { 220, 220, 220 }; // Magearna
                case 802: return new int[] { 101, 101, 101 }; // Marshadow
                default: return new int[] { 0, 0, 0 }; // No pokémon
            }
        }

        #endregion Ability

        #region Species

        public string[] Species6
        {
            get
            {
                string[] data = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch’d", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr-Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew", "Chikorita", "Bayleef", "Meganium", "Cyndaquil", "Quilava", "Typhlosion", "Totodile", "Croconaw", "Feraligatr", "Sentret", "Furret", "Hoothoot", "Noctowl", "Ledyba", "Ledian", "Spinarak", "Ariados", "Crobat", "Chinchou", "Lanturn", "Pichu", "Cleffa", "Igglybuff", "Togepi", "Togetic", "Natu", "Xatu", "Mareep", "Flaaffy", "Ampharos", "Bellossom", "Marill", "Azumarill", "Sudowoodo", "Politoed", "Hoppip", "Skiploom", "Jumpluff", "Aipom", "Sunkern", "Sunflora", "Yanma", "Wooper", "Quagsire", "Espeon", "Umbreon", "Murkrow", "Slowking", "Misdreavus", "Unown", "Wobbuffet", "Girafarig", "Pineco", "Forretress", "Dunsparce", "Gligar", "Steelix", "Snubbull", "Granbull", "Qwilfish", "Scizor", "Shuckle", "Heracross", "Sneasel", "Teddiursa", "Ursaring", "Slugma", "Magcargo", "Swinub", "Piloswine", "Corsola", "Remoraid", "Octillery", "Delibird", "Mantine", "Skarmory", "Houndour", "Houndoom", "Kingdra", "Phanpy", "Donphan", "Porygon2", "Stantler", "Smeargle", "Tyrogue", "Hitmontop", "Smoochum", "Elekid", "Magby", "Miltank", "Blissey", "Raikou", "Entei", "Suicune", "Larvitar", "Pupitar", "Tyranitar", "Lugia", "Ho-Oh", "Celebi", "Treecko", "Grovyle", "Sceptile", "Torchic", "Combusken", "Blaziken", "Mudkip", "Marshtomp", "Swampert", "Poochyena", "Mightyena", "Zigzagoon", "Linoone", "Wurmple", "Silcoon", "Beautifly", "Cascoon", "Dustox", "Lotad", "Lombre", "Ludicolo", "Seedot", "Nuzleaf", "Shiftry", "Taillow", "Swellow", "Wingull", "Pelipper", "Ralts", "Kirlia", "Gardevoir", "Surskit", "Masquerain", "Shroomish", "Breloom", "Slakoth", "Vigoroth", "Slaking", "Nincada", "Ninjask", "Shedinja", "Whismur", "Loudred", "Exploud", "Makuhita", "Hariyama", "Azurill", "Nosepass", "Skitty", "Delcatty", "Sableye", "Mawile", "Aron", "Lairon", "Aggron", "Meditite", "Medicham", "Electrike", "Manectric", "Plusle", "Minun", "Volbeat", "Illumise", "Roselia", "Gulpin", "Swalot", "Carvanha", "Sharpedo", "Wailmer", "Wailord", "Numel", "Camerupt", "Torkoal", "Spoink", "Grumpig", "Spinda", "Trapinch", "Vibrava", "Flygon", "Cacnea", "Cacturne", "Swablu", "Altaria", "Zangoose", "Seviper", "Lunatone", "Solrock", "Barboach", "Whiscash", "Corphish", "Crawdaunt", "Baltoy", "Claydol", "Lileep", "Cradily", "Anorith", "Armaldo", "Feebas", "Milotic", "Castform", "Kecleon", "Shuppet", "Banette", "Duskull", "Dusclops", "Tropius", "Chimecho", "Absol", "Wynaut", "Snorunt", "Glalie", "Spheal", "Sealeo", "Walrein", "Clamperl", "Huntail", "Gorebyss", "Relicanth", "Luvdisc", "Bagon", "Shelgon", "Salamence", "Beldum", "Metang", "Metagross", "Regirock", "Regice", "Registeel", "Latias", "Latios", "Kyogre", "Groudon", "Rayquaza", "Jirachi", "Deoxys", "Turtwig", "Grotle", "Torterra", "Chimchar", "Monferno", "Infernape", "Piplup", "Prinplup", "Empoleon", "Starly", "Staravia", "Staraptor", "Bidoof", "Bibarel", "Kricketot", "Kricketune", "Shinx", "Luxio", "Luxray", "Budew", "Roserade", "Cranidos", "Rampardos", "Shieldon", "Bastiodon", "Burmy", "Wormadam", "Mothim", "Combee", "Vespiquen", "Pachirisu", "Buizel", "Floatzel", "Cherubi", "Cherrim", "Shellos", "Gastrodon", "Ambipom", "Drifloon", "Drifblim", "Buneary", "Lopunny", "Mismagius", "Honchkrow", "Glameow", "Purugly", "Chingling", "Stunky", "Skuntank", "Bronzor", "Bronzong", "Bonsly", "Mime-Jr.", "Happiny", "Chatot", "Spiritomb", "Gible", "Gabite", "Garchomp", "Munchlax", "Riolu", "Lucario", "Hippopotas", "Hippowdon", "Skorupi", "Drapion", "Croagunk", "Toxicroak", "Carnivine", "Finneon", "Lumineon", "Mantyke", "Snover", "Abomasnow", "Weavile", "Magnezone", "Lickilicky", "Rhyperior", "Tangrowth", "Electivire", "Magmortar", "Togekiss", "Yanmega", "Leafeon", "Glaceon", "Gliscor", "Mamoswine", "Porygon-Z", "Gallade", "Probopass", "Dusknoir", "Froslass", "Rotom", "Uxie", "Mesprit", "Azelf", "Dialga", "Palkia", "Heatran", "Regigigas", "Giratina", "Cresselia", "Phione", "Manaphy", "Darkrai", "Shaymin", "Arceus", "Victini", "Snivy", "Servine", "Serperior", "Tepig", "Pignite", "Emboar", "Oshawott", "Dewott", "Samurott", "Patrat", "Watchog", "Lillipup", "Herdier", "Stoutland", "Purrloin", "Liepard", "Pansage", "Simisage", "Pansear", "Simisear", "Panpour", "Simipour", "Munna", "Musharna", "Pidove", "Tranquill", "Unfezant", "Blitzle", "Zebstrika", "Roggenrola", "Boldore", "Gigalith", "Woobat", "Swoobat", "Drilbur", "Excadrill", "Audino", "Timburr", "Gurdurr", "Conkeldurr", "Tympole", "Palpitoad", "Seismitoad", "Throh", "Sawk", "Sewaddle", "Swadloon", "Leavanny", "Venipede", "Whirlipede", "Scolipede", "Cottonee", "Whimsicott", "Petilil", "Lilligant", "Basculin", "Sandile", "Krokorok", "Krookodile", "Darumaka", "Darmanitan", "Maractus", "Dwebble", "Crustle", "Scraggy", "Scrafty", "Sigilyph", "Yamask", "Cofagrigus", "Tirtouga", "Carracosta", "Archen", "Archeops", "Trubbish", "Garbodor", "Zorua", "Zoroark", "Minccino", "Cinccino", "Gothita", "Gothorita", "Gothitelle", "Solosis", "Duosion", "Reuniclus", "Ducklett", "Swanna", "Vanillite", "Vanillish", "Vanilluxe", "Deerling", "Sawsbuck", "Emolga", "Karrablast", "Escavalier", "Foongus", "Amoonguss", "Frillish", "Jellicent", "Alomomola", "Joltik", "Galvantula", "Ferroseed", "Ferrothorn", "Klink", "Klang", "Klinklang", "Tynamo", "Eelektrik", "Eelektross", "Elgyem", "Beheeyem", "Litwick", "Lampent", "Chandelure", "Axew", "Fraxure", "Haxorus", "Cubchoo", "Beartic", "Cryogonal", "Shelmet", "Accelgor", "Stunfisk", "Mienfoo", "Mienshao", "Druddigon", "Golett", "Golurk", "Pawniard", "Bisharp", "Bouffalant", "Rufflet", "Braviary", "Vullaby", "Mandibuzz", "Heatmor", "Durant", "Deino", "Zweilous", "Hydreigon", "Larvesta", "Volcarona", "Cobalion", "Terrakion", "Virizion", "Tornadus", "Thundurus", "Reshiram", "Zekrom", "Landorus", "Kyurem", "Keldeo", "Meloetta", "Genesect", "Chespin", "Quilladin", "Chesnaught", "Fennekin", "Braixen", "Delphox", "Froakie", "Frogadier", "Greninja", "Bunnelby", "Diggersby", "Fletchling", "Fletchinder", "Talonflame", "Scatterbug", "Spewpa", "Vivillon", "Litleo", "Pyroar", "Flabebe", "Floette", "Florges", "Skiddo", "Gogoat", "Pancham", "Pangoro", "Furfrou", "Espurr", "Meowstic", "Honedge", "Doublade", "Aegislash", "Spritzee", "Aromatisse", "Swirlix", "Slurpuff", "Inkay", "Malamar", "Binacle", "Barbaracle", "Skrelp", "Dragalge", "Clauncher", "Clawitzer", "Helioptile", "Heliolisk", "Tyrunt", "Tyrantrum", "Amaura", "Aurorus", "Sylveon", "Hawlucha", "Dedenne", "Carbink", "Goomy", "Sliggoo", "Goodra", "Klefki", "Phantump", "Trevenant", "Pumpkaboo", "Gourgeist", "Bergmite", "Avalugg", "Noibat", "Noivern", "Xerneas", "Yveltal", "Zygarde", "Diancie", "Hoopa", "Volcanion", "Egg" };
                return data;
            }
        }

        public string[] Species7
        {
            get
            {
                string[] data = { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch’d", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr-Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew", "Chikorita", "Bayleef", "Meganium", "Cyndaquil", "Quilava", "Typhlosion", "Totodile", "Croconaw", "Feraligatr", "Sentret", "Furret", "Hoothoot", "Noctowl", "Ledyba", "Ledian", "Spinarak", "Ariados", "Crobat", "Chinchou", "Lanturn", "Pichu", "Cleffa", "Igglybuff", "Togepi", "Togetic", "Natu", "Xatu", "Mareep", "Flaaffy", "Ampharos", "Bellossom", "Marill", "Azumarill", "Sudowoodo", "Politoed", "Hoppip", "Skiploom", "Jumpluff", "Aipom", "Sunkern", "Sunflora", "Yanma", "Wooper", "Quagsire", "Espeon", "Umbreon", "Murkrow", "Slowking", "Misdreavus", "Unown", "Wobbuffet", "Girafarig", "Pineco", "Forretress", "Dunsparce", "Gligar", "Steelix", "Snubbull", "Granbull", "Qwilfish", "Scizor", "Shuckle", "Heracross", "Sneasel", "Teddiursa", "Ursaring", "Slugma", "Magcargo", "Swinub", "Piloswine", "Corsola", "Remoraid", "Octillery", "Delibird", "Mantine", "Skarmory", "Houndour", "Houndoom", "Kingdra", "Phanpy", "Donphan", "Porygon2", "Stantler", "Smeargle", "Tyrogue", "Hitmontop", "Smoochum", "Elekid", "Magby", "Miltank", "Blissey", "Raikou", "Entei", "Suicune", "Larvitar", "Pupitar", "Tyranitar", "Lugia", "Ho-Oh", "Celebi", "Treecko", "Grovyle", "Sceptile", "Torchic", "Combusken", "Blaziken", "Mudkip", "Marshtomp", "Swampert", "Poochyena", "Mightyena", "Zigzagoon", "Linoone", "Wurmple", "Silcoon", "Beautifly", "Cascoon", "Dustox", "Lotad", "Lombre", "Ludicolo", "Seedot", "Nuzleaf", "Shiftry", "Taillow", "Swellow", "Wingull", "Pelipper", "Ralts", "Kirlia", "Gardevoir", "Surskit", "Masquerain", "Shroomish", "Breloom", "Slakoth", "Vigoroth", "Slaking", "Nincada", "Ninjask", "Shedinja", "Whismur", "Loudred", "Exploud", "Makuhita", "Hariyama", "Azurill", "Nosepass", "Skitty", "Delcatty", "Sableye", "Mawile", "Aron", "Lairon", "Aggron", "Meditite", "Medicham", "Electrike", "Manectric", "Plusle", "Minun", "Volbeat", "Illumise", "Roselia", "Gulpin", "Swalot", "Carvanha", "Sharpedo", "Wailmer", "Wailord", "Numel", "Camerupt", "Torkoal", "Spoink", "Grumpig", "Spinda", "Trapinch", "Vibrava", "Flygon", "Cacnea", "Cacturne", "Swablu", "Altaria", "Zangoose", "Seviper", "Lunatone", "Solrock", "Barboach", "Whiscash", "Corphish", "Crawdaunt", "Baltoy", "Claydol", "Lileep", "Cradily", "Anorith", "Armaldo", "Feebas", "Milotic", "Castform", "Kecleon", "Shuppet", "Banette", "Duskull", "Dusclops", "Tropius", "Chimecho", "Absol", "Wynaut", "Snorunt", "Glalie", "Spheal", "Sealeo", "Walrein", "Clamperl", "Huntail", "Gorebyss", "Relicanth", "Luvdisc", "Bagon", "Shelgon", "Salamence", "Beldum", "Metang", "Metagross", "Regirock", "Regice", "Registeel", "Latias", "Latios", "Kyogre", "Groudon", "Rayquaza", "Jirachi", "Deoxys", "Turtwig", "Grotle", "Torterra", "Chimchar", "Monferno", "Infernape", "Piplup", "Prinplup", "Empoleon", "Starly", "Staravia", "Staraptor", "Bidoof", "Bibarel", "Kricketot", "Kricketune", "Shinx", "Luxio", "Luxray", "Budew", "Roserade", "Cranidos", "Rampardos", "Shieldon", "Bastiodon", "Burmy", "Wormadam", "Mothim", "Combee", "Vespiquen", "Pachirisu", "Buizel", "Floatzel", "Cherubi", "Cherrim", "Shellos", "Gastrodon", "Ambipom", "Drifloon", "Drifblim", "Buneary", "Lopunny", "Mismagius", "Honchkrow", "Glameow", "Purugly", "Chingling", "Stunky", "Skuntank", "Bronzor", "Bronzong", "Bonsly", "Mime-Jr.", "Happiny", "Chatot", "Spiritomb", "Gible", "Gabite", "Garchomp", "Munchlax", "Riolu", "Lucario", "Hippopotas", "Hippowdon", "Skorupi", "Drapion", "Croagunk", "Toxicroak", "Carnivine", "Finneon", "Lumineon", "Mantyke", "Snover", "Abomasnow", "Weavile", "Magnezone", "Lickilicky", "Rhyperior", "Tangrowth", "Electivire", "Magmortar", "Togekiss", "Yanmega", "Leafeon", "Glaceon", "Gliscor", "Mamoswine", "Porygon-Z", "Gallade", "Probopass", "Dusknoir", "Froslass", "Rotom", "Uxie", "Mesprit", "Azelf", "Dialga", "Palkia", "Heatran", "Regigigas", "Giratina", "Cresselia", "Phione", "Manaphy", "Darkrai", "Shaymin", "Arceus", "Victini", "Snivy", "Servine", "Serperior", "Tepig", "Pignite", "Emboar", "Oshawott", "Dewott", "Samurott", "Patrat", "Watchog", "Lillipup", "Herdier", "Stoutland", "Purrloin", "Liepard", "Pansage", "Simisage", "Pansear", "Simisear", "Panpour", "Simipour", "Munna", "Musharna", "Pidove", "Tranquill", "Unfezant", "Blitzle", "Zebstrika", "Roggenrola", "Boldore", "Gigalith", "Woobat", "Swoobat", "Drilbur", "Excadrill", "Audino", "Timburr", "Gurdurr", "Conkeldurr", "Tympole", "Palpitoad", "Seismitoad", "Throh", "Sawk", "Sewaddle", "Swadloon", "Leavanny", "Venipede", "Whirlipede", "Scolipede", "Cottonee", "Whimsicott", "Petilil", "Lilligant", "Basculin", "Sandile", "Krokorok", "Krookodile", "Darumaka", "Darmanitan", "Maractus", "Dwebble", "Crustle", "Scraggy", "Scrafty", "Sigilyph", "Yamask", "Cofagrigus", "Tirtouga", "Carracosta", "Archen", "Archeops", "Trubbish", "Garbodor", "Zorua", "Zoroark", "Minccino", "Cinccino", "Gothita", "Gothorita", "Gothitelle", "Solosis", "Duosion", "Reuniclus", "Ducklett", "Swanna", "Vanillite", "Vanillish", "Vanilluxe", "Deerling", "Sawsbuck", "Emolga", "Karrablast", "Escavalier", "Foongus", "Amoonguss", "Frillish", "Jellicent", "Alomomola", "Joltik", "Galvantula", "Ferroseed", "Ferrothorn", "Klink", "Klang", "Klinklang", "Tynamo", "Eelektrik", "Eelektross", "Elgyem", "Beheeyem", "Litwick", "Lampent", "Chandelure", "Axew", "Fraxure", "Haxorus", "Cubchoo", "Beartic", "Cryogonal", "Shelmet", "Accelgor", "Stunfisk", "Mienfoo", "Mienshao", "Druddigon", "Golett", "Golurk", "Pawniard", "Bisharp", "Bouffalant", "Rufflet", "Braviary", "Vullaby", "Mandibuzz", "Heatmor", "Durant", "Deino", "Zweilous", "Hydreigon", "Larvesta", "Volcarona", "Cobalion", "Terrakion", "Virizion", "Tornadus", "Thundurus", "Reshiram", "Zekrom", "Landorus", "Kyurem", "Keldeo", "Meloetta", "Genesect", "Chespin", "Quilladin", "Chesnaught", "Fennekin", "Braixen", "Delphox", "Froakie", "Frogadier", "Greninja", "Bunnelby", "Diggersby", "Fletchling", "Fletchinder", "Talonflame", "Scatterbug", "Spewpa", "Vivillon", "Litleo", "Pyroar", "Flabebe", "Floette", "Florges", "Skiddo", "Gogoat", "Pancham", "Pangoro", "Furfrou", "Espurr", "Meowstic", "Honedge", "Doublade", "Aegislash", "Spritzee", "Aromatisse", "Swirlix", "Slurpuff", "Inkay", "Malamar", "Binacle", "Barbaracle", "Skrelp", "Dragalge", "Clauncher", "Clawitzer", "Helioptile", "Heliolisk", "Tyrunt", "Tyrantrum", "Amaura", "Aurorus", "Sylveon", "Hawlucha", "Dedenne", "Carbink", "Goomy", "Sliggoo", "Goodra", "Klefki", "Phantump", "Trevenant", "Pumpkaboo", "Gourgeist", "Bergmite", "Avalugg", "Noibat", "Noivern", "Xerneas", "Yveltal", "Zygarde", "Diancie", "Hoopa", "Volcanion", "Rowlet", "Dartrix", "Decidueye", "Litten", "Torracat", "Incineroar", "Popplio", "Brionne", "Primarina", "Pikipek", "Trumbeak", "Toucannon", "Yungoos", "Gumshoos", "Grubbin", "Charjabug", "Vikavolt", "Crabrawler", "Crabominable", "Oricorio", "Cutiefly", "Ribombee", "Rockruff", "Lycanroc", "Wishiwashi", "Mareanie", "Toxapex", "Mudbray", "Mudsdale", "Dewpider", "Araquanid", "Fomantis", "Lurantis", "Morelull", "Shiinotic", "Salandit", "Salazzle", "Stufful", "Bewear", "Bounsweet", "Steenee", "Tsareena", "Comfey", "Oranguru", "Passimian", "Wimpod", "Golisopod", "Sandygast", "Palossand", "Pyukumuku", "Type: Null", "Silvally", "Minior", "Komala", "Turtonator", "Togedemaru", "Mimikyu", "Bruxish", "Drampa", "Dhelmise", "Jangmo-o", "Hakamo-o", "Kommo-o", "Tapu Koko", "Tapu Lele", "Tapu Bulu", "Tapu Fini", "Cosmog", "Cosmoem", "Solgaleo", "Lunala", "Nihilego", "Buzzwole", "Pheromosa", "Xurkitree", "Celesteela", "Kartana", "Guzzlord", "Necrozma", "Magearna", "Marshadow", "Egg" };
                return data;
            }
        }

        #endregion Species

        #region Moves

        public string[] Moves6
        {
            get
            {
                string[] data = { "[None]", "Pound", "Karate Chop", "Double Slap", "Comet Punch", "Mega Punch", "Pay Day", "Fire Punch", "Ice Punch", "Thunder Punch", "Scratch", "Vice Grip", "Guillotine", "Razor Wind", "Swords Dance", "Cut", "Gust", "Wing Attack", "Whirlwind", "Fly", "Bind", "Slam", "Vine Whip", "Stomp", "Double Kick", "Mega Kick", "Jump Kick", "Rolling Kick", "Sand Attack", "Headbutt", "Horn Attack", "Fury Attack", "Horn Drill", "Tackle", "Body Slam", "Wrap", "Take Down", "Thrash", "Double-Edge", "Tail Whip", "Poison Sting", "Twineedle", "Pin Missile", "Leer", "Bite", "Growl", "Roar", "Sing", "Supersonic", "Sonic Boom", "Disable", "Acid", "Ember", "Flamethrower", "Mist", "Water Gun", "Hydro Pump", "Surf", "Ice Beam", "Blizzard", "Psybeam", "Bubble Beam", "Aurora Beam", "Hyper Beam", "Peck", "Drill Peck", "Submission", "Low Kick", "Counter", "Seismic Toss", "Strength", "Absorb", "Mega Drain", "Leech Seed", "Growth", "Razor Leaf", "Solar Beam", "Poison Powder", "Stun Spore", "Sleep Powder", "Petal Dance", "String Shot", "Dragon Rage", "Fire Spin", "Thunder Shock", "Thunderbolt", "Thunder Wave", "Thunder", "Rock Throw", "Earthquake", "Fissure", "Dig", "Toxic", "Confusion", "Psychic", "Hypnosis", "Meditate", "Agility", "Quick Attack", "Rage", "Teleport", "Night Shade", "Mimic", "Screech", "Double Team", "Recover", "Harden", "Minimize", "Smokescreen", "Confuse Ray", "Withdraw", "Defense Curl", "Barrier", "Light Screen", "Haze", "Reflect", "Focus Energy", "Bide", "Metronome", "Mirror Move", "Self-Destruct", "Egg Bomb", "Lick", "Smog", "Sludge", "Bone Club", "Fire Blast", "Waterfall", "Clamp", "Swift", "Skull Bash", "Spike Cannon", "Constrict", "Amnesia", "Kinesis", "Soft-Boiled", "High Jump Kick", "Glare", "Dream Eater", "Poison Gas", "Barrage", "Leech Life", "Lovely Kiss", "Sky Attack", "Transform", "Bubble", "Dizzy Punch", "Spore", "Flash", "Psywave", "Splash", "Acid Armor", "Crabhammer", "Explosion", "Fury Swipes", "Bonemerang", "Rest", "Rock Slide", "Hyper Fang", "Sharpen", "Conversion", "Tri Attack", "Super Fang", "Slash", "Substitute", "Struggle", "Sketch", "Triple Kick", "Thief", "Spider Web", "Mind Reader", "Nightmare", "Flame Wheel", "Snore", "Curse", "Flail", "Conversion 2", "Aeroblast", "Cotton Spore", "Reversal", "Spite", "Powder Snow", "Protect", "Mach Punch", "Scary Face", "Feint Attack", "Sweet Kiss", "Belly Drum", "Sludge Bomb", "Mud-Slap", "Octazooka", "Spikes", "Zap Cannon", "Foresight", "Destiny Bond", "Perish Song", "Icy Wind", "Detect", "Bone Rush", "Lock-On", "Outrage", "Sandstorm", "Giga Drain", "Endure", "Charm", "Rollout", "False Swipe", "Swagger", "Milk Drink", "Spark", "Fury Cutter", "Steel Wing", "Mean Look", "Attract", "Sleep Talk", "Heal Bell", "Return", "Present", "Frustration", "Safeguard", "Pain Split", "Sacred Fire", "Magnitude", "Dynamic Punch", "Megahorn", "Dragon Breath", "Baton Pass", "Encore", "Pursuit", "Rapid Spin", "Sweet Scent", "Iron Tail", "Metal Claw", "Vital Throw", "Morning Sun", "Synthesis", "Moonlight", "Hidden Power", "Cross Chop", "Twister", "Rain Dance", "Sunny Day", "Crunch", "Mirror Coat", "Psych Up", "Extreme Speed", "Ancient Power", "Shadow Ball", "Future Sight", "Rock Smash", "Whirlpool", "Beat Up", "Fake Out", "Uproar", "Stockpile", "Spit Up", "Swallow", "Heat Wave", "Hail", "Torment", "Flatter", "Will-O-Wisp", "Memento", "Facade", "Focus Punch", "Smelling Salts", "Follow Me", "Nature Power", "Charge", "Taunt", "Helping Hand", "Trick", "Role Play", "Wish", "Assist", "Ingrain", "Superpower", "Magic Coat", "Recycle", "Revenge", "Brick Break", "Yawn", "Knock Off", "Endeavor", "Eruption", "Skill Swap", "Imprison", "Refresh", "Grudge", "Snatch", "Secret Power", "Dive", "Arm Thrust", "Camouflage", "Tail Glow", "Luster Purge", "Mist Ball", "Feather Dance", "Teeter Dance", "Blaze Kick", "Mud Sport", "Ice Ball", "Needle Arm", "Slack Off", "Hyper Voice", "Poison Fang", "Crush Claw", "Blast Burn", "Hydro Cannon", "Meteor Mash", "Astonish", "Weather Ball", "Aromatherapy", "Fake Tears", "Air Cutter", "Overheat", "Odor Sleuth", "Rock Tomb", "Silver Wind", "Metal Sound", "Grass Whistle", "Tickle", "Cosmic Power", "Water Spout", "Signal Beam", "Shadow Punch", "Extrasensory", "Sky Uppercut", "Sand Tomb", "Sheer Cold", "Muddy Water", "Bullet Seed", "Aerial Ace", "Icicle Spear", "Iron Defense", "Block", "Howl", "Dragon Claw", "Frenzy Plant", "Bulk Up", "Bounce", "Mud Shot", "Poison Tail", "Covet", "Volt Tackle", "Magical Leaf", "Water Sport", "Calm Mind", "Leaf Blade", "Dragon Dance", "Rock Blast", "Shock Wave", "Water Pulse", "Doom Desire", "Psycho Boost", "Roost", "Gravity", "Miracle Eye", "Wake-Up Slap", "Hammer Arm", "Gyro Ball", "Healing Wish", "Brine", "Natural Gift", "Feint", "Pluck", "Tailwind", "Acupressure", "Metal Burst", "U-turn", "Close Combat", "Payback", "Assurance", "Embargo", "Fling", "Psycho Shift", "Trump Card", "Heal Block", "Wring Out", "Power Trick", "Gastro Acid", "Lucky Chant", "Me First", "Copycat", "Power Swap", "Guard Swap", "Punishment", "Last Resort", "Worry Seed", "Sucker Punch", "Toxic Spikes", "Heart Swap", "Aqua Ring", "Magnet Rise", "Flare Blitz", "Force Palm", "Aura Sphere", "Rock Polish", "Poison Jab", "Dark Pulse", "Night Slash", "Aqua Tail", "Seed Bomb", "Air Slash", "X-Scissor", "Bug Buzz", "Dragon Pulse", "Dragon Rush", "Power Gem", "Drain Punch", "Vacuum Wave", "Focus Blast", "Energy Ball", "Brave Bird", "Earth Power", "Switcheroo", "Giga Impact", "Nasty Plot", "Bullet Punch", "Avalanche", "Ice Shard", "Shadow Claw", "Thunder Fang", "Ice Fang", "Fire Fang", "Shadow Sneak", "Mud Bomb", "Psycho Cut", "Zen Headbutt", "Mirror Shot", "Flash Cannon", "Rock Climb", "Defog", "Trick Room", "Draco Meteor", "Discharge", "Lava Plume", "Leaf Storm", "Power Whip", "Rock Wrecker", "Cross Poison", "Gunk Shot", "Iron Head", "Magnet Bomb", "Stone Edge", "Captivate", "Stealth Rock", "Grass Knot", "Chatter", "Judgment", "Bug Bite", "Charge Beam", "Wood Hammer", "Aqua Jet", "Attack Order", "Defend Order", "Heal Order", "Head Smash", "Double Hit", "Roar of Time", "Spacial Rend", "Lunar Dance", "Crush Grip", "Magma Storm", "Dark Void", "Seed Flare", "Ominous Wind", "Shadow Force", "Hone Claws", "Wide Guard", "Guard Split", "Power Split", "Wonder Room", "Psyshock", "Venoshock", "Autotomize", "Rage Powder", "Telekinesis", "Magic Room", "Smack Down", "Storm Throw", "Flame Burst", "Sludge Wave", "Quiver Dance", "Heavy Slam", "Synchronoise", "Electro Ball", "Soak", "Flame Charge", "Coil", "Low Sweep", "Acid Spray", "Foul Play", "Simple Beam", "Entrainment", "After You", "Round", "Echoed Voice", "Chip Away", "Clear Smog", "Stored Power", "Quick Guard", "Ally Switch", "Scald", "Shell Smash", "Heal Pulse", "Hex", "Sky Drop", "Shift Gear", "Circle Throw", "Incinerate", "Quash", "Acrobatics", "Reflect Type", "Retaliate", "Final Gambit", "Bestow", "Inferno", "Water Pledge", "Fire Pledge", "Grass Pledge", "Volt Switch", "Struggle Bug", "Bulldoze", "Frost Breath", "Dragon Tail", "Work Up", "Electroweb", "Wild Charge", "Drill Run", "Dual Chop", "Heart Stamp", "Horn Leech", "Sacred Sword", "Razor Shell", "Heat Crash", "Leaf Tornado", "Steamroller", "Cotton Guard", "Night Daze", "Psystrike", "Tail Slap", "Hurricane", "Head Charge", "Gear Grind", "Searing Shot", "Techno Blast", "Relic Song", "Secret Sword", "Glaciate", "Bolt Strike", "Blue Flare", "Fiery Dance", "Freeze Shock", "Ice Burn", "Snarl", "Icicle Crash", "V-create", "Fusion Flare", "Fusion Bolt", "Flying Press", "Mat Block", "Belch", "Rototiller", "Sticky Web", "Fell Stinger", "Phantom Force", "Trick-or-Treat", "Noble Roar", "Ion Deluge", "Parabolic Charge", "Forest’s Curse", "Petal Blizzard", "Freeze-Dry", "Disarming Voice", "Parting Shot", "Topsy-Turvy", "Draining Kiss", "Crafty Shield", "Flower Shield", "Grassy Terrain", "Misty Terrain", "Electrify", "Play Rough", "Fairy Wind", "Moonblast", "Boomburst", "Fairy Lock", "King’s Shield", "Play Nice", "Confide", "Diamond Storm", "Steam Eruption", "Hyperspace Hole", "Water Shuriken", "Mystical Fire", "Spiky Shield", "Aromatic Mist", "Eerie Impulse", "Venom Drench", "Powder", "Geomancy", "Magnetic Flux", "Happy Hour", "Electric Terrain", "Dazzling Gleam", "Celebrate", "Hold Hands", "Baby-Doll Eyes", "Nuzzle", "Hold Back", "Infestation", "Power-Up Punch", "Oblivion Wing", "Thousand Arrows", "Thousand Waves", "Land’s Wrath", "Light of Ruin", "Origin Pulse", "Precipice Blades", "Dragon Ascent", "Hyperspace Fury" };
                return data;
            }
        }

        public string[] Moves7
        {
            get
            {
                string[] data = { "[None]", "Pound", "Karate Chop", "Double Slap", "Comet Punch", "Mega Punch", "Pay Day", "Fire Punch", "Ice Punch", "Thunder Punch", "Scratch", "Vice Grip", "Guillotine", "Razor Wind", "Swords Dance", "Cut", "Gust", "Wing Attack", "Whirlwind", "Fly", "Bind", "Slam", "Vine Whip", "Stomp", "Double Kick", "Mega Kick", "Jump Kick", "Rolling Kick", "Sand Attack", "Headbutt", "Horn Attack", "Fury Attack", "Horn Drill", "Tackle", "Body Slam", "Wrap", "Take Down", "Thrash", "Double-Edge", "Tail Whip", "Poison Sting", "Twineedle", "Pin Missile", "Leer", "Bite", "Growl", "Roar", "Sing", "Supersonic", "Sonic Boom", "Disable", "Acid", "Ember", "Flamethrower", "Mist", "Water Gun", "Hydro Pump", "Surf", "Ice Beam", "Blizzard", "Psybeam", "Bubble Beam", "Aurora Beam", "Hyper Beam", "Peck", "Drill Peck", "Submission", "Low Kick", "Counter", "Seismic Toss", "Strength", "Absorb", "Mega Drain", "Leech Seed", "Growth", "Razor Leaf", "Solar Beam", "Poison Powder", "Stun Spore", "Sleep Powder", "Petal Dance", "String Shot", "Dragon Rage", "Fire Spin", "Thunder Shock", "Thunderbolt", "Thunder Wave", "Thunder", "Rock Throw", "Earthquake", "Fissure", "Dig", "Toxic", "Confusion", "Psychic", "Hypnosis", "Meditate", "Agility", "Quick Attack", "Rage", "Teleport", "Night Shade", "Mimic", "Screech", "Double Team", "Recover", "Harden", "Minimize", "Smokescreen", "Confuse Ray", "Withdraw", "Defense Curl", "Barrier", "Light Screen", "Haze", "Reflect", "Focus Energy", "Bide", "Metronome", "Mirror Move", "Self-Destruct", "Egg Bomb", "Lick", "Smog", "Sludge", "Bone Club", "Fire Blast", "Waterfall", "Clamp", "Swift", "Skull Bash", "Spike Cannon", "Constrict", "Amnesia", "Kinesis", "Soft-Boiled", "High Jump Kick", "Glare", "Dream Eater", "Poison Gas", "Barrage", "Leech Life", "Lovely Kiss", "Sky Attack", "Transform", "Bubble", "Dizzy Punch", "Spore", "Flash", "Psywave", "Splash", "Acid Armor", "Crabhammer", "Explosion", "Fury Swipes", "Bonemerang", "Rest", "Rock Slide", "Hyper Fang", "Sharpen", "Conversion", "Tri Attack", "Super Fang", "Slash", "Substitute", "Struggle", "Sketch", "Triple Kick", "Thief", "Spider Web", "Mind Reader", "Nightmare", "Flame Wheel", "Snore", "Curse", "Flail", "Conversion 2", "Aeroblast", "Cotton Spore", "Reversal", "Spite", "Powder Snow", "Protect", "Mach Punch", "Scary Face", "Feint Attack", "Sweet Kiss", "Belly Drum", "Sludge Bomb", "Mud-Slap", "Octazooka", "Spikes", "Zap Cannon", "Foresight", "Destiny Bond", "Perish Song", "Icy Wind", "Detect", "Bone Rush", "Lock-On", "Outrage", "Sandstorm", "Giga Drain", "Endure", "Charm", "Rollout", "False Swipe", "Swagger", "Milk Drink", "Spark", "Fury Cutter", "Steel Wing", "Mean Look", "Attract", "Sleep Talk", "Heal Bell", "Return", "Present", "Frustration", "Safeguard", "Pain Split", "Sacred Fire", "Magnitude", "Dynamic Punch", "Megahorn", "Dragon Breath", "Baton Pass", "Encore", "Pursuit", "Rapid Spin", "Sweet Scent", "Iron Tail", "Metal Claw", "Vital Throw", "Morning Sun", "Synthesis", "Moonlight", "Hidden Power", "Cross Chop", "Twister", "Rain Dance", "Sunny Day", "Crunch", "Mirror Coat", "Psych Up", "Extreme Speed", "Ancient Power", "Shadow Ball", "Future Sight", "Rock Smash", "Whirlpool", "Beat Up", "Fake Out", "Uproar", "Stockpile", "Spit Up", "Swallow", "Heat Wave", "Hail", "Torment", "Flatter", "Will-O-Wisp", "Memento", "Facade", "Focus Punch", "Smelling Salts", "Follow Me", "Nature Power", "Charge", "Taunt", "Helping Hand", "Trick", "Role Play", "Wish", "Assist", "Ingrain", "Superpower", "Magic Coat", "Recycle", "Revenge", "Brick Break", "Yawn", "Knock Off", "Endeavor", "Eruption", "Skill Swap", "Imprison", "Refresh", "Grudge", "Snatch", "Secret Power", "Dive", "Arm Thrust", "Camouflage", "Tail Glow", "Luster Purge", "Mist Ball", "Feather Dance", "Teeter Dance", "Blaze Kick", "Mud Sport", "Ice Ball", "Needle Arm", "Slack Off", "Hyper Voice", "Poison Fang", "Crush Claw", "Blast Burn", "Hydro Cannon", "Meteor Mash", "Astonish", "Weather Ball", "Aromatherapy", "Fake Tears", "Air Cutter", "Overheat", "Odor Sleuth", "Rock Tomb", "Silver Wind", "Metal Sound", "Grass Whistle", "Tickle", "Cosmic Power", "Water Spout", "Signal Beam", "Shadow Punch", "Extrasensory", "Sky Uppercut", "Sand Tomb", "Sheer Cold", "Muddy Water", "Bullet Seed", "Aerial Ace", "Icicle Spear", "Iron Defense", "Block", "Howl", "Dragon Claw", "Frenzy Plant", "Bulk Up", "Bounce", "Mud Shot", "Poison Tail", "Covet", "Volt Tackle", "Magical Leaf", "Water Sport", "Calm Mind", "Leaf Blade", "Dragon Dance", "Rock Blast", "Shock Wave", "Water Pulse", "Doom Desire", "Psycho Boost", "Roost", "Gravity", "Miracle Eye", "Wake-Up Slap", "Hammer Arm", "Gyro Ball", "Healing Wish", "Brine", "Natural Gift", "Feint", "Pluck", "Tailwind", "Acupressure", "Metal Burst", "U-turn", "Close Combat", "Payback", "Assurance", "Embargo", "Fling", "Psycho Shift", "Trump Card", "Heal Block", "Wring Out", "Power Trick", "Gastro Acid", "Lucky Chant", "Me First", "Copycat", "Power Swap", "Guard Swap", "Punishment", "Last Resort", "Worry Seed", "Sucker Punch", "Toxic Spikes", "Heart Swap", "Aqua Ring", "Magnet Rise", "Flare Blitz", "Force Palm", "Aura Sphere", "Rock Polish", "Poison Jab", "Dark Pulse", "Night Slash", "Aqua Tail", "Seed Bomb", "Air Slash", "X-Scissor", "Bug Buzz", "Dragon Pulse", "Dragon Rush", "Power Gem", "Drain Punch", "Vacuum Wave", "Focus Blast", "Energy Ball", "Brave Bird", "Earth Power", "Switcheroo", "Giga Impact", "Nasty Plot", "Bullet Punch", "Avalanche", "Ice Shard", "Shadow Claw", "Thunder Fang", "Ice Fang", "Fire Fang", "Shadow Sneak", "Mud Bomb", "Psycho Cut", "Zen Headbutt", "Mirror Shot", "Flash Cannon", "Rock Climb", "Defog", "Trick Room", "Draco Meteor", "Discharge", "Lava Plume", "Leaf Storm", "Power Whip", "Rock Wrecker", "Cross Poison", "Gunk Shot", "Iron Head", "Magnet Bomb", "Stone Edge", "Captivate", "Stealth Rock", "Grass Knot", "Chatter", "Judgment", "Bug Bite", "Charge Beam", "Wood Hammer", "Aqua Jet", "Attack Order", "Defend Order", "Heal Order", "Head Smash", "Double Hit", "Roar of Time", "Spacial Rend", "Lunar Dance", "Crush Grip", "Magma Storm", "Dark Void", "Seed Flare", "Ominous Wind", "Shadow Force", "Hone Claws", "Wide Guard", "Guard Split", "Power Split", "Wonder Room", "Psyshock", "Venoshock", "Autotomize", "Rage Powder", "Telekinesis", "Magic Room", "Smack Down", "Storm Throw", "Flame Burst", "Sludge Wave", "Quiver Dance", "Heavy Slam", "Synchronoise", "Electro Ball", "Soak", "Flame Charge", "Coil", "Low Sweep", "Acid Spray", "Foul Play", "Simple Beam", "Entrainment", "After You", "Round", "Echoed Voice", "Chip Away", "Clear Smog", "Stored Power", "Quick Guard", "Ally Switch", "Scald", "Shell Smash", "Heal Pulse", "Hex", "Sky Drop", "Shift Gear", "Circle Throw", "Incinerate", "Quash", "Acrobatics", "Reflect Type", "Retaliate", "Final Gambit", "Bestow", "Inferno", "Water Pledge", "Fire Pledge", "Grass Pledge", "Volt Switch", "Struggle Bug", "Bulldoze", "Frost Breath", "Dragon Tail", "Work Up", "Electroweb", "Wild Charge", "Drill Run", "Dual Chop", "Heart Stamp", "Horn Leech", "Sacred Sword", "Razor Shell", "Heat Crash", "Leaf Tornado", "Steamroller", "Cotton Guard", "Night Daze", "Psystrike", "Tail Slap", "Hurricane", "Head Charge", "Gear Grind", "Searing Shot", "Techno Blast", "Relic Song", "Secret Sword", "Glaciate", "Bolt Strike", "Blue Flare", "Fiery Dance", "Freeze Shock", "Ice Burn", "Snarl", "Icicle Crash", "V-create", "Fusion Flare", "Fusion Bolt", "Flying Press", "Mat Block", "Belch", "Rototiller", "Sticky Web", "Fell Stinger", "Phantom Force", "Trick-or-Treat", "Noble Roar", "Ion Deluge", "Parabolic Charge", "Forest’s Curse", "Petal Blizzard", "Freeze-Dry", "Disarming Voice", "Parting Shot", "Topsy-Turvy", "Draining Kiss", "Crafty Shield", "Flower Shield", "Grassy Terrain", "Misty Terrain", "Electrify", "Play Rough", "Fairy Wind", "Moonblast", "Boomburst", "Fairy Lock", "King’s Shield", "Play Nice", "Confide", "Diamond Storm", "Steam Eruption", "Hyperspace Hole", "Water Shuriken", "Mystical Fire", "Spiky Shield", "Aromatic Mist", "Eerie Impulse", "Venom Drench", "Powder", "Geomancy", "Magnetic Flux", "Happy Hour", "Electric Terrain", "Dazzling Gleam", "Celebrate", "Hold Hands", "Baby-Doll Eyes", "Nuzzle", "Hold Back", "Infestation", "Power-Up Punch", "Oblivion Wing", "Thousand Arrows", "Thousand Waves", "Land’s Wrath", "Light of Ruin", "Origin Pulse", "Precipice Blades", "Dragon Ascent", "Hyperspace Fury", "Breakneck Blitz", "Breakneck Blitz", "All-Out Pummeling", "All-Out Pummeling", "Supersonic Skystrike", "Supersonic Skystrike", "Acid Downpour", "Acid Downpour", "Tectonic Rage", "Tectonic Rage", "Continental Crush", "Continental Crush", "Savage Spin-Out", "Savage Spin-Out", "Never-Ending Nightmare", "Never-Ending Nightmare", "Corkscrew Crash", "Corkscrew Crash", "Inferno Overdrive", "Inferno Overdrive", "Hydro Vortex", "Hydro Vortex", "Bloom Doom", "Bloom Doom", "Gigavolt Havoc", "Gigavolt Havoc", "Shattered Psyche", "Shattered Psyche", "Subzero Slammer", "Subzero Slammer", "Devastating Drake", "Devastating Drake", "Black Hole Eclipse", "Black Hole Eclipse", "Twinkle Tackle", "Twinkle Tackle", "Catastropika", "Shore Up", "First Impression", "Baneful Bunker", "Spirit Shackle", "Darkest Lariat", "Sparkling Aria", "Ice Hammer", "Floral Healing", "High Horsepower", "Strength Sap", "Solar Blade", "Leafage", "Spotlight", "Toxic Thread", "Laser Focus", "Gear Up", "Throat Chop", "Pollen Puff", "Anchor Shot", "Psychic Terrain", "Lunge", "Fire Lash", "Power Trip", "Burn Up", "Speed Swap", "Smart Strike", "Purify", "Revelation Dance", "Core Enforcer", "Trop Kick", "Instruct", "Beak Blast", "Clanging Scales", "Dragon Hammer", "Brutal Swing", "Aurora Veil", "Sinister Arrow Raid", "Malicious Moonsault", "Oceanic Operetta", "Guardian of Alola", "Soul-Stealing 7-Star Strike", "Stoked Sparksurfer", "Pulverizing Pancake", "Extreme Evoboost", "Genesis Supernova", "Shell Trap", "Fleur Cannon", "Psychic Fangs", "Stomping Tantrum", "Shadow Bone", "Accelerock", "Liquidation", "Prismatic Laser", "Spectral Thief", "Sunsteel Strike", "Moongeist Beam", "Tearful Look", "Zing Zap", "Nature’s Madness", "Multi-Attack", "10,000,000 Volt Thunderbolt" };
                return data;
            }
        }

        #endregion Moves

        #region Languages

        public string[] Lang6
        {
            get
            {
                string[] data = { "JPN", "ENG", "FRE", "ITA", "GER", "SPA", "KOR" };
                return data;
            }
        }

        public string[] Lang7
        {
            get
            {
                string[] data = { "JPN", "ENG", "FRE", "ITA", "GER", "SPA", "KOR", "CHS", "CHT" };
                return data;
            }
        }

        #endregion Languages

        #region Hidden Power

        public string[] HPName
        {
            get
            {
                string[] data = { "Fighting", "Flying", "Poison", "Ground", "Rock", "Bug", "Ghost", "Steel", "Fire", "Water", "Grass", "Electric", "Psychic", "Ice", "Dragon", "Dark", };
                return data;
            }
        }

        public Color[] HPColor
        {
            get
            {
                Color[] data = { Color.FromArgb(192, 48, 40), Color.FromArgb(168, 144, 240), Color.FromArgb(160, 64, 160), Color.FromArgb(224, 192, 104), Color.FromArgb(184, 160, 56), Color.FromArgb(168, 184, 32), Color.FromArgb(112, 88, 152), Color.FromArgb(184, 184, 208), Color.FromArgb(240, 128, 48), Color.FromArgb(104, 144, 240), Color.FromArgb(120, 200, 80), Color.FromArgb(248, 208, 48), Color.FromArgb(248, 88, 136), Color.FromArgb(152, 216, 216), Color.FromArgb(112, 56, 248), Color.FromArgb(112, 88, 72) };
                return data;
            }
        }

        #endregion Hidden Power

        #region Buttons

        public uint nokey = 0xFFF;
        public uint keyA = 0xFFE;
        public uint keyB = 0xFFD;
        public uint keyX = 0xBFF;
        public uint keyY = 0x7FF;
        public uint keyR = 0xEFF;
        public uint keyL = 0xDFF;
        public uint keySTART = 0xFF7;
        public uint keySELECT = 0xFFB;
        public uint DpadUP = 0xFBF;
        public uint DpadDOWN = 0xF7F;
        public uint DpadLEFT = 0xFDF;
        public uint DpadRIGHT = 0xFEF;
        public uint runUP = 0xFBD;
        public uint runDOWN = 0xF7D;
        public uint runLEFT = 0xFDD;
        public uint runRIGHT = 0xFED;
        public uint softReset = 0xCF7;
        public uint notouch = 0x02000000;

        #endregion Buttons

        #region Box Position

        // Gen 6
        public uint[] pokeposX = { 30, 60, 90, 120, 150, 180, 30, 60, 90, 120, 150, 180, 30, 60, 90, 120, 150, 180, 30, 60, 90, 120, 150, 180, 30, 60, 90, 120, 150, 180 };
        public uint[] pokeposY = { 60, 60, 60, 60, 60, 60, 90, 90, 90, 90, 90, 90, 120, 120, 120, 120, 120, 120, 150, 150, 150, 150, 150, 150, 180, 180, 180, 180, 180, 180 };
        public uint[] boxposX = { 20, 60, 100, 140, 180, 220, 260, 300, 20, 60, 100, 140, 180, 220, 260, 300, 20, 60, 100, 140, 180, 220, 260, 300, 20, 60, 100, 140, 180, 220, 260 };
        public uint[] boxposY = { 24, 24, 24, 24, 24, 24, 24, 24, 72, 72, 72, 72, 72, 72, 72, 72, 120, 120, 120, 120, 120, 120, 120, 120, 168, 168, 168, 168, 168, 168, 168 };

        // Gen 7
        public uint[] pokeposX7 = { 30, 60, 90, 120, 150, 180, 30, 60, 90, 120, 150, 180, 30, 60, 90, 120, 150, 180, 30, 60, 90, 120, 150, 180, 30, 60, 90, 120, 150, 180 };
        public uint[] pokeposY7 = { 70, 70, 70, 70, 70, 70, 100, 100, 100, 100, 100, 100, 130, 130, 130, 130, 130, 130, 160, 160, 160, 160, 160, 160, 190, 190, 190, 190, 190, 190 };
        public uint[] boxposX7 = { 35, 70, 105, 140, 175, 210, 245, 280, 35, 70, 105, 140, 175, 210, 245, 280, 35, 70, 105, 140, 175, 210, 245, 280, 35, 70, 105, 140, 175, 210, 245, 280 };
        public uint[] boxposY7 = { 40, 40, 40, 40, 40, 40, 40, 40, 80, 80, 80, 80, 80, 80, 80, 80, 120, 120, 120, 120, 120, 120, 120, 120, 160, 160, 160, 160, 160, 160, 160, 160 };

        #endregion Box Position
    }

}