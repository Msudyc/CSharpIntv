/* Question 8.4
 
Design a parking lot using OOP. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter08_Q04
    {
        public enum VehicleSize
        {
            Motorcycle = 0,
            Compact = 1,
            Large = 2
        }

        public class Vehicle
        {
            public VehicleSize Size { get; set; }
            public List<ParkingSpot> ParkingSpots { get; set; }
            protected int SpotsNeeded { get; set; }

            public void ParkInSpot(ParkingSpot spot)
            {
            }

            public void ClearSpot()
            {
            }

            public virtual bool CanFitInSpot(ParkingSpot spot)
            {
                return spot.CanFitVehicle(this);
            }
        }

        public class Bus : Vehicle
        {
            public Bus()
            {
                this.SpotsNeeded = 5;
                this.Size = VehicleSize.Large;
            }

            public override bool CanFitInSpot(ParkingSpot spot)
            {
                throw new NotImplementedException();
            }
        }

        public class Car : Vehicle
        {
            public Car()
            {
                this.SpotsNeeded = 1;
                this.Size = VehicleSize.Compact;
            }
        }

        public class Motorcycle : Vehicle
        {
            public Motorcycle()
            {
                this.SpotsNeeded = 1;
                this.Size = VehicleSize.Motorcycle;
            }
        }

        public class ParkingLot
        {
            private List<Level> levels = new List<Level>();
            public bool ParkVehicle(Vehicle v)
            {
                throw new NotImplementedException();
            }
        }

        public class Level
        {            
            private List<ParkingSpot> spots = new List<ParkingSpot>();
            private int availableSpots = 100;
            private const int SpotsPerRow = 10;

            public int Floor { get; set; }

            public int GetAvailableSpots()
            {
                return this.availableSpots;
            }

            public bool ParkVehicle(Vehicle v)
            {
                this.availableSpots--;
                throw new NotImplementedException();
            }

            public void SpotFreed()
            {
                throw new NotImplementedException();
            }

            private int FindAvailableSpots(Vehicle v)
            {
                throw new NotImplementedException();
            }
        }

        public class ParkingSpot
        {
            private Vehicle vehicle;
            private VehicleSize spotSize;
            private int row;
            private int spotNumber;
            private Level level;

            public ParkingSpot(
                Level lvl,
                int r,
                int n,
                VehicleSize size)
            {
                this.level = lvl;
                this.row = r;
                this.spotNumber = n;
                this.spotSize = size;
            }

            public bool IsAvailable()
            {
                return this.vehicle == null;
            }

            public bool CanFitVehicle(Vehicle v)
            {
                throw new NotImplementedException();
            }

            public bool Park(Vehicle v)
            {
                this.vehicle = v;
                throw new NotImplementedException();
            }

            public int GetRow()
            {
                return this.row;
            }

            public int GetSpotNumber()
            {
                return this.spotNumber;
            }

            public void RemoveVehicle()
            {
            }
        }        
    }
}
