
string? name = null;
int? id = null;
bool status = default;
Console.WriteLine(status);
bool? gateQualified = null;
if (gateQualified == true)
{
    Console.WriteLine("GateQualified");
}
else if(gateQualified == false)
{
    Console.WriteLine("GateNotQualified");
}
else
{
    Console.WriteLine("Data not filled");
}
