birds.SelectMany(b => b.Sightings).Select(s => s.Place.Country);

birds.SelectMany(b => b.Sightings).Select(s => s.Place.Country).Distinct();

birds.SelectMany(b => b.Sightings).GroupBy(s => s.Place.Country).Select(grp => new { Country = grp.Key, Sightings = grp.Count()});
