﻿namespace hsdc.dpt.Control.DTO.Creational.FactoryMethod
{
    public class Pushpin : ILocationMarker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
    }
}