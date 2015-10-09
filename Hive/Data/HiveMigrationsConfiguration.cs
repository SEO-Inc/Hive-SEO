using Hive.Data.enums;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;

namespace Hive.Data
{
    class HiveMigrationsConfiguration : DbMigrationsConfiguration<HiveContext>
    {
        public HiveMigrationsConfiguration()
        {
            //if remote db field
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }
        
        protected override void Seed(HiveContext context)
        {
            base.Seed(context);

#if DEBUG
            if (context.Domains.Count() == 0)
            {
                var domain = new Domain()
                {
                    Name = "www.seoinc.com",
                    Created = DateTime.Now,

                };
                context.Domains.Add(domain);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }
            }

            if (context.Accounts.Count() == 0)
            {
                var account = new Account()
                {
                    CompanyName="SEO Inc",
                    DomainId=1,
                    Created=DateTime.Now,
                    AccountType = AccountType.Agency

                };
               context.Accounts.Add(account);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }
            }

            if (context.ProjectStatuses.Count() == 0)
            {
                var projectstatus = new ProjectStatus()
                {
                    Status = "New",
                    Order = 1
                };
                context.ProjectStatuses.Add(projectstatus);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }
            }
            if (context.Countries.Count() == 0)
            {
                var countries = new List<Country>{
                    new Country{Name="AFGHANISTAN",Code="AF"},
                    new Country{Name="ALAND ISLANDS",Code="AX"},
                    new Country{Name="ALBANIA",Code="AL"},
                    new Country{Name="ALGERIA",Code="DZ"},
                    new Country{Name="AMERICAN SAMOA",Code="AS"},
                    new Country{Name="ANDORRA",Code="AD"},
                    new Country{Name="ANGOLA",Code="AO"},
                    new Country{Name="ANGUILLA",Code="AI"},
                    new Country{Name="ANTARCTICA",Code="AQ"},
                    new Country{Name="ANTIGUA AND BARBUDA",Code="AG"},
                    new Country{Name="ARGENTINA",Code="AR"},
                    new Country{Name="ARMENIA",Code="AM"},
                    new Country{Name="ARUBA",Code="AW"},
                    new Country{Name="AUSTRALIA",Code="AU"},
                    new Country{Name="AUSTRIA",Code="AT"},
                    new Country{Name="AZERBAIJAN",Code="AZ"},
                    new Country{Name="BAHAMAS",Code="BS"},
                    new Country{Name="BAHRAIN",Code="BH"},
                    new Country{Name="BANGLADESH",Code="BD"},
                    new Country{Name="BARBADOS",Code="BB"},
                    new Country{Name="BELARUS",Code="BY"},
                    new Country{Name="BELGIUM",Code="BE"},
                    new Country{Name="BELIZE",Code="BZ"},
                    new Country{Name="BENIN",Code="BJ"},
                    new Country{Name="BERMUDA",Code="BM"},
                    new Country{Name="BHUTAN",Code="BT"},
                    new Country{Name="BOLIVIA, PLURINATIONAL STATE OF",Code="BO"},
                    new Country{Name="BONAIRE, SINT EUSTATIUS AND SABA",Code="BQ"},
                    new Country{Name="BOSNIA AND HERZEGOVINA",Code="BA"},
                    new Country{Name="BOTSWANA",Code="BW"},
                    new Country{Name="BOUVET ISLAND",Code="BV"},
                    new Country{Name="BRAZIL",Code="BR"},
                    new Country{Name="BRITISH INDIAN OCEAN TERRITORY",Code="IO"},
                    new Country{Name="BRUNEI DARUSSALAM",Code="BN"},
                    new Country{Name="BULGARIA",Code="BG"},
                    new Country{Name="BURKINA FASO",Code="BF"},
                    new Country{Name="BURUNDI",Code="BI"},
                    new Country{Name="CAMBODIA",Code="KH"},
                    new Country{Name="CAMEROON",Code="CM"},
                    new Country{Name="CANADA",Code="CA"},
                    new Country{Name="CAPE VERDE",Code="CV"},
                    new Country{Name="CAYMAN ISLANDS",Code="KY"},
                    new Country{Name="CENTRAL AFRICAN REPUBLIC",Code="CF"},
                    new Country{Name="CHAD",Code="TD"},
                    new Country{Name="CHILE",Code="CL"},
                    new Country{Name="CHINA",Code="CN"},
                    new Country{Name="CHRISTMAS ISLAND",Code="CX"},
                    new Country{Name="COCOS (KEELING) ISLANDS",Code="CC"},
                    new Country{Name="COLOMBIA",Code="CO"},
                    new Country{Name="COMOROS",Code="KM"},
                    new Country{Name="CONGO",Code="CG"},
                    new Country{Name="CONGO, THE DEMOCRATIC REPUBLIC OF THE",Code="CD"},
                    new Country{Name="COOK ISLANDS",Code="CK"},
                    new Country{Name="COSTA RICA",Code="CR"},
                    new Country{Name="CÔTE D'IVOIRE",Code="CI"},
                    new Country{Name="CROATIA",Code="HR"},
                    new Country{Name="CUBA",Code="CU"},
                    new Country{Name="CURAÇAO",Code="CW"},
                    new Country{Name="CYPRUS",Code="CY"},
                    new Country{Name="CZECH REPUBLIC",Code="CZ"},
                    new Country{Name="DENMARK",Code="DK"},
                    new Country{Name="DJIBOUTI",Code="DJ"},
                    new Country{Name="DOMINICA",Code="DM"},
                    new Country{Name="DOMINICAN REPUBLIC",Code="DO"},
                    new Country{Name="ECUADOR",Code="EC"},
                    new Country{Name="EGYPT",Code="EG"},
                    new Country{Name="EL SALVADOR",Code="SV"},
                    new Country{Name="EQUATORIAL GUINEA",Code="GQ"},
                    new Country{Name="ERITREA",Code="ER"},
                    new Country{Name="ESTONIA",Code="EE"},
                    new Country{Name="ETHIOPIA",Code="ET"},
                    new Country{Name="FALKLAND ISLANDS (MALVINAS)",Code="FK"},
                    new Country{Name="FAROE ISLANDS",Code="FO"},
                    new Country{Name="FIJI",Code="FJ"},
                    new Country{Name="FINLAND",Code="FI"},
                    new Country{Name="FRANCE",Code="FR"},
                    new Country{Name="FRENCH GUIANA",Code="GF"},
                    new Country{Name="FRENCH POLYNESIA",Code="PF"},
                    new Country{Name="FRENCH SOUTHERN TERRITORIES",Code="TF"},
                    new Country{Name="GABON",Code="GA"},
                    new Country{Name="GAMBIA",Code="GM"},
                    new Country{Name="GEORGIA",Code="GE"},
                    new Country{Name="GERMANY",Code="DE"},
                    new Country{Name="GHANA",Code="GH"},
                    new Country{Name="GIBRALTAR",Code="GI"},
                    new Country{Name="GREECE",Code="GR"},
                    new Country{Name="GREENLAND",Code="GL"},
                    new Country{Name="GRENADA",Code="GD"},
                    new Country{Name="GUADELOUPE",Code="GP"},
                    new Country{Name="GUAM",Code="GU"},
                    new Country{Name="GUATEMALA",Code="GT"},
                    new Country{Name="GUERNSEY",Code="GG"},
                    new Country{Name="GUINEA",Code="GN"},
                    new Country{Name="GUINEA-BISSAU",Code="GW"},
                    new Country{Name="GUYANA",Code="GY"},
                    new Country{Name="HAITI",Code="HT"},
                    new Country{Name="HEARD ISLAND AND MCDONALD ISLANDS",Code="HM"},
                    new Country{Name="HOLY SEE (VATICAN CITY STATE)",Code="VA"},
                    new Country{Name="HONDURAS",Code="HN"},
                    new Country{Name="HONG KONG",Code="HK"},
                    new Country{Name="HUNGARY",Code="HU"},
                    new Country{Name="ICELAND",Code="IS"},
                    new Country{Name="INDIA",Code="IN"},
                    new Country{Name="INDONESIA",Code="ID"},
                    new Country{Name="IRAN, ISLAMIC REPUBLIC OF",Code="IR"},
                    new Country{Name="IRAQ",Code="IQ"},
                    new Country{Name="IRELAND",Code="IE"},
                    new Country{Name="ISLE OF MAN",Code="IM"},
                    new Country{Name="ISRAEL",Code="IL"},
                    new Country{Name="ITALY",Code="IT"},
                    new Country{Name="JAMAICA",Code="JM"},
                    new Country{Name="JAPAN",Code="JP"},
                    new Country{Name="JERSEY",Code="JE"},
                    new Country{Name="JORDAN",Code="JO"},
                    new Country{Name="KAZAKHSTAN",Code="KZ"},
                    new Country{Name="KENYA",Code="KE"},
                    new Country{Name="KIRIBATI",Code="KI"},
                    new Country{Name="KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF",Code="KP"},
                    new Country{Name="KOREA, REPUBLIC OF",Code="KR"},
                    new Country{Name="KUWAIT",Code="KW"},
                    new Country{Name="KYRGYZSTAN",Code="KG"},
                    new Country{Name="LAO PEOPLE'S DEMOCRATIC REPUBLIC",Code="LA"},
                    new Country{Name="LATVIA",Code="LV"},
                    new Country{Name="LEBANON",Code="LB"},
                    new Country{Name="LESOTHO",Code="LS"},
                    new Country{Name="LIBERIA",Code="LR"},
                    new Country{Name="LIBYA",Code="LY"},
                    new Country{Name="LIECHTENSTEIN",Code="LI"},
                    new Country{Name="LITHUANIA",Code="LT"},
                    new Country{Name="LUXEMBOURG",Code="LU"},
                    new Country{Name="MACAO",Code="MO"},
                    new Country{Name="MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF",Code="MK"},
                    new Country{Name="MADAGASCAR",Code="MG"},
                    new Country{Name="MALAWI",Code="MW"},
                    new Country{Name="MALAYSIA",Code="MY"},
                    new Country{Name="MALDIVES",Code="MV"},
                    new Country{Name="MALI",Code="ML"},
                    new Country{Name="MALTA",Code="MT"},
                    new Country{Name="MARSHALL ISLANDS",Code="MH"},
                    new Country{Name="MARTINIQUE",Code="MQ"},
                    new Country{Name="MAURITANIA",Code="MR"},
                    new Country{Name="MAURITIUS",Code="MU"},
                    new Country{Name="MAYOTTE",Code="YT"},
                    new Country{Name="MEXICO",Code="MX"},
                    new Country{Name="MICRONESIA, FEDERATED STATES OF",Code="FM"},
                    new Country{Name="MOLDOVA, REPUBLIC OF",Code="MD"},
                    new Country{Name="MONACO",Code="MC"},
                    new Country{Name="MONGOLIA",Code="MN"},
                    new Country{Name="MONTENEGRO",Code="ME"},
                    new Country{Name="MONTSERRAT",Code="MS"},
                    new Country{Name="MOROCCO",Code="MA"},
                    new Country{Name="MOZAMBIQUE",Code="MZ"},
                    new Country{Name="MYANMAR",Code="MM"},
                    new Country{Name="NAMIBIA",Code="NA"},
                    new Country{Name="NAURU",Code="NR"},
                    new Country{Name="NEPAL",Code="NP"},
                    new Country{Name="NETHERLANDS",Code="NL"},
                    new Country{Name="NEW CALEDONIA",Code="NC"},
                    new Country{Name="NEW ZEALAND",Code="NZ"},
                    new Country{Name="NICARAGUA",Code="NI"},
                    new Country{Name="NIGER",Code="NE"},
                    new Country{Name="NIGERIA",Code="NG"},
                    new Country{Name="NIUE",Code="NU"},
                    new Country{Name="NORFOLK ISLAND",Code="NF"},
                    new Country{Name="NORTHERN MARIANA ISLANDS",Code="MP"},
                    new Country{Name="NORWAY",Code="NO"},
                    new Country{Name="OMAN",Code="OM"},
                    new Country{Name="PAKISTAN",Code="PK"},
                    new Country{Name="PALAU",Code="PW"},
                    new Country{Name="PALESTINE, STATE OF",Code="PS"},
                    new Country{Name="PANAMA",Code="PA"},
                    new Country{Name="PAPUA NEW GUINEA",Code="PG"},
                    new Country{Name="PARAGUAY",Code="PY"},
                    new Country{Name="PERU",Code="PE"},
                    new Country{Name="PHILIPPINES",Code="PH"},
                    new Country{Name="PITCAIRN",Code="PN"},
                    new Country{Name="POLAND",Code="PL"},
                    new Country{Name="PORTUGAL",Code="PT"},
                    new Country{Name="PUERTO RICO",Code="PR"},
                    new Country{Name="QATAR",Code="QA"},
                    new Country{Name="RÉUNION",Code="RE"},
                    new Country{Name="ROMANIA",Code="RO"},
                    new Country{Name="RUSSIAN FEDERATION",Code="RU"},
                    new Country{Name="RWANDA",Code="RW"},
                    new Country{Name="SAINT BARTHÉLEMY",Code="BL"},
                    new Country{Name="SAINT HELENA, ASCENSION AND TRISTAN DA CUNHA",Code="SH"},
                    new Country{Name="SAINT KITTS AND NEVIS",Code="KN"},
                    new Country{Name="SAINT LUCIA",Code="LC"},
                    new Country{Name="SAINT MARTIN (FRENCH PART)",Code="MF"},
                    new Country{Name="SAINT PIERRE AND MIQUELON",Code="PM"},
                    new Country{Name="SAINT VINCENT AND THE GRENADINES",Code="VC"},
                    new Country{Name="SAMOA",Code="WS"},
                    new Country{Name="SAN MARINO",Code="SM"},
                    new Country{Name="SAO TOME AND PRINCIPE",Code="ST"},
                    new Country{Name="SAUDI ARABIA",Code="SA"},
                    new Country{Name="SENEGAL",Code="SN"},
                    new Country{Name="SERBIA",Code="RS"},
                    new Country{Name="SEYCHELLES",Code="SC"},
                    new Country{Name="SIERRA LEONE",Code="SL"},
                    new Country{Name="SINGAPORE",Code="SG"},
                    new Country{Name="SINT MAARTEN (DUTCH PART)",Code="SX"},
                    new Country{Name="SLOVAKIA",Code="SK"},
                    new Country{Name="SLOVENIA",Code="SI"},
                    new Country{Name="SOLOMON ISLANDS",Code="SB"},
                    new Country{Name="SOMALIA",Code="SO"},
                    new Country{Name="SOUTH AFRICA",Code="ZA"},
                    new Country{Name="SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS",Code="GS"},
                    new Country{Name="SOUTH SUDAN",Code="SS"},
                    new Country{Name="SPAIN",Code="ES"},
                    new Country{Name="SRI LANKA",Code="LK"},
                    new Country{Name="SUDAN",Code="SD"},
                    new Country{Name="SURINAME",Code="SR"},
                    new Country{Name="SVALBARD AND JAN MAYEN",Code="SJ"},
                    new Country{Name="SWAZILAND",Code="SZ"},
                    new Country{Name="SWEDEN",Code="SE"},
                    new Country{Name="SWITZERLAND",Code="CH"},
                    new Country{Name="SYRIAN ARAB REPUBLIC",Code="SY"},
                    new Country{Name="TAIWAN, PROVINCE OF CHINA",Code="TW"},
                    new Country{Name="TAJIKISTAN",Code="TJ"},
                    new Country{Name="TANZANIA, UNITED REPUBLIC OF",Code="TZ"},
                    new Country{Name="THAILAND",Code="TH"},
                    new Country{Name="TIMOR-LESTE",Code="TL"},
                    new Country{Name="TOGO",Code="TG"},
                    new Country{Name="TOKELAU",Code="TK"},
                    new Country{Name="TONGA",Code="TO"},
                    new Country{Name="TRINIDAD AND TOBAGO",Code="TT"},
                    new Country{Name="TUNISIA",Code="TN"},
                    new Country{Name="TURKEY",Code="TR"},
                    new Country{Name="TURKMENISTAN",Code="TM"},
                    new Country{Name="TURKS AND CAICOS ISLANDS",Code="TC"},
                    new Country{Name="TUVALU",Code="TV"},
                    new Country{Name="UGANDA",Code="UG"},
                    new Country{Name="UKRAINE",Code="UA"},
                    new Country{Name="UNITED ARAB EMIRATES",Code="AE"},
                    new Country{Name="UNITED KINGDOM",Code="GB"},
                    new Country{Name="UNITED STATES",Code="US"},
                    new Country{Name="UNITED STATES MINOR OUTLYING ISLANDS",Code="UM"},
                    new Country{Name="URUGUAY",Code="UY"},
                    new Country{Name="UZBEKISTAN",Code="UZ"},
                    new Country{Name="VANUATU",Code="VU"},
                    new Country{Name="VENEZUELA, BOLIVARIAN REPUBLIC OF",Code="VE"},
                    new Country{Name="VIETNAM",Code="VN"},
                    new Country{Name="VIRGIN ISLANDS, BRITISH",Code="VG"},
                    new Country{Name="VIRGIN ISLANDS, U.S.",Code="VI"},
                    new Country{Name="WALLIS AND FUTUNA",Code="WF"},
                    new Country{Name="WESTERN SAHARA",Code="EH"},
                    new Country{Name="YEMEN",Code="YE"},
                    new Country{Name="ZAMBIA",Code="ZM"},
                    new Country{Name="ZIMBABWE",Code="ZW"}
                };
                context.Countries.AddOrUpdate(
                  c => new { c.Name, c.Code }, countries.ToArray());
                context.SaveChanges();
            }
            if (context.States.Count() == 0)
            {
                var states = new List<State>{
                    new State{Code="AL",Name="Alabama",CountryId=236},
                    new State{Code="AK",Name="Alaska",CountryId=236},
                    new State{Code="AZ",Name="Arizona",CountryId=236},
                    new State{Code="AR",Name="Arkansas",CountryId=236},
                    new State{Code="CA",Name="California",CountryId=236},
                    new State{Code="CO",Name="Colorado",CountryId=236},
                    new State{Code="CT",Name="Connecticut",CountryId=236},
                    new State{Code="DE",Name="Delaware",CountryId=236},
                    new State{Code="FL",Name="Florida",CountryId=236},
                    new State{Code="GA",Name="Georgia",CountryId=236},
                    new State{Code="HI",Name="Hawaii",CountryId=236},
                    new State{Code="ID",Name="Idaho",CountryId=236},
                    new State{Code="IL",Name="Illinois",CountryId=236},
                    new State{Code="IN",Name="Indiana",CountryId=236},
                    new State{Code="IA",Name="Iowa",CountryId=236},
                    new State{Code="KS",Name="Kansas",CountryId=236},
                    new State{Code="KY",Name="Kentucky",CountryId=236},
                    new State{Code="LA",Name="Louisiana",CountryId=236},
                    new State{Code="ME",Name="Maine",CountryId=236},
                    new State{Code="MD",Name="Maryland",CountryId=236},
                    new State{Code="MA",Name="Massachusetts",CountryId=236},
                    new State{Code="MI",Name="Michigan",CountryId=236},
                    new State{Code="MN",Name="Minnesota",CountryId=236},
                    new State{Code="MS",Name="Mississippi",CountryId=236},
                    new State{Code="MO",Name="Missouri",CountryId=236},
                    new State{Code="MT",Name="Montana",CountryId=236},
                    new State{Code="NE",Name="Nebraska",CountryId=236},
                    new State{Code="NV",Name="Nevada",CountryId=236},
                    new State{Code="NH",Name="New Hampshire",CountryId=236},
                    new State{Code="NJ",Name="New Jersey",CountryId=236},
                    new State{Code="NM",Name="New Mexico",CountryId=236},
                    new State{Code="NY",Name="New York",CountryId=236},
                    new State{Code="NC",Name="North Carolina",CountryId=236},
                    new State{Code="ND",Name="North Dakota",CountryId=236},
                    new State{Code="OH",Name="Ohio",CountryId=236},
                    new State{Code="OK",Name="Oklahoma",CountryId=236},
                    new State{Code="OR",Name="Oregon",CountryId=236},
                    new State{Code="PA",Name="Pennsylvania",CountryId=236},
                    new State{Code="RI",Name="Rhode Island",CountryId=236},
                    new State{Code="SC",Name="South Carolina",CountryId=236},
                    new State{Code="SD",Name="South Dakota",CountryId=236},
                    new State{Code="TN",Name="Tennessee",CountryId=236},
                    new State{Code="TX",Name="Texas",CountryId=236},
                    new State{Code="UT",Name="Utah",CountryId=236},
                    new State{Code="VT",Name="Vermont",CountryId=236},
                    new State{Code="VA",Name="Virginia",CountryId=236},
                    new State{Code="WA",Name="Washington",CountryId=236},
                    new State{Code="WV",Name="West Virginia",CountryId=236},
                    new State{Code="WI",Name="Wisconsin",CountryId=236},
                    new State{Code="WY",Name="Wyoming",CountryId=236},
                    new State{Code="DC",Name="Washington DC",CountryId=236},
                    new State{Code="AB",Name="Alberta",CountryId=236},
                    new State{Code="BC",Name="British Columbia",CountryId=236},
                    new State{Code="MB",Name="Manitoba",CountryId=236},
                    new State{Code="NB",Name="New Brunswick",CountryId=236},
                    new State{Code="NL",Name="Newfoundland and Labrador",CountryId=236},
                    new State{Code="NS",Name="Nova Scotia",CountryId=236},
                    new State{Code="ON",Name="Ontario",CountryId=236},
                    new State{Code="PE",Name="Prince Edward Island",CountryId=236},
                    new State{Code="QC",Name="Quebec",CountryId=236},
                    new State{Code="SK",Name="Saskatchewan",CountryId=236}
                };
                context.States.AddOrUpdate(
                  c => new { c.Name, c.Code }, states.ToArray());
                context.SaveChanges();
            }
#endif
        }
    }
}
