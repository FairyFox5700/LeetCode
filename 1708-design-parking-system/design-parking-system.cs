    public class ParkingSystem
    {
        private int[] _array;
        public ParkingSystem(int big, int medium, int small)
        {
            _array = new int[3];
            _array[0] = big;
            _array[1] = medium;
            _array[2] = small;
        }

        public bool AddCar(int carType)
        {
            if (_array[carType - 1] > 0)
            {
                _array[carType-1]--;
                return true;
            }
            return false;
        }
    }