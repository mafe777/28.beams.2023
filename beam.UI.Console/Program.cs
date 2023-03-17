using beam.logic;

try
{
    Console.Write("Enter the beam: ");
    var beam = Console.ReadLine();

    var myBeam = new MyBeams(beam);
    myBeam.isvalidbeam(beam);
    myBeam.supportsweight(beam);

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}