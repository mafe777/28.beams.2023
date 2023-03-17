namespace beam.logic
{
    public class MyBeams
    {
        private readonly string _beam;
        public MyBeams(string beam)
        {
            _beam = beam;
        }
        public bool isvalidbeam(string _beam)
        {
            char bas = _beam[0];
            if (bas != '%' && bas != '&' && bas != '#')
            {
                throw new ArgumentException("the beam is poorly built");
            }

            int conection = 0;
            int size = _beam.Length;

            for (int i = 1; i < size; i++)
            {
                char next = _beam[i];
                if (next != '=' && next != '*')
                {
                    throw new ArgumentException("the beam is poorly built");
                }
                if (next == '*')
                {
                    conection++;
                }
                else
                {
                    conection = 0;
                }
                if (conection == 2)
                {
                    throw new ArgumentException("the beam is poorly built");
                }
            }
            throw new ArgumentException("the beam is well built");
        }

        public bool supportsweight(string _beam)
        {
            char bas = _beam[0];
            int size = _beam.Length;

            int totalbeam = 0;
            int totalsegment = 0;

            for (int i = 1; i < size; i++)
            {
                char next = _beam[i];

                if (next == '=')
                {
                    totalsegment++;
                }
                else
                {
                    totalbeam += totalsegment * 3;
                    totalsegment = 0;
                }
            }
            totalbeam += totalsegment;

            int beamweight = 0;

            if (bas == '%')
            {
                beamweight = 10;
            }
            if (bas == '&')
            {
                beamweight = 30;
            }
            if (bas == '#')
            {
                beamweight = 90;
            }
            if (totalbeam >= beamweight)
            {
                throw new ArgumentException("the beam does NOT supports the weight");

            }

            throw new ArgumentException("the beam supports the weight");
        }


    }
}