using System.Collections.Generic;
using System.Linq;
using MyFace.Models.Database;
using MyFace.Services;

namespace MyFace.Data
{
    public static class SampleUsers
    {
        public static int NumberOfUsers = 100;
        
        private static IList<IList<string>> _data = new List<IList<string>>
        {
            new List<string> { "Kania", "Placido", "kplacido0", "kplacido0@qq.com", "password01" },
            new List<string> { "Scotty", "Gariff", "sgariff1", "sgariff1@biblegateway.com", "password11" },
            new List<string> { "Colly", "Burgiss", "cburgiss2", "cburgiss2@amazon.co.uk", "password31" },
            new List<string> { "Barnie", "Percival", "bpercival3", "bpercival3@cmu.edu", "password051" },
            new List<string> { "Brandon", "Narraway", "bnarraway4", "bnarraway4@trellian.com", "passeword01" },
            new List<string> { "Carlos", "Sakins", "csakins5", "csakins5@spiegel.de", "password201" },
            new List<string> { "Zeke", "Barkworth", "zbarkworth6", "zbarkworth6@symantec.com", "phassword01" },
            new List<string> { "Henrietta", "Verick", "hverick7", "hverick7@adobe.com", "passworfd01" },
            new List<string> { "Maxine", "Lovett", "mlovett8", "mlovett8@mac.com", "password021" },
            new List<string> { "Adorne", "Smyth", "asmyth9", "asmyth9@nyu.edu", "password01!" },
            new List<string> { "Roslyn", "O' Scallan", "roscallana", "roscallana@marriott.com", "p6assword01" },
            new List<string> { "Kalindi", "Bevington", "kbevingtonb", "kbevingtonb@wired.com", "pas87sword01" },
            new List<string> { "Silva", "Cow", "scowc", "scowc@yellowbook.com", "password011" },
            new List<string> { "Gnni", "Northage", "gnorthaged", "gnorthaged@lulu.com", "p645assword01" },
            new List<string> { "Jobi", "Balsom", "jbalsome", "jbalsome@ox.ac.uk", "password041" },
            new List<string> { "Laurice", "Galgey", "lgalgeyf", "lgalgeyf@usa.gov", "passwor1d01" },
            new List<string> { "Orsola", "Laurant", "olaurantg", "olaurantg@reverbnation.com", "pajhssword01" },
            new List<string> { "Dante", "Mabley", "dmableyh", "dmableyh@scientificamerican.com", "pasdfsword01" },
            new List<string> { "Shantee", "Guillond", "sguillondi", "sguillondi@gravatar.com", "passwordgd01" },
            new List<string> { "Mendy", "Djuricic", "mdjuricicj", "mdjuricicj@tuttocitta.it", "password0!1" },
            new List<string> { "Ralph", "Adamovicz", "radamoviczk", "radamoviczk@salon.com", "password0?1" },
            new List<string> { "Zsa zsa", "Goodacre", "zgoodacrel", "zgoodacrel@histats.com", "passworbad01" },
            new List<string> { "Fleurette", "Blow", "fblowm", "fblowm@who.int", "passwor42d01" },
            new List<string> { "Zelda", "Pritchett", "zpritchettn", "zpritchettn@wordpress.org", "pas43sword01" },
            new List<string> { "Kaitlyn", "Filshin", "kfilshino", "kfilshino@so-net.ne.jp", "password061" },
            new List<string> { "Aube", "Goneau", "agoneaup", "agoneaup@barnesandnoble.com", "password601" },
            new List<string> { "Natala", "Mackrill", "nmackrillq", "nmackrillq@google.es", "passwordhg01" },
            new List<string> { "Ev", "Wadly", "ewadlyr", "ewadlyr@adobe.com", "password0s1" },
            new List<string> { "Aurora", "Feedham", "afeedhams", "afeedhams@house.gov", "phassword01" },
            new List<string> { "Farly", "Chestney", "fchestneyt", "fchestneyt@usda.gov", "pa3ssword01" },
            new List<string> { "Chico", "Guilloux", "cguillouxu", "cguillouxu@senate.gov", "pajssword01" },
            new List<string> { "Julianna", "Huckstepp", "jhucksteppv", "jhucksteppv@ycombinator.com", "passwjord01" },
            new List<string> { "Bev", "Sancto", "bsanctow", "bsanctow@spiegel.de", "password0d1" },
            new List<string> { "Shara", "Jeeves", "sjeevesx", "sjeevesx@behance.net", "passwor5d01" },
            new List<string> { "Legra", "Jereatt", "ljereatty", "ljereatty@prnewswire.com", "payssword01" },
            new List<string> { "Katey", "Ternouth", "kternouthz", "kternouthz@webmd.com", "passw26ord01" },
            new List<string> { "Val", "McMenamin", "vmcmenamin10", "vmcmenamin10@noaa.gov", "passw1ord01" },
            new List<string> { "Shannan", "Greenhalf", "sgreenhalf11", "sgreenhalf11@gravatar.com", "pahhssword01" },
            new List<string> { "Sterling", "Fellgate", "sfellgate12", "sfellgate12@surveymonkey.com", "pasdsword01" },
            new List<string> { "Brina", "Dickens", "bdickens13", "bdickens13@zimbio.com", "password0g1" },
            new List<string> { "Boniface", "McKaile", "bmckaile14", "bmckaile14@jalbum.net", "passwordd01" },
            new List<string> { "Vincenty", "Aishford", "vaishford15", "vaishford15@wordpress.org", "passsword01" },
            new List<string> { "Kathye", "Gauford", "kgauford16", "kgauford16@xrea.com", "passwo2rd01" },
            new List<string> { "Chico", "Seelbach", "cseelbach17", "cseelbach17@over-blog.com", "payssword01" },
            new List<string> { "Enoch", "Winsper", "ewinsper18", "ewinsper18@devhub.com", "password0f1" },
            new List<string> { "Brandie", "Welds", "bwelds19", "bwelds19@chicagotribune.com", "passwofrd01" },
            new List<string> { "Bethanne", "Kerin", "bkerin1a", "bkerin1a@acquirethisname.com", "passwford01" },
            new List<string> { "Margo", "Tompkins", "mtompkins1b", "mtompkins1b@mayoclinic.com", "passfword01" },
            new List<string> { "Allie", "Clever", "aclever1c", "aclever1c@slideshare.net", "passford01" },
            new List<string> { "North", "Denny", "ndenny1d", "ndenny1d@simplemachines.org", "pasdword01" },
            new List<string> { "Ted", "Scorah", "tscorah1e", "tscorah1e@devhub.com", "passwor£d01" },
            new List<string> { "Leone", "McGow", "lmcgow1f", "lmcgow1f@unblog.fr", "password01£" },
            new List<string> { "Abbie", "Jannasch", "ajannasch1g", "ajannasch1g@sakura.ne.jp", "p£assword01" },
            new List<string> { "Marika", "Dommett", "mdommett1h", "mdommett1h@infoseek.co.jp", "pa£s£sword01" },
            new List<string> { "Edith", "Norcop", "enorcop1i", "enorcop1i@behance.net", "password0££1" },
            new List<string> { "Ernest", "Baline", "ebaline1j", "ebaline1j@amazon.co.uk", "passwor!!d01" },
            new List<string> { "Rowen", "Dorcey", "rdorcey1k", "rdorcey1k@gravatar.com", "password0!!1" },
            new List<string> { "Pasquale", "Surplice", "psurplice1l", "psurplice1l@paypal.com", "passtword01" },
            new List<string> { "Tim", "Dyott", "tdyott1m", "tdyott1m@yellowbook.com", "password01g" },
            new List<string> { "Tedd", "Connachan", "tconnachan1n", "tconnachan1n@so-net.ne.jp", "pgassword01" },
            new List<string> { "Jacquetta", "McClelland", "jmcclelland1o", "jmcclelland1o@nifty.com", "pgassword01" },
            new List<string> { "Nelli", "Maund", "nmaund1p", "nmaund1p@myspace.com", "passwford01" },
            new List<string> { "Morie", "Anselmi", "manselmi1q", "manselmi1q@nytimes.com", "pafssword01" },
            new List<string> { "Gabie", "Antoniazzi", "gantoniazzi1r", "gantoniazzi1r@dailymail.co.uk", "passwordf01" },
            new List<string> { "Menard", "Engelbrecht", "mengelbrecht1s", "mengelbrecht1s@over-blog.com", "passwford01" },
            new List<string> { "Mike", "Tommasetti", "mtommasetti1t", "mtommasetti1t@bluehost.com", "password0f1" },
            new List<string> { "Eldin", "Fredy", "efredy1u", "efredy1u@mozilla.com", "passworfd01" },
            new List<string> { "Pris", "McCowen", "pmccowen1v", "pmccowen1v@jalbum.net", "password01" },
            new List<string> { "Joey", "Dossettor", "jdossettor1w", "jdossettor1w@webnode.com", "password01" },
            new List<string> { "Daisey", "Ogdahl", "dogdahl1x", "dogdahl1x@nyu.edu", "password01" },
            new List<string> { "Melanie", "Searle", "msearle1y", "msearle1y@loc.gov", "password01" },
            new List<string> { "Beatrix", "MacLise", "bmaclise1z", "bmaclise1z@hugedomains.com", "password01" },
            new List<string> { "Missy", "Hillitt", "mhillitt20", "mhillitt20@multiply.com", "password01" },
            new List<string> { "Belinda", "Tumielli", "btumielli21", "btumielli21@php.net", "password01" },
            new List<string> { "Raynor", "Dupey", "rdupey22", "rdupey22@fc2.com", "password01" },
            new List<string> { "Inigo", "Heineke", "iheineke23", "iheineke23@ihg.com", "password01" },
            new List<string> { "Ilaire", "Angric", "iangric24", "iangric24@apache.org", "password01" },
            new List<string> { "Estel", "Steljes", "esteljes25", "esteljes25@livejournal.com", "password01" },
            new List<string> { "Lyell", "Ashard", "lashard26", "lashard26@umn.edu", "password01" },
            new List<string> { "Darren", "Devons", "ddevons27", "ddevons27@economist.com", "password01" },
            new List<string> { "Warden", "Undrell", "wundrell28", "wundrell28@mozilla.org", "password01" },
            new List<string> { "Iris", "Langworthy", "ilangworthy29", "ilangworthy29@timesonline.co.uk", "password01" },
            new List<string> { "Marten", "Minards", "mminards2a", "mminards2a@statcounter.com", "password01" },
            new List<string> { "Kerry", "Bennion", "kbennion2b", "kbennion2b@spotify.com", "password01" },
            new List<string> { "Olivette", "Norridge", "onorridge2c", "onorridge2c@cpanel.net", "password01" },
            new List<string> { "Rosalinde", "Traske", "rtraske2d", "rtraske2d@bbc.co.uk", "password01" },
            new List<string> { "Gaultiero", "McCard", "gmccard2e", "gmccard2e@utexas.edu", "password01" },
            new List<string> { "Zonnya", "Capstaff", "zcapstaff2f", "zcapstaff2f@theatlantic.com", "password01" },
            new List<string> { "Ingelbert", "Sleford", "isleford2g", "isleford2g@qq.com", "password01" },
            new List<string> { "Nicol", "Nary", "nnary2h", "nnary2h@google.com.hk", "password01" },
            new List<string> { "Jasun", "Lukianov", "jlukianov2i", "jlukianov2i@blogs.com", "password01" },
            new List<string> { "Alison", "Durkin", "adurkin2j", "adurkin2j@sitemeter.com", "password01" },
            new List<string> { "Claudius", "Coronas", "ccoronas2k", "ccoronas2k@tamu.edu", "password01" },
            new List<string> { "Jakie", "Keener", "jkeener2l", "jkeener2l@princeton.edu", "password01" },
            new List<string> { "Gilbertine", "Wynett", "gwynett2m", "gwynett2m@epa.gov", "password01" },
            new List<string> { "Syd", "Cordelle", "scordelle2n", "scordelle2n@blogger.com", "password01" },
            new List<string> { "Stafford", "Deport", "sdeport2o", "sdeport2o@wix.com", "password01" },
            new List<string> { "Zacharie", "Perchard", "zperchard2p", "zperchard2p@qq.com", "password01" },
            new List<string> { "Jane", "Iceton", "jiceton2q", "jiceton2q@lulu.com", "password01" },
            new List<string> { "Marjy", "Beadell", "mbeadell2r", "mbeadell2r@delicious.com", "password01" }
        };
        
        public static IEnumerable<User> GetUsers()
        {
            return Enumerable.Range(0, NumberOfUsers).Select(CreateRandomUser);
        }

        private static User CreateRandomUser(int index)
        {
            byte[] newSalt = HasherNSalter.MakeSalt();
            return new User
            {
                FirstName = _data[index][0],
                LastName = _data[index][1],
                Username = _data[index][2],
                Email = _data[index][3],
                ProfileImageUrl = ImageGenerator.GetProfileImage(_data[index][2]),
                CoverImageUrl = ImageGenerator.GetCoverImage(index),
                PasswordSalt = newSalt,
                HashedPassword = HasherNSalter.DoHash(_data[index][4], newSalt),
            };
        }
    }
}