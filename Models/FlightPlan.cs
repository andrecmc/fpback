using System;

public class FlightPlan
{
    public long Id { get; set; }
    public string FlightNumber { get; set; }
    public string AircraftType { get; set; }
    public string AircraftPrefix { get; set; }
    public string FromAirport { get; set; }
    public string ToAirport { get; set; }
    public DateTime FlightDateTime { get; set; }
}