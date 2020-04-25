using System;

public class CountryModel
{
    public Data data { get; set; }
    public bool _cacheHit { get; set; }
}

public class Data
{
    public CoordinatesModel coordinates { get; set; }
    public string name { get; set; }
    public string code { get; set; }
    public int? population { get; set; }
    public DateTime updated_at { get; set; }
    public TodayModel today { get; set; }
    public Latest_DataModel latest_data { get; set; }
    public TimelineModel[] timeline { get; set; }
}

public class CoordinatesModel
{
    public double? latitude { get; set; } = 0.0;
    public double? longitude { get; set; } = 0.0;
}

public class TodayModel
{
    public int? deaths { get; set; }
    public int? confirmed { get; set; }
}

public class Latest_DataModel
{
    public int? deaths { get; set; }
    public int? confirmed { get; set; }
    public int? recovered { get; set; }
    public int? critical { get; set; }
    public Calculated calculated { get; set; }
}

public class Calculated
{
    public float? death_rate { get; set; }
    public float? recovery_rate { get; set; }
    public object recovered_vs_death_ratio { get; set; }
    public float? cases_per_million_population { get; set; }
}

public class TimelineModel
{
    public DateTime updated_at { get; set; }
    public string date { get; set; }
    public int deaths { get; set; }
    public int confirmed { get; set; }
    public int active { get; set; }
    public int recovered { get; set; }
    public int new_confirmed { get; set; }
    public int new_recovered { get; set; }
    public int new_deaths { get; set; }
    public bool is_in_progress { get; set; }
}

