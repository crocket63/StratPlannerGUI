using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class SimParameters
    {
        public int totalRaceLaps   =47;
        public int trackLenght_m   =6600;

        public double[] paramWeightCurve   = { 1, 2, 3 };
        public double[] paramWeightLaptime = { 4, 5, 6 };

        public double[] paramTireWearCurve = { 7, 8, 9 };
        public double[] paramTireLapFactor = { 10, 11, 12 };

        public double fuelCons = 1.9;

        public double[] pitStrategy1 = { 30 };
        public double[] pitStrategy2 = { 15, 28 };
        public double[] pitStrategy3 = { 8, 28, 33 };

        public SimParameters()
        {

        }

        public void LoadSavedParams()
        {
            System.Xml.Serialization.XmlSerializer deserializer = new System.Xml.Serialization.XmlSerializer(typeof(SimParameters));


            System.IO.StreamReader lecteur = new System.IO.StreamReader("Params.xml");
            if (lecteur == null)
                return;

            SimParameters p = (SimParameters)deserializer.Deserialize(lecteur);
            lecteur.Close();


            this.totalRaceLaps = p.totalRaceLaps;
            this.trackLenght_m = p.trackLenght_m;

            this.paramWeightCurve = p.paramWeightCurve;
            this.paramWeightLaptime = p.paramWeightLaptime;

            this.paramTireWearCurve = p.paramTireWearCurve;
            this.paramTireLapFactor = p.paramTireLapFactor;

            this.fuelCons = p.fuelCons;

            this.pitStrategy1 = p.pitStrategy1;
            this.pitStrategy2 = p.pitStrategy2;
            this.pitStrategy3 = p.pitStrategy3;
            
        }

        public void SaveToFile()
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(SimParameters));
            System.IO.StreamWriter ecrivain = new System.IO.StreamWriter("Params.xml", false);

            //On sérialise en spécifiant le flux d'écriture et l'objet à sérialiser.
            serializer.Serialize(ecrivain,this );

            //IMPORTANT : On ferme le flux en tous temps !!!
            ecrivain.Close();
        }
    }
}
