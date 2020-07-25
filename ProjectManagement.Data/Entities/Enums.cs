using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Data.Entities
{
    public class Enums
    {
        public enum State
        {
            [Display(Name = "Alabama")]
            Alabama = 1,
            [Display(Name = "Alaska")]
            Alaska,
            [Display(Name = "Arizona")]
            Arizona,
            [Display(Name = "Arkansas")]
            Arkansas,
            [Display(Name = "California")]
            California,
            [Display(Name = "Colorado")]
            Colorado,
            [Display(Name = "Connecticut")]
            Connecticut,
            [Display(Name = "Delaware")]
            Delaware,
            [Display(Name = "Florida")]
            Florida,
            [Display(Name = "Georgia")]
            Georgia,
            [Display(Name = "Hawaii")]
            Hawaii,
            [Display(Name = "Idaho")]
            Idaho,
            [Display(Name = "Illinois")]
            Illinois,
            [Display(Name = "Indiana")]
            Indiana,
            [Display(Name = "Iowa")]
            Iowa,
            [Display(Name = "Kansas")]
            Kansas,
            [Display(Name = "Kentucky")]
            Kentucky,
            [Display(Name = "Louisiana")]
            Louisiana,
            [Display(Name = "Maine")]
            Maine,
            [Display(Name = "Maryland")]
            Maryland,
            [Display(Name = "Massachusetts")]
            Massachusetts,
            [Display(Name = "Michigan")]
            Michigan,
            [Display(Name = "Minnesota")]
            Minnesota,
            [Display(Name = "Mississippi")]
            Mississippi,
            [Display(Name = "Missouri")]
            Missouri,
            [Display(Name = "Montana")]
            Montana,
            [Display(Name = "Nebraska")]
            Nebraska,
            [Display(Name = "Nevada")]
            Nevada,
            [Display(Name = "New Hampshire")]
            NewHampshire,
            [Display(Name = "New Jersey")]
            NewJersey,
            [Display(Name = "New Mexico")]
            NewMexico,
            [Display(Name = "New York")]
            NewYork,
            [Display(Name = "North Carolina")]
            NorthCarolina,
            [Display(Name = "North Dakoa")]
            NorthDakota,
            [Display(Name = "Ohio")]
            Ohio,
            [Display(Name = "Oklahoma")]
            Oklahoma,
            [Display(Name = "Oregon")]
            Oregon,
            [Display(Name = "Pennsylvania")]
            Pennsylvania,
            [Display(Name = "Rhode Island")]
            RhodeIsland,
            [Display(Name = "South Carolina")]
            SouthCarolina,
            [Display(Name = "South Dakota")]
            SouthDakota,
            [Display(Name = "Tennessee")]
            Tennessee,
            [Display(Name = "Texas")]
            Texas,
            [Display(Name = "Utah")]
            Utah,
            [Display(Name = "Vermont")]
            Vermont,
            [Display(Name = "Virginia")]
            Virginia,
            [Display(Name = "Washington")]
            Washington,
            [Display(Name = "West Virginia")]
            WestVirginia,
            [Display(Name = "Wisconsin")]
            Wisconsin,
            [Display(Name = "Wyoming")]
            Wyoming
        }

        public enum Equipment
        {
            [Display(Name = "Code 3")]
            Code3 =1,
            [Display(Name = "Federal Signal")]
            FederalSignal,
            [Display(Name = "Fenix")]
            Fenix,
            [Display(Name = "SoundOff Signal")]
            SoundoffSignal,
            [Display(Name = "Whelen Engineering")]
            Whelen
        }

        public enum Vehicle
        {
            [Display(Name = "Chevrolet Silverado")]
            ChevySilverado = 1,
            [Display(Name = "Chevrolet Silverado PPV")]
            ChevySilveradoPPV,
            [Display(Name = "Chevrolet Tahoe")]
            ChevyTahoe,
            [Display(Name = "Chevrolet Tahoe PPV")]
            ChevyTahoePPV,
            [Display(Name = "Dodge Charger Pursuit")]
            DodgeChargerPursuit,
            [Display(Name = "Dodge Durango Pursuit")]
            DodgeDurangoPursuit,
            [Display(Name = "Ford Explorer")]
            FordExplorer,
            [Display(Name = "Ford F-150")]
            FordF150,
            [Display(Name = "Ford F-150 Responder")]
            FordF150Responder,
            [Display(Name = "Ford F-250")]
            FordF250,
            [Display(Name = "Ford F-350")]
            FordF350,
            [Display(Name = "Ford Interceptor Utility")]
            FordInterceptorUtility,
            [Display(Name = "Ram 1500")]
            Ram1500,
            [Display(Name = "Ram 1500 SSV")]
            Ram1500SSV,
            [Display(Name = "Ram 2500")]
            Ram2500,
            [Display(Name = "Ram 2500 SSV")]
            Ram2500SSV,
            [Display(Name = "Ram 3500")]
            Ram3500,
            [Display(Name = "Ram 3500 SSV")]
            Ram3500SSV
        }

        public enum CustomerType
        {
            [Display(Name = "Construction")]
            Construction = 1,
            [Display(Name = "EMS")]
            EMS,
            [Display(Name = "Fire")]
            Fire,
            [Display(Name = "Police")]
            Police,
            [Display(Name = "Private Security")]
            PrivateSecurity,
            [Display(Name = "Towing/Recovery")]
            Towing
        }
    }
}
