using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anatoly.Buildings
{
    class BuildingDescription
    {
        private int _id;
        private int _height;
        private int _flatsCount;
        private byte _floorsCount;
        private byte _porchCount;

        private static int _idCounter;

        private BuildingDescription() : this(0)
        {
        }


        private BuildingDescription(int height) : this(height, 0)
        {
        }

        private BuildingDescription(int height, int flatsCount) : this(height, flatsCount, 0)
        {
        }

        private BuildingDescription(
            int height,
            int flatsCount,
            byte floorsCount) : this(height, flatsCount, floorsCount, 0)
        {
        }

        private BuildingDescription(
            int height,
            int flatsCount,
            byte floorsCount,
            byte porchCount)
        {
            IncrementID();
            _id = _idCounter;
            _height = height;
            _flatsCount = flatsCount;
            _floorsCount = floorsCount;
            _porchCount = porchCount;

        }

        public void SetAllFields(int height, int flatsCount, byte floorsCount, byte porchCount)
        {
            _height = height;
            _flatsCount = flatsCount;
            _floorsCount = floorsCount;
            _porchCount = porchCount;
        }

        public void ShowAllFields()
        {
            Console.WriteLine($"ID: {_id}\nHeight: {_height}\nCount of flats: {_flatsCount}\n" +
                $"Count of floors: {_floorsCount}\nCount of porchs: {_porchCount} ");
        }

        public int GetID() => _id;

        public int GetFloorHeight() => (_floorsCount == 0) ? -1 : _height / _floorsCount;

        public int FlatsInPorch() => (_porchCount == 0) ? -1 : _flatsCount / _porchCount;

        public int FlatsOnFloor() => (_floorsCount==0)? -1: FlatsInPorch()/_floorsCount;

        private void IncrementID() => _idCounter++;




        class Creator
        {
            private static Hashtable _buildings = new Hashtable();

            private Creator()
            {

            }

            public static BuildingDescription CreateBuilding(int height, int flatsCount, byte floorsCount, byte porchCount)
            {
                BuildingDescription newBuilding = new BuildingDescription(height, flatsCount, floorsCount, porchCount);
                _buildings.Add(newBuilding.GetID(), newBuilding);
                return newBuilding;
            }

            public static void DeleteBuilding(int id) => _buildings.Remove(id);


        }

    }
}
