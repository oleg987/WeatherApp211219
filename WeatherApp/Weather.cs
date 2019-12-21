using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Weather
    {
        int minTemp;
        int maxTemp;
        int directionValue;
        Dictionary.Direction direction;
        int precipitationValue;
        Dictionary.Precipitation precipitationType;

        public int MinTemp { get => minTemp; set => minTemp = value; }
        public int MaxTemp { get => maxTemp; set => maxTemp = value; }
        public int DirectionValue { 
            get => directionValue; 
            set => directionValue = (value > 360 || value < 0) ? throw new Exception("Wrong direction") : value; }
        public int PrecipitationValue
        { 
            get => precipitationValue; 
            set => precipitationValue = (value < 0) ? throw new Exception("Wrong precipitation value") : value ; }
        internal Dictionary.Direction Direction { get => direction; set => direction = value; }
        internal Dictionary.Precipitation PrecipitationType { get => precipitationType; set => precipitationType = value; }

        public Weather()
        { }

        public Weather(
            int minTemp, 
            int maxTemp, 
            int directionValue, 
            int precipitationValue, 
            string precipitationType = "")
        {
            MinTemp = minTemp;
            MaxTemp = maxTemp;
            DirectionValue = directionValue;

            if (directionValue > 315 || directionValue <= 45)
            {
                Direction = Dictionary.Direction.N;
            }
            else if(directionValue > 45 || directionValue <= 135)
            {
                Direction = Dictionary.Direction.E;
            }
            else if (directionValue > 135 || directionValue <= 225)
            {
                Direction = Dictionary.Direction.S;
            }
            else if (directionValue > 225 || directionValue <= 315)
            {
                Direction = Dictionary.Direction.W;
            }

            PrecipitationValue = precipitationValue;

            switch (precipitationType.ToLower())
            {
                case "r":
                case "rain":
                    PrecipitationType = Dictionary.Precipitation.Rain;
                    break;
                case "s":
                case "snow":
                    PrecipitationType = Dictionary.Precipitation.Snow;
                    break;
                default:
                    PrecipitationType = Dictionary.Precipitation.Undefined;
                    break;
            }
        }

        public override string ToString()
        {
            return
                $"Temerature: {MinTemp} - {MaxTemp}\n" +
                $"Wind: {Direction}\n" +
                $"Precipitations: {PrecipitationType} {PrecipitationValue}mm\n";
        }
    }
}
