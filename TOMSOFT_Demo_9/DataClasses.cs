namespace Data
{
    //obračun po vrsti plaćanja
    public class ObracunPlacanjaRoot
    {
        public Result[] result { get; set; }

        public class Result
        {
            public Obracun_Placanja[] obracun_placanja { get; set; }

            public class Obracun_Placanja
            {
                public string vrste_placanja_uid { get; set; }
                public string naziv { get; set; }
                public float iznos { get; set; }
            }
        }
    }


    public class ArtikliRoot
    {
        public Result[] result { get; set; }

        public class Result
        {
            public Artikli[] artikli { get; set; }

            public class Artikli
            {
                public string id { get; set; }
                public string sid { get; set; }
                public string artikl_uid { get; set; }
                public string artikl { get; set; }
                public string naziv { get; set; }
                public string jm { get; set; }
                public string vpc { get; set; }
                public string mpc { get; set; }
                public string enabled { get; set; }
                public string usluga { get; set; }
                public string materijal { get; set; }
                public string eol { get; set; }
                public string webshop { get; set; }
                public string multipack { get; set; }
                public string trgovacka_roba { get; set; }
                public string bundle { get; set; }
                public Atributi[] atributi { get; set; }

                public class Atributi
                {
                    public string atribut { get; set; }
                    public string atribut_uid { get; set; }
                    public string b2b_atribut { get; set; }
                    public string naziv { get; set; }
                    public string atribut_tip { get; set; }
                    public string aktivan { get; set; }
                    public int redoslijed { get; set; }
                    public string vidljiv { get; set; }
                    public string vrijednost { get; set; }
                }

            }
        }
    }

    //obračun po artiklima
    public class ObracunArtikliRoot
    {
        public Result[] result { get; set; }
        public class Result
        {
            public Obracun_Artikli[] obracun_artikli { get; set; }

            public class Obracun_Artikli
            {
                public string artikl_uid { get; set; }
                public string naziv_artikla { get; set; }
                public int kolicina { get; set; }
                public float iznos { get; set; }
                public string usluga { get; set; }
            }
        }

    }

}