# AmbientRouteValuesRepro

This is a repro project to investigate oddities in how ambient route values handled across different .net versions.

## Instructions to compare oddities

1. Go to russian culture `/ru`
2. Review destination URLs for each link below

#### You'll note:
- .NET 2.1 adds culture to both the default and custom routes specified in Startup.cs.
- .NET 3.1 only adds culture to the default route, however custom routes do not pick up ambient route values.
