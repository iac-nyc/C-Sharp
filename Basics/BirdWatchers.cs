birds.SelectMany(b => b.Sightings).Select(s => s.Place.Country);

birds.SelectMany(b => b.Sightings).Select(s => s.Place.Country).Distinct();
